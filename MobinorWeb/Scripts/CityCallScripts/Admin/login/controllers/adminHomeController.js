
(function () {
    'use strict';

    adminHomeController.$inject = ['$scope',
    'authentication'
    ];

    angular.module('app').controller('adminHomeController', adminHomeController);

    function adminHomeController(
    $scope,
    authentication) {

        $scope.user = authentication.user.name;
    }

})();