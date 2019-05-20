namespace BanCeti.Admin
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.tbar_AdminAccess = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Repeat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_AdminAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(199, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(199, 53);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(100, 20);
            this.txt_Code.TabIndex = 1;
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(199, 145);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(100, 20);
            this.txt_Money.TabIndex = 2;
            // 
            // txt_Pin
            // 
            this.txt_Pin.Location = new System.Drawing.Point(199, 195);
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '*';
            this.txt_Pin.Size = new System.Drawing.Size(100, 20);
            this.txt_Pin.TabIndex = 3;
            this.txt_Pin.UseSystemPasswordChar = true;
            // 
            // tbar_AdminAccess
            // 
            this.tbar_AdminAccess.Location = new System.Drawing.Point(195, 86);
            this.tbar_AdminAccess.Maximum = 1;
            this.tbar_AdminAccess.Name = "tbar_AdminAccess";
            this.tbar_AdminAccess.Size = new System.Drawing.Size(104, 45);
            this.tbar_AdminAccess.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(111, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(64, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Administrador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(25, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dinero de Apertura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(155, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "(si es administrador el dinero no sera tomado en cuenta)";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(136, 281);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 37);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Agregar Usuario";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(274, 281);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 37);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F);
            this.label9.Location = new System.Drawing.Point(90, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Repetir Pin:";
            // 
            // txt_Repeat
            // 
            this.txt_Repeat.Location = new System.Drawing.Point(199, 221);
            this.txt_Repeat.Name = "txt_Repeat";
            this.txt_Repeat.PasswordChar = '*';
            this.txt_Repeat.Size = new System.Drawing.Size(100, 20);
            this.txt_Repeat.TabIndex = 15;
            this.txt_Repeat.UseSystemPasswordChar = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 386);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Repeat);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbar_AdminAccess);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.tbar_AdminAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.TextBox txt_Pin;
        private System.Windows.Forms.TrackBar tbar_AdminAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Repeat;
    }
}