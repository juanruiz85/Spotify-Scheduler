using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using System.Deployment.Application;

//
/// <summary>
/// Api mabe by Johnny Crazy
/// a lot of code of this app was taken from the creator's page
/// https://github.com/JohnnyCrazy/SpotifyAPI-NET
/// </summary>

namespace Spotify_Scheduler
{
    public partial class Form1 : Form
    {
        public SpotifyLocalAPI _spotify;
        public Track _currentTrack;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //adding the version number at form's name
            if (System.Diagnostics.Debugger.IsAttached == false)
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    this.Text = string.Format(this.Text + " - Version: {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
                }
            }
            else
            {
                this.Text = this.Text + " - Version: Debug Mode";
            }

            _spotify = new SpotifyLocalAPI(new SpotifyLocalAPIConfig
            {
                Port = 4371,
                HostUrl = "http://127.0.0.1"
            });

            _spotify = new SpotifyLocalAPI();
            _spotify.OnPlayStateChange += _spotify_OnPlayStateChange;
            _spotify.OnTrackChange += _spotify_OnTrackChange;
            _spotify.OnTrackTimeChange += _spotify_OnTrackTimeChange;
            _spotify.SynchronizingObject = this;
        }

        private void Form1_Unload(object sender, EventArgs e)
        {
            //Force to kill all processes
            Environment.Exit(0);
            Environment.FailFast("");
        }

        public void Connect()
        {
            if (!SpotifyLocalAPI.IsSpotifyRunning())
            {
                MessageBox.Show(@"Spotify isn't running!");
                return;
            }
            if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
            {
                MessageBox.Show(@"SpotifyWebHelper isn't running!");
                return;
            }

            bool successful = _spotify.Connect();
            if (successful)
            {
                connectBtn.Text = @"Connection to Spotify successful";
                connectBtn.Enabled = false;
                UpdateInfos();
                _spotify.ListenForEvents = true;
            }
            else
            {
                //dont like the question then now is disabled
                DialogResult res = MessageBox.Show(@"Couldn't connect to the spotify client. Retry?", @"Spotify", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                listBox1.Items.Add("Error al conectar a spotify " + DateTime.Now.ToString("HH:mm"));
                Connect();
            }
        }

        public void UpdateInfos()
        {
            StatusResponse status = _spotify.GetStatus();
            if (status == null)
                return;

            //Basic Spotify Infos
            UpdatePlayingStatus(status.Playing);
            clientVersionLabel.Text = status.ClientVersion;
            versionLabel.Text = status.Version.ToString();

            if (status.Track != null) //Update track infos
                UpdateTrack(status.Track);
        }

        public async void UpdateTrack(Track track)
        {
            _currentTrack = track;
            timeProgressBar.Maximum = track.Length;

            if (track.IsAd())
                return; //Don't process further, maybe null values

            titleLinkLabel.Text = track.TrackResource.Name;
            titleLinkLabel.Tag = track.TrackResource.Uri;

            artistLinkLabel.Text = track.ArtistResource.Name;
            artistLinkLabel.Tag = track.ArtistResource.Uri;

            albumLinkLabel.Text = track.AlbumResource.Name;
            albumLinkLabel.Tag = track.AlbumResource.Uri;

            SpotifyUri uri = track.TrackResource.ParseUri();
        }

        public void UpdatePlayingStatus(bool playing)
        {
            isPlayingLabel.Text = playing.ToString();
        }

        private void _spotify_OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnTrackTimeChange(sender, e)));
                return;
            }
            timeLabel.Text = $@"{FormatTime(e.TrackTime)}/{FormatTime(_currentTrack.Length)}";
            if (e.TrackTime < _currentTrack.Length)
                timeProgressBar.Value = (int)e.TrackTime;
        }

        private void _spotify_OnTrackChange(object sender, TrackChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnTrackChange(sender, e)));
                return;
            }
            UpdateTrack(e.NewTrack);
        }

        private void _spotify_OnPlayStateChange(object sender, PlayStateEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnPlayStateChange(sender, e)));
                return;
            }
            UpdatePlayingStatus(e.Playing);
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private async void playBtn_Click(object sender, EventArgs e)
        {
            await _spotify.Play();
        }

        private async void pauseBtn_Click(object sender, EventArgs e)
        {
            await _spotify.Pause();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            _spotify.Previous();
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            _spotify.Skip();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Temporizador();
        }

        //time format
        private static String FormatTime(double sec)
        {
            TimeSpan span = TimeSpan.FromSeconds(sec);
            String secs = span.Seconds.ToString(), mins = span.Minutes.ToString();
            if (secs.Length < 2)
                secs = "0" + secs;
            return mins + ":" + secs;
        }

        //function for do play or pause and verifying the connection before
        //this code now is a mess because always give me error or stop working without reason
        private void Procesos(string Proceso, String Hora)
        {
            if (Proceso == "play")
            {
                bool successful = _spotify.Connect();
                if (successful)
                {
                    //call the click button action from playbtn
                    playBtn_Click(new object(), new EventArgs());
                    listBox1.Items.Add("Play - Conectado a " + Hora);
                }
                else
                {
                    Connect();
                    playBtn_Click(new object(), new EventArgs());
                    listBox1.Items.Add("Play - ReConectado a " + Hora);
                }
            }
            if (Proceso == "pause")
            {
                bool successful = _spotify.Connect();
                if (successful)
                {
                    //call the click button action from pausebtn
                    pauseBtn_Click(new object(), new EventArgs());
                    listBox1.Items.Add("Pausa - Conectado a " + Hora);
                }
                else
                {
                    Connect();
                    //call the click button action from pausebtn
                    pauseBtn_Click(new object(), new EventArgs());
                    listBox1.Items.Add("Pausa - ReConectado a " + Hora);
                }
            }
        }

        //Process for play and stop the music
        private void Temporizador()
        {
            //Pauses
            if (DateTime.Now.ToString("HH:mm") == "14:55")
            {
                Procesos("pause", "14:55");
            }
            if (DateTime.Now.ToString("HH:mm") == "16:00")
            {
                Procesos("pause", "16:00");
            }
            if (DateTime.Now.ToString("HH:mm") == "05:00")
            {
                Procesos("pause", "05:00");
            }
            if (DateTime.Now.ToString("HH:mm") == "21:50")
            {
                Procesos("pause", "21:50");
            }

            //Plays
            if (DateTime.Now.ToString("HH:mm") == "10:40")
            {
                Procesos("play", "10:40");
            }
            if (DateTime.Now.ToString("HH:mm") == "15:10")
            {
                Procesos("play", "15:10");
            }
            if (DateTime.Now.ToString("HH:mm") == "18:00")
            {
                Procesos("play", "18:00");
            }
            if (DateTime.Now.ToString("HH:mm") == "22:10")
            {
                Procesos("play", "22:10");
            }
            label9.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Force to kill all processes
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Environment.FailFast("");
        }

        //Disable the close button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
