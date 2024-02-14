using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            this.staffDal = staffDal;
        }

        public void TDelete(Staff t)
        {
            staffDal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return staffDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return staffDal.GetList();
        }

        public void TInsert(Staff t)
        {
            staffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            staffDal.Update(t);
        }
    }
}
