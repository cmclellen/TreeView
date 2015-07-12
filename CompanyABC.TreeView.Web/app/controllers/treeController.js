angular
    .module('app.tree-view')
    .controller('treeController', ['$scope', '$routeParams', 'treeNodeService', function ($scope, $routeParams, treeNodeService) {
        
        angular.extend($scope, {

            // ui state
            uiState: {
                treeNodes: null,
                depth: parseInt($routeParams.treeDepth, 10) || 0
            },

            // functions
            isLoading: function () {
                var uiState = $scope.uiState;
                return uiState.treeNodes === null;
            },

            canShowTree: function () {
                var uiState = $scope.uiState;
                return uiState.depth > 0;
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