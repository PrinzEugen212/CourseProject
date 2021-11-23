namespace CorseProject.Forms
{
    partial class CreateDiagnosisForm
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
            this.lBirthDate = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Location = new System.Drawing.Point(12, 9);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(67, 20);
            this.lBirthDate.TabIndex = 27;
            this.lBirthDate.Text = "Диагноз";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(270, 111);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 30);
            this.bCancel.TabIndex = 24;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(85, 111);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 30);
            this.bAdd.TabIndex = 22;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Location = new System.Drawing.Point(85, 6);
            this.tbDiagnosis.Multiline = true;
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(285, 99);
            this.tbDiagnosis.TabIndex = 28;
            // 
            // CreateDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.lBirthDate);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Name = "CreateDiagnosisForm";
            this.Text = "CreateDiagnosisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbDiagnosis;
    }
}