
(function () {
    'use strict';

    LoginCtrl.$inject = ['$scope',
    '$http',
    '$location',
    'authentication'
    ];

    angular.module('app').controller('LoginCtrl', LoginCtrl);

    function LoginCtrl(
    $scope,
    $http,
    $location,
    authentication) {

        $scope.login = function () {
            if ($scope.username === 'admin' && $scope.password === 'pass') {
                console.log('successful')
                authentication.isAuthenticated = true;
                authentication.user = { name: $scope.username };
                $location.url("/");
            } else {
                $scope.loginError = "Invalid username/password combination";
                console.log('Login failed..');
            };
        };
    }

})();