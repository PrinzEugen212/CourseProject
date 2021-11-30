
namespace CorseProject.Forms
{
    partial class CreateClientForm
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
            this.bAdd = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.bCancel = new System.Windows.Forms.Button();
            this.lFullName = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(156, 114);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(85, 29);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(134, 47);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(228, 27);
            this.tbPhone.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(134, 14);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 27);
            this.tbName.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(134, 81);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(228, 27);
            this.dtpDate.TabIndex = 15;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(247, 113);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(85, 29);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lFullName
            // 
            this.lFullName.AutoSize = true;
            this.lFullName.Location = new System.Drawing.Point(13, 15);
            this.lFullName.Name = "lFullName";
            this.lFullName.Size = new System.Drawing.Size(95, 20);
            this.lFullName.TabIndex = 17;
            this.lFullName.Text = "Полное имя";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(13, 47);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(69, 20);
            this.lPhone.TabIndex = 18;
            this.lPhone.Text = "Телефон";
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Location = new System.Drawing.Point(13, 81);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(116, 20);
            this.lBirthDate.TabIndex = 19;
            this.lBirthDate.Text = "Дата рождения";
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.lBirthDate);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lFullName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Name = "CreateClientForm";
            this.Text = "AddClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lFullName;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lBirthDate;
    }
}