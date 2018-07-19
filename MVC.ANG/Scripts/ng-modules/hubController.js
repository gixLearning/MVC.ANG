(function () {
    var module = angular.module("PepsApp").controller('HubController', function ($scope, $log, peopleHub) {
        $scope.message = "Hub is ok!";
        $scope.Hub = null;

        var onSuccess = function (data) {
            $scope.Hub = data;
            //return data;
        };
        var onError = function (reason) {
            $scope.error = "Could not get data";
        };

        $scope.orderByMe = function (order) {
            $scope.myOrderBy = order;
        }

        peopleHub.getListOfPeople().then(onSuccess, onError);
    });
}());