/**********************************************************************************************************************************************************
***													SAKARYA ÜNİVERSİTESİ
***											BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
***												BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
***											   NESNEYE DAYALI PROGRAMLAMA DERSİ
***
***								ÖDEV NUMARASI...: 2. Ödev 2. Soru
***								ÖĞRENCİ ADI.....: Sezer Bulgur
***								ÖĞRENCİ NUMARASI: b201210060
***								DERS GRUBU......: 1. Öğretim C grubu
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
    

    public partial class Form1 : Form
    {
        public static class matris
        {

            public static double[,] topla(double[,] matris1, double[,] matris2)
            {
                double[,] sonuc = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sonuc[i, j] = (matris1[i, j] + matris2[i, j]);

                    }
                }
                return sonuc;

            }

            public static double[,] carp(double[,] matris1, double[,] matris2)
            {
                double[,] carpım = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            carpım[i, j] += matris1[i, k] * matris2[k, j];
                        }
                    }
                }
                return carpım;
            }

            public static void yaz(double[,] matris1)
            {
                Random rast = new Random();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matris1[i, j] = rast.Next(10);
                    }
                }
            }

            public static double izBul(double[,] matris1)
            {

                double sonuc = 0;
                for (int i = 0; i < 3; i++)
                {
                    sonuc += matris1[i, i];
                }
                return sonuc;
            }

            public static double determinant(double[,] matris1)
            {
                double determinant = 0;
                double sonuc = 1;
                for (int k = 0; k < 3; k++)
                {
                    int j = k;
                    for (int i = 0; i < 3; i++)
                    {

                        sonuc *= matris1[i % 3, j % 3];
                        j++;

                    }
                    determinant += sonuc;
                    sonuc = 1;
                }
                for (int k = 0; k < 3; k++)
                {
                    int j = k;
                    for (int i = 2; i >= 0; i--)
                    {

                        sonuc *= matris1[i % 3, j % 3];
                        j++;
                    }
                    determinant -= sonuc;
                    sonuc = 1;
                }
                return determinant;
            }


            public static double[,] transpozu(double[,] matris1)
            {
                double[,] sonuc = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sonuc[j, i] = matris1[i, j];
                    }
                }
                return sonuc;
            }

            public static double[,] ekMatris(double[,] matris1)
            {
                double[,] sonucMatris = new double[3, 3];

                double[,] coMatris = new double[2, 2];

                double detCoMatris;
                int a = 0, b = 0;

                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            if (x == i)
                            {
                                continue;
                            }

                            for (int y = 0; y < 3; y++)
                            {
                                if (y == j)
                                {
                                    continue;
                                }
                                coMatris[a % 2, b % 2] = matris1[x, y];
                                b++;
                                if (b % 2 == 0)
                                {
                                    a++;
                                }


                            }

                        }

                        detCoMatris = coMatris[0, 0] * coMatris[1, 1]
                            - coMatris[0, 1] * coMatris[1, 0];
                        sonucMatris[i, j] = Math.Pow((-1), ((i + 1) + (j + 1))) * detCoMatris;
                    }

                }
                sonucMatris = matris.transpozu(sonucMatris);

                return sonucMatris;
            }

            public static double[,] tersiniBul(double[,] matris1)
            {
                double[,] sonucMatris = new double[3, 3];
                double[,] ekMatris = new double[3, 3];
                double det = matris.determinant(matris1);
                ekMatris = matris.ekMatris(matris1);

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sonucMatris[i, j] = (1 / det) * (ekMatris[i, j]);
                        sonucMatris[i, j] = Math.Round(sonucMatris[i, j], 2);
                    }
                }
                return sonucMatris;
            }

           
        }


        string path = Path.Combine(Environment.CurrentDirectory, "islemler.txt");

        double[,] matrisA = new double[3, 3];
        double[,] matrisB = new double[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void numA00_ValueChanged(object sender, EventArgs e)
        {
            matrisA[0, 0] = Convert.ToDouble(numA00.Value);
        }

        private void numA01_ValueChanged(object sender, EventArgs e)
        {
            matrisA[0, 1] = Convert.ToDouble(numA01.Value);
        }

        private void numA02_ValueChanged(object sender, EventArgs e)
        {
            matrisA[0, 2] = Convert.ToDouble(numA02.Value);
        }

        private void numA10_ValueChanged(object sender, EventArgs e)
        {
            matrisA[1, 0] = Convert.ToDouble(numA10.Value);
        }

        private void numA11_ValueChanged(object sender, EventArgs e)
        {
            matrisA[1, 1] = Convert.ToDouble(numA11.Value);
        }

        private void numA12_ValueChanged(object sender, EventArgs e)
        {
            matrisA[1, 2] = Convert.ToDouble(numA12.Value);
        }

        private void numA20_ValueChanged(object sender, EventArgs e)
        {
            matrisA[2, 0] = Convert.ToDouble(numA20.Value);
        }

        private void numA21_ValueChanged(object sender, EventArgs e)
        {
            matrisA[2, 1] = Convert.ToDouble(numA21.Value);
        }

        private void numA22_ValueChanged(object sender, EventArgs e)
        {
            matrisA[2, 2] = Convert.ToDouble(numA22.Value);
        }

        private void numB00_ValueChanged(object sender, EventArgs e)
        {
            matrisB[0, 0] = Convert.ToDouble(numB00.Value);
        }

        private void numB01_ValueChanged(object sender, EventArgs e)
        {
            matrisB[0, 1] = Convert.ToDouble(numB01.Value);
        }

        private void numB02_ValueChanged(object sender, EventArgs e)
        {
            matrisB[0, 2] = Convert.ToDouble(numB02.Value);
        }

        private void numB10_ValueChanged(object sender, EventArgs e)
        {
            matrisB[1, 0] = Convert.ToDouble(numB10.Value);
        }

        private void numB11_ValueChanged(object sender, EventArgs e)
        {
            matrisB[1, 1] = Convert.ToDouble(numB11.Value);
        }

        private void numB12_ValueChanged(object sender, EventArgs e)
        {
            matrisB[1, 2] = Convert.ToDouble(numB12.Value);
        }

        private void numB20_ValueChanged(object sender, EventArgs e)
        {
            matrisB[2, 0] = Convert.ToDouble(numB20.Value);
        }

        private void numB21_ValueChanged(object sender, EventArgs e)
        {
            matrisB[2, 1] = Convert.ToDouble(numB21.Value);
        }

        private void numB22_ValueChanged(object sender, EventArgs e)
        {
            matrisB[2, 2] = Convert.ToDouble(numB22.Value);
        }

        private void butTopla_Click(object sender, EventArgs e)
        {
            sonucKutusu.Clear();
            string sonuc = "";
            string gecmis = "";
            double[,] sonucMatrisi = matris.topla(matrisA, matrisB);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sonuc += Convert.ToString(sonucMatrisi[i, j]) + "  ";
                }

                sonuc += "\n";
            }
            sonucKutusu.Text = sonuc;

            gecmis = "^^^^^^^^^^^^^^^^^^^\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisA[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "+\n";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisB[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "=\n" + sonuc;

            gecmis += "^^^^^^^^^^^^^^^^^^^\n";

            StreamWriter yaz = File.AppendText(path);
            yaz.Write(gecmis);
            yaz.Close();

        }

        private void butCarp_Click(object sender, EventArgs e)
        {
            sonucKutusu.Clear();
            string sonuc = "";
            string gecmis = "";
            double[,] sonucMatrisi = matris.topla(matrisA, matrisB);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sonuc += Convert.ToString(sonucMatrisi[i, j]) + "  ";
                }

                sonuc += "\n";
            }
            sonucKutusu.Text = sonuc;

            gecmis = "^^^^^^^^^^^^^^^^^^^\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisA[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "*\n";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisB[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "=\n" + sonuc;

            gecmis += "^^^^^^^^^^^^^^^^^^^\n";

            StreamWriter yaz = File.AppendText(path);
            yaz.Write(gecmis);
            yaz.Close();
        }

        private void butGecmis_Click(object sender, EventArgs e)
        {
            gecmisKutusu.LoadFile(path, RichTextBoxStreamType.PlainText);
        }

        private void butYaz_Click(object sender, EventArgs e)
        {
            matris.yaz(matrisA);
            numA00.Value = Convert.ToDecimal(matrisA[0, 0]);
            numA01.Value = Convert.ToDecimal(matrisA[0, 1]);
            numA02.Value = Convert.ToDecimal(matrisA[0, 2]);
            numA10.Value = Convert.ToDecimal(matrisA[1, 0]);
            numA11.Value = Convert.ToDecimal(matrisA[1, 1]);
            numA12.Value = Convert.ToDecimal(matrisA[1, 2]);
            numA20.Value = Convert.ToDecimal(matrisA[2, 0]);
            numA21.Value = Convert.ToDecimal(matrisA[2, 1]);
            numA22.Value = Convert.ToDecimal(matrisA[2, 2]);
        }

        private void butTranspoz_Click(object sender, EventArgs e)
        {       
            sonucKutusu.Clear();
            string sonuc = "";
            string gecmis = "";
            double[,] sonucMatrisi = matris.transpozu(matrisA);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sonuc += Convert.ToString(sonucMatrisi[i, j]) + "  ";
                }

                sonuc += "\n";
            }
            sonucKutusu.Text = sonuc;

            gecmis = "^^^^^^^^^^^^^^^^^^^\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisA[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "matrisinin transpozu:\n" + sonuc;

            gecmis += "^^^^^^^^^^^^^^^^^^^\n";

            StreamWriter yaz = File.AppendText(path);
            yaz.Write(gecmis);
            yaz.Close();
        }
     
        private void butIz_Click(object sender, EventArgs e)
        {
            sonucKutusu.Clear();
            string sonuc = "";
            string gecmis = "";
            sonuc = Convert.ToString(matris.izBul(matrisA));
            sonucKutusu.Text = sonuc;

            gecmis = "^^^^^^^^^^^^^^^^^^^\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisA[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "matrisinin izi:\n" + sonuc;

            gecmis += "^^^^^^^^^^^^^^^^^^^\n";

            StreamWriter yaz = File.AppendText(path);
            yaz.Write(gecmis);
            yaz.Close();
        }

        private void butDeterminant_Click(object sender, EventArgs e)
        {
            sonucKutusu.Clear();
            string sonuc = "";
            string gecmis = "";
            sonuc = Convert.ToString(matris.determinant(matrisA));
            sonucKutusu.Text = sonuc;

            gecmis = "^^^^^^^^^^^^^^^^^^^\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisA[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "matrisinin determinanti:\n" + sonuc;

            gecmis += "^^^^^^^^^^^^^^^^^^^\n";

            StreamWriter yaz = File.AppendText(path);
            yaz.Write(gecmis);
            yaz.Close();
        }

        private void butEkMatris_Click(object sender, EventArgs e)
        {
            sonucKutusu.Clear();
            string sonuc = "";
            string gecmis = "";
            double[,] sonucMatrisi = matris.ekMatris(matrisA);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sonuc += Convert.ToString(sonucMatrisi[i, j]) + "  ";
                }

                sonuc += "\n";
            }
            sonucKutusu.Text = sonuc;

            gecmis = "^^^^^^^^^^^^^^^^^^^\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisA[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "matrisinin ek matrisi:\n" + sonuc;

            gecmis += "^^^^^^^^^^^^^^^^^^^\n";

            StreamWriter yaz = File.AppendText(path);
            yaz.Write(gecmis);
            yaz.Close();
        }

        private void butTers_Click(object sender, EventArgs e)
        {
            sonucKutusu.Clear();
            string sonuc = "";
            string gecmis = "";
            double[,] sonucMatrisi = matris.tersiniBul(matrisA);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sonuc += Convert.ToString(sonucMatrisi[i, j]) + "  ";
                }

                sonuc += "\n";
            }
            sonucKutusu.Text = sonuc;

            gecmis = "^^^^^^^^^^^^^^^^^^^\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gecmis += Convert.ToString(matrisA[i, j] + "  ");

                }

                gecmis += "\n";
            }

            gecmis += "matrisinin tersi:\n" + sonuc;

            gecmis += "^^^^^^^^^^^^^^^^^^^\n";

            StreamWriter yaz = File.AppendText(path);
            yaz.Write(gecmis);
            yaz.Close();
        }

        private void butCıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
