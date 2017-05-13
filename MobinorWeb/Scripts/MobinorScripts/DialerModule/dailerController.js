mobinorApp.controller('dailerController', ['$scope','$http', function ($scope, $http) {
    $scope.message = 'Look! I am an Dailer page.';

    $http({
        method: "GET",
        url: "api/DailerInfoApi/GetCountries"
    }).then(function mySucces(response) {
        $scope.message = response.data;
    }, function myError(response) {
        $scope.message = response.data;
    });
}]);