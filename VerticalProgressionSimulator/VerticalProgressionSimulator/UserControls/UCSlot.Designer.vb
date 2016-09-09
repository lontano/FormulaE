<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSlot
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.TableLayoutPanelSlot = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelIndex = New System.Windows.Forms.Label()
    Me.TextBoxNumber = New System.Windows.Forms.TextBox()
    Me.NumericUpDownPosition = New System.Windows.Forms.NumericUpDown()
    Me.TextBoxName = New System.Windows.Forms.TextBox()
    Me.CheckBoxExpand = New System.Windows.Forms.CheckBox()
    Me.CheckBoxCarChanged = New System.Windows.Forms.CheckBox()
    Me.CheckBoxInPits = New System.Windows.Forms.CheckBox()
    Me.TableLayoutPanelSlot.SuspendLayout()
    CType(Me.NumericUpDownPosition, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanelSlot
    '
    Me.TableLayoutPanelSlot.ColumnCount = 8
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanelSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanelSlot.Controls.Add(Me.LabelIndex, 0, 0)
    Me.TableLayoutPanelSlot.Controls.Add(Me.TextBoxNumber, 2, 0)
    Me.TableLayoutPanelSlot.Controls.Add(Me.NumericUpDownPosition, 1, 0)
    Me.TableLayoutPanelSlot.Controls.Add(Me.TextBoxName, 3, 0)
    Me.TableLayoutPanelSlot.Controls.Add(Me.CheckBoxExpand, 4, 0)
    Me.TableLayoutPanelSlot.Controls.Add(Me.CheckBoxCarChanged, 5, 0)
    Me.TableLayoutPanelSlot.Controls.Add(Me.CheckBoxInPits, 6, 0)
    Me.TableLayoutPanelSlot.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelSlot.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelSlot.Name = "TableLayoutPanelSlot"
    Me.TableLayoutPanelSlot.RowCount = 1
    Me.TableLayoutPanelSlot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelSlot.Size = New System.Drawing.Size(819, 28)
    Me.TableLayoutPanelSlot.TabIndex = 0
    '
    'LabelIndex
    '
    Me.LabelIndex.AutoSize = True
    Me.LabelIndex.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelIndex.Location = New System.Drawing.Point(3, 0)
    Me.LabelIndex.Name = "LabelIndex"
    Me.LabelIndex.Size = New System.Drawing.Size(44, 28)
    Me.LabelIndex.TabIndex = 1
    Me.LabelIndex.Text = "00"
    Me.LabelIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'TextBoxNumber
    '
    Me.TextBoxNumber.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxNumber.Location = New System.Drawing.Point(103, 3)
    Me.TextBoxNumber.Name = "TextBoxNumber"
    Me.TextBoxNumber.Size = New System.Drawing.Size(44, 20)
    Me.TextBoxNumber.TabIndex = 0
    '
    'NumericUpDownPosition
    '
    Me.NumericUpDownPosition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NumericUpDownPosition.Location = New System.Drawing.Point(53, 3)
    Me.NumericUpDownPosition.Name = "NumericUpDownPosition"
    Me.NumericUpDownPosition.Size = New System.Drawing.Size(44, 20)
    Me.NumericUpDownPosition.TabIndex = 2
    '
    'TextBoxName
    '
    Me.TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxName.Location = New System.Drawing.Point(153, 3)
    Me.TextBoxName.Name = "TextBoxName"
    Me.TextBoxName.Size = New System.Drawing.Size(127, 20)
    Me.TextBoxName.TabIndex = 3
    '
    'CheckBoxExpand
    '
    Me.CheckBoxExpand.AutoSize = True
    Me.CheckBoxExpand.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckBoxExpand.Location = New System.Drawing.Point(286, 3)
    Me.CheckBoxExpand.Name = "CheckBoxExpand"
    Me.CheckBoxExpand.Size = New System.Drawing.Size(127, 22)
    Me.CheckBoxExpand.TabIndex = 4
    Me.CheckBoxExpand.Text = "Expand"
    Me.CheckBoxExpand.UseVisualStyleBackColor = True
    '
    'CheckBoxCarChanged
    '
    Me.CheckBoxCarChanged.AutoSize = True
    Me.CheckBoxCarChanged.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckBoxCarChanged.Location = New System.Drawing.Point(419, 3)
    Me.CheckBoxCarChanged.Name = "CheckBoxCarChanged"
    Me.CheckBoxCarChanged.Size = New System.Drawing.Size(127, 22)
    Me.CheckBoxCarChanged.TabIndex = 5
    Me.CheckBoxCarChanged.Text = "Car changed"
    Me.CheckBoxCarChanged.UseVisualStyleBackColor = True
    '
    'CheckBoxInPits
    '
    Me.CheckBoxInPits.AutoSize = True
    Me.CheckBoxInPits.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckBoxInPits.Location = New System.Drawing.Point(552, 3)
    Me.CheckBoxInPits.Name = "CheckBoxInPits"
    Me.CheckBoxInPits.Size = New System.Drawing.Size(127, 22)
    Me.CheckBoxInPits.TabIndex = 6
    Me.CheckBoxInPits.Text = "In pits"
    Me.CheckBoxInPits.UseVisualStyleBackColor = True
    '
    'UCSlot
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelSlot)
    Me.Name = "UCSlot"
    Me.Size = New System.Drawing.Size(819, 28)
    Me.TableLayoutPanelSlot.ResumeLayout(False)
    Me.TableLayoutPanelSlot.PerformLayout()
    CType(Me.NumericUpDownPosition, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelSlot As TableLayoutPanel
  Friend WithEvents LabelIndex As Label
  Friend WithEvents TextBoxNumber As TextBox
  Friend WithEvents NumericUpDownPosition As NumericUpDown
  Friend WithEvents TextBoxName As TextBox
  Friend WithEvents CheckBoxExpand As CheckBox
  Friend WithEvents CheckBoxCarChanged As CheckBox
  Friend WithEvents CheckBoxInPits As CheckBox
End Class
