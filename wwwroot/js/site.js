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
            "sLengthMenu": "_MENU_",
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
        },
        "initComplete": function () {
            // Find the standard DataTables length menu container
            var lengthMenu = $(this).closest('.dataTables_wrapper').find('.dataTables_length');
            var select = lengthMenu.find('select');

            // Create DaisyUI collapse structure
            var collapse = $('<div class="collapse collapse-arrow bg-primary text-primary-content mb-4 w-52"></div>');
            var checkbox = $('<input type="checkbox" />');
            var title = $('<div class="collapse-title text-xl font-medium">number of sillies</div>');
            var content = $('<div class="collapse-content bg-primary-content text-primary"></div>');

            // Style the select to look nice inside
            select.addClass('select select-bordered w-full max-w-xs mt-2');

            // Assemble
            content.append(select);
            collapse.append(checkbox);
            collapse.append(title);
            collapse.append(content);

            // Replace content
            lengthMenu.html(collapse);
        }
    });
}

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});