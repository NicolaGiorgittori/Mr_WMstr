using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// Il modello di elemento per la pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=391641

namespace Mr_WMstr
{
    /// <summary>
    /// Pagina vuota che può essere utilizzata autonomamente oppure esplorata all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Richiamato quando la pagina sta per essere visualizzata in un Frame.
        /// </summary>
        /// <param name="e">Dati dell'evento in cui vengono descritte le modalità con cui la pagina è stata raggiunta.
        /// Questo parametro viene in genere utilizzato per configurare la pagina.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: preparare qui la pagina da visualizzare.

            // TODO: se l'applicazione contiene più pagine, assicurarsi che si stia
            // gestendo il pulsante Indietro dell'hardware effettuando la registrazione per
            // l'evento Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Se si utilizza l'elemento NavigationHelper fornito da alcuni modelli,
            // questo evento viene gestito automaticamente.
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Hai Premuto Ciao");
            await dialog.ShowAsync();
        }

        private async void Bottone_Click(object sender, RoutedEventArgs e)
        {
            //MessageDialog msgbox = new MessageDialog("Would you like to greet the world with a \"Hello, world\"?", "My App");
            /*
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            msgbox.Commands.Add(new UICommand { Label = "Cancel", Id = 2 });

            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                MessageDialog msgbox2 = new MessageDialog("Hello to you too! :)", "User Response");
                await msgbox2.ShowAsync();
            }

            if ((int)res.Id == 1)
            {
                MessageDialog msgbox2 = new MessageDialog("Oh well, too bad! :(", "User Response");
                await msgbox2.ShowAsync();
            }

            if ((int)res.Id == 2)
            {
                MessageDialog msgbox2 = new MessageDialog("Nevermind then... :|", "User Response");
                await msgbox2.ShowAsync();
            }
            */
            /*
                //Application.Current.Shutdown();
                var dialog = new MessageDialog("Your message here");
                await dialog.ShowAsync();             
             */
            var dialog = new MessageDialog("Sei sicuro?");

            dialog.Title = "Veramente?";
            dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "Annulla", Id = 1 });
            var res = await dialog.ShowAsync();

            if ((int)res.Id == 0)
            {
                //MessageDialog msgbox2 = new MessageDialog("Nevermind then... :|", "User Response");
                MessageDialog msgbox_OK = new MessageDialog("Hai premuto OK e per questo \nL'applicazione verrà chiusa...!", "Risposta Utente");
                await msgbox_OK.ShowAsync();
                Application.Current.Exit();
            }
            else
            {
                MessageDialog msgbox_Cancel = new MessageDialog("Hai premuto Annulla", "Risposta Utente");
                await msgbox_Cancel.ShowAsync();
            }
        }
    }
}
