angular.module('spAngular', ['blockUI'])
.controller('MyController', ['$scope', '$log', 'dataService', function ($scope, $log, dataService) {
  $scope.welcomeMessage = "Hello SPAngular";
  $scope.items = [];

  $scope.doSomething = function() {

    var promise = dataService.getData();
    promise.then(
       function (payload) {
         $scope.items = payload;
       },
       function (errorPayload) {
         $log.error('failure loading data', errorPayload);
       });

  }
}])
.factory('dataService', function ($http, $log, $q, blockUI) {
  return {
    getData: function () {

      blockUI.start();

      var deferred = $q.defer();

      $http.get('/api/someprefix/items')
        .success(function (data) {
          blockUI.stop();
          deferred.resolve(data);
        }).error(function (msg, code) {
          blockUI.stop();
          deferred.reject(msg);
          $log.error(msg, code);
        });


      return deferred.promise;
    }
  }
});