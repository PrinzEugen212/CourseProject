
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
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 27);
            this.tbName.TabIndex = 0;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(128, 107);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(228, 27);
            this.tbAge.TabIndex = 3;
            // 
            // tbBreed
            // 
            this.tbBreed.Location = new System.Drawing.Point(128, 74);
            this.tbBreed.Name = "tbBreed";
            this.tbBreed.Size = new System.Drawing.Size(228, 27);
            this.tbBreed.TabIndex = 4;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(128, 41);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(228, 27);
            this.tbType.TabIndex = 5;
            // 
            // bChoosePhoto
            // 
            this.bChoosePhoto.Location = new System.Drawing.Point(128, 174);
            this.bChoosePhoto.Name = "bChoosePhoto";
            this.bChoosePhoto.Size = new System.Drawing.Size(228, 29);
            this.bChoosePhoto.TabIndex = 6;
            this.bChoosePhoto.Text = "Выбрать фото";
            this.bChoosePhoto.UseVisualStyleBackColor = true;
            this.bChoosePhoto.Click += new System.EventHandler(this.bChoosePhoto_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(155, 208);
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
            this.bCancel.Location = new System.Drawing.Point(246, 208);
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
            this.lName.Location = new System.Drawing.Point(13, 13);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(58, 20);
            this.lName.TabIndex = 9;
            this.lName.Text = "Кличка";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 46);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(115, 20);
            this.lType.TabIndex = 10;
            this.lType.Text = "Вид животного";
            // 
            // lBreed
            // 
            this.lBreed.AutoSize = true;
            this.lBreed.Location = new System.Drawing.Point(13, 79);
            this.lBreed.Name = "lBreed";
            this.lBreed.Size = new System.Drawing.Size(63, 20);
            this.lBreed.TabIndex = 11;
            this.lBreed.Text = "Порода";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(13, 112);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(64, 20);
            this.lAge.TabIndex = 12;
            this.lAge.Text = "Возраст";
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(13, 145);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(37, 20);
            this.lGender.TabIndex = 13;
            this.lGender.Text = "Пол";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(128, 140);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(112, 28);
            this.cbGender.TabIndex = 14;
            // 
            // CreateAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 253);
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
    }
}