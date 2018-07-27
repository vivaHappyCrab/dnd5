using System.Collections.Generic;
using System.Linq;
using dnd5.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Libraries;

namespace dnd5.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateCharacterPage : ContentPage
    { 
        public CreateCharacterPage()
        {
            this.InitializeComponent();
            this.BindingContext = new CreateClassViewModel() { AvailableClasses = PhoneLibrary.GetClasses().Classes};
        }
    }
}