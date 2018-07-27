using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CharacterBase.Entities;

namespace dnd5.ViewModels
{
    public class CreateClassViewModel : INotifyPropertyChanged
    {
        private List<Class> _availableClasses;

        public List<Class> AvailableClasses
        {
            get { return this._availableClasses; }
            set
            {
                if (this._availableClasses == value) return;
                this._availableClasses = value;
                this.OnPropertyChanged();
            }
        }

        private Class _selectedClass;
        public Class SelectedClass
        {
            get { return this._selectedClass; }
            set
            {
                if (this._selectedClass == value) return;
                this._selectedClass = value;
                this.OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
