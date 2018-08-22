var myApp = angular
  .module("myModule", [])
  .controller("myController", function ($scope) {
    var Account = {
      Name: "Sikelela Nkohla",
      Site: "http://www.c-sharpcorner.com/members/satyaprakash-samantaray",
      Flair: "http://www.c-sharpcorner.com/members/satyaprakash-samantaray/flair.png"
    };
    $scope.Account = Account;
  });   