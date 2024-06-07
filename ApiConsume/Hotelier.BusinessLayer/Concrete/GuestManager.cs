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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _GuestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _GuestDal = guestDal;
        }

        public void TDelete(Guest t)
        {
            _GuestDal.Delete(t);
        }

        public Guest TGetByID(int id)
        {
            return _GuestDal.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _GuestDal.GetList();
        }

        public void TInsert(Guest t)
        {
            _GuestDal.Insert(t);
        }

        public void TUpdate(Guest t)
        {
            _GuestDal.Update(t);
        }
    }
}
