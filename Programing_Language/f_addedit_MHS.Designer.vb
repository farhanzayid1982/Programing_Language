<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_addedit_MHS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbJenis_Kelamin = New System.Windows.Forms.GroupBox()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.txtTempat_Lahir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTanggal_Lahir = New System.Windows.Forms.DateTimePicker()
        Me.dtpMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpKeluar = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.gbJenis_Kelamin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(173, 12)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(283, 26)
        Me.txtNIM.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(173, 44)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(283, 26)
        Me.txtNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'gbJenis_Kelamin
        '
        Me.gbJenis_Kelamin.Controls.Add(Me.rbP)
        Me.gbJenis_Kelamin.Controls.Add(Me.rbL)
        Me.gbJenis_Kelamin.Location = New System.Drawing.Point(173, 76)
        Me.gbJenis_Kelamin.Name = "gbJenis_Kelamin"
        Me.gbJenis_Kelamin.Size = New System.Drawing.Size(315, 61)
        Me.gbJenis_Kelamin.TabIndex = 4
        Me.gbJenis_Kelamin.TabStop = False
        Me.gbJenis_Kelamin.Text = "Jenis Kelamin"
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(186, 25)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(116, 24)
        Me.rbP.TabIndex = 2
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Checked = True
        Me.rbL.Location = New System.Drawing.Point(33, 25)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(91, 24)
        Me.rbL.TabIndex = 1
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'txtTempat_Lahir
        '
        Me.txtTempat_Lahir.Location = New System.Drawing.Point(173, 143)
        Me.txtTempat_Lahir.Name = "txtTempat_Lahir"
        Me.txtTempat_Lahir.Size = New System.Drawing.Size(283, 26)
        Me.txtTempat_Lahir.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(499, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tanggal Lahir"
        '
        'dtpTanggal_Lahir
        '
        Me.dtpTanggal_Lahir.CustomFormat = "yyyy/MM/dd"
        Me.dtpTanggal_Lahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal_Lahir.Location = New System.Drawing.Point(657, 143)
        Me.dtpTanggal_Lahir.Name = "dtpTanggal_Lahir"
        Me.dtpTanggal_Lahir.Size = New System.Drawing.Size(141, 26)
        Me.dtpTanggal_Lahir.TabIndex = 9
        '
        'dtpMasuk
        '
        Me.dtpMasuk.CustomFormat = "yyyy/MM/dd"
        Me.dtpMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMasuk.Location = New System.Drawing.Point(261, 175)
        Me.dtpMasuk.Name = "dtpMasuk"
        Me.dtpMasuk.Size = New System.Drawing.Size(141, 26)
        Me.dtpMasuk.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Masuk"
        '
        'dtpKeluar
        '
        Me.dtpKeluar.Checked = False
        Me.dtpKeluar.CustomFormat = "yyyy/MM/dd"
        Me.dtpKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKeluar.Location = New System.Drawing.Point(511, 175)
        Me.dtpKeluar.Name = "dtpKeluar"
        Me.dtpKeluar.ShowCheckBox = True
        Me.dtpKeluar.Size = New System.Drawing.Size(141, 26)
        Me.dtpKeluar.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Keluar"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(887, 32)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 35)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(887, 76)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 35)
        Me.btnBatal.TabIndex = 15
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'f_addedit_MHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 236)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dtpKeluar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpMasuk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpTanggal_Lahir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTempat_Lahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbJenis_Kelamin)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f_addedit_MHS"
        Me.Text = "Add/Edit Mahasiswa"
        Me.gbJenis_Kelamin.ResumeLayout(False)
        Me.gbJenis_Kelamin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNIM As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbJenis_Kelamin As System.Windows.Forms.GroupBox
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents txtTempat_Lahir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal_Lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpKeluar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
