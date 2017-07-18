(function () {
    'use strict';
    angular.module('mce.student').service('studentService', studentService);
    studentService.$inject = ['$http'];

    function studentService($http) {
        return {
            create: create,
            list:list
        };

        function create(student) {
            return $http.post("api/student", student).then(function (result) {
                return result.data;
            });
        }
        function list() {
          return   $http.get("api/student").then(function (result) {
                return result.data;
            });
        }
    }
})();
