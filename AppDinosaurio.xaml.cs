namespace Navegacion_4216528;

public partial class AppDinosaurio : ContentPage

{

	public AppDinosaurio()

	{

		InitializeComponent();

	}

    ///<summary>
    ///<Createdate>07/07/2023</Createdate>
    ///<Company>SandBox</Company>
    ///<Lastmodificationdate>07/07/2023</Lastmodificationdate>
    ///<Lastmodificationdescription>Se aplicara las conversiones necesarias para expresar el peso de Kg a L, y la altura de MTS, a CMT</Lastmodificationdescription>
    ///<Lastmodificationautor>Nery</Lastmodificationautor>
    ///</summary>

    private void OnCounterClicked(object sender, EventArgs e)

    // Declaramos las variables N,PK,AM estas son sirven para almacenar los valores ingresados por el usuario. PL,y AC, nos sirven para convertir los sistemas de medida ingresados anteriormente //

    {

        // Imprimimos el nombre del dinosaurio con la propiedad text del label correspondiente, y asi con las demas variables //

        string N = Nombre.Text; NombreDinosaurio.Text = N.ToString();

        double PK = double.Parse(PesoKilogramos.Text);

        double AM = double.Parse(AlturaMetros.Text);

        double PL = PK * 2.2046 / 1; PesoLibras.Text = PL.ToString();

        double AC = AM * 100 / 1; AlturaCentimetros.Text = AC.ToString();

    }

}