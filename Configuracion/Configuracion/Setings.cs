using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion
{
    class Setings
    {
        IsolatedStorageSettings settings;

        const string ListBoxSettingKeyName = "ListBoxSetting";
        const string EditText = "EditTextStetting";
        const string EditText1 = "EditTextStetting";

        const int ListBoxSettingDefault = 0;
        const string Nombre = "";
        const string Edad = "";

        public Setings()
        {
            // Get the settings for this application.
            settings = IsolatedStorageSettings.ApplicationSettings;
        }

    }
}
