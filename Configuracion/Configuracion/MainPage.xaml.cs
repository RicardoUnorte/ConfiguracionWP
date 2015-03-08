using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Configuracion.Resources;
using System.IO.IsolatedStorage;

namespace Configuracion
{
    public partial class MainPage : PhoneApplicationPage
    {
        IsolatedStorageSettings appset = IsolatedStorageSettings.ApplicationSettings;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            if (!(appset.Contains("Nombre")))
            {
                appset.Add("Nombre","false");
                appset.Add("Edad", "false");
                appset.Add("Genero", "false");
            }
            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();

            Name.Text = "Nombre: " + appset["Nombre"].ToString();
            Age.Text = "Edad: " + appset["Edad"].ToString();
            Gen.Text = "Genero: " + appset["Genero"].ToString();
        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SettingPage.xaml", UriKind.Relative));
        }

        private void settingBut_Reload(object sender, RoutedEventArgs e)
        {
            Name.Text = "Nombre: " + appset["Nombre"].ToString();
            Age.Text = "Edad: " + appset["Edad"].ToString();
            Gen.Text = "Genero: " + appset["Genero"].ToString();
        }

     

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}