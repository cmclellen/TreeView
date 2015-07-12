# TreeView 
    <ul>
        <li>
            <h3>Overview</h3>
            <p>This ASP.NET MVC web application renders a tree structure to a depth specified by either the query string or the provided numeric input.</p>
            <p>I've used Visual Studio 2012 along with ASP.NET MVC5 and AngularJs 1.4 (for it's MVVM like feel enabling easier separation of concerns) to develop this application.</p>
        </li>
        <li>
            <h3>Prerequisites to run the application</h3>
            <ul>
                <li>Visual Studio 2012/2013/2015 (I haven't tested it in VS 2013 or 2015, as I haven't downloaded the express versions to my home machine yet as I've been dabbling more with NodeJs lately, but I'm almost sure it'll be fine).</li>
                <li>To have the .js tests running in Visual Studio's "Test Explorer", you'll need to install the <a href="https://visualstudiogallery.msdn.microsoft.com/f8741f04-bae4-4900-81c7-7c9bfb9ed1fe">Chutzpah Test Adapter for the Test Explorer</a> and optionally the <a href="https://visualstudiogallery.msdn.microsoft.com/71a4e9bd-f660-448f-bd92-f5a65d39b7f0">Chutzpah Test Runner Context Menu Extension</a> extensions for Visual Studio.</li>
            </ul>
        </li>
        <li>
            <h3>Start playing</h3>            
            <p>
The application could be deployed to IIS to be run, but I haven't written any deployment scripts to automate this, so to keep things simple, 
you will need to open up the solution file "CompanyABC.TreeView.sln" in Visual Studio 2012/2013/2015, and ensure the "CompanyABC.TreeView.Web" is set 
as the StartUp project. Also ensure that the Start action on this project is set to "Specific Page" in project properties.
            </p>
            <p>
When the application is running, you can access a tree of depth 2 by either typing into the internet browser address bar or clicking on the url <a href="{{uiState.sampleTreeViewUrl}}" ng-bind="uiState.sampleTreeViewUrl"></a>.
            </p>
        </li>
        <li>
            <h3>Notes</h3>
            <p>
For the DAL, if it were tied to an actual DB, I usually have an accompanying "IntegrationTests" project
to ensure that the integration between the DAL and actual DB is correct. In the DAL layer, I 
would usually use an ORM such as EntityFramework or Dapper - there are usually performance issues 
related to bulk data manipulation or complex queries with ORMs, but there are solutions for these unique
situations which cater for these specific scenarios. </p>
            <p>
In this project I've clumped both the WebApi and the Web into one project, but if this was an actual project, 
I would have separated these out into separate projects as the WebApi is reusable by other clients 
(e.g. mobile apps, etc.).
            </p>
            <p>
I'm using NodeJs & Gulp to generate the template-cache js files for my angular views, but I've kept it 
separate from the VS build process ("AfterBuild" step in the CompanyABC.TreeView.Web.csproj) to avoid 
you having to install NodeJs on your local machine, but if this was an actual project, I would have 
included it in my build process instead as this is not the only benefit of using a task runner like Gulp and I would have
not included the generated associated template-cache js files in my source control (as these can be generated from files 
that are already in my source control). I use gulp to minify/uglify my .js, .css, .html files, as well as running preprocessors for .less, es6 files, as well
as "stylecop" type tasks such as eslint. VS 2015 actually natively caters for these types of task runners.

                </p>
        </li>
        <li>
            <h3>Troubleshooting</h3>
            <ul>
                <li>
                    <p>
                        Please ensure the "Start Action" for the web project (CompanyABC.TreeView.Web) has been set to "Specific Page" with a blank value.
                    </p>                    
                </li>
                <li>
                    <p>To ensure the JS tests run, you'll have to install Chutzpah for Visual Studio.</p>
                </li>
            </ul>
        </li>
    </ul>
</div>

