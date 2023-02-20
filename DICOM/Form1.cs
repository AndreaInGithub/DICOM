using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Dicom;
using Dicom.Imaging;

namespace DICOM
{
    public partial class Form1 : Form
    {


        string PicturePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)//注意，此处一定要手动引入System.Window.Forms空间，否则你如果使用默认的DialogResult会发现没有OK属性
            {
                PicturePath = openFileDialog.FileName;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("C:\\Users\\kuror\\PycharmProjects\\pythonProject\\dist\\main\\main.exe");
            p.WaitForExit();//
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }



//-------------------------------------------------------------------------------------------------------------------------------------



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Load(PicturePath);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }




 //-------------------------------------------------------------------------------------------------------------------------------------       

        private void mouse_click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X,MousePosition.Y);
            }
        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)//注意，此处一定要手动引入System.Window.Forms空间，否则你如果使用默认的DialogResult会发现没有OK属性
            {
                PicturePath = openFileDialog.FileName;
            }
        }
    }
}
