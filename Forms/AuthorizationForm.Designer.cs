
namespace CorseProject
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.bAuthorize = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(94, 51);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(190, 27);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Text = "Логин";
            this.tbLogin.Click += new System.EventHandler(this.tbClick);
            this.tbLogin.Enter += new System.EventHandler(this.tbClick);
            // 
            // bAuthorize
            // 
            this.bAuthorize.Location = new System.Drawing.Point(124, 152);
            this.bAuthorize.Name = "bAuthorize";
            this.bAuthorize.Size = new System.Drawing.Size(125, 29);
            this.bAuthorize.TabIndex = 1;
            this.bAuthorize.Text = "Войти";
            this.bAuthorize.UseVisualStyleBackColor = true;
            this.bAuthorize.Click += new System.EventHandler(this.bAuthorize_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(94, 95);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(190, 27);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Пароль";
            this.tbPassword.Click += new System.EventHandler(this.tbClick);
            this.tbPassword.Enter += new System.EventHandler(this.tbClick);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 237);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bAuthorize);
            this.Controls.Add(this.tbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button bAuthorize;
        private System.Windows.Forms.TextBox tbPassword;
    }
}

