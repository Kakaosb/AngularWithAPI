  testApp.filter('boolReplace', function () {
            return function (input) {
                var result = input ? 'Yes' : 'No';
                return result;
            };
        });