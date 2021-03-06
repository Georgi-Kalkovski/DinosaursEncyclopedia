﻿var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/dinosaurs/getall",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "imageUrl", "render": function (data) {
                    return `
                             <img src="${data}" class="img-fluid">
                             <a href="${data}" class="link-preview venobox" data-gall="portfolioGallery"><i class="ion ion-eye"></i></a>
                           `
                }},
            { "data": "name", "width": "20%" },
            { "data": "period", "width": "20%" },
            { "data": "diet", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                        <a href="/dinosaurs/upsert?id=${data}" class='btn btn-success text-black' style='cursor:pointer; width:70px;'>
                            Edit
                        </a>
                        &nbsp;
                        <a class='btn btn-danger text-white' style='cursor:pointer; width:70px;'
                            onclick=Delete('/dinosaurs/delete?id='+${data})>
                            Delete
                        </a>
                        </div>`;
                }, "width": "20%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "are you?",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}

