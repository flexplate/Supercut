using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Supercut
{
    public partial class MainForm : Form
    {
        double _clipDuration;
        int _nowPlayingIndex;
        Random _rng = new Random();
        string[] _supportedVideoExtensions = { ".webm", ".mp4", ".mkv", ".avi", ".wmv" };
        public MainForm()
        {
            InitializeComponent();
            VideoPlayer.currentPlaylist = VideoPlayer.newPlaylist("playlist", "");
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var FilePaths = dlg.FileNames.Where(f => _supportedVideoExtensions.Contains(Path.GetExtension(f)));
                    foreach (var file in FilePaths)
                    {
                        PlayList.Items.Add(file);
                        VideoPlayer.currentPlaylist.appendItem(VideoPlayer.newMedia(file));
                    }
                }
            }
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var FilePaths = Directory.GetFiles(dlg.SelectedPath, "*.*").Where(f => _supportedVideoExtensions.Contains(Path.GetExtension(f)));
                    foreach (var file in FilePaths)
                    {
                        PlayList.Items.Add(file);
                        VideoPlayer.currentPlaylist.appendItem(VideoPlayer.newMedia(file));
                    }
                }
            }
        }

        private void AutoClip_CheckedChanged(object sender, EventArgs e)
        {
            Duration.Enabled = AutoClip.Checked;
        }
        private void Duration_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Duration.Text, out _clipDuration))
            {
                timer1.Interval = (int)_clipDuration * 1000;
            }
            else
            {
                MessageBox.Show("Not a valid duration in seconds");
            }
        }

        private void Play(int index)
        {
            if (index >= PlayList.Items.Count) { index = 0; }
            _nowPlayingIndex = index;
            string Path = PlayList.Items[_nowPlayingIndex].ToString();
            Play(Path);
        }

        private void Play(string path)
        {
            VideoPlayer.URL = path;
        }

        private void PlayList_DoubleClick(object sender, EventArgs e)
        {
            Play(PlayList.SelectedIndex);
        }

        private void RemoveFile_Click(object sender, EventArgs e)
        {
            if (PlayList.SelectedItem != null)
            {
                int idx = PlayList.SelectedIndex;
                VideoPlayer.currentPlaylist.removeItem(VideoPlayer.currentPlaylist.Item[idx]);
                PlayList.Items.RemoveAt(idx);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AutoClip.Checked)
            {
                timer1.Stop();
                if (RandomOrder.Checked) { Play(_rng.Next(PlayList.Items.Count - 1)); }
                Play(_nowPlayingIndex + 1);
            }
        }

        private void VideoPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:     // Undefined
                    break;
                case 1:     // Stopped by controls
                    timer1.Stop();
                    break;
                case 2:     // paused
                    timer1.Stop();
                    break;
                case 3:     // playing
                    if (RandomStart.Checked)
                    {
                        double MediaDuration = VideoPlayer.currentMedia.duration;
                        double TargetPosition = _rng.NextDouble() * (MediaDuration - _clipDuration);
                        VideoPlayer.Ctlcontrols.currentPosition = TargetPosition;
                    }
                    timer1.Start();
                    break;
                case 4:     // Scanning forward
                    break;
                case 5:     // Rewinding
                    break;
                case 6:     // Buffering
                    break;
                case 7:     // Waiting
                    break;
                case 8:     // Playback has ended
                    if (RandomOrder.Checked) { Play(_rng.Next(PlayList.Items.Count - 1)); }
                    Play(_nowPlayingIndex + 1);
                    break;
                case 9:     // Loading new item
                    break;
                case 10:    // Ready to play
                    break;
                case 11:    // Reconnecting to stream
                    break;
                default:
                    break;
            }
        }
    }
}
