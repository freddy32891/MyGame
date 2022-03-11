namespace gameClient
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.labelRegisterError = new System.Windows.Forms.Label();
            this.btBackRegister = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbNameR = new System.Windows.Forms.TextBox();
            this.tbConfirmPassR = new System.Windows.Forms.TextBox();
            this.lbPassConfirm = new System.Windows.Forms.Label();
            this.btRegist = new System.Windows.Forms.Button();
            this.tbPassR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMailR = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            this.btBackLogin = new System.Windows.Forms.Button();
            this.btLog = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.panelRegister.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(465, 152);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(300, 125);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btGoLogin_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(465, 398);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(300, 125);
            this.btRegister.TabIndex = 1;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btGoRegister_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.labelRegisterError);
            this.panelRegister.Controls.Add(this.btBackRegister);
            this.panelRegister.Controls.Add(this.lbName);
            this.panelRegister.Controls.Add(this.tbNameR);
            this.panelRegister.Controls.Add(this.tbConfirmPassR);
            this.panelRegister.Controls.Add(this.lbPassConfirm);
            this.panelRegister.Controls.Add(this.btRegist);
            this.panelRegister.Controls.Add(this.tbPassR);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.tbMailR);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(1284, 702);
            this.panelRegister.TabIndex = 2;
            this.panelRegister.Visible = false;
            // 
            // labelRegisterError
            // 
            this.labelRegisterError.AutoSize = true;
            this.labelRegisterError.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterError.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterError.Location = new System.Drawing.Point(696, 480);
            this.labelRegisterError.Name = "labelRegisterError";
            this.labelRegisterError.Size = new System.Drawing.Size(0, 27);
            this.labelRegisterError.TabIndex = 16;
            this.labelRegisterError.Visible = false;
            // 
            // btBackRegister
            // 
            this.btBackRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackRegister.BackgroundImage")));
            this.btBackRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBackRegister.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackRegister.Location = new System.Drawing.Point(124, 62);
            this.btBackRegister.Name = "btBackRegister";
            this.btBackRegister.Size = new System.Drawing.Size(150, 75);
            this.btBackRegister.TabIndex = 8;
            this.btBackRegister.UseVisualStyleBackColor = true;
            this.btBackRegister.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(375, 114);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(118, 49);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "Name";
            // 
            // tbNameR
            // 
            this.tbNameR.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameR.Location = new System.Drawing.Point(578, 108);
            this.tbNameR.Name = "tbNameR";
            this.tbNameR.Size = new System.Drawing.Size(274, 56);
            this.tbNameR.TabIndex = 14;
            // 
            // tbConfirmPassR
            // 
            this.tbConfirmPassR.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassR.Location = new System.Drawing.Point(578, 398);
            this.tbConfirmPassR.Name = "tbConfirmPassR";
            this.tbConfirmPassR.Size = new System.Drawing.Size(500, 56);
            this.tbConfirmPassR.TabIndex = 13;
            this.tbConfirmPassR.UseSystemPasswordChar = true;
            // 
            // lbPassConfirm
            // 
            this.lbPassConfirm.AutoSize = true;
            this.lbPassConfirm.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassConfirm.Location = new System.Drawing.Point(316, 382);
            this.lbPassConfirm.Name = "lbPassConfirm";
            this.lbPassConfirm.Size = new System.Drawing.Size(177, 98);
            this.lbPassConfirm.TabIndex = 12;
            this.lbPassConfirm.Text = "Confirm\r\nPassword";
            // 
            // btRegist
            // 
            this.btRegist.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegist.Location = new System.Drawing.Point(982, 518);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(200, 100);
            this.btRegist.TabIndex = 11;
            this.btRegist.Text = "Register";
            this.btRegist.UseVisualStyleBackColor = true;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // tbPassR
            // 
            this.tbPassR.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassR.Location = new System.Drawing.Point(578, 294);
            this.tbPassR.Name = "tbPassR";
            this.tbPassR.Size = new System.Drawing.Size(500, 56);
            this.tbPassR.TabIndex = 10;
            this.tbPassR.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 49);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail";
            // 
            // tbMailR
            // 
            this.tbMailR.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMailR.Location = new System.Drawing.Point(578, 205);
            this.tbMailR.Name = "tbMailR";
            this.tbMailR.Size = new System.Drawing.Size(500, 56);
            this.tbMailR.TabIndex = 7;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.labelErrorLogin);
            this.gbLogin.Controls.Add(this.btBackLogin);
            this.gbLogin.Controls.Add(this.btLog);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.lbMail);
            this.gbLogin.Controls.Add(this.tbMail);
            this.gbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLogin.ForeColor = System.Drawing.Color.White;
            this.gbLogin.Location = new System.Drawing.Point(0, 0);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(1284, 702);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            this.gbLogin.Visible = false;
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.AutoSize = true;
            this.labelErrorLogin.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLogin.Location = new System.Drawing.Point(726, 455);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(0, 22);
            this.labelErrorLogin.TabIndex = 8;
            this.labelErrorLogin.Visible = false;
            // 
            // btBackLogin
            // 
            this.btBackLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackLogin.BackgroundImage")));
            this.btBackLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBackLogin.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackLogin.Location = new System.Drawing.Point(111, 77);
            this.btBackLogin.Name = "btBackLogin";
            this.btBackLogin.Size = new System.Drawing.Size(150, 75);
            this.btBackLogin.TabIndex = 7;
            this.btBackLogin.UseVisualStyleBackColor = true;
            this.btBackLogin.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btLog
            // 
            this.btLog.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLog.ForeColor = System.Drawing.Color.Black;
            this.btLog.Location = new System.Drawing.Point(968, 518);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(188, 92);
            this.btLog.TabIndex = 6;
            this.btLog.Text = "Login";
            this.btLog.UseVisualStyleBackColor = true;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(519, 365);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(404, 56);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(297, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.ForeColor = System.Drawing.Color.Black;
            this.lbMail.Location = new System.Drawing.Point(378, 249);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(96, 49);
            this.lbMail.TabIndex = 2;
            this.lbMail.Text = "Mail";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(519, 255);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(404, 56);
            this.tbMail.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btLogin);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batle Game";
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.TextBox tbPassR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMailR;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbConfirmPassR;
        private System.Windows.Forms.Label lbPassConfirm;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbNameR;
        private System.Windows.Forms.Button btBackLogin;
        private System.Windows.Forms.Button btBackRegister;
        private System.Windows.Forms.Label labelErrorLogin;
        private System.Windows.Forms.Label labelRegisterError;
    }
}

