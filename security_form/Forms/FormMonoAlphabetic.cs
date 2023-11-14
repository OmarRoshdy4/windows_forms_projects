using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace security_form.Forms
{
    public partial class FormMonoAlphabetic : Form
    {
        char[] arr = new char[26];
        public FormMonoAlphabetic()
        {
            InitializeComponent();
            // Generate letters   abcde . . . xyz

            int i = 0;
            char lettter = 'a';
            while (i < 26)
            {
                arr[i++] = lettter++;
            }
        }

        // Generating Random Key Function:
        public void GenerateRandomChars()
        {
            Random r = new Random();
            char tmp;
            string generated = ((char)('a' + r.Next(0, 26))).ToString();
         
            while (generated.Length < 26)
            {
                tmp = (char)('a' + r.Next(0, 26));
                if (!generated.Contains(tmp))
                {
                    generated += tmp;
                }
            }
            txtKey.Text = generated;
        }


        // Find index function
        string encryptedText = "";
        
        private int findIndexOf(char chr)
        {
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] == chr)
                {
                    return i;
                }
            }
            return -1;
        }
        int findIndexInRandomKey(char chr)
        {
            for (int i = 0; i < 26; i++)
            {
                if (chr == txtKey.Text[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private void FormMonoAlphabetic_Load(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // when we write, we write with this ABCDEFGHIJKLMNOPQRSTUVWXYZ
            //                                   ydwfxboahenlcsijgzmrtvqupk
            //replace 'a' with 'y' :: replace 'b' with 'd' and so on!
            int index;
            string encryptedText = "";

            // Convert user message to lower case
            string lowerMessage = txtMessage.Text.ToLower();
            for (int i = 0; i < txtMessage.TextLength; i++)
            {
                if (char.IsWhiteSpace(lowerMessage[i]))
                {
                    encryptedText += " ";
                    continue;
                }
                index = findIndexOf(lowerMessage[i]);
                encryptedText += txtKey.Text[index];
            }

            txtCipher.Text = encryptedText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            
            int index;
            string decryptedMessage = "";
            // Convert user message to lower case
            string lowerMessage = txtMessage.Text.ToLower();
            for (int i = 0; i < txtMessage.TextLength; i++)
            {
                if (char.IsWhiteSpace(lowerMessage[i]))
                {
                    decryptedMessage += " ";
                    continue;
                }
                index = findIndexInRandomKey(lowerMessage[i]);
                decryptedMessage += arr[index];
                txtCipher.Text = decryptedMessage;
                MessageBox.Show(arr[index].ToString());
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            GenerateRandomChars();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveThisKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("no keys generated yet.");
                return;
            }
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string path = Path.Combine(folderBrowserDialog.SelectedPath, "Keys.txt");
                    try
                    {
                        File.AppendAllText(path, txtKey.Text + "\n");
                        MessageBox.Show("Successfully saved at\n" + path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


    }
}
