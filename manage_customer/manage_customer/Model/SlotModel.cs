using manage_customer.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_customer.Model
{
    class SlotModel
    {
        private static string slotPath = Directory.GetCurrentDirectory() + "\\slot.dat";
        public List<Slot> getAllSlot()
        {
            List<Slot> result = new List<Slot>();
            List<string> data = new List<string>();
            try
            {
                data = FileAccess.readData(slotPath);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not get slots !");
            }

            Slot slot;
            foreach (string line in data)
            {
                slot = new Slot(line);
                result.Add(slot);
            }
            return result;
        }

        public Boolean addSlot(Slot slot)
        {
            string str = slot.convertToString();
            try
            {
                FileAccess.writeData(slotPath, str);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not add slot !");
                return false;
            }
            return true;
        }
    }
}
