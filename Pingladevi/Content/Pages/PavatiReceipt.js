var SavePavati = function () {
    var id = $("#txtId").val();
    var date = $("#txtDate").val();
    var name = $("#txtName").val();
    var mobileno = $("#txtMobileno").val();
    var paymentinword = $("#txtPaymentInWord").val();
    var paymentinno = $("#txtPaymentInNo").val();

    var model = {
        Id: id,
        Date: date,
        Name: name,
        Mobileno: mobileno,
        PaymentInWord: paymentinword,
        PaymentInNo: paymentinno,
    };

    alert("hii");
    $.ajax({
        url: "/Pavati/SavePavati",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",

        success: function (response) {
            console.log(response.message);
            alert("Successfull");

            /*detail(reponse.message);*/
        }
    })
};

var detail = function (id) {
    var model = { ID: id };

    $.ajax({
        url: "/Pavati/GetDetailData ",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            $("#txtId").val(response.model.id);
            $("#txtDate").val(response.model.date);
            $("#txtnamesame").val(response.model.name);
            $("#txtmobilenosame").val(response.model.mobileno);
            $("#txtpaymentinwordsame").val(response.model.paymentinword);
            $("#txtpaymentinnosame").val(response.model.paymentinno);
        }
    });
}