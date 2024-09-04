<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_mhs
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSisip = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvMHS = New System.Windows.Forms.ListView()
        Me.chnim = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chnama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chjenis_kelamin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chtempat_lahir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chtanggal_lahir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chmasuk = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkeluar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSisip)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUbah)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnHapus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnTampil)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFilter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvMHS)
        Me.SplitContainer1.Size = New System.Drawing.Size(942, 351)
        Me.SplitContainer1.SplitterDistance = 73
        Me.SplitContainer1.TabIndex = 4
        '
        'btnSisip
        '
        Me.btnSisip.Location = New System.Drawing.Point(25, 20)
        Me.btnSisip.Name = "btnSisip"
        Me.btnSisip.Size = New System.Drawing.Size(75, 37)
        Me.btnSisip.TabIndex = 8
        Me.btnSisip.Text = "&Sisip"
        Me.btnSisip.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(759, 19)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 37)
        Me.btnUbah.TabIndex = 7
        Me.btnUbah.Text = "&Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(849, 20)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 37)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(627, 20)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(110, 37)
        Me.btnTampil.TabIndex = 5
        Me.btnTampil.Text = "&Tampil"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(199, 25)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(422, 26)
        Me.txtFilter.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filter"
        '
        'lvMHS
        '
        Me.lvMHS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chnim, Me.chnama, Me.chjenis_kelamin, Me.chtempat_lahir, Me.chtanggal_lahir, Me.chmasuk, Me.chkeluar})
        Me.lvMHS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMHS.FullRowSelect = True
        Me.lvMHS.Location = New System.Drawing.Point(0, 0)
        Me.lvMHS.Name = "lvMHS"
        Me.lvMHS.Size = New System.Drawing.Size(942, 274)
        Me.lvMHS.TabIndex = 4
        Me.lvMHS.UseCompatibleStateImageBehavior = False
        Me.lvMHS.View = System.Windows.Forms.View.Details
        '
        'chnim
        '
        Me.chnim.Text = "Nim"
        Me.chnim.Width = 105
        '
        'chnama
        '
        Me.chnama.Text = "Nama"
        Me.chnama.Width = 168
        '
        'chjenis_kelamin
        '
        Me.chjenis_kelamin.Text = "Jenis Kelamin"
        Me.chjenis_kelamin.Width = 120
        '
        'chtempat_lahir
        '
        Me.chtempat_lahir.Text = "Tempat Lahir"
        Me.chtempat_lahir.Width = 150
        '
        'chtanggal_lahir
        '
        Me.chtanggal_lahir.Text = "Tanggal Lahir"
        Me.chtanggal_lahir.Width = 120
        '
        'chmasuk
        '
        Me.chmasuk.Text = "Masuk"
        Me.chmasuk.Width = 120
        '
        'chkeluar
        '
        Me.chkeluar.Text = "Keluar"
        Me.chkeluar.Width = 120
        '
        'f_mhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 351)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "f_mhs"
        Me.Text = "Data Mahasiswa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvMHS As System.Windows.Forms.ListView
    Friend WithEvents chnim As System.Windows.Forms.ColumnHeader
    Friend WithEvents chnama As System.Windows.Forms.ColumnHeader
    Friend WithEvents chjenis_kelamin As System.Windows.Forms.ColumnHeader
    Friend WithEvents chtempat_lahir As System.Windows.Forms.ColumnHeader
    Friend WithEvents chtanggal_lahir As System.Windows.Forms.ColumnHeader
    Friend WithEvents chmasuk As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkeluar As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSisip As System.Windows.Forms.Button

End Class
