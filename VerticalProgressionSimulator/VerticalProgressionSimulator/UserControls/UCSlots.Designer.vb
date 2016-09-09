<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCSlots
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.PanelSlots = New System.Windows.Forms.Panel()
    Me.ButtonUpdate = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.PanelSlots, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.ButtonUpdate, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(546, 420)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'PanelSlots
    '
    Me.PanelSlots.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelSlots.Location = New System.Drawing.Point(3, 33)
    Me.PanelSlots.Name = "PanelSlots"
    Me.PanelSlots.Size = New System.Drawing.Size(540, 384)
    Me.PanelSlots.TabIndex = 0
    '
    'ButtonUpdate
    '
    Me.ButtonUpdate.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonUpdate.Location = New System.Drawing.Point(3, 3)
    Me.ButtonUpdate.Name = "ButtonUpdate"
    Me.ButtonUpdate.Size = New System.Drawing.Size(540, 24)
    Me.ButtonUpdate.TabIndex = 1
    Me.ButtonUpdate.Text = "Update positions"
    Me.ButtonUpdate.UseVisualStyleBackColor = True
    '
    'UCSlots
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "UCSlots"
    Me.Size = New System.Drawing.Size(546, 420)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents PanelSlots As Panel
  Friend WithEvents ButtonUpdate As Button
End Class
