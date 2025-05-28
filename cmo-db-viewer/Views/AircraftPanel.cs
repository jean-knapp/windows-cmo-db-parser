using cmo_db_viewer.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmo_db_viewer.Views
{
    public partial class AircraftPanel : DevExpress.XtraEditors.XtraUserControl
    {
        public AircraftPanel()
        {
            InitializeComponent();
        }

        public void SetAircraft(DataAircraft aircraft)
        {
            aircraftNameLabel.Text = aircraft.Name;
            categoryLabel.Text = aircraft.Category.Description;
            typeLabel.Text = aircraft.Type.Description;
            countryLabel.Text = aircraft.OperatorCountry.Description;
            serviceLabel.Text = aircraft.OperatorService.Description;
            yearCommissionedLabel.Text = aircraft.YearCommissioned.ToString();
            yearDecommissionedLabel.Text = aircraft.YearDecommissioned > 0 ? aircraft.YearDecommissioned.ToString() : "N/A";
            lengthLabel.Text = aircraft.Length.ToString("F2") + " m";
            spanLabel.Text = aircraft.Span.ToString("F2") + " m";
            heightLabel.Text = aircraft.Height.ToString("F2") + " m";
            weightEmptyLabel.Text = aircraft.WeightEmpty.ToString("N0") + " kg";
            weightMaxLabel.Text = aircraft.WeightMax.ToString("N0") + " kg";
            weightPayloadLabel.Text = aircraft.WeightPayload.ToString("N0") + " kg";
            crewLabel.Text = aircraft.Crew.ToString();
            agilityLabel.Text = aircraft.Agility.ToString("F2");
            climbRateLabel.Text = aircraft.ClimbRate.ToString("F2") + " m/s";
            autonomousControlLevelLabel.Text = aircraft.AutonomousControlLevel.Description;
            autonomousControlSignalLossLabel.Text = aircraft.AutonomousControlLevel.OnSignalLoss;
            cockpitGenLabel.Text = aircraft.CockpitGen.Description;
            cockpitGenExampleLabel.Text = aircraft.CockpitGen.Example;
            ergonomicsLabel.Text = aircraft.Ergonomics.Description;
            totalEnduranceLabel.Text = aircraft.TotalEndurance > 0 ? aircraft.TotalEndurance.ToString() + " min" : "N/A";
            physicalSizeLabel.Text = aircraft.PhysicalSizeCode.Description;
            runwayLengthLabel.Text = aircraft.RunwayLengthCode.Description;
            damagePointsLabel.Text = aircraft.DamagePoints.ToString("F2");
            engineArmorLabel.Text = aircraft.AircraftEngineArmor.Description;
            fuselageArmorLabel.Text = aircraft.AircraftFuselageArmor.Description;
            cockpitArmorLabel.Text = aircraft.AircraftCockpitArmor.Description;
            cockpitVisibilityLabel.Text = aircraft.Visibility.Description;
            fuelOffloadRateLabel.Text = aircraft.FuelOffloadRate > 0 ? aircraft.FuelOffloadRate.ToString() + " kg/s" : "N/A";
            hypotheticalLabel.Visible = aircraft.Hypothetical;
            costLabel.Text = aircraft.Cost > 0 ? aircraft.Cost.ToString("N0") + " $M" : "N/A";
            descriptionMemo.Text = aircraft.Description;

            loadoutsTree.BeginUnboundLoad();
            foreach (var loadout in aircraft.Loadouts)
            {
                var loadoutNode = loadoutsTree.AppendNode(new object[]
                {
                    loadout.Name,
                    loadout.LoadoutRole.Description,
                    loadout.Capacity,
                    loadout.ReadyTime + " min",
                    loadout.TimeOfDay.Description,
                    loadout.Weather.Description,
                    loadout.DefaultCombatRadius + " NM",
                    loadout.RequiresBuddyIllumination,
                    loadout.CargoType.Description,
                    loadout.CargoMass + " ton",
                    loadout.CargoArea + " m²",
                    loadout.CargoCrew,
                    loadout.CargoParadropCapable,
                }, null);
            }
            loadoutsTree.EndUnboundLoad();

            fuelTree.BeginUnboundLoad();
            foreach (var fuel in aircraft.Fuel)
            {
                var fuelNode = fuelTree.AppendNode(new object[]
                {
                    fuel.Type.Description,
                    fuel.Capacity
                }, null);
            }
            fuelTree.EndUnboundLoad();

            // Load bitmap without locking
            string path = Path.Combine(Program.ImagesFolder, "Aircraft_" + aircraft.ID + ".jpg");
            if (File.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    if (stream.Length > 0)
                    {
                        pictureEdit.Image = Image.FromStream(stream);
                    }
                }
            }
        }
    }
}
