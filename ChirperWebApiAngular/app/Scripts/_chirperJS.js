var app = angular.module("app", ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: 'Views/home.html',
        controller: 'Home'
    })
    .when('/user', {
        templateUrl: 'Views/user.html',
        controller: 'User'
    })
    .when('/user/:id', {
        templateUrl: 'Views/detail.html',
        controller: 'Details'
    })
    .when('/chirp', {
        templateUrl: 'Views/chirp.html',
        controller: 'Chirp'
    })
    .otherwise(
    {
        redirectTo: function () {
            return "/";
        }
    })
});
app.factory("Messages", function () {
    return [];
})
app.factory("Users", function () {
    return [];
});
app.factory("Followers", function () {
    return [];
});
app.controller("Home", function () { })
app.controller("User", function ($scope, $http, $location) {
    $scope.getUsers = function () {
        //Get List of users
        $http.get("/api/user")
        .success(
        function (data) {
            Users = [];
            for (var x in data) {
                Users.push(data[x])
            }
            $scope.Users = Users;
        })
    }
    $scope.showDetails = function (id) {
        $location.path("/user/" + id);
    }
})

app.controller("Chirp", function ($scope, Messages, $http, Users, $location) {
    $scope.title = "Chirps!";
    //Get Chirps from database to display in Chirp.html file
    $scope.getChirps = function () {
        $http.get("/api/chirp")
        .success(
        function (data) {
            Messages = [];            
            for (var x in data) {
                Messages.push(data[x]);
            }
            console.log(Messages);
            $scope.Messages = Messages;
        })
    }
    //Add Chirps to Database.
    $scope.addChirp = function (Message, Author) {
        var chirp = { Message: Message, Author: Author }
        
        $http.post("/api/chirp", chirp)
        .success(function () {
            console.log("db has been updated");
            $scope.getChirps
        })
    };
    //Redirect to Profile View onClick in Table

    $scope.seeProfile = function (user) {
        $location.path("/user/" + Users.indexOf(user));
    };
});

app.controller("Details", function ($scope, $http, Users, $routeParams) {
    $scope.title = "User Profile";
    //Get User Details from DB
    $http.get("/api/user/" + $routeParams.id)
    .success(
    function (User) {
        console.log(User);
        $scope.User = User;
            })

    //Get Chirps By Specific User from DB
    $http.get("/api/chirp")
   .success(
   function (data) {
       Messages = [];
       for (var x in data) {
           if (data[x].Author == $scope.User.UserName) {
               Messages.push(data[x]);
           }
       }
       console.log(Messages);
       $scope.Messages = Messages;
   })
    $scope.showFriends = function (id) {
        $http.get("/api/user")
        .success(
        function (data) {
            
            console.log("Followers are:" + data)
            })
    }
})   



  