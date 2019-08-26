<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDaftar))
        Me.btnhlogin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtrole = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnhlogin
        '
        Me.btnhlogin.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhlogin.Location = New System.Drawing.Point(63, 261)
        Me.btnhlogin.Name = "btnhlogin"
        Me.btnhlogin.Size = New System.Drawing.Size(199, 49)
        Me.btnhlogin.TabIndex = 15
        Me.btnhlogin.Text = "&HALAMAN LOGIN"
        Me.btnhlogin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(63, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 53)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&DAFTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtrole
        '
        Me.txtrole.Location = New System.Drawing.Point(110, 166)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.Size = New System.Drawing.Size(125, 20)
        Me.txtrole.TabIndex = 13
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(110, 126)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(125, 20)
        Me.txtpass.TabIndex = 12
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(110, 87)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(125, 20)
        Me.txtid.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ROLE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "PASSWORD :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "USER_ID :"
        '
        'FormDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(315, 381)
        Me.Controls.Add(Me.btnhlogin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDaftar"
        Me.Text = "FormDaftar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnhlogin As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtrole As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
