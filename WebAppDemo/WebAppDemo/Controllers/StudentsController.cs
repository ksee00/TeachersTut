using SekolahDataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;


namespace WebAppDemo.Controllers
{
    public class StudentsController : ApiController
    {
        public IEnumerable<Student> Get()
        {
            using (
                
                SekolahDBEntities entities = new SekolahDBEntities())
            {
                return entities.Students.ToList();
            }
        }

    }
}
