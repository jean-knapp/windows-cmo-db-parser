namespace cmo_db_viewer.Views
{
    partial class AircraftsListPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.coltreeListColumn0 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coltreeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coltreeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coltreeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.coltreeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.coltreeListColumn0,
            this.coltreeListColumn2,
            this.coltreeListColumn1,
            this.coltreeListColumn3,
            this.coltreeListColumn4});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.treeList1.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never;
            this.treeList1.Size = new System.Drawing.Size(901, 557);
            this.treeList1.TabIndex = 0;
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // coltreeListColumn0
            // 
            this.coltreeListColumn0.Caption = "Name";
            this.coltreeListColumn0.FieldName = "name";
            this.coltreeListColumn0.Name = "coltreeListColumn0";
            this.coltreeListColumn0.Visible = true;
            this.coltreeListColumn0.VisibleIndex = 0;
            // 
            // coltreeListColumn2
            // 
            this.coltreeListColumn2.Caption = "Type";
            this.coltreeListColumn2.FieldName = "type";
            this.coltreeListColumn2.Name = "coltreeListColumn2";
            this.coltreeListColumn2.Visible = true;
            this.coltreeListColumn2.VisibleIndex = 1;
            // 
            // coltreeListColumn1
            // 
            this.coltreeListColumn1.Caption = "Country";
            this.coltreeListColumn1.FieldName = "country";
            this.coltreeListColumn1.Name = "coltreeListColumn1";
            this.coltreeListColumn1.Visible = true;
            this.coltreeListColumn1.VisibleIndex = 2;
            // 
            // coltreeListColumn3
            // 
            this.coltreeListColumn3.Caption = "Category";
            this.coltreeListColumn3.FieldName = "category";
            this.coltreeListColumn3.Name = "coltreeListColumn3";
            this.coltreeListColumn3.Visible = true;
            this.coltreeListColumn3.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.treeList1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(905, 561);
            this.panelControl1.TabIndex = 1;
            // 
            // coltreeListColumn4
            // 
            this.coltreeListColumn4.Caption = "Year Comissioned";
            this.coltreeListColumn4.FieldName = "yearComissioned";
            this.coltreeListColumn4.Name = "coltreeListColumn4";
            this.coltreeListColumn4.Visible = true;
            this.coltreeListColumn4.VisibleIndex = 4;
            // 
            // AircraftsListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "AircraftsListPanel";
            this.Size = new System.Drawing.Size(905, 561);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn0;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn4;
    }
}
