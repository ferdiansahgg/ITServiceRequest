<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listingservice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listingservice))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.TbserviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblopen = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblclose = New System.Windows.Forms.Label()
        Me.txtkeluhan = New System.Windows.Forms.RichTextBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.lblpending = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.cbdept = New System.Windows.Forms.ComboBox()
        Me.cbjk = New System.Windows.Forms.ComboBox()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.TbserviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "KELUHAN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "NAMA :"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(70, 146)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(98, 20)
        Me.txtnama.TabIndex = 26
        '
        'TbserviceBindingSource
        '
        Me.TbserviceBindingSource.DataMember = "tbservice"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "NIK : "
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(328, 384)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 40
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "STATUS :"
        '
        'lblopen
        '
        Me.lblopen.AutoSize = True
        Me.lblopen.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblopen.Location = New System.Drawing.Point(489, 13)
        Me.lblopen.Name = "lblopen"
        Me.lblopen.Size = New System.Drawing.Size(0, 29)
        Me.lblopen.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "DEPARTEMEN :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "JENIS KELUHAN :"
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.BackColor = System.Drawing.Color.SpringGreen
        Me.lblclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclose.Location = New System.Drawing.Point(373, 21)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(0, 29)
        Me.lblclose.TabIndex = 36
        '
        'txtkeluhan
        '
        Me.txtkeluhan.Location = New System.Drawing.Point(469, 110)
        Me.txtkeluhan.Name = "txtkeluhan"
        Me.txtkeluhan.Size = New System.Drawing.Size(243, 96)
        Me.txtkeluhan.TabIndex = 33
        Me.txtkeluhan.Text = ""
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(428, 384)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 34
        Me.btnrefresh.Text = "REFRESH"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'lblpending
        '
        Me.lblpending.AutoSize = True
        Me.lblpending.BackColor = System.Drawing.Color.SpringGreen
        Me.lblpending.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpending.Location = New System.Drawing.Point(167, 23)
        Me.lblpending.Name = "lblpending"
        Me.lblpending.Size = New System.Drawing.Size(0, 29)
        Me.lblpending.TabIndex = 32
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(131, 384)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 30
        Me.btnupdate.Text = "EDIT"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(858, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 38)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "FORM LOGIN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(230, 384)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(752, 166)
        Me.DataGridView1.TabIndex = 20
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(774, 221)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(76, 49)
        Me.btnreport.TabIndex = 46
        Me.btnreport.Text = "REPORT"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'cbdept
        '
        Me.cbdept.FormattingEnabled = True
        Me.cbdept.Items.AddRange(New Object() {"IT", "ACC", "MAR", "HRD"})
        Me.cbdept.Location = New System.Drawing.Point(291, 116)
        Me.cbdept.Name = "cbdept"
        Me.cbdept.Size = New System.Drawing.Size(100, 21)
        Me.cbdept.TabIndex = 47
        '
        'cbjk
        '
        Me.cbjk.FormattingEnabled = True
        Me.cbjk.Items.AddRange(New Object() {"Internet", "Printer", "Komputer", "Laptop", "Mesin Fotocopy"})
        Me.cbjk.Location = New System.Drawing.Point(291, 153)
        Me.cbjk.Name = "cbjk"
        Me.cbjk.Size = New System.Drawing.Size(100, 21)
        Me.cbjk.TabIndex = 48
        '
        'cbstatus
        '
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Items.AddRange(New Object() {"OnProses", "Fix"})
        Me.cbstatus.Location = New System.Drawing.Point(70, 180)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(98, 21)
        Me.cbstatus.TabIndex = 49
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(70, 111)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(98, 20)
        Me.txtnik.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(774, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "MENU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(29, 384)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "ADD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'listingservice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(943, 468)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.cbstatus)
        Me.Controls.Add(Me.cbjk)
        Me.Controls.Add(Me.cbdept)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblopen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblclose)
        Me.Controls.Add(Me.txtkeluhan)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.lblpending)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "listingservice"
        Me.Text = "listingservice"
        CType(Me.TbserviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents TbserviceBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblopen As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblclose As Label
    Friend WithEvents txtkeluhan As RichTextBox
    Friend WithEvents btnrefresh As Button
    Friend WithEvents lblpending As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnreport As Button
    Friend WithEvents cbdept As ComboBox
    Friend WithEvents cbjk As ComboBox
    Friend WithEvents cbstatus As ComboBox
    Friend WithEvents txtnik As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
