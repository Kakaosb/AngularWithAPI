testApp.controller("searchContactController", function ($scope, $http) {

    $scope.continentList = continentsList;       

    $scope.default = {
        Name: "",
        Sername: "",
        Gender: "null",
        IsAdult: "null",
        Continent: "null",
    } 

    $scope.search = $scope.default;
    
    $scope.contacts;

    //при переходе, загружаем всех контактов
    //$http({
    //    method: 'GET',
    //    url: serverAddress + '/MyApi/api/Contact'
    //}).then(function successCallback(response) {

    //    $scope.contacts = JSON.parse(response.data);

    //    }, function errorCallback(response) {

    //        ShowMessage(response.data);

    //    });
     

    $scope.searchContact = function (params, searchForm) {
        
            $http({
                method: 'GET',
                url: serverAddress + '/MyApi/api/Contact',
                params: params
            }).then(function successCallback(response) {

                $scope.search = $scope.default;
                $scope.contacts = JSON.parse(response.data);

            }, function errorCallback(response) {
                ShowMessage(response.data);
            });
        
    };

    $scope.searchContact($scope.search);
});