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
        int numberOfButtonClicks;
        // Handle number of Clicks on Label
        int numberOfLabelClicks;
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
            numberOfLabelClicks++;
            ClickedLabel.Text = "NumberOfLabelClicks: " + numberOfLabelClicks;
        }

        /// <summary>
        /// Handle Button clicks and update label with number of clicks on button
        /// </summary>
        /// <param name="sender">Object which fired this event</param>
        /// <param name="e">Additional Click parameters</param>
        public void ButtonClick(Object sender, EventArgs e)
        {
            numberOfButtonClicks++;
            ClickedButton.Text = "NumberOfButtonClicks: " + numberOfButtonClicks;
        }
    }
}
