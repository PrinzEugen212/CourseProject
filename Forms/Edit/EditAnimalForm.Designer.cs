namespace CorseProject.Forms.Edit
{
    partial class EditAnimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAnimalForm));
            this.bAddClient = new System.Windows.Forms.Button();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lGender = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lBreed = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bChoosePhoto = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbBreed = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(323, 8);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(33, 29);
            this.bAddClient.TabIndex = 36;
            this.bAddClient.Text = "+";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(128, 8);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(189, 28);
            this.cbClients.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Хозяин";
            // 
            // pbAnimal
            // 
            this.pbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnimal.Image = ((System.Drawing.Image)(resources.GetObject("pbAnimal.Image")));
            this.pbAnimal.Location = new System.Drawing.Point(362, 8);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(293, 228);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 33;
            this.pbAnimal.TabStop = false;
            // 
            // cbGender
            // 
            this.cbGender.Enabled = false;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(128, 173);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(112, 28);
            this.cbGender.TabIndex = 32;
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(13, 178);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(37, 20);
            this.lGender.TabIndex = 31;
            this.lGender.Text = "Пол";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(13, 145);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(64, 20);
            this.lAge.TabIndex = 30;
            this.lAge.Text = "Возраст";
            // 
            // lBreed
            // 
            this.lBreed.AutoSize = true;
            this.lBreed.Location = new System.Drawing.Point(13, 112);
            this.lBreed.Name = "lBreed";
            this.lBreed.Size = new System.Drawing.Size(63, 20);
            this.lBreed.TabIndex = 29;
            this.lBreed.Text = "Порода";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 79);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(115, 20);
            this.lType.TabIndex = 28;
            this.lType.Text = "Вид животного";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 46);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(58, 20);
            this.lName.TabIndex = 27;
            this.lName.Text = "Кличка";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(246, 241);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(85, 29);
            this.bCancel.TabIndex = 26;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(154, 241);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(86, 29);
            this.bEdit.TabIndex = 25;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bChoosePhoto
            // 
            this.bChoosePhoto.Location = new System.Drawing.Point(128, 207);
            this.bChoosePhoto.Name = "bChoosePhoto";
            this.bChoosePhoto.Size = new System.Drawing.Size(228, 29);
            this.bChoosePhoto.TabIndex = 24;
            this.bChoosePhoto.Text = "Выбрать фото";
            this.bChoosePhoto.UseVisualStyleBackColor = true;
            this.bChoosePhoto.Click += new System.EventHandler(this.bChoosePhoto_Click);
            // 
            // tbType
            // 
            this.tbType.Enabled = false;
            this.tbType.Location = new System.Drawing.Point(128, 74);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(228, 27);
            this.tbType.TabIndex = 23;
            // 
            // tbBreed
            // 
            this.tbBreed.Location = new System.Drawing.Point(128, 107);
            this.tbBreed.Name = "tbBreed";
            this.tbBreed.Size = new System.Drawing.Size(228, 27);
            this.tbBreed.TabIndex = 22;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(128, 140);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(228, 27);
            this.tbAge.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 27);
            this.tbName.TabIndex = 20;
            // 
            // openPhotoDialog
            // 
            this.openPhotoDialog.FileName = "openFileDialog1";
            // 
            // EditAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 278);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAnimal);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lGender);
            this.Controls.Add(this.lAge);
            this.Controls.Add(this.lBreed);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bChoosePhoto);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbBreed);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Name = "EditAnimalForm";
            this.Text = "EditAnimalForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lBreed;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bChoosePhoto;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbBreed;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
    }
}