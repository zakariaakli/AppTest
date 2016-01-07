////////CONTROLLER PERSON LIST

angular.module('App', []).controller('personController',['$scope','$http',
function ($scope, $http) {


    //get persons
    $scope.get = function () {

        //call api
        $http.post('/Api/Persons/' + 'Get').then(function (data) {
            $scope.persons = data.data;
        })
    }

    //init
    $scope.get();
}])
