(function(module) {
try {
  module = angular.module('app.tree-view.partials');
} catch (e) {
  module = angular.module('app.tree-view.partials', []);
}
module.run(['$templateCache', function($templateCache) {
  $templateCache.put('/partials/views/tree.html',
    '<div>\n' +
    '\n' +
    '    <script type="text/ng-template" id="treenode_renderer.html">\n' +
    '    {{data.displayText}} [Depth: {{data.t}}]\n' +
    '    <ul ng-if="data.t < uiState.depth">\n' +
    '        <li class="tree-node" ng-repeat="data in data.treeNodes" ng-init="data.t = ($parent.data.t || 0) + 1" ng-include="\'treenode_renderer.html\'"></li>\n' +
    '    </ul>\n' +
    '    </script>\n' +
    '\n' +
    '    <div class="form-group">\n' +
    '        <label for="treeDepth">Depth</label>\n' +
    '        <input type="number" id="treeDepth" min="0" ng-model="uiState.depth" value="{{uiState.depth}}" />\n' +
    '    </div>\n' +
    '\n' +
    '    <div ng-if="isLoading()">\n' +
    '        Loading...\n' +
    '    </div>\n' +
    '    <div ng-if="!isLoading()">\n' +
    '        <div ng-if="!canShowTree()" class="alert alert-warning">No tree will display if the depth is 0</div>\n' +
    '        <ul class="tree" ng-if="canShowTree()">\n' +
    '            <li class="tree-node" ng-repeat="data in uiState.treeNodes" ng-include="\'treenode_renderer.html\'" ng-init="data.t = ($parent.data.t || 0) + 1"></li>\n' +
    '        </ul>\n' +
    '    </div>\n' +
    '</div>\n' +
    '');
}]);
})();
