/**********************************************************************************************************************************************************
***													SAKARYA ÜNÝVERSÝTESÝ
***											BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
***												BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
***											   NESNEYE DAYALI PROGRAMLAMA DERSÝ
***
***								ÖDEV NUMARASI...: 2. Ödev 2. Soru
***								ÖÐRENCÝ ADI.....: Sezer Bulgur
***								ÖÐRENCÝ NUMARASI: b201210060
***								DERS GRUBU......: 1. Öðretim C grubu
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

