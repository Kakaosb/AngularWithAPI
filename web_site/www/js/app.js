var testApp = angular.module('testApp', ["ngRoute"])
    .config(function ($routeProvider) {
        $routeProvider.when('/AddContact',
            {
                templateUrl: '/AddContact.html',
                controller: 'contactController'
            });
        $routeProvider.when('/SearchContacts',
            {
                templateUrl: 'SearchContacts.html',
                controller: 'searchContactController'
            });

        $routeProvider.otherwise({ redirectTo: '/AddContact' });
    });