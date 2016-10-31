using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using DNDSoundboard;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Runtime.Serialization;

namespace DNDSoundboard
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region vars
        private string path = @".\Sounds\Death.wav";
        //private string MusicPath = "";
        private string Full;
        private string FormatReferenceVideo;
        private string VideoID;
        System.Windows.Media.MediaPlayer Player = Utilities.GetMediaPlayer();
        bool b = true;
        int indexTotal = -1;
        int index = 0;
        List<YoutubeLink> YoutubeLinkList = new List<YoutubeLink>();
        #endregion vars

        #region PlaySoundEffect
        private void PlaySound()
        {
            SoundPlayer SoundEffect = Utilities.SoundPlayer(path);
            SoundEffect.Play();
        }
        #endregion PlaySoundEffect
        #region init
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dNDSoundboardDataSet.tblCustomLinks' table. You can move, or remove it, as needed.
           LoadYoutubeLinks();
           DisplayYoutubeLink();
           PlayYoutubeLink();
        }

        private void btnDing_Click(object sender, EventArgs e)
        {
            path = @"C:\WINDOWS\Media\ding.wav";
            PlaySound();
        }

        private void btnFireball_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\SmallFireball.wav";
            PlaySound();
        }
        #endregion init

        #region Weapons
        private void btnSwordSlash_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\SwordSlash.wav";
            PlaySound();
        }

        private void btnSwordSlashLimb_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\SwordSlashLimb.wav";
            PlaySound();
        }

        private void btnSwordsClashing_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\SwordsClashing.wav";
            PlaySound();
        }
        
        private void btnSwordsBout_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\SwordsBout.wav";
            PlaySound();
        }

        private void btnSwordDraw_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\SwordDraw.wav";
            PlaySound();
        }

        private void btnSwordFlaunt_Click_1(object sender, EventArgs e)
        {
            path = @".\Sounds\SwordFlaunt.wav";
            PlaySound();
        }

        private void btnSwordMiss_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\SwordMiss.wav";
            PlaySound();
        }
        #region Bows

        private void btnBowRelease_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\BowRelease.wav";
            PlaySound();
        }

        private void btnBowFlames_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\BowFlame.wav";
            PlaySound();
        }

        #endregion Bows

        #region Knives

        private void btnThrowingKnife_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\KnifeThrow.wav";
            PlaySound();
        }

        private void btnKnifeSharpen_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\KnifeSharpening.wav";
            PlaySound();
        }

        private void btnKnifeStab_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\KnifeStab.wav";
            PlaySound();
        }


        #endregion Knives

        #region Clubs
        private void btnStaffHit_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\StaffHit.wav";
            PlaySound();
        }

        private void btnClubHit_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\ClubHit.wav";
            PlaySound();
        }

        private void btnMiss_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\Miss.wav";
            PlaySound();
        }


        #endregion Clubs

        #region Defense

        private void btnBlock_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\MetalShieldBlock.wav";
            PlaySound();
        }

        private void btnDeath_Click(object sender, EventArgs e)
        {
            path = @".\Sounds\Death.wav";
            PlaySound();
        }

        #endregion Defense

        #endregion Weapons


        #region Music
        #region CoreMusicPlayer
        #region events
        private void btnTogglePlay_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                Player.MediaEnded += new EventHandler(Media_Ended);
                Player.Play();
                b = false;
            }
            else
            {
                StopMusic();
                b = true;
            }
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            Player.Position = TimeSpan.Zero;
            Player.Play();
        }

        private void trkThemes_Scroll(object sender, EventArgs e)
        {
            Player.Volume = (double)trkThemes.Value / 100;
        }

        private void btnBattleMusic_Click(object sender, EventArgs e)
        {
            txtCurrentlyPlaying.Text = "Celtic Battle Theme";
            Full = Path.GetFullPath("C:BattleMusicWolfBlood.mp3");
            LoadThemeMusic();
        }

        private void btnMainVillainTheme_Click(object sender, EventArgs e)
        {
            Full = Path.GetFullPath("C:MainVillainTheme.mp3");
            txtCurrentlyPlaying.Text = "Main Villain Theme";
            LoadThemeMusic();
        }


        private void btnMainBattleTheme_Click(object sender, EventArgs e)
        {
            txtCurrentlyPlaying.Text = "Main Battle Theme";
            Full = Path.GetFullPath("C:MainBattleTheme.mp3");
            LoadThemeMusic();
        }

        private void btnBossBattleTheme_Click(object sender, EventArgs e)
        {
            txtCurrentlyPlaying.Text = "Boss Battle Theme";
            Full = Path.GetFullPath("C:BossBattleTheme.mp3");
            LoadThemeMusic();
        }

        private void btnHeroTheme_Click(object sender, EventArgs e)
        {
            txtCurrentlyPlaying.Text = "Hero Theme";
            Full = Path.GetFullPath("C:HeroTheme.mp3");
            LoadThemeMusic();
        }

        private void btnTownTheme_Click(object sender, EventArgs e)
        {
            txtCurrentlyPlaying.Text = "Town Theme";
            Full = Path.GetFullPath("C:TownTheme.mp3");
            LoadThemeMusic();
        }

        private void btnDungeonTheme_Click(object sender, EventArgs e)
        {
            txtCurrentlyPlaying.Text = "Dungeon Theme";
            Full = Path.GetFullPath("C:DungeonTheme.mp3");
            LoadThemeMusic();
        }

        private void btnTristramTheme_Click(object sender, EventArgs e)
        {
            txtCurrentlyPlaying.Text = "Tristram Theme";
            Full = Path.GetFullPath("C:TristramTheme.mp3");
            LoadThemeMusic();
        }
        #endregion events
        private void LoadThemeMusic()
        {
            b = true;
                Player.Open(GetURI());
        }

        private System.Uri GetURI()
        {
            return new System.Uri(Full);
        }

        private void StopMusic()
        {
            Player.Pause();
        }
    
        #endregion CoreMusicPlayer
        private void PlayTheMovie()
        {
            SFPlayer.Loop = true;
            SFPlayer.Movie = FormatReferenceVideo;
        }

        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            try
            {
                GetVideoID(txtLinkURL.Text);
                FormatReferenceVideo = txtVideoRef.Text.Replace("watch?", "").Replace("=", "/")+"?autoplay=1&loop=1&playlist="+VideoID;//also need to return play list id which is 11 chars
                PlayTheMovie();
            }
            catch (Exception E)
            {
                MessageBox.Show("ERROR:" + E);
            }
        }

        private void GetVideoID(string Source)
        {
            VideoID = Source;
            VideoID = VideoID.Substring(32);
        }

        private void PlayYoutubeLink()
        {
            try
            {
                GetVideoID(txtLinkURL.Text);
                FormatReferenceVideo = txtLinkURL.Text.Replace("watch?", "").Replace("=", "/") + "?autoplay=1&loop=1&playlist=" + VideoID;//also need to return play list id which is 11 chars
                PlayTheMovie();
            }
            catch (Exception E)
            {
                MessageBox.Show("ERROR:" + E);
            }
        }


        #endregion Music

        #region Data
        private void btnAddLink_Click(object sender, EventArgs e)
        {
            SaveMusicDetails();
        }

        public void AddLinkToList()
        {
            YoutubeLinkList.Add(new YoutubeLink(txtLinkName.Text, txtLinkURL.Text));
        }

        private void SaveMusicDetails()
        {
            AddLinkToList();
            IFormatter Formatter = new BinaryFormatter();
            Stream Stream = new FileStream("YoutubeLinks.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            Formatter.Serialize(Stream, YoutubeLinkList);
            Stream.Close();
            YoutubeLinkList.Clear();
            indexTotal = -1;
            LoadYoutubeLinks();
            FirstLink();
        }

        private void btnOpenLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com");
        }

        /*CODE for editing a link then saving it
        private void EditLinkSave()
        {
            YoutubeLinkList[index].LinkName = txtLinkName.Text;
            YoutubeLinkList[index].LinkURL = txtLinkURL.Text;
            IFormatter Formatter = new BinaryFormatter();
            Stream Stream = new FileStream("YoutubeLinks.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            Formatter.Serialize(Stream, YoutubeLinkList);
            Stream.Close();
        }
        */

        private void LoadYoutubeLinks()
        {
            try
            {
                IFormatter Formatter = new BinaryFormatter();
                Stream Stream = new FileStream("YoutubeLinks.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

                //Deserializes the BinaryFile as a List of Youtube Links
                var YoutubeLinks = (List<YoutubeLink>)Formatter.Deserialize(Stream);
                foreach (YoutubeLink youtubelink in YoutubeLinks)//Foreach YoutubeLink that was deserealized it adds it to the list
                {
                    YoutubeLinkList.Add(youtubelink);
                    indexTotal++;
                }

                Stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e);
            }
        }

        private void DisplayYoutubeLink()
        {
            txtLinkName.Text = YoutubeLinkList[index].LinkName;
            txtLinkURL.Text = YoutubeLinkList[index].LinkURL;
        }

        #endregion data

        #region nav
        private void btnNext_Click(object sender, EventArgs e)
        {
            NextLink();
        }

        private void NextLink()
        {
            if (index < indexTotal)
            {
                index++;
                DisplayYoutubeLink();
                PlayYoutubeLink();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousLink();
        }

        private void PreviousLink()
        {
            if (index != 0)
            {
                index--;
                DisplayYoutubeLink();
                PlayYoutubeLink();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            FirstLink();
        }

        private void FirstLink()
        {
            index = 0;
            DisplayYoutubeLink();
            PlayYoutubeLink();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            LastLink();
        }

        private void LastLink()
        {
            index = indexTotal;
            DisplayYoutubeLink();
            PlayYoutubeLink();
        }

        #endregion nav

        private void btnDelete_Click(object sender, EventArgs e)
        {
            YoutubeLinkList.RemoveAll((YoutubeLink) => YoutubeLink.LinkName == txtLinkName.Text);
            IFormatter Formatter = new BinaryFormatter();
            Stream Stream = new FileStream("YoutubeLinks.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            Formatter.Serialize(Stream, YoutubeLinkList);
            Stream.Close();
            YoutubeLinkList.Clear();
            indexTotal = -1;
            LoadYoutubeLinks();
            FirstLink();
        }
    }
}

