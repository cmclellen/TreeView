angular
    .module('app.tree-view')
    .controller('aboutController', ['$scope', '$window', function ($scope, $window) {
                
        angular.extend($scope, {
            uiState: {
                name: "about Controller",
                sampleTreeViewUrl: $window.myApp.constants.urlAuthority + '/tree/2',
                webProjStartActionImagePath: $window.myApp.constants.urlPrefix + 'docs/assets/WebProjStartAction.png'
            }
        });

    }]);
