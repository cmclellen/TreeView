angular
    .module('app.tree-view')
    .factory('treeNodeService', ['$http', '$q', '$window', function ($http, $q, $window) {

        var urlPrefix = $window.myApp.constants.urlPrefix + 'api/treeNode';

        function getAll() {
            var url = urlPrefix + '/';
            
            var deferred = $q.defer();
            $http.get(url)
                .success(function (response) {
                    deferred.resolve(response);
                })
                .error(function (msg, code) {
                    deferred.reject(msg);
                });
            return deferred.promise;
        }

        return {
            getAll: getAll
        };
    }]);