using AppAgroMovil.MVVM.ViewModels;

namespace AppAgroMovil.MVVM.View.User;

public partial class AppUsers : ContentPage
{
	public AppUsers()
	{
        InitializeComponent();

        // Datos directamente en el code-behind
        var sensores = new List<Sensor>
            {
                new Sensor
                {
                    Name = "Sensor de humedad",
                    Description = "Ideal para medir la humedad del suelo.",
                    Image = "sensor.png"
                },
                new Sensor
                {
                    Name = "Panel solar",
                    Description = "Proporciona energía renovable para dispositivos.",
                    Image = "panel.png"
                },
                new Sensor
                {
                    Name = "Estación meteorológica",
                    Description = "Monitorea condiciones climáticas en tiempo real.",
                    Image = "estacion.png"
                }
            };

        // Enlace de los datos al ListView
        ProductsListView.ItemsSource = sensores;
    }

    // Clase de producto
    public class Sensor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
