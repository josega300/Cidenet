// <reference path="../angular.min.js" />
// <reference path="Modules.js" />
// <reference path="Services.js" />

app.controller("CRUD_AngularJs_RESTController", function ($scope, CRUD_AngularJs_RESTService) {

    $scope.OperType = 1;
    //1 Mean New Entry

    GetAllRecords();
    //GetAllRecordsFilter();
    //To Get All Records
    function GetAllRecords() {
        var promiseGet = CRUD_AngularJs_RESTService.getAllUsers();
        promiseGet.then(function (pl) { $scope.Users = pl.data },
            function (errorPl) {
                $log.error('Ocurrio un error con los datos.', errorPl);
            });
    }

    function GetAllRecordsFilter() {
        var promiseGet = CRUD_AngularJs_RESTService.GetAllRecordsFilter();
        promiseGet.then(function (pl) { $scope.Users = pl.data },
            function (errorPl) {
                $log.error('Ocurrio un error con los datos.', errorPl);
            });
    }


    //To Clear all input controls.
    function ClearModels() {
        $scope.OperType = 1;
        $scope.UserID = "";

        /*********************/
        $scope.PrimerApellido = "";
        $scope.SegundoApellido = "";
        $scope.PrimerNombre = "";
        $scope.OtrosNombres = "";
        $scope.PaisEmpleo = "";
        $scope.TipoIdentificacion = "";
        $scope.NumeroIdentificacion = "";
        $scope.CorreoElectronico = "";
        $scope.FechaIngreso = "";
        $scope.Area = "";
        $scope.Estado = "";
        $scope.FechaHoraRegistro = "";
        $scope.FechaHoraActualizado = "";

        /*********************/

    }

    //To Create new record and Edit an existing Record.
    $scope.save = function () {
        var User = {


            /*****************/
            PrimerApellido: $scope.PrimerApellido,
            SegundoApellido: $scope.SegundoApellido,
            PrimerNombre: $scope.PrimerNombre,
            OtrosNombres: $scope.OtrosNombres,
            PaisEmpleo: $scope.PaisEmpleo,
            TipoIdentificacion: $scope.TipoIdentificacion,
            NumeroIdentificacion: $scope.NumeroIdentificacion,
            CorreoElectronico: $scope.CorreoElectronico,
            FechaIngreso: $scope.FechaIngreso,
            Area: $scope.Area,
            Estado: $scope.Estado,
            FechaHoraRegistro: $scope.FechaHoraRegistro,
            FechaHoraActualizado: $scope.FechaHoraActualizado,

            /*****************/


        };
        if ($scope.OperType === 1) {
            var promisePost = CRUD_AngularJs_RESTService.post(User);
            promisePost.then(function (pl) {
                $scope.UserID = pl.data.UserID;
                GetAllRecords();

                ClearModels();
            }, function (err) {
                console.log("Ocurrio un error" + err);
            });
        } else {
            //Edit the record    
            //debugger;
            User.UserID = $scope.UserID;
            var promisePut = CRUD_AngularJs_RESTService.put($scope.UserID, User);
            promisePut.then(function (pl) {
                $scope.Message = "Usuario actualizado exitosamente.";
                GetAllRecords();
                ClearModels();
            }, function (err) {
                console.log("Ocurrio un error." + err);
            });
        }
    };

    //To Get Student Detail on the Base of Student ID
    $scope.get = function (User) {
        var promiseGetSingle = CRUD_AngularJs_RESTService.get(User.UserID);
        promiseGetSingle.then(function (pl) {
            var res = pl.data;
            $scope.UserID = res.UserID;

            //$scope.OperType = 0;

            /*************************/
            $scope.PrimerApellido = res.PrimerApellido;
            $scope.SegundoApellido = res.SegundoApellido;
            $scope.PrimerNombre = res.PrimerNombre;
            $scope.OtrosNombres = res.OtrosNombres;
            $scope.PaisEmpleo = res.PaisEmpleo;
            $scope.TipoIdentificacion = res.TipoIdentificacion;
            $scope.NumeroIdentificacion = res.NumeroIdentificacion;
            $scope.CorreoElectronico = res.CorreoElectronico;
            $scope.FechaIngreso = res.FechaIngreso;
            $scope.Area = res.Area;
            $scope.Estado = res.Estado;
            $scope.FechaHoraRegistro = res.FechaHoraRegistro;
            $scope.FechaHoraActualizado = res.FechaHoraActualizado;
            $scope.OperType = 0;
            /*************************/

        },
            function (errorPl) {
                console.log('Ocurrio un error con los datos del usuario', errorPl);
            });
    }

    //To Delete Record
    $scope.delete = function (User) {
        var promiseDelete = CRUD_AngularJs_RESTService.delete(User.UserID);
        promiseDelete.then(function (pl) {
            $scope.Message = "Usuario eliminado exitosamente.";
            GetAllRecords();
            ClearModels();
        }, function (err) {
            console.log("Ocurrio un error." + err);
        });
    }
});