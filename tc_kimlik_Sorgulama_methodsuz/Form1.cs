using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tc_kimlik_Sorgulama_methodsuz
{
    public partial class Form1 : Form
    {

        int[] tc = new int[11];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            string tckimlikno = txt_tcno.Text;

            if (txt_tcno.Text!=" ")
            {
                if (tckimlikno.Length == 11)
                {
                    if (long.TryParse(tckimlikno, out long result))
                    {
                        for (int i = 0; i < tc.Length; i++)
                        {

                            tc[i] = int.Parse(tckimlikno.Substring(i, 1));
                        }

                        if (tc[0] != 0)
                        {

                            int a = ((tc[0] + tc[2] + tc[4] + tc[6] + tc[8]) * 7) + ((tc[1] + tc[3] + tc[5] + tc[7]) * 9);

                            if (a % 10 == tc[9])
                            {
                                int toplam = tc[0] + tc[2] + tc[4] + tc[6] + tc[8] + tc[1] + tc[3] + tc[5] + tc[7] + tc[9];

                                if (toplam % 10 == tc[10])
                                {
                                    int toplam2 = tc[0] + tc[2] + tc[4] + tc[6] + tc[8];

                                    if ((toplam2 * 8) % 10 == tc[10])
                                    {
                                        MessageBox.Show("Geçerli Tc");
                                    }
                                    else
                                    {
                                        MessageBox.Show("6.maddeye uymuyor");
                                    }
                                }
                                else
                                {

                                    MessageBox.Show("5.maddeye uymuyor");
                                }

                            }
                            else
                            {
                                MessageBox.Show("4.maddeye uymuyor");
                            }

                        }
                        else
                        {
                            MessageBox.Show("tc no sıfırla başlayamaz!");

                        }


                    }
                    else
                    {
                        MessageBox.Show("girilen değer doğru formatta değil");
                    }

                }
                else
                {
                    MessageBox.Show("girilen değer 11 karakter olmalıdır!");
                }
            }

          





































            //string tckimlikno = txt_tcno.Text;
            //if (txt_tcno.Text!=" ")
            //{
            //    if (tckimlikno.Length == 11)
            //    {
            //        if (int.TryParse(tckimlikno, out int result))
            //        {

            //            for (int i = 0; i < tc.Length; i++)
            //            {
            //                tc[i] = int.Parse(tckimlikno.Substring(i, 1));
                           
            //            }
            //            if (tc[0]!=0)
            //            {
            //              if( (((tc[0]+tc[2]+tc[4]+tc[6]+tc[8])*7) + ((tc[0] + tc[2] + tc[4] + tc[6]*9)) ) % 10 == tc[9])


            //            }
            //            else
            //            {
            //                MessageBox.Show("ilk hanesi sıfır olamaz");
            //            }


            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lütfen doğru bir format giriniz");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("lütfen bir değer giriniz");
            //}



        }
    }
}
