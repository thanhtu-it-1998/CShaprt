<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/SinhVien/LayoutSinhVien.master" AutoEventWireup="true" CodeBehind="FormMain.aspx.cs" Inherits="TRAIN.SIMAX.WEBSIZE.DanhMuc.SinhVien.FormMain" %>

<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div id="top-main">
        <div class="row">
            <div class="col">
                <input class="form-control mr-sm-2" id="txtSeach" type="search" placeholder="Nhập tên muốn tìm kiếm" aria-label="Search">
            </div>
            <div class="col">
                <select class="custom-select" id="inputGroupSelect02">
                    <option selected>Chọn lớp</option>
                    <option value="1">Vật Lý</option>
                    <option value="2">Hóa Học</option>
                    <option value="3">Sinh Học</option>
                    <option value="3">Toán Học</option>
                </select>
            </div>
            <div class="col">
                <button type="button" class="btn btn-outline-primary" id="btnAdd" title="Thêm học sinh">
                    Thêm
                    <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-person-plus" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                        <path fill-rule="evenodd" d="M8 5a2 2 0 1 1-4 0 2 2 0 0 1 4 0zM6 8a3 3 0 1 0 0-6 3 3 0 0 0 0 6zm6 5c0 1-1 1-1 1H1s-1 0-1-1 1-4 6-4 6 3 6 4zm-1-.004c-.001-.246-.154-.986-.832-1.664C9.516 10.68 8.289 10 6 10c-2.29 0-3.516.68-4.168 1.332-.678.678-.83 1.418-.832 1.664h10zM13.5 5a.5.5 0 0 1 .5.5V7h1.5a.5.5 0 0 1 0 1H14v1.5a.5.5 0 0 1-1 0V8h-1.5a.5.5 0 0 1 0-1H13V5.5a.5.5 0 0 1 .5-.5z" />
                    </svg>
                </button>
            </div>
        </div>
    </div>
    <div id="bottom-main" class="mt-3">
        <table class="table text-center">
            <thead class="thead-light">
                <tr>
                    <th scope="col">STT</th>
                    <th scope="col">Họ tên</th>
                    <th scope="col">Địa chỉ</th>
                    <th scope="col">Ngày sinh</th>
                    <th scope="col">Số điện thoại</th>
                    <th scope="col">Giới tính</th>
                    <th scope="col"></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">1</th>
                    <td>Trương Thanh Tú</td>
                    <td>Huế</td>
                    <td>03-09-1998</td>
                    <td>016503252356</td>
                    <td>Nam</td>
                    <td>
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <button type="button" class="btn btn-outline-primary " id="btnView" title="Xem thông tin">
                                <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-eye" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                    <path fill-rule="evenodd" d="M16 8s-3-5.5-8-5.5S0 8 0 8s3 5.5 8 5.5S16 8 16 8zM1.173 8a13.134 13.134 0 0 0 1.66 2.043C4.12 11.332 5.88 12.5 8 12.5c2.12 0 3.879-1.168 5.168-2.457A13.134 13.134 0 0 0 14.828 8a13.133 13.133 0 0 0-1.66-2.043C11.879 4.668 10.119 3.5 8 3.5c-2.12 0-3.879 1.168-5.168 2.457A13.133 13.133 0 0 0 1.172 8z" />
                                    <path fill-rule="evenodd" d="M8 5.5a2.5 2.5 0 1 0 0 5 2.5 2.5 0 0 0 0-5zM4.5 8a3.5 3.5 0 1 1 7 0 3.5 3.5 0 0 1-7 0z" />
                                </svg></button>
                            <button type="button" class="btn btn-outline-warning mr-1 ml-1" title="Chỉnh sữa thông tin ">
                                <svg width="1em" height="1em" viewBox="0 0 16 16" id="btnEdit" class="bi bi-brush-fill" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                    <path fill-rule="evenodd" d="M15.825.12a.5.5 0 0 1 .132.584c-1.53 3.43-4.743 8.17-7.095 10.64a6.067 6.067 0 0 1-2.373 1.534c-.018.227-.06.538-.16.868-.201.659-.667 1.479-1.708 1.74a8.117 8.117 0 0 1-3.078.132 3.658 3.658 0 0 1-.563-.135 1.382 1.382 0 0 1-.465-.247.714.714 0 0 1-.204-.288.622.622 0 0 1 .004-.443c.095-.245.316-.38.461-.452.393-.197.625-.453.867-.826.094-.144.184-.297.287-.472l.117-.198c.151-.255.326-.54.546-.848.528-.739 1.2-.925 1.746-.896.126.007.243.025.348.048.062-.172.142-.38.238-.608.261-.619.658-1.419 1.187-2.069 2.175-2.67 6.18-6.206 9.117-8.104a.5.5 0 0 1 .596.04z" />
                                </svg></button>
                            <button type="button" class="btn btn-outline-danger" id="btnDelete" title="Xóa bỏ thông tin">
                                <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-archive" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                    <path fill-rule="evenodd" d="M0 2a1 1 0 0 1 1-1h14a1 1 0 0 1 1 1v2a1 1 0 0 1-1 1v7.5a2.5 2.5 0 0 1-2.5 2.5h-9A2.5 2.5 0 0 1 1 12.5V5a1 1 0 0 1-1-1V2zm2 3v7.5A1.5 1.5 0 0 0 3.5 14h9a1.5 1.5 0 0 0 1.5-1.5V5H2zm13-3H1v2h14V2zM5 7.5a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5z" />
                                </svg></button>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <script>
        $(document).ready(function () {
            $("#btnAdd").on("click", function () {
                $.post("DetailForm.aspx", { "do": "Add" }, function (data) {
                    alert("Thanh cong");
                });
            })
        })
    </script>
</asp:Content>
