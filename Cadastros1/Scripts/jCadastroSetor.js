window.pageSetor = {

    createSector: function () {
    
        $.ajax({

            url: 'api/Setor/CreateNewSector',
            type: 'POST',
            dataType: 'json',
            data: {
                "sSetor": $('#NomeSetor').val()
            },
            success: function (e) {

                alert(e);

            }

        });
    },

    events: function () {

        $('body').delegate('input[name="btnCadastrarSetor"]', 'click', function () { pageSetor.createSector(); })

    },

    config: function () {

        pageSetor.events();

    },

    init: function () {

        pageSetor.config();

    }

};

$(document).ready(function () {

    pageSetor.init();

});