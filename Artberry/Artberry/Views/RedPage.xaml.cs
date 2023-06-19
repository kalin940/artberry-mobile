using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Artberry.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RedPage : ContentPage
    {
        public RedPage()
        {
            InitializeComponent();
        }

        private void PlayPauseButton_Clicked(object sender, EventArgs e)
        {
            var _libVLC = new LibVLC();
            var _mediaPlayer = new MediaPlayer(_libVLC)
            {
                Media = new Media(_libVLC, new Uri("http://213.232.88.19:8334"))
            };

            _mediaPlayer.Play();

            //_mediaPlayer.SetPause(_mediaPlayer.IsPlaying);

            var btn = (Button)sender;

            btn.Text = _mediaPlayer.IsPlaying ? "Pause" : "Play";
        }
    }
}