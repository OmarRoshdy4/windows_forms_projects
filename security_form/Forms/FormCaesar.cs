using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace security_form.Forms
{
    public partial class FormCaesar : Form
    {
        // a b c d e f g h i j k l m n o p q r s t u v w x y z
        // ----------------cipher algorithm-------------------
        string encryptedText = "";
        char[] arr = new char[26];
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

        public FormCaesar()
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

        private void FormCaesar_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int index;
            encryptedText = "";
            string lowerMessage = txtMessage.Text.ToLower();
            for (int i = 0; i < txtMessage.Text.Length; i++)
            {
                if (char.IsWhiteSpace(lowerMessage[i]))
                {
                    encryptedText += " ";
                    continue;
                }
                index = (findIndexOf(lowerMessage[i]) + int.Parse(txtKey.Text)) % 26;
                if (index < 0)
                {
                    index += 26;
                }
                encryptedText += arr[index];
            }
            txtCipher.Text = encryptedText;
            //:::::::::::::::::::::::::::::::::::::
            //char ch;
            //for (int i = 0; i < txtMessage.Text.Length; i++)
            //{
            //    ch = txtMessage.Text[i];

            //    // Encrypt for lower case
            //    if (ch>='a'&&ch<='z')
            //    {
            //        ch = (char)(ch + int.Parse(txtKey.Text));
            //        if (ch > 'z')
            //        {
            //            ch = (char)(ch - 'z' + 'a' - 1);
            //        }
            //        encryptedText += ch;
            //    }
            //}
            //txtCipher.Text = encryptedText;
            //MessageBox.Show(encryptedText);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int index;
            encryptedText = "";
            string lowerMessage = txtMessage.Text.ToLower();
            for (int i = 0; i < txtMessage.Text.Length; i++)
            {
                index = (findIndexOf(lowerMessage[i]) - int.Parse(txtKey.Text)) % 26;
                if (index < 0)
                {
                    index += 26;
                }
                encryptedText += arr[index];
            }
            
            txtCipher.Text = encryptedText;
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


    }
}
