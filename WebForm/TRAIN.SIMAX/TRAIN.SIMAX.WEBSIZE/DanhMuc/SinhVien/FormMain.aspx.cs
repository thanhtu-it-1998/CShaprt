using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TRAIN.SIMAX.DATA;

namespace TRAIN.SIMAX.WEBSIZE.DanhMuc.SinhVien
{
    public partial class FormMain : System.Web.UI.Page
    {
        public List<DMStudentEntities> lstStudent = new List<DMStudentEntities>();
        public ManageStudent manageStudent = new ManageStudent();
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDAP studentDAP = new StudentDAP(manageStudent);
            lstStudent = studentDAP.getPages();
        }                                
    }                                   
}                                       
                                         
