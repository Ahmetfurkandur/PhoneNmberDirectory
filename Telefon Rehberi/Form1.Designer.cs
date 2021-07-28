namespace Telefon_Rehberi
{
    partial class Form1
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
            this.dgwDirectories = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxEmailAdress = new System.Windows.Forms.TextBox();
            this.tbxNameAndSurname = new System.Windows.Forms.TextBox();
            this.lblEmailAdress = new System.Windows.Forms.Label();
            this.lblNameAndSurname = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxPhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.tbxEmailAdressUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameAndSurnameUpdate = new System.Windows.Forms.TextBox();
            this.lblEMailAdressUpdate = new System.Windows.Forms.Label();
            this.lblNameAndSurnameUpdate = new System.Windows.Forms.Label();
            this.lblNameAndSurnamSearch = new System.Windows.Forms.Label();
            this.tbxNamaAndSurnameSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDirectories)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDirectories
            // 
            this.dgwDirectories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDirectories.Location = new System.Drawing.Point(12, 43);
            this.dgwDirectories.Name = "dgwDirectories";
            this.dgwDirectories.Size = new System.Drawing.Size(402, 314);
            this.dgwDirectories.TabIndex = 0;
            this.dgwDirectories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDirectories_CellClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Controls.Add(this.tbxPhoneNumber);
            this.gbxAdd.Controls.Add(this.tbxEmailAdress);
            this.gbxAdd.Controls.Add(this.tbxNameAndSurname);
            this.gbxAdd.Controls.Add(this.lblEmailAdress);
            this.gbxAdd.Controls.Add(this.lblNameAndSurname);
            this.gbxAdd.Location = new System.Drawing.Point(430, 12);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(224, 165);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "EKLE";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon Numarası";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(118, 104);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxPhoneNumber.TabIndex = 5;
            // 
            // tbxEmailAdress
            // 
            this.tbxEmailAdress.Location = new System.Drawing.Point(118, 68);
            this.tbxEmailAdress.Name = "tbxEmailAdress";
            this.tbxEmailAdress.Size = new System.Drawing.Size(100, 20);
            this.tbxEmailAdress.TabIndex = 4;
            // 
            // tbxNameAndSurname
            // 
            this.tbxNameAndSurname.Location = new System.Drawing.Point(118, 31);
            this.tbxNameAndSurname.Name = "tbxNameAndSurname";
            this.tbxNameAndSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxNameAndSurname.TabIndex = 3;
            // 
            // lblEmailAdress
            // 
            this.lblEmailAdress.AutoSize = true;
            this.lblEmailAdress.Location = new System.Drawing.Point(22, 71);
            this.lblEmailAdress.Name = "lblEmailAdress";
            this.lblEmailAdress.Size = new System.Drawing.Size(74, 13);
            this.lblEmailAdress.TabIndex = 2;
            this.lblEmailAdress.Text = "E-posta adresi";
            // 
            // lblNameAndSurname
            // 
            this.lblNameAndSurname.AutoSize = true;
            this.lblNameAndSurname.Location = new System.Drawing.Point(22, 38);
            this.lblNameAndSurname.Name = "lblNameAndSurname";
            this.lblNameAndSurname.Size = new System.Drawing.Size(60, 13);
            this.lblNameAndSurname.TabIndex = 1;
            this.lblNameAndSurname.Text = "Adı, Soyadı";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblPhoneNumber);
            this.gbxUpdate.Controls.Add(this.tbxPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.tbxEmailAdressUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameAndSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.lblEMailAdressUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameAndSurnameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(430, 192);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(224, 165);
            this.gbxUpdate.TabIndex = 2;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "GÜNCELLE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Ekle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(22, 111);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(90, 13);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Telefon Numarası";
            // 
            // tbxPhoneNumberUpdate
            // 
            this.tbxPhoneNumberUpdate.Location = new System.Drawing.Point(118, 104);
            this.tbxPhoneNumberUpdate.Name = "tbxPhoneNumberUpdate";
            this.tbxPhoneNumberUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxPhoneNumberUpdate.TabIndex = 5;
            // 
            // tbxEmailAdressUpdate
            // 
            this.tbxEmailAdressUpdate.Location = new System.Drawing.Point(118, 68);
            this.tbxEmailAdressUpdate.Name = "tbxEmailAdressUpdate";
            this.tbxEmailAdressUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxEmailAdressUpdate.TabIndex = 4;
            // 
            // tbxNameAndSurnameUpdate
            // 
            this.tbxNameAndSurnameUpdate.Location = new System.Drawing.Point(118, 31);
            this.tbxNameAndSurnameUpdate.Name = "tbxNameAndSurnameUpdate";
            this.tbxNameAndSurnameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxNameAndSurnameUpdate.TabIndex = 3;
            // 
            // lblEMailAdressUpdate
            // 
            this.lblEMailAdressUpdate.AutoSize = true;
            this.lblEMailAdressUpdate.Location = new System.Drawing.Point(22, 71);
            this.lblEMailAdressUpdate.Name = "lblEMailAdressUpdate";
            this.lblEMailAdressUpdate.Size = new System.Drawing.Size(74, 13);
            this.lblEMailAdressUpdate.TabIndex = 2;
            this.lblEMailAdressUpdate.Text = "E-posta adresi";
            // 
            // lblNameAndSurnameUpdate
            // 
            this.lblNameAndSurnameUpdate.AutoSize = true;
            this.lblNameAndSurnameUpdate.Location = new System.Drawing.Point(22, 38);
            this.lblNameAndSurnameUpdate.Name = "lblNameAndSurnameUpdate";
            this.lblNameAndSurnameUpdate.Size = new System.Drawing.Size(60, 13);
            this.lblNameAndSurnameUpdate.TabIndex = 1;
            this.lblNameAndSurnameUpdate.Text = "Adı, Soyadı";
            // 
            // lblNameAndSurnamSearch
            // 
            this.lblNameAndSurnamSearch.AutoSize = true;
            this.lblNameAndSurnamSearch.Location = new System.Drawing.Point(58, 22);
            this.lblNameAndSurnamSearch.Name = "lblNameAndSurnamSearch";
            this.lblNameAndSurnamSearch.Size = new System.Drawing.Size(76, 13);
            this.lblNameAndSurnamSearch.TabIndex = 3;
            this.lblNameAndSurnamSearch.Text = "İsime göre ara:";
            // 
            // tbxNamaAndSurnameSearch
            // 
            this.tbxNamaAndSurnameSearch.Location = new System.Drawing.Point(140, 12);
            this.tbxNamaAndSurnameSearch.Name = "tbxNamaAndSurnameSearch";
            this.tbxNamaAndSurnameSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxNamaAndSurnameSearch.TabIndex = 4;
            this.tbxNamaAndSurnameSearch.TextChanged += new System.EventHandler(this.tbxNamaAndSurnameSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 369);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxNamaAndSurnameSearch);
            this.Controls.Add(this.lblNameAndSurnamSearch);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwDirectories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDirectories)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDirectories;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxEmailAdress;
        private System.Windows.Forms.TextBox tbxNameAndSurname;
        private System.Windows.Forms.Label lblEmailAdress;
        private System.Windows.Forms.Label lblNameAndSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxPhoneNumberUpdate;
        private System.Windows.Forms.TextBox tbxEmailAdressUpdate;
        private System.Windows.Forms.TextBox tbxNameAndSurnameUpdate;
        private System.Windows.Forms.Label lblEMailAdressUpdate;
        private System.Windows.Forms.Label lblNameAndSurnameUpdate;
        private System.Windows.Forms.Label lblNameAndSurnamSearch;
        private System.Windows.Forms.TextBox tbxNamaAndSurnameSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}

