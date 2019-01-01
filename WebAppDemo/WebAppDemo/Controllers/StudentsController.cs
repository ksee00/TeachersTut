using SekolahDataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
//using System.Data.Entity;


namespace WebAppDemo.Controllers
{
    public class StudentsController : ApiController
    {
        //Database db = new Database();

        //public StudentsController()
        //{
        //    db.Configuration.ProxyCreationEnabled = false;
        //}

         public IEnumerable<Student> Get()
        {
            using (SekolahDBEntities entities = new SekolahDBEntities())
            {
                return entities.Students.ToList();
            }
        }

        public Student Get(int id)
        {
            using (
                SekolahDBEntities entities = new SekolahDBEntities())
            {
                Student _stu = new Student();
                _stu = entities.Students.FirstOrDefault(e => e.StudentId == id);
                return _stu;
                //return entities.Students.FirstOrDefault(e => e.StudentId == id);
            }
        }

    }
}
