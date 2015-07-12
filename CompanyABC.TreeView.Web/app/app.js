angular.module('app.tree-view', ['ngRoute', 'ui.bootstrap', 'app.tree-view.partials'])

angular.module('app.tree-view')
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $locationProvider.html5Mode(true);
        
        $routeProvider
            .when('/', {
                templateUrl: '/partials/views/about.html',
                controller: 'aboutController'
            })
            .when('/tree/:treeDepth?', {
                templateUrl: '/partials/views/tree.html',
                controller: 'treeController'
            });
    }]);
