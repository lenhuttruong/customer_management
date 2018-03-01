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
        public static void insertData(string path, string str)
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
            }
        }

        public static void editData(string path, string id, string str)
        {
            string tempFile = Path.GetTempFileName();
            try
            {
                StreamReader sr = new StreamReader(path);
                StreamWriter sw = new StreamWriter(tempFile);
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.IndexOf(id) == -1)
                        {
                            sw.WriteLine(line);
                        }
                        else
                        {
                            sw.WriteLine(str);
                        }
                    }
                }

                File.Delete(path);
                File.Move(tempFile, path);
            }
            catch (Exception Ex)
            {
            }
        }

        public static void deleteData(string path, string str)
        {
            string tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllLines(tempFile, File.ReadLines(path).Where(l => l.IndexOf(str) == -1));

                File.Delete(path);
                File.Move(tempFile, path);
            }
            catch (Exception Ex)
            {
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
            }
            return result;
        }
    }
}
