using NAudio.Wave;

namespace Melody
{
    public partial class MainForm : Form
    {
        private List<string> playlist = new List<string>();
        private int currentTrackIndex = 0;
        private WaveOutEvent player = new WaveOutEvent();
        private AudioFileReader? audioFile;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddToPlaylistButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 files|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    playlist.Add(fileName);
                    PlaylistListBox.Items.Add(Path.GetFileName(fileName));
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0)
                return;

            if (audioFile == null)
            {
                audioFile = new AudioFileReader(playlist[currentTrackIndex]);
                player.Init(audioFile);
            }
            player.Play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentTrackIndex < playlist.Count - 1)
            {
                currentTrackIndex++;
                PlayTrack();
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentTrackIndex > 0)
            {
                currentTrackIndex--;
                PlayTrack();
            }
        }

        private void PlayTrack()
        {
            if (audioFile != null)
            {
                player.Stop();
                player.Dispose();
                audioFile.Dispose();
            }
            audioFile = new AudioFileReader(playlist[currentTrackIndex]);
            player.Init(audioFile);
            player.Play();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About showAbout = new About();
            showAbout.Show();
        }
    }
}
