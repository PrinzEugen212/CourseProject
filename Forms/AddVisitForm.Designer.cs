
namespace CorseProject.Forms
{
    partial class AddVisitForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.tbAssigment = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.cbAnimals = new System.Windows.Forms.ComboBox();
            this.bAddAnimal = new System.Windows.Forms.Button();
            this.lUserName = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.bAddClient = new System.Windows.Forms.Button();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDate.TabIndex = 0;
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Location = new System.Drawing.Point(11, 188);
            this.tbDiagnosis.Multiline = true;
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(249, 135);
            this.tbDiagnosis.TabIndex = 1;
            // 
            // tbAssigment
            // 
            this.tbAssigment.Location = new System.Drawing.Point(11, 329);
            this.tbAssigment.Multiline = true;
            this.tbAssigment.Name = "tbAssigment";
            this.tbAssigment.Size = new System.Drawing.Size(249, 135);
            this.tbAssigment.TabIndex = 2;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(90, 470);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(94, 29);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAddClick);
            // 
            // cbAnimals
            // 
            this.cbAnimals.FormattingEnabled = true;
            this.cbAnimals.Location = new System.Drawing.Point(12, 112);
            this.cbAnimals.Name = "cbAnimals";
            this.cbAnimals.Size = new System.Drawing.Size(209, 28);
            this.cbAnimals.TabIndex = 4;
            // 
            // bAddAnimal
            // 
            this.bAddAnimal.Location = new System.Drawing.Point(228, 112);
            this.bAddAnimal.Name = "bAddAnimal";
            this.bAddAnimal.Size = new System.Drawing.Size(33, 29);
            this.bAddAnimal.TabIndex = 5;
            this.bAddAnimal.Text = "+";
            this.bAddAnimal.UseVisualStyleBackColor = true;
            this.bAddAnimal.Click += new System.EventHandler(this.bAddAnimal_Click);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUserName.Location = new System.Drawing.Point(12, 147);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(65, 28);
            this.lUserName.TabIndex = 6;
            this.lUserName.Text = "label1";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(12, 45);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(250, 27);
            this.dtpTime.TabIndex = 7;
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(228, 78);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(33, 29);
            this.bAddClient.TabIndex = 9;
            this.bAddClient.Text = "+";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(12, 78);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(209, 28);
            this.cbClients.TabIndex = 8;
            // 
            // AddVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 530);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.bAddAnimal);
            this.Controls.Add(this.cbAnimals);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbAssigment);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.dtpDate);
            this.Name = "AddVisitForm";
            this.Text = "AddVisitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbDiagnosis;
        private System.Windows.Forms.TextBox tbAssigment;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ComboBox cbAnimals;
        private System.Windows.Forms.Button bAddAnimal;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.ComboBox cbClients;
    }
}