using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my
{

    public class newForm : Form
    {
        public newForm()
        {
            InitializeComponent();
        }

        private void Form1_Load()
        {
            // Creating and setting the properties of Lable1
            Label Mylablel1 = new Label();
            Mylablel1.Location = new Point(96, 54);
            Mylablel1.Text = "Enter Name";
            Mylablel1.AutoSize = true;
            Mylablel1.BackColor = Color.LightGray;

            // Add this label to form
            this.Controls.Add(Mylablel1);

            // Creating and setting the properties of TextBox1
            TextBox Mytextbox1 = new TextBox();
            Mytextbox1.Location = new Point(187, 51);
            Mytextbox1.BackColor = Color.LightGray;
            Mytextbox1.AutoSize = true;
            Mytextbox1.Name = "text_box1";
            Mytextbox1.Margin = new Padding(5, 5, 5, 5);

            // Add this textbox to form
            this.Controls.Add(Mytextbox1);

            // Creating and setting the properties of Lable1
            Label Mylablel2 = new Label();
            Mylablel2.Location = new Point(96, 102);
            Mylablel2.Text = "Enter Area";
            Mylablel2.AutoSize = true;
            Mylablel2.BackColor = Color.LightGray;

            this.Controls.Add(Mylablel2);

            // Creating and setting the properties of TextBox2
            TextBox Mytextbox2 = new TextBox();
            Mytextbox2.Location = new Point(187, 99);
            Mytextbox2.BackColor = Color.LightGray;
            Mytextbox2.AutoSize = true;
            Mytextbox2.Name = "text_box2";

            this.Controls.Add(Mytextbox2);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // newForm
            // 
            Form1_Load(); 
            this.ClientSize = new System.Drawing.Size(1441, 624);
            this.Name = "newForm";
            this.ResumeLayout(false);
        }
    }
}