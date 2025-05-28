namespace cmo_db_viewer
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::cmo_db_viewer.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.countryComboBox = new DevExpress.XtraBars.BarEditItem();
            this.countryRepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.typeComboBox = new DevExpress.XtraBars.BarEditItem();
            this.typeRepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.filterEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.categoryMenu = new DevExpress.XtraBars.BarSubItem();
            this.categoryCheckAllButton = new DevExpress.XtraBars.BarButtonItem();
            this.categoryFixedWingCheck = new DevExpress.XtraBars.BarCheckItem();
            this.categoryFixedWingCarrierCapableCheck = new DevExpress.XtraBars.BarCheckItem();
            this.categoryHelicopterCheck = new DevExpress.XtraBars.BarCheckItem();
            this.categoryTiltrotorCheck = new DevExpress.XtraBars.BarCheckItem();
            this.categoryAirshipCheck = new DevExpress.XtraBars.BarCheckItem();
            this.categorySeaplaneCheck = new DevExpress.XtraBars.BarCheckItem();
            this.categoryAmphibianCheck = new DevExpress.XtraBars.BarCheckItem();
            this.clearAircraftsFilterButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.aircraftsListPanel1 = new cmo_db_viewer.Views.AircraftsListPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRepositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.countryComboBox,
            this.typeComboBox,
            this.filterEdit,
            this.categoryMenu,
            this.categoryCheckAllButton,
            this.categoryFixedWingCheck,
            this.categoryFixedWingCarrierCapableCheck,
            this.categoryHelicopterCheck,
            this.categoryTiltrotorCheck,
            this.categoryAirshipCheck,
            this.categorySeaplaneCheck,
            this.categoryAmphibianCheck,
            this.clearAircraftsFilterButton});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.countryRepositoryItem,
            this.typeRepositoryItem,
            this.repositoryItemTextEdit1,
            this.repositoryItemPopupContainerEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office365;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1022, 201);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // countryComboBox
            // 
            this.countryComboBox.Caption = "Country";
            this.countryComboBox.Edit = this.countryRepositoryItem;
            this.countryComboBox.EditWidth = 144;
            this.countryComboBox.Id = 2;
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.EditValueChanged += new System.EventHandler(this.countryComboBox_EditValueChanged);
            // 
            // countryRepositoryItem
            // 
            this.countryRepositoryItem.AutoHeight = false;
            this.countryRepositoryItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countryRepositoryItem.Name = "countryRepositoryItem";
            this.countryRepositoryItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Caption = "Type";
            this.typeComboBox.Edit = this.typeRepositoryItem;
            this.typeComboBox.EditWidth = 144;
            this.typeComboBox.Id = 3;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.EditValueChanged += new System.EventHandler(this.typeComboBox_EditValueChanged);
            // 
            // typeRepositoryItem
            // 
            this.typeRepositoryItem.AutoHeight = false;
            this.typeRepositoryItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeRepositoryItem.Name = "typeRepositoryItem";
            this.typeRepositoryItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // filterEdit
            // 
            this.filterEdit.Caption = "Filter";
            this.filterEdit.Edit = this.repositoryItemTextEdit1;
            this.filterEdit.EditWidth = 144;
            this.filterEdit.Id = 4;
            this.filterEdit.Name = "filterEdit";
            this.filterEdit.EditValueChanged += new System.EventHandler(this.filterEdit_EditValueChanged);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // categoryMenu
            // 
            this.categoryMenu.Caption = "Category";
            this.categoryMenu.Id = 6;
            this.categoryMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryCheckAllButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryFixedWingCheck, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryFixedWingCarrierCapableCheck),
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryHelicopterCheck),
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryTiltrotorCheck),
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryAirshipCheck),
            new DevExpress.XtraBars.LinkPersistInfo(this.categorySeaplaneCheck),
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryAmphibianCheck)});
            this.categoryMenu.Name = "categoryMenu";
            // 
            // categoryCheckAllButton
            // 
            this.categoryCheckAllButton.Caption = "Clear filter";
            this.categoryCheckAllButton.Id = 14;
            this.categoryCheckAllButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("categoryCheckAllButton.ImageOptions.SvgImage")));
            this.categoryCheckAllButton.Name = "categoryCheckAllButton";
            this.categoryCheckAllButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.categoryCheckAllButton_ItemClick);
            // 
            // categoryFixedWingCheck
            // 
            this.categoryFixedWingCheck.Caption = "Fixed Wing";
            this.categoryFixedWingCheck.Id = 15;
            this.categoryFixedWingCheck.Name = "categoryFixedWingCheck";
            this.categoryFixedWingCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.category_CheckedChanged);
            // 
            // categoryFixedWingCarrierCapableCheck
            // 
            this.categoryFixedWingCarrierCapableCheck.Caption = "Fixed Wing, Carrier Capable";
            this.categoryFixedWingCarrierCapableCheck.Id = 16;
            this.categoryFixedWingCarrierCapableCheck.Name = "categoryFixedWingCarrierCapableCheck";
            this.categoryFixedWingCarrierCapableCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.category_CheckedChanged);
            // 
            // categoryHelicopterCheck
            // 
            this.categoryHelicopterCheck.Caption = "Helicopter";
            this.categoryHelicopterCheck.Id = 17;
            this.categoryHelicopterCheck.Name = "categoryHelicopterCheck";
            this.categoryHelicopterCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.category_CheckedChanged);
            // 
            // categoryTiltrotorCheck
            // 
            this.categoryTiltrotorCheck.Caption = "Tiltrotor";
            this.categoryTiltrotorCheck.Id = 18;
            this.categoryTiltrotorCheck.Name = "categoryTiltrotorCheck";
            this.categoryTiltrotorCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.category_CheckedChanged);
            // 
            // categoryAirshipCheck
            // 
            this.categoryAirshipCheck.Caption = "Airship";
            this.categoryAirshipCheck.Id = 19;
            this.categoryAirshipCheck.Name = "categoryAirshipCheck";
            this.categoryAirshipCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.category_CheckedChanged);
            // 
            // categorySeaplaneCheck
            // 
            this.categorySeaplaneCheck.Caption = "Seaplane";
            this.categorySeaplaneCheck.Id = 20;
            this.categorySeaplaneCheck.Name = "categorySeaplaneCheck";
            this.categorySeaplaneCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.category_CheckedChanged);
            // 
            // categoryAmphibianCheck
            // 
            this.categoryAmphibianCheck.Caption = "Amphibian";
            this.categoryAmphibianCheck.Id = 21;
            this.categoryAmphibianCheck.Name = "categoryAmphibianCheck";
            this.categoryAmphibianCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.category_CheckedChanged);
            // 
            // clearAircraftsFilterButton
            // 
            this.clearAircraftsFilterButton.Caption = "Clear Filter";
            this.clearAircraftsFilterButton.Id = 22;
            this.clearAircraftsFilterButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearAircraftsFilterButton.ImageOptions.SvgImage")));
            this.clearAircraftsFilterButton.Name = "clearAircraftsFilterButton";
            this.clearAircraftsFilterButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearAircraftsFilterButton_ItemClick);
            // 
            // ribbonPageHome
            // 
            this.ribbonPageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageHome.Name = "ribbonPageHome";
            this.ribbonPageHome.Text = "Aircrafts";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.countryComboBox);
            this.ribbonPageGroup1.ItemLinks.Add(this.typeComboBox);
            this.ribbonPageGroup1.ItemLinks.Add(this.filterEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.categoryMenu);
            this.ribbonPageGroup1.ItemLinks.Add(this.clearAircraftsFilterButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Filter";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 730);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1022, 37);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // aircraftsListPanel1
            // 
            this.aircraftsListPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aircraftsListPanel1.Location = new System.Drawing.Point(16, 8);
            this.aircraftsListPanel1.Name = "aircraftsListPanel1";
            this.aircraftsListPanel1.Size = new System.Drawing.Size(990, 513);
            this.aircraftsListPanel1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.aircraftsListPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 201);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.panelControl1.Size = new System.Drawing.Size(1022, 529);
            this.panelControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 767);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Military Assets Database";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRepositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private Views.AircraftsListPanel aircraftsListPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarEditItem countryComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox countryRepositoryItem;
        private DevExpress.XtraBars.BarEditItem typeComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox typeRepositoryItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarEditItem filterEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarSubItem categoryMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraBars.BarButtonItem categoryCheckAllButton;
        private DevExpress.XtraBars.BarCheckItem categoryFixedWingCheck;
        private DevExpress.XtraBars.BarCheckItem categoryFixedWingCarrierCapableCheck;
        private DevExpress.XtraBars.BarCheckItem categoryHelicopterCheck;
        private DevExpress.XtraBars.BarCheckItem categoryTiltrotorCheck;
        private DevExpress.XtraBars.BarCheckItem categoryAirshipCheck;
        private DevExpress.XtraBars.BarCheckItem categorySeaplaneCheck;
        private DevExpress.XtraBars.BarCheckItem categoryAmphibianCheck;
        private DevExpress.XtraBars.BarButtonItem clearAircraftsFilterButton;
    }
}

