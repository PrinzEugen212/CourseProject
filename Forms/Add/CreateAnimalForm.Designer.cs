
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnimalForm));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbBreed = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.bChoosePhoto = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.bCancel = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lBreed = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddClient = new System.Windows.Forms.Button();
            this.cbClients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 27);
            this.tbName.TabIndex = 0;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(128, 138);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(228, 27);
            this.tbAge.TabIndex = 3;
            // 
            // tbBreed
            // 
            this.tbBreed.Location = new System.Drawing.Point(128, 105);
            this.tbBreed.Name = "tbBreed";
            this.tbBreed.Size = new System.Drawing.Size(228, 27);
            this.tbBreed.TabIndex = 4;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(128, 72);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(228, 27);
            this.tbType.TabIndex = 5;
            // 
            // bChoosePhoto
            // 
            this.bChoosePhoto.Location = new System.Drawing.Point(128, 205);
            this.bChoosePhoto.Name = "bChoosePhoto";
            this.bChoosePhoto.Size = new System.Drawing.Size(228, 29);
            this.bChoosePhoto.TabIndex = 6;
            this.bChoosePhoto.Text = "Выбрать фото";
            this.bChoosePhoto.UseVisualStyleBackColor = true;
            this.bChoosePhoto.Click += new System.EventHandler(this.bChoosePhoto_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(155, 239);
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
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(246, 239);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(85, 29);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancelClick);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 44);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(58, 20);
            this.lName.TabIndex = 9;
            this.lName.Text = "Кличка";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 77);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(115, 20);
            this.lType.TabIndex = 10;
            this.lType.Text = "Вид животного";
            // 
            // lBreed
            // 
            this.lBreed.AutoSize = true;
            this.lBreed.Location = new System.Drawing.Point(13, 110);
            this.lBreed.Name = "lBreed";
            this.lBreed.Size = new System.Drawing.Size(63, 20);
            this.lBreed.TabIndex = 11;
            this.lBreed.Text = "Порода";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(13, 143);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(64, 20);
            this.lAge.TabIndex = 12;
            this.lAge.Text = "Возраст";
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(13, 176);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(37, 20);
            this.lGender.TabIndex = 13;
            this.lGender.Text = "Пол";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(128, 171);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(112, 28);
            this.cbGender.TabIndex = 14;
            // 
            // pbAnimal
            // 
            this.pbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnimal.Image = ((System.Drawing.Image)(resources.GetObject("pbAnimal.Image")));
            this.pbAnimal.Location = new System.Drawing.Point(362, 6);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(293, 228);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 15;
            this.pbAnimal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Хозяин";
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(323, 6);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(33, 29);
            this.bAddClient.TabIndex = 19;
            this.bAddClient.Text = "+";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(128, 6);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(189, 28);
            this.cbClients.TabIndex = 18;
            // 
            // CreateAnimalForm
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
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bChoosePhoto);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbBreed);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Name = "CreateAnimalForm";
            this.Text = "CreateAnimalForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbBreed;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Button bChoosePhoto;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lBreed;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.ComboBox cbClients;
    }
}