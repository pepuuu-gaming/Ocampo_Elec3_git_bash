<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Button = New System.Windows.Forms.Button()
        Me.XML_Button = New System.Windows.Forms.Button()
        Me.JSON_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(149, 132)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(253, 26)
        Me.AddressTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(149, 100)
        Me.AgeTextBox.MaxLength = 3
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(46, 26)
        Me.AgeTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Age"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(149, 68)
        Me.NameTextBox.MaxLength = 1000
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(253, 26)
        Me.NameTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'TXT_Button
        '
        Me.TXT_Button.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Button.Location = New System.Drawing.Point(72, 203)
        Me.TXT_Button.Name = "TXT_Button"
        Me.TXT_Button.Size = New System.Drawing.Size(75, 23)
        Me.TXT_Button.TabIndex = 10
        Me.TXT_Button.Text = "TXT"
        Me.TXT_Button.UseVisualStyleBackColor = True
        '
        'XML_Button
        '
        Me.XML_Button.Font = New System.Drawing.Font("Cooper Black", 9.75!)
        Me.XML_Button.Location = New System.Drawing.Point(199, 203)
        Me.XML_Button.Name = "XML_Button"
        Me.XML_Button.Size = New System.Drawing.Size(75, 23)
        Me.XML_Button.TabIndex = 11
        Me.XML_Button.Text = "XML"
        Me.XML_Button.UseVisualStyleBackColor = True
        '
        'JSON_Button
        '
        Me.JSON_Button.Font = New System.Drawing.Font("Cooper Black", 9.75!)
        Me.JSON_Button.Location = New System.Drawing.Point(326, 203)
        Me.JSON_Button.Name = "JSON_Button"
        Me.JSON_Button.Size = New System.Drawing.Size(75, 23)
        Me.JSON_Button.TabIndex = 12
        Me.JSON_Button.Text = "JSON"
        Me.JSON_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 323)
        Me.Controls.Add(Me.JSON_Button)
        Me.Controls.Add(Me.XML_Button)
        Me.Controls.Add(Me.TXT_Button)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Button As Button
    Friend WithEvents XML_Button As Button
    Friend WithEvents JSON_Button As Button
End Class
