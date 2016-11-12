using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Layouts.Views
{
    public partial class ViewModel : ContentPage
    {
        // Handle number of Clicks on Button
        int _numberOfButtonClicks;
        // Handle number of Clicks on Label
        int _numberOfLabelClicks;
        public ViewModel()
        {
            InitializeComponent();
            // If View doesn't have onClick listener, it could be defined by following line
            // Old way LabelToClick.GestureRecognizers.Add(new TapGestureRecognizer((view) => LabelClick()));
           
            // Or by Command
            LabelToClick.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => LabelClick()),
            });

        }

        /// <summary>
        /// Handle Label clicks and update label with number of clicks on label
        /// </summary>
        public void LabelClick()
        {
            _numberOfLabelClicks++;
            ClickedLabel.Text = "NumberOfLabelClicks: " + _numberOfLabelClicks;
        }

        /// <summary>
        /// Handle Button clicks and update label with number of clicks on button
        /// </summary>
        /// <param name="sender">Object which fired this event</param>
        /// <param name="e">Additional Click parameters</param>
        public void ButtonClick(Object sender, EventArgs e)
        {
            _numberOfButtonClicks++;
            ClickedButton.Text = "NumberOfButtonClicks: " + _numberOfButtonClicks;
        }

        /// <summary>
        /// Repeats text from Entry when user changed it.
        /// </summary>
        /// <param name="sender">Object which fired this event</param>
        /// <param name="e">Additional Click parameters</param>
        private void TexChanged(object sender, TextChangedEventArgs e)
        {
            ChangedText.Text = "You wrote: " + e.NewTextValue;
        }
    }
}
