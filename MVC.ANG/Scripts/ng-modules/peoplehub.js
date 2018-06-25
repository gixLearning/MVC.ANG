(function () {
    var peopleHub = function ($http, $log) {
        var getMessage = function () {
            return "Hub";
        };

        var getLastUser = function () {
            $log.log("getLastUser");
            return $http.get("/Data/GetLastPerson")
                .then(function (response) {
                    //$log.log(response.data);
                    return response.data;
                });
        };

        var getListOfPeople = function () {
            return $http.get("/Data/GetListOfPeople")
                .then(function (response) {
                    return response.data;
                });
        };

        return {
            getLastUser: getLastUser,
            getMessage: getMessage
        };
    };

    var module = angular.module('PepsApp').factory("peopleHub", peopleHub);
}());