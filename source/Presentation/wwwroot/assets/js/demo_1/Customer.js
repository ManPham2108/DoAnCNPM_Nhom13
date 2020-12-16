(function ($) {
    $(function () {
        $(".DeleteCustomer").click(function () {
            var id = $(this).attr("id");
            if (confirm('Are you sure you want to delete this person has id: ' + id)) {
                $.ajax({
                    type: 'POST',
                    headers: {
                        "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
                    },
                    dataType: 'json',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Admin/Customer?handler=DeleteCustomer',
                    data: JSON.stringify({
                        Id: id
                    }),
                    success: function (respone) {
                        alert(respone);
                        location.reload();
                    }
                });
            }
        });
        $(".DetailCustomer").click(function () {
            var id = $(this).attr("id");
            // alert("Id1 " + id);
            $.ajax({
                type: 'GET',
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=DetailCustomer',
                data: {
                    id: id
                },
                success: function (result) {
                    // alert("Id2 " + result.Id);
                    $("#DetailCustomer-lastname").val(result.LastName);
                    $("#DetailCustomer-firstname").val(result.FirstName);
                    $("#DetailCustomer-birthday").val(result.Birthdate);
                    $("#DetailCustomer-phone").val(result.Phone);
                    $("#DetailCustomer-email").val(result.Email);
                    $("#DetailCustomer-address").val(result.Address.toString());
                    $("#DetailCustomer-status").val(result.Status);
                    $("#DetailCustomer-username").val(result.Username);
                    $("#DetailCustomer-password").val(result.Password);

                }
            });
        });
        $(".EditCustomer").click(function () {
            var id = $(this).attr("id");
            $.ajax({
                type: 'GET',
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=EditCustomer',
                data: {
                    id: id
                },
                success: function (result) {
                    // alert("Id2 " + result.Id);
                    $("#EditCustomerLock-id").val(result.Id);
                    $("#EditCustomerUnlock-id").val(result.Id);
                }
            });
        });
        $("#btsubmitEditCustomerLock").click(function () {
            var id = $('#EditCustomerLock-id').val();
            // alert(id);
            event.preventDefault();
            // event.preventDefault() là để ngăn thằng form nó load lại trang ..
            $.ajax({
                type: 'POST',
                headers: {
                    "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
                },
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=EditCustomerLock',
                data: JSON.stringify({
                    Id: id
                }),
                success: function (respone) {
                    alert("Disabled success");
                    location.reload();
                },
                failure: function (result) {
                    alert("fail");
                }

            });
        });
        $("#btsubmitEditCustomerUnlock").click(function () {
            var id = $('#EditCustomerUnlock-id').val();
            // alert(id);
            event.preventDefault();
            // event.preventDefault() là để ngăn thằng form nó load lại trang ..
            $.ajax({
                type: 'POST',
                headers: {
                    "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
                },
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=EditCustomerUnlock',
                data: JSON.stringify({
                    Id: id
                }),
                success: function (respone) {
                    alert("Active success");
                    location.reload();
                },
                failure: function (result) {
                    alert("fail");
                }

            });
        });
        $("#AddCustomer").click(function () {
            // alert("Create");
            var check = true;
            var test = true;
            // var id = $('#CreateCustomer-id').val();
            var firstname = $("#CreateCustomer-firstname").val();
            var lastname = $("#CreateCustomer-lastname").val();
            var username = $("#CreateCustomer-username").val();
            var password = $("#CreateCustomer-password").val();
            var password2 = $("#CreateCustomer-password2").val();
            var birthdate = $("#CreateCustomer-birthdate").val();
            var phone = $("#CreateCustomer-phone").val();
            var status = $("#CreateCustomer-status").val();
            var address = $("#CreateCustomer-address").val();
            alert(username + " " + password + " " + password2 + " " + birthdate);
            if (username.length == 0 || username.length > 20) {
                $("#z-CreateCustomer-username").removeClass("hidden-class");
                check = false;
            } else {
                $("#z-CreateCustomer-username").addClass("hidden-class");
            }
            if (password.length == 0 || password.length > 20) {
                $("#z-CreateCustomer-password").removeClass("hidden-class");
                check = false;
            } else {
                $("#z-CreateCustomer-password").addClass("hidden-class");
                if (password2 == null || (password2 != password)) {
                    $("#z-CreateCustomer-password2").removeClass("hidden-class");
                    check = false;
                } else {
                    $("#z-CreateCustomer-password2").addClass("hidden-class");
                }
            }
            var patt = /[A-Za-z\s]+/;
            test = patt.test(firstname);
            if (test == false) {
                $("#z-CreateCustomer-firstname").removeClass("hidden-class");
                check = false;
            } else {
                $("#z-CreateCustomer-firstname").addClass("hidden-class");
            }
            test = patt.test(lastname);
            if (test == false) {
                $("#z-CreateCustomer-lastname").removeClass("hidden-class");
                check = false;
            } else {
                $("#z-CreateCustomer-lastname").addClass("hidden-class");
            }
            var patt = /0[0-9]{9,10}/;
            test = patt.test(phone);
            if (test == false) {
                $("#z-CreateCustomer-phone").removeClass("hidden-class");
                check = false;
            } else {
                $("#z-CreateCustomer-phone").addClass("hidden-class");
            }
            if (birthdate.length == 0) {
                $("#z-CreateCustomer-birthdate").removeClass("hidden-class");
                check = false;
            } else {
                $("#z-CreateCustomer-birthdate").addClass("hidden-class");
            }
            if (check == false) {
                alert("Fail");
                return;
            } else {
                alert("Well");
            }

            event.preventDefault();
            // event.preventDefault() là để ngăn thằng form nó load lại trang ..
            $.ajax({
                type: 'POST',
                headers: {
                    "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
                },
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=AddCustomer',
                data: JSON.stringify({
                    FirstName: firstname,
                    LastName: lastname,
                    Username: username,
                    Password: password,
                    Birthdate: birthdate,
                    Phone: phone,
                    JobId: job,
                    Salary: salary,
                    Status: status,
                    Address: address
                }),
                success: function (respone) {
                    // $('#CreateCustomer').modal('hide');
                    if (respone.trim() == "True") {
                        alert("Create success");
                        location.reload();
                    } else {
                        alert("This Id exists");
                        $('#CreateCustomer-username').focus();
                    }
                },
                failure: function (result) {
                    alert("fail");
                }

            });
        });
        // $("#btsubmitSearchCustomer").click(function () {
        //     var search = $('#SearchCustomer').val();
        //     event.preventDefault();
        //     // event.preventDefault() là để ngăn thằng form nó load lại trang ..
        //     $.ajax({
        //         type: 'POST',
        //         headers: {
        //             "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
        //         },
        //         dataType: 'json',
        //         contentType: 'application/json; charset=utf-8',
        //         url: '/Admin/Customer?handler=EditCustomer',
        //         data: {
        //             searchString: search
        //         },
        //         success: function (respone) {
        //             location.reload();
        //         },
        //         failure: function (result) {
        //             alert("fail");
        //         }

        //     });
        // });

    });
})(jQuery);