(function () {

    'use strict';

    angular.module('app').directive('myCustomer', myCustomer);

    function myCustomer() {
        return {
            restrict: 'AE',
            replace: 'true',
            template: '<h3>Hello World!!</h3>'
        };
    }

})();