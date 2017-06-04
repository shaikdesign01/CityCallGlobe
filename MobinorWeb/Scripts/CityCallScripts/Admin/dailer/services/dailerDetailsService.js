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
        ){

       // var _this = this;

        return {
            getCountries: getCountries,
            getDailerDetails: getDailerDetails,
            getMobileDetails: getMobileDetails
        };

        function getCountries() {
            var defferObj = $q.defer();
            if (_.isEmpty(dailerDetailsFactory.getCountries)) {
                $http({
                    method: "GET",
                    url: "api/DailerInfoApi/GetCountries"
                }).then(function (response) {
                    dailerDetailsFactory.getCountries = response.data;
                    defferObj.resolve(response.data || []);
                });
            } else {
                defferObj.resolve(dailerDetailsFactory.getCountries);
            }
            return defferObj.promise;
        }

        function getDailerDetails() {
            var defferObj = $q.defer();
            if (_.isEmpty(dailerDetailsFactory.getDailerDetails)) {
                $http({
                    method: "GET",
                    url: "api/DailerInfoApi/GetDailerDetails"
                }).then(function (response) {
                    dailerDetailsFactory.getDailerDetails = response.data;
                    defferObj.resolve(response.data || []);
                });
            } else {
                defferObj.resolve(dailerDetailsFactory.getDailerDetails);
            }
            return defferObj.promise;
        }

        function getMobileDetails() {
            var defferObj = $q.defer();
            if (_.isEmpty(dailerDetailsFactory.getMobileDetails)) {
                $http({
                    method: "GET",
                    url: "api/DailerInfoApi/GetMobileDetails"
                }).then(function (response) {
                    dailerDetailsFactory.getMobileDetails = response.data;
                    defferObj.resolve(response.data || []);
                });
            } else {
                defferObj.resolve(dailerDetailsFactory.getMobileDetails);
            }
            return defferObj.promise;
        }
    }

    angular.module('app').service('dailerDetailsService', dailerDetailsService);

})();