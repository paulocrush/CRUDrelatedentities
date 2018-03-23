﻿//NOT SAVING ASSIGNEDMANUFACTURER_ID

(function () {
    angular
    .module('app')
    .controller('app.views.products.createModal',
    ['$scope', '$uibModalInstance', 'abp.services.app.produto','abp.services.app.fabricante',

        function ($scope, $uibModalInstance, produtoService, fabricanteService) {
            var vm = this;
            vm.getFabricante = getFabricante;
            vm.save = save;
            vm.cancel = cancel;

            vm.produto = {};
            vm.fabricantes = [];
            vm.fabricante = {};

            getFabricantes();

            function getFabricantes() {
                fabricanteService.getAllFabricantes({}).then(function (result) {
                    vm.fabricantes = result.data.fabricantes;
                });
            }

            function getFabricante(fabricante) {
                vm.fabricante = fabricante;
            }

            function save() {
                
                produtoService.createProduto(vm.produto)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            function cancel() {
                $uibModalInstance.dismiss({});
            };

        }
    ]);
})();