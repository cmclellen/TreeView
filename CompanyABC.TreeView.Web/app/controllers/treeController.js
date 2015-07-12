angular
    .module('app.tree-view')
    .controller('treeController', ['$scope', '$routeParams', 'treeNodeService', function ($scope, $routeParams, treeNodeService) {

        angular.extend($scope, {
            uiState: {
                treeNodes: null,
                depth: parseInt($routeParams.treeDepth, 10)
            }
        });
        
        function init() {
            var uiState = $scope.uiState;
            treeNodeService.getAll()
                .then(function (response) {                    
                    uiState.treeNodes = response;
                });
        }
        init();
    }]);