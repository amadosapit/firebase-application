app.controller("ITFWebApplicationProjectController", function (ITFWebApplicationProjectService, $scope) {

    $scope.userarray = [];

    $scope.AlertFunc = function () {
        alert("hgnjhknbjylkuhb hgj");
    }

    $scope.WelcomeMessage = function () {
        alert("Welcome to my webpage");
    }

    $scope.CalculateFunc = function () {

        var numone = 1;
        var numtwo = 2;
        var sum = numone + numtwo;
        alert(sum);

    }

    $scope.UsernameFunc = function (parameterone) {
        alert("The student name is " + parameterone);
    }

    $scope.GetNameFunc = function () {
        $scope.newalertname = "The name of the user is " + $scope.txtUsername;
    }

    $scope.RegisterName = function () {

        if (($scope.txtFirstname === "" || $scope.txtFirstname == undefined) ||
            ($scope.txtMiddlename === "" || $scope.txtMiddlename == undefined) ||
            ($scope.txtLastname === "" || $scope.txtLastname == undefined)) {
            Swal.fire({
                title: "Notification!",
                text: "Please insert values in the required fields",
                icon: "error"
            });
        } else {
            var userdataa = {
                FName: $scope.txtFirstname,
                MName: $scope.txtMiddlename,
                LName: $scope.txtLastname
            }

            $scope.userarray.push(userdataa);

            $scope.arraylength = $scope.userarray.length;
        }

    }

    $scope.editFunc = function (userindex) {

        var userdata = $scope.userarray[userindex];

        if (($scope.txtFirstname === "" || $scope.txtFirstname == undefined) ||
            ($scope.txtMiddlename === "" || $scope.txtMiddlename == undefined) ||
            ($scope.txtLastname === "" || $scope.txtLastname == undefined)) {
            Swal.fire({
                title: "Notification!",
                text: "Please insert values in the required fields",
                icon: "error"
            });
        } else {
            if (userdata.FName === $scope.txtFirstname ||
                userdata.MName === $scope.txtMiddlename ||
                userdata.LName === $scope.txtLastname) {
                Swal.fire({
                    title: "Notification!",
                    text: "No Changes found in the required fields",
                    icon: "error"
                });
            } else {
                userdata.FName = $scope.txtFirstname;
                userdata.MName = $scope.txtMiddlename;
                userdata.LName = $scope.txtLastname;
            }
        }

    }

    $scope.deleteFunc = function (userindex) {
        $scope.userarray.splice(userindex, 1);
    }


    $scope.redirectFunc = function () {
        window.location.href = "/ITFApplication/AboutPage";
    }

    $scope.getUsernameFunc = function () {

        var getData = ITFWebApplicationProjectService.getUsernameFunc();
        getData.then(function (returnedData) {
            Swal.fire({
                title: "Notification!",
                text: returnedData.data,
                icon: "error"
            });
        });
    }

    $scope.updateUsernameFunc = function () {

        var getData = ITFWebApplicationProjectService.updateUsernameFunc("amado.sapit");
        getData.then(function (returnedData) {
            Swal.fire({
                title: "Notification!",
                text: returnedData.data,
                icon: "success"
            });
        })
    }

    $scope.manipulateFunc = function () {

        var userdata = {
            FirstName:"amado",
            MiddleName: "mariano",
            LastName: "sapit"
        }

        var getData = ITFWebApplicationProjectService.manipulateFunc(userdata);
        getData.then(function (returnedData) {
            Swal.fire({
                title: "Notification!",
                text: returnedData.data.FirstName,
                icon: "success"
            });
        })

    }

    $scope.CreateEmployeeFunc = function () {

        var userdata = {
            FirstName: $scope.txtFirstname,
            MiddleName: $scope.txtMiddlename,
            LastName: $scope.txtLastname
        }

        var postData = ITFWebApplicationProjectService.CreateEmployeeFunc(userdata);
        postData.then(function (returnedData) {
            Swal.fire({
                title: "Notification!",
                text: "Successfully Added a user",
                icon: "success"
            });

            $scope.userList = returnedData.data;
        })
    }

    $scope.UpdateEmployeeFunc = function (uID) {
        var userdata = {
            UserID: uID,
            FirstName: $scope.txtFirstname,
            MiddleName: $scope.txtMiddlename,
            LastName: $scope.txtLastname
        }

        var postData = ITFWebApplicationProjectService.UpdateEmployeeFunc(userdata);
        postData.then(function (returnedData) {
            Swal.fire({
                title: "Notification!",
                text: "Successfully Updated a user",
                icon: "success"
            });

            $scope.userList = returnedData.data;
        })
    }

    $scope.RemoveEmployeeFunc = function (uID) {
        var removeData = ITFWebApplicationProjectService.RemoveEmployeeFunc(uID);
        removeData.then(function (returnedData) {
            Swal.fire({
                title: "Notification!",
                text: "Successfully removed a user",
                icon: "success"
            });

            $scope.userList = returnedData.data;
        })
    }

});