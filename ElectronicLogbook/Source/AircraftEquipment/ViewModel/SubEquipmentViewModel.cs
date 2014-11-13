using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElectronicLogbookDataLib.AirCraftEquipment;
using System.ComponentModel;

namespace ElectronicLogbook.AircraftEquipment.ViewModel
{
    public class SubEquipmentViewModel : INotifyPropertyChanged
    {
        public String mNodeName { set; get; }
        public SubEquipment mSubEquipment { set; get; }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    this.OnPropertyChanged("IsSelected");
                }
            }
        }

        public SubEquipmentViewModel(SubEquipment lSubEquipment)
        {
            this.mSubEquipment = lSubEquipment;
            this.mNodeName = "EquipmentID: " + lSubEquipment.mEquipmentID;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
