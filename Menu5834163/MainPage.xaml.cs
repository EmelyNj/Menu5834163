﻿namespace Menu5834163
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
        }

        private void CambioBtn_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ());
        }

        private void TrianguloBtn_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ());
        }

        private void DinosaurioBtn_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ());
        }

        private void GasolineraBtn_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ());
        }

        private void AboutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
