// <reference path="../angular.min.js" />
// <reference path="Modules.js" />

app.service("CRUD_AngularJs_RESTService", function ($http) {
    //Create new record
    this.post = function (User) {
        var request = $http({
            method: "post",
            url: "http://localhost:27321/UserService.svc/AddNewUser",
            data: User
        });
        return request;
    }

    //Update the Record
    this.put = function (UserID, User) {
        var request = $http({
            method: "put",
            url: "http://localhost:27321/UserService.svc/UpdateUser",
            data: User
        });
        return request;
    }

    this.getAllUsers = function () {
        return $http.get("http://localhost:27321/UserService.svc/GetAllUsers");
    };

    //Get Single Records
    this.get = function (UserID) {
        return $http.get("http://localhost:27321/UserService.svc/GetUserDetails/" + UserID);
    }

    this.getAllUsersFilter = function () {
        return $http.get("http://localhost:27321/UserService.svc/getAllUsersFilter");
    };

    //Delete the Record
    this.delete = function (UserID) {
        var request = $http({
            method: "delete",
            url: "http://localhost:27321/UserService.svc/DeleteUser/" + UserID
        });
        return request;
    }
});