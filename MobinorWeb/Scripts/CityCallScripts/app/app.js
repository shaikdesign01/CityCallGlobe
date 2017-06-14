// App Module Decleration
var app = angular.module('app', ['ngRoute', 'ui.grid','ui.grid.edit','ui.bootstrap','ui.bootstrap.tpls']);

//Showing Routing  
app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
    .when('/home',
    {
        templateUrl: 'Content/templates/Home.tmpl.html',
        controller: 'adminHomeController'
    })
    .when('/admin', {
             templateUrl: 'Content/templates/Admin/login/index.html',
             controller: 'indexController'
     })
    .when('/login', {
        templateUrl: 'Content/templates/Admin/login/login.html',
        controller: 'LoginCtrl'
    })
    .when('/', {
        templateUrl: 'Content/templates/Home.tmpl.html',
        controller: 'adminHomeController'
    })
    .otherwise({
        redirectTo: '/'
    });
}]);


app.run(function (authentication, $rootScope, $location) {
    $rootScope.$on('$routeChangeStart', function (evt) {
        if (!authentication.isAuthenticated) {
            $location.url("/admin");
        }
        event.preventDefault();
    });
});

app.factory('authentication', function () {
    return {
        isAuthenticated: false,
        user: null
    }
});

