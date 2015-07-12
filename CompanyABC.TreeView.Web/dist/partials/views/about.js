(function(module) {
try {
  module = angular.module('app.tree-view.partials');
} catch (e) {
  module = angular.module('app.tree-view.partials', []);
}
module.run(['$templateCache', function($templateCache) {
  $templateCache.put('/partials/views/about.html',
    '<div class="jumbotron">\n' +
    '    <ul class="list-unstyled">\n' +
    '        <li>\n' +
    '            <h3>Overview</h3>\n' +
    '            <p>This ASP.NET MVC web application renders a tree structure to a depth specified by either the query string or the provided numeric input.</p>\n' +
    '            <p>I\'ve used Visual Studio 2012 along with ASP.NET MVC5 and AngularJs 1.4 (for it\'s ease of keeping concerns separate by providing an MVVM type pattern) to develop this application.</p>\n' +
    '        </li>\n' +
    '        <li>\n' +
    '            <h3>Prerequisites to run the application</h3>\n' +
    '            <ul>\n' +
    '                <li>Visual Studio 2012/2013/2015 (I haven\'t tested it in VS 2013 or 2015, as I haven\'t downloaded the express versions to my home machine yet as I\'ve been dabbling more with NodeJs lately, but I\'m almost sure it\'ll be fine).</li>\n' +
    '                <li>To have the .js tests running in Visual Studio\'s "Test Explorer", you\'ll need to install the <a href="https://visualstudiogallery.msdn.microsoft.com/f8741f04-bae4-4900-81c7-7c9bfb9ed1fe">Chutzpah Test Adapter for the Test Explorer</a> and optionally the <a href="https://visualstudiogallery.msdn.microsoft.com/71a4e9bd-f660-448f-bd92-f5a65d39b7f0">Chutzpah Test Runner Context Menu Extension</a> extensions for Visual Studio.</li>\n' +
    '            </ul>\n' +
    '        </li>\n' +
    '        <li>\n' +
    '            <h3>Start playing</h3>            \n' +
    '            <p>\n' +
    'The application could be deployed to IIS to be run, but I haven\'t written any deployment scripts to automate this, so to keep things simple, \n' +
    'you will need to open up the solution file "CompanyABC.TreeView.sln" in Visual Studio 2012/2013/2015, and ensure the "CompanyABC.TreeView.Web" is set \n' +
    'as the StartUp project. Also ensure that the Start action on this project is set to "Specific Page" in project properties.\n' +
    '            </p>\n' +
    '            <p>\n' +
    'When the application is running, you can access a tree of depth 2 by either typing into the internet browser address bar or clicking on the url <a href="{{uiState.sampleTreeViewUrl}}" ng-bind="uiState.sampleTreeViewUrl"></a>.\n' +
    '            </p>\n' +
    '        </li>\n' +
    '        <li>\n' +
    '            <h3>Notes</h3>\n' +
    '            <p>\n' +
    'For the DAL, if it were tied to an actual DB, I usually have an accompanying "IntegrationTests" project\n' +
    'to ensure that the integration between the DAL and actual DB is correct. In the DAL layer, I \n' +
    'would usually use an ORM such as EntityFramework or Dapper - there are usually performance issues \n' +
    'related to bulk data manipulation or complex queries with ORMs, but there are solutions for these unique\n' +
    'situations which cater for these specific scenarios. </p>\n' +
    '            <p>\n' +
    'In this project I\'ve clumped both the WebApi and the Web into one project, but if this was an actual project, \n' +
    'I would have separated these out into separate projects as the WebApi is reusable by other clients \n' +
    '(e.g. mobile apps, etc.).\n' +
    '            </p>\n' +
    '            <p>\n' +
    'I\'m using NodeJs & Gulp to generate the template-cache js files for my angular views, but I\'ve kept it \n' +
    'separate from the VS build process ("AfterBuild" step in the CompanyABC.TreeView.Web.csproj) to avoid \n' +
    'you having to install NodeJs on your local machine, but if this was an actual project, I would have \n' +
    'included it in my build process instead as this is not the only benefit of using a task runner like Gulp and I would have\n' +
    'not included the generated associated template-cache js files in my source control (as these can be generated from files \n' +
    'that are already in my source control). I use gulp to minify/uglify my .js, .css, .html files, as well as running preprocessors for .less, es6 files, as well\n' +
    'as "stylecop" type tasks such as eslint. VS 2015 actually natively caters for these types of task runners.\n' +
    '\n' +
    '                </p>\n' +
    '        </li>\n' +
    '        <li>\n' +
    '            <h3>Troubleshooting</h3>\n' +
    '            <ul>\n' +
    '                <li>\n' +
    '                    <p>\n' +
    '                        Please ensure the "Start Action" for the web project (CompanyABC.TreeView.Web) has been set to "Specific Page" with a blank value.\n' +
    '                    </p>\n' +
    '                    <img src="{{uiState.webProjStartActionImagePath}}" />\n' +
    '                </li>\n' +
    '                <li>\n' +
    '                    <p>To ensure the JS tests run, you\'ll have to install Chutzpah for Visual Studio.</p>\n' +
    '                </li>\n' +
    '            </ul>\n' +
    '        </li>\n' +
    '    </ul>\n' +
    '</div>\n' +
    '\n' +
    '');
}]);
})();
