﻿namespace WindowsFormsApp1
{
    partial class FormProviders
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
            this.label2 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.textBoxProviderName = new System.Windows.Forms.TextBox();
            this.textBoxProviderScore = new System.Windows.Forms.TextBox();
=======
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating:";
            // 
<<<<<<< HEAD
            // textBoxProviderName
            // 
            this.textBoxProviderName.Location = new System.Drawing.Point(101, 27);
            this.textBoxProviderName.Name = "textBoxProviderName";
            this.textBoxProviderName.Size = new System.Drawing.Size(136, 22);
            this.textBoxProviderName.TabIndex = 2;
            // 
            // textBoxProviderScore
            // 
            this.textBoxProviderScore.Location = new System.Drawing.Point(101, 76);
            this.textBoxProviderScore.Name = "textBoxProviderScore";
            this.textBoxProviderScore.Size = new System.Drawing.Size(136, 22);
            this.textBoxProviderScore.TabIndex = 3;
=======
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 3;
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(43, 120);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(94, 33);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "Save";
            this.buttonRegister.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.buttonRegister.Click += new System.EventHandler(this.buttonProviderRegister_Click);
=======
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(143, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.buttonCancel.Click += new System.EventHandler(this.buttonProviderCancel_Click);
=======
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
            // 
            // FormProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 176);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRegister);
<<<<<<< HEAD
            this.Controls.Add(this.textBoxProviderScore);
            this.Controls.Add(this.textBoxProviderName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProviders";
            this.Text = "Новый провайдер";
=======
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProviders";
            this.Text = "FormProviders";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox textBoxProviderName;
        private System.Windows.Forms.TextBox textBoxProviderScore;
=======
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonCancel;
    }
}