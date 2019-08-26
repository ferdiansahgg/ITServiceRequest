<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnlist = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(379, 225)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(63, 33)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnlist
        '
        Me.btnlist.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlist.Location = New System.Drawing.Point(240, 62)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(189, 61)
        Me.btnlist.TabIndex = 4
        Me.btnlist.Text = "SERVICE REQUEST"
        Me.btnlist.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Sejarah Perusahaan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 257)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents btnlist As Button
    Friend WithEvents Button1 As Button
End Class
