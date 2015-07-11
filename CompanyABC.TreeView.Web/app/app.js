angular.module('app.tree-view', ['ngRoute', 'ui.bootstrap'])

angular.module('app.tree-view')
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $locationProvider.html5Mode(true);

        $routeProvider
            .when('/', {
                templateUrl: '/app/views/about.html',
                controller: 'aboutController'
            })
            .when('/tree/:treeDepth', {
                templateUrl: '/app/views/tree.html',
                controller: 'treeController'
            });
    }]);
