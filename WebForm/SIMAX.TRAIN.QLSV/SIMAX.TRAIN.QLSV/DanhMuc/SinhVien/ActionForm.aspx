<script>
    var arrItem = [];
    var obj = {
        txtName: "Trần Mạnh Hùng",
        dtpBirth: "20-12-2000",
        txtLocal: "Lâm Đồng",
        txtClass: "12A1",
        rdoSex: "Nam",
        cboAcademicPower: "Khá",
        cboConduct: "Tốt",
        txtDescription: "",
        txtSubElective: "",
    }
    arrItem.push(obj);
    $(document).ready(function () {
        $.each(arrItem, function (key, item) {
            DisplayItem(key, item);
        })
        $("#frmAction").dialog({
            autoOpen: false,
            width: 900,
            title: "",
            show: { effect: "blink", duration: 1000 },
            hide: { effect: "explode", duration: 1000 },
            resizable: false,
            modal: true,
            button: {
            }
        });
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
        $("#btnAdd").click(function () {
            $("#ui-id-1").text("Thêm học sinh");
            $("#btnSave").show();
            $("#btnEdit").hide();
            $("#frmAction").dialog("open");
        })
        $("#btnSave").click(function () {
            if ($("#frmAction").valid()) {
                var getInfor = GetInfor();
                if (ExistenceCheck()) {
                    arrItem.push(getInfor);
                    //DisplayItem();
                    $(".bottomTable").remove();
                    $.each(arrItem, function (key, item) {
                        DisplayItem(key, item);
                    })
                    $("#frmAction")[0].reset();
                    $("#frmAction").dialog("close");
                }
            };
        })
        CancelForm();
    }
    function DeleteItem(arrItem, index) {
        arrItem.splice(index, 1);
        $(".bottomTable").remove();
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
        $("#txtSubElective").val(arrItem[key].txtSubElective);

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

                    $(".bottomTable").remove();
                    $.each(arrItem, function (key, item) {
                        DisplayItem(key, item);
                    })
                    $("#frmAction")[0].reset();
                    $("#frmAction").dialog("close");
                }
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
            var subElective = $("input [name = txtSubElective]:checked");
            var subElectives = []
            for (let index = 0; index < subElective.length; index++) {
                subElectives.push(subElective[index].val());
            }
            return subElectives.toString();
        }

        student.rdoSex = sex();
        student.txtSubElective = sub();

        return student;
    }
    function SearchItem() {
        $("#txtSearch").on("keyup", function (event) {
            if (event.keyCode == 13) {
                var value = $(this).val().toLowerCase();
                $(".bottomTable").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            }
        });
        $("#cboSex").on("change",function () {
            var value = $(this).val().toLowerCase();
            if (value == "all") {
                $(".bottomTable").remove();
                $.each(arrItem, function (key, item) {
                    DisplayItem(key, item);
                })
            }
            else {
                
                $(".bottomTable").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            }
        })
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
</script>


<form id="frmAction">
    <div class="row">
        <div class="col-6">
            <div class="form-group">
                <label for="txtName">Họ và tên (<span class="text-danger">*</span>)</label>
                <input type="text" class="form-control" id="txtName" name="txtName">
            </div>
            <div class="form-group">
                <label for="dtpBirth">Ngày Sinh (<span class="text-danger">*</span>)</label>
                <input type="date" class="form-control w-100" id="dtpBirth" name="dtpBirth">
            </div>
            <div class="form-group">
                <label>Giới Tính: </label>
                <div class="form-check form-check-inline">
                    <input class="form-check-input" type="radio" checked name="rdoSex" value="1">
                    <label class="form-check-label" for="inlineRadio1">Nam</label>
                </div>
                <div class="form-check form-check-inline">
                    <input class="form-check-input" type="radio" name="rdoSex" value="0">
                    <label class="form-check-label" for="inlineRadio2">Nữ</label>
                </div>
            </div>
            <div class="form-group">
                <label for="txtLocal">Nới Sinh (<span class="text-danger">*</span>)</label>
                <input type="text" class="form-control w-100" id="txtLocal" name="txtLocal">
            </div>
            <div class="form-grounp form-row">
                <div class="col">
                    <label for="txtClass">Lớp (<span class="text-danger">*</span>) </label>
                    <input type="text" class="form-control w-100" id="txtClass" name="txtClass">
                </div>
                <div class="col">
                    <label for="cboAcademicPower">Học Lực: </label>
                    <select class="custom-select" id="cboAcademicPower">
                        <option value="Giỏi">Giỏi</option>
                        <option value="Khá">Khá</option>
                        <option value="Trung Bình">Trung Bình</option>
                        <option value="Yếu">Yếu</option>
                    </select>
                </div>
                <div class="col">
                    <div class="col">
                        <label for="cboConduct">Hạnh Kiểm: </label>
                        <select class="custom-select" id="cboConduct">
                            <option value="Đạt">Đạt</option>
                            <option value="Không Đạt">Không Đạt</option>
                        </select>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-6">
            <div class="form-group">
                <label for="txtDescription">Miêu tả:</label>
                <textarea class="form-control rounded-0" id="txtDescription" style="resize: none; outline: none;" rows="6" cols="12"></textarea>
            </div>
            <div class="form-check">
                <label for="txtSubElective">Môn Tự Chọn:</label>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name="txtSubElective" id="txtToan" value="Toán">
                    <label for="txtToan" class="custom-control-label">Toán</label>
                </div>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name="txtSubElective" id="txtLy" value="Lý">
                    <label for="txtLy" class="custom-control-label">Lý</label>
                </div>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name="txtSubElective" id="txtHoa" value="Hóa">
                    <label for="txtHoa" class="custom-control-label">Hóa</label>
                </div>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name="txtSubElective" id="txtSinh" value="Sinh">
                    <label for="txtSinh" class="custom-control-label">Sinh</label>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="form-group">
            <input type="text" class="custom-control-input" name="txtID" id="txtID" hidden value="">
        </div>
    </div>
    <div class="row justify-content-end d-flex ">
        <div class="listBtn mt-3 mr-2">
            <button type="button" class="btn btn-primary" id="btnSave">Thêm</button>
            <button type="button" class="btn btn-warning" id="btnEdit">Sửa</button>
            <button type="button" class="btn btn-danger" id="btnCancel">Hủy</button>
        </div>
    </div>
</form>
