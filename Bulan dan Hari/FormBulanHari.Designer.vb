<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBulanHari
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
        Me.listKeluaran = New System.Windows.Forms.ListBox()
        Me.tombolTampil = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listKeluaran
        '
        Me.listKeluaran.FormattingEnabled = True
        Me.listKeluaran.Location = New System.Drawing.Point(13, 13)
        Me.listKeluaran.Name = "listKeluaran"
        Me.listKeluaran.Size = New System.Drawing.Size(221, 199)
        Me.listKeluaran.TabIndex = 0
        '
        'tombolTampil
        '
        Me.tombolTampil.Location = New System.Drawing.Point(13, 219)
        Me.tombolTampil.Name = "tombolTampil"
        Me.tombolTampil.Size = New System.Drawing.Size(103, 40)
        Me.tombolTampil.TabIndex = 1
        Me.tombolTampil.Text = "Tampilkan Bulan dan Hari"
        Me.tombolTampil.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(131, 219)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(103, 40)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormBulanHari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 262)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolTampil)
        Me.Controls.Add(Me.listKeluaran)
        Me.Name = "FormBulanHari"
        Me.Text = "Bulan dan Hari"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listKeluaran As System.Windows.Forms.ListBox
    Friend WithEvents tombolTampil As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
