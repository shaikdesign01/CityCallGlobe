(function () {
    'use strict';

    indexController.$inject = ['$scope',
    'authentication'
    ];

    angular.module('app').controller('indexController', indexController);

    function indexController(   
    $scope,
    authentication) {

        $scope.templates =
       [
         { url: 'Content/templates/Admin/login/login.html' },
         { url: 'Content/templates/Admin/login/adminHome.html' }
       ];
        $scope.template = $scope.templates[0];
        $scope.login = function (username, password) {
            if (username === 'admin' && password === '1234') {
                authentication.isAuthenticated = true;
                $scope.template = $scope.templates[1];
                $scope.user = username;
            } else {
                $scope.loginError = "Invalid username/password combination";
            };
        };
    }

    })();