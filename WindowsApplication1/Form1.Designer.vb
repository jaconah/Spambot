<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pause = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Message = New System.Windows.Forms.TextBox()
        Me.Delay = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalSent = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.NumericUpDown()
        Me.Start = New System.Windows.Forms.Button()
        Me.Begin = New System.Windows.Forms.Timer(Me.components)
        Me.add1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sentcount = New System.Windows.Forms.MaskedTextBox()
        Me.tcount = New System.Windows.Forms.MaskedTextBox()
        Me.sentcounter = New System.Windows.Forms.Label()
        CType(Me.amount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pause
        '
        Me.pause.Location = New System.Drawing.Point(17, 158)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(190, 51)
        Me.pause.TabIndex = 4
        Me.pause.Text = "Stop the spam bot"
        Me.pause.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "What message would you like to be spamed?"
        '
        'Message
        '
        Me.Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.Location = New System.Drawing.Point(15, 32)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(402, 23)
        Me.Message.TabIndex = 0
        Me.Message.Text = "Type your spam message here"
        '
        'Delay
        '
        Me.Delay.Interval = 5000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "How many times do you want the message to be sent?"
        '
        'TotalSent
        '
        Me.TotalSent.AutoSize = True
        Me.TotalSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSent.Location = New System.Drawing.Point(14, 227)
        Me.TotalSent.Name = "TotalSent"
        Me.TotalSent.Size = New System.Drawing.Size(0, 17)
        Me.TotalSent.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(345, 17)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Spam will start 10 seconds after start button is clicked"
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(15, 89)
        Me.amount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.amount.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(120, 23)
        Me.amount.TabIndex = 2
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(227, 158)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(190, 51)
        Me.Start.TabIndex = 106
        Me.Start.Text = "Start the spam bot"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Begin
        '
        Me.Begin.Interval = 60
        '
        'add1
        '
        Me.add1.Location = New System.Drawing.Point(317, 6)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(100, 20)
        Me.add1.TabIndex = 107
        Me.add1.Text = "1"
        Me.add1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Spam has been sent:"
        '
        'sentcount
        '
        Me.sentcount.Location = New System.Drawing.Point(317, 32)
        Me.sentcount.Name = "sentcount"
        Me.sentcount.Size = New System.Drawing.Size(100, 20)
        Me.sentcount.TabIndex = 110
        Me.sentcount.Text = "0"
        Me.sentcount.Visible = False
        '
        'tcount
        '
        Me.tcount.Location = New System.Drawing.Point(317, 58)
        Me.tcount.Name = "tcount"
        Me.tcount.Size = New System.Drawing.Size(100, 20)
        Me.tcount.TabIndex = 112
        Me.tcount.Text = "0"
        Me.tcount.Visible = False
        '
        'sentcounter
        '
        Me.sentcounter.AutoSize = True
        Me.sentcounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sentcounter.Location = New System.Drawing.Point(160, 227)
        Me.sentcounter.Name = "sentcounter"
        Me.sentcounter.Size = New System.Drawing.Size(12, 17)
        Me.sentcounter.TabIndex = 113
        Me.sentcounter.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 260)
        Me.Controls.Add(Me.sentcounter)
        Me.Controls.Add(Me.tcount)
        Me.Controls.Add(Me.sentcount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pause)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.amount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pause As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Message As System.Windows.Forms.TextBox
    Friend WithEvents Delay As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Friend WithEvents TotalSent As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents amount As System.Windows.Forms.NumericUpDown

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Begin As System.Windows.Forms.Timer
    Friend WithEvents add1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sentcount As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tcount As System.Windows.Forms.MaskedTextBox
    Friend WithEvents sentcounter As Label
End Class
