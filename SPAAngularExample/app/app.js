'use strict';

var app = angular.module("app", ['ngRoute'])
 .config(function ($routeProvider, $locationProvider) {
     $routeProvider.when('/Cadastro/Produtos', { templateUrl: '/templates/Produtos/produtos.html', controller: 'ProdutosController' });
     $routeProvider.when('/Cadastro/Clientes', { templateUrl: '/templates/Clientes/clientes.html', controller: 'ClientesController' });
     $locationProvider.html5Mode(true);
 });
