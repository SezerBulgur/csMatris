/**********************************************************************************************************************************************************
***													SAKARYA �N�VERS�TES�
***											B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
***												B�LG�SAYAR M�HEND�SL��� B�L�M�
***											   NESNEYE DAYALI PROGRAMLAMA DERS�
***
***								�DEV NUMARASI...: 2. �dev 2. Soru
***								��RENC� ADI.....: Sezer Bulgur
***								��RENC� NUMARASI: b201210060
***								DERS GRUBU......: 1. ��retim C grubu
**********************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace b201210060_odev2_soru2
{
    
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

