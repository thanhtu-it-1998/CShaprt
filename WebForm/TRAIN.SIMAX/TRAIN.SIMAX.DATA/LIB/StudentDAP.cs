using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAIN.SIMAX.DATA
{
    public class StudentDAP
    {
        ManageStudentEntities dbManage;
        public StudentDAP(ManageStudentEntities _dbManage)
        {
            dbManage = _dbManage;
        }
        
        public DMStudent getByID(string Id)
        {
            return dbManage.DMStudents.Where(el => el.ID == Int32.Parse(Id)).FirstOrDefault();
        }

        public int Add(DMStudent objStudent)
        {
            dbManage.DMStudents.Add(objStudent);
            return dbManage.SaveChanges();
        }

        public int Save()
        {
            return dbManage.SaveChanges();
        }

        public int Delete(string Id)
        {
            DMStudent objStudetn = getByID(Id);
            dbManage.DMStudents.Remove(objStudetn);
            return dbManage.SaveChanges();
        }
    }
}
