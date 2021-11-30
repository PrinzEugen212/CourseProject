namespace CorseProject.Forms
{
    partial class EditVisitForm
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
            this.bEdit = new System.Windows.Forms.Button();
            this.lbAssignment = new System.Windows.Forms.ListBox();
            this.lbDiagnosis = new System.Windows.Forms.ListBox();
            this.bCreateAssignment = new System.Windows.Forms.Button();
            this.bCreateDiagnosis = new System.Windows.Forms.Button();
            this.bAddAssig = new System.Windows.Forms.Button();
            this.bAddDiagnosis = new System.Windows.Forms.Button();
            this.cbAssig = new System.Windows.Forms.ComboBox();
            this.cbDiagnosis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddClient = new System.Windows.Forms.Button();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.bAddAnimal = new System.Windows.Forms.Button();
            this.cbAnimals = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(116, 491);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(251, 48);
            this.bEdit.TabIndex = 49;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // lbAssignment
            // 
            this.lbAssignment.FormattingEnabled = true;
            this.lbAssignment.ItemHeight = 20;
            this.lbAssignment.Location = new System.Drawing.Point(252, 361);
            this.lbAssignment.Name = "lbAssignment";
            this.lbAssignment.Size = new System.Drawing.Size(225, 124);
            this.lbAssignment.TabIndex = 48;
            this.lbAssignment.DoubleClick += new System.EventHandler(this.lb_DoubleClick);
            // 
            // lbDiagnosis
            // 
            this.lbDiagnosis.FormattingEnabled = true;
            this.lbDiagnosis.ItemHeight = 20;
            this.lbDiagnosis.Location = new System.Drawing.Point(21, 361);
            this.lbDiagnosis.Name = "lbDiagnosis";
            this.lbDiagnosis.Size = new System.Drawing.Size(225, 124);
            this.lbDiagnosis.TabIndex = 47;
            this.lbDiagnosis.DoubleClick += new System.EventHandler(this.lb_DoubleClick);
            // 
            // bCreateAssignment
            // 
            this.bCreateAssignment.Location = new System.Drawing.Point(422, 276);
            this.bCreateAssignment.Name = "bCreateAssignment";
            this.bCreateAssignment.Size = new System.Drawing.Size(33, 29);
            this.bCreateAssignment.TabIndex = 46;
            this.bCreateAssignment.Text = "+";
            this.bCreateAssignment.UseVisualStyleBackColor = true;
            this.bCreateAssignment.Click += new System.EventHandler(this.bCreateAssignment_Click);
            // 
            // bCreateDiagnosis
            // 
            this.bCreateDiagnosis.Location = new System.Drawing.Point(422, 193);
            this.bCreateDiagnosis.Name = "bCreateDiagnosis";
            this.bCreateDiagnosis.Size = new System.Drawing.Size(33, 29);
            this.bCreateDiagnosis.TabIndex = 45;
            this.bCreateDiagnosis.Text = "+";
            this.bCreateDiagnosis.UseVisualStyleBackColor = true;
            this.bCreateDiagnosis.Click += new System.EventHandler(this.bCreateDiagnosis_Click);
            // 
            // bAddAssig
            // 
            this.bAddAssig.Location = new System.Drawing.Point(205, 314);
            this.bAddAssig.Name = "bAddAssig";
            this.bAddAssig.Size = new System.Drawing.Size(94, 29);
            this.bAddAssig.TabIndex = 44;
            this.bAddAssig.Text = "Добавить";
            this.bAddAssig.UseVisualStyleBackColor = true;
            this.bAddAssig.Click += new System.EventHandler(this.bAddAssig_Click);
            // 
            // bAddDiagnosis
            // 
            this.bAddDiagnosis.Location = new System.Drawing.Point(205, 227);
            this.bAddDiagnosis.Name = "bAddDiagnosis";
            this.bAddDiagnosis.Size = new System.Drawing.Size(94, 29);
            this.bAddDiagnosis.TabIndex = 43;
            this.bAddDiagnosis.Text = "Добавить";
            this.bAddDiagnosis.UseVisualStyleBackColor = true;
            this.bAddDiagnosis.Click += new System.EventHandler(this.bAddDiagnosis_Click);
            // 
            // cbAssig
            // 
            this.cbAssig.FormattingEnabled = true;
            this.cbAssig.Location = new System.Drawing.Point(206, 277);
            this.cbAssig.Name = "cbAssig";
            this.cbAssig.Size = new System.Drawing.Size(210, 28);
            this.cbAssig.TabIndex = 42;
            // 
            // cbDiagnosis
            // 
            this.cbDiagnosis.FormattingEnabled = true;
            this.cbDiagnosis.Location = new System.Drawing.Point(205, 193);
            this.cbDiagnosis.Name = "cbDiagnosis";
            this.cbDiagnosis.Size = new System.Drawing.Size(211, 28);
            this.cbDiagnosis.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Назначение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Диагноз";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ответственный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Питомец*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Клиент*";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(206, 50);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(250, 27);
            this.dtpTime.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Время приёма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Дата приёма";
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(422, 83);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(33, 29);
            this.bAddClient.TabIndex = 33;
            this.bAddClient.Text = "+";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(206, 83);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(209, 28);
            this.cbClients.TabIndex = 32;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUserName.Location = new System.Drawing.Point(205, 157);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(253, 20);
            this.lUserName.TabIndex = 30;
            this.lUserName.Text = "Мартынов Евгений Станиславович";
            // 
            // bAddAnimal
            // 
            this.bAddAnimal.Location = new System.Drawing.Point(422, 117);
            this.bAddAnimal.Name = "bAddAnimal";
            this.bAddAnimal.Size = new System.Drawing.Size(33, 29);
            this.bAddAnimal.TabIndex = 29;
            this.bAddAnimal.Text = "+";
            this.bAddAnimal.UseVisualStyleBackColor = true;
            this.bAddAnimal.Click += new System.EventHandler(this.bAddAnimal_Click);
            // 
            // cbAnimals
            // 
            this.cbAnimals.FormattingEnabled = true;
            this.cbAnimals.Location = new System.Drawing.Point(206, 117);
            this.cbAnimals.Name = "cbAnimals";
            this.cbAnimals.Size = new System.Drawing.Size(209, 28);
            this.cbAnimals.TabIndex = 28;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(206, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDate.TabIndex = 26;
            // 
            // EditVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.bEdit);
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
            this.Controls.Add(this.dtpDate);
            this.Name = "EditVisitForm";
            this.Text = "EditVisitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.ListBox lbAssignment;
        private System.Windows.Forms.ListBox lbDiagnosis;
        private System.Windows.Forms.Button bCreateAssignment;
        private System.Windows.Forms.Button bCreateDiagnosis;
        private System.Windows.Forms.Button bAddAssig;
        private System.Windows.Forms.Button bAddDiagnosis;
        private System.Windows.Forms.ComboBox cbAssig;
        private System.Windows.Forms.ComboBox cbDiagnosis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Button bAddAnimal;
        private System.Windows.Forms.ComboBox cbAnimals;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}