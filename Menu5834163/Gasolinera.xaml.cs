namespace Menu5834163;

public partial class Gasolinera : ContentPage
{
	public Gasolinera()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Algoritmo que se ejecuta al hacer clic en el bot�n
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        //Si los entries gal y precio contienen caract�res
        if (eGal.Text != null && ePrecio.Text != null)
        {
            //Usamos un try
            try
            {
                //Creamos las variables costo, galones y pago
                double costo = Convert.ToDouble(ePrecio.Text), galones = Convert.ToDouble(eGal.Text);
                //Calculamos el pago
                double pago = costo * (galones * 3.78541);
                //Mostramos el pago en su entry correspondiente
                ePago.Text = pago.ToString("C2");
            }
            //Si hay un error mostrar una alerta
            catch
            {
                DisplayAlert("Error", "Los datos deben ser num�ricos", "Ok");
            }
        }
        //Si no, mostrar una alerta
        else
        {
            DisplayAlert("Error", "Debe introducir los galones y el costo", "Ok");
        }
    }

    private void Regresar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}