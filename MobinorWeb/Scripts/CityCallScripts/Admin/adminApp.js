var adminApp = angular.module('adminApp', ['ngRoute']);

adminApp.config(function ($routeProvider) {
    $routeProvider.when('/login', {
        templateUrl: 'Content/templates/Admin/login/login.html',
        controller: 'LoginCtrl'
    });
    $routeProvider.when('/', {
        templateUrl: 'Content/templates/Admin/login/adminHome.html',
        controller: 'adminHomeController'
    });
    $routeProvider.otherwise({ redirectTo: '/' });
});

adminApp.run(function (authentication, $rootScope, $location) {
    $rootScope.$on('$routeChangeStart', function (evt) {
        if (!authentication.isAuthenticated) {
            $location.url("/login");
        }
        event.preventDefault();
    });
});


adminApp.factory('authentication', function () {
    return {
        isAuthenticated: false,
        user: null
    }
});