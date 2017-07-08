Partial Class FrmMenu
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.ribbonControl = New DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2()
        Me.barActionContainerViewsHistoryNavigation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerViewsHistoryNavigation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerObjectsCreation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerObjectsCreation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerFile = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFile = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerSave = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerSave = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerPrint = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerPrint = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerEdit = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerEdit = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerUndoRedo = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerUndoRedo = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerOpenObject = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerOpenObject = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerExport = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerExport = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerRecordEdit = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerRecordEdit = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerWorkflow = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerWorkflow = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerView = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerView = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerReports = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerReports = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerDefault = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerDefault = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerPanels = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerPanels = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerRecordsNavigation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerRecordsNavigation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerFilters = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFilters = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerSearch = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerSearch = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerFullTextSearch = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFullTextSearch = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerViewsNavigation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerViewsNavigation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerWindows = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerWindows = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerTools = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerTools = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerOptions = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerOptions = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerDiagnostic = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerDiagnostic = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerExit = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerExit = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerAbout = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerAbout = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerMenu = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerMenu = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerNotifications = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerNotifications = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.ribbonChooseSkinActionControl = New DevExpress.ExpressApp.Win.Templates.Ribbon.ActionControls.RibbonChooseSkinActionControl()
        Me.ribbonGallerySkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.applicationMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.mainBarAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barMdiChildrenListItem = New DevExpress.XtraBars.BarDockingMenuItem()
        Me.barSubItemPanels = New DevExpress.XtraBars.BarSubItem()
        Me.barContainerStatusMessages = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.BarEditItem4 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.BarEditItem5 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.dockPanelNavigation = New DevExpress.XtraBars.Docking.DockPanel()
        Me.dockPanelNavigation_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.navigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer()
        Me.viewSitePanel = New DevExpress.XtraEditors.PanelControl()
        Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.noDocumentsView = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
        Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.nativeMdiView = New DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(Me.components)
        Me.viewSiteManager = New DevExpress.ExpressApp.Win.Templates.ViewSiteManager(Me.components)
        Me.modelSynchronizationManager = New DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager(Me.components)
        Me.formStateModelSynchronizer = New DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(Me.components)
        Me.templateContextMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerViewsHistoryNavigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerObjectsCreation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerUndoRedo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerOpenObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerRecordEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerWorkflow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerPanels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerRecordsNavigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerFullTextSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerViewsNavigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerTools, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerDiagnostic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonChooseSkinActionControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.applicationMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainBarAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockPanelNavigation.SuspendLayout()
        Me.dockPanelNavigation_Container.SuspendLayout()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noDocumentsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nativeMdiView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.templateContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerViewsHistoryNavigation)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerObjectsCreation)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerFile)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerSave)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerPrint)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerEdit)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerUndoRedo)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerOpenObject)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerExport)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerRecordEdit)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerWorkflow)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerView)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerReports)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerDefault)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerPanels)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerRecordsNavigation)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerFilters)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerSearch)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerFullTextSearch)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerViewsNavigation)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerWindows)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerTools)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerOptions)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerDiagnostic)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerExit)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerAbout)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerMenu)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerNotifications)
        Me.ribbonControl.ActionControls.Add(Me.ribbonChooseSkinActionControl)
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.applicationMenu
        Me.ribbonControl.AutoHideEmptyItems = True
        Me.ribbonControl.BackColor = System.Drawing.Color.White
        Me.ribbonControl.Controller = Me.mainBarAndDockingController
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.barMdiChildrenListItem, Me.barSubItemPanels, Me.barContainerViewsHistoryNavigation, Me.barContainerEdit, Me.barContainerUndoRedo, Me.barContainerView, Me.barContainerReports, Me.barContainerObjectsCreation, Me.barContainerFile, Me.barContainerSave, Me.barContainerPrint, Me.barContainerOpenObject, Me.barContainerRecordEdit, Me.barContainerWorkflow, Me.barContainerExport, Me.barContainerDefault, Me.barContainerPanels, Me.barContainerRecordsNavigation, Me.barContainerFilters, Me.barContainerSearch, Me.barContainerFullTextSearch, Me.barContainerViewsNavigation, Me.barContainerWindows, Me.barContainerTools, Me.barContainerOptions, Me.barContainerDiagnostic, Me.barContainerExit, Me.barContainerAbout, Me.barContainerMenu, Me.barContainerNotifications, Me.barContainerStatusMessages, Me.ribbonGallerySkins, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem6, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarEditItem1, Me.BarEditItem2, Me.BarEditItem3, Me.BarEditItem4, Me.BarEditItem5})
        resources.ApplyResources(Me.ribbonControl, "ribbonControl")
        Me.ribbonControl.MaxItemId = 37
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemTimeEdit1, Me.RepositoryItemTimeEdit2, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2, Me.RepositoryItemSpinEdit3})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        '
        'barActionContainerViewsHistoryNavigation
        '
        Me.barActionContainerViewsHistoryNavigation.ActionCategory = "ViewsHistoryNavigation"
        Me.barActionContainerViewsHistoryNavigation.BarContainerItem = Me.barContainerViewsHistoryNavigation
        Me.barActionContainerViewsHistoryNavigation.IsMenuMode = True
        '
        'barContainerViewsHistoryNavigation
        '
        resources.ApplyResources(Me.barContainerViewsHistoryNavigation, "barContainerViewsHistoryNavigation")
        Me.barContainerViewsHistoryNavigation.Id = 35
        Me.barContainerViewsHistoryNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerViewsHistoryNavigation.Name = "barContainerViewsHistoryNavigation"
        '
        'barActionContainerObjectsCreation
        '
        Me.barActionContainerObjectsCreation.ActionCategory = "ObjectsCreation"
        Me.barActionContainerObjectsCreation.BarContainerItem = Me.barContainerObjectsCreation
        '
        'barContainerObjectsCreation
        '
        resources.ApplyResources(Me.barContainerObjectsCreation, "barContainerObjectsCreation")
        Me.barContainerObjectsCreation.Id = 18
        Me.barContainerObjectsCreation.MergeOrder = 1
        Me.barContainerObjectsCreation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerObjectsCreation.Name = "barContainerObjectsCreation"
        '
        'barActionContainerFile
        '
        Me.barActionContainerFile.ActionCategory = "File"
        Me.barActionContainerFile.BarContainerItem = Me.barContainerFile
        '
        'barContainerFile
        '
        resources.ApplyResources(Me.barContainerFile, "barContainerFile")
        Me.barContainerFile.Id = 5
        Me.barContainerFile.MergeOrder = 2
        Me.barContainerFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFile.Name = "barContainerFile"
        '
        'barActionContainerSave
        '
        Me.barActionContainerSave.ActionCategory = "Save"
        Me.barActionContainerSave.BarContainerItem = Me.barContainerSave
        '
        'barContainerSave
        '
        resources.ApplyResources(Me.barContainerSave, "barContainerSave")
        Me.barContainerSave.Id = 8
        Me.barContainerSave.MergeOrder = 7
        Me.barContainerSave.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerSave.Name = "barContainerSave"
        '
        'barActionContainerPrint
        '
        Me.barActionContainerPrint.ActionCategory = "Print"
        Me.barActionContainerPrint.BarContainerItem = Me.barContainerPrint
        '
        'barContainerPrint
        '
        resources.ApplyResources(Me.barContainerPrint, "barContainerPrint")
        Me.barContainerPrint.Id = 6
        Me.barContainerPrint.MergeOrder = 11
        Me.barContainerPrint.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerPrint.Name = "barContainerPrint"
        '
        'barActionContainerEdit
        '
        Me.barActionContainerEdit.ActionCategory = "Edit"
        Me.barActionContainerEdit.BarContainerItem = Me.barContainerEdit
        '
        'barContainerEdit
        '
        resources.ApplyResources(Me.barContainerEdit, "barContainerEdit")
        Me.barContainerEdit.Id = 9
        Me.barContainerEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerEdit.Name = "barContainerEdit"
        '
        'barActionContainerUndoRedo
        '
        Me.barActionContainerUndoRedo.ActionCategory = "UndoRedo"
        Me.barActionContainerUndoRedo.BarContainerItem = Me.barContainerUndoRedo
        '
        'barContainerUndoRedo
        '
        resources.ApplyResources(Me.barContainerUndoRedo, "barContainerUndoRedo")
        Me.barContainerUndoRedo.Id = 10
        Me.barContainerUndoRedo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerUndoRedo.Name = "barContainerUndoRedo"
        '
        'barActionContainerOpenObject
        '
        Me.barActionContainerOpenObject.ActionCategory = "OpenObject"
        Me.barActionContainerOpenObject.BarContainerItem = Me.barContainerOpenObject
        '
        'barContainerOpenObject
        '
        resources.ApplyResources(Me.barContainerOpenObject, "barContainerOpenObject")
        Me.barContainerOpenObject.Id = 9
        Me.barContainerOpenObject.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerOpenObject.Name = "barContainerOpenObject"
        '
        'barActionContainerExport
        '
        Me.barActionContainerExport.ActionCategory = "Export"
        Me.barActionContainerExport.BarContainerItem = Me.barContainerExport
        '
        'barContainerExport
        '
        resources.ApplyResources(Me.barContainerExport, "barContainerExport")
        Me.barContainerExport.Id = 7
        Me.barContainerExport.MergeOrder = 10
        Me.barContainerExport.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerExport.Name = "barContainerExport"
        '
        'barActionContainerRecordEdit
        '
        Me.barActionContainerRecordEdit.ActionCategory = "RecordEdit"
        Me.barActionContainerRecordEdit.BarContainerItem = Me.barContainerRecordEdit
        '
        'barContainerRecordEdit
        '
        resources.ApplyResources(Me.barContainerRecordEdit, "barContainerRecordEdit")
        Me.barContainerRecordEdit.Id = 9
        Me.barContainerRecordEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerRecordEdit.Name = "barContainerRecordEdit"
        '
        'barActionContainerWorkflow
        '
        Me.barActionContainerWorkflow.ActionCategory = "Workflow"
        Me.barActionContainerWorkflow.BarContainerItem = Me.barContainerWorkflow
        '
        'barContainerWorkflow
        '
        resources.ApplyResources(Me.barContainerWorkflow, "barContainerWorkflow")
        Me.barContainerWorkflow.Id = 9
        Me.barContainerWorkflow.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerWorkflow.Name = "barContainerWorkflow"
        '
        'barActionContainerView
        '
        Me.barActionContainerView.ActionCategory = "View"
        Me.barActionContainerView.BarContainerItem = Me.barContainerView
        '
        'barContainerView
        '
        resources.ApplyResources(Me.barContainerView, "barContainerView")
        Me.barContainerView.Id = 12
        Me.barContainerView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerView.Name = "barContainerView"
        '
        'barActionContainerReports
        '
        Me.barActionContainerReports.ActionCategory = "Reports"
        Me.barActionContainerReports.BarContainerItem = Me.barContainerReports
        '
        'barContainerReports
        '
        resources.ApplyResources(Me.barContainerReports, "barContainerReports")
        Me.barContainerReports.Id = 11
        Me.barContainerReports.MergeOrder = 12
        Me.barContainerReports.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerReports.Name = "barContainerReports"
        '
        'barActionContainerDefault
        '
        Me.barActionContainerDefault.ActionCategory = "Default"
        Me.barActionContainerDefault.BarContainerItem = Me.barContainerDefault
        '
        'barContainerDefault
        '
        resources.ApplyResources(Me.barContainerDefault, "barContainerDefault")
        Me.barContainerDefault.Id = 50
        Me.barContainerDefault.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerDefault.Name = "barContainerDefault"
        '
        'barActionContainerPanels
        '
        Me.barActionContainerPanels.ActionCategory = "Panels"
        Me.barActionContainerPanels.BarContainerItem = Me.barContainerPanels
        Me.barActionContainerPanels.IsMenuMode = True
        '
        'barContainerPanels
        '
        resources.ApplyResources(Me.barContainerPanels, "barContainerPanels")
        Me.barContainerPanels.Id = 16
        Me.barContainerPanels.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerPanels.Name = "barContainerPanels"
        '
        'barActionContainerRecordsNavigation
        '
        Me.barActionContainerRecordsNavigation.ActionCategory = "RecordsNavigation"
        Me.barActionContainerRecordsNavigation.BarContainerItem = Me.barContainerRecordsNavigation
        '
        'barContainerRecordsNavigation
        '
        resources.ApplyResources(Me.barContainerRecordsNavigation, "barContainerRecordsNavigation")
        Me.barContainerRecordsNavigation.Id = 10
        Me.barContainerRecordsNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerRecordsNavigation.Name = "barContainerRecordsNavigation"
        '
        'barActionContainerFilters
        '
        Me.barActionContainerFilters.ActionCategory = "Filters"
        Me.barActionContainerFilters.BarContainerItem = Me.barContainerFilters
        '
        'barContainerFilters
        '
        resources.ApplyResources(Me.barContainerFilters, "barContainerFilters")
        Me.barContainerFilters.Id = 26
        Me.barContainerFilters.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFilters.Name = "barContainerFilters"
        '
        'barActionContainerSearch
        '
        Me.barActionContainerSearch.ActionCategory = "Search"
        Me.barActionContainerSearch.BarContainerItem = Me.barContainerSearch
        '
        'barContainerSearch
        '
        resources.ApplyResources(Me.barContainerSearch, "barContainerSearch")
        Me.barContainerSearch.Id = 11
        Me.barContainerSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerSearch.Name = "barContainerSearch"
        '
        'barActionContainerFullTextSearch
        '
        Me.barActionContainerFullTextSearch.ActionCategory = "FullTextSearch"
        Me.barActionContainerFullTextSearch.BarContainerItem = Me.barContainerFullTextSearch
        '
        'barContainerFullTextSearch
        '
        resources.ApplyResources(Me.barContainerFullTextSearch, "barContainerFullTextSearch")
        Me.barContainerFullTextSearch.Id = 12
        Me.barContainerFullTextSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFullTextSearch.Name = "barContainerFullTextSearch"
        '
        'barActionContainerViewsNavigation
        '
        Me.barActionContainerViewsNavigation.ActionCategory = "ViewsNavigation"
        Me.barActionContainerViewsNavigation.BarContainerItem = Me.barContainerViewsNavigation
        '
        'barContainerViewsNavigation
        '
        resources.ApplyResources(Me.barContainerViewsNavigation, "barContainerViewsNavigation")
        Me.barContainerViewsNavigation.Id = 14
        Me.barContainerViewsNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerViewsNavigation.Name = "barContainerViewsNavigation"
        '
        'barActionContainerWindows
        '
        Me.barActionContainerWindows.ActionCategory = "Windows"
        Me.barActionContainerWindows.BarContainerItem = Me.barContainerWindows
        '
        'barContainerWindows
        '
        resources.ApplyResources(Me.barContainerWindows, "barContainerWindows")
        Me.barContainerWindows.Id = 16
        Me.barContainerWindows.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerWindows.Name = "barContainerWindows"
        '
        'barActionContainerTools
        '
        Me.barActionContainerTools.ActionCategory = "Tools"
        Me.barActionContainerTools.BarContainerItem = Me.barContainerTools
        Me.barActionContainerTools.IsMenuMode = True
        '
        'barContainerTools
        '
        resources.ApplyResources(Me.barContainerTools, "barContainerTools")
        Me.barContainerTools.Id = 13
        Me.barContainerTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerTools.Name = "barContainerTools"
        '
        'barActionContainerOptions
        '
        Me.barActionContainerOptions.ActionCategory = "Options"
        Me.barActionContainerOptions.BarContainerItem = Me.barContainerOptions
        Me.barActionContainerOptions.IsMenuMode = True
        '
        'barContainerOptions
        '
        resources.ApplyResources(Me.barContainerOptions, "barContainerOptions")
        Me.barContainerOptions.Id = 14
        Me.barContainerOptions.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerOptions.Name = "barContainerOptions"
        '
        'barActionContainerDiagnostic
        '
        Me.barActionContainerDiagnostic.ActionCategory = "Diagnostic"
        Me.barActionContainerDiagnostic.BarContainerItem = Me.barContainerDiagnostic
        Me.barActionContainerDiagnostic.IsMenuMode = True
        '
        'barContainerDiagnostic
        '
        resources.ApplyResources(Me.barContainerDiagnostic, "barContainerDiagnostic")
        Me.barContainerDiagnostic.Id = 16
        Me.barContainerDiagnostic.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerDiagnostic.Name = "barContainerDiagnostic"
        '
        'barActionContainerExit
        '
        Me.barActionContainerExit.ActionCategory = "Exit"
        Me.barActionContainerExit.BarContainerItem = Me.barContainerExit
        '
        'barContainerExit
        '
        resources.ApplyResources(Me.barContainerExit, "barContainerExit")
        Me.barContainerExit.Id = 8
        Me.barContainerExit.MergeOrder = 900
        Me.barContainerExit.Name = "barContainerExit"
        '
        'barActionContainerAbout
        '
        Me.barActionContainerAbout.ActionCategory = "About"
        Me.barActionContainerAbout.BarContainerItem = Me.barContainerAbout
        Me.barActionContainerAbout.IsMenuMode = True
        '
        'barContainerAbout
        '
        resources.ApplyResources(Me.barContainerAbout, "barContainerAbout")
        Me.barContainerAbout.Id = 15
        Me.barContainerAbout.MergeOrder = 15
        Me.barContainerAbout.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerAbout.Name = "barContainerAbout"
        '
        'barActionContainerMenu
        '
        Me.barActionContainerMenu.ActionCategory = "Menu"
        Me.barActionContainerMenu.BarContainerItem = Me.barContainerMenu
        '
        'barContainerMenu
        '
        resources.ApplyResources(Me.barContainerMenu, "barContainerMenu")
        Me.barContainerMenu.Id = 7
        Me.barContainerMenu.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerMenu.Name = "barContainerMenu"
        '
        'barActionContainerNotifications
        '
        Me.barActionContainerNotifications.ActionCategory = "Notifications"
        Me.barActionContainerNotifications.BarContainerItem = Me.barContainerNotifications
        '
        'barContainerNotifications
        '
        Me.barContainerNotifications.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        resources.ApplyResources(Me.barContainerNotifications, "barContainerNotifications")
        Me.barContainerNotifications.Id = 28
        Me.barContainerNotifications.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerNotifications.Name = "barContainerNotifications"
        '
        'ribbonChooseSkinActionControl
        '
        Me.ribbonChooseSkinActionControl.ActionId = "ChooseSkin"
        Me.ribbonChooseSkinActionControl.BarItem = Me.ribbonGallerySkins
        '
        'ribbonGallerySkins
        '
        resources.ApplyResources(Me.ribbonGallerySkins, "ribbonGallerySkins")
        Me.ribbonGallerySkins.Id = 1
        Me.ribbonGallerySkins.Name = "ribbonGallerySkins"
        '
        'applicationMenu
        '
        Me.applicationMenu.ItemLinks.Add(Me.barContainerObjectsCreation, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerFile, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerSave, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerExport, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerPrint, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerReports, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerAbout, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerExit, True)
        Me.applicationMenu.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText
        Me.applicationMenu.Name = "applicationMenu"
        Me.applicationMenu.Ribbon = Me.ribbonControl
        '
        'mainBarAndDockingController
        '
        Me.mainBarAndDockingController.PropertiesBar.AllowLinkLighting = False
        Me.mainBarAndDockingController.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.mainBarAndDockingController.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'barMdiChildrenListItem
        '
        resources.ApplyResources(Me.barMdiChildrenListItem, "barMdiChildrenListItem")
        Me.barMdiChildrenListItem.Id = 37
        Me.barMdiChildrenListItem.Name = "barMdiChildrenListItem"
        '
        'barSubItemPanels
        '
        resources.ApplyResources(Me.barSubItemPanels, "barSubItemPanels")
        Me.barSubItemPanels.Id = 7
        Me.barSubItemPanels.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerPanels, True)})
        Me.barSubItemPanels.Name = "barSubItemPanels"
        '
        'barContainerStatusMessages
        '
        resources.ApplyResources(Me.barContainerStatusMessages, "barContainerStatusMessages")
        Me.barContainerStatusMessages.Id = 27
        Me.barContainerStatusMessages.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerStatusMessages.Name = "barContainerStatusMessages"
        '
        'BarButtonItem1
        '
        resources.ApplyResources(Me.BarButtonItem1, "BarButtonItem1")
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 14
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem2
        '
        resources.ApplyResources(Me.BarButtonItem2, "BarButtonItem2")
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 15
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem3
        '
        resources.ApplyResources(Me.BarButtonItem3, "BarButtonItem3")
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 16
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem4
        '
        resources.ApplyResources(Me.BarButtonItem4, "BarButtonItem4")
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 17
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem6
        '
        resources.ApplyResources(Me.BarButtonItem6, "BarButtonItem6")
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 19
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem8
        '
        resources.ApplyResources(Me.BarButtonItem8, "BarButtonItem8")
        Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
        Me.BarButtonItem8.Id = 21
        Me.BarButtonItem8.Name = "BarButtonItem8"
        Me.BarButtonItem8.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem9
        '
        resources.ApplyResources(Me.BarButtonItem9, "BarButtonItem9")
        Me.BarButtonItem9.Glyph = CType(resources.GetObject("BarButtonItem9.Glyph"), System.Drawing.Image)
        Me.BarButtonItem9.Id = 24
        Me.BarButtonItem9.Name = "BarButtonItem9"
        Me.BarButtonItem9.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Edit = Me.RepositoryItemDateEdit2
        resources.ApplyResources(Me.BarEditItem1, "BarEditItem1")
        Me.BarEditItem1.Id = 28
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemDateEdit2
        '
        resources.ApplyResources(Me.RepositoryItemDateEdit2, "RepositoryItemDateEdit2")
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemDateEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemDateEdit2.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Edit = Me.RepositoryItemDateEdit3
        resources.ApplyResources(Me.BarEditItem2, "BarEditItem2")
        Me.BarEditItem2.Id = 29
        Me.BarEditItem2.Name = "BarEditItem2"
        '
        'RepositoryItemDateEdit3
        '
        resources.ApplyResources(Me.RepositoryItemDateEdit3, "RepositoryItemDateEdit3")
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemDateEdit3.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemDateEdit3.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'BarEditItem3
        '
        resources.ApplyResources(Me.BarEditItem3, "BarEditItem3")
        Me.BarEditItem3.Edit = Me.RepositoryItemSpinEdit1
        Me.BarEditItem3.Id = 30
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'RepositoryItemSpinEdit1
        '
        resources.ApplyResources(Me.RepositoryItemSpinEdit1, "RepositoryItemSpinEdit1")
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemSpinEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'BarEditItem4
        '
        resources.ApplyResources(Me.BarEditItem4, "BarEditItem4")
        Me.BarEditItem4.Edit = Me.RepositoryItemSpinEdit2
        Me.BarEditItem4.Id = 35
        Me.BarEditItem4.Name = "BarEditItem4"
        '
        'RepositoryItemSpinEdit2
        '
        resources.ApplyResources(Me.RepositoryItemSpinEdit2, "RepositoryItemSpinEdit2")
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemSpinEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'BarEditItem5
        '
        resources.ApplyResources(Me.BarEditItem5, "BarEditItem5")
        Me.BarEditItem5.Edit = Me.RepositoryItemSpinEdit3
        Me.BarEditItem5.Id = 36
        Me.BarEditItem5.Name = "BarEditItem5"
        '
        'RepositoryItemSpinEdit3
        '
        resources.ApplyResources(Me.RepositoryItemSpinEdit3, "RepositoryItemSpinEdit3")
        Me.RepositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemSpinEdit3.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemSpinEdit3.Name = "RepositoryItemSpinEdit3"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        resources.ApplyResources(Me.RibbonPage1, "RibbonPage1")
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarEditItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarEditItem2)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        resources.ApplyResources(Me.RibbonPageGroup1, "RibbonPageGroup1")
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        resources.ApplyResources(Me.RibbonPageGroup2, "RibbonPageGroup2")
        Me.RibbonPageGroup2.Visible = False
        '
        'RepositoryItemComboBox1
        '
        resources.ApplyResources(Me.RepositoryItemComboBox1, "RepositoryItemComboBox1")
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        resources.ApplyResources(Me.RepositoryItemComboBox2, "RepositoryItemComboBox2")
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemTimeEdit1
        '
        resources.ApplyResources(Me.RepositoryItemTimeEdit1, "RepositoryItemTimeEdit1")
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemTimeEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemTimeEdit2
        '
        resources.ApplyResources(Me.RepositoryItemTimeEdit2, "RepositoryItemTimeEdit2")
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemTimeEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'RepositoryItemDateEdit1
        '
        resources.ApplyResources(Me.RepositoryItemDateEdit1, "RepositoryItemDateEdit1")
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemDateEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemDateEdit1.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.barContainerStatusMessages)
        Me.ribbonStatusBar.ItemLinks.Add(Me.barContainerNotifications)
        resources.ApplyResources(Me.ribbonStatusBar, "ribbonStatusBar")
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        '
        'dockManager
        '
        Me.dockManager.Controller = Me.mainBarAndDockingController
        Me.dockManager.Form = Me
        Me.dockManager.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelNavigation})
        Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2", "DevExpress.XtraBars.Ribbon.RibbonStatusBar"})
        '
        'dockPanelNavigation
        '
        Me.dockPanelNavigation.Controls.Add(Me.dockPanelNavigation_Container)
        Me.dockPanelNavigation.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanelNavigation.FloatSize = New System.Drawing.Size(146, 428)
        Me.dockPanelNavigation.ID = New System.Guid("24977e30-0ea6-44aa-8fa4-9abaeb178b5e")
        resources.ApplyResources(Me.dockPanelNavigation, "dockPanelNavigation")
        Me.dockPanelNavigation.Name = "dockPanelNavigation"
        Me.dockPanelNavigation.Options.AllowDockBottom = False
        Me.dockPanelNavigation.Options.AllowDockTop = False
        Me.dockPanelNavigation.OriginalSize = New System.Drawing.Size(200, 200)
        Me.dockPanelNavigation.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanelNavigation.SavedIndex = 0
        Me.dockPanelNavigation.TabStop = False
        Me.dockPanelNavigation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'dockPanelNavigation_Container
        '
        Me.dockPanelNavigation_Container.Controls.Add(Me.navigation)
        resources.ApplyResources(Me.dockPanelNavigation_Container, "dockPanelNavigation_Container")
        Me.dockPanelNavigation_Container.Name = "dockPanelNavigation_Container"
        '
        'navigation
        '
        resources.ApplyResources(Me.navigation, "navigation")
        Me.navigation.Model = Nothing
        Me.navigation.Name = "navigation"
        '
        'viewSitePanel
        '
        Me.viewSitePanel.Appearance.BackColor = CType(resources.GetObject("viewSitePanel.Appearance.BackColor"), System.Drawing.Color)
        Me.viewSitePanel.Appearance.Options.UseBackColor = True
        Me.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        resources.ApplyResources(Me.viewSitePanel, "viewSitePanel")
        Me.viewSitePanel.Name = "viewSitePanel"
        '
        'documentManager
        '
        Me.documentManager.BarAndDockingController = Me.mainBarAndDockingController
        Me.documentManager.ClientControl = Me.viewSitePanel
        Me.documentManager.MenuManager = Me.ribbonControl.Manager
        Me.documentManager.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.[False]
        Me.documentManager.View = Me.noDocumentsView
        Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.noDocumentsView, Me.tabbedView, Me.nativeMdiView})
        '
        'tabbedView
        '
        Me.tabbedView.DocumentProperties.MaxTabWidth = 150
        Me.tabbedView.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
        Me.tabbedView.OptionsLayout.PropertiesRestoreMode = DevExpress.XtraBars.Docking2010.Views.PropertiesRestoreMode.None
        '
        'nativeMdiView
        '
        Me.nativeMdiView.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
        '
        'viewSiteManager
        '
        Me.viewSiteManager.ViewSiteControl = Me.viewSitePanel
        '
        'modelSynchronizationManager
        '
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.formStateModelSynchronizer)
        '
        'formStateModelSynchronizer
        '
        Me.formStateModelSynchronizer.Form = Me
        '
        'templateContextMenu
        '
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerObjectsCreation, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerSave, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerEdit, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerRecordEdit, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerOpenObject, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerPrint, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerView, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerExport, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerMenu, True)
        Me.templateContextMenu.Name = "templateContextMenu"
        Me.templateContextMenu.Ribbon = Me.ribbonControl
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader
        Me.XtraTabbedMdiManager1.Controller = Me.mainBarAndDockingController
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'FrmMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.viewSitePanel)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.IsMdiContainer = True
        Me.Name = "FrmMenu"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerViewsHistoryNavigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerObjectsCreation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerUndoRedo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerOpenObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerRecordEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerWorkflow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerPanels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerRecordsNavigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerFullTextSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerViewsNavigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerWindows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerTools, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerDiagnostic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonChooseSkinActionControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.applicationMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainBarAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockPanelNavigation.ResumeLayout(False)
        Me.dockPanelNavigation_Container.ResumeLayout(False)
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noDocumentsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nativeMdiView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.templateContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private mainBarAndDockingController As DevExpress.XtraBars.BarAndDockingController
    Private dockManager As DevExpress.XtraBars.Docking.DockManager
    Private ribbonControl As DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2
    Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private dockPanelNavigation As DevExpress.XtraBars.Docking.DockPanel
    Private dockPanelNavigation_Container As DevExpress.XtraBars.Docking.ControlContainer
    Private viewSitePanel As DevExpress.XtraEditors.PanelControl
    Private barSubItemPanels As DevExpress.XtraBars.BarSubItem
    Private applicationMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private barContainerViewsHistoryNavigation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerObjectsCreation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerFile As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerSave As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerPrint As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerEdit As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerUndoRedo As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerOpenObject As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerExport As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerRecordEdit As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerWorkflow As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerView As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerReports As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerDefault As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerPanels As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerRecordsNavigation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerFilters As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerSearch As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerFullTextSearch As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerViewsNavigation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerWindows As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerTools As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerOptions As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerDiagnostic As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerExit As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerAbout As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerMenu As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerNotifications As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerStatusMessages As DevExpress.XtraBars.BarLinkContainerExItem
    Private ribbonGallerySkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private barActionContainerViewsNavigation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerViewsHistoryNavigation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerObjectsCreation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerFile As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerSave As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerPrint As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerEdit As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerUndoRedo As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerOpenObject As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerExport As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerRecordEdit As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerWorkflow As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerDefault As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerPanels As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerRecordsNavigation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerFilters As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerSearch As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerFullTextSearch As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerWindows As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerTools As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerOptions As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerDiagnostic As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerExit As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerView As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerReports As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerAbout As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerMenu As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerNotifications As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private ribbonChooseSkinActionControl As DevExpress.ExpressApp.Win.Templates.Ribbon.ActionControls.RibbonChooseSkinActionControl
    Private navigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer
    Private barMdiChildrenListItem As DevExpress.XtraBars.BarDockingMenuItem
    Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
    Private noDocumentsView As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
    Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Private nativeMdiView As DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView
    Private viewSiteManager As DevExpress.ExpressApp.Win.Templates.ViewSiteManager
    Private modelSynchronizationManager As DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager
    Private formStateModelSynchronizer As DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer
    Private templateContextMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents BarEditItem4 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents BarEditItem5 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
