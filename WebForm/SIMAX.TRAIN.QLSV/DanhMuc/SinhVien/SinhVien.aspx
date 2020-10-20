<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutPages/QuanLy.master" AutoEventWireup="true" CodeBehind="SinhVien.aspx.cs" Inherits="SIMAX.TRAIN.QLSV.DanhMuc.SinhVien.SinhVien" %>

<asp:Content ID="SinhVienLayout" ContentPlaceHolderID="QuanLyLayout" runat="server">
    <script>
        var arrItem = [];
        var count = 0;
        var obj = {
            txtName: "Trần Mạnh Hùng",
            dtpBirth: "2000-12-02",
            txtLocal: "Lâm Đồng",
            txtClass: "12A1",
            rdoSex: "Nam",
            cboAcademicPower: "Khá",
            cboConduct: "Tốt",
            txtSubElective: "",
        }
        arrItem.push(obj);
        $(document).ready(function () {
            $.each(arrItem, function (key, item) {
                DisplayItem(key, item);
            });
            SearchItem();
            ShowActionForm(null);
            $(".btn-warning").click(function () {
                $("#frmAction").show();
            })
        })
        function ShowActionForm(key) {

            if (key == null) {
                $("#btnAdd").click(function () {
                    TakeForm("add")
                    $("#ui-id-1").text("Thêm học sinh");
                    $("#frmAction").dialog("open")
                });
            }
            else {
                TakeForm("edit")
                ShowEditItem(key)
            }

        }
        function TakeForm(key) {
            count++;
            if (count == 1) {
                $.post("/DanhMuc/SinhVien/ActionForm.aspx", {}, function (reuslt) {
                    $("#jdialog").html(reuslt);
                    $("#frmAction").smDialog({autoClose: true});

                    if (key == "add") {
                        $("#btnSave").show();
                        $("#btnEdit").hide();
                    }
                    else if (key == "edit") {
                        $("#btnSave").hide();
                        $("#btnEdit").show();
                        $("#frmAction").dialog("close");
                    }

                })
                return true;
            }
            else {
                $("#btnSave").show();
                $("#btnEdit").hide();
                $("#frmAction").dialog("close");
                return false;
            }

        }
        function DisplayItem(key, obj) {
            $("tbody").after("<tr class= \"size-3 bottomTable\" >" +
                "<th scope=\"row\">" +
                ++key + "</th><td>" +
                obj.txtName + "</td><td>" +
                obj.dtpBirth + "</td><td>" +
                obj.rdoSex + "</td><td>" +
                obj.txtLocal + "</td><td>" +
                obj.txtClass + "</td><td>" +
                obj.cboAcademicPower + "</td><td>" +
                obj.cboConduct + "</td><td class=\"d-flex\">" +
                "<div class=\"mr-1\">" +
                "<button type=\"button\"   onclick=\"DeleteItem(arrItem," + --key + ")\" class=\"btn btn-danger\">Xóa</button>" +
                "</div>" +
                "<div class=\"ml-1\">" +
                "<button type=\"button\"onclick=\"ShowActionForm(" + key + ")\" class=\"btn btn-warning\">Sữa</button>" +
                "</div>" +
                "</td></tr >"
            );
        };
        function DeleteItem(arrItem, index) {
            arrItem.splice(index, 1);
            $(".bottomTable").html("");
            $.each(arrItem, function (key, item) {
                DisplayItem(key, item);
            })
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
            $("#cboSex").on("change", function () {
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
    </script>
    <div class="row">
        <h5 class="card-title">Danh Sách Học Sinh</h5>
    </div>
    <div class="row">
        <div class="col-5">
            <button type="button" id="btnAdd" class="btn btn-primary  mt-2">Thêm</button>
        </div>
        <div class="col-7 d-flex">
            <select class="custom-select w-25 mt-2" id="cboSex">
                <option value="all">Giới Tính</option>
                <option value="Nam">Nam</option>
                <option value="Nữ">Nữ</option>
            </select>
            <nav class="navbar navbar-light ">
                <input class="form-control" id="txtSearch" type="search" placeholder="Tìm Kiếm Theo Tên" aria-label="Search">
            </nav>
        </div>
    </div>
    <div class="row">
        <table class="table mt-3 table-hover">
            <thead>
                <tr>
                    <th scope="col">STT</th>
                    <th scope="col">Họ Tên</th>
                    <th scope="col">Ngày Sinh</th>
                    <th scope="col">Giới Tính</th>
                    <th scope="col">Nơi Sinh</th>
                    <th scope="col">Lớp</th>
                    <th scope="col">Học Lực</th>
                    <th scope="col">Hành Kiểm</th>
                    <th scope="col"></th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
    <div class="row">
        <div id="jdialog"></div>
    </div>
</asp:Content>
