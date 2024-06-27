namespace Menu5834163;

public partial class Dino : ContentPage
{
	public Dino()
	{
		InitializeComponent();
	}

    /// <summary>
    /// El evento clicked del botón realiza una conversión de datos ingresados por el usuario según la altura y el peso
    /// Con un if/else se validan que los datos ingresados en los entry sean de tipo string en el nombre y de tipo double en los datos de la altura y el peso
    /// Con el try/catch se validan que los campos no esten vacios
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (NomDino.Text != null && Altura.Text != null && Peso.Text != null)
        {
            try
            {
                double alt, peso, conversion1, conversion2;
		        string Nombre;

		        Nombre = Convert.ToString(NomDino.Text);
                alt = Convert.ToDouble(Altura.Text);
		        peso = Convert.ToDouble(Peso.Text);

		        conversion1 = peso * 2.2046;
		        conversion2 = alt * 100;

		        Resultado.Text = "El nombre del dinosaurio es : " +  Nombre;
		        Dato1.Text = "Su altura en centimetros es de : " + conversion2 + "cm";
		        Dato2.Text = "Su peso en libras es de : " + conversion1 + "lb";
            }
            catch
            {
                DisplayAlert("ERROR", "Verifique datos", "Ok");
            }

        }
        else
        {
            DisplayAlert("ERROR", "Ingrese todos los datos solicitados ", "Ok");
        }

    }
}