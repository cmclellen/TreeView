angular.module('app.tree-view', ['ngRoute', 'ui.bootstrap'])

angular.module('app.tree-view')
    .config(function ($routeProvider) {

        $routeProvider
            // route for the home page
            .when('/', {
                templateUrl: '/app/views/about.html',
                controller: 'aboutController'
            })
            .when('/tree/:treeDepth', {
                templateUrl: '/app/views/tree.html',
                controller: 'treeController'
            });
        //// route for the about page
        //.when('/about', {
        //    templateUrl : 'pages/about.html',
        //    controller  : 'aboutController'
        //})
        //// route for the contact page
        //.when('/contact', {
        //    templateUrl : 'pages/contact.html',
        //    controller  : 'contactController'
        //});
    });
