namespace gameClient
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.homePanel = new System.Windows.Forms.Panel();
            this.btUserProfile = new System.Windows.Forms.Button();
            this.btTrophy = new System.Windows.Forms.Button();
            this.btGoStartBatle = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lbErrorPrivateRoom = new System.Windows.Forms.Label();
            this.btBackFromGamePanel = new System.Windows.Forms.Button();
            this.btSearchRooms = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrivateRoomCode = new System.Windows.Forms.TextBox();
            this.btPrivateRoom = new System.Windows.Forms.Button();
            this.btCreateMatch = new System.Windows.Forms.Button();
            this.gbCreateRoom = new System.Windows.Forms.GroupBox();
            this.BackCreateRoomPanel = new System.Windows.Forms.Button();
            this.lbWaitingForPlayer = new System.Windows.Forms.Label();
            this.lbMatchCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGoSocial = new System.Windows.Forms.Button();
            this.btGoSettings = new System.Windows.Forms.Button();
            this.socialPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btGoSearchPlayer = new System.Windows.Forms.Button();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.Order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.friendId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FriendName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.friendTrophies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btGoHome = new System.Windows.Forms.Button();
            this.joinPublicPanel = new System.Windows.Forms.Panel();
            this.btBackFromJoinPublicPanel = new System.Windows.Forms.Button();
            this.btSelectOponent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewSelectOponent = new System.Windows.Forms.ListView();
            this.RoomCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userIdR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userNameR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userTrophiesR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.homePanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.gbCreateRoom.SuspendLayout();
            this.socialPanel.SuspendLayout();
            this.joinPublicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.btUserProfile);
            this.homePanel.Controls.Add(this.btTrophy);
            this.homePanel.Controls.Add(this.btGoStartBatle);
            this.homePanel.Controls.Add(this.lbUserName);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(856, 345);
            this.homePanel.TabIndex = 1;
            // 
            // btUserProfile
            // 
            this.btUserProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUserProfile.BackgroundImage")));
            this.btUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUserProfile.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUserProfile.Location = new System.Drawing.Point(690, 117);
            this.btUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btUserProfile.Name = "btUserProfile";
            this.btUserProfile.Size = new System.Drawing.Size(65, 55);
            this.btUserProfile.TabIndex = 5;
            this.btUserProfile.UseVisualStyleBackColor = true;
            this.btUserProfile.Click += new System.EventHandler(this.btUserProfile_Click);
            // 
            // btTrophy
            // 
            this.btTrophy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTrophy.BackgroundImage")));
            this.btTrophy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTrophy.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrophy.Location = new System.Drawing.Point(690, 32);
            this.btTrophy.Margin = new System.Windows.Forms.Padding(2);
            this.btTrophy.Name = "btTrophy";
            this.btTrophy.Size = new System.Drawing.Size(65, 55);
            this.btTrophy.TabIndex = 4;
            this.btTrophy.UseVisualStyleBackColor = true;
            this.btTrophy.Click += new System.EventHandler(this.btTrophy_Click);
            // 
            // btGoStartBatle
            // 
            this.btGoStartBatle.BackColor = System.Drawing.Color.Transparent;
            this.btGoStartBatle.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoStartBatle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btGoStartBatle.Location = new System.Drawing.Point(269, 136);
            this.btGoStartBatle.Margin = new System.Windows.Forms.Padding(2);
            this.btGoStartBatle.Name = "btGoStartBatle";
            this.btGoStartBatle.Size = new System.Drawing.Size(300, 125);
            this.btGoStartBatle.TabIndex = 4;
            this.btGoStartBatle.Text = "Start Battle";
            this.btGoStartBatle.UseVisualStyleBackColor = false;
            this.btGoStartBatle.Click += new System.EventHandler(this.btGoStartBatle_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbUserName.Location = new System.Drawing.Point(84, 32);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(109, 28);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "UserName";
            this.lbUserName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.lbErrorPrivateRoom);
            this.gamePanel.Controls.Add(this.btBackFromGamePanel);
            this.gamePanel.Controls.Add(this.btSearchRooms);
            this.gamePanel.Controls.Add(this.label2);
            this.gamePanel.Controls.Add(this.tbPrivateRoomCode);
            this.gamePanel.Controls.Add(this.btPrivateRoom);
            this.gamePanel.Controls.Add(this.btCreateMatch);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(856, 456);
            this.gamePanel.TabIndex = 2;
            this.gamePanel.Visible = false;
            // 
            // lbErrorPrivateRoom
            // 
            this.lbErrorPrivateRoom.AutoSize = true;
            this.lbErrorPrivateRoom.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPrivateRoom.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPrivateRoom.Location = new System.Drawing.Point(444, 315);
            this.lbErrorPrivateRoom.Name = "lbErrorPrivateRoom";
            this.lbErrorPrivateRoom.Size = new System.Drawing.Size(166, 16);
            this.lbErrorPrivateRoom.TabIndex = 6;
            this.lbErrorPrivateRoom.Text = "Error: Room not founded";
            this.lbErrorPrivateRoom.Visible = false;
            // 
            // btBackFromGamePanel
            // 
            this.btBackFromGamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackFromGamePanel.BackgroundImage")));
            this.btBackFromGamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBackFromGamePanel.Location = new System.Drawing.Point(107, 56);
            this.btBackFromGamePanel.Name = "btBackFromGamePanel";
            this.btBackFromGamePanel.Size = new System.Drawing.Size(111, 55);
            this.btBackFromGamePanel.TabIndex = 4;
            this.btBackFromGamePanel.UseVisualStyleBackColor = true;
            this.btBackFromGamePanel.Click += new System.EventHandler(this.BtBackFromGamePanel_Click);
            // 
            // btSearchRooms
            // 
            this.btSearchRooms.Location = new System.Drawing.Point(352, 181);
            this.btSearchRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btSearchRooms.Name = "btSearchRooms";
            this.btSearchRooms.Size = new System.Drawing.Size(150, 46);
            this.btSearchRooms.TabIndex = 5;
            this.btSearchRooms.Text = "Search Room";
            this.btSearchRooms.UseVisualStyleBackColor = true;
            this.btSearchRooms.Click += new System.EventHandler(this.btSearchRooms_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the room code: ";
            // 
            // tbPrivateRoomCode
            // 
            this.tbPrivateRoomCode.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrivateRoomCode.Location = new System.Drawing.Point(352, 272);
            this.tbPrivateRoomCode.Name = "tbPrivateRoomCode";
            this.tbPrivateRoomCode.Size = new System.Drawing.Size(150, 36);
            this.tbPrivateRoomCode.TabIndex = 3;
            // 
            // btPrivateRoom
            // 
            this.btPrivateRoom.Location = new System.Drawing.Point(507, 272);
            this.btPrivateRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btPrivateRoom.Name = "btPrivateRoom";
            this.btPrivateRoom.Size = new System.Drawing.Size(114, 36);
            this.btPrivateRoom.TabIndex = 2;
            this.btPrivateRoom.Text = "Go Private Room";
            this.btPrivateRoom.UseVisualStyleBackColor = true;
            this.btPrivateRoom.Click += new System.EventHandler(this.btPrivateRoom_Click);
            // 
            // btCreateMatch
            // 
            this.btCreateMatch.Location = new System.Drawing.Point(352, 104);
            this.btCreateMatch.Margin = new System.Windows.Forms.Padding(2);
            this.btCreateMatch.Name = "btCreateMatch";
            this.btCreateMatch.Size = new System.Drawing.Size(150, 46);
            this.btCreateMatch.TabIndex = 0;
            this.btCreateMatch.Text = "Create Room";
            this.btCreateMatch.UseVisualStyleBackColor = true;
            this.btCreateMatch.Click += new System.EventHandler(this.btCreateMatch_Click);
            // 
            // gbCreateRoom
            // 
            this.gbCreateRoom.Controls.Add(this.BackCreateRoomPanel);
            this.gbCreateRoom.Controls.Add(this.lbWaitingForPlayer);
            this.gbCreateRoom.Controls.Add(this.lbMatchCode);
            this.gbCreateRoom.Controls.Add(this.label1);
            this.gbCreateRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCreateRoom.Location = new System.Drawing.Point(0, 0);
            this.gbCreateRoom.Name = "gbCreateRoom";
            this.gbCreateRoom.Size = new System.Drawing.Size(856, 456);
            this.gbCreateRoom.TabIndex = 1;
            this.gbCreateRoom.TabStop = false;
            this.gbCreateRoom.Text = "Create Room";
            this.gbCreateRoom.Visible = false;
            // 
            // BackCreateRoomPanel
            // 
            this.BackCreateRoomPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackCreateRoomPanel.BackgroundImage")));
            this.BackCreateRoomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackCreateRoomPanel.Location = new System.Drawing.Point(107, 47);
            this.BackCreateRoomPanel.Name = "BackCreateRoomPanel";
            this.BackCreateRoomPanel.Size = new System.Drawing.Size(96, 55);
            this.BackCreateRoomPanel.TabIndex = 3;
            this.BackCreateRoomPanel.UseVisualStyleBackColor = true;
            this.BackCreateRoomPanel.Click += new System.EventHandler(this.BackCreateRoomPanel_Click);
            // 
            // lbWaitingForPlayer
            // 
            this.lbWaitingForPlayer.AutoSize = true;
            this.lbWaitingForPlayer.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingForPlayer.ForeColor = System.Drawing.Color.DimGray;
            this.lbWaitingForPlayer.Location = new System.Drawing.Point(401, 273);
            this.lbWaitingForPlayer.Name = "lbWaitingForPlayer";
            this.lbWaitingForPlayer.Size = new System.Drawing.Size(145, 16);
            this.lbWaitingForPlayer.TabIndex = 2;
            this.lbWaitingForPlayer.Text = "Waiting for another player...";
            // 
            // lbMatchCode
            // 
            this.lbMatchCode.AutoSize = true;
            this.lbMatchCode.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatchCode.Location = new System.Drawing.Point(384, 205);
            this.lbMatchCode.Name = "lbMatchCode";
            this.lbMatchCode.Size = new System.Drawing.Size(0, 44);
            this.lbMatchCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Match Code:";
            // 
            // btGoSocial
            // 
            this.btGoSocial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoSocial.BackgroundImage")));
            this.btGoSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoSocial.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoSocial.Location = new System.Drawing.Point(61, 349);
            this.btGoSocial.Margin = new System.Windows.Forms.Padding(2);
            this.btGoSocial.Name = "btGoSocial";
            this.btGoSocial.Size = new System.Drawing.Size(117, 65);
            this.btGoSocial.TabIndex = 2;
            this.btGoSocial.Text = "Social";
            this.btGoSocial.UseVisualStyleBackColor = true;
            this.btGoSocial.Click += new System.EventHandler(this.btGoSocial_Click);
            // 
            // btGoSettings
            // 
            this.btGoSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoSettings.BackgroundImage")));
            this.btGoSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoSettings.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoSettings.Location = new System.Drawing.Point(678, 349);
            this.btGoSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btGoSettings.Name = "btGoSettings";
            this.btGoSettings.Size = new System.Drawing.Size(117, 65);
            this.btGoSettings.TabIndex = 3;
            this.btGoSettings.UseVisualStyleBackColor = true;
            this.btGoSettings.Click += new System.EventHandler(this.btGoSettings_Click);
            // 
            // socialPanel
            // 
            this.socialPanel.Controls.Add(this.label4);
            this.socialPanel.Controls.Add(this.btGoSearchPlayer);
            this.socialPanel.Controls.Add(this.listViewFriends);
            this.socialPanel.Location = new System.Drawing.Point(11, 11);
            this.socialPanel.Margin = new System.Windows.Forms.Padding(2);
            this.socialPanel.Name = "socialPanel";
            this.socialPanel.Size = new System.Drawing.Size(834, 334);
            this.socialPanel.TabIndex = 0;
            this.socialPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(355, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Friends";
            // 
            // btGoSearchPlayer
            // 
            this.btGoSearchPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoSearchPlayer.BackgroundImage")));
            this.btGoSearchPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoSearchPlayer.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoSearchPlayer.Location = new System.Drawing.Point(675, 23);
            this.btGoSearchPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btGoSearchPlayer.Name = "btGoSearchPlayer";
            this.btGoSearchPlayer.Size = new System.Drawing.Size(80, 50);
            this.btGoSearchPlayer.TabIndex = 5;
            this.btGoSearchPlayer.UseVisualStyleBackColor = true;
            this.btGoSearchPlayer.Click += new System.EventHandler(this.btGoSearchPlayer_Click);
            // 
            // listViewFriends
            // 
            this.listViewFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order,
            this.friendId,
            this.FriendName,
            this.friendTrophies});
            this.listViewFriends.FullRowSelect = true;
            this.listViewFriends.GridLines = true;
            this.listViewFriends.HideSelection = false;
            this.listViewFriends.Location = new System.Drawing.Point(237, 118);
            this.listViewFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFriends.MultiSelect = false;
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(384, 173);
            this.listViewFriends.TabIndex = 0;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            this.listViewFriends.View = System.Windows.Forms.View.Details;
            // 
            // Order
            // 
            this.Order.Text = "Position";
            this.Order.Width = 70;
            // 
            // friendId
            // 
            this.friendId.Text = "ID";
            this.friendId.Width = 70;
            // 
            // FriendName
            // 
            this.FriendName.Text = "Name";
            this.FriendName.Width = 175;
            // 
            // friendTrophies
            // 
            this.friendTrophies.Text = "Trophies";
            this.friendTrophies.Width = 70;
            // 
            // btGoHome
            // 
            this.btGoHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoHome.BackgroundImage")));
            this.btGoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGoHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoHome.Location = new System.Drawing.Point(374, 349);
            this.btGoHome.Margin = new System.Windows.Forms.Padding(2);
            this.btGoHome.Name = "btGoHome";
            this.btGoHome.Size = new System.Drawing.Size(117, 65);
            this.btGoHome.TabIndex = 1;
            this.btGoHome.Text = "Home";
            this.btGoHome.UseVisualStyleBackColor = true;
            this.btGoHome.Click += new System.EventHandler(this.btGoHome_Click);
            // 
            // joinPublicPanel
            // 
            this.joinPublicPanel.Controls.Add(this.btBackFromJoinPublicPanel);
            this.joinPublicPanel.Controls.Add(this.btSelectOponent);
            this.joinPublicPanel.Controls.Add(this.label3);
            this.joinPublicPanel.Controls.Add(this.listViewSelectOponent);
            this.joinPublicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinPublicPanel.Location = new System.Drawing.Point(0, 0);
            this.joinPublicPanel.Name = "joinPublicPanel";
            this.joinPublicPanel.Size = new System.Drawing.Size(856, 456);
            this.joinPublicPanel.TabIndex = 4;
            this.joinPublicPanel.Visible = false;
            // 
            // btBackFromJoinPublicPanel
            // 
            this.btBackFromJoinPublicPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackFromJoinPublicPanel.BackgroundImage")));
            this.btBackFromJoinPublicPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBackFromJoinPublicPanel.Location = new System.Drawing.Point(82, 47);
            this.btBackFromJoinPublicPanel.Name = "btBackFromJoinPublicPanel";
            this.btBackFromJoinPublicPanel.Size = new System.Drawing.Size(111, 55);
            this.btBackFromJoinPublicPanel.TabIndex = 5;
            this.btBackFromJoinPublicPanel.UseVisualStyleBackColor = true;
            this.btBackFromJoinPublicPanel.Click += new System.EventHandler(this.BtBackFromJoinPublicPanel_Click);
            // 
            // btSelectOponent
            // 
            this.btSelectOponent.Location = new System.Drawing.Point(669, 230);
            this.btSelectOponent.Name = "btSelectOponent";
            this.btSelectOponent.Size = new System.Drawing.Size(100, 47);
            this.btSelectOponent.TabIndex = 2;
            this.btSelectOponent.Text = "Play";
            this.btSelectOponent.UseVisualStyleBackColor = true;
            this.btSelectOponent.Click += new System.EventHandler(this.btSelectOponent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(283, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select an oponent: ";
            // 
            // listViewSelectOponent
            // 
            this.listViewSelectOponent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomCode,
            this.userIdR,
            this.userNameR,
            this.userTrophiesR});
            this.listViewSelectOponent.FullRowSelect = true;
            this.listViewSelectOponent.GridLines = true;
            this.listViewSelectOponent.HideSelection = false;
            this.listViewSelectOponent.Location = new System.Drawing.Point(204, 159);
            this.listViewSelectOponent.MultiSelect = false;
            this.listViewSelectOponent.Name = "listViewSelectOponent";
            this.listViewSelectOponent.Size = new System.Drawing.Size(428, 183);
            this.listViewSelectOponent.TabIndex = 0;
            this.listViewSelectOponent.UseCompatibleStateImageBehavior = false;
            this.listViewSelectOponent.View = System.Windows.Forms.View.Details;
            // 
            // RoomCode
            // 
            this.RoomCode.Text = "Room Code";
            this.RoomCode.Width = 90;
            // 
            // userIdR
            // 
            this.userIdR.Text = "User ID";
            this.userIdR.Width = 70;
            // 
            // userNameR
            // 
            this.userNameR.Text = "User Name";
            this.userNameR.Width = 175;
            // 
            // userTrophiesR
            // 
            this.userTrophiesR.Text = "User Trophies";
            this.userTrophiesR.Width = 85;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.gbCreateRoom);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.joinPublicPanel);
            this.Controls.Add(this.socialPanel);
            this.Controls.Add(this.btGoSettings);
            this.Controls.Add(this.btGoSocial);
            this.Controls.Add(this.btGoHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onClosing);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.gbCreateRoom.ResumeLayout(false);
            this.gbCreateRoom.PerformLayout();
            this.socialPanel.ResumeLayout(false);
            this.socialPanel.PerformLayout();
            this.joinPublicPanel.ResumeLayout(false);
            this.joinPublicPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btGoSocial;
        private System.Windows.Forms.Button btGoSettings;
        private System.Windows.Forms.Button btGoStartBatle;
        private System.Windows.Forms.Button btTrophy;
        private System.Windows.Forms.Button btUserProfile;
        private System.Windows.Forms.Panel socialPanel;
        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.Button btGoSearchPlayer;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button btCreateMatch;
        private System.Windows.Forms.Button btGoHome;
        private System.Windows.Forms.Button btPrivateRoom;
        private System.Windows.Forms.GroupBox gbCreateRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackCreateRoomPanel;
        private System.Windows.Forms.Label lbWaitingForPlayer;
        private System.Windows.Forms.Label lbMatchCode;
        private System.Windows.Forms.Button btSearchRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrivateRoomCode;
        private System.Windows.Forms.Panel joinPublicPanel;
        private System.Windows.Forms.Button btSelectOponent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewSelectOponent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Order;
        private System.Windows.Forms.ColumnHeader friendId;
        private System.Windows.Forms.ColumnHeader FriendName;
        private System.Windows.Forms.ColumnHeader friendTrophies;
        private System.Windows.Forms.ColumnHeader RoomCode;
        private System.Windows.Forms.ColumnHeader userIdR;
        private System.Windows.Forms.ColumnHeader userNameR;
        private System.Windows.Forms.ColumnHeader userTrophiesR;
        private System.Windows.Forms.Button btBackFromGamePanel;
        private System.Windows.Forms.Button btBackFromJoinPublicPanel;
        private System.Windows.Forms.Label lbErrorPrivateRoom;
    }
}