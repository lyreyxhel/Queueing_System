<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblName = New Label()
        lblPeople = New Label()
        txtName = New TextBox()
        txtPeople = New TextBox()
        btnAdd = New Button()
        lblWaiting = New Label()
        lblServing = New Label()
        lstWaiting = New ListBox()
        lstServing = New ListBox()
        lblTitle = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(186, 161)
        lblName.Name = "lblName"
        lblName.Size = New Size(68, 28)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblPeople
        ' 
        lblPeople.AutoSize = True
        lblPeople.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPeople.Location = New Point(186, 215)
        lblPeople.Name = "lblPeople"
        lblPeople.Size = New Size(164, 25)
        lblPeople.TabIndex = 1
        lblPeople.Text = "Number Of People:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(260, 165)
        txtName.Name = "txtName"
        txtName.Size = New Size(272, 27)
        txtName.TabIndex = 2
        ' 
        ' txtPeople
        ' 
        txtPeople.Location = New Point(356, 213)
        txtPeople.Name = "txtPeople"
        txtPeople.Size = New Size(41, 27)
        txtPeople.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Bisque
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(327, 267)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(126, 51)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add to Queue"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' lblWaiting
        ' 
        lblWaiting.AutoSize = True
        lblWaiting.Font = New Font("Segoe UI", 12.8F, FontStyle.Bold)
        lblWaiting.Location = New Point(160, 321)
        lblWaiting.Name = "lblWaiting"
        lblWaiting.Size = New Size(100, 30)
        lblWaiting.TabIndex = 5
        lblWaiting.Text = "Waiting:"
        ' 
        ' lblServing
        ' 
        lblServing.AutoSize = True
        lblServing.Font = New Font("Segoe UI", 12.8F, FontStyle.Bold)
        lblServing.Location = New Point(513, 321)
        lblServing.Name = "lblServing"
        lblServing.Size = New Size(98, 30)
        lblServing.TabIndex = 6
        lblServing.Text = "Serving:"
        ' 
        ' lstWaiting
        ' 
        lstWaiting.FormattingEnabled = True
        lstWaiting.Location = New Point(60, 354)
        lstWaiting.Name = "lstWaiting"
        lstWaiting.Size = New Size(327, 224)
        lstWaiting.TabIndex = 7
        ' 
        ' lstServing
        ' 
        lstServing.FormattingEnabled = True
        lstServing.Location = New Point(393, 354)
        lstServing.Name = "lstServing"
        lstServing.Size = New Size(327, 224)
        lstServing.TabIndex = 8
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(272, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(260, 28)
        lblTitle.TabIndex = 9
        lblTitle.Text = "Seat Queue System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(301, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Bisque
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(301, 600)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 41)
        Button1.TabIndex = 11
        Button1.Text = "Next Serve"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(779, 695)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(lblTitle)
        Controls.Add(lstServing)
        Controls.Add(lstWaiting)
        Controls.Add(lblServing)
        Controls.Add(lblWaiting)
        Controls.Add(btnAdd)
        Controls.Add(txtPeople)
        Controls.Add(txtName)
        Controls.Add(lblPeople)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPeople As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblServing As Label
    Friend WithEvents lstWaiting As ListBox
    Friend WithEvents lstServing As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button

End Class
