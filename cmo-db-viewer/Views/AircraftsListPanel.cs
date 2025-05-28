using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmo_db_viewer.Views
{
    public partial class AircraftsListPanel : DevExpress.XtraEditors.XtraUserControl
    {
        public AircraftsListPanel()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            treeList1.BeginUnboundLoad();
            treeList1.Nodes.Clear();
            foreach (var entry in Models.DataAircraft.DataEntries)
            {
                var data = entry.Value as Models.DataAircraft;
                if (data == null) continue;
                var node = treeList1.AppendNode(new object[] { data.Name, data.Type.Description, data.OperatorCountry.Description, data.Category.Description, data.YearCommissioned }, null);
                node.Tag = data;
            }
            treeList1.EndUnboundLoad();
        }

        public void SetFilter(string country, string type, string[] category, string name)
        {
            List<string> categoryFilter = new List<string>();
            foreach(string cat in category)
            {
                categoryFilter.Add($"[category] LIKE '%{cat}%'");
            }
            treeList1.ActiveFilterString = $"[name] LIKE '%{name}%' AND [country] LIKE '%{country}%' AND (" + string.Join(" OR ", categoryFilter) + $") AND [type] LIKE '%{type}%'";
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            // Check if a node is selected
            if (treeList1.FocusedNode != null && treeList1.FocusedNode.Tag is Models.DataAircraft aircraft)
            {
                // Create a new AircraftPanel and set the selected aircraft
                var aircraftPanel = new AircraftPanel();
                aircraftPanel.SetAircraft(aircraft);
                // Show the AircraftPanel in a new form
                var form = new XtraForm
                {
                    Text = "Aircraft Details",
                    Size = new Size(900, 900),
                    StartPosition = FormStartPosition.CenterParent
                };
                form.Controls.Add(aircraftPanel);
                aircraftPanel.Dock = DockStyle.Fill;
                form.ShowDialog(this);
            }
        }
    }
}
