const { post } = require("jquery");

$(document).ready(function () {
    let skip = 2;
    let MenuCount = $("#MenuCount").val()
    $(document).on('click', '#LoadMore', function () {
        $.ajax({
            type: "GET",
            url: "/Dashboard/LoadMore/",
            data: {
                "skip": skip,
            },
            success: function (res) {
                $("#menuLists").append(res)
                skip += 2;
                if (MenuCount < skip) {
                    $("#LoadMore").remove()
                }
            }
        })
    })


    $(document).on('click', '.reply-btn', function () {
        $.ajax({
            type: "POST",
            url: "/Email/SendMessage/",
            type: "Get",
            data: {
                "message": $("#message").val(),
                "email": $("#email").val(),
                "subject": $("#subject").val(),
                "name": $("#name").val(),
            },
            success: function (res) {
                $("#SendMessage").empty();
                $("#SendMessage").append(res);
                if ($("#email").val() != null) {
                    $("#message").empty();
                    $("#email").empty();
                    $("#subject").empty();
                    $("#name").empty();
                };
            }
        })
    })


})

