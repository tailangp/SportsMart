angular
    .module('app.service', [])
    .factory('appservice', ['$http','$rootScope', function ($http,$rootscope) {
        return {
            getAll: function (apiName) {
                return $http({
                    method: 'GET',
                    url:  $rootscope.apiBaseAddress + '/' + apiName
                });
            },
            getByActionName: function (apiName, actionName, id) {
                return $http({
                    method: 'GET',
                    url:  $rootscope.apiBaseAddress + '/' + apiName + '/' + actionName + '/' + id
                });
            },
            createNew: function (apiName, model) {
                return $http({
                    method: 'POST',
                    url:  $rootscope.apiBaseAddress + '/' + apiName,
                    data: JSON.stringify(model)
                });
            },
            getSingle: function (apiName, id) {
                return $http({
                    method: 'GET',
                    url:  $rootscope.apiBaseAddress + '/' + apiName + '/' + id
                });
            },
            updateSingle: function (apiName, id, model) {
                return $http({
                    method: 'PUT',
                    url:  $rootscope.apiBaseAddress + '/' + apiName + '/' + id,
                    data: JSON.stringify(model)
                });
            },
            deleteSingle: function (apiName, id) {
                return $http({
                    method: 'DELETE',
                    url:  $rootscope.apiBaseAddress + '/' + apiName + '/' + id
                });
            }
        };
    }]);
