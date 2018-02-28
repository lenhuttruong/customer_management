using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_customer
{
    public static class FileAccess
    {
        public static void writeData(string path, string str)
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
                MessageBox.Show("Can not add customer !");
            }
        }

        public static List<string> readData(string path)
        {
            List<string> result = new List<string>();
            string line;
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                while ((line = sr.ReadLine()) != null)
                {
                    result.Add(line);
                }
                sr.Close();
                sr.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not get customers !");
            }
            return result;
        }
    }
}
