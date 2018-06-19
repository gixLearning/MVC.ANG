(function () {
    var peopleHub = function ($http) {
        var getLastUser = function () {
            return $http.get("Data/GetLastPerson")
                .then(function (response) {
                    return response.data;
                });
        };

        return {
            getLastUser: getLastUser
        };
    };
    var module = angular.module('PepsApp').factory('peopleHub', peopleHub);
}());