using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Process copy = new Process();
            copy.StartInfo.FileName = "cmd.exe";
            copy.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            copy.StartInfo.CreateNoWindow = true;

            for (int i = 0; i <= 13; i++) //копируем данные за 2 недели
            {
                string date = DateTime.Now.AddDays(-i).ToString("yyyyMMdd");
                
                //команда с папками назначения и параметрами копирования
                string settings = "/C robocopy.exe E:\\2\\" + date + " E:\\1\\" + date + " /DCOPY:T /E /R:2 /W:5 /unilog+:log\\Copy.log"; 

                copy.StartInfo.Arguments = settings ;
                copy.Start();
                copy.WaitForExit();

            }
            
        }
    }
}
