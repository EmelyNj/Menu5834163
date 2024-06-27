namespace Menu5834163;

public partial class CC : ContentPage
{
	public CC()
	{
		InitializeComponent();
	}
	/// <summary>
	///  El evento clicked  del bot�n realiza la accion de calcular el cambio del cliente mediante una resta
	///  Pero mediante un try/catch valida el ingreso de datos que sean solo n�mericos
	///  Con el if/else valida que los campos no esten vacios 
	///  Con otro if/else se valida que si el costo del articulo es mayor al dinero entregado, el entry le indica el faltante
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
	{
		if (Articulo.Text != null && Cambio.Text != null)
		{
			try
			{
				double Art, Dinero, CambioC;
				Art = Convert.ToDouble(Articulo.Text);
				Dinero = Convert.ToDouble(Cambio.Text);
				if (Art <= Dinero)
				{
					CambioC = Dinero - Art;
					CambioCliente.Text = CambioC.ToString() + " D�lares";
				}
				else if (Art > Dinero) 
				{
					CambioC = Art - Dinero;
                    CambioCliente.Text = "Te Falta/n " + CambioC.ToString() + " D�lares";
                }
			}
			catch 
			{
				DisplayAlert("ERROR", "Verifique ingresar solo n�meros", "Ok");
			}
			

		}
		else
		{
            DisplayAlert("ERROR", "Ingrese los datos solicitados ", "Ok");
        }
    }
}