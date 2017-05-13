// App Module Decleration
var mobinorApp = angular.module('mobinorApp', ['ngRoute']);

//Showing Routing  
mobinorApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
    .when('/home',
    {
        templateUrl: 'Content/templates/Home.tmpl.html',
        controller: 'homeController'
    })
    .when('/dailer', {
        templateUrl: 'Content/templates/Dailer.tmpl.html',
        controller: 'dailerController'
    })
    .otherwise({
        redirectTo: '/'
    });
}]);