using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Surveys.Core.Views;
using Surveys.Core.Models;
using Surveys.Core.Others;

namespace Surveys.Core
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveysView : ContentPage
	{
        public SurveysView()
        {
            InitializeComponent();
            this.btnAdd.Clicked += BtnAdd_Clicked;

            MessagingCenter.Subscribe<ContentPage, Survey>(this, Menssages.NewSurveyComplete,
            (sender, args) =>
            {
                SurveysPanel.Children.Add(new Label()
                {
                    Text = args.ToString()
                 });
            });
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SurveysDetaislView());
            
        }
    }
}