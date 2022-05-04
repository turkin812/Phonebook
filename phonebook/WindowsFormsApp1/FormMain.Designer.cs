namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_DataBase = new System.Windows.Forms.TabControl();
            this.tabPageAbonents = new System.Windows.Forms.TabPage();
            this.dataGridViewAbonents = new System.Windows.Forms.DataGridView();
            this.tabPageContacts = new System.Windows.Forms.TabPage();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.tabPageProviders = new System.Windows.Forms.TabPage();
            this.dataGridViewProviders = new System.Windows.Forms.DataGridView();
            this.tabPagePhonebook = new System.Windows.Forms.TabPage();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxSNP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPhonebook = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabControl_DataBase.SuspendLayout();
            this.tabPageAbonents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbonents)).BeginInit();
            this.tabPageContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.tabPageProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).BeginInit();
            this.tabPagePhonebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhonebook)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_DataBase
            // 
            this.tabControl_DataBase.Controls.Add(this.tabPageAbonents);
            this.tabControl_DataBase.Controls.Add(this.tabPageContacts);
            this.tabControl_DataBase.Controls.Add(this.tabPageProviders);
            this.tabControl_DataBase.Controls.Add(this.tabPagePhonebook);
            this.tabControl_DataBase.Location = new System.Drawing.Point(13, 13);
            this.tabControl_DataBase.Name = "tabControl_DataBase";
            this.tabControl_DataBase.SelectedIndex = 0;
            this.tabControl_DataBase.Size = new System.Drawing.Size(775, 425);
            this.tabControl_DataBase.TabIndex = 0;
            // 
            // tabPageAbonents
            // 
            this.tabPageAbonents.Controls.Add(this.dataGridViewAbonents);
            this.tabPageAbonents.Location = new System.Drawing.Point(4, 25);
            this.tabPageAbonents.Name = "tabPageAbonents";
            this.tabPageAbonents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbonents.Size = new System.Drawing.Size(767, 396);
            this.tabPageAbonents.TabIndex = 0;
            this.tabPageAbonents.Text = "Abonents";
            this.tabPageAbonents.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAbonents
            // 
            this.dataGridViewAbonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbonents.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAbonents.Name = "dataGridViewAbonents";
            this.dataGridViewAbonents.RowHeadersWidth = 51;
            this.dataGridViewAbonents.RowTemplate.Height = 24;
            this.dataGridViewAbonents.Size = new System.Drawing.Size(767, 321);
            this.dataGridViewAbonents.TabIndex = 0;
            // 
            // tabPageContacts
            // 
            this.tabPageContacts.Controls.Add(this.dataGridViewContacts);
            this.tabPageContacts.Location = new System.Drawing.Point(4, 25);
            this.tabPageContacts.Name = "tabPageContacts";
            this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContacts.Size = new System.Drawing.Size(767, 396);
            this.tabPageContacts.TabIndex = 1;
            this.tabPageContacts.Text = "Contacts";
            this.tabPageContacts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.RowHeadersWidth = 51;
            this.dataGridViewContacts.RowTemplate.Height = 24;
            this.dataGridViewContacts.Size = new System.Drawing.Size(767, 321);
            this.dataGridViewContacts.TabIndex = 1;
            // 
            // tabPageProviders
            // 
            this.tabPageProviders.Controls.Add(this.dataGridViewProviders);
            this.tabPageProviders.Location = new System.Drawing.Point(4, 25);
            this.tabPageProviders.Name = "tabPageProviders";
            this.tabPageProviders.Size = new System.Drawing.Size(767, 396);
            this.tabPageProviders.TabIndex = 2;
            this.tabPageProviders.Text = "Providers";
            this.tabPageProviders.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProviders
            // 
            this.dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProviders.Name = "dataGridViewProviders";
            this.dataGridViewProviders.RowHeadersWidth = 51;
            this.dataGridViewProviders.RowTemplate.Height = 24;
            this.dataGridViewProviders.Size = new System.Drawing.Size(767, 321);
            this.dataGridViewProviders.TabIndex = 1;
            // 
            // tabPagePhonebook
            // 
            this.tabPagePhonebook.Controls.Add(this.textBoxPhoneNumber);
            this.tabPagePhonebook.Controls.Add(this.textBoxSNP);
            this.tabPagePhonebook.Controls.Add(this.label2);
            this.tabPagePhonebook.Controls.Add(this.label1);
            this.tabPagePhonebook.Controls.Add(this.dataGridViewPhonebook);
            this.tabPagePhonebook.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhonebook.Name = "tabPagePhonebook";
            this.tabPagePhonebook.Size = new System.Drawing.Size(767, 396);
            this.tabPagePhonebook.TabIndex = 3;
            this.tabPagePhonebook.Text = "Phoneboook";
            this.tabPagePhonebook.UseVisualStyleBackColor = true;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(78, 363);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(173, 22);
            this.textBoxPhoneNumber.TabIndex = 5;
            // 
            // textBoxSNP
            // 
            this.textBoxSNP.Location = new System.Drawing.Point(78, 335);
            this.textBoxSNP.Name = "textBoxSNP";
            this.textBoxSNP.Size = new System.Drawing.Size(270, 22);
            this.textBoxSNP.TabIndex = 4;
            this.textBoxSNP.TextChanged += new System.EventHandler(this.UpdateTable);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SNP :";
            // 
            // dataGridViewPhonebook
            // 
            this.dataGridViewPhonebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhonebook.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPhonebook.Name = "dataGridViewPhonebook";
            this.dataGridViewPhonebook.RowHeadersWidth = 51;
            this.dataGridViewPhonebook.RowTemplate.Height = 24;
            this.dataGridViewPhonebook.Size = new System.Drawing.Size(767, 321);
            this.dataGridViewPhonebook.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 445);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 53);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(170, 445);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(151, 53);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(327, 445);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(151, 53);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(484, 445);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(151, 53);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tabControl_DataBase);
            this.Name = "FormMain";
            this.Text = "Phonebook";
            this.tabControl_DataBase.ResumeLayout(false);
            this.tabPageAbonents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbonents)).EndInit();
            this.tabPageContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.tabPageProviders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).EndInit();
            this.tabPagePhonebook.ResumeLayout(false);
            this.tabPagePhonebook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhonebook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_DataBase;
        private System.Windows.Forms.TabPage tabPageAbonents;
        private System.Windows.Forms.DataGridView dataGridViewAbonents;
        private System.Windows.Forms.TabPage tabPageContacts;
        private System.Windows.Forms.TabPage tabPageProviders;
        private System.Windows.Forms.TabPage tabPagePhonebook;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.DataGridView dataGridViewProviders;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxSNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPhonebook;
    }
}

