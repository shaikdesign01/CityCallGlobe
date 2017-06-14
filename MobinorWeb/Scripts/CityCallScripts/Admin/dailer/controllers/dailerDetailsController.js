(function () {

    'use strict'

    dailerDetailsController.$inject = [
        '$scope',
        '$http',
        'dailerDetailsService',
        'dailerDetailsFactory',
        '$uibModal',
        '$q'
    ];

    function dailerDetailsController(
        $scope,
        $http,
        dailerDetailsService,
        dailerDetailsFactory, $uibModal, $q) {

        var vm = this;
        $scope.gridOptions = {
            data: [],
            columnDef: []
        };

        vm.getDailerDetails = function () {

            let promises = {
                dailerData: dailerDetailsService.getDailerDetails(),
                countrydata: dailerDetailsService.getCountries(),
                mobileData: dailerDetailsService.getMobileDetails()
            }

            $q.all(promises).then((values) => {

                dailerDetailsFactory.dailerData = values.dailerData;
                dailerDetailsFactory.countrydata = values.countrydata;
                dailerDetailsFactory.mobileData = values.mobileData;

                _.each(dailerDetailsFactory.dailerData, function (field) {
                    var country = _.find(values.countrydata, { CountryId: field.CountryId });
                    field.CountryName = country ? country.CountryName : '';

                    var phone = _.find(values.mobileData, { MobileId: field.MobileId });
                    field.MobileName = phone ? phone.MobileName : '';

                });
                $scope.gridOptions.data = dailerDetailsFactory.dailerData;
            });
        }

        vm.getDailerDetails();

        $scope.Delete = function (row) {
            dailerDetailsService.deleteDailersInfo(row.Id).then(function (response) {
                dailerDetailsFactory.dailerData = [];
                vm.getDailerDetails();
            });
        };

        $scope.editDailer = function (editedRowData) {
            openModalPopUp(editedRowData);
        }

        function openModalPopUp(editedData) {
            var modalInstance;
            modalInstance = $uibModal.open({
                templateUrl: '/Content/templates/Admin/dailer/addEditDailerDetails.tmpl.html',
                animation: true,
                size: 'sm',
                backdrop: "static",
                controller: 'addEditDailerDetailsCtrl as AEDD',
                resolve: {
                    modalData: function () { return editedData; }
                }
            });

            modalInstance.result.then(
                function (result) {
                    dailerDetailsFactory.dailerData = [];
                    vm.getDailerDetails();
                },
            function (result) {
                console.log('called $uibmodalInstance.dismiss()');
            });
        }

        vm.addDailer = function () {
            var editData = null;
            openModalPopUp(editData);
        }

        $scope.gridOptions.columnDefs = [
             {
                 name: 'Id',
                 visible: false,
                 field: 'Id'
             }, {
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
                 name: 'Edit',
                 cellTemplate: '<button ng-click="grid.appScope.editDailer(row.entity)"  class="fa fa-edit">Edit</button>'
             }, {
                 name: 'Delete',
                 cellTemplate: '<button class="btn primary" ng-click="grid.appScope.Delete(row.entity)">Delete Me</button>'
             }];

    }

    angular.module('app').controller('dailerDetailsController', dailerDetailsController);

})();