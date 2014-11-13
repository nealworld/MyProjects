using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ElectronicLogbook.AircraftEquipment.ViewModel;
using ElectronicLogbookDataLib.AirCraftEquipment;

namespace ElectronicLogbook.AircraftEquipment
{
    /// <summary>
    /// Interaction logic for AircraftEquipmentControl.xaml
    /// </summary>
    public partial class AircraftEquipmentControl : UserControl
    {
        AirCraftEquipmentConfigViewModel mAirCraftEquipmentConfigViewModel;
        public AircraftEquipmentControl()
        {
            InitializeComponent();


            mAirCraftEquipmentConfigViewModel = new AirCraftEquipmentConfigViewModel(GetList());
            base.DataContext = mAirCraftEquipmentConfigViewModel;

        }

        private List<AirCraftEquipmentConfig> GetList()
        {
            List<AirCraftEquipmentConfig> myList = new List<AirCraftEquipmentConfig>();

            AirCraftEquipmentConfig lAirCraftEquipmentConfig1 = new AirCraftEquipmentConfig();
            lAirCraftEquipmentConfig1.mConfigName = "GPM1";
            lAirCraftEquipmentConfig1.mSubEquipmentList = new List<SubEquipment>();
            SubEquipment lSubEquipment = new SubEquipment();
            lSubEquipment.mEquipmentID = "Equipment_ID: 1";
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_1","1","1","1","1"));
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_2", "2", "2", "2", "2"));
            lAirCraftEquipmentConfig1.mSubEquipmentList.Add(lSubEquipment);
            lSubEquipment = new SubEquipment();
            lSubEquipment.mEquipmentID = "Equipment_ID: 2";
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_1", "1", "1", "1", "1"));
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_2", "2", "2", "2", "2"));
            lAirCraftEquipmentConfig1.mSubEquipmentList.Add(lSubEquipment);
            lSubEquipment = new SubEquipment();
            lSubEquipment.mEquipmentID = "Equipment_ID: 3";
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_1", "1", "1", "1", "1"));
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_2", "2", "2", "2", "2"));
            lAirCraftEquipmentConfig1.mSubEquipmentList.Add(lSubEquipment);
            myList.Add(lAirCraftEquipmentConfig1);

            lAirCraftEquipmentConfig1 = new AirCraftEquipmentConfig();
            lAirCraftEquipmentConfig1.mConfigName = "GPM2";
            lAirCraftEquipmentConfig1.mSubEquipmentList = new List<SubEquipment>();
            lSubEquipment = new SubEquipment();
            lSubEquipment.mEquipmentID = "Equipment_ID: 1";
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_1", "1", "1", "1", "1"));
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_2", "2", "2", "2", "2"));
            lAirCraftEquipmentConfig1.mSubEquipmentList.Add(lSubEquipment);
            lSubEquipment = new SubEquipment();
            lSubEquipment.mEquipmentID = "Equipment_ID: 2";
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_1", "1", "1", "1", "1"));
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_2", "2", "2", "2", "2"));
            lAirCraftEquipmentConfig1.mSubEquipmentList.Add(lSubEquipment);
            lSubEquipment = new SubEquipment();
            lSubEquipment.mEquipmentID = "Equipment_ID: 3";
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_1", "1", "1", "1", "1"));
            lSubEquipment.mHWPartList.Add(new HWPart("HW_PART_2", "2", "2", "2", "2"));
            lAirCraftEquipmentConfig1.mSubEquipmentList.Add(lSubEquipment);
            myList.Add(lAirCraftEquipmentConfig1);

            return myList;
        }
    }
}
