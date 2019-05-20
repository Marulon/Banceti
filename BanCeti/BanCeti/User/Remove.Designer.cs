namespace BanCeti.User
{
    partial class Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove));
            this.txt_Remove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UserWithdrawals = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Remove
            // 
            this.txt_Remove.Location = new System.Drawing.Point(130, 62);
            this.txt_Remove.Name = "txt_Remove";
            this.txt_Remove.Size = new System.Drawing.Size(79, 20);
            this.txt_Remove.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a retirar";
            // 
            // btn_UserWithdrawals
            // 
            this.btn_UserWithdrawals.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserWithdrawals.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserWithdrawals.Location = new System.Drawing.Point(35, 108);
            this.btn_UserWithdrawals.Name = "btn_UserWithdrawals";
            this.btn_UserWithdrawals.Size = new System.Drawing.Size(132, 49);
            this.btn_UserWithdrawals.TabIndex = 11;
            this.btn_UserWithdrawals.Text = "Retirar";
            this.btn_UserWithdrawals.UseVisualStyleBackColor = false;
            this.btn_UserWithdrawals.Click += new System.EventHandler(this.btn_UserWithdrawals_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(173, 108);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(132, 49);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Balance.Location = new System.Drawing.Point(12, 9);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(172, 18);
            this.lbl_Balance.TabIndex = 13;
            this.lbl_Balance.Text = "Su saldo es: 88888";
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(333, 180);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_UserWithdrawals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Remove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar";
            this.Load += new System.EventHandler(this.Remove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_UserWithdrawals;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Balance;
    }
}