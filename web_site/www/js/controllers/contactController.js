testApp.controller('contactController',
    function contactController($scope, $http) {

        $scope.continentList = continentsList;            

        $scope.ValidForm = contactForm.IsValid;

        $scope.default = { IsAdult: false };

        $scope.contact = {
            IsAdult: false
        }

        $scope.sendData = function (contact, contactForm) {
            if (contactForm.$valid) {
                $http({
                    method: 'POST',
                    url: serverAddress + '/MyApi/api/Contact',
                    data: contact
                }).then(function successCallback(response) {

                    $scope.contact = $scope.default;
                    ShowMessage(response.data);                    

                }, function errorCallback(response) {
                    ShowMessage(response.data);
                });
            }
        };        
    });