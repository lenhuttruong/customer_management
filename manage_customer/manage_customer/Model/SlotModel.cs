﻿using manage_customer.DAO;
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

        public List<Customer> getBySearchString(string searchString)
        {
            List<Customer> result = new List<Customer>();
            List<string> data = new List<string>();
            try
            {
                data = FileAccess.findData(slotPath, searchString);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not find slot !");
            }

            Customer customer;
            foreach (string line in data)
            {
                customer = new Customer(line);
                result.Add(customer);
            }
            return result;
        }

        public Boolean addSlot(Slot slot)
        {
            string str = slot.convertToString();
            try
            {
                FileAccess.insertData(slotPath, str);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not add slot !");
                return false;
            }
            return true;
        }

        public Boolean editSlot(Slot slot)
        {
            string str = slot.convertToString();
            try
            {
                FileAccess.editData(slotPath, slot.Id, str);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not edit slot !");
                return false;
            }
            return true;
        }

        public Boolean deleteSlot(string id)
        {
            try
            {
                FileAccess.deleteData(slotPath, id);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not delete slot !");
                return false;
            }
            return true;
        }
    }
}
