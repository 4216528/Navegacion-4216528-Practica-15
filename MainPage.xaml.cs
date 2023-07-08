namespace Navegacion_4216528;

public partial class MainPage : ContentPage



{

    public MainPage()

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

    private void AppCambio_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new AppCambio());

    }

    private void AppSuperficieTriangulo_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new AppSuperficieTriangulo());

    }

    private void AppDinosaurio_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new AppDinosaurio());

    }

    private void AppGasolinera_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new AppGasolinera());

    }

    private void Acerca_Clicked(object sender, EventArgs e)

    {

        Navigation.PushAsync(new Acerca());

    }
}
