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
        Me.btnanser = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.lblquest = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblNameanser = New System.Windows.Forms.Label()
        Me.lblQuestanser = New System.Windows.Forms.Label()
        Me.lblColoranser = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnanser
        '
        Me.btnanser.Location = New System.Drawing.Point(104, 158)
        Me.btnanser.Name = "btnanser"
        Me.btnanser.Size = New System.Drawing.Size(75, 23)
        Me.btnanser.TabIndex = 0
        Me.btnanser.Text = "submit"
        Me.btnanser.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(177, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(90, 20)
        Me.txtName.TabIndex = 1
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(177, 95)
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(90, 20)
        Me.txtQuest.TabIndex = 2
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(177, 132)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(89, 20)
        Me.txtColor.TabIndex = 3
        '
        'lblcolor
        '
        Me.lblcolor.AutoSize = True
        Me.lblcolor.Location = New System.Drawing.Point(12, 132)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(135, 13)
        Me.lblcolor.TabIndex = 4
        Me.lblcolor.Text = "what is your favoirite color?"
        '
        'lblquest
        '
        Me.lblquest.AutoSize = True
        Me.lblquest.Location = New System.Drawing.Point(12, 95)
        Me.lblquest.Name = "lblquest"
        Me.lblquest.Size = New System.Drawing.Size(98, 13)
        Me.lblquest.TabIndex = 5
        Me.lblquest.Text = "what is your quest?"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(12, 56)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(101, 13)
        Me.lblname.TabIndex = 6
        Me.lblname.Text = "What is your name?"
        '
        'lblNameanser
        '
        Me.lblNameanser.AutoSize = True
        Me.lblNameanser.Location = New System.Drawing.Point(25, 193)
        Me.lblNameanser.Name = "lblNameanser"
        Me.lblNameanser.Size = New System.Drawing.Size(39, 13)
        Me.lblNameanser.TabIndex = 7
        Me.lblNameanser.Text = "Label1"
        '
        'lblQuestanser
        '
        Me.lblQuestanser.AutoSize = True
        Me.lblQuestanser.Location = New System.Drawing.Point(118, 193)
        Me.lblQuestanser.Name = "lblQuestanser"
        Me.lblQuestanser.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestanser.TabIndex = 8
        Me.lblQuestanser.Text = "Label2"
        '
        'lblColoranser
        '
        Me.lblColoranser.AutoSize = True
        Me.lblColoranser.Location = New System.Drawing.Point(210, 193)
        Me.lblColoranser.Name = "lblColoranser"
        Me.lblColoranser.Size = New System.Drawing.Size(39, 13)
        Me.lblColoranser.TabIndex = 9
        Me.lblColoranser.Text = "Label3"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(71, 19)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(153, 13)
        Me.lbltitle.TabIndex = 10
        Me.lbltitle.Text = "welcome to the bridge of death"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.lblColoranser)
        Me.Controls.Add(Me.lblQuestanser)
        Me.Controls.Add(Me.lblNameanser)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblquest)
        Me.Controls.Add(Me.lblcolor)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtQuest)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnanser)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnanser As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuest As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblcolor As System.Windows.Forms.Label
    Friend WithEvents lblquest As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblNameanser As System.Windows.Forms.Label
    Friend WithEvents lblQuestanser As System.Windows.Forms.Label
    Friend WithEvents lblColoranser As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label

End Class
