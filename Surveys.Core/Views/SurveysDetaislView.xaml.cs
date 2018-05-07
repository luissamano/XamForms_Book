using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Surveys.Core.Others;
using Surveys.Core.Models;

namespace Surveys.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SurveysDetaislView : ContentPage
    {
        private readonly string[] teams =
        {
            "Cruz Azul",
            "Guadalajara",
            "Leon",
            "Necaxa",
            "Monterrey",
            "Tigres",
            "Toluca"
        };
        
        public SurveysDetaislView()
        {
            InitializeComponent();
            
        }

        private async void btnFavoriteTeam(object sender, EventArgs e)
        {
            var favTeam = 
            await DisplayActionSheet(Literals.FavoriteTeamTitle, "Cancelar", null, teams);

            if (!string.IsNullOrWhiteSpace(favTeam))
            {
                labelFavoriteTeam.Text = favTeam;
            }
        }

        private async void btnOk(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryName.Text) || 
                string.IsNullOrWhiteSpace(labelFavoriteTeam.Text))
            {
                return;
            }
 
            var newSurvey = new Survey()
            {
                Name = entryName.Text,
                Birthdate = dpikerBirthdate.Date,
                FavoriteTeam = labelFavoriteTeam.Text
            };

            MessagingCenter.Send((ContentPage)this, Menssages.NewSurveyComplete, newSurvey);

            await Navigation.PopAsync();            
        }

    }
}