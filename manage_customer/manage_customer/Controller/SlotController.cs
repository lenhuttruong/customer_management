using manage_customer.DAO;
using manage_customer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_customer.Controller
{

    class SlotController
    {
        SlotModel slotModel = new SlotModel();
        public List<Slot> getAllSlot()
        {
            return slotModel.getAllSlot();
        }

        public List<Slot> getBySearchString(string searchString)
        {
            return slotModel.getBySearchString(searchString);
        }

        public Boolean addSlot(Slot slot)
        {
            return slotModel.addSlot(slot);
        }

        public Boolean editSlot(Slot slot)
        {
            return slotModel.editSlot(slot);
        }

        public Boolean deleteSlot(string id)
        {
            return slotModel.deleteSlot(id);
        }
    }
}
