﻿/// <reference path="../_references.js" />
/// <reference path="../../../companyabc.treeview.web/dist/partials/views/tree.js" />
/// <reference path="../../../companyabc.treeview.web/app/controllers/treecontroller.js" />

describe("treeController", function () {

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

        it('should initialize the tree nodes', function () {

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
        });

    });

    describe('depth specified on query-string', function () {

        var viewHtml,
            formElement,
            controller;

        beforeEach(inject(function ($templateCache) {            
            viewHtml = $templateCache.get('/partials/views/tree.html');
            formElement = angular.element(viewHtml);                       
        }));

        it('should only show depth of 2 when query-string param value of 2 specified', function () {

            // ARRANGE
            $routeParams.treeDepth = 2;
            controller = $controller('treeController', {
                '$scope': scope,
                '$routeParams': $routeParams
            });
            var element = $compile(formElement)(scope);
            deferred.resolve(treeNodes);

            // ACT            
            $rootScope.$digest();
            
            // ASSERT
            var nodes = formElement[0].querySelectorAll('li.tree-node > span');
            expect(nodes.length).toBe(7);
            
            var nodeText = Object.keys(nodes).map(function (item) {
                var val = nodes[item];
                return val.innerText?val.innerText.trim():undefined;
            }).filter(function (item) {
                return item !== undefined;
            });
            expect(nodeText).toEqual([
                'a [Depth: 1]', 'aa [Depth: 2]', 'ab [Depth: 2]',
                'b [Depth: 1]', 'ba [Depth: 2]', 'bb [Depth: 2]', 'bc [Depth: 2]']);
        });

    });

});