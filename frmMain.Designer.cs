namespace DNDSoundboard
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDing = new System.Windows.Forms.Button();
            this.btnFireball = new System.Windows.Forms.Button();
            this.grbWeapons = new System.Windows.Forms.GroupBox();
            this.btnDeath = new System.Windows.Forms.Button();
            this.lblDeath = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.lblDefense = new System.Windows.Forms.Label();
            this.btnSwordDraw = new System.Windows.Forms.Button();
            this.btnSwordMiss = new System.Windows.Forms.Button();
            this.btnSwordFlaunt = new System.Windows.Forms.Button();
            this.btnMiss = new System.Windows.Forms.Button();
            this.btnClubHit = new System.Windows.Forms.Button();
            this.btnStaffHit = new System.Windows.Forms.Button();
            this.lblClub = new System.Windows.Forms.Label();
            this.btnSwordsBout = new System.Windows.Forms.Button();
            this.btnKnifeStab = new System.Windows.Forms.Button();
            this.btnKnifeSharpen = new System.Windows.Forms.Button();
            this.btnThrowingKnife = new System.Windows.Forms.Button();
            this.lblKnifes = new System.Windows.Forms.Label();
            this.lblBows = new System.Windows.Forms.Label();
            this.lblSwords = new System.Windows.Forms.Label();
            this.btnBowFlames = new System.Windows.Forms.Button();
            this.btnBowRelease = new System.Windows.Forms.Button();
            this.btnSwordsClashing = new System.Windows.Forms.Button();
            this.btnSwordSlashLimb = new System.Windows.Forms.Button();
            this.btnSwordSlash = new System.Windows.Forms.Button();
            this.btnBattleMusic = new System.Windows.Forms.Button();
            this.btnOpenLink = new System.Windows.Forms.Button();
            this.SFPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.btnLoadVideo = new System.Windows.Forms.Button();
            this.txtVideoRef = new System.Windows.Forms.TextBox();
            this.grpThemes = new System.Windows.Forms.GroupBox();
            this.grpNavigate = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.txtLinkURL = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLinkName = new System.Windows.Forms.TextBox();
            this.lblLinkName = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblLinkURL = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.tblCustomLinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dNDSoundboardDataSet = new DNDSoundboard.DNDSoundboardDataSet();
            this.grpUtilitySounds = new System.Windows.Forms.GroupBox();
            this.btnTogglePlay = new System.Windows.Forms.Button();
            this.grpBuiltInThemes = new System.Windows.Forms.GroupBox();
            this.btnTristramTheme = new System.Windows.Forms.Button();
            this.trkThemes = new System.Windows.Forms.TrackBar();
            this.btnHeroTheme = new System.Windows.Forms.Button();
            this.btnMainBattleTheme = new System.Windows.Forms.Button();
            this.btnBossBattleTheme = new System.Windows.Forms.Button();
            this.btnDungeonTheme = new System.Windows.Forms.Button();
            this.btnTownTheme = new System.Windows.Forms.Button();
            this.btnMainVillainTheme = new System.Windows.Forms.Button();
            this.lblCurrentPlay = new System.Windows.Forms.Label();
            this.txtCurrentlyPlaying = new System.Windows.Forms.TextBox();
            this.tblCustomLinksTableAdapter = new DNDSoundboard.DNDSoundboardDataSetTableAdapters.tblCustomLinksTableAdapter();
            this.grbWeapons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFPlayer)).BeginInit();
            this.grpThemes.SuspendLayout();
            this.grpNavigate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomLinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNDSoundboardDataSet)).BeginInit();
            this.grpUtilitySounds.SuspendLayout();
            this.grpBuiltInThemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkThemes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDing
            // 
            this.btnDing.Location = new System.Drawing.Point(131, 106);
            this.btnDing.Name = "btnDing";
            this.btnDing.Size = new System.Drawing.Size(75, 23);
            this.btnDing.TabIndex = 0;
            this.btnDing.Text = "Ding";
            this.btnDing.UseVisualStyleBackColor = true;
            this.btnDing.Click += new System.EventHandler(this.btnDing_Click);
            // 
            // btnFireball
            // 
            this.btnFireball.Location = new System.Drawing.Point(131, 140);
            this.btnFireball.Name = "btnFireball";
            this.btnFireball.Size = new System.Drawing.Size(75, 23);
            this.btnFireball.TabIndex = 1;
            this.btnFireball.Text = "Fireball";
            this.btnFireball.UseVisualStyleBackColor = true;
            this.btnFireball.Click += new System.EventHandler(this.btnFireball_Click);
            // 
            // grbWeapons
            // 
            this.grbWeapons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbWeapons.Controls.Add(this.btnDeath);
            this.grbWeapons.Controls.Add(this.lblDeath);
            this.grbWeapons.Controls.Add(this.btnBlock);
            this.grbWeapons.Controls.Add(this.lblDefense);
            this.grbWeapons.Controls.Add(this.btnSwordDraw);
            this.grbWeapons.Controls.Add(this.btnSwordMiss);
            this.grbWeapons.Controls.Add(this.btnSwordFlaunt);
            this.grbWeapons.Controls.Add(this.btnMiss);
            this.grbWeapons.Controls.Add(this.btnClubHit);
            this.grbWeapons.Controls.Add(this.btnStaffHit);
            this.grbWeapons.Controls.Add(this.lblClub);
            this.grbWeapons.Controls.Add(this.btnSwordsBout);
            this.grbWeapons.Controls.Add(this.btnKnifeStab);
            this.grbWeapons.Controls.Add(this.btnKnifeSharpen);
            this.grbWeapons.Controls.Add(this.btnThrowingKnife);
            this.grbWeapons.Controls.Add(this.lblKnifes);
            this.grbWeapons.Controls.Add(this.lblBows);
            this.grbWeapons.Controls.Add(this.lblSwords);
            this.grbWeapons.Controls.Add(this.btnBowFlames);
            this.grbWeapons.Controls.Add(this.btnBowRelease);
            this.grbWeapons.Controls.Add(this.btnSwordsClashing);
            this.grbWeapons.Controls.Add(this.btnSwordSlashLimb);
            this.grbWeapons.Controls.Add(this.btnSwordSlash);
            this.grbWeapons.Location = new System.Drawing.Point(12, 12);
            this.grbWeapons.Name = "grbWeapons";
            this.grbWeapons.Size = new System.Drawing.Size(303, 380);
            this.grbWeapons.TabIndex = 3;
            this.grbWeapons.TabStop = false;
            this.grbWeapons.Text = "Weapons";
            // 
            // btnDeath
            // 
            this.btnDeath.Location = new System.Drawing.Point(158, 331);
            this.btnDeath.Name = "btnDeath";
            this.btnDeath.Size = new System.Drawing.Size(125, 23);
            this.btnDeath.TabIndex = 16;
            this.btnDeath.Text = "Death";
            this.btnDeath.UseVisualStyleBackColor = true;
            this.btnDeath.Click += new System.EventHandler(this.btnDeath_Click);
            // 
            // lblDeath
            // 
            this.lblDeath.AutoSize = true;
            this.lblDeath.Location = new System.Drawing.Point(159, 307);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(129, 13);
            this.lblDeath.TabIndex = 16;
            this.lblDeath.Text = "Whenever Someone Dies";
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(158, 273);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(125, 23);
            this.btnBlock.TabIndex = 15;
            this.btnBlock.Text = "Metal Shield Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Location = new System.Drawing.Point(159, 257);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(47, 13);
            this.lblDefense.TabIndex = 15;
            this.lblDefense.Text = "Defense";
            // 
            // btnSwordDraw
            // 
            this.btnSwordDraw.Location = new System.Drawing.Point(6, 192);
            this.btnSwordDraw.Name = "btnSwordDraw";
            this.btnSwordDraw.Size = new System.Drawing.Size(128, 23);
            this.btnSwordDraw.TabIndex = 12;
            this.btnSwordDraw.Text = "Swords  - Draw";
            this.btnSwordDraw.UseVisualStyleBackColor = true;
            this.btnSwordDraw.Click += new System.EventHandler(this.btnSwordDraw_Click);
            // 
            // btnSwordMiss
            // 
            this.btnSwordMiss.Location = new System.Drawing.Point(7, 221);
            this.btnSwordMiss.Name = "btnSwordMiss";
            this.btnSwordMiss.Size = new System.Drawing.Size(128, 23);
            this.btnSwordMiss.TabIndex = 12;
            this.btnSwordMiss.Text = "Swords - Miss";
            this.btnSwordMiss.UseVisualStyleBackColor = true;
            this.btnSwordMiss.Click += new System.EventHandler(this.btnSwordMiss_Click);
            // 
            // btnSwordFlaunt
            // 
            this.btnSwordFlaunt.Location = new System.Drawing.Point(6, 163);
            this.btnSwordFlaunt.Name = "btnSwordFlaunt";
            this.btnSwordFlaunt.Size = new System.Drawing.Size(128, 23);
            this.btnSwordFlaunt.TabIndex = 12;
            this.btnSwordFlaunt.Text = "Swords - Flaunt";
            this.btnSwordFlaunt.UseVisualStyleBackColor = true;
            this.btnSwordFlaunt.Click += new System.EventHandler(this.btnSwordFlaunt_Click_1);
            // 
            // btnMiss
            // 
            this.btnMiss.Location = new System.Drawing.Point(6, 331);
            this.btnMiss.Name = "btnMiss";
            this.btnMiss.Size = new System.Drawing.Size(125, 23);
            this.btnMiss.TabIndex = 14;
            this.btnMiss.Text = "Miss";
            this.btnMiss.UseVisualStyleBackColor = true;
            this.btnMiss.Click += new System.EventHandler(this.btnMiss_Click);
            // 
            // btnClubHit
            // 
            this.btnClubHit.Location = new System.Drawing.Point(6, 302);
            this.btnClubHit.Name = "btnClubHit";
            this.btnClubHit.Size = new System.Drawing.Size(125, 23);
            this.btnClubHit.TabIndex = 10;
            this.btnClubHit.Text = "Club - Hit Bludgeon";
            this.btnClubHit.UseVisualStyleBackColor = true;
            this.btnClubHit.Click += new System.EventHandler(this.btnClubHit_Click);
            // 
            // btnStaffHit
            // 
            this.btnStaffHit.Location = new System.Drawing.Point(6, 273);
            this.btnStaffHit.Name = "btnStaffHit";
            this.btnStaffHit.Size = new System.Drawing.Size(125, 23);
            this.btnStaffHit.TabIndex = 13;
            this.btnStaffHit.Text = "Staff (light) - Hit";
            this.btnStaffHit.UseVisualStyleBackColor = true;
            this.btnStaffHit.Click += new System.EventHandler(this.btnStaffHit_Click);
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(7, 257);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(63, 13);
            this.lblClub.TabIndex = 12;
            this.lblClub.Text = "Clubs/ Staff";
            // 
            // btnSwordsBout
            // 
            this.btnSwordsBout.Location = new System.Drawing.Point(6, 134);
            this.btnSwordsBout.Name = "btnSwordsBout";
            this.btnSwordsBout.Size = new System.Drawing.Size(128, 23);
            this.btnSwordsBout.TabIndex = 11;
            this.btnSwordsBout.Text = "Swords - Bout";
            this.btnSwordsBout.UseVisualStyleBackColor = true;
            this.btnSwordsBout.Click += new System.EventHandler(this.btnSwordsBout_Click);
            // 
            // btnKnifeStab
            // 
            this.btnKnifeStab.Location = new System.Drawing.Point(158, 134);
            this.btnKnifeStab.Name = "btnKnifeStab";
            this.btnKnifeStab.Size = new System.Drawing.Size(125, 23);
            this.btnKnifeStab.TabIndex = 10;
            this.btnKnifeStab.Text = "Knife - Stab";
            this.btnKnifeStab.UseVisualStyleBackColor = true;
            this.btnKnifeStab.Click += new System.EventHandler(this.btnKnifeStab_Click);
            // 
            // btnKnifeSharpen
            // 
            this.btnKnifeSharpen.Location = new System.Drawing.Point(158, 192);
            this.btnKnifeSharpen.Name = "btnKnifeSharpen";
            this.btnKnifeSharpen.Size = new System.Drawing.Size(125, 23);
            this.btnKnifeSharpen.TabIndex = 9;
            this.btnKnifeSharpen.Text = "Knife - Sharpening";
            this.btnKnifeSharpen.UseVisualStyleBackColor = true;
            this.btnKnifeSharpen.Click += new System.EventHandler(this.btnKnifeSharpen_Click);
            // 
            // btnThrowingKnife
            // 
            this.btnThrowingKnife.Location = new System.Drawing.Point(158, 163);
            this.btnThrowingKnife.Name = "btnThrowingKnife";
            this.btnThrowingKnife.Size = new System.Drawing.Size(125, 23);
            this.btnThrowingKnife.TabIndex = 8;
            this.btnThrowingKnife.Text = "Knife - Throwing";
            this.btnThrowingKnife.UseVisualStyleBackColor = true;
            this.btnThrowingKnife.Click += new System.EventHandler(this.btnThrowingKnife_Click);
            // 
            // lblKnifes
            // 
            this.lblKnifes.AutoSize = true;
            this.lblKnifes.Location = new System.Drawing.Point(159, 115);
            this.lblKnifes.Name = "lblKnifes";
            this.lblKnifes.Size = new System.Drawing.Size(39, 13);
            this.lblKnifes.TabIndex = 7;
            this.lblKnifes.Text = "Knives";
            // 
            // lblBows
            // 
            this.lblBows.AutoSize = true;
            this.lblBows.Location = new System.Drawing.Point(158, 30);
            this.lblBows.Name = "lblBows";
            this.lblBows.Size = new System.Drawing.Size(33, 13);
            this.lblBows.TabIndex = 6;
            this.lblBows.Text = "Bows";
            // 
            // lblSwords
            // 
            this.lblSwords.AutoSize = true;
            this.lblSwords.Location = new System.Drawing.Point(7, 31);
            this.lblSwords.Name = "lblSwords";
            this.lblSwords.Size = new System.Drawing.Size(42, 13);
            this.lblSwords.TabIndex = 5;
            this.lblSwords.Text = "Swords";
            // 
            // btnBowFlames
            // 
            this.btnBowFlames.Location = new System.Drawing.Point(158, 76);
            this.btnBowFlames.Name = "btnBowFlames";
            this.btnBowFlames.Size = new System.Drawing.Size(128, 23);
            this.btnBowFlames.TabIndex = 4;
            this.btnBowFlames.Text = "Bow - Flaming Arrow";
            this.btnBowFlames.UseVisualStyleBackColor = true;
            this.btnBowFlames.Click += new System.EventHandler(this.btnBowFlames_Click);
            // 
            // btnBowRelease
            // 
            this.btnBowRelease.Location = new System.Drawing.Point(158, 46);
            this.btnBowRelease.Name = "btnBowRelease";
            this.btnBowRelease.Size = new System.Drawing.Size(128, 23);
            this.btnBowRelease.TabIndex = 3;
            this.btnBowRelease.Text = "Bow - Releasing Arrow";
            this.btnBowRelease.UseVisualStyleBackColor = true;
            this.btnBowRelease.Click += new System.EventHandler(this.btnBowRelease_Click);
            // 
            // btnSwordsClashing
            // 
            this.btnSwordsClashing.Location = new System.Drawing.Point(6, 76);
            this.btnSwordsClashing.Name = "btnSwordsClashing";
            this.btnSwordsClashing.Size = new System.Drawing.Size(129, 23);
            this.btnSwordsClashing.TabIndex = 2;
            this.btnSwordsClashing.Text = "Swords - Clashing";
            this.btnSwordsClashing.UseVisualStyleBackColor = true;
            this.btnSwordsClashing.Click += new System.EventHandler(this.btnSwordsClashing_Click);
            // 
            // btnSwordSlashLimb
            // 
            this.btnSwordSlashLimb.Location = new System.Drawing.Point(6, 105);
            this.btnSwordSlashLimb.Name = "btnSwordSlashLimb";
            this.btnSwordSlashLimb.Size = new System.Drawing.Size(129, 23);
            this.btnSwordSlashLimb.TabIndex = 1;
            this.btnSwordSlashLimb.Text = "Sword Slash - Limb Falls Off";
            this.btnSwordSlashLimb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSwordSlashLimb.UseVisualStyleBackColor = true;
            this.btnSwordSlashLimb.Click += new System.EventHandler(this.btnSwordSlashLimb_Click);
            // 
            // btnSwordSlash
            // 
            this.btnSwordSlash.Location = new System.Drawing.Point(6, 47);
            this.btnSwordSlash.Name = "btnSwordSlash";
            this.btnSwordSlash.Size = new System.Drawing.Size(128, 23);
            this.btnSwordSlash.TabIndex = 0;
            this.btnSwordSlash.Text = "Sword - Slash";
            this.btnSwordSlash.UseVisualStyleBackColor = true;
            this.btnSwordSlash.Click += new System.EventHandler(this.btnSwordSlash_Click);
            // 
            // btnBattleMusic
            // 
            this.btnBattleMusic.Location = new System.Drawing.Point(159, 136);
            this.btnBattleMusic.Name = "btnBattleMusic";
            this.btnBattleMusic.Size = new System.Drawing.Size(128, 23);
            this.btnBattleMusic.TabIndex = 4;
            this.btnBattleMusic.Text = "&Celtic Battle Theme";
            this.btnBattleMusic.UseVisualStyleBackColor = true;
            this.btnBattleMusic.Click += new System.EventHandler(this.btnBattleMusic_Click);
            // 
            // btnOpenLink
            // 
            this.btnOpenLink.Location = new System.Drawing.Point(131, 50);
            this.btnOpenLink.Name = "btnOpenLink";
            this.btnOpenLink.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLink.TabIndex = 5;
            this.btnOpenLink.Text = "Open a link";
            this.btnOpenLink.UseVisualStyleBackColor = true;
            // 
            // SFPlayer
            // 
            this.SFPlayer.Enabled = true;
            this.SFPlayer.Location = new System.Drawing.Point(6, 48);
            this.SFPlayer.Name = "SFPlayer";
            this.SFPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SFPlayer.OcxState")));
            this.SFPlayer.Size = new System.Drawing.Size(368, 324);
            this.SFPlayer.TabIndex = 6;
            // 
            // btnLoadVideo
            // 
            this.btnLoadVideo.Location = new System.Drawing.Point(276, 22);
            this.btnLoadVideo.Name = "btnLoadVideo";
            this.btnLoadVideo.Size = new System.Drawing.Size(98, 23);
            this.btnLoadVideo.TabIndex = 6;
            this.btnLoadVideo.Text = "Play &New Video";
            this.btnLoadVideo.UseVisualStyleBackColor = true;
            this.btnLoadVideo.Click += new System.EventHandler(this.btnLoadVideo_Click);
            // 
            // txtVideoRef
            // 
            this.txtVideoRef.Location = new System.Drawing.Point(6, 22);
            this.txtVideoRef.Name = "txtVideoRef";
            this.txtVideoRef.Size = new System.Drawing.Size(257, 20);
            this.txtVideoRef.TabIndex = 6;
            this.txtVideoRef.Text = "*paste a youtube link here*";
            // 
            // grpThemes
            // 
            this.grpThemes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpThemes.Controls.Add(this.grpNavigate);
            this.grpThemes.Controls.Add(this.txtVideoRef);
            this.grpThemes.Controls.Add(this.btnLoadVideo);
            this.grpThemes.Controls.Add(this.SFPlayer);
            this.grpThemes.Location = new System.Drawing.Point(333, 12);
            this.grpThemes.Name = "grpThemes";
            this.grpThemes.Size = new System.Drawing.Size(939, 380);
            this.grpThemes.TabIndex = 4;
            this.grpThemes.TabStop = false;
            this.grpThemes.Text = "Theme Music - Via Youtube";
            // 
            // grpNavigate
            // 
            this.grpNavigate.Controls.Add(this.btnNew);
            this.grpNavigate.Controls.Add(this.btnAddLink);
            this.grpNavigate.Controls.Add(this.txtLinkURL);
            this.grpNavigate.Controls.Add(this.btnDelete);
            this.grpNavigate.Controls.Add(this.txtLinkName);
            this.grpNavigate.Controls.Add(this.lblLinkName);
            this.grpNavigate.Controls.Add(this.btnPrevious);
            this.grpNavigate.Controls.Add(this.lblLinkURL);
            this.grpNavigate.Controls.Add(this.btnNext);
            this.grpNavigate.Controls.Add(this.btnLast);
            this.grpNavigate.Controls.Add(this.btnFirst);
            this.grpNavigate.Location = new System.Drawing.Point(390, 19);
            this.grpNavigate.Name = "grpNavigate";
            this.grpNavigate.Size = new System.Drawing.Size(346, 138);
            this.grpNavigate.TabIndex = 17;
            this.grpNavigate.TabStop = false;
            this.grpNavigate.Text = "Currently Playing";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 67);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(47, 23);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnAddLink
            // 
            this.btnAddLink.Location = new System.Drawing.Point(258, 98);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(75, 23);
            this.btnAddLink.TabIndex = 16;
            this.btnAddLink.Text = "Add";
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // txtLinkURL
            // 
            this.txtLinkURL.Location = new System.Drawing.Point(116, 43);
            this.txtLinkURL.Name = "txtLinkURL";
            this.txtLinkURL.Size = new System.Drawing.Size(217, 20);
            this.txtLinkURL.TabIndex = 7;
            this.txtLinkURL.Text = "*paste youtube link here";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(133, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLinkName
            // 
            this.txtLinkName.Location = new System.Drawing.Point(116, 17);
            this.txtLinkName.Name = "txtLinkName";
            this.txtLinkName.Size = new System.Drawing.Size(217, 20);
            this.txtLinkName.TabIndex = 8;
            // 
            // lblLinkName
            // 
            this.lblLinkName.AutoSize = true;
            this.lblLinkName.Location = new System.Drawing.Point(12, 20);
            this.lblLinkName.Name = "lblLinkName";
            this.lblLinkName.Size = new System.Drawing.Size(38, 13);
            this.lblLinkName.TabIndex = 9;
            this.lblLinkName.Text = "Name:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(170, 67);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblLinkURL
            // 
            this.lblLinkURL.AutoSize = true;
            this.lblLinkURL.Location = new System.Drawing.Point(12, 46);
            this.lblLinkURL.Name = "lblLinkURL";
            this.lblLinkURL.Size = new System.Drawing.Size(98, 13);
            this.lblLinkURL.TabIndex = 10;
            this.lblLinkURL.Text = "Youtube Link URL:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(241, 67);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(285, 67);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(48, 23);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(116, 67);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(48, 23);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // tblCustomLinksBindingSource
            // 
            this.tblCustomLinksBindingSource.DataMember = "tblCustomLinks";
            this.tblCustomLinksBindingSource.DataSource = this.dNDSoundboardDataSet;
            // 
            // dNDSoundboardDataSet
            // 
            this.dNDSoundboardDataSet.DataSetName = "DNDSoundboardDataSet";
            this.dNDSoundboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpUtilitySounds
            // 
            this.grpUtilitySounds.Controls.Add(this.btnOpenLink);
            this.grpUtilitySounds.Controls.Add(this.btnDing);
            this.grpUtilitySounds.Controls.Add(this.btnFireball);
            this.grpUtilitySounds.Location = new System.Drawing.Point(12, 398);
            this.grpUtilitySounds.Name = "grpUtilitySounds";
            this.grpUtilitySounds.Size = new System.Drawing.Size(303, 251);
            this.grpUtilitySounds.TabIndex = 6;
            this.grpUtilitySounds.TabStop = false;
            this.grpUtilitySounds.Text = "Utility Sounds";
            // 
            // btnTogglePlay
            // 
            this.btnTogglePlay.Location = new System.Drawing.Point(293, 21);
            this.btnTogglePlay.Name = "btnTogglePlay";
            this.btnTogglePlay.Size = new System.Drawing.Size(75, 23);
            this.btnTogglePlay.TabIndex = 7;
            this.btnTogglePlay.Text = "&Play/Pause";
            this.btnTogglePlay.UseVisualStyleBackColor = true;
            this.btnTogglePlay.Click += new System.EventHandler(this.btnTogglePlay_Click);
            // 
            // grpBuiltInThemes
            // 
            this.grpBuiltInThemes.Controls.Add(this.btnTristramTheme);
            this.grpBuiltInThemes.Controls.Add(this.trkThemes);
            this.grpBuiltInThemes.Controls.Add(this.btnHeroTheme);
            this.grpBuiltInThemes.Controls.Add(this.btnMainBattleTheme);
            this.grpBuiltInThemes.Controls.Add(this.btnBossBattleTheme);
            this.grpBuiltInThemes.Controls.Add(this.btnDungeonTheme);
            this.grpBuiltInThemes.Controls.Add(this.btnTownTheme);
            this.grpBuiltInThemes.Controls.Add(this.btnMainVillainTheme);
            this.grpBuiltInThemes.Controls.Add(this.lblCurrentPlay);
            this.grpBuiltInThemes.Controls.Add(this.txtCurrentlyPlaying);
            this.grpBuiltInThemes.Controls.Add(this.btnBattleMusic);
            this.grpBuiltInThemes.Controls.Add(this.btnTogglePlay);
            this.grpBuiltInThemes.Location = new System.Drawing.Point(333, 398);
            this.grpBuiltInThemes.Name = "grpBuiltInThemes";
            this.grpBuiltInThemes.Size = new System.Drawing.Size(374, 251);
            this.grpBuiltInThemes.TabIndex = 8;
            this.grpBuiltInThemes.TabStop = false;
            this.grpBuiltInThemes.Text = "Built-in Themes";
            // 
            // btnTristramTheme
            // 
            this.btnTristramTheme.Location = new System.Drawing.Point(159, 107);
            this.btnTristramTheme.Name = "btnTristramTheme";
            this.btnTristramTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTristramTheme.Size = new System.Drawing.Size(128, 23);
            this.btnTristramTheme.TabIndex = 32;
            this.btnTristramTheme.Text = "&Tristram Theme";
            this.btnTristramTheme.UseVisualStyleBackColor = true;
            this.btnTristramTheme.Click += new System.EventHandler(this.btnTristramTheme_Click);
            // 
            // trkThemes
            // 
            this.trkThemes.Location = new System.Drawing.Point(323, 49);
            this.trkThemes.Maximum = 100;
            this.trkThemes.Name = "trkThemes";
            this.trkThemes.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThemes.Size = new System.Drawing.Size(45, 104);
            this.trkThemes.TabIndex = 31;
            this.trkThemes.Scroll += new System.EventHandler(this.trkThemes_Scroll);
            // 
            // btnHeroTheme
            // 
            this.btnHeroTheme.Location = new System.Drawing.Point(6, 136);
            this.btnHeroTheme.Name = "btnHeroTheme";
            this.btnHeroTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHeroTheme.Size = new System.Drawing.Size(128, 23);
            this.btnHeroTheme.TabIndex = 30;
            this.btnHeroTheme.Text = "&Hero Theme";
            this.btnHeroTheme.UseVisualStyleBackColor = true;
            this.btnHeroTheme.Click += new System.EventHandler(this.btnHeroTheme_Click);
            // 
            // btnMainBattleTheme
            // 
            this.btnMainBattleTheme.Location = new System.Drawing.Point(6, 78);
            this.btnMainBattleTheme.Name = "btnMainBattleTheme";
            this.btnMainBattleTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMainBattleTheme.Size = new System.Drawing.Size(128, 23);
            this.btnMainBattleTheme.TabIndex = 28;
            this.btnMainBattleTheme.Text = "Main &Battle Theme";
            this.btnMainBattleTheme.UseVisualStyleBackColor = true;
            this.btnMainBattleTheme.Click += new System.EventHandler(this.btnMainBattleTheme_Click);
            // 
            // btnBossBattleTheme
            // 
            this.btnBossBattleTheme.Location = new System.Drawing.Point(6, 107);
            this.btnBossBattleTheme.Name = "btnBossBattleTheme";
            this.btnBossBattleTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBossBattleTheme.Size = new System.Drawing.Size(128, 23);
            this.btnBossBattleTheme.TabIndex = 27;
            this.btnBossBattleTheme.Text = "B&oss Battle Theme";
            this.btnBossBattleTheme.UseVisualStyleBackColor = true;
            this.btnBossBattleTheme.Click += new System.EventHandler(this.btnBossBattleTheme_Click);
            // 
            // btnDungeonTheme
            // 
            this.btnDungeonTheme.Location = new System.Drawing.Point(159, 78);
            this.btnDungeonTheme.Name = "btnDungeonTheme";
            this.btnDungeonTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDungeonTheme.Size = new System.Drawing.Size(128, 23);
            this.btnDungeonTheme.TabIndex = 26;
            this.btnDungeonTheme.Text = "&Dungeon Theme";
            this.btnDungeonTheme.UseVisualStyleBackColor = true;
            this.btnDungeonTheme.Click += new System.EventHandler(this.btnDungeonTheme_Click);
            // 
            // btnTownTheme
            // 
            this.btnTownTheme.Location = new System.Drawing.Point(159, 50);
            this.btnTownTheme.Name = "btnTownTheme";
            this.btnTownTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTownTheme.Size = new System.Drawing.Size(128, 23);
            this.btnTownTheme.TabIndex = 25;
            this.btnTownTheme.Text = "&Town Theme";
            this.btnTownTheme.UseVisualStyleBackColor = true;
            this.btnTownTheme.Click += new System.EventHandler(this.btnTownTheme_Click);
            // 
            // btnMainVillainTheme
            // 
            this.btnMainVillainTheme.Location = new System.Drawing.Point(6, 49);
            this.btnMainVillainTheme.Name = "btnMainVillainTheme";
            this.btnMainVillainTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMainVillainTheme.Size = new System.Drawing.Size(128, 23);
            this.btnMainVillainTheme.TabIndex = 24;
            this.btnMainVillainTheme.Text = "&Main Villain Theme";
            this.btnMainVillainTheme.UseVisualStyleBackColor = true;
            this.btnMainVillainTheme.Click += new System.EventHandler(this.btnMainVillainTheme_Click);
            // 
            // lblCurrentPlay
            // 
            this.lblCurrentPlay.AutoSize = true;
            this.lblCurrentPlay.Location = new System.Drawing.Point(6, 26);
            this.lblCurrentPlay.Name = "lblCurrentPlay";
            this.lblCurrentPlay.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentPlay.TabIndex = 23;
            this.lblCurrentPlay.Text = "Currently Playing:";
            // 
            // txtCurrentlyPlaying
            // 
            this.txtCurrentlyPlaying.Location = new System.Drawing.Point(100, 23);
            this.txtCurrentlyPlaying.Name = "txtCurrentlyPlaying";
            this.txtCurrentlyPlaying.Size = new System.Drawing.Size(187, 20);
            this.txtCurrentlyPlaying.TabIndex = 18;
            // 
            // tblCustomLinksTableAdapter
            // 
            this.tblCustomLinksTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.grpBuiltInThemes);
            this.Controls.Add(this.grpUtilitySounds);
            this.Controls.Add(this.grpThemes);
            this.Controls.Add(this.grbWeapons);
            this.Name = "frmMain";
            this.Text = "DND Soundboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbWeapons.ResumeLayout(false);
            this.grbWeapons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFPlayer)).EndInit();
            this.grpThemes.ResumeLayout(false);
            this.grpThemes.PerformLayout();
            this.grpNavigate.ResumeLayout(false);
            this.grpNavigate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomLinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNDSoundboardDataSet)).EndInit();
            this.grpUtilitySounds.ResumeLayout(false);
            this.grpBuiltInThemes.ResumeLayout(false);
            this.grpBuiltInThemes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkThemes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDing;
        private System.Windows.Forms.Button btnFireball;
        private System.Windows.Forms.GroupBox grbWeapons;
        private System.Windows.Forms.Button btnSwordSlash;
        private System.Windows.Forms.Button btnSwordSlashLimb;
        private System.Windows.Forms.Button btnSwordsClashing;
        private System.Windows.Forms.Button btnBowRelease;
        private System.Windows.Forms.Button btnBowFlames;
        private System.Windows.Forms.Button btnThrowingKnife;
        private System.Windows.Forms.Label lblKnifes;
        private System.Windows.Forms.Label lblBows;
        private System.Windows.Forms.Label lblSwords;
        private System.Windows.Forms.Button btnKnifeSharpen;
        private System.Windows.Forms.Button btnKnifeStab;
        private System.Windows.Forms.Button btnSwordsBout;
        private System.Windows.Forms.Button btnClubHit;
        private System.Windows.Forms.Button btnStaffHit;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Button btnSwordMiss;
        private System.Windows.Forms.Button btnSwordFlaunt;
        private System.Windows.Forms.Button btnMiss;
        private System.Windows.Forms.Button btnSwordDraw;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Button btnDeath;
        private System.Windows.Forms.Label lblDeath;
        private System.Windows.Forms.Button btnBattleMusic;
        private System.Windows.Forms.Button btnOpenLink;
        private AxShockwaveFlashObjects.AxShockwaveFlash SFPlayer;
        private System.Windows.Forms.Button btnLoadVideo;
        private System.Windows.Forms.TextBox txtVideoRef;
        private System.Windows.Forms.GroupBox grpThemes;
        private System.Windows.Forms.GroupBox grpUtilitySounds;
        private System.Windows.Forms.Button btnTogglePlay;
        private System.Windows.Forms.GroupBox grpBuiltInThemes;
        private System.Windows.Forms.Label lblCurrentPlay;
        private System.Windows.Forms.TextBox txtCurrentlyPlaying;
        private System.Windows.Forms.Button btnMainVillainTheme;
        private System.Windows.Forms.Button btnHeroTheme;
        private System.Windows.Forms.Button btnMainBattleTheme;
        private System.Windows.Forms.Button btnBossBattleTheme;
        private System.Windows.Forms.Button btnDungeonTheme;
        private System.Windows.Forms.Button btnTownTheme;
        private System.Windows.Forms.TrackBar trkThemes;
        private System.Windows.Forms.Button btnTristramTheme;
        private DNDSoundboardDataSet dNDSoundboardDataSet;
        private System.Windows.Forms.BindingSource tblCustomLinksBindingSource;
        private DNDSoundboardDataSetTableAdapters.tblCustomLinksTableAdapter tblCustomLinksTableAdapter;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblLinkURL;
        private System.Windows.Forms.Label lblLinkName;
        private System.Windows.Forms.TextBox txtLinkName;
        private System.Windows.Forms.TextBox txtLinkURL;
        private System.Windows.Forms.GroupBox grpNavigate;
        private System.Windows.Forms.Button btnNew;
    }
}

