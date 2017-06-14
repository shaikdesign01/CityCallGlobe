(function () {

    'use strict';

    dailerDetailsFactory.$inject = [
        '$http'
    ];

    angular.module('app').factory('dailerDetailsFactory', dailerDetailsFactory);

    function dailerDetailsFactory(
        $http
        ){

        return {
            countrydata: [],
            dailerData: [],
            mobileData:[]
        }
    }

})();