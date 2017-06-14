(function () {
    'use strict'

    addEditDailerDetailsCtrl.$inject = [
        '$uibModalInstance',
        'modalData',
        'dailerDetailsFactory',
        'dailerDetailsService'
    ]

    function addEditDailerDetailsCtrl($uibModalInstance,
        modalData,
        dailerDetailsFactory,
        dailerDetailsService) {

        var vm = this;
        vm.mobileData = [];
        vm.countryData = [];

        vm.mobileData = dailerDetailsFactory.mobileData;
        vm.countryData = dailerDetailsFactory.countrydata;
        bindDailersData(modalData);
      

        function bindDailersData(modalData) {
            if (modalData != null) {
                vm.dailerInfo = {
                    Id: modalData.Id,
                    DailerName: modalData.DailerName,
                    DailerLink: modalData.DailerLink,
                    OperatorCode: modalData.OperatorCode,
                    selectedMobileInfo: {
                        "MobileId": modalData.MobileId,
                        "MobileName": modalData.MobileName
                    },
                    selectedCountryInfo: {
                        "CountryId": modalData.CountryId,
                        "CountryName": modalData.CountryName
                    }
                }
            } else {

                vm.mobileData.push({
                    "MobileId": '0',
                    "MobileName": 'Select Mobile'
                });

                vm.countryData.push({
                    "CountryId": '0',
                    "CountryName": 'Select Country'
                });

                vm.dailerInfo = {
                    selectedMobileInfo: {
                        "MobileId": '0',
                        "MobileName":'Select Mobile'
                    },
                    selectedCountryInfo: {
                        "CountryId": '0',
                        "CountryName": 'Select Country'
                    }
                }
            }
        }

        vm.addEditDailerInfo = function (data) {
            var modal = {};
            modal = {
                Id: data.Id,
                DailerName: data.DailerName,
                DailerLink: data.DailerLink,
                OperatorCode: data.OperatorCode,
                CountryId: data.selectedCountryInfo.CountryId,
                MobileId: data.selectedMobileInfo.MobileId
            }
            if (modal.Id) {
                dailerDetailsService.updateDailersInfo(modal).then(function (response) {
                    $uibModalInstance.close(response);
                });
            } else {
                dailerDetailsService.addDailerInfo(modal).then(function (response) {
                    $uibModalInstance.close(response);
                });
            }
        }

        vm.cancel = function () {
            $uibModalInstance.dismiss('this is result for dismiss');
        };
    }

    angular.module('app').controller('addEditDailerDetailsCtrl', addEditDailerDetailsCtrl);

})();