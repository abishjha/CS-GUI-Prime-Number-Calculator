using System;
using System.Windows.Forms;
using System.Threading;

namespace ajha_lab13
{
     public partial class Form1 : Form
     {
          static int endPoint = 2;
          static Thread thread;

          public Form1()
          {
               InitializeComponent();
          }

          private void calculateButton_Click(object sender, EventArgs e)
          {
               resultListBox.Items.Clear();

               try
               {
                    endPoint = Int32.Parse(endPointNumber.Text);
               }
               catch
               {
                    MessageBox.Show("invalid number. please enter an integer");
                    return;
               }

               calculateButton.Enabled = false;
               cancelButton.Enabled = true;

               //Thread thread = new Thread();
               thread = new Thread(new ThreadStart(PrimeFunc));
               thread.Start();
          }

          void PrimeFunc()
          {
               for (int i = 2; i < endPoint; i++)
               {
                    if (isPrime(i))
                         resultListBox.Items.Add(i.ToString());
               }

               calculateButton.Enabled = true;
               cancelButton.Enabled = false;
          }

          static bool isPrime(int num)
          {
               if (num >= 2)
               {
                    for (int i = 2; i < num / 2 + 1; i++)
                    {
                         if (num % i == 0)
                              return false;
                    }
               }
               else
                    return false;
               return true;
          }

          private void cancelButton_Click(object sender, EventArgs e)
          {
               thread.Abort();

               calculateButton.Enabled = true;
               cancelButton.Enabled = false;
          }
     }
}
