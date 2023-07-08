namespace Navegacion_4216528;

public partial class AppGasolinera : ContentPage

{

	public AppGasolinera()

	{

		InitializeComponent();

	}

    /// <summary>
    /// <Createdate>07/07/2023</Createdate>
    /// <Company>SandBox</Company>
    /// <Lastmodificationsdate>07/07/2023</Lastmodificationsdate>
    /// <Lastmodificationsdescription>ninguno</Lastmodificationsdescription>
    /// <Lastmodificationsautor>Nery</Lastmodificationsautor>
    /// </summary>

    private void OnCounterClicked(object sender, EventArgs e)

    // Declaramos las variables correpondientes y hacemos sus operaciones debidas //

    {

        double G = double.Parse(GalonesSurtidos.Text);

        double PL = double.Parse(PrecioLitro.Text);

        double M = G * PL * 3.78 / 1; Monto.Text = M.ToString("N2");

    }

}