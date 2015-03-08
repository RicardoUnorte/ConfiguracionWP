using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Configuracion
{
    public partial class SettingPage : PhoneApplicationPage
    {

        IsolatedStorageSettings appset = IsolatedStorageSettings.ApplicationSettings;
        public SettingPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            appset.Remove("Nombre");
            appset.Add("Nombre", Na.Text);

            appset.Remove("Edad");
            appset.Add("Edad", Ed.Text);

            if (mas.IsChecked == true)
            {
                appset.Remove("Genero");
                appset.Add("Genero", mas.Content);
            }
            else
            {
                appset.Remove("Genero");
                appset.Add("Genero", fem.Content);
            }
            NavigationService.GoBack();
            }

    }
}