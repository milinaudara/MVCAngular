(function () {
	'use strict';

	angular.module('mce.student', [])
   .config(stateConfig);

	stateConfig.$inject = ['$stateProvider'];

	function stateConfig($stateProvider) {

	    $stateProvider
	        .state('home',
	        {
	            url: '',
	            templateUrl: 'scripts/app/student/student.html',
	            controller: 'StudentCtrl'
	        });
	}

})();