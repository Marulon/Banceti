namespace BanCeti.User
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.txt_Depositar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.btn_UserDeposit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Depositar
            // 
            this.txt_Depositar.Location = new System.Drawing.Point(116, 30);
            this.txt_Depositar.Name = "txt_Depositar";
            this.txt_Depositar.Size = new System.Drawing.Size(100, 20);
            this.txt_Depositar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a depositar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(134, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Motivo";
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(116, 97);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(100, 20);
            this.txt_Reason.TabIndex = 4;
            // 
            // btn_UserDeposit
            // 
            this.btn_UserDeposit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UserDeposit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_UserDeposit.Location = new System.Drawing.Point(15, 147);
            this.btn_UserDeposit.Name = "btn_UserDeposit";
            this.btn_UserDeposit.Size = new System.Drawing.Size(132, 49);
            this.btn_UserDeposit.TabIndex = 8;
            this.btn_UserDeposit.Text = "Depositar";
            this.btn_UserDeposit.UseVisualStyleBackColor = false;
            this.btn_UserDeposit.Click += new System.EventHandler(this.btn_UserDeposit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(173, 147);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(132, 49);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(338, 218);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_UserDeposit);
            this.Controls.Add(this.txt_Reason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Depositar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Depositar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.Button btn_UserDeposit;
        private System.Windows.Forms.Button btn_Cancel;
    }
}