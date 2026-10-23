using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
 
namespace HolaAvalonia;
 
public class VentanaCS : Window
{
    private TextBlock saludo = null!;
 
    public VentanaCS()
    {
        InitializeComponent();
    }
 
    private void InitializeComponent()
    {
        // 1) Propiedades de la ventana: Title, Width y Height
        Title = "Título cambiado desde C#";
        Width = 500;
        Height = 250;

        // 2) Crea el TextBlock con tu nombre y guárdalo en "saludo"
        saludo = new TextBlock
        {
            Text = "Este texto lo ha puesto el C#",
            FontSize = 24,
            Foreground=Brushes.Crimson,
            Margin = new Thickness(0, 10, 0, 0)
        };

        // 3) Crea el Button con el mismo texto que en MainWindow
        var boton = new Button
        {
            Content = "Púlsame",
            Margin = new Thickness(0, 10, 0, 0)
        };

        boton.Click += Boton_Click;

        // 4) Asigna a Content un StackPanel que contenga los dos
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(saludo);
        panel.Children.Add(boton);
        Content = panel;
        
    }

    private void Boton_Click(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "Esto es un nuevo texto";
    }

}
