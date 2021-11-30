
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
            this.lEditLast = new System.Windows.Forms.Label();
            this.lAddProcedure = new System.Windows.Forms.Label();
            this.lAddEmployee = new System.Windows.Forms.Label();
            this.lAddVisit = new System.Windows.Forms.Label();
            this.dgwTables = new System.Windows.Forms.DataGridView();
            this.bGetClients = new System.Windows.Forms.Button();
            this.bGetAnimals = new System.Windows.Forms.Button();
            this.bGetVisits = new System.Windows.Forms.Button();
            this.bGetEmployees = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bDiseases = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTables)).BeginInit();
            this.SuspendLayout();
            // 
            // lUserName
            // 
            this.lUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUserName.Location = new System.Drawing.Point(1239, 7);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(103, 28);
            this.lUserName.TabIndex = 0;
            this.lUserName.Text = "UserName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lEditLast);
            this.groupBox1.Controls.Add(this.lAddProcedure);
            this.groupBox1.Controls.Add(this.lAddEmployee);
            this.groupBox1.Controls.Add(this.lAddVisit);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 732);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lEditLast
            // 
            this.lEditLast.AutoSize = true;
            this.lEditLast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lEditLast.Location = new System.Drawing.Point(6, 67);
            this.lEditLast.Margin = new System.Windows.Forms.Padding(3);
            this.lEditLast.Name = "lEditLast";
            this.lEditLast.Padding = new System.Windows.Forms.Padding(5);
            this.lEditLast.Size = new System.Drawing.Size(283, 38);
            this.lEditLast.TabIndex = 3;
            this.lEditLast.Text = "Изменить последний приём";
            this.lEditLast.Click += new System.EventHandler(this.lEditLast_Click);
            // 
            // lAddProcedure
            // 
            this.lAddProcedure.AutoSize = true;
            this.lAddProcedure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddProcedure.Location = new System.Drawing.Point(6, 146);
            this.lAddProcedure.Name = "lAddProcedure";
            this.lAddProcedure.Padding = new System.Windows.Forms.Padding(5);
            this.lAddProcedure.Size = new System.Drawing.Size(217, 38);
            this.lAddProcedure.TabIndex = 2;
            this.lAddProcedure.Text = "Добавить процедуру";
            this.lAddProcedure.MouseLeave += new System.EventHandler(this.lMouseLeave);
            this.lAddProcedure.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lMouseMove);
            // 
            // lAddEmployee
            // 
            this.lAddEmployee.AutoSize = true;
            this.lAddEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddEmployee.Location = new System.Drawing.Point(6, 108);
            this.lAddEmployee.Name = "lAddEmployee";
            this.lAddEmployee.Padding = new System.Windows.Forms.Padding(5);
            this.lAddEmployee.Size = new System.Drawing.Size(222, 38);
            this.lAddEmployee.TabIndex = 1;
            this.lAddEmployee.Text = "Добавить сотрудника";
            this.lAddEmployee.Click += new System.EventHandler(this.lAddEmployee_Click);
            this.lAddEmployee.MouseLeave += new System.EventHandler(this.lMouseLeave);
            this.lAddEmployee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lMouseMove);
            // 
            // lAddVisit
            // 
            this.lAddVisit.AutoSize = true;
            this.lAddVisit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddVisit.Location = new System.Drawing.Point(6, 27);
            this.lAddVisit.Margin = new System.Windows.Forms.Padding(3);
            this.lAddVisit.Name = "lAddVisit";
            this.lAddVisit.Padding = new System.Windows.Forms.Padding(5);
            this.lAddVisit.Size = new System.Drawing.Size(169, 38);
            this.lAddVisit.TabIndex = 0;
            this.lAddVisit.Text = "Записать приём";
            this.lAddVisit.Click += new System.EventHandler(this.lAddVisitClick);
            this.lAddVisit.MouseLeave += new System.EventHandler(this.lMouseLeave);
            this.lAddVisit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lMouseMove);
            // 
            // dgwTables
            // 
            this.dgwTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTables.Location = new System.Drawing.Point(301, 38);
            this.dgwTables.Name = "dgwTables";
            this.dgwTables.RowHeadersWidth = 51;
            this.dgwTables.RowTemplate.Height = 29;
            this.dgwTables.Size = new System.Drawing.Size(1120, 637);
            this.dgwTables.TabIndex = 2;
            this.dgwTables.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTables_CellContentDoubleClick);
            // 
            // bGetClients
            // 
            this.bGetClients.Location = new System.Drawing.Point(301, 681);
            this.bGetClients.Name = "bGetClients";
            this.bGetClients.Size = new System.Drawing.Size(147, 29);
            this.bGetClients.TabIndex = 3;
            this.bGetClients.Tag = "Clients";
            this.bGetClients.Text = "Клиенты";
            this.bGetClients.UseVisualStyleBackColor = true;
            this.bGetClients.Click += new System.EventHandler(this.GetTableByButtonTag);
            // 
            // bGetAnimals
            // 
            this.bGetAnimals.Location = new System.Drawing.Point(454, 680);
            this.bGetAnimals.Name = "bGetAnimals";
            this.bGetAnimals.Size = new System.Drawing.Size(147, 29);
            this.bGetAnimals.TabIndex = 4;
            this.bGetAnimals.Tag = "Animals";
            this.bGetAnimals.Text = "Животные";
            this.bGetAnimals.UseVisualStyleBackColor = true;
            this.bGetAnimals.Click += new System.EventHandler(this.GetTableByButtonTag);
            // 
            // bGetVisits
            // 
            this.bGetVisits.Location = new System.Drawing.Point(607, 680);
            this.bGetVisits.Name = "bGetVisits";
            this.bGetVisits.Size = new System.Drawing.Size(147, 29);
            this.bGetVisits.TabIndex = 5;
            this.bGetVisits.Tag = "Visits";
            this.bGetVisits.Text = "Приёмы";
            this.bGetVisits.UseVisualStyleBackColor = true;
            this.bGetVisits.Click += new System.EventHandler(this.GetTableByButtonTag);
            // 
            // bGetEmployees
            // 
            this.bGetEmployees.Location = new System.Drawing.Point(760, 680);
            this.bGetEmployees.Name = "bGetEmployees";
            this.bGetEmployees.Size = new System.Drawing.Size(147, 29);
            this.bGetEmployees.TabIndex = 6;
            this.bGetEmployees.Tag = "Employees";
            this.bGetEmployees.Text = "Работники";
            this.bGetEmployees.UseVisualStyleBackColor = true;
            this.bGetEmployees.Click += new System.EventHandler(this.GetTableByButtonTag);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 29);
            this.button1.TabIndex = 7;
            this.button1.Tag = "ProceduresList";
            this.button1.Text = "Процедуры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetTableByButtonTag);
            // 
            // bDiseases
            // 
            this.bDiseases.Location = new System.Drawing.Point(1066, 680);
            this.bDiseases.Name = "bDiseases";
            this.bDiseases.Size = new System.Drawing.Size(147, 29);
            this.bDiseases.TabIndex = 8;
            this.bDiseases.Tag = "Diseases";
            this.bDiseases.Text = "Болезни";
            this.bDiseases.UseVisualStyleBackColor = true;
            this.bDiseases.Click += new System.EventHandler(this.GetTableByButtonTag);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 756);
            this.Controls.Add(this.bDiseases);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bGetEmployees);
            this.Controls.Add(this.bGetVisits);
            this.Controls.Add(this.bGetAnimals);
            this.Controls.Add(this.bGetClients);
            this.Controls.Add(this.dgwTables);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lUserName);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lAddVisit;
        private System.Windows.Forms.Label lAddProcedure;
        private System.Windows.Forms.Label lAddEmployee;
        private System.Windows.Forms.DataGridView dgwTables;
        private System.Windows.Forms.Button bGetClients;
        private System.Windows.Forms.Button bGetAnimals;
        private System.Windows.Forms.Button bGetVisits;
        private System.Windows.Forms.Button bGetEmployees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bDiseases;
        private System.Windows.Forms.Label lEditLast;
    }
}