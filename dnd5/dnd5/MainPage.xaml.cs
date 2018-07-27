using System;
using System.Collections.ObjectModel;
using dnd5.Pages;
using Xamarin.Forms;

namespace dnd5
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<CharacterSelection> _strs=new ObservableCollection<CharacterSelection>();
        private int _count = 0;
        public MainPage()
        {
            this.InitializeComponent();
            this.CharactersList.ItemsSource = this._strs;
            this.BindingContext = this;
        }

        private async void  NewCharacterClicked(object sender, EventArgs e)
        {
            //this._strs.Add(new CharacterSelection() {Name = this._count.ToString(), ClassName = "Warlock"});
            //this._count++;
            await this.Navigation.PushAsync(new CreateCharacterPage());
        }

        private class CharacterSelection
        {
            public string Name { get; set; }
            public string ClassName { get; set; }

            public int Level { get; set; }
        }
    }
}
