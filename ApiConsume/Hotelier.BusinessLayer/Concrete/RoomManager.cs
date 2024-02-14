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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            this.roomDal = roomDal;
        }

        public void TDelete(Room t)
        {
            roomDal.Delete(t);
        }

        public Room TGetByID(int id)
        {
            return roomDal.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            roomDal.Update(t);
        }
    }
}
