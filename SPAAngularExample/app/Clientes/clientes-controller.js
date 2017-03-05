'use strict';
  
app.controller("ClientesController", function ($scope, bootstrappedData) {
    $scope.clientes = bootstrappedData.clientes;
});
