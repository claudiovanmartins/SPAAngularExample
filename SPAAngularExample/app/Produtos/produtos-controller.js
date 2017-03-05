'use strict';
  
app.controller("ProdutosController", function ($scope, bootstrappedData) {
    $scope.produtos = bootstrappedData.produtos;
});