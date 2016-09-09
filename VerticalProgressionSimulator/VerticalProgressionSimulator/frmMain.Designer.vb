<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
    Me.PanelContainer = New System.Windows.Forms.Panel()
    Me.TimerFrame = New System.Windows.Forms.Timer(Me.components)
    Me.ButtonExpand = New System.Windows.Forms.Button()
    Me.ButtonAction = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.UcSlots1 = New VerticalProgressionSimulator.UCSlots()
    Me.TableLayoutPanelVizControls = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelScenePath = New System.Windows.Forms.Label()
    Me.LabelSceneName = New System.Windows.Forms.Label()
    Me.TextBoxSceneBasePath = New System.Windows.Forms.TextBox()
    Me.TextBoxSceneName = New System.Windows.Forms.TextBox()
    Me.ButtonReload = New System.Windows.Forms.Button()
    Me.ButtonActivateScene = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ButtonShowDIR_VERTICAL = New System.Windows.Forms.Button()
    Me.ButtonHideDIR_VERTICAL = New System.Windows.Forms.Button()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelVizEngine = New System.Windows.Forms.Label()
    Me.TableLayoutPanelAllPositions = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonSendEachSlotInfo = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanelVizControls.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanelAllPositions.SuspendLayout()
    Me.SuspendLayout()
    '
    'PanelContainer
    '
    Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PanelContainer.Location = New System.Drawing.Point(3, 53)
    Me.PanelContainer.Name = "PanelContainer"
    Me.PanelContainer.Size = New System.Drawing.Size(244, 399)
    Me.PanelContainer.TabIndex = 1
    '
    'TimerFrame
    '
    Me.TimerFrame.Enabled = True
    Me.TimerFrame.Interval = 2
    '
    'ButtonExpand
    '
    Me.ButtonExpand.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonExpand.Location = New System.Drawing.Point(125, 3)
    Me.ButtonExpand.Name = "ButtonExpand"
    Me.ButtonExpand.Size = New System.Drawing.Size(116, 28)
    Me.ButtonExpand.TabIndex = 6
    Me.ButtonExpand.Text = "Random expand"
    Me.ButtonExpand.UseVisualStyleBackColor = True
    '
    'ButtonAction
    '
    Me.ButtonAction.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonAction.Location = New System.Drawing.Point(3, 3)
    Me.ButtonAction.Name = "ButtonAction"
    Me.ButtonAction.Size = New System.Drawing.Size(116, 28)
    Me.ButtonAction.TabIndex = 5
    Me.ButtonAction.Text = "Random move"
    Me.ButtonAction.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.PanelContainer, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.UcSlots1, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelVizControls, 2, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelAllPositions, 1, 2)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(977, 495)
    Me.TableLayoutPanel1.TabIndex = 7
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.ButtonAction, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.ButtonExpand, 1, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 458)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(244, 34)
    Me.TableLayoutPanel2.TabIndex = 2
    '
    'UcSlots1
    '
    Me.UcSlots1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.UcSlots1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcSlots1.Location = New System.Drawing.Point(253, 53)
    Me.UcSlots1.Name = "UcSlots1"
    Me.UcSlots1.Size = New System.Drawing.Size(444, 399)
    Me.UcSlots1.TabIndex = 3
    '
    'TableLayoutPanelVizControls
    '
    Me.TableLayoutPanelVizControls.ColumnCount = 3
    Me.TableLayoutPanelVizControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelVizControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelVizControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelVizControls.Controls.Add(Me.LabelScenePath, 0, 0)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.LabelSceneName, 0, 1)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.TextBoxSceneBasePath, 1, 0)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.TextBoxSceneName, 1, 1)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.ButtonReload, 1, 2)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.ButtonActivateScene, 2, 2)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.Label1, 0, 3)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.ButtonShowDIR_VERTICAL, 1, 3)
    Me.TableLayoutPanelVizControls.Controls.Add(Me.ButtonHideDIR_VERTICAL, 2, 3)
    Me.TableLayoutPanelVizControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelVizControls.Location = New System.Drawing.Point(703, 53)
    Me.TableLayoutPanelVizControls.Name = "TableLayoutPanelVizControls"
    Me.TableLayoutPanelVizControls.RowCount = 10
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanelVizControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelVizControls.Size = New System.Drawing.Size(271, 399)
    Me.TableLayoutPanelVizControls.TabIndex = 4
    '
    'LabelScenePath
    '
    Me.LabelScenePath.AutoSize = True
    Me.LabelScenePath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelScenePath.Location = New System.Drawing.Point(3, 0)
    Me.LabelScenePath.Name = "LabelScenePath"
    Me.LabelScenePath.Size = New System.Drawing.Size(84, 30)
    Me.LabelScenePath.TabIndex = 0
    Me.LabelScenePath.Text = "Scene path"
    Me.LabelScenePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelSceneName
    '
    Me.LabelSceneName.AutoSize = True
    Me.LabelSceneName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelSceneName.Location = New System.Drawing.Point(3, 30)
    Me.LabelSceneName.Name = "LabelSceneName"
    Me.LabelSceneName.Size = New System.Drawing.Size(84, 30)
    Me.LabelSceneName.TabIndex = 1
    Me.LabelSceneName.Text = "Scene name"
    Me.LabelSceneName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxSceneBasePath
    '
    Me.TableLayoutPanelVizControls.SetColumnSpan(Me.TextBoxSceneBasePath, 2)
    Me.TextBoxSceneBasePath.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxSceneBasePath.Location = New System.Drawing.Point(93, 3)
    Me.TextBoxSceneBasePath.Name = "TextBoxSceneBasePath"
    Me.TextBoxSceneBasePath.Size = New System.Drawing.Size(175, 22)
    Me.TextBoxSceneBasePath.TabIndex = 2
    '
    'TextBoxSceneName
    '
    Me.TableLayoutPanelVizControls.SetColumnSpan(Me.TextBoxSceneName, 2)
    Me.TextBoxSceneName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxSceneName.Location = New System.Drawing.Point(93, 33)
    Me.TextBoxSceneName.Name = "TextBoxSceneName"
    Me.TextBoxSceneName.Size = New System.Drawing.Size(175, 22)
    Me.TextBoxSceneName.TabIndex = 3
    '
    'ButtonReload
    '
    Me.ButtonReload.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonReload.Location = New System.Drawing.Point(93, 63)
    Me.ButtonReload.Name = "ButtonReload"
    Me.ButtonReload.Size = New System.Drawing.Size(84, 24)
    Me.ButtonReload.TabIndex = 4
    Me.ButtonReload.Text = "Reload scene"
    Me.ButtonReload.UseVisualStyleBackColor = True
    '
    'ButtonActivateScene
    '
    Me.ButtonActivateScene.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonActivateScene.Location = New System.Drawing.Point(183, 63)
    Me.ButtonActivateScene.Name = "ButtonActivateScene"
    Me.ButtonActivateScene.Size = New System.Drawing.Size(85, 24)
    Me.ButtonActivateScene.TabIndex = 5
    Me.ButtonActivateScene.Text = "Activate scene"
    Me.ButtonActivateScene.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 90)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(77, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "DIR_VERTICAL"
    '
    'ButtonShowDIR_VERTICAL
    '
    Me.ButtonShowDIR_VERTICAL.Location = New System.Drawing.Point(93, 93)
    Me.ButtonShowDIR_VERTICAL.Name = "ButtonShowDIR_VERTICAL"
    Me.ButtonShowDIR_VERTICAL.Size = New System.Drawing.Size(72, 23)
    Me.ButtonShowDIR_VERTICAL.TabIndex = 7
    Me.ButtonShowDIR_VERTICAL.Text = "Show"
    Me.ButtonShowDIR_VERTICAL.UseVisualStyleBackColor = True
    '
    'ButtonHideDIR_VERTICAL
    '
    Me.ButtonHideDIR_VERTICAL.Location = New System.Drawing.Point(183, 93)
    Me.ButtonHideDIR_VERTICAL.Name = "ButtonHideDIR_VERTICAL"
    Me.ButtonHideDIR_VERTICAL.Size = New System.Drawing.Size(68, 24)
    Me.ButtonHideDIR_VERTICAL.TabIndex = 8
    Me.ButtonHideDIR_VERTICAL.Text = "Hide"
    Me.ButtonHideDIR_VERTICAL.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.LabelVizEngine, 0, 0)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(703, 3)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 2
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 44)
    Me.TableLayoutPanel3.TabIndex = 5
    '
    'LabelVizEngine
    '
    Me.LabelVizEngine.AutoSize = True
    Me.LabelVizEngine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelVizEngine.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelVizEngine.Location = New System.Drawing.Point(3, 0)
    Me.LabelVizEngine.Name = "LabelVizEngine"
    Me.LabelVizEngine.Size = New System.Drawing.Size(94, 22)
    Me.LabelVizEngine.TabIndex = 0
    Me.LabelVizEngine.Text = "Viz host"
    Me.LabelVizEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'TableLayoutPanelAllPositions
    '
    Me.TableLayoutPanelAllPositions.ColumnCount = 4
    Me.TableLayoutPanelAllPositions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAllPositions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAllPositions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAllPositions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanelAllPositions.Controls.Add(Me.ButtonSendEachSlotInfo, 0, 0)
    Me.TableLayoutPanelAllPositions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAllPositions.Location = New System.Drawing.Point(253, 458)
    Me.TableLayoutPanelAllPositions.Name = "TableLayoutPanelAllPositions"
    Me.TableLayoutPanelAllPositions.RowCount = 1
    Me.TableLayoutPanelAllPositions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAllPositions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
    Me.TableLayoutPanelAllPositions.Size = New System.Drawing.Size(444, 34)
    Me.TableLayoutPanelAllPositions.TabIndex = 7
    '
    'ButtonSendEachSlotInfo
    '
    Me.ButtonSendEachSlotInfo.Location = New System.Drawing.Point(3, 3)
    Me.ButtonSendEachSlotInfo.Name = "ButtonSendEachSlotInfo"
    Me.ButtonSendEachSlotInfo.Size = New System.Drawing.Size(105, 26)
    Me.ButtonSendEachSlotInfo.TabIndex = 6
    Me.ButtonSendEachSlotInfo.Text = "Send info"
    Me.ButtonSendEachSlotInfo.UseVisualStyleBackColor = True
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(977, 495)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmMain"
    Me.Text = "Vertical test"
    Me.TopMost = True
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanelVizControls.ResumeLayout(False)
    Me.TableLayoutPanelVizControls.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanelAllPositions.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents PanelContainer As Panel
  Friend WithEvents TimerFrame As Timer
  Friend WithEvents ButtonExpand As Button
  Friend WithEvents ButtonAction As Button
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents UcSlots1 As UCSlots
  Friend WithEvents TableLayoutPanelVizControls As TableLayoutPanel
  Friend WithEvents LabelScenePath As Label
  Friend WithEvents LabelSceneName As Label
  Friend WithEvents TextBoxSceneBasePath As TextBox
  Friend WithEvents TextBoxSceneName As TextBox
  Friend WithEvents ButtonReload As Button
  Friend WithEvents ButtonActivateScene As Button
  Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
  Friend WithEvents LabelVizEngine As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents ButtonShowDIR_VERTICAL As Button
  Friend WithEvents ButtonHideDIR_VERTICAL As Button
  Friend WithEvents TableLayoutPanelAllPositions As TableLayoutPanel
  Friend WithEvents ButtonSendEachSlotInfo As Button
End Class
