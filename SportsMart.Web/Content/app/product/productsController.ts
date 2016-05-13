angular
    .module('app.product.ctrl', [])
    .controller('product', ['$scope','$http','appservice', function ($scope,$http,appservice) {
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
