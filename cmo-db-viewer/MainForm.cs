using cmo_db_viewer.Models;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cmo_db_viewer
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            // Read the tables in the database
            CMODatabase.ReadTables(Program.SqlFilePath);

            CMODatabase.ReadDescriptions(Program.DescriptionFolder);

            // Initialize the views
            aircraftsListPanel1.RefreshList();

            foreach(EnumOperatorCountry country in EnumOperatorCountry.DataEntries.Values)
            {
                countryRepositoryItem.Items.Add(country.Description);
            }

            foreach (EnumAircraftType type in EnumAircraftType.DataEntries.Values)
            {
                typeRepositoryItem.Items.Add(type.Description);
            }
        }

        private void filterEdit_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void typeComboBox_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void countryComboBox_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void categoryCheckAllButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            categoryFixedWingCheck.Checked = false;
            categoryFixedWingCarrierCapableCheck.Checked = false;
            categoryHelicopterCheck.Checked = false;
            categoryTiltrotorCheck.Checked = false;
            categoryAirshipCheck.Checked = false;
            categorySeaplaneCheck.Checked = false;
            categoryAmphibianCheck.Checked = false;

            UpdateFilter();
        }

        private void category_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            UpdateFilter();
        }

        private void UpdateFilter()
        {
            string country = countryComboBox.EditValue?.ToString() ?? "";
            string type = typeComboBox.EditValue?.ToString() ?? "";
            string name = filterEdit.EditValue?.ToString() ?? "";
            string[] category = getCategoryFilter();
            aircraftsListPanel1.SetFilter(country, type, category, name);
        }

        private string[] getCategoryFilter()
        {
            List<string> categories = new List<string>();
            if (categoryFixedWingCheck.Checked)
                categories.Add("Fixed Wing");
            if (categoryFixedWingCarrierCapableCheck.Checked)
                categories.Add("Fixed Wing, Carrier Capable");
            if (categoryHelicopterCheck.Checked)
                categories.Add("Helicopter");
            if (categoryTiltrotorCheck.Checked)
                categories.Add("Tiltrotor");
            if (categoryAirshipCheck.Checked)
                categories.Add("Airship");
            if (categorySeaplaneCheck.Checked)
                categories.Add("Seaplane");
            if (categoryAmphibianCheck.Checked)
                categories.Add("Amphibian");
            return categories.ToArray();
        }

        private void clearAircraftsFilterButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            countryComboBox.EditValue = null;
            typeComboBox.EditValue = null;
            filterEdit.EditValue = null;

            categoryFixedWingCheck.Checked = false;
            categoryFixedWingCarrierCapableCheck.Checked = false;
            categoryHelicopterCheck.Checked = false;
            categoryTiltrotorCheck.Checked = false;
            categoryAirshipCheck.Checked = false;
            categorySeaplaneCheck.Checked = false;
            categoryAmphibianCheck.Checked = false;
        }
    }
}
