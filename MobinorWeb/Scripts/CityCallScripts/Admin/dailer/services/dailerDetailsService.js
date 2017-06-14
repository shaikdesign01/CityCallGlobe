(function () {

    'use strict';

    dailerDetailsService.$inject = [
        '$http',
        '$q',
        'dailerDetailsFactory'
    ];

    function dailerDetailsService(
        $http,
        $q,
        dailerDetailsFactory
        ) {

        return {
            getCountries: getCountries,
            getDailerDetails: getDailerDetails,
            getMobileDetails: getMobileDetails,
            updateDailersInfo: updateDailersInfo,
            deleteDailersInfo:deleteDailersInfo,
            addDailerInfo: addDailerInfo
        };

        function getCountries() {
            var defferObj = $q.defer();
            if (_.isEmpty(dailerDetailsFactory.countrydata)) {
                $http({
                    method: "GET",
                    url: "api/DailerInfoApi/GetCountries"
                }).then(function (response) {
                    dailerDetailsFactory.countrydata = response.data;
                    defferObj.resolve(response.data || []);
                });
            } else {
                defferObj.resolve(dailerDetailsFactory.countrydata);
            }
            return defferObj.promise;
        }

        function getDailerDetails() {
            var defferObj = $q.defer();
            if (_.isEmpty(dailerDetailsFactory.dailerData)) {
                $http({
                    method: "GET",
                    url: "api/DailerInfoApi/GetDailerDetails"
                }).then(function (response) {
                    dailerDetailsFactory.dailerData = response.data;
                    defferObj.resolve(response.data || []);
                });
            } else {
                defferObj.resolve(dailerDetailsFactory.dailerData);
            }
            return defferObj.promise;
        }

        function getMobileDetails() {
            var defferObj = $q.defer();
            if (_.isEmpty(dailerDetailsFactory.mobileData)) {
                $http({
                    method: "GET",
                    url: "api/DailerInfoApi/GetMobileDetails"
                }).then(function (response) {
                    dailerDetailsFactory.mobileData = response.data;
                    defferObj.resolve(response.data || []);
                });
            } else {
                defferObj.resolve(dailerDetailsFactory.mobileData);
            }
            return defferObj.promise;
        }


        function updateDailersInfo(dailersInfo) {
           return $http({
                method: 'POST',
                url: 'api/DailerInfoApi/UpdateDailerInfo',
                data: dailersInfo
            });
        }

        function deleteDailersInfo(dailerId) {
            return $http({
                method: 'DELETE',
                url: 'api/DailerInfoApi/DeleteDailerInfo',
                params: { dailerId: dailerId }
            });
        }

        function addDailerInfo(dailersInfo) {
            return $http({
                method: 'POST',
                url: 'api/DailerInfoApi/AddDailerInfo',
                data: dailersInfo
            });
        }
    }

    angular.module('app').service('dailerDetailsService', dailerDetailsService);

})();