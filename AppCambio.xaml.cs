namespace Navegacion_4216528;

public partial class AppCambio : ContentPage

{

	public AppCambio()

	{

		InitializeComponent();

	}

    /// <summary>
    /// <CreateDate>07/07/2023</CreateDate>
    /// <Company>SandBox</Company>
    /// <Lastmodificationdate>07/07/2023</Lastmodificationdate>
    /// <lastmodificationdescript>Se imprime el cambio correspondiente en un label</lastmodificationdescript>
    /// <lastmodificationautor>Nery</lastmodificationautor>
    /// </summary>

    // Programamos el evento click del button para que este sea capaz de generar lo que le estamos solicitando //
    private void OnCounterClicked(object sender, EventArgs e)

    // Declaramos las variables C,D Y V. y les asiganamos sus valores correspondientes //

    {

        int C = Convert.ToInt32(Costo.Text);

        int D = Convert.ToInt32(Dinero.Text);

        // Imprimimos el vuelto que se dara en el label Cambio en su propiedad text //

        int V = D - C; Cambio.Text = V.ToString();

    }

}