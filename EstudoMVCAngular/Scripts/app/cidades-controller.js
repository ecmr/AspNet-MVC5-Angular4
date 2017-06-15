angular.module('CidadesApp', []).controller('CidadesCtrl',
    function ($scope, $http) {

        $scope.qtdeRegioes = 5;

        $http.get('/api/capitais')
            .success(function (data) {
                $scope.capitais = data;
            });
    });