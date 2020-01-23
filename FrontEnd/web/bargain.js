

var ServiceURL = "http://localhost:3000/api/Bargain/";

var app = angular.module("cheapawsome", []);


app.service("cheapawsomeContactService", function ($http) {


    this.PostToService = function (param, MethodName) {
        var response = $http({
            method: "post",
            url: ServiceURL + MethodName,
            data: JSON.stringify(param),
            dataType: "json"
        });
        return response;
    }

});



app.controller("cheapawsomeController", function ($scope, $log, cheapawsomeContactService) {



    $scope.fn_findbargain = function () {


        
        var param =
            {
                destinationid: 1,
                nights:1,
                code:"asdfasdf"
            };

        console.log(param); 

        var ResponseRegistration = cheapawsomeContactService.PostToService(param, "FindBargain");
        ResponseRegistration.then(function (msg) {
            console.log(msg); 
            
        }, function (msg) {

            console.log('Error: GetStateList ');
        });
    }



});