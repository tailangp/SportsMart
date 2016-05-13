angular.module('app', [
    'ngRoute',
    'app.home.ctrl',
    'app.contact.ctrl',
    'app.about.ctrl',
    'app.product.ctrl',
    'app.service'
])
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        // Specify the three simple routes ('/', '/About', and '/Contact')
        $routeProvider.when('/', {
            templateUrl: 'content/app/home/home.html',
            controller: 'home',
        })
            .when('/about', {
            templateUrl: 'content/app/home/about.html',
            controller: 'about',
        })
            .when('/contact', {
            templateUrl: 'content/app/home/contact.html',
            controller: 'contact'
        })
            .when('/product', {
            templateUrl: 'content/app/product/products.html',
            controller: 'contact'
        })
            .otherwise({
            templateUrl: 'content/app/home/home.html',
            controller: 'home',
        });
        // Specify HTML5 mode (using the History APIs) or HashBang syntax.
        $locationProvider.html5Mode(false).hashPrefix('!');
    }])
    .run(function ($rootScope) {
    //set Base Address
    $rootScope.apiBaseAddress = 'api';
});

angular
    .module('app.service', [])
    .factory('appservice', ['$http', '$rootScope', function ($http, $rootscope) {
        return {
            getAll: function (apiName) {
                return $http({
                    method: 'GET',
                    url: $rootscope.apiBaseAddress + '/' + apiName
                });
            },
            getByActionName: function (apiName, actionName, id) {
                return $http({
                    method: 'GET',
                    url: $rootscope.apiBaseAddress + '/' + apiName + '/' + actionName + '/' + id
                });
            },
            createNew: function (apiName, model) {
                return $http({
                    method: 'POST',
                    url: $rootscope.apiBaseAddress + '/' + apiName,
                    data: JSON.stringify(model)
                });
            },
            getSingle: function (apiName, id) {
                return $http({
                    method: 'GET',
                    url: $rootscope.apiBaseAddress + '/' + apiName + '/' + id
                });
            },
            updateSingle: function (apiName, id, model) {
                return $http({
                    method: 'PUT',
                    url: $rootscope.apiBaseAddress + '/' + apiName + '/' + id,
                    data: JSON.stringify(model)
                });
            },
            deleteSingle: function (apiName, id) {
                return $http({
                    method: 'DELETE',
                    url: $rootscope.apiBaseAddress + '/' + apiName + '/' + id
                });
            }
        };
    }]);

angular
    .module('app.product.ctrl', [])
    .controller('product', ['$scope', '$http', 'appservice', function ($scope, $http, appservice) {
        $scope.name = "Product";
        $scope.apiname = "Product/GetProducts";
        appservice.getAll($scope.apiname).success(function (data) {
            $scope.products = data;
        });
        //    $scope.products = [
        //        { "id": "1", "name": "John", "price": "12.3" },
        //        { "id": "2", "name": "John", "price": "12.3" },
        //        { "id": "3", "name": "John", "price": "12.3" },
        //        { "id": "4", "name": "John", "price": "12.3" },
        //        { "id": "5", "name": "John", "price": "12.3" },
        //        { "id": "6", "name": "John", "price": "12.3" }];
        //}]
    }]);

angular
    .module('app.about.ctrl', [])
    .controller('about', ['$scope', function ($scope) {
        $scope.name = "About";
    }]);

angular
    .module('app.contact.ctrl', [])
    .controller('contact', ['$scope', function ($scope) {
        $scope.name = "Contact";
    }]);

angular
    .module('app.home.ctrl', [])
    .controller('home', ['$scope', function ($scope) {
        $scope.name = "World";
    }]);

//# sourceMappingURL=app.js.map
