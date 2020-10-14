
$(document).ready(function () {

    $("#frmAction").validate({
        rules: {
            txtName: "required",
            dtpBirth: "required",
            txtLocal: "required",
            txtClass: "required",
        }
    });


})
function AddItem() {
    $("#btnSave").click(function () {
        if ($("#frmAction").valid()) {
            var getInfor = GetInfor();
            if (ExistenceCheck()) {
                arrItem.push(getInfor);
                //DisplayItem();
                $(".bottomTable").html("");
                $.each(arrItem, function (key, item) {
                    DisplayItem(key, item);
                })
                $("#frmAction")[0].reset();
                $("#frmAction").dialog("close");
                $("#jdialog").html("");
            }
        };

    })
    CancelForm();
}
function DeleteItem(arrItem, index) {
    arrItem.splice(index, 1);
    $(".bottomTable").html("");
    $.each(arrItem, function (key, item) {
        DisplayItem(key, item);
    })
}
function ShowEditItem(key) {
    $("#ui-id-1").text("Sửa thông tin");

    $("#txtName").val(arrItem[key].txtName);
    $("#dtpBirth").val(arrItem[key].dtpBirth);
    $("#txtLocal").val(arrItem[key].txtLocal);
    $("#txtClass").val(arrItem[key].txtClass);
    $("#rdoSex").val(arrItem[key].rdoSex);
    $("#cboAcademicPower").val(arrItem[key].cboAcademicPower);
    $("#cboConduct").val(arrItem[key].cboConduct);
    $("#txtDescription").val(arrItem[key].txtDescription);
    $("#chkSubElective").val(arrItem[key].txtSubElective);

    $("#txtID").val(key);

    $("#btnSave").hide();
    $("#btnEdit").show();

    $("#frmAction").dialog("open");

}
function EditItem() {
    $("#btnEdit").click(function () {

        if ($("#frmAction").valid()) {
            var getInfor = GetInfor();
            if (ExistenceCheck()) {
                key = $("#txtID").val();
                arrItem[key] = getInfor;

                $(".bottomTable").html("");
                $.each(arrItem, function (key, item) {
                    DisplayItem(key, item);
                })
            }
            $("#frmAction")[0].reset();
            $("#frmAction").dialog("close");
        }
    })
}
function CancelForm() {
    $("#btnCancel").click(function () {
        $("#frmAction")[0].reset();
        $("label[class=\"error\"]").remove();
        $("#frmAction").dialog("close");
    });

}
function GetInfor() {
    student = {
        txtName: $("#txtName").val(),
        dtpBirth: $("#dtpBirth").val(),
        txtLocal: $("#txtLocal").val(),
        txtClass: $("#txtClass").val(),
        rdoSex: "",
        cboAcademicPower: $("#cboAcademicPower").val(),
        cboConduct: $("#cboConduct").val(),
        txtDescription: $("#txtDescription").val(),
        txtSubElective: "",
    }
    var sex = function () {
        return ($("input [name=rdoSex]:checked").val() == 1) ? "Nam" : "Nữ";
    }
    var sub = function () {
        var subElective = $("input [name =chkSubElective]:checked");
        var subElectives = []
        for (let index = 0; index < subElective.length; index++) {
            subElectives.push(subElective[index].val());
        }
        return subElectives.toString();
    }

    student.rdoSex = sex();
    student.chkSubElective = sub();

    return student;
}

function DisplayItem(key, obj) {
    $("tbody").after("<tr class= \"size-3 bottomTable\" ><th scope=\"row\">" + ++key + "</th><td>" + obj.txtName + "</td><td>" + obj.dtpBirth + "</td><td>" + obj.rdoSex + "</td><td>" + obj.txtLocal + "</td><td>" + obj.txtClass + "</td><td>" + obj.cboAcademicPower + "</td><td>" + obj.cboConduct + "</td><td class=\"d-flex\"><div class=\"mr-1\"><button type=\"button\"   onclick=\"DeleteItem(arrItem," + --key + ")\" class=\"btn btn-danger\">Xóa</button></div><div class=\"ml-1\"></div><button type=\"button\"onclick=\"ShowEditItem(" + key + ")\" class=\"btn btn-warning\">Sữa</button></td></tr >");
}
function ExistenceCheck(arrItem, objItem) {
    for (item in arrItem) {
        if (arrItem[item].txtName == objItem.txtName && arrItem[item].txtLocal == objItem.txtLocal) {
            return false;
        }
    }
    return true;
}