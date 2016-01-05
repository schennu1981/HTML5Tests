var app = angular.module('pollAppModule', []);
app.controller("Question", function ($scope, $http)
{
    
 
    $http.get("service/Question").success(function (data) {
        $scope.OpenPolls = data.result;
        debugger;
    });
    

    
   

    $scope.SaveQuestionClick = function (questionObject) {
        // service calls;
        var result;
        result.status = "OK";
        result.result = "Created Question SUCCESS";
        updateStatus = resultDTO;




    };

    $scope.UpdateQuestionClick = function (objectToUpdatestatus) {

        // service calls;
        var result;
        result.status = "OK";
        result.result = "Created Question SUCCESS";
        updateStatus = resultDTO;
    };

    $scope.CreateQuestionClick = function (qustionObject) {
        // service calls;
        var result;
        result.status = "OK";
        result.result = "Created Question SUCCESS";
        updateStatus = resultDTO;
    };

    $scope.OpenQuestionList = function()
    {
        // service call to get the list of question for today with active status. users to vote.

    }



});

app.controller("Answers", function ($scope)
{
    
    $scope.SaveUserAnswer = function (answerObject) {
        // service call to save user answers.
    }

});


app.controller("Results", function ($scope) {


});