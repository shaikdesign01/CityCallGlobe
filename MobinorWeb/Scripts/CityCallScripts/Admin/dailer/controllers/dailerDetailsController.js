(function () {

    'use strict'

    dailerDetailsController.$inject = [
        '$scope',
        '$http',
        'dailerDetailsService',
        'dailerDetailsFactory'
    ];

    function dailerDetailsController(
        $scope,
        $http,
        dailerDetailsService,
        dailerDetailsFactory) {

        var vm = this;

        vm.getCountries = function () {
            dailerDetailsService.getCountries().then(function (countries) {
                dailerDetailsFactory.getCountries = countries;
            });
        }

        vm.getMobileDetails = function () {
            dailerDetailsService.getMobileDetails().then(function (response) {
                dailerDetailsFactory.getMobileDetails = response;
            });
        }

        vm.getDailerDetails = function () {
            dailerDetailsService.getDailerDetails().then(function (response) {

                dailerDetailsFactory.getDailerDetails = response;

                _.each(dailerDetailsFactory.getDailerDetails, function (field) {
                    return _.find(dailerDetailsFactory.getCountries, function (row) {
                        if (row.CountryId == field.CountryId) {
                            field.CountryName = row.CountryName;
                        }
                    });
                });

                _.each(dailerDetailsFactory.getDailerDetails, function (field) {
                    return _.find(dailerDetailsFactory.getMobileDetails, function (row) {
                        if (row.MobileId == field.MobileId) {
                            field.MobileName = row.MobileName;
                        }
                    });
                });
             
                $scope.gridOptions.data = dailerDetailsFactory.getDailerDetails;
            });
        }

        $scope.gridOptions = {};
        vm.getCountries();
        vm.getMobileDetails();
        vm.getDailerDetails();

        $scope.Delete = function (row) {
            var index = $scope.gridOptions.data.indexOf(row.entity);
            $scope.gridOptions.data.splice(index, 1);
        };

        $scope.gridOptions.columnDefs = [{
            name: 'Country',
            field: 'CountryName'
        }, {
            name: 'Mobile',
            field: 'MobileName'
        }, {
            name: 'DailerName',
            field: 'DailerName'
        }, {
            name: 'OperatorCode',
            field: 'OperatorCode'
        }, {
            name: 'ShowScope',
            cellTemplate: '<button class="btn primary" ng-click="grid.appScope.Delete(row)">Delete Me</button>'
        }];

    }

    angular
.module('app')
.controller('dailerDetailsController', dailerDetailsController);

})();