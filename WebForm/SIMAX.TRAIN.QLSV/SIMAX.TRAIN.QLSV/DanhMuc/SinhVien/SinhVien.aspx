<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutPages/QuanLy.master" AutoEventWireup="true" CodeBehind="SinhVien.aspx.cs" Inherits="SIMAX.TRAIN.QLSV.DanhMuc.SinhVien.SinhVien" %>

<asp:Content ID="SinhVienLayout" ContentPlaceHolderID="QuanLyLayout" runat="server">
    <script>

        $(document).ready(function () {
            AddItem();
            EditItem();
            SearchItem();
        })
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
    <div class="row" id="dagAction">
        <!--#include file="ActionForm.aspx"-->
    </div>
</asp:Content>
