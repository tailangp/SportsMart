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
        $routeProvider.when('/',{
                templateUrl: 'content/app/components/home/home.html',
                controller: 'home',
            })
            .when('/about',{
                templateUrl: 'content/app/components/home/about.html',
                controller: 'about',
            })
            .when('/contact', {
                templateUrl: 'content/app/components/home/contact.html',
                controller: 'contact'
            })
            .when('/product', {
                templateUrl: 'content/app/components/product/products.html',
                controller: 'contact'
            })
            .otherwise({
                templateUrl: 'content/app/components/home/home.html',
                controller: 'home',
            });


        // Specify HTML5 mode (using the History APIs) or HashBang syntax.
        $locationProvider.html5Mode(false).hashPrefix('!');

    }])
    .run(function ($rootScope) {
        //set Base Address
        $rootScope.apiBaseAddress = 'api';
    });