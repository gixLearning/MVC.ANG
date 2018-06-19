(function () {
    var app = angular.module("PepsApp", ['ngRoute']);

    app.controller('HomeController', function ($scope) {
        $scope.message = "Hello AngularJS World";
    });
    
}());