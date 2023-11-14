namespace security_form.Forms
{
    partial class FormMonoAlphabetic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnSaveThisKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cipher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(129, 85);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(500, 32);
            this.txtKey.TabIndex = 17;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtCipher
            // 
            this.txtCipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipher.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtCipher.Location = new System.Drawing.Point(129, 141);
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(500, 32);
            this.txtCipher.TabIndex = 16;
            this.txtCipher.TextChanged += new System.EventHandler(this.txtCipher_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(129, 38);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(500, 32);
            this.txtMessage.TabIndex = 15;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDecrypt.BackColor = System.Drawing.Color.DarkRed;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecrypt.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnDecrypt.Location = new System.Drawing.Point(467, 250);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(126, 52);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEncrypt.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEncrypt.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnEncrypt.Location = new System.Drawing.Point(129, 250);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(126, 52);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerateKey.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGenerateKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerateKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateKey.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnGenerateKey.Location = new System.Drawing.Point(129, 193);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(154, 34);
            this.btnGenerateKey.TabIndex = 21;
            this.btnGenerateKey.Text = "generate new key";
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnSaveThisKey
            // 
            this.btnSaveThisKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveThisKey.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSaveThisKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveThisKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveThisKey.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveThisKey.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnSaveThisKey.Location = new System.Drawing.Point(307, 193);
            this.btnSaveThisKey.Name = "btnSaveThisKey";
            this.btnSaveThisKey.Size = new System.Drawing.Size(154, 34);
            this.btnSaveThisKey.TabIndex = 22;
            this.btnSaveThisKey.Text = "Save this key";
            this.btnSaveThisKey.UseVisualStyleBackColor = false;
            this.btnSaveThisKey.Click += new System.EventHandler(this.btnSaveThisKey_Click);
            // 
            // FormMonoAlphabetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(660, 341);
            this.Controls.Add(this.btnSaveThisKey);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "FormMonoAlphabetic";
            this.Text = "FormMonoAlphabetic";
            this.Load += new System.EventHandler(this.FormMonoAlphabetic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnSaveThisKey;
    }
}