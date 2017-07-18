(function () {
    'use strict';

    angular.module('mce.core')
        .config(customConfigs)
       
        .run(run);

    function customConfigs() {
       
    }

    function run($rootScope) {
        

    }


    //runErrorMessage.$inject = ['defaultErrorMessageResolver'];
    //function runErrorMessage(defaultErrorMessageResolver) {
    //    // passing a culture into getErrorMessages('fr-fr') will get the culture specific messages
    //    // otherwise the current default culture is returned.
    //    defaultErrorMessageResolver.getErrorMessages().then(function (errorMessages) {
    //        errorMessages['price'] = 'Please entere valid price';
    //        errorMessages['imageIsRequired'] = 'Please upload at least one image.';
    //    });
    //}

})();