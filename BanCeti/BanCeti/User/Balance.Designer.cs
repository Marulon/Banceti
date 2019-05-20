namespace BanCeti.User
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.btn_UserDeposit = new System.Windows.Forms.Button();
            this.btn_UserWithdrawals = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(12, 9);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(414, 45);
            this.lbl_Balance.TabIndex = 0;
            this.lbl_Balance.Text = "Su saldo es: 88888";
            // 
            // btn_UserDeposit
            // 
            this.btn_UserDeposit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserDeposit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserDeposit.Location = new System.Drawing.Point(12, 87);
            this.btn_UserDeposit.Name = "btn_UserDeposit";
            this.btn_UserDeposit.Size = new System.Drawing.Size(132, 49);
            this.btn_UserDeposit.TabIndex = 8;
            this.btn_UserDeposit.Text = "Depositar";
            this.btn_UserDeposit.UseVisualStyleBackColor = false;
            this.btn_UserDeposit.Click += new System.EventHandler(this.btn_UserDeposit_Click);
            // 
            // btn_UserWithdrawals
            // 
            this.btn_UserWithdrawals.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserWithdrawals.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserWithdrawals.Location = new System.Drawing.Point(244, 87);
            this.btn_UserWithdrawals.Name = "btn_UserWithdrawals";
            this.btn_UserWithdrawals.Size = new System.Drawing.Size(132, 49);
            this.btn_UserWithdrawals.TabIndex = 11;
            this.btn_UserWithdrawals.Text = "Retirar";
            this.btn_UserWithdrawals.UseVisualStyleBackColor = false;
            this.btn_UserWithdrawals.Click += new System.EventHandler(this.btn_UserWithdrawals_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(450, 87);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(132, 49);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(594, 158);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_UserWithdrawals);
            this.Controls.Add(this.btn_UserDeposit);
            this.Controls.Add(this.lbl_Balance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de saldo";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Button btn_UserDeposit;
        private System.Windows.Forms.Button btn_UserWithdrawals;
        private System.Windows.Forms.Button btn_Exit;
    }
}