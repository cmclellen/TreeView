/// <reference path="../_references.js" />
/// <reference path="../../../companyabc.treeview.web/app/controllers/treecontroller.js" />

describe("treeControllerTests", function () {

    var scope,
        controller,
        treeNodeServiceMock,
        deferred;

    beforeEach(module('app.tree-view', function ($provide) {
        treeNodeServiceMock = {
            getAll: function () { return deferred.promise; }
        };
        $provide.value('treeNodeService', treeNodeServiceMock);
    }));

    beforeEach(inject(function (_$rootScope_, _$controller_, _$q_) {
        deferred = _$q_.defer();
        scope = _$rootScope_.$new();
        controller = _$controller_('treeController', { $scope: scope });
    }));

    it('should set the treeNodes on page initialize', function () {

        // ARRANGE
        var response = [
            { displayText: 'aaa' },
            { displayText: 'bbb' }
        ];

        // ACT
        deferred.resolve(response);
        scope.$digest();

        // ASSERT
        expect(scope.uiState.treeNodes).toEqual([
            { displayText: 'aaa' },
            { displayText: 'bbb' }
        ]);
    });

});