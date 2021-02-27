using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectV1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
            ClickerButton.Clicked += ClickerButton_Clicked;
        }

        int count = 0;

        private void ClickerButton_Clicked(object sender, EventArgs e)
        {
            count++;
            LabelCount.Text = $" {count} ";
        }

        private void MembersButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SubmitScoreButton_Clicked(object sender, EventArgs e)
        {

        }
        private void ViewScoreButton_Clicked(object sender, EventArgs e)
        {

        }
    }
} 