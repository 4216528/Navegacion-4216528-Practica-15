namespace Navegacion_4216528;

public partial class AppSuperficieTriangulo : ContentPage

{

	public AppSuperficieTriangulo()

	{

		InitializeComponent();

	}

    /// <summary>
    /// <Createdate>07/07/2023</Createdate>
    /// <Company>SandBox</Company>
    /// <Lastmodificationdate>07/07/2023</Lastmodificationdate>
    /// <lastmodificationsdescription>Se implementa una funcion que sea capaz de determinar la superficie de un triangulo</lastmodificationsdescription>
    /// <Lastmodificationautor>Nery</Lastmodificationautor>
    /// </summary>

    private void OnCounterClicked(object sender, EventArgs e)

    // Declaramos las variables A,B y S y declaramos que el valor de S sera igual a = (B * A) / 2. y los valores de A y B seran obtenidos de la propiedad text de los Entry correspondientes //

    {

        double A = double.Parse(Altura.Text);

        double B = double.Parse(Base.Text);

        double S = (B * A) / 2; Superficie.Text = S.ToString();

    }

}