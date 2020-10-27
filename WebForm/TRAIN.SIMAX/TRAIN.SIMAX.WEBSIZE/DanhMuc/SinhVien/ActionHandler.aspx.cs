using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TRAIN.SIMAX.DATA;

namespace TRAIN.SIMAX.WEBSIZE.DanhMuc.SinhVien
{
    public partial class ActionHandler : System.Web.UI.Page
    {
        string doAction = "";
        JEntity jMessage = new JEntity();
        ManageStudentEntities dbManage;
        DmTinhNangDAP dapTinhNang;
        protected void Page_Load(object sender, EventArgs e)
        {
            dbManage = new ManageStudentEntities();
            dapTinhNang = new DmTinhNangDAP(dbManage);

            doAction = Request["do"];
            switch (doAction)
            {
                case "add":
                    Add();
                    break;
                case "edit":
                    Update();
                    break;
                case "delete":
                    Delete();
                    break;
                default:
                    break;
            }

            RenderMessage(jMessage);
        }
        private void Add()
        { }
        private void Update()
        { }
        private void Delete()
        { }

        protected void RenderMessage<T>(T _object)
        {
            try
            {
                System.Web.Script.Serialization.JavaScriptSerializer oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                oSerializer.MaxJsonLength = Int32.MaxValue;
                string strJsonMessage = oSerializer.Serialize(_object);
                this.Page.Response.Clear();
                this.Page.Response.ContentType = "application/json";
                this.Page.Response.Write(strJsonMessage);
                this.Page.Response.End();
            }
            catch { }
        }
    }
    public class JEntity
    {
        public JEntity() { Erros = true; }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string jsonData { get; set; }
        public bool Erros { get; set; }
        public string Message { get; set; }

    }
}