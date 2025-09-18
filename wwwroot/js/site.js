import DataTable from 'datatables.net-dt';
 
let table = new DataTable('#tabela-contatos');

// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//i'm keeping it in mind that THIS bit of code might break and fuck everything up
$(document).ready(function () {
    $('#tabela-contatos').DataTable();
});
$('.close-alert').click(function () {
    $('.alert').hide('hide');
})
//alright so the problem:
//the fuckwads who made evolua forgot to update 