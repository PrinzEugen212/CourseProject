
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
            this.bAdd = new System.Windows.Forms.Button();
            this.cbAnimals = new System.Windows.Forms.ComboBox();
            this.bAddAnimal = new System.Windows.Forms.Button();
            this.lUserName = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.bAddClient = new System.Windows.Forms.Button();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDiagnosis = new System.Windows.Forms.ComboBox();
            this.cbAssig = new System.Windows.Forms.ComboBox();
            this.bAddDiagnosis = new System.Windows.Forms.Button();
            this.bAddAssig = new System.Windows.Forms.Button();
            this.bCreateDiagnosis = new System.Windows.Forms.Button();
            this.bCreateAssignment = new System.Windows.Forms.Button();
            this.lbDiagnosis = new System.Windows.Forms.ListBox();
            this.lbAssignment = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(199, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDate.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(116, 484);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(251, 48);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAddClick);
            // 
            // cbAnimals
            // 
            this.cbAnimals.FormattingEnabled = true;
            this.cbAnimals.Location = new System.Drawing.Point(199, 110);
            this.cbAnimals.Name = "cbAnimals";
            this.cbAnimals.Size = new System.Drawing.Size(209, 28);
            this.cbAnimals.TabIndex = 4;
            // 
            // bAddAnimal
            // 
            this.bAddAnimal.Location = new System.Drawing.Point(415, 110);
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
            this.lUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUserName.Location = new System.Drawing.Point(198, 150);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(253, 20);
            this.lUserName.TabIndex = 6;
            this.lUserName.Text = "Мартынов Евгений Станиславович";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(199, 43);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(250, 27);
            this.dtpTime.TabIndex = 7;
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(415, 76);
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
            this.cbClients.Location = new System.Drawing.Point(199, 76);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(209, 28);
            this.cbClients.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата приёма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Время приёма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Питомец";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ответственный";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Диагноз";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(-1, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Назначение";
            // 
            // cbDiagnosis
            // 
            this.cbDiagnosis.FormattingEnabled = true;
            this.cbDiagnosis.Location = new System.Drawing.Point(198, 186);
            this.cbDiagnosis.Name = "cbDiagnosis";
            this.cbDiagnosis.Size = new System.Drawing.Size(211, 28);
            this.cbDiagnosis.TabIndex = 17;
            // 
            // cbAssig
            // 
            this.cbAssig.FormattingEnabled = true;
            this.cbAssig.Location = new System.Drawing.Point(199, 270);
            this.cbAssig.Name = "cbAssig";
            this.cbAssig.Size = new System.Drawing.Size(210, 28);
            this.cbAssig.TabIndex = 18;
            // 
            // bAddDiagnosis
            // 
            this.bAddDiagnosis.Location = new System.Drawing.Point(198, 220);
            this.bAddDiagnosis.Name = "bAddDiagnosis";
            this.bAddDiagnosis.Size = new System.Drawing.Size(94, 29);
            this.bAddDiagnosis.TabIndex = 19;
            this.bAddDiagnosis.Text = "Добавить";
            this.bAddDiagnosis.UseVisualStyleBackColor = true;
            this.bAddDiagnosis.Click += new System.EventHandler(this.bAddDiagnosis_Click);
            // 
            // bAddAssig
            // 
            this.bAddAssig.Location = new System.Drawing.Point(198, 307);
            this.bAddAssig.Name = "bAddAssig";
            this.bAddAssig.Size = new System.Drawing.Size(94, 29);
            this.bAddAssig.TabIndex = 20;
            this.bAddAssig.Text = "Добавить";
            this.bAddAssig.UseVisualStyleBackColor = true;
            this.bAddAssig.Click += new System.EventHandler(this.bAddAssig_Click);
            // 
            // bCreateDiagnosis
            // 
            this.bCreateDiagnosis.Location = new System.Drawing.Point(415, 186);
            this.bCreateDiagnosis.Name = "bCreateDiagnosis";
            this.bCreateDiagnosis.Size = new System.Drawing.Size(33, 29);
            this.bCreateDiagnosis.TabIndex = 21;
            this.bCreateDiagnosis.Text = "+";
            this.bCreateDiagnosis.UseVisualStyleBackColor = true;
            this.bCreateDiagnosis.Click += new System.EventHandler(this.bCreateDiagnosis_Click);
            // 
            // bCreateAssignment
            // 
            this.bCreateAssignment.Location = new System.Drawing.Point(415, 269);
            this.bCreateAssignment.Name = "bCreateAssignment";
            this.bCreateAssignment.Size = new System.Drawing.Size(33, 29);
            this.bCreateAssignment.TabIndex = 22;
            this.bCreateAssignment.Text = "+";
            this.bCreateAssignment.UseVisualStyleBackColor = true;
            this.bCreateAssignment.Click += new System.EventHandler(this.bCreateAssignment_Click);
            // 
            // lbDiagnosis
            // 
            this.lbDiagnosis.FormattingEnabled = true;
            this.lbDiagnosis.ItemHeight = 20;
            this.lbDiagnosis.Location = new System.Drawing.Point(14, 354);
            this.lbDiagnosis.Name = "lbDiagnosis";
            this.lbDiagnosis.Size = new System.Drawing.Size(225, 124);
            this.lbDiagnosis.TabIndex = 23;
            // 
            // lbAssignment
            // 
            this.lbAssignment.FormattingEnabled = true;
            this.lbAssignment.ItemHeight = 20;
            this.lbAssignment.Location = new System.Drawing.Point(245, 354);
            this.lbAssignment.Name = "lbAssignment";
            this.lbAssignment.Size = new System.Drawing.Size(225, 124);
            this.lbAssignment.TabIndex = 24;
            // 
            // AddVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 561);
            this.Controls.Add(this.lbAssignment);
            this.Controls.Add(this.lbDiagnosis);
            this.Controls.Add(this.bCreateAssignment);
            this.Controls.Add(this.bCreateDiagnosis);
            this.Controls.Add(this.bAddAssig);
            this.Controls.Add(this.bAddDiagnosis);
            this.Controls.Add(this.cbAssig);
            this.Controls.Add(this.cbDiagnosis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.bAddAnimal);
            this.Controls.Add(this.cbAnimals);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dtpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddVisitForm";
            this.Text = "AddVisitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ComboBox cbAnimals;
        private System.Windows.Forms.Button bAddAnimal;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDiagnosis;
        private System.Windows.Forms.ComboBox cbAssig;
        private System.Windows.Forms.Button bAddDiagnosis;
        private System.Windows.Forms.Button bAddAssig;
        private System.Windows.Forms.Button bCreateDiagnosis;
        private System.Windows.Forms.Button bCreateAssignment;
        private System.Windows.Forms.ListBox lbDiagnosis;
        private System.Windows.Forms.ListBox lbAssignment;
    }
}