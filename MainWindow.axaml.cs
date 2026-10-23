using Avalonia.Controls;
using Avalonia.Media;
using Avalonia;
using Avalonia.Interactivity;

namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Title="Título cambiado desde C#";
        saludo.Text="Este texto lo ha puesto el C#";
        saludo.Foreground=Brushes.Crimson;

        var extra = new Button
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };
        panel.Children.Add(extra);

        boton.Click += Boton_Click;
        extra.Click += AbrirVentanaCS;
    }

    private void Boton_Click(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "Esto es un nuevo texto";
    }

    private void AbrirVentanaCS(object? sender, RoutedEventArgs e)
    {
        new VentanaCS().Show();
    }


}
