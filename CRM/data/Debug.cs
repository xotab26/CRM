using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.data
{
    public class Debug
    {
        public void Message(string message)
        {
            if (Mains.debug)
                MessageBox.Show("Debug: " + message);
        }

        public void Log(string message)
        {
            if (!File.Exists(Mains.LogPatch)) System.IO.File.WriteAllText(Mains.LogPatch, "");

            FileStream fileStream = new FileStream(@"C:\" + "\\" + "Log" + ".txt", FileMode.Open);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.BaseStream.Seek(fileStream.Length, SeekOrigin.Begin);
            streamWriter.WriteLine(message);
            streamWriter.Close();
            fileStream.Close();
        }
    }
}
