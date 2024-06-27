namespace Menu5834163
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
        }

        private void CambioBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CC());
        }

        private void TrianguloBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Superficie());
        }

        private void DinosaurioBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dino());
        }

        private void GasolineraBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gasolinera());
        }

        private void AboutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
