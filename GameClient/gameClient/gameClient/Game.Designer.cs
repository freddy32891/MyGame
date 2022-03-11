namespace gameClient
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.selectArsenalPanel = new System.Windows.Forms.Panel();
            this.lbCoins = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUserArsenal = new System.Windows.Forms.GroupBox();
            this.listViewArsenalAvailable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labeErrorAddingArsenal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewArsenal = new System.Windows.Forms.ListView();
            this.arsenalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arsenalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arsenalType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arsenalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btFinishAdding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lbRound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbErrorPlaying = new System.Windows.Forms.Label();
            this.cbShields = new System.Windows.Forms.ComboBox();
            this.lbBullets = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbWeapons = new System.Windows.Forms.ComboBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btDefend = new System.Windows.Forms.Button();
            this.lbActionEnemy = new System.Windows.Forms.Label();
            this.lbActionUser = new System.Windows.Forms.Label();
            this.btAttack = new System.Windows.Forms.Button();
            this.btRecharge = new System.Windows.Forms.Button();
            this.lbPointsOfLifeUser = new System.Windows.Forms.Label();
            this.lbPointOfLifeEnemy = new System.Windows.Forms.Label();
            this.lbOponentName = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureEnemy = new System.Windows.Forms.PictureBox();
            this.lbWinOrLose = new System.Windows.Forms.Label();
            this.selectArsenalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUserArsenal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // selectArsenalPanel
            // 
            this.selectArsenalPanel.Controls.Add(this.lbCoins);
            this.selectArsenalPanel.Controls.Add(this.pictureBox1);
            this.selectArsenalPanel.Controls.Add(this.gbUserArsenal);
            this.selectArsenalPanel.Controls.Add(this.labeErrorAddingArsenal);
            this.selectArsenalPanel.Controls.Add(this.groupBox1);
            this.selectArsenalPanel.Controls.Add(this.btFinishAdding);
            this.selectArsenalPanel.Controls.Add(this.label1);
            this.selectArsenalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectArsenalPanel.ForeColor = System.Drawing.Color.Gold;
            this.selectArsenalPanel.Location = new System.Drawing.Point(0, 0);
            this.selectArsenalPanel.Name = "selectArsenalPanel";
            this.selectArsenalPanel.Size = new System.Drawing.Size(800, 450);
            this.selectArsenalPanel.TabIndex = 0;
            // 
            // lbCoins
            // 
            this.lbCoins.AutoSize = true;
            this.lbCoins.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoins.Location = new System.Drawing.Point(611, 19);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(101, 41);
            this.lbCoins.TabIndex = 2;
            this.lbCoins.Text = "1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(697, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 51);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gbUserArsenal
            // 
            this.gbUserArsenal.Controls.Add(this.listViewArsenalAvailable);
            this.gbUserArsenal.Location = new System.Drawing.Point(43, 95);
            this.gbUserArsenal.Name = "gbUserArsenal";
            this.gbUserArsenal.Size = new System.Drawing.Size(315, 209);
            this.gbUserArsenal.TabIndex = 6;
            this.gbUserArsenal.TabStop = false;
            this.gbUserArsenal.Text = "Arsenal Available";
            // 
            // listViewArsenalAvailable
            // 
            this.listViewArsenalAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewArsenalAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewArsenalAvailable.FullRowSelect = true;
            this.listViewArsenalAvailable.GridLines = true;
            this.listViewArsenalAvailable.HideSelection = false;
            this.listViewArsenalAvailable.Location = new System.Drawing.Point(3, 16);
            this.listViewArsenalAvailable.MultiSelect = false;
            this.listViewArsenalAvailable.Name = "listViewArsenalAvailable";
            this.listViewArsenalAvailable.Size = new System.Drawing.Size(309, 190);
            this.listViewArsenalAvailable.TabIndex = 0;
            this.listViewArsenalAvailable.UseCompatibleStateImageBehavior = false;
            this.listViewArsenalAvailable.View = System.Windows.Forms.View.Details;
            this.listViewArsenalAvailable.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            // 
            // labeErrorAddingArsenal
            // 
            this.labeErrorAddingArsenal.AutoSize = true;
            this.labeErrorAddingArsenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeErrorAddingArsenal.ForeColor = System.Drawing.Color.Red;
            this.labeErrorAddingArsenal.Location = new System.Drawing.Point(352, 311);
            this.labeErrorAddingArsenal.Name = "labeErrorAddingArsenal";
            this.labeErrorAddingArsenal.Size = new System.Drawing.Size(0, 20);
            this.labeErrorAddingArsenal.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewArsenal);
            this.groupBox1.Location = new System.Drawing.Point(416, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arsenal for the match";
            // 
            // listViewArsenal
            // 
            this.listViewArsenal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.arsenalID,
            this.arsenalName,
            this.arsenalType,
            this.arsenalCost});
            this.listViewArsenal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewArsenal.FullRowSelect = true;
            this.listViewArsenal.GridLines = true;
            this.listViewArsenal.HideSelection = false;
            this.listViewArsenal.Location = new System.Drawing.Point(3, 16);
            this.listViewArsenal.MultiSelect = false;
            this.listViewArsenal.Name = "listViewArsenal";
            this.listViewArsenal.Size = new System.Drawing.Size(309, 190);
            this.listViewArsenal.TabIndex = 0;
            this.listViewArsenal.UseCompatibleStateImageBehavior = false;
            this.listViewArsenal.View = System.Windows.Forms.View.Details;
            this.listViewArsenal.SelectedIndexChanged += new System.EventHandler(this.ListViewArsenal_SelectedIndexChanged);
            // 
            // arsenalID
            // 
            this.arsenalID.Text = "ID";
            // 
            // arsenalName
            // 
            this.arsenalName.Text = "Name";
            this.arsenalName.Width = 125;
            // 
            // arsenalType
            // 
            this.arsenalType.Text = "Type";
            // 
            // arsenalCost
            // 
            this.arsenalCost.Text = "Cost";
            // 
            // btFinishAdding
            // 
            this.btFinishAdding.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinishAdding.ForeColor = System.Drawing.Color.Black;
            this.btFinishAdding.Location = new System.Drawing.Point(614, 353);
            this.btFinishAdding.Name = "btFinishAdding";
            this.btFinishAdding.Size = new System.Drawing.Size(117, 59);
            this.btFinishAdding.TabIndex = 4;
            this.btFinishAdding.Text = "Finish";
            this.btFinishAdding.UseVisualStyleBackColor = true;
            this.btFinishAdding.Click += new System.EventHandler(this.BtFinishAdding_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your arsenal";
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePanel.Controls.Add(this.lbWinOrLose);
            this.gamePanel.Controls.Add(this.lbRound);
            this.gamePanel.Controls.Add(this.label2);
            this.gamePanel.Controls.Add(this.lbErrorPlaying);
            this.gamePanel.Controls.Add(this.cbShields);
            this.gamePanel.Controls.Add(this.lbBullets);
            this.gamePanel.Controls.Add(this.labelUserName);
            this.gamePanel.Controls.Add(this.pictureBox2);
            this.gamePanel.Controls.Add(this.cbWeapons);
            this.gamePanel.Controls.Add(this.lbDescription);
            this.gamePanel.Controls.Add(this.btDefend);
            this.gamePanel.Controls.Add(this.lbActionEnemy);
            this.gamePanel.Controls.Add(this.lbActionUser);
            this.gamePanel.Controls.Add(this.btAttack);
            this.gamePanel.Controls.Add(this.btRecharge);
            this.gamePanel.Controls.Add(this.lbPointsOfLifeUser);
            this.gamePanel.Controls.Add(this.lbPointOfLifeEnemy);
            this.gamePanel.Controls.Add(this.lbOponentName);
            this.gamePanel.Controls.Add(this.pictureUser);
            this.gamePanel.Controls.Add(this.pictureEnemy);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(800, 450);
            this.gamePanel.TabIndex = 7;
            this.gamePanel.Visible = false;
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.BackColor = System.Drawing.Color.Transparent;
            this.lbRound.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRound.ForeColor = System.Drawing.Color.DarkRed;
            this.lbRound.Location = new System.Drawing.Point(424, 67);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(47, 34);
            this.lbRound.TabIndex = 19;
            this.lbRound.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(309, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Round";
            // 
            // lbErrorPlaying
            // 
            this.lbErrorPlaying.AutoSize = true;
            this.lbErrorPlaying.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorPlaying.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPlaying.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPlaying.Location = new System.Drawing.Point(186, 358);
            this.lbErrorPlaying.Name = "lbErrorPlaying";
            this.lbErrorPlaying.Size = new System.Drawing.Size(485, 21);
            this.lbErrorPlaying.TabIndex = 17;
            this.lbErrorPlaying.Text = "You have no bullets left, please select an other option";
            // 
            // cbShields
            // 
            this.cbShields.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShields.FormattingEnabled = true;
            this.cbShields.Location = new System.Drawing.Point(499, 392);
            this.cbShields.Name = "cbShields";
            this.cbShields.Size = new System.Drawing.Size(121, 25);
            this.cbShields.TabIndex = 16;
            // 
            // lbBullets
            // 
            this.lbBullets.AutoSize = true;
            this.lbBullets.BackColor = System.Drawing.Color.Transparent;
            this.lbBullets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBullets.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBullets.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBullets.Location = new System.Drawing.Point(63, 356);
            this.lbBullets.Name = "lbBullets";
            this.lbBullets.Size = new System.Drawing.Size(31, 23);
            this.lbBullets.TabIndex = 15;
            this.lbBullets.Text = "19";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(129, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(105, 34);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Freddy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(85, 356);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 23);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // cbWeapons
            // 
            this.cbWeapons.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWeapons.FormattingEnabled = true;
            this.cbWeapons.Location = new System.Drawing.Point(190, 392);
            this.cbWeapons.Name = "cbWeapons";
            this.cbWeapons.Size = new System.Drawing.Size(121, 25);
            this.cbWeapons.TabIndex = 12;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDescription.Location = new System.Drawing.Point(264, 127);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(179, 34);
            this.lbDescription.TabIndex = 11;
            this.lbDescription.Text = "Oponent has maken you \r\n100 points of damage!!";
            // 
            // btDefend
            // 
            this.btDefend.BackColor = System.Drawing.Color.Black;
            this.btDefend.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDefend.ForeColor = System.Drawing.Color.White;
            this.btDefend.Location = new System.Drawing.Point(642, 382);
            this.btDefend.Name = "btDefend";
            this.btDefend.Size = new System.Drawing.Size(106, 41);
            this.btDefend.TabIndex = 10;
            this.btDefend.Text = "Defend";
            this.btDefend.UseVisualStyleBackColor = false;
            this.btDefend.Click += new System.EventHandler(this.btDefend_Click);
            // 
            // lbActionEnemy
            // 
            this.lbActionEnemy.AutoSize = true;
            this.lbActionEnemy.BackColor = System.Drawing.Color.Transparent;
            this.lbActionEnemy.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActionEnemy.ForeColor = System.Drawing.SystemColors.Control;
            this.lbActionEnemy.Location = new System.Drawing.Point(529, 93);
            this.lbActionEnemy.Name = "lbActionEnemy";
            this.lbActionEnemy.Size = new System.Drawing.Size(132, 34);
            this.lbActionEnemy.TabIndex = 9;
            this.lbActionEnemy.Text = "Recharge";
            // 
            // lbActionUser
            // 
            this.lbActionUser.AutoSize = true;
            this.lbActionUser.BackColor = System.Drawing.Color.Transparent;
            this.lbActionUser.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActionUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbActionUser.Location = new System.Drawing.Point(120, 93);
            this.lbActionUser.Name = "lbActionUser";
            this.lbActionUser.Size = new System.Drawing.Size(132, 34);
            this.lbActionUser.TabIndex = 8;
            this.lbActionUser.Text = "Recharge";
            // 
            // btAttack
            // 
            this.btAttack.BackColor = System.Drawing.Color.Black;
            this.btAttack.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAttack.ForeColor = System.Drawing.Color.White;
            this.btAttack.Location = new System.Drawing.Point(356, 382);
            this.btAttack.Name = "btAttack";
            this.btAttack.Size = new System.Drawing.Size(106, 41);
            this.btAttack.TabIndex = 7;
            this.btAttack.Text = "Attack";
            this.btAttack.UseVisualStyleBackColor = false;
            this.btAttack.Click += new System.EventHandler(this.btAttack_Click);
            // 
            // btRecharge
            // 
            this.btRecharge.BackColor = System.Drawing.Color.Black;
            this.btRecharge.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecharge.ForeColor = System.Drawing.Color.White;
            this.btRecharge.Location = new System.Drawing.Point(50, 382);
            this.btRecharge.Name = "btRecharge";
            this.btRecharge.Size = new System.Drawing.Size(106, 41);
            this.btRecharge.TabIndex = 6;
            this.btRecharge.Text = "Recharge";
            this.btRecharge.UseVisualStyleBackColor = false;
            this.btRecharge.Click += new System.EventHandler(this.btRecharge_Click);
            // 
            // lbPointsOfLifeUser
            // 
            this.lbPointsOfLifeUser.AutoSize = true;
            this.lbPointsOfLifeUser.BackColor = System.Drawing.Color.Transparent;
            this.lbPointsOfLifeUser.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPointsOfLifeUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPointsOfLifeUser.Location = new System.Drawing.Point(147, 304);
            this.lbPointsOfLifeUser.Name = "lbPointsOfLifeUser";
            this.lbPointsOfLifeUser.Size = new System.Drawing.Size(87, 34);
            this.lbPointsOfLifeUser.TabIndex = 5;
            this.lbPointsOfLifeUser.Text = "1000";
            // 
            // lbPointOfLifeEnemy
            // 
            this.lbPointOfLifeEnemy.AutoSize = true;
            this.lbPointOfLifeEnemy.BackColor = System.Drawing.Color.Transparent;
            this.lbPointOfLifeEnemy.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPointOfLifeEnemy.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPointOfLifeEnemy.Location = new System.Drawing.Point(576, 304);
            this.lbPointOfLifeEnemy.Name = "lbPointOfLifeEnemy";
            this.lbPointOfLifeEnemy.Size = new System.Drawing.Size(87, 34);
            this.lbPointOfLifeEnemy.TabIndex = 4;
            this.lbPointOfLifeEnemy.Text = "1000";
            // 
            // lbOponentName
            // 
            this.lbOponentName.AutoSize = true;
            this.lbOponentName.BackColor = System.Drawing.Color.Transparent;
            this.lbOponentName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOponentName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOponentName.Location = new System.Drawing.Point(493, 0);
            this.lbOponentName.Name = "lbOponentName";
            this.lbOponentName.Size = new System.Drawing.Size(105, 34);
            this.lbOponentName.TabIndex = 3;
            this.lbOponentName.Text = "Freddy";
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureUser.BackgroundImage")));
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureUser.Location = new System.Drawing.Point(85, 135);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(201, 167);
            this.pictureUser.TabIndex = 1;
            this.pictureUser.TabStop = false;
            // 
            // pictureEnemy
            // 
            this.pictureEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureEnemy.BackgroundImage")));
            this.pictureEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEnemy.Location = new System.Drawing.Point(512, 135);
            this.pictureEnemy.Name = "pictureEnemy";
            this.pictureEnemy.Size = new System.Drawing.Size(201, 167);
            this.pictureEnemy.TabIndex = 0;
            this.pictureEnemy.TabStop = false;
            // 
            // lbWinOrLose
            // 
            this.lbWinOrLose.AutoSize = true;
            this.lbWinOrLose.BackColor = System.Drawing.Color.Lavender;
            this.lbWinOrLose.Font = new System.Drawing.Font("Impact", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinOrLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbWinOrLose.Location = new System.Drawing.Point(182, 161);
            this.lbWinOrLose.Name = "lbWinOrLose";
            this.lbWinOrLose.Size = new System.Drawing.Size(449, 117);
            this.lbWinOrLose.TabIndex = 20;
            this.lbWinOrLose.Text = "You Win!!!";
            this.lbWinOrLose.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.selectArsenalPanel);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.windowClosed);
            this.selectArsenalPanel.ResumeLayout(false);
            this.selectArsenalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUserArsenal.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectArsenalPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewArsenal;
        private System.Windows.Forms.ColumnHeader arsenalID;
        private System.Windows.Forms.ColumnHeader arsenalName;
        private System.Windows.Forms.ColumnHeader arsenalType;
        private System.Windows.Forms.ColumnHeader arsenalCost;
        private System.Windows.Forms.Button btFinishAdding;
        private System.Windows.Forms.Label lbCoins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeErrorAddingArsenal;
        private System.Windows.Forms.GroupBox gbUserArsenal;
        private System.Windows.Forms.ListView listViewArsenalAvailable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox pictureEnemy;
        private System.Windows.Forms.Label lbPointsOfLifeUser;
        private System.Windows.Forms.Label lbPointOfLifeEnemy;
        private System.Windows.Forms.Label lbOponentName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button btDefend;
        private System.Windows.Forms.Label lbActionEnemy;
        private System.Windows.Forms.Label lbActionUser;
        private System.Windows.Forms.Button btAttack;
        private System.Windows.Forms.Button btRecharge;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.ComboBox cbWeapons;
        private System.Windows.Forms.Label lbBullets;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbShields;
        private System.Windows.Forms.Label lbErrorPlaying;
        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWinOrLose;
    }
}