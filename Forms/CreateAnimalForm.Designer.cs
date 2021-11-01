
namespace CorseProject.Forms
{
    partial class CreateAnimalForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbBreed = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.bChoosePhoto = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 27);
            this.tbName.TabIndex = 0;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(12, 144);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(228, 27);
            this.tbGender.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(12, 111);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(228, 27);
            this.tbAge.TabIndex = 3;
            // 
            // tbBreed
            // 
            this.tbBreed.Location = new System.Drawing.Point(12, 78);
            this.tbBreed.Name = "tbBreed";
            this.tbBreed.Size = new System.Drawing.Size(228, 27);
            this.tbBreed.TabIndex = 4;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(12, 45);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(228, 27);
            this.tbType.TabIndex = 5;
            // 
            // bChoosePhoto
            // 
            this.bChoosePhoto.Location = new System.Drawing.Point(12, 178);
            this.bChoosePhoto.Name = "bChoosePhoto";
            this.bChoosePhoto.Size = new System.Drawing.Size(228, 29);
            this.bChoosePhoto.TabIndex = 6;
            this.bChoosePhoto.Text = "Выбрать фото";
            this.bChoosePhoto.UseVisualStyleBackColor = true;
            this.bChoosePhoto.Click += new System.EventHandler(this.bChoosePhoto_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(79, 213);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(85, 29);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // openPhotoDialog
            // 
            this.openPhotoDialog.FileName = "openFileDialog1";
            // 
            // CreateAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 253);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bChoosePhoto);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbBreed);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbName);
            this.Name = "CreateAnimalForm";
            this.Text = "CreateAnimalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbBreed;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Button bChoosePhoto;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
    }
}