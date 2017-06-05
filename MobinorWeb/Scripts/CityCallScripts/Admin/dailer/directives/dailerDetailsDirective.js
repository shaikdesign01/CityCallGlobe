/// <reference path="D:\Projects\Mushtak_Projects\CityCallGlobe\MobinorWeb\Content/templates/Admin/dailer/dailerDetails.tmpl.html" />
(function () {

    'use strict';

    angular.module('app').directive('dailerDetails', dailerDetails);

    function dailerDetails() {
        return {
            restrict: 'AE',
            replace: 'true',
            templateUrl:'/Content/templates/Admin/dailer/dailerDetails.tmpl.html',
            controller: 'dailerDetailsController',
            bindToController: true
        };
    }

})();