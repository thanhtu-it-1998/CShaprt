
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
                <label for=" chkSubElective">Môn Tự Chọn:</label>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name="chkSubElective" id="txtToan" value="Toán">
                    <label for="txtToan" class="custom-control-label">Toán</label>
                </div>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name="chkSubElective" id="txtLy" value="Lý">
                    <label for="txtLy" class="custom-control-label">Lý</label>
                </div>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name="chkSubElective" id="txtHoa" value="Hóa">
                    <label for="txtHoa" class="custom-control-label">Hóa</label>
                </div>
                <div class="custom-control custom-checkbox">
                    <input type="checkbox" class="custom-control-input" name=" chkSubElective" id="txtSinh" value="Sinh">
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
<script src="/DanhMuc/SinhVien/ActionForm.js?v=1"></script>
<script>
    $(document).ready(function () {
        AddItem();
        CancelForm();
        EditItem();
    })
</script>