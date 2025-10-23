// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function () {
    getDatatable('#tabela-contatos');
    getDatatable('#tabela-usuarios')
});

function getDatatable(id) {
        $(id).DataTable({
        "ordering": true,
        "searching": true,
        "paging": true,
        "oLanguage": {
            "sEmptyTable": "everyone is dead :(",
            "sInfo": "showing _START_ to _END_ of _TOTAL_ sillies",
            "sInfoEmpty": "showing 0 to 0 of 0 sillies",
            "sInfoFiltered": "(Filtrados de _MAX_ registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "_MENU_ number of sillies per page",
            "sLoadingRecords": "loading...",
            "sProcessing": "blast processing...",
            "sZeroRecords": "everyone is dead :(",
            "sSearch": "search for the sillies!!!!",
            "oPaginate": {
                "sNext": "next",
                "sPrevious": "unnext",
                "sFirst": "unnexest",
                "sLast": "nexest"
            },
            "oAria": {
                "sSortAscending": ": ASCENDING ORDER I HARDLY KNOW ER",
                "sSortDescending": ": DESCENDING ORDER I HARDLY KNOW ER"
            }
        }
    });
}

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});