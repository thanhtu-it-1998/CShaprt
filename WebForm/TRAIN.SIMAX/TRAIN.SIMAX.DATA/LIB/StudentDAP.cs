using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAIN.SIMAX.DATA
{
    public class StudentDAP
    {
        ManageStudent dbManage;

        public StudentDAP(ManageStudent _dbManage)
        {
            dbManage = _dbManage;
        }

        public DMStudent getByID(string Id)
        {
            return dbManage.DMStudents.Where(el => el.ID == Id).FirstOrDefault();
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

        public List<DMStudentEntities> getPages()
        {
            var query = (from obj in dbManage.DMStudents
                         select new DMStudentEntities
                         {
                             ID = obj.ID,
                             IDClass = obj.IDClass,
                             LastName = obj.LastName,
                             FirstName = obj.LastName,
                             Address = obj.Address,
                             BirthDay = obj.BirthDay,
                             Phone = obj.Phone,
                             Sex = obj.Sex
                         });
            return query.ToList();
        }
    }
}
