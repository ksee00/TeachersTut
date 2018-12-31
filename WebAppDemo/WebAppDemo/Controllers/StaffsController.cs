using SekolahDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppDemo.Controllers
{
    public class StaffsController : ApiController
    {
        public IEnumerable<Staff> Get()
        {
            using (
                SekolahDBEntities entities = new SekolahDBEntities())
            {
                return entities.Staffs.ToList();
            }
        }
    }
}
