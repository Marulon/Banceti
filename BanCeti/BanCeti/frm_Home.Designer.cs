namespace BanCeti
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.Pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_AdminAdd = new System.Windows.Forms.Button();
            this.btn_AdminShow = new System.Windows.Forms.Button();
            this.btn_UserDeposit = new System.Windows.Forms.Button();
            this.btn_UserStatus = new System.Windows.Forms.Button();
            this.btn_UserMoney = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_UserWithdrawals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Logo
            // 
            this.Pb_Logo.Image = global::BanCeti.Properties.Resources.LogoBanCeti;
            this.Pb_Logo.Location = new System.Drawing.Point(13, 13);
            this.Pb_Logo.Name = "Pb_Logo";
            this.Pb_Logo.Size = new System.Drawing.Size(115, 102);
            this.Pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Logo.TabIndex = 0;
            this.Pb_Logo.TabStop = false;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(172, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(214, 39);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Bienvenido...";
            // 
            // btn_AdminAdd
            // 
            this.btn_AdminAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_AdminAdd.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_AdminAdd.Location = new System.Drawing.Point(216, 199);
            this.btn_AdminAdd.Name = "btn_AdminAdd";
            this.btn_AdminAdd.Size = new System.Drawing.Size(132, 49);
            this.btn_AdminAdd.TabIndex = 2;
            this.btn_AdminAdd.Text = "Agregar Usuario";
            this.btn_AdminAdd.UseVisualStyleBackColor = false;
            this.btn_AdminAdd.Click += new System.EventHandler(this.btn_AdminAdd_Click);
            // 
            // btn_AdminShow
            // 
            this.btn_AdminShow.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_AdminShow.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_AdminShow.Location = new System.Drawing.Point(492, 199);
            this.btn_AdminShow.Name = "btn_AdminShow";
            this.btn_AdminShow.Size = new System.Drawing.Size(132, 49);
            this.btn_AdminShow.TabIndex = 6;
            this.btn_AdminShow.Text = "Mostrar Usuario";
            this.btn_AdminShow.UseVisualStyleBackColor = false;
            this.btn_AdminShow.Click += new System.EventHandler(this.btn_AdminShow_Click);
            // 
            // btn_UserDeposit
            // 
            this.btn_UserDeposit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserDeposit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserDeposit.Location = new System.Drawing.Point(216, 199);
            this.btn_UserDeposit.Name = "btn_UserDeposit";
            this.btn_UserDeposit.Size = new System.Drawing.Size(132, 49);
            this.btn_UserDeposit.TabIndex = 7;
            this.btn_UserDeposit.Text = "Depositar";
            this.btn_UserDeposit.UseVisualStyleBackColor = false;
            this.btn_UserDeposit.Click += new System.EventHandler(this.btn_UserDeposit_Click);
            // 
            // btn_UserStatus
            // 
            this.btn_UserStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserStatus.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserStatus.Location = new System.Drawing.Point(492, 287);
            this.btn_UserStatus.Name = "btn_UserStatus";
            this.btn_UserStatus.Size = new System.Drawing.Size(132, 49);
            this.btn_UserStatus.TabIndex = 8;
            this.btn_UserStatus.Text = "Estado de cuenta";
            this.btn_UserStatus.UseVisualStyleBackColor = false;
            this.btn_UserStatus.Click += new System.EventHandler(this.btn_UserStatus_Click);
            // 
            // btn_UserMoney
            // 
            this.btn_UserMoney.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserMoney.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserMoney.Location = new System.Drawing.Point(492, 199);
            this.btn_UserMoney.Name = "btn_UserMoney";
            this.btn_UserMoney.Size = new System.Drawing.Size(132, 49);
            this.btn_UserMoney.TabIndex = 9;
            this.btn_UserMoney.Text = "Consultar saldo";
            this.btn_UserMoney.UseVisualStyleBackColor = false;
            this.btn_UserMoney.Click += new System.EventHandler(this.btn_UserMoney_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(372, 396);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(98, 23);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Cerrar sesion";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_UserWithdrawals
            // 
            this.btn_UserWithdrawals.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserWithdrawals.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserWithdrawals.Location = new System.Drawing.Point(216, 287);
            this.btn_UserWithdrawals.Name = "btn_UserWithdrawals";
            this.btn_UserWithdrawals.Size = new System.Drawing.Size(132, 49);
            this.btn_UserWithdrawals.TabIndex = 10;
            this.btn_UserWithdrawals.Text = "Retirar";
            this.btn_UserWithdrawals.UseVisualStyleBackColor = false;
            this.btn_UserWithdrawals.Click += new System.EventHandler(this.btn_UserWithdrawals_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_UserWithdrawals);
            this.Controls.Add(this.btn_UserMoney);
            this.Controls.Add(this.btn_UserStatus);
            this.Controls.Add(this.btn_UserDeposit);
            this.Controls.Add(this.btn_AdminShow);
            this.Controls.Add(this.btn_AdminAdd);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.Pb_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Logo;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_AdminAdd;
        private System.Windows.Forms.Button btn_AdminShow;
        private System.Windows.Forms.Button btn_UserDeposit;
        private System.Windows.Forms.Button btn_UserStatus;
        private System.Windows.Forms.Button btn_UserMoney;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_UserWithdrawals;
    }
}