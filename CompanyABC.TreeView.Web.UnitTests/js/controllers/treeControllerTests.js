/// <reference path="../_references.js" />
/// <reference path="../../../companyabc.treeview.web/dist/partials/views/tree.js" />
/// <reference path="../../../companyabc.treeview.web/app/controllers/treecontroller.js" />

describe("tree controller", function () {

    var $rootScope,
        $controller,
        $routeParams,
        $compile,
        scope,
        controller,
        treeNodeServiceMock,
        deferred,
        treeNodes = [
            { displayText: 'a', treeNodes: [
                  { displayText: 'aa', treeNodes: [ { displayText: 'aaa' } ] },
                  { displayText: 'ab', treeNodes: [ { displayText: 'aba' } ] }]
            },
            { displayText: 'b', treeNodes: [
                  { displayText: 'ba' },
                  { displayText: 'bb', treeNodes: [
                      { displayText: 'bba', treeNodes: [{ displayText: 'bbaa' }] }]
                  },
                  { displayText: 'bc' }]
            }
        ];

    beforeEach(module('app.tree-view', function ($provide) {
        treeNodeServiceMock = {
            getAll: function () { return deferred.promise; }
        };
        $provide.value('treeNodeService', treeNodeServiceMock);
    }));

    beforeEach(inject(function (_$rootScope_, _$controller_, _$q_, _$routeParams_, _$compile_) {
        $controller = _$controller_;
        $rootScope = _$rootScope_;
        $routeParams = _$routeParams_;
        $compile = _$compile_;

        deferred = _$q_.defer();
        scope = _$rootScope_.$new();       
    }));

    describe('initialization', function () {
        var controller;

        beforeEach(inject(function () {
            controller = $controller('treeController', { $scope: scope });
        }));

        it('should set the tree nodes once all nodes loaded from server', function () {

            // ARRANGE
            deferred.resolve(treeNodes);

            // ACT            
            scope.$digest();

            // ASSERT
            var expected = [
            {
                displayText: 'a', treeNodes: [
                    { displayText: 'aa', treeNodes: [{ displayText: 'aaa' }] },
                    { displayText: 'ab', treeNodes: [{ displayText: 'aba' }] }]
            },
            {
                displayText: 'b', treeNodes: [
                    { displayText: 'ba' },
                    {
                        displayText: 'bb', treeNodes: [
                          { displayText: 'bba', treeNodes: [{ displayText: 'bbaa' }] }]
                    },
                    { displayText: 'bc' }]
            }
            ];
            expect(scope.uiState.treeNodes).toEqual(expected);
            expect(scope.isLoading()).toBeFalsy();
        });

        it('should have state isLoading while retrieving nodes', function () {

            // ARRANGE
            
            // ACT            
            
            // ASSERT            
            expect(scope.isLoading()).toBeTruthy();
        });

        it('should have state canShowTree true if current depth greater than 0', function () {

            // ARRANGE
            scope.uiState.depth = 5;

            // ACT            
            
            // ASSERT            
            expect(scope.canShowTree()).toBeTruthy();
        });

        it('should have state canShowTree false if current depth equals 0', function () {

            // ARRANGE
            scope.uiState.depth = 0;

            // ACT            

            // ASSERT            
            expect(scope.canShowTree()).toBeFalsy();
        });

    });
});