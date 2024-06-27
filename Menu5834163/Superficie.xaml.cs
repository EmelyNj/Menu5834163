namespace Menu5834163;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Algoritmo que se ejecuta al hacer clic en el botón
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        //Si el entry base y el entry altura contienen caractéres...
        if (eBase.Text != null && eAltura.Text != null)
        {
            //Hacemos un try
            try
            {
                //Se crean las variables area, base y altura
                double area;
                double b = Convert.ToDouble(eBase.Text), a = Convert.ToDouble(eAltura.Text);
                //Si pagas más de lo que cuesta el producto...
                area = b * a;
                //Se muestra el área en su entry correspondiente
                eArea.Text = area.ToString();
            }
            //Si hay un error
            catch
            {
                //Mostramos una alerta
                DisplayAlert("Error", "Los datos deben ser numéricos", "Ok");
            }
        }
        //Si esos entries están vacíos...
        else
        {
            //Mostramos esta alerta
            DisplayAlert("Error", "Debe introducir la base y la altura", "Ok");
        }
    }

    private void Regresar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}