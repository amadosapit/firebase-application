app.service("ITFWebApplicationProjectService", function ($http) {

    this.getUsernameFunc = function () {
       return $http.get("/ITFApplication/GetUsername");
    }

    this.updateUsernameFunc = function (uname) {
        var response = $http({
            method: "post",
            url: "/ITFApplication/UpdateUsername",
            params: {
                username: uname
            }
        })

        return response;
    }

    this.manipulateFunc = function (udata) {
        var response = $http({
            method: "post",
            url: "/ITFApplication/ManipulateData",
            data: udata
        });

        return response;
    }

    this.CreateEmployeeFunc = function (udata) {
        var response = $http({
            method: "post",
            url: "/ITFApplication/CreateEmployee",
            data:udata
        })
        return response;
    }

    this.UpdateEmployeeFunc = function (udata) {
        var response = $http({
            method: "post",
            url: "/ITFApplication/UpdateEmployee",
            data: udata
        })
        return response;
    }

    this.RemoveEmployeeFunc = function (uID) {
        var response = $http({
            method: "post",
            url: "/ITFApplication/RemoveEmployee",
            params: {
                userID :  uID
            }
        })

        return response;
    }


});