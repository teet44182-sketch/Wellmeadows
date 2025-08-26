Imports System.Data.SqlClient


Public Class StaffForm
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.WORK_EXPERIENCE' table. You can move, or remove it, as needed.
        Me.WORK_EXPERIENCETableAdapter.Fill(Me.WellmeadowsDataSet.WORK_EXPERIENCE)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.QUALIFICATION' table. You can move, or remove it, as needed.
        Me.QUALIFICATIONTableAdapter.Fill(Me.WellmeadowsDataSet.QUALIFICATION)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.WellmeadowsDataSet.Staff)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Wellmeadows;Integrated Security=True"),
              cmd As New SqlCommand("INSERT INTO Staff 
            (NIN, Staff_Number, F_Name, L_Name, Address, Tel, DOB, Sex, Position, Salary, Salary_scale, Paid_condition, Hours_per_Week, allocatedWard)
            VALUES (@NIN, @Staff_Number, @F_Name, @L_Name, @Address, @Tel, @DOB, @Sex, @Position, @Salary, @Salary_scale, @Paid_condition, @Hours_per_Week, @allocatedWard)", con)

            ' เอาค่าจาก TextBox
            cmd.Parameters.AddWithValue("@NIN", txtNIN.Text)
            cmd.Parameters.AddWithValue("@Staff_Number", txtStaffNo.Text)
            cmd.Parameters.AddWithValue("@F_Name", txtFName.Text)
            cmd.Parameters.AddWithValue("@L_Name", txtLName.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Tel", txtTel.Text)
            cmd.Parameters.AddWithValue("@DOB", txtDOB.Text)          ' ควรเป็น DateTime nahee the killer
            cmd.Parameters.AddWithValue("@Sex", txtSex.Text)
            cmd.Parameters.AddWithValue("@Position", txtPosition.Text)
            cmd.Parameters.AddWithValue("@Salary", txtSalary.Text)
            cmd.Parameters.AddWithValue("@Salary_scale", txtScale.Text)
            cmd.Parameters.AddWithValue("@Paid_condition", txtPaid.Text)
            cmd.Parameters.AddWithValue("@Hours_per_Week", txtHours.Text)
            cmd.Parameters.AddWithValue("@allocatedWard", txtWard.Text)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("เพิ่ม Staff เรียบร้อย")
    End Sub


End Class
