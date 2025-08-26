<System.Diagnostics.DebuggerStepThrough()> _
Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffForm))

    ' ====== Data / Binding sources ======
    Me.WellmeadowsDataSet = New Wellmeadows.wellmeadowsDataSet()
    Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.StaffTableAdapter = New Wellmeadows.wellmeadowsDataSetTableAdapters.StaffTableAdapter()
    Me.QUALIFICATIONTableAdapter = New Wellmeadows.wellmeadowsDataSetTableAdapters.QUALIFICATIONTableAdapter()
    Me.WORK_EXPERIENCETableAdapter = New Wellmeadows.wellmeadowsDataSetTableAdapters.WORK_EXPERIENCETableAdapter()
    Me.TableAdapterManager = New Wellmeadows.wellmeadowsDataSetTableAdapters.TableAdapterManager()

    ' ====== BindingNavigator ======
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

    ' ====== Header ======
    Dim header As New Panel()
    Dim lblTitle As New Label()
    Dim lblSub As New Label()

    ' ====== Main Tabs ======
    Dim tabs As New TabControl()
    Dim tabStaff As New TabPage("Staff")
    Dim tabQual As New TabPage("Qualification")
    Dim tabWork As New TabPage("Work Experience")

    ' ====== Staff TableLayout ======
    Dim tlpStaff As New TableLayoutPanel()
    Dim NINLabel As New Label()
    Dim Staff_NumberLabel As New Label()
    Dim F_NameLabel As New Label()
    Dim L_NameLabel As New Label()
    Dim AddressLabel As New Label()
    Dim TelLabel As New Label()
    Dim DOBLabel As New Label()
    Dim SexLabel As New Label()
    Dim PositionLabel As New Label()
    Dim SalaryLabel As New Label()
    Dim Salary_scaleLabel As New Label()
    Dim Paid_conditionLabel As New Label()
    Dim Hours_per_WeekLabel As New Label()
    Dim AllocatedWardLabel As New Label()

    ' ====== Staff inputs (ใช้ของเดิมทั้งหมด) ======
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

    ' ====== Command Buttons ======
    Dim cmdBar As New FlowLayoutPanel()
    Dim btnNew As New Button()
    Dim btnSave As New Button()
    Dim btnDelete As New Button()

    ' ====== Qualification ======
    Me.QUALIFICATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Dim tlpQual As New TableLayoutPanel()
    Dim Qualification_typeLabel As New Label()
    Dim Grad_dateLabel As New Label()
    Dim InstitutionLabel As New Label()
    Dim Staff_NumberLabel1 As New Label()
    Me.Qualification_typeTextBox = New System.Windows.Forms.TextBox()
    Me.Grad_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
    Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
    Me.Staff_NumberTextBox1 = New System.Windows.Forms.TextBox()

    ' ====== Work Experience ======
    Me.WORK_EXPERIENCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Dim tlpWork As New TableLayoutPanel()
    Dim PositionLabel1 As New Label()
    Dim Start_dateLabel As New Label()
    Dim Finish_dateLabel As New Label()
    Dim OrganizationLabel As New Label()
    Dim Staff_NumberLabel2 As New Label()
    Me.PositionTextBox1 = New System.Windows.Forms.TextBox()
    Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
    Me.Finish_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
    Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
    Me.Staff_NumberTextBox2 = New System.Windows.Forms.TextBox()

    ' ====== Dataset wiring ======
    CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.QUALIFICATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.WORK_EXPERIENCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.StaffBindingNavigator.SuspendLayout()

    ' ----------------- Form base style -----------------
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1000, 720)
    Me.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular, GraphicsUnit.Point)
    Me.BackColor = Color.FromArgb(245, 247, 250)
    Me.StartPosition = FormStartPosition.CenterScreen
    Me.Text = "Staff Management"
    Me.MinimumSize = New Size(980, 680)

    ' ----------------- Data binding setup -----------------
    Me.WellmeadowsDataSet.DataSetName = "wellmeadowsDataSet"
    Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema

    Me.StaffBindingSource.DataMember = "Staff"
    Me.StaffBindingSource.DataSource = Me.WellmeadowsDataSet

    Me.QUALIFICATIONBindingSource.DataMember = "QUALIFICATION"
    Me.QUALIFICATIONBindingSource.DataSource = Me.WellmeadowsDataSet

    Me.WORK_EXPERIENCEBindingSource.DataMember = "WORK_EXPERIENCE"
    Me.WORK_EXPERIENCEBindingSource.DataSource = Me.WellmeadowsDataSet

    Me.StaffTableAdapter.ClearBeforeFill = True
    Me.QUALIFICATIONTableAdapter.ClearBeforeFill = True
    Me.WORK_EXPERIENCETableAdapter.ClearBeforeFill = True

    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
    Me.TableAdapterManager.QUALIFICATIONTableAdapter = Me.QUALIFICATIONTableAdapter
    Me.TableAdapterManager.WORK_EXPERIENCETableAdapter = Me.WORK_EXPERIENCETableAdapter
    Me.TableAdapterManager.UpdateOrder = Wellmeadows.wellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete

    ' ----------------- BindingNavigator style -----------------
    Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
    Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
    Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.StaffBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
        Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator,
        Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1,
        Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2,
        Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
    Me.StaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
    Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
    Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
    Me.StaffBindingNavigator.Size = New System.Drawing.Size(1000, 31)
    Me.StaffBindingNavigator.TabIndex = 0
    Me.StaffBindingNavigator.RenderMode = ToolStripRenderMode.System
    Me.StaffBindingNavigator.GripStyle = ToolStripGripStyle.Hidden
    Me.StaffBindingNavigator.BackColor = Color.FromArgb(234, 240, 246)

    Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorAddNewItem.Text = "Add new"

    Me.BindingNavigatorCountItem.Text = "of {0}"
    Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorDeleteItem.Text = "Delete"

    Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorPositionItem.AutoSize = False
    Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
    Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
    Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
    Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
    Me.StaffBindingNavigatorSaveItem.Text = "Save Data"

    ' ----------------- Header -----------------
    header.Dock = DockStyle.Top
    header.Height = 72
    header.BackColor = Color.FromArgb(52, 152, 219)
    header.Padding = New Padding(20, 12, 20, 12)

    lblTitle.AutoSize = True
    lblTitle.Text = "Staff Management"
    lblTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
    lblTitle.ForeColor = Color.White
    lblTitle.Location = New Point(20, 12)

    lblSub.AutoSize = True
    lblSub.Text = "Create • Edit • Track staff profiles"
    lblSub.Font = New Font("Segoe UI", 10, FontStyle.Regular)
    lblSub.ForeColor = Color.White
    lblSub.Location = New Point(22, 44)

    header.Controls.Add(lblTitle)
    header.Controls.Add(lblSub)

    ' ----------------- Tabs -----------------
    tabs.Dock = DockStyle.Fill
    tabs.Padding = New Point(12, 6)
    tabs.Appearance = TabAppearance.Normal

    ' ----------------- Staff Layout -----------------
    tlpStaff.ColumnCount = 2
    tlpStaff.RowCount = 14
    tlpStaff.Dock = DockStyle.Fill
    tlpStaff.Padding = New Padding(20)
    tlpStaff.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35))
    tlpStaff.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65))
    For i As Integer = 1 To 14
        tlpStaff.RowStyles.Add(New RowStyle(SizeType.Absolute, 34))
    Next

    ' label styling helper
    Dim labelFont = New Font("Segoe UI", 10, FontStyle.Bold)
    Dim labelFore = Color.FromArgb(60, 72, 88)

    Dim SubLbl = Sub(lbl As Label, text As String)
                    lbl.Text = text
                    lbl.AutoSize = True
                    lbl.Margin = New Padding(0, 6, 8, 6)
                    lbl.Font = labelFont
                    lbl.ForeColor = labelFore
                End Sub

    SubLbl(NINLabel, "NIN:")
    SubLbl(Staff_NumberLabel, "Staff Number:")
    SubLbl(F_NameLabel, "First Name:")
    SubLbl(L_NameLabel, "Last Name:")
    SubLbl(AddressLabel, "Address:")
    SubLbl(TelLabel, "Tel:")
    SubLbl(DOBLabel, "DOB:")
    SubLbl(SexLabel, "Sex:")
    SubLbl(PositionLabel, "Position:")
    SubLbl(SalaryLabel, "Salary:")
    SubLbl(Salary_scaleLabel, "Salary Scale:")
    SubLbl(Paid_conditionLabel, "Paid Condition:")
    SubLbl(Hours_per_WeekLabel, "Hours per Week:")
    SubLbl(AllocatedWardLabel, "Allocated Ward:")

    ' inputs – common styling
    Dim inputFont = New Font("Segoe UI", 10, FontStyle.Regular)
    Dim SetBox = Sub(tb As Control)
                     tb.Margin = New Padding(0, 3, 0, 3)
                     tb.Anchor = AnchorStyles.Left Or AnchorStyles.Right
                 End Sub

    ' data bindings (เหมือนเดิม)
    Me.txtNIN.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "NIN", True))
    Me.txtStaffNo.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Staff_Number", True))
    Me.txtFName.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "F_Name", True))
    Me.txtLName.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "L_Name", True))
    Me.txtAddress.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Address", True))
    Me.txtTel.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Tel", True))
    Me.txtDOB.DataBindings.Add(New Binding("Value", Me.StaffBindingSource, "DOB", True))
    Me.txtSex.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Sex", True))
    Me.txtPosition.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Position", True))
    Me.txtSalary.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Salary", True))
    Me.txtScale.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Salary_scale", True))
    Me.Paid_conditionTextBox.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Paid_condition", True))
    Me.Hours_per_WeekTextBox.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "Hours_per_Week", True))
    Me.AllocatedWardTextBox.DataBindings.Add(New Binding("Text", Me.StaffBindingSource, "allocatedWard", True))

    ' input visual
    For Each c As Control In New Control() {txtNIN, txtStaffNo, txtFName, txtLName, txtAddress, txtTel, txtSex, txtPosition, txtSalary, txtScale, Paid_conditionTextBox, Hours_per_WeekTextBox, AllocatedWardTextBox}
        c.Font = inputFont
        SetBox(c)
    Next
    Me.txtDOB.Font = inputFont
    SetBox(Me.txtDOB)

    ' Add to TLP
    Dim r As Integer = 0
    tlpStaff.Controls.Add(NINLabel, 0, r) : tlpStaff.Controls.Add(Me.txtNIN, 1, r) : r += 1
    tlpStaff.Controls.Add(Staff_NumberLabel, 0, r) : tlpStaff.Controls.Add(Me.txtStaffNo, 1, r) : r += 1
    tlpStaff.Controls.Add(F_NameLabel, 0, r) : tlpStaff.Controls.Add(Me.txtFName, 1, r) : r += 1
    tlpStaff.Controls.Add(L_NameLabel, 0, r) : tlpStaff.Controls.Add(Me.txtLName, 1, r) : r += 1
    tlpStaff.Controls.Add(AddressLabel, 0, r) : tlpStaff.Controls.Add(Me.txtAddress, 1, r) : r += 1
    tlpStaff.Controls.Add(TelLabel, 0, r) : tlpStaff.Controls.Add(Me.txtTel, 1, r) : r += 1
    tlpStaff.Controls.Add(DOBLabel, 0, r) : tlpStaff.Controls.Add(Me.txtDOB, 1, r) : r += 1
    tlpStaff.Controls.Add(SexLabel, 0, r) : tlpStaff.Controls.Add(Me.txtSex, 1, r) : r += 1
    tlpStaff.Controls.Add(PositionLabel, 0, r) : tlpStaff.Controls.Add(Me.txtPosition, 1, r) : r += 1
    tlpStaff.Controls.Add(SalaryLabel, 0, r) : tlpStaff.Controls.Add(Me.txtSalary, 1, r) : r += 1
    tlpStaff.Controls.Add(Salary_scaleLabel, 0, r) : tlpStaff.Controls.Add(Me.txtScale, 1, r) : r += 1
    tlpStaff.Controls.Add(Paid_conditionLabel, 0, r) : tlpStaff.Controls.Add(Me.Paid_conditionTextBox, 1, r) : r += 1
    tlpStaff.Controls.Add(Hours_per_WeekLabel, 0, r) : tlpStaff.Controls.Add(Me.Hours_per_WeekTextBox, 1, r) : r += 1
    tlpStaff.Controls.Add(AllocatedWardLabel, 0, r) : tlpStaff.Controls.Add(Me.AllocatedWardTextBox, 1, r) : r += 1

    ' ----------------- Command bar -----------------
    cmdBar.Dock = DockStyle.Bottom
    cmdBar.FlowDirection = FlowDirection.RightToLeft
    cmdBar.Padding = New Padding(20)
    cmdBar.Height = 72
    cmdBar.BackColor = Color.Transparent

    Dim StyleBtn = Sub(b As Button, t As String)
                       b.Text = t
                       b.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                       b.FlatStyle = FlatStyle.Flat
                       b.FlatAppearance.BorderSize = 0
                       b.Height = 40
                       b.Width = 120
                       b.Margin = New Padding(10, 8, 0, 8)
                       b.ForeColor = Color.White
                   End Sub

    StyleBtn(btnSave, "Save")
    btnSave.BackColor = Color.FromArgb(46, 204, 113)

    StyleBtn(btnNew, "New")
    btnNew.BackColor = Color.FromArgb(52, 152, 219)

    StyleBtn(btnDelete, "Delete")
    btnDelete.BackColor = Color.FromArgb(231, 76, 60)

    cmdBar.Controls.AddRange(New Control() {btnSave, btnNew, btnDelete})

    ' (optional) wire simple actions—คุณมี logic เดิมอาจอยู่ที่ที่อื่นได้
    AddHandler btnNew.Click, Sub() Me.StaffBindingSource.AddNew()
    AddHandler btnDelete.Click, Sub() Me.StaffBindingSource.RemoveCurrent()
    AddHandler btnSave.Click,
        Sub()
            Me.Validate()
            Me.StaffBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)
            MessageBox.Show("Saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

    ' ----------------- Qualification layout -----------------
    tlpQual.ColumnCount = 2
    tlpQual.RowCount = 4
    tlpQual.Dock = DockStyle.Fill
    tlpQual.Padding = New Padding(20)
    tlpQual.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35))
    tlpQual.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65))
    For i As Integer = 1 To 4
        tlpQual.RowStyles.Add(New RowStyle(SizeType.Absolute, 34))
    Next

    SubLbl(Qualification_typeLabel, "Qualification type:")
    SubLbl(Grad_dateLabel, "Grad date:")
    SubLbl(InstitutionLabel, "Institution:")
    SubLbl(Staff_NumberLabel1, "Staff Number:")

    Me.Qualification_typeTextBox.DataBindings.Add(New Binding("Text", Me.QUALIFICATIONBindingSource, "Qualification_type", True))
    Me.Grad_dateDateTimePicker.DataBindings.Add(New Binding("Value", Me.QUALIFICATIONBindingSource, "Grad_date", True))
    Me.InstitutionTextBox.DataBindings.Add(New Binding("Text", Me.QUALIFICATIONBindingSource, "Institution", True))
    Me.Staff_NumberTextBox1.DataBindings.Add(New Binding("Text", Me.QUALIFICATIONBindingSource, "Staff_Number", True))

    For Each c As Control In New Control() {Qualification_typeTextBox, InstitutionTextBox, Staff_NumberTextBox1}
        c.Font = inputFont : SetBox(c)
    Next
    Me.Grad_dateDateTimePicker.Font = inputFont : SetBox(Me.Grad_dateDateTimePicker)

    tlpQual.Controls.Add(Qualification_typeLabel, 0, 0) : tlpQual.Controls.Add(Me.Qualification_typeTextBox, 1, 0)
    tlpQual.Controls.Add(Grad_dateLabel, 0, 1) : tlpQual.Controls.Add(Me.Grad_dateDateTimePicker, 1, 1)
    tlpQual.Controls.Add(InstitutionLabel, 0, 2) : tlpQual.Controls.Add(Me.InstitutionTextBox, 1, 2)
    tlpQual.Controls.Add(Staff_NumberLabel1, 0, 3) : tlpQual.Controls.Add(Me.Staff_NumberTextBox1, 1, 3)

    ' ----------------- Work Experience layout -----------------
    tlpWork.ColumnCount = 2
    tlpWork.RowCount = 5
    tlpWork.Dock = DockStyle.Fill
    tlpWork.Padding = New Padding(20)
    tlpWork.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35))
    tlpWork.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65))
    For i As Integer = 1 To 5
        tlpWork.RowStyles.Add(New RowStyle(SizeType.Absolute, 34))
    Next

    SubLbl(PositionLabel1, "Position:")
    SubLbl(Start_dateLabel, "Start date:")
    SubLbl(Finish_dateLabel, "Finish date:")
    SubLbl(OrganizationLabel, "Organization:")
    SubLbl(Staff_NumberLabel2, "Staff Number:")

    Me.PositionTextBox1.DataBindings.Add(New Binding("Text", Me.WORK_EXPERIENCEBindingSource, "Position", True))
    Me.Start_dateDateTimePicker.DataBindings.Add(New Binding("Value", Me.WORK_EXPERIENCEBindingSource, "Start_date", True))
    Me.Finish_dateDateTimePicker.DataBindings.Add(New Binding("Value", Me.WORK_EXPERIENCEBindingSource, "Finish_date", True))
    Me.OrganizationTextBox.DataBindings.Add(New Binding("Text", Me.WORK_EXPERIENCEBindingSource, "Organization", True))
    Me.Staff_NumberTextBox2.DataBindings.Add(New Binding("Text", Me.WORK_EXPERIENCEBindingSource, "Staff_Number", True))

    For Each c As Control In New Control() {PositionTextBox1, OrganizationTextBox, Staff_NumberTextBox2}
        c.Font = inputFont : SetBox(c)
    Next
    Me.Start_dateDateTimePicker.Font = inputFont : SetBox(Me.Start_dateDateTimePicker)
    Me.Finish_dateDateTimePicker.Font = inputFont : SetBox(Me.Finish_dateDateTimePicker)

    tlpWork.Controls.Add(PositionLabel1, 0, 0) : tlpWork.Controls.Add(Me.PositionTextBox1, 1, 0)
    tlpWork.Controls.Add(Start_dateLabel, 0, 1) : tlpWork.Controls.Add(Me.Start_dateDateTimePicker, 1, 1)
    tlpWork.Controls.Add(Finish_dateLabel, 0, 2) : tlpWork.Controls.Add(Me.Finish_dateDateTimePicker, 1, 2)
    tlpWork.Controls.Add(OrganizationLabel, 0, 3) : tlpWork.Controls.Add(Me.OrganizationTextBox, 1, 3)
    tlpWork.Controls.Add(Staff_NumberLabel2, 0, 4) : tlpWork.Controls.Add(Me.Staff_NumberTextBox2, 1, 4)

    ' ----------------- Put together -----------------
    tabStaff.Padding = New Padding(10)
    tabQual.Padding = New Padding(10)
    tabWork.Padding = New Padding(10)
    tabStaff.Controls.Add(tlpStaff)
    tabStaff.Controls.Add(cmdBar)
    tabQual.Controls.Add(tlpQual)
    tabWork.Controls.Add(tlpWork)

    tabs.TabPages.AddRange(New TabPage() {tabStaff, tabQual, tabWork})

    Me.Controls.Add(tabs)
    Me.Controls.Add(header)
    Me.Controls.Add(Me.StaffBindingNavigator)

    CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.QUALIFICATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.WORK_EXPERIENCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.StaffBindingNavigator.ResumeLayout(False)
    Me.StaffBindingNavigator.PerformLayout()
End Sub
