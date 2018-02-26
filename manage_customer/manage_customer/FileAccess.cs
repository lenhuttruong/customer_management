using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_customer
{
    class FileAccess
    {
        public void writeData(string path, string str)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(str);

                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not add customer!");
            }
        }

        public string readData(string path)
        {
            string result = "";
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                result = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not get customer!");
            }
            return result;
        }
    }
}
