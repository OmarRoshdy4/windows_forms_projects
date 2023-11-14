using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace security_form
{
    public partial class Form1 : Form

    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        // Form Construcor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Methods
        private Color SelectThemeColor() {

            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
           
           
        }

        private void ActivateButton(object btnSender)
        {
            try
            {
                if (btnSender != null)
                {
                    if (currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        Color color = SelectThemeColor();
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = color;
                        currentButton.ForeColor = Color.White;
                        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
            catch (Exception) { }
        }

        private void DisableButton()
        {
            try
            {
                foreach (Control previousBtn in panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                        previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnCaesar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new Forms.FormCaesar(), sender);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnMonoAlphabetic_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenChildForm(new Forms.FormMonoAlphabetic(), sender);
            }
            catch (Exception)
            {


            }
        }

        private void btnPolyAlphabetic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new Forms.FormPolyAlphabetic(), sender);
            }
            catch (Exception)
            {
            }
        }

        private void btnPlayFair_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new Forms.FormPlayFair(), sender);
            }
            catch (Exception)
            {
                
            }
        }

        private void brnDictionaryType1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new Forms.FormDictionaryType1(), sender);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnDictionaryType2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new Forms.FormDictionaryType2(), sender);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnMEssageDigest5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new Forms.FormMessageDigest5(), sender);
            }
            catch (Exception)
            {
                
            }
        }

        // Method to open another forms in panelDesktopPane
        private void OpenChildForm(Form childForm, object btnSender)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                ActivateButton(btnSender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                labelTitle.Text = childForm.Text;
            }
            catch (Exception)
            {

            }
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
