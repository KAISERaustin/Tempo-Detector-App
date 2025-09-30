using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TempoDetector
{
    public partial class MainWindow : Window
    {
        private readonly List<DateTime> tapTimes = new();
        private const int MaxTaps = 8;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TapButton_Click(object sender, RoutedEventArgs e)
        {
            var now = DateTime.Now;
            tapTimes.Add(now);

            if (tapTimes.Count > 1)
            {
                // Remove oldest tap if we exceed the maximum number of taps
                if (tapTimes.Count > MaxTaps)
                    tapTimes.RemoveAt(0);

                // Update the display with the current tap count
                double totalMs = 0;
                for (int i = 1; i < tapTimes.Count; i++)
                {
                    // Calculate the total milliseconds between taps
                    totalMs += (tapTimes[i] - tapTimes[i - 1]).TotalMilliseconds;
                }
                
                // Calculate average interval and BPM
                double avgInterval = totalMs / (tapTimes.Count - 1);
                double bpm = 60000.0 / avgInterval;
                int tempo = (int)bpm;
                tempoText.Text = $"Tempo: {tempo} BPM";
            }
        }
    }
}