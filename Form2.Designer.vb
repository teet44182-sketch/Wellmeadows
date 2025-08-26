<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NINLabel As System.Windows.Forms.Label
        Dim Staff_NumberLabel As System.Windows.Forms.Label
        Dim F_NameLabel As System.Windows.Forms.Label
        Dim L_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim Salary_scaleLabel As System.Windows.Forms.Label
        Dim Paid_conditionLabel As System.Windows.Forms.Label
        Dim Hours_per_WeekLabel As System.Windows.Forms.Label
        Dim AllocatedWardLabel As System.Windows.Forms.Label
        Dim Qualification_typeLabel As System.Windows.Forms.Label
        Dim Grad_dateLabel As System.Windows.Forms.Label
        Dim InstitutionLabel As System.Windows.Forms.Label
        Dim Staff_NumberLabel1 As System.Windows.Forms.Label
        Dim PositionLabel1 As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim Finish_dateLabel As System.Windows.Forms.Label
        Dim OrganizationLabel As System.Windows.Forms.Label
        Dim Staff_NumberLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffForm))
        Me.WellmeadowsDataSet = New Wellmeadows.wellmeadowsDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Wellmeadows.wellmeadowsDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New Wellmeadows.wellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.QUALIFICATIONTableAdapter = New Wellmeadows.wellmeadowsDataSetTableAdapters.QUALIFICATIONTableAdapter()
        Me.WORK_EXPERIENCETableAdapter = New Wellmeadows.wellmeadowsDataSetTableAdapters.WORK_EXPERIENCETableAdapter()
        Me.StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtNIN = New System.Windows.Forms.TextBox()
        Me.txtStaffNo = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.Paid_conditionTextBox = New System.Windows.Forms.TextBox()
        Me.Hours_per_WeekTextBox = New System.Windows.Forms.TextBox()
        Me.AllocatedWardTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.QUALIFICATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Qualification_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Grad_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.WORK_EXPERIENCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionTextBox1 = New System.Windows.Forms.TextBox()
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Finish_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_NumberTextBox2 = New System.Windows.Forms.TextBox()
        NINLabel = New System.Windows.Forms.Label()
        Staff_NumberLabel = New System.Windows.Forms.Label()
        F_NameLabel = New System.Windows.Forms.Label()
        L_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Salary_scaleLabel = New System.Windows.Forms.Label()
        Paid_conditionLabel = New System.Windows.Forms.Label()
        Hours_per_WeekLabel = New System.Windows.Forms.Label()
        AllocatedWardLabel = New System.Windows.Forms.Label()
        Qualification_typeLabel = New System.Windows.Forms.Label()
        Grad_dateLabel = New System.Windows.Forms.Label()
        InstitutionLabel = New System.Windows.Forms.Label()
        Staff_NumberLabel1 = New System.Windows.Forms.Label()
        PositionLabel1 = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        Finish_dateLabel = New System.Windows.Forms.Label()
        OrganizationLabel = New System.Windows.Forms.Label()
        Staff_NumberLabel2 = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        CType(Me.QUALIFICATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORK_EXPERIENCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NINLabel
        '
        NINLabel.AutoSize = True
        NINLabel.Location = New System.Drawing.Point(113, 82)
        NINLabel.Name = "NINLabel"
        NINLabel.Size = New System.Drawing.Size(33, 16)
        NINLabel.TabIndex = 1
        NINLabel.Text = "NIN:"
        '
        'Staff_NumberLabel
        '
        Staff_NumberLabel.AutoSize = True
        Staff_NumberLabel.Location = New System.Drawing.Point(113, 110)
        Staff_NumberLabel.Name = "Staff_NumberLabel"
        Staff_NumberLabel.Size = New System.Drawing.Size(87, 16)
        Staff_NumberLabel.TabIndex = 3
        Staff_NumberLabel.Text = "Staff Number:"
        '
        'F_NameLabel
        '
        F_NameLabel.AutoSize = True
        F_NameLabel.Location = New System.Drawing.Point(113, 138)
        F_NameLabel.Name = "F_NameLabel"
        F_NameLabel.Size = New System.Drawing.Size(58, 16)
        F_NameLabel.TabIndex = 5
        F_NameLabel.Text = "F Name:"
        '
        'L_NameLabel
        '
        L_NameLabel.AutoSize = True
        L_NameLabel.Location = New System.Drawing.Point(113, 166)
        L_NameLabel.Name = "L_NameLabel"
        L_NameLabel.Size = New System.Drawing.Size(57, 16)
        L_NameLabel.TabIndex = 7
        L_NameLabel.Text = "L Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(113, 194)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(61, 16)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(113, 222)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(30, 16)
        TelLabel.TabIndex = 11
        TelLabel.Text = "Tel:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(113, 251)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(39, 16)
        DOBLabel.TabIndex = 13
        DOBLabel.Text = "DOB:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(113, 278)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(33, 16)
        SexLabel.TabIndex = 15
        SexLabel.Text = "Sex:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(113, 306)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(58, 16)
        PositionLabel.TabIndex = 17
        PositionLabel.Text = "Position:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(113, 334)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(49, 16)
        SalaryLabel.TabIndex = 19
        SalaryLabel.Text = "Salary:"
        '
        'Salary_scaleLabel
        '
        Salary_scaleLabel.AutoSize = True
        Salary_scaleLabel.Location = New System.Drawing.Point(113, 362)
        Salary_scaleLabel.Name = "Salary_scaleLabel"
        Salary_scaleLabel.Size = New System.Drawing.Size(85, 16)
        Salary_scaleLabel.TabIndex = 21
        Salary_scaleLabel.Text = "Salary scale:"
        '
        'Paid_conditionLabel
        '
        Paid_conditionLabel.AutoSize = True
        Paid_conditionLabel.Location = New System.Drawing.Point(113, 390)
        Paid_conditionLabel.Name = "Paid_conditionLabel"
        Paid_conditionLabel.Size = New System.Drawing.Size(95, 16)
        Paid_conditionLabel.TabIndex = 23
        Paid_conditionLabel.Text = "Paid condition:"
        '
        'Hours_per_WeekLabel
        '
        Hours_per_WeekLabel.AutoSize = True
        Hours_per_WeekLabel.Location = New System.Drawing.Point(113, 418)
        Hours_per_WeekLabel.Name = "Hours_per_WeekLabel"
        Hours_per_WeekLabel.Size = New System.Drawing.Size(108, 16)
        Hours_per_WeekLabel.TabIndex = 25
        Hours_per_WeekLabel.Text = "Hours per Week:"
        '
        'AllocatedWardLabel
        '
        AllocatedWardLabel.AutoSize = True
        AllocatedWardLabel.Location = New System.Drawing.Point(113, 446)
        AllocatedWardLabel.Name = "AllocatedWardLabel"
        AllocatedWardLabel.Size = New System.Drawing.Size(102, 16)
        AllocatedWardLabel.TabIndex = 27
        AllocatedWardLabel.Text = "allocated Ward:"
        '
        'Qualification_typeLabel
        '
        Qualification_typeLabel.AutoSize = True
        Qualification_typeLabel.Location = New System.Drawing.Point(487, 85)
        Qualification_typeLabel.Name = "Qualification_typeLabel"
        Qualification_typeLabel.Size = New System.Drawing.Size(112, 16)
        Qualification_typeLabel.TabIndex = 30
        Qualification_typeLabel.Text = "Qualification type:"
        '
        'Grad_dateLabel
        '
        Grad_dateLabel.AutoSize = True
        Grad_dateLabel.Location = New System.Drawing.Point(487, 114)
        Grad_dateLabel.Name = "Grad_dateLabel"
        Grad_dateLabel.Size = New System.Drawing.Size(70, 16)
        Grad_dateLabel.TabIndex = 32
        Grad_dateLabel.Text = "Grad date:"
        '
        'InstitutionLabel
        '
        InstitutionLabel.AutoSize = True
        InstitutionLabel.Location = New System.Drawing.Point(487, 141)
        InstitutionLabel.Name = "InstitutionLabel"
        InstitutionLabel.Size = New System.Drawing.Size(64, 16)
        InstitutionLabel.TabIndex = 34
        InstitutionLabel.Text = "Institution:"
        '
        'Staff_NumberLabel1
        '
        Staff_NumberLabel1.AutoSize = True
        Staff_NumberLabel1.Location = New System.Drawing.Point(487, 169)
        Staff_NumberLabel1.Name = "Staff_NumberLabel1"
        Staff_NumberLabel1.Size = New System.Drawing.Size(87, 16)
        Staff_NumberLabel1.TabIndex = 36
        Staff_NumberLabel1.Text = "Staff Number:"
        '
        'PositionLabel1
        '
        PositionLabel1.AutoSize = True
        PositionLabel1.Location = New System.Drawing.Point(487, 247)
        PositionLabel1.Name = "PositionLabel1"
        PositionLabel1.Size = New System.Drawing.Size(58, 16)
        PositionLabel1.TabIndex = 38
        PositionLabel1.Text = "Position:"
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.Location = New System.Drawing.Point(487, 276)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(67, 16)
        Start_dateLabel.TabIndex = 40
        Start_dateLabel.Text = "Start date:"
        '
        'Finish_dateLabel
        '
        Finish_dateLabel.AutoSize = True
        Finish_dateLabel.Location = New System.Drawing.Point(487, 304)
        Finish_dateLabel.Name = "Finish_dateLabel"
        Finish_dateLabel.Size = New System.Drawing.Size(75, 16)
        Finish_dateLabel.TabIndex = 42
        Finish_dateLabel.Text = "Finish date:"
        '
        'OrganizationLabel
        '
        OrganizationLabel.AutoSize = True
        OrganizationLabel.Location = New System.Drawing.Point(487, 331)
        OrganizationLabel.Name = "OrganizationLabel"
        OrganizationLabel.Size = New System.Drawing.Size(85, 16)
        OrganizationLabel.TabIndex = 44
        OrganizationLabel.Text = "Organization:"
        '
        'Staff_NumberLabel2
        '
        Staff_NumberLabel2.AutoSize = True
        Staff_NumberLabel2.Location = New System.Drawing.Point(487, 359)
        Staff_NumberLabel2.Name = "Staff_NumberLabel2"
        Staff_NumberLabel2.Size = New System.Drawing.Size(87, 16)
        Staff_NumberLabel2.TabIndex = 46
        Staff_NumberLabel2.Text = "Staff Number:"
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "wellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AllocateTableAdapter = Nothing
        Me.TableAdapterManager.AppointTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.InpatientTableAdapter = Nothing
        Me.TableAdapterManager.Local_DoctorTableAdapter = Nothing
        Me.TableAdapterManager.NEXT_OF_KINTableAdapter = Nothing
        Me.TableAdapterManager.OutpatientTableAdapter = Nothing
        Me.TableAdapterManager.Patient_MedicationTableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTableAdapter = Nothing
        Me.TableAdapterManager.Pharma_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.QUALIFICATIONTableAdapter = Me.QUALIFICATIONTableAdapter
        Me.TableAdapterManager.RequisitionTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmeadows.wellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WORK_EXPERIENCETableAdapter = Me.WORK_EXPERIENCETableAdapter
        '
        'QUALIFICATIONTableAdapter
        '
        Me.QUALIFICATIONTableAdapter.ClearBeforeFill = True
        '
        'WORK_EXPERIENCETableAdapter
        '
        Me.WORK_EXPERIENCETableAdapter.ClearBeforeFill = True
        '
        'StaffBindingNavigator
        '
        Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
        Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
        Me.StaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
        Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffBindingNavigator.Size = New System.Drawing.Size(906, 31)
        Me.StaffBindingNavigator.TabIndex = 0
        Me.StaffBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'StaffBindingNavigatorSaveItem
        '
        Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem"
        Me.StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtNIN
        '
        Me.txtNIN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "NIN", True))
        Me.txtNIN.Location = New System.Drawing.Point(227, 79)
        Me.txtNIN.Name = "txtNIN"
        Me.txtNIN.Size = New System.Drawing.Size(200, 22)
        Me.txtNIN.TabIndex = 2
        '
        'txtStaffNo
        '
        Me.txtStaffNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff_Number", True))
        Me.txtStaffNo.Location = New System.Drawing.Point(227, 107)
        Me.txtStaffNo.Name = "txtStaffNo"
        Me.txtStaffNo.Size = New System.Drawing.Size(200, 22)
        Me.txtStaffNo.TabIndex = 4
        '
        'txtFName
        '
        Me.txtFName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "F_Name", True))
        Me.txtFName.Location = New System.Drawing.Point(227, 135)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(200, 22)
        Me.txtFName.TabIndex = 6
        '
        'txtLName
        '
        Me.txtLName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "L_Name", True))
        Me.txtLName.Location = New System.Drawing.Point(227, 163)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(200, 22)
        Me.txtLName.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(227, 191)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 22)
        Me.txtAddress.TabIndex = 10
        '
        'txtTel
        '
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Tel", True))
        Me.txtTel.Location = New System.Drawing.Point(226, 219)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(200, 22)
        Me.txtTel.TabIndex = 12
        '
        'txtDOB
        '
        Me.txtDOB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "DOB", True))
        Me.txtDOB.Location = New System.Drawing.Point(227, 247)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(200, 22)
        Me.txtDOB.TabIndex = 14
        '
        'txtSex
        '
        Me.txtSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Sex", True))
        Me.txtSex.Location = New System.Drawing.Point(227, 275)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(200, 22)
        Me.txtSex.TabIndex = 16
        '
        'txtPosition
        '
        Me.txtPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.txtPosition.Location = New System.Drawing.Point(227, 303)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(200, 22)
        Me.txtPosition.TabIndex = 18
        '
        'txtSalary
        '
        Me.txtSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary", True))
        Me.txtSalary.Location = New System.Drawing.Point(227, 331)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(200, 22)
        Me.txtSalary.TabIndex = 20
        '
        'txtScale
        '
        Me.txtScale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary_scale", True))
        Me.txtScale.Location = New System.Drawing.Point(227, 359)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(200, 22)
        Me.txtScale.TabIndex = 22
        '
        'Paid_conditionTextBox
        '
        Me.Paid_conditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Paid_condition", True))
        Me.Paid_conditionTextBox.Location = New System.Drawing.Point(227, 387)
        Me.Paid_conditionTextBox.Name = "Paid_conditionTextBox"
        Me.Paid_conditionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Paid_conditionTextBox.TabIndex = 24
        '
        'Hours_per_WeekTextBox
        '
        Me.Hours_per_WeekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Hours_per_Week", True))
        Me.Hours_per_WeekTextBox.Location = New System.Drawing.Point(227, 415)
        Me.Hours_per_WeekTextBox.Name = "Hours_per_WeekTextBox"
        Me.Hours_per_WeekTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Hours_per_WeekTextBox.TabIndex = 26
        '
        'AllocatedWardTextBox
        '
        Me.AllocatedWardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "allocatedWard", True))
        Me.AllocatedWardTextBox.Location = New System.Drawing.Point(227, 443)
        Me.AllocatedWardTextBox.Name = "AllocatedWardTextBox"
        Me.AllocatedWardTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AllocatedWardTextBox.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'QUALIFICATIONBindingSource
        '
        Me.QUALIFICATIONBindingSource.DataMember = "QUALIFICATION"
        Me.QUALIFICATIONBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Qualification_typeTextBox
        '
        Me.Qualification_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QUALIFICATIONBindingSource, "Qualification_type", True))
        Me.Qualification_typeTextBox.Location = New System.Drawing.Point(605, 82)
        Me.Qualification_typeTextBox.Name = "Qualification_typeTextBox"
        Me.Qualification_typeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Qualification_typeTextBox.TabIndex = 31
        '
        'Grad_dateDateTimePicker
        '
        Me.Grad_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QUALIFICATIONBindingSource, "Grad_date", True))
        Me.Grad_dateDateTimePicker.Location = New System.Drawing.Point(605, 110)
        Me.Grad_dateDateTimePicker.Name = "Grad_dateDateTimePicker"
        Me.Grad_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Grad_dateDateTimePicker.TabIndex = 33
        '
        'InstitutionTextBox
        '
        Me.InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QUALIFICATIONBindingSource, "Institution", True))
        Me.InstitutionTextBox.Location = New System.Drawing.Point(605, 138)
        Me.InstitutionTextBox.Name = "InstitutionTextBox"
        Me.InstitutionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.InstitutionTextBox.TabIndex = 35
        '
        'Staff_NumberTextBox1
        '
        Me.Staff_NumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QUALIFICATIONBindingSource, "Staff_Number", True))
        Me.Staff_NumberTextBox1.Location = New System.Drawing.Point(605, 166)
        Me.Staff_NumberTextBox1.Name = "Staff_NumberTextBox1"
        Me.Staff_NumberTextBox1.Size = New System.Drawing.Size(200, 22)
        Me.Staff_NumberTextBox1.TabIndex = 37
        '
        'WORK_EXPERIENCEBindingSource
        '
        Me.WORK_EXPERIENCEBindingSource.DataMember = "WORK_EXPERIENCE"
        Me.WORK_EXPERIENCEBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'PositionTextBox1
        '
        Me.PositionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORK_EXPERIENCEBindingSource, "Position", True))
        Me.PositionTextBox1.Location = New System.Drawing.Point(580, 244)
        Me.PositionTextBox1.Name = "PositionTextBox1"
        Me.PositionTextBox1.Size = New System.Drawing.Size(200, 22)
        Me.PositionTextBox1.TabIndex = 39
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WORK_EXPERIENCEBindingSource, "Start_date", True))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(580, 272)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Start_dateDateTimePicker.TabIndex = 41
        '
        'Finish_dateDateTimePicker
        '
        Me.Finish_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WORK_EXPERIENCEBindingSource, "Finish_date", True))
        Me.Finish_dateDateTimePicker.Location = New System.Drawing.Point(580, 300)
        Me.Finish_dateDateTimePicker.Name = "Finish_dateDateTimePicker"
        Me.Finish_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Finish_dateDateTimePicker.TabIndex = 43
        '
        'OrganizationTextBox
        '
        Me.OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORK_EXPERIENCEBindingSource, "Organization", True))
        Me.OrganizationTextBox.Location = New System.Drawing.Point(580, 328)
        Me.OrganizationTextBox.Name = "OrganizationTextBox"
        Me.OrganizationTextBox.Size = New System.Drawing.Size(200, 22)
        Me.OrganizationTextBox.TabIndex = 45
        '
        'Staff_NumberTextBox2
        '
        Me.Staff_NumberTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORK_EXPERIENCEBindingSource, "Staff_Number", True))
        Me.Staff_NumberTextBox2.Location = New System.Drawing.Point(580, 356)
        Me.Staff_NumberTextBox2.Name = "Staff_NumberTextBox2"
        Me.Staff_NumberTextBox2.Size = New System.Drawing.Size(200, 22)
        Me.Staff_NumberTextBox2.TabIndex = 47
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 651)
        Me.Controls.Add(PositionLabel1)
        Me.Controls.Add(Me.PositionTextBox1)
        Me.Controls.Add(Start_dateLabel)
        Me.Controls.Add(Me.Start_dateDateTimePicker)
        Me.Controls.Add(Finish_dateLabel)
        Me.Controls.Add(Me.Finish_dateDateTimePicker)
        Me.Controls.Add(OrganizationLabel)
        Me.Controls.Add(Me.OrganizationTextBox)
        Me.Controls.Add(Staff_NumberLabel2)
        Me.Controls.Add(Me.Staff_NumberTextBox2)
        Me.Controls.Add(Qualification_typeLabel)
        Me.Controls.Add(Me.Qualification_typeTextBox)
        Me.Controls.Add(Grad_dateLabel)
        Me.Controls.Add(Me.Grad_dateDateTimePicker)
        Me.Controls.Add(InstitutionLabel)
        Me.Controls.Add(Me.InstitutionTextBox)
        Me.Controls.Add(Staff_NumberLabel1)
        Me.Controls.Add(Me.Staff_NumberTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NINLabel)
        Me.Controls.Add(Me.txtNIN)
        Me.Controls.Add(Staff_NumberLabel)
        Me.Controls.Add(Me.txtStaffNo)
        Me.Controls.Add(F_NameLabel)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(L_NameLabel)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(TelLabel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Salary_scaleLabel)
        Me.Controls.Add(Me.txtScale)
        Me.Controls.Add(Paid_conditionLabel)
        Me.Controls.Add(Me.Paid_conditionTextBox)
        Me.Controls.Add(Hours_per_WeekLabel)
        Me.Controls.Add(Me.Hours_per_WeekTextBox)
        Me.Controls.Add(AllocatedWardLabel)
        Me.Controls.Add(Me.AllocatedWardTextBox)
        Me.Controls.Add(Me.StaffBindingNavigator)
        Me.Name = "StaffForm"
        Me.Text = "Form2"
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        CType(Me.QUALIFICATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORK_EXPERIENCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDataSet As wellmeadowsDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As wellmeadowsDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtNIN As TextBox
    Friend WithEvents txtStaffNo As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtScale As TextBox
    Friend WithEvents Paid_conditionTextBox As TextBox
    Friend WithEvents Hours_per_WeekTextBox As TextBox
    Friend WithEvents AllocatedWardTextBox As TextBox
    Friend WithEvents QUALIFICATIONTableAdapter As wellmeadowsDataSetTableAdapters.QUALIFICATIONTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents QUALIFICATIONBindingSource As BindingSource
    Friend WithEvents WORK_EXPERIENCETableAdapter As wellmeadowsDataSetTableAdapters.WORK_EXPERIENCETableAdapter
    Friend WithEvents Qualification_typeTextBox As TextBox
    Friend WithEvents Grad_dateDateTimePicker As DateTimePicker
    Friend WithEvents InstitutionTextBox As TextBox
    Friend WithEvents Staff_NumberTextBox1 As TextBox
    Friend WithEvents WORK_EXPERIENCEBindingSource As BindingSource
    Friend WithEvents PositionTextBox1 As TextBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents Finish_dateDateTimePicker As DateTimePicker
    Friend WithEvents OrganizationTextBox As TextBox
    Friend WithEvents Staff_NumberTextBox2 As TextBox
End Class
