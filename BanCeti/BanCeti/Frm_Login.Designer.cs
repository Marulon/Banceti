namespace BanCeti
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.lbl_text2 = new System.Windows.Forms.Label();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.lbl_text1 = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_text2
            // 
            this.lbl_text2.AutoSize = true;
            this.lbl_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text2.Location = new System.Drawing.Point(357, 404);
            this.lbl_text2.Name = "lbl_text2";
            this.lbl_text2.Size = new System.Drawing.Size(39, 20);
            this.lbl_text2.TabIndex = 7;
            this.lbl_text2.Text = "PIN:";
            // 
            // txt_Pin
            // 
            this.txt_Pin.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Pin.Location = new System.Drawing.Point(402, 404);
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '*';
            this.txt_Pin.Size = new System.Drawing.Size(100, 20);
            this.txt_Pin.TabIndex = 6;
            this.txt_Pin.UseSystemPasswordChar = true;
            // 
            // lbl_text1
            // 
            this.lbl_text1.AutoSize = true;
            this.lbl_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text1.Location = new System.Drawing.Point(115, 404);
            this.lbl_text1.Name = "lbl_text1";
            this.lbl_text1.Size = new System.Drawing.Size(65, 20);
            this.lbl_text1.TabIndex = 5;
            this.lbl_text1.Text = "Cuenta:";
            // 
            // txt_Account
            // 
            this.txt_Account.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Account.Location = new System.Drawing.Point(186, 404);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(100, 20);
            this.txt_Account.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Login.Location = new System.Drawing.Point(565, 389);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(122, 49);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "ENTRAR";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::BanCeti.Properties.Resources.LogoBanCeti;
            this.pb_logo.Location = new System.Drawing.Point(186, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(406, 339);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 9;
            this.pb_logo.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(713, 415);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_text2);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.lbl_text1);
            this.Controls.Add(this.txt_Account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text2;
        public System.Windows.Forms.TextBox txt_Pin;
        private System.Windows.Forms.Label lbl_text1;
        public System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_Exit;
    }
}