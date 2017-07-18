(function () {
	'use strict';
	angular.module('mce.student').controller('StudentCtrl', StudentCtrl);

	StudentCtrl.$inject = ['$scope', 'studentService'];

	function StudentCtrl($scope, studentService) {
		studentService.list().then(function (students) {
	        $scope.students = students;
		});

		$scope.master = {};

		$scope.update = function (user) {
			$scope.master = angular.copy(user);
		    studentService.create($scope.master).then(function() {

		    });
		};

		$scope.reset = function () {
			$scope.user = angular.copy($scope.master);
		};

		$scope.reset();

	};
})();