
namespace CorseProject.Forms
{
    partial class MainForm
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
            this.lUserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lAddProcedure = new System.Windows.Forms.Label();
            this.lAddEmployee = new System.Windows.Forms.Label();
            this.lAddVisit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lUserName
            // 
            this.lUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUserName.Location = new System.Drawing.Point(1259, 9);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(103, 28);
            this.lUserName.TabIndex = 0;
            this.lUserName.Text = "UserName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lAddProcedure);
            this.groupBox1.Controls.Add(this.lAddEmployee);
            this.groupBox1.Controls.Add(this.lAddVisit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 732);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lAddProcedure
            // 
            this.lAddProcedure.AutoSize = true;
            this.lAddProcedure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddProcedure.Location = new System.Drawing.Point(8, 99);
            this.lAddProcedure.Name = "lAddProcedure";
            this.lAddProcedure.Size = new System.Drawing.Size(207, 28);
            this.lAddProcedure.TabIndex = 2;
            this.lAddProcedure.Text = "Добавить процедуру";
            // 
            // lAddEmployee
            // 
            this.lAddEmployee.AutoSize = true;
            this.lAddEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddEmployee.Location = new System.Drawing.Point(8, 61);
            this.lAddEmployee.Name = "lAddEmployee";
            this.lAddEmployee.Size = new System.Drawing.Size(212, 28);
            this.lAddEmployee.TabIndex = 1;
            this.lAddEmployee.Text = "Добавить сотрудника";
            // 
            // lAddVisit
            // 
            this.lAddVisit.AutoSize = true;
            this.lAddVisit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddVisit.Location = new System.Drawing.Point(6, 23);
            this.lAddVisit.Margin = new System.Windows.Forms.Padding(3);
            this.lAddVisit.Name = "lAddVisit";
            this.lAddVisit.Size = new System.Drawing.Size(159, 28);
            this.lAddVisit.TabIndex = 0;
            this.lAddVisit.Text = "Записать приём";
            this.lAddVisit.Click += new System.EventHandler(this.lAddVisitClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lUserName);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lAddVisit;
        private System.Windows.Forms.Label lAddProcedure;
        private System.Windows.Forms.Label lAddEmployee;
    }
}