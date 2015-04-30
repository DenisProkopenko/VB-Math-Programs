<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObliqueTriangles
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
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panASA = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSAS = New System.Windows.Forms.GroupBox()
        Me.radaBc = New System.Windows.Forms.RadioButton()
        Me.radbCa = New System.Windows.Forms.RadioButton()
        Me.radcAb = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.panAngles = New System.Windows.Forms.Panel()
        Me.panSSS = New System.Windows.Forms.Panel()
        Me.btnClearSSS = New System.Windows.Forms.Button()
        Me.lblSSSc = New System.Windows.Forms.Label()
        Me.lblSSSb = New System.Windows.Forms.Label()
        Me.lblSSSa = New System.Windows.Forms.Label()
        Me.btnSolveB = New System.Windows.Forms.Button()
        Me.btnSolveC = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnSolveA = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSSSc = New System.Windows.Forms.TextBox()
        Me.txtSSSb = New System.Windows.Forms.TextBox()
        Me.txtSSSa = New System.Windows.Forms.TextBox()
        Me.panMissingAngleSAA = New System.Windows.Forms.Panel()
        Me.lblMissing3rdAngleSAA = New System.Windows.Forms.Label()
        Me.btnFindMissingAngleSAA = New System.Windows.Forms.Button()
        Me.txtMissingAngle1 = New System.Windows.Forms.TextBox()
        Me.txtMissingAngle2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFindingMissingAngle = New System.Windows.Forms.Label()
        Me.panAnswers1And2 = New System.Windows.Forms.Panel()
        Me.lblLength3SSA2 = New System.Windows.Forms.Label()
        Me.lblLength2SSA2 = New System.Windows.Forms.Label()
        Me.lblLength1SSA2 = New System.Windows.Forms.Label()
        Me.lblAngle3SSA2 = New System.Windows.Forms.Label()
        Me.lblAngle2SSA2 = New System.Windows.Forms.Label()
        Me.lblAngle1SSA2 = New System.Windows.Forms.Label()
        Me.lblLength3SSA1 = New System.Windows.Forms.Label()
        Me.lblLength2SSA1 = New System.Windows.Forms.Label()
        Me.lblLength1SSA1 = New System.Windows.Forms.Label()
        Me.lblAngle3SSA1 = New System.Windows.Forms.Label()
        Me.lblAngle2SSA1 = New System.Windows.Forms.Label()
        Me.lblAngle1SSA1 = New System.Windows.Forms.Label()
        Me.btnContinueToSSS = New System.Windows.Forms.Button()
        Me.lblSASanswer = New System.Windows.Forms.Label()
        Me.btnSolveSAS = New System.Windows.Forms.Button()
        Me.lblMissingAngle = New System.Windows.Forms.Label()
        Me.lblSolutionASA = New System.Windows.Forms.Label()
        Me.lblLetterASA = New System.Windows.Forms.Label()
        Me.btnAnswerASA = New System.Windows.Forms.Button()
        Me.panSolve = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtExampleSide2ofASA = New System.Windows.Forms.TextBox()
        Me.txtSide2 = New System.Windows.Forms.TextBox()
        Me.txtExampleSide1ofASA = New System.Windows.Forms.TextBox()
        Me.txtExampleSine2ofASA = New System.Windows.Forms.TextBox()
        Me.txtExampleSine1ofASA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSine1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSine2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSide1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panSASsolving = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtKnown11 = New System.Windows.Forms.TextBox()
        Me.txtKnown2 = New System.Windows.Forms.TextBox()
        Me.txtKnown1 = New System.Windows.Forms.TextBox()
        Me.txtUnknown = New System.Windows.Forms.TextBox()
        Me.txtKnownCos = New System.Windows.Forms.TextBox()
        Me.txtKnown22 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtExampleKnown11 = New System.Windows.Forms.TextBox()
        Me.txtExampleKnown2 = New System.Windows.Forms.TextBox()
        Me.txtExampleKnown1 = New System.Windows.Forms.TextBox()
        Me.txtExampleUnknown = New System.Windows.Forms.TextBox()
        Me.txtExampleKnownCos = New System.Windows.Forms.TextBox()
        Me.txtExampleKnown22 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnSolveSSA = New System.Windows.Forms.Button()
        Me.picOblique = New System.Windows.Forms.PictureBox()
        Me.picSSA = New System.Windows.Forms.PictureBox()
        Me.grpSAA = New System.Windows.Forms.GroupBox()
        Me.radBCcaSAA = New System.Windows.Forms.RadioButton()
        Me.radBCbaSAA = New System.Windows.Forms.RadioButton()
        Me.radACabSAA = New System.Windows.Forms.RadioButton()
        Me.radACcbSAA = New System.Windows.Forms.RadioButton()
        Me.radABbcSAA = New System.Windows.Forms.RadioButton()
        Me.radABacSAA = New System.Windows.Forms.RadioButton()
        Me.radBCcbSAA = New System.Windows.Forms.RadioButton()
        Me.radACcaSAA = New System.Windows.Forms.RadioButton()
        Me.radACacSAA = New System.Windows.Forms.RadioButton()
        Me.radBCbcSAA = New System.Windows.Forms.RadioButton()
        Me.radABbASAA = New System.Windows.Forms.RadioButton()
        Me.radABabSAA = New System.Windows.Forms.RadioButton()
        Me.grpASA = New System.Windows.Forms.GroupBox()
        Me.radBCcb = New System.Windows.Forms.RadioButton()
        Me.radACca = New System.Windows.Forms.RadioButton()
        Me.radAaCc = New System.Windows.Forms.RadioButton()
        Me.radBbCc = New System.Windows.Forms.RadioButton()
        Me.radABba = New System.Windows.Forms.RadioButton()
        Me.radAaBb = New System.Windows.Forms.RadioButton()
        Me.grpSSA = New System.Windows.Forms.GroupBox()
        Me.radbcC = New System.Windows.Forms.RadioButton()
        Me.radbcB = New System.Windows.Forms.RadioButton()
        Me.radacC = New System.Windows.Forms.RadioButton()
        Me.radacA = New System.Windows.Forms.RadioButton()
        Me.radabB = New System.Windows.Forms.RadioButton()
        Me.radabA = New System.Windows.Forms.RadioButton()
        Me.grpAngleType = New System.Windows.Forms.GroupBox()
        Me.radSSS = New System.Windows.Forms.RadioButton()
        Me.radSAS = New System.Windows.Forms.RadioButton()
        Me.radSSA = New System.Windows.Forms.RadioButton()
        Me.radSAA = New System.Windows.Forms.RadioButton()
        Me.radASA = New System.Windows.Forms.RadioButton()
        Me.btnSAS = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSSA = New System.Windows.Forms.Button()
        Me.btnSAA = New System.Windows.Forms.Button()
        Me.btnASA = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.panASA.SuspendLayout()
        Me.grpSAS.SuspendLayout()
        Me.panAngles.SuspendLayout()
        Me.panSSS.SuspendLayout()
        Me.panMissingAngleSAA.SuspendLayout()
        Me.panAnswers1And2.SuspendLayout()
        Me.panSolve.SuspendLayout()
        Me.panSASsolving.SuspendLayout()
        CType(Me.picOblique, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSSA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSAA.SuspendLayout()
        Me.grpASA.SuspendLayout()
        Me.grpSSA.SuspendLayout()
        Me.grpAngleType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(256, 27)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(75, 23)
        Me.btnInstructions.TabIndex = 26
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.InstructionsToolStripMenuItem.Text = "&Instructions"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear Everything"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'panASA
        '
        Me.panASA.BackColor = System.Drawing.Color.Transparent
        Me.panASA.Controls.Add(Me.grpAngleType)
        Me.panASA.Controls.Add(Me.btnExit)
        Me.panASA.Controls.Add(Me.grpSAS)
        Me.panASA.Controls.Add(Me.btnClear)
        Me.panASA.Controls.Add(Me.panAngles)
        Me.panASA.Controls.Add(Me.grpSSA)
        Me.panASA.Controls.Add(Me.btnSAS)
        Me.panASA.Controls.Add(Me.btnNext)
        Me.panASA.Controls.Add(Me.btnSSA)
        Me.panASA.Controls.Add(Me.btnSAA)
        Me.panASA.Controls.Add(Me.btnASA)
        Me.panASA.Controls.Add(Me.grpSAA)
        Me.panASA.Controls.Add(Me.grpASA)
        Me.panASA.Location = New System.Drawing.Point(2, 82)
        Me.panASA.Name = "panASA"
        Me.panASA.Size = New System.Drawing.Size(581, 599)
        Me.panASA.TabIndex = 27
        Me.panASA.Visible = False
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(434, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'grpSAS
        '
        Me.grpSAS.BackColor = System.Drawing.Color.SkyBlue
        Me.grpSAS.Controls.Add(Me.radaBc)
        Me.grpSAS.Controls.Add(Me.radbCa)
        Me.grpSAS.Controls.Add(Me.radcAb)
        Me.grpSAS.Location = New System.Drawing.Point(199, 45)
        Me.grpSAS.Name = "grpSAS"
        Me.grpSAS.Size = New System.Drawing.Size(180, 89)
        Me.grpSAS.TabIndex = 17
        Me.grpSAS.TabStop = False
        Me.grpSAS.Text = "Known Values of SAS"
        '
        'radaBc
        '
        Me.radaBc.AutoSize = True
        Me.radaBc.Location = New System.Drawing.Point(6, 65)
        Me.radaBc.Name = "radaBc"
        Me.radaBc.Size = New System.Drawing.Size(170, 17)
        Me.radaBc.TabIndex = 2
        Me.radaBc.TabStop = True
        Me.radaBc.Text = "Side ( a ), Angle ( B ), Side ( c )"
        Me.radaBc.UseVisualStyleBackColor = True
        '
        'radbCa
        '
        Me.radbCa.AutoSize = True
        Me.radbCa.Location = New System.Drawing.Point(6, 42)
        Me.radbCa.Name = "radbCa"
        Me.radbCa.Size = New System.Drawing.Size(170, 17)
        Me.radbCa.TabIndex = 1
        Me.radbCa.TabStop = True
        Me.radbCa.Text = "Side ( b ), Angle ( C ), Side ( a )"
        Me.radbCa.UseVisualStyleBackColor = True
        '
        'radcAb
        '
        Me.radcAb.AutoSize = True
        Me.radcAb.Location = New System.Drawing.Point(6, 19)
        Me.radcAb.Name = "radcAb"
        Me.radcAb.Size = New System.Drawing.Size(170, 17)
        Me.radcAb.TabIndex = 0
        Me.radcAb.TabStop = True
        Me.radcAb.Text = "Side ( c ), Angle ( A ), Side ( b )"
        Me.radcAb.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(296, 177)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear Everything"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'panAngles
        '
        Me.panAngles.BackColor = System.Drawing.Color.Transparent
        Me.panAngles.Controls.Add(Me.panSSS)
        Me.panAngles.Controls.Add(Me.panMissingAngleSAA)
        Me.panAngles.Controls.Add(Me.panAnswers1And2)
        Me.panAngles.Controls.Add(Me.btnContinueToSSS)
        Me.panAngles.Controls.Add(Me.lblSASanswer)
        Me.panAngles.Controls.Add(Me.btnSolveSAS)
        Me.panAngles.Controls.Add(Me.lblMissingAngle)
        Me.panAngles.Controls.Add(Me.lblSolutionASA)
        Me.panAngles.Controls.Add(Me.lblLetterASA)
        Me.panAngles.Controls.Add(Me.btnAnswerASA)
        Me.panAngles.Controls.Add(Me.panSolve)
        Me.panAngles.Controls.Add(Me.panSASsolving)
        Me.panAngles.Controls.Add(Me.btnSolveSSA)
        Me.panAngles.Controls.Add(Me.picOblique)
        Me.panAngles.Controls.Add(Me.picSSA)
        Me.panAngles.Location = New System.Drawing.Point(12, 206)
        Me.panAngles.Name = "panAngles"
        Me.panAngles.Size = New System.Drawing.Size(555, 379)
        Me.panAngles.TabIndex = 10
        '
        'panSSS
        '
        Me.panSSS.BackColor = System.Drawing.Color.SkyBlue
        Me.panSSS.Controls.Add(Me.btnClearSSS)
        Me.panSSS.Controls.Add(Me.lblSSSc)
        Me.panSSS.Controls.Add(Me.lblSSSb)
        Me.panSSS.Controls.Add(Me.lblSSSa)
        Me.panSSS.Controls.Add(Me.btnSolveB)
        Me.panSSS.Controls.Add(Me.btnSolveC)
        Me.panSSS.Controls.Add(Me.Label26)
        Me.panSSS.Controls.Add(Me.Label25)
        Me.panSSS.Controls.Add(Me.btnSolveA)
        Me.panSSS.Controls.Add(Me.Label24)
        Me.panSSS.Controls.Add(Me.txtSSSc)
        Me.panSSS.Controls.Add(Me.txtSSSb)
        Me.panSSS.Controls.Add(Me.txtSSSa)
        Me.panSSS.Location = New System.Drawing.Point(276, 3)
        Me.panSSS.Name = "panSSS"
        Me.panSSS.Size = New System.Drawing.Size(259, 273)
        Me.panSSS.TabIndex = 17
        Me.panSSS.Visible = False
        '
        'btnClearSSS
        '
        Me.btnClearSSS.Location = New System.Drawing.Point(92, 123)
        Me.btnClearSSS.Name = "btnClearSSS"
        Me.btnClearSSS.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSSS.TabIndex = 41
        Me.btnClearSSS.Text = "Clear"
        Me.btnClearSSS.UseVisualStyleBackColor = True
        '
        'lblSSSc
        '
        Me.lblSSSc.AutoSize = True
        Me.lblSSSc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSSc.Location = New System.Drawing.Point(59, 218)
        Me.lblSSSc.Name = "lblSSSc"
        Me.lblSSSc.Size = New System.Drawing.Size(0, 16)
        Me.lblSSSc.TabIndex = 40
        '
        'lblSSSb
        '
        Me.lblSSSb.AutoSize = True
        Me.lblSSSb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSSb.Location = New System.Drawing.Point(59, 191)
        Me.lblSSSb.Name = "lblSSSb"
        Me.lblSSSb.Size = New System.Drawing.Size(0, 16)
        Me.lblSSSb.TabIndex = 39
        '
        'lblSSSa
        '
        Me.lblSSSa.AutoSize = True
        Me.lblSSSa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSSa.Location = New System.Drawing.Point(59, 164)
        Me.lblSSSa.Name = "lblSSSa"
        Me.lblSSSa.Size = New System.Drawing.Size(0, 16)
        Me.lblSSSa.TabIndex = 38
        '
        'btnSolveB
        '
        Me.btnSolveB.Location = New System.Drawing.Point(92, 94)
        Me.btnSolveB.Name = "btnSolveB"
        Me.btnSolveB.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveB.TabIndex = 36
        Me.btnSolveB.Text = "Solve ( B )"
        Me.btnSolveB.UseVisualStyleBackColor = True
        '
        'btnSolveC
        '
        Me.btnSolveC.Location = New System.Drawing.Point(173, 94)
        Me.btnSolveC.Name = "btnSolveC"
        Me.btnSolveC.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveC.TabIndex = 37
        Me.btnSolveC.Text = "Solve ( C )"
        Me.btnSolveC.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(56, 66)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 13)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Side Length ( c )"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(56, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Side Length ( b )"
        '
        'btnSolveA
        '
        Me.btnSolveA.Location = New System.Drawing.Point(11, 94)
        Me.btnSolveA.Name = "btnSolveA"
        Me.btnSolveA.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveA.TabIndex = 35
        Me.btnSolveA.Text = "Solve ( A )"
        Me.btnSolveA.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(56, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Side Length ( a )"
        '
        'txtSSSc
        '
        Me.txtSSSc.Location = New System.Drawing.Point(147, 63)
        Me.txtSSSc.Name = "txtSSSc"
        Me.txtSSSc.Size = New System.Drawing.Size(56, 20)
        Me.txtSSSc.TabIndex = 2
        Me.txtSSSc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSSb
        '
        Me.txtSSSb.Location = New System.Drawing.Point(147, 36)
        Me.txtSSSb.Name = "txtSSSb"
        Me.txtSSSb.Size = New System.Drawing.Size(56, 20)
        Me.txtSSSb.TabIndex = 1
        Me.txtSSSb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSSa
        '
        Me.txtSSSa.BackColor = System.Drawing.Color.White
        Me.txtSSSa.Location = New System.Drawing.Point(147, 9)
        Me.txtSSSa.Name = "txtSSSa"
        Me.txtSSSa.Size = New System.Drawing.Size(56, 20)
        Me.txtSSSa.TabIndex = 0
        Me.txtSSSa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panMissingAngleSAA
        '
        Me.panMissingAngleSAA.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panMissingAngleSAA.Controls.Add(Me.lblMissing3rdAngleSAA)
        Me.panMissingAngleSAA.Controls.Add(Me.btnFindMissingAngleSAA)
        Me.panMissingAngleSAA.Controls.Add(Me.txtMissingAngle1)
        Me.panMissingAngleSAA.Controls.Add(Me.txtMissingAngle2)
        Me.panMissingAngleSAA.Controls.Add(Me.Label3)
        Me.panMissingAngleSAA.Controls.Add(Me.Label2)
        Me.panMissingAngleSAA.Controls.Add(Me.lblFindingMissingAngle)
        Me.panMissingAngleSAA.Location = New System.Drawing.Point(86, 178)
        Me.panMissingAngleSAA.Name = "panMissingAngleSAA"
        Me.panMissingAngleSAA.Size = New System.Drawing.Size(215, 168)
        Me.panMissingAngleSAA.TabIndex = 25
        Me.panMissingAngleSAA.Visible = False
        '
        'lblMissing3rdAngleSAA
        '
        Me.lblMissing3rdAngleSAA.AutoSize = True
        Me.lblMissing3rdAngleSAA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissing3rdAngleSAA.Location = New System.Drawing.Point(30, 125)
        Me.lblMissing3rdAngleSAA.Name = "lblMissing3rdAngleSAA"
        Me.lblMissing3rdAngleSAA.Size = New System.Drawing.Size(0, 16)
        Me.lblMissing3rdAngleSAA.TabIndex = 27
        '
        'btnFindMissingAngleSAA
        '
        Me.btnFindMissingAngleSAA.Location = New System.Drawing.Point(48, 87)
        Me.btnFindMissingAngleSAA.Name = "btnFindMissingAngleSAA"
        Me.btnFindMissingAngleSAA.Size = New System.Drawing.Size(119, 23)
        Me.btnFindMissingAngleSAA.TabIndex = 26
        Me.btnFindMissingAngleSAA.Text = "Find Missing Angle"
        Me.btnFindMissingAngleSAA.UseVisualStyleBackColor = True
        '
        'txtMissingAngle1
        '
        Me.txtMissingAngle1.Location = New System.Drawing.Point(123, 35)
        Me.txtMissingAngle1.Name = "txtMissingAngle1"
        Me.txtMissingAngle1.Size = New System.Drawing.Size(61, 20)
        Me.txtMissingAngle1.TabIndex = 22
        Me.txtMissingAngle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMissingAngle2
        '
        Me.txtMissingAngle2.Location = New System.Drawing.Point(123, 61)
        Me.txtMissingAngle2.Name = "txtMissingAngle2"
        Me.txtMissingAngle2.Size = New System.Drawing.Size(61, 20)
        Me.txtMissingAngle2.TabIndex = 23
        Me.txtMissingAngle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Known 2nd Angle:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Known 1st Angle:"
        '
        'lblFindingMissingAngle
        '
        Me.lblFindingMissingAngle.AutoSize = True
        Me.lblFindingMissingAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindingMissingAngle.Location = New System.Drawing.Point(6, 1)
        Me.lblFindingMissingAngle.Name = "lblFindingMissingAngle"
        Me.lblFindingMissingAngle.Size = New System.Drawing.Size(202, 16)
        Me.lblFindingMissingAngle.TabIndex = 20
        Me.lblFindingMissingAngle.Text = "First: Find the Missing Angle"
        '
        'panAnswers1And2
        '
        Me.panAnswers1And2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panAnswers1And2.Controls.Add(Me.lblLength3SSA2)
        Me.panAnswers1And2.Controls.Add(Me.lblLength2SSA2)
        Me.panAnswers1And2.Controls.Add(Me.lblLength1SSA2)
        Me.panAnswers1And2.Controls.Add(Me.lblAngle3SSA2)
        Me.panAnswers1And2.Controls.Add(Me.lblAngle2SSA2)
        Me.panAnswers1And2.Controls.Add(Me.lblAngle1SSA2)
        Me.panAnswers1And2.Controls.Add(Me.lblLength3SSA1)
        Me.panAnswers1And2.Controls.Add(Me.lblLength2SSA1)
        Me.panAnswers1And2.Controls.Add(Me.lblLength1SSA1)
        Me.panAnswers1And2.Controls.Add(Me.lblAngle3SSA1)
        Me.panAnswers1And2.Controls.Add(Me.lblAngle2SSA1)
        Me.panAnswers1And2.Controls.Add(Me.lblAngle1SSA1)
        Me.panAnswers1And2.Location = New System.Drawing.Point(3, 205)
        Me.panAnswers1And2.Name = "panAnswers1And2"
        Me.panAnswers1And2.Size = New System.Drawing.Size(413, 162)
        Me.panAnswers1And2.TabIndex = 19
        Me.panAnswers1And2.Visible = False
        '
        'lblLength3SSA2
        '
        Me.lblLength3SSA2.AutoSize = True
        Me.lblLength3SSA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength3SSA2.Location = New System.Drawing.Point(208, 135)
        Me.lblLength3SSA2.Name = "lblLength3SSA2"
        Me.lblLength3SSA2.Size = New System.Drawing.Size(0, 16)
        Me.lblLength3SSA2.TabIndex = 11
        '
        'lblLength2SSA2
        '
        Me.lblLength2SSA2.AutoSize = True
        Me.lblLength2SSA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength2SSA2.Location = New System.Drawing.Point(208, 110)
        Me.lblLength2SSA2.Name = "lblLength2SSA2"
        Me.lblLength2SSA2.Size = New System.Drawing.Size(0, 16)
        Me.lblLength2SSA2.TabIndex = 10
        '
        'lblLength1SSA2
        '
        Me.lblLength1SSA2.AutoSize = True
        Me.lblLength1SSA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength1SSA2.Location = New System.Drawing.Point(208, 85)
        Me.lblLength1SSA2.Name = "lblLength1SSA2"
        Me.lblLength1SSA2.Size = New System.Drawing.Size(0, 16)
        Me.lblLength1SSA2.TabIndex = 9
        '
        'lblAngle3SSA2
        '
        Me.lblAngle3SSA2.AutoSize = True
        Me.lblAngle3SSA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle3SSA2.Location = New System.Drawing.Point(208, 60)
        Me.lblAngle3SSA2.Name = "lblAngle3SSA2"
        Me.lblAngle3SSA2.Size = New System.Drawing.Size(0, 16)
        Me.lblAngle3SSA2.TabIndex = 8
        '
        'lblAngle2SSA2
        '
        Me.lblAngle2SSA2.AutoSize = True
        Me.lblAngle2SSA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle2SSA2.Location = New System.Drawing.Point(208, 35)
        Me.lblAngle2SSA2.Name = "lblAngle2SSA2"
        Me.lblAngle2SSA2.Size = New System.Drawing.Size(0, 16)
        Me.lblAngle2SSA2.TabIndex = 7
        '
        'lblAngle1SSA2
        '
        Me.lblAngle1SSA2.AutoSize = True
        Me.lblAngle1SSA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle1SSA2.Location = New System.Drawing.Point(208, 10)
        Me.lblAngle1SSA2.Name = "lblAngle1SSA2"
        Me.lblAngle1SSA2.Size = New System.Drawing.Size(0, 16)
        Me.lblAngle1SSA2.TabIndex = 6
        '
        'lblLength3SSA1
        '
        Me.lblLength3SSA1.AutoSize = True
        Me.lblLength3SSA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength3SSA1.Location = New System.Drawing.Point(3, 135)
        Me.lblLength3SSA1.Name = "lblLength3SSA1"
        Me.lblLength3SSA1.Size = New System.Drawing.Size(0, 16)
        Me.lblLength3SSA1.TabIndex = 5
        '
        'lblLength2SSA1
        '
        Me.lblLength2SSA1.AutoSize = True
        Me.lblLength2SSA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength2SSA1.Location = New System.Drawing.Point(3, 110)
        Me.lblLength2SSA1.Name = "lblLength2SSA1"
        Me.lblLength2SSA1.Size = New System.Drawing.Size(0, 16)
        Me.lblLength2SSA1.TabIndex = 4
        '
        'lblLength1SSA1
        '
        Me.lblLength1SSA1.AutoSize = True
        Me.lblLength1SSA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength1SSA1.Location = New System.Drawing.Point(3, 85)
        Me.lblLength1SSA1.Name = "lblLength1SSA1"
        Me.lblLength1SSA1.Size = New System.Drawing.Size(0, 16)
        Me.lblLength1SSA1.TabIndex = 3
        '
        'lblAngle3SSA1
        '
        Me.lblAngle3SSA1.AutoSize = True
        Me.lblAngle3SSA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle3SSA1.Location = New System.Drawing.Point(3, 60)
        Me.lblAngle3SSA1.Name = "lblAngle3SSA1"
        Me.lblAngle3SSA1.Size = New System.Drawing.Size(0, 16)
        Me.lblAngle3SSA1.TabIndex = 2
        '
        'lblAngle2SSA1
        '
        Me.lblAngle2SSA1.AutoSize = True
        Me.lblAngle2SSA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle2SSA1.Location = New System.Drawing.Point(3, 35)
        Me.lblAngle2SSA1.Name = "lblAngle2SSA1"
        Me.lblAngle2SSA1.Size = New System.Drawing.Size(0, 16)
        Me.lblAngle2SSA1.TabIndex = 1
        '
        'lblAngle1SSA1
        '
        Me.lblAngle1SSA1.AutoSize = True
        Me.lblAngle1SSA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle1SSA1.Location = New System.Drawing.Point(3, 10)
        Me.lblAngle1SSA1.Name = "lblAngle1SSA1"
        Me.lblAngle1SSA1.Size = New System.Drawing.Size(0, 16)
        Me.lblAngle1SSA1.TabIndex = 0
        '
        'btnContinueToSSS
        '
        Me.btnContinueToSSS.Location = New System.Drawing.Point(349, 276)
        Me.btnContinueToSSS.Name = "btnContinueToSSS"
        Me.btnContinueToSSS.Size = New System.Drawing.Size(105, 23)
        Me.btnContinueToSSS.TabIndex = 34
        Me.btnContinueToSSS.Text = "Continue to SSS"
        Me.btnContinueToSSS.UseVisualStyleBackColor = True
        Me.btnContinueToSSS.Visible = False
        '
        'lblSASanswer
        '
        Me.lblSASanswer.AutoSize = True
        Me.lblSASanswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSASanswer.Location = New System.Drawing.Point(362, 214)
        Me.lblSASanswer.Name = "lblSASanswer"
        Me.lblSASanswer.Size = New System.Drawing.Size(16, 16)
        Me.lblSASanswer.TabIndex = 0
        Me.lblSASanswer.Text = "1"
        '
        'btnSolveSAS
        '
        Me.btnSolveSAS.Location = New System.Drawing.Point(349, 176)
        Me.btnSolveSAS.Name = "btnSolveSAS"
        Me.btnSolveSAS.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveSAS.TabIndex = 28
        Me.btnSolveSAS.Text = "Solve SAS"
        Me.btnSolveSAS.UseVisualStyleBackColor = True
        Me.btnSolveSAS.Visible = False
        '
        'lblMissingAngle
        '
        Me.lblMissingAngle.AutoSize = True
        Me.lblMissingAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissingAngle.Location = New System.Drawing.Point(362, 242)
        Me.lblMissingAngle.Name = "lblMissingAngle"
        Me.lblMissingAngle.Size = New System.Drawing.Size(16, 16)
        Me.lblMissingAngle.TabIndex = 19
        Me.lblMissingAngle.Text = "1"
        '
        'lblSolutionASA
        '
        Me.lblSolutionASA.AutoSize = True
        Me.lblSolutionASA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolutionASA.Location = New System.Drawing.Point(390, 214)
        Me.lblSolutionASA.Name = "lblSolutionASA"
        Me.lblSolutionASA.Size = New System.Drawing.Size(16, 16)
        Me.lblSolutionASA.TabIndex = 18
        Me.lblSolutionASA.Text = "1"
        '
        'lblLetterASA
        '
        Me.lblLetterASA.AutoSize = True
        Me.lblLetterASA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterASA.Location = New System.Drawing.Point(362, 214)
        Me.lblLetterASA.Name = "lblLetterASA"
        Me.lblLetterASA.Size = New System.Drawing.Size(16, 16)
        Me.lblLetterASA.TabIndex = 17
        Me.lblLetterASA.Text = "1"
        '
        'btnAnswerASA
        '
        Me.btnAnswerASA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswerASA.Location = New System.Drawing.Point(379, 176)
        Me.btnAnswerASA.Name = "btnAnswerASA"
        Me.btnAnswerASA.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswerASA.TabIndex = 14
        Me.btnAnswerASA.UseVisualStyleBackColor = True
        Me.btnAnswerASA.Visible = False
        '
        'panSolve
        '
        Me.panSolve.BackColor = System.Drawing.Color.SkyBlue
        Me.panSolve.Controls.Add(Me.Label19)
        Me.panSolve.Controls.Add(Me.Label18)
        Me.panSolve.Controls.Add(Me.txtExampleSide2ofASA)
        Me.panSolve.Controls.Add(Me.txtSide2)
        Me.panSolve.Controls.Add(Me.txtExampleSide1ofASA)
        Me.panSolve.Controls.Add(Me.txtExampleSine2ofASA)
        Me.panSolve.Controls.Add(Me.txtExampleSine1ofASA)
        Me.panSolve.Controls.Add(Me.Label11)
        Me.panSolve.Controls.Add(Me.Label6)
        Me.panSolve.Controls.Add(Me.Label12)
        Me.panSolve.Controls.Add(Me.Label13)
        Me.panSolve.Controls.Add(Me.Label14)
        Me.panSolve.Controls.Add(Me.txtSine1)
        Me.panSolve.Controls.Add(Me.Label15)
        Me.panSolve.Controls.Add(Me.txtSine2)
        Me.panSolve.Controls.Add(Me.Label16)
        Me.panSolve.Controls.Add(Me.txtSide1)
        Me.panSolve.Controls.Add(Me.Label17)
        Me.panSolve.Controls.Add(Me.Label10)
        Me.panSolve.Controls.Add(Me.Label9)
        Me.panSolve.Controls.Add(Me.Label1)
        Me.panSolve.Controls.Add(Me.Label5)
        Me.panSolve.Controls.Add(Me.Label7)
        Me.panSolve.Controls.Add(Me.Label8)
        Me.panSolve.Location = New System.Drawing.Point(319, 3)
        Me.panSolve.Name = "panSolve"
        Me.panSolve.Size = New System.Drawing.Size(216, 169)
        Me.panSolve.TabIndex = 26
        Me.panSolve.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 91)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Known:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Example:"
        '
        'txtExampleSide2ofASA
        '
        Me.txtExampleSide2ofASA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtExampleSide2ofASA.Location = New System.Drawing.Point(154, 43)
        Me.txtExampleSide2ofASA.Name = "txtExampleSide2ofASA"
        Me.txtExampleSide2ofASA.ReadOnly = True
        Me.txtExampleSide2ofASA.Size = New System.Drawing.Size(25, 20)
        Me.txtExampleSide2ofASA.TabIndex = 21
        Me.txtExampleSide2ofASA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSide2
        '
        Me.txtSide2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSide2.Location = New System.Drawing.Point(132, 129)
        Me.txtSide2.Name = "txtSide2"
        Me.txtSide2.Size = New System.Drawing.Size(53, 20)
        Me.txtSide2.TabIndex = 10
        Me.txtSide2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleSide1ofASA
        '
        Me.txtExampleSide1ofASA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtExampleSide1ofASA.Location = New System.Drawing.Point(63, 43)
        Me.txtExampleSide1ofASA.Name = "txtExampleSide1ofASA"
        Me.txtExampleSide1ofASA.ReadOnly = True
        Me.txtExampleSide1ofASA.Size = New System.Drawing.Size(25, 20)
        Me.txtExampleSide1ofASA.TabIndex = 20
        Me.txtExampleSide1ofASA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleSine2ofASA
        '
        Me.txtExampleSine2ofASA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtExampleSine2ofASA.Location = New System.Drawing.Point(169, 21)
        Me.txtExampleSine2ofASA.Name = "txtExampleSine2ofASA"
        Me.txtExampleSine2ofASA.ReadOnly = True
        Me.txtExampleSine2ofASA.Size = New System.Drawing.Size(25, 20)
        Me.txtExampleSine2ofASA.TabIndex = 19
        Me.txtExampleSine2ofASA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleSine1ofASA
        '
        Me.txtExampleSine1ofASA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtExampleSine1ofASA.Location = New System.Drawing.Point(75, 21)
        Me.txtExampleSine1ofASA.Name = "txtExampleSine1ofASA"
        Me.txtExampleSine1ofASA.ReadOnly = True
        Me.txtExampleSine1ofASA.Size = New System.Drawing.Size(25, 20)
        Me.txtExampleSine1ofASA.TabIndex = 18
        Me.txtExampleSine1ofASA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(147, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "(         )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(104, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "="
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "(         )"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(138, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Sine (         )"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(117, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "="
        '
        'txtSine1
        '
        Me.txtSine1.BackColor = System.Drawing.Color.White
        Me.txtSine1.Location = New System.Drawing.Point(50, 107)
        Me.txtSine1.Name = "txtSine1"
        Me.txtSine1.Size = New System.Drawing.Size(38, 20)
        Me.txtSine1.TabIndex = 7
        Me.txtSine1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Sine (         )"
        '
        'txtSine2
        '
        Me.txtSine2.BackColor = System.Drawing.Color.White
        Me.txtSine2.Location = New System.Drawing.Point(156, 107)
        Me.txtSine2.Name = "txtSine2"
        Me.txtSine2.Size = New System.Drawing.Size(38, 20)
        Me.txtSine2.TabIndex = 8
        Me.txtSine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(44, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "__________"
        '
        'txtSide1
        '
        Me.txtSide1.BackColor = System.Drawing.Color.White
        Me.txtSide1.Location = New System.Drawing.Point(30, 129)
        Me.txtSide1.Name = "txtSide1"
        Me.txtSide1.Size = New System.Drawing.Size(53, 20)
        Me.txtSide1.TabIndex = 9
        Me.txtSide1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(136, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "__________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(126, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "(                  )"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "(                  )"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sine (             )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "____________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Sine (             )"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(123, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "____________"
        '
        'panSASsolving
        '
        Me.panSASsolving.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panSASsolving.Controls.Add(Me.Label22)
        Me.panSASsolving.Controls.Add(Me.txtKnown11)
        Me.panSASsolving.Controls.Add(Me.txtKnown2)
        Me.panSASsolving.Controls.Add(Me.txtKnown1)
        Me.panSASsolving.Controls.Add(Me.txtUnknown)
        Me.panSASsolving.Controls.Add(Me.txtKnownCos)
        Me.panSASsolving.Controls.Add(Me.txtKnown22)
        Me.panSASsolving.Controls.Add(Me.Label21)
        Me.panSASsolving.Controls.Add(Me.txtExampleKnown11)
        Me.panSASsolving.Controls.Add(Me.txtExampleKnown2)
        Me.panSASsolving.Controls.Add(Me.txtExampleKnown1)
        Me.panSASsolving.Controls.Add(Me.txtExampleUnknown)
        Me.panSASsolving.Controls.Add(Me.txtExampleKnownCos)
        Me.panSASsolving.Controls.Add(Me.txtExampleKnown22)
        Me.panSASsolving.Controls.Add(Me.Label4)
        Me.panSASsolving.Controls.Add(Me.Label20)
        Me.panSASsolving.Controls.Add(Me.Label23)
        Me.panSASsolving.Location = New System.Drawing.Point(219, 3)
        Me.panSASsolving.Name = "panSASsolving"
        Me.panSASsolving.Size = New System.Drawing.Size(334, 169)
        Me.panSASsolving.TabIndex = 33
        Me.panSASsolving.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(2, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Known:"
        '
        'txtKnown11
        '
        Me.txtKnown11.Location = New System.Drawing.Point(169, 112)
        Me.txtKnown11.Name = "txtKnown11"
        Me.txtKnown11.Size = New System.Drawing.Size(36, 20)
        Me.txtKnown11.TabIndex = 19
        Me.txtKnown11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKnown2
        '
        Me.txtKnown2.Location = New System.Drawing.Point(106, 112)
        Me.txtKnown2.Name = "txtKnown2"
        Me.txtKnown2.Size = New System.Drawing.Size(36, 20)
        Me.txtKnown2.TabIndex = 18
        Me.txtKnown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKnown1
        '
        Me.txtKnown1.Location = New System.Drawing.Point(54, 112)
        Me.txtKnown1.Name = "txtKnown1"
        Me.txtKnown1.Size = New System.Drawing.Size(36, 20)
        Me.txtKnown1.TabIndex = 17
        Me.txtKnown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnknown
        '
        Me.txtUnknown.Location = New System.Drawing.Point(5, 112)
        Me.txtUnknown.Name = "txtUnknown"
        Me.txtUnknown.ReadOnly = True
        Me.txtUnknown.Size = New System.Drawing.Size(36, 20)
        Me.txtUnknown.TabIndex = 15
        Me.txtUnknown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKnownCos
        '
        Me.txtKnownCos.Location = New System.Drawing.Point(282, 112)
        Me.txtKnownCos.Name = "txtKnownCos"
        Me.txtKnownCos.Size = New System.Drawing.Size(36, 20)
        Me.txtKnownCos.TabIndex = 21
        Me.txtKnownCos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKnown22
        '
        Me.txtKnown22.Location = New System.Drawing.Point(219, 112)
        Me.txtKnown22.Name = "txtKnown22"
        Me.txtKnown22.Size = New System.Drawing.Size(36, 20)
        Me.txtKnown22.TabIndex = 20
        Me.txtKnown22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(38, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(291, 13)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "=                +               -  (2               x              Cos (        " & _
    "     ))"
        '
        'txtExampleKnown11
        '
        Me.txtExampleKnown11.Location = New System.Drawing.Point(169, 40)
        Me.txtExampleKnown11.Name = "txtExampleKnown11"
        Me.txtExampleKnown11.ReadOnly = True
        Me.txtExampleKnown11.Size = New System.Drawing.Size(36, 20)
        Me.txtExampleKnown11.TabIndex = 5
        Me.txtExampleKnown11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleKnown2
        '
        Me.txtExampleKnown2.Location = New System.Drawing.Point(106, 40)
        Me.txtExampleKnown2.Name = "txtExampleKnown2"
        Me.txtExampleKnown2.ReadOnly = True
        Me.txtExampleKnown2.Size = New System.Drawing.Size(36, 20)
        Me.txtExampleKnown2.TabIndex = 4
        Me.txtExampleKnown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleKnown1
        '
        Me.txtExampleKnown1.Location = New System.Drawing.Point(54, 40)
        Me.txtExampleKnown1.Name = "txtExampleKnown1"
        Me.txtExampleKnown1.ReadOnly = True
        Me.txtExampleKnown1.Size = New System.Drawing.Size(36, 20)
        Me.txtExampleKnown1.TabIndex = 3
        Me.txtExampleKnown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleUnknown
        '
        Me.txtExampleUnknown.Location = New System.Drawing.Point(5, 40)
        Me.txtExampleUnknown.Name = "txtExampleUnknown"
        Me.txtExampleUnknown.ReadOnly = True
        Me.txtExampleUnknown.Size = New System.Drawing.Size(36, 20)
        Me.txtExampleUnknown.TabIndex = 1
        Me.txtExampleUnknown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleKnownCos
        '
        Me.txtExampleKnownCos.Location = New System.Drawing.Point(282, 40)
        Me.txtExampleKnownCos.Name = "txtExampleKnownCos"
        Me.txtExampleKnownCos.ReadOnly = True
        Me.txtExampleKnownCos.Size = New System.Drawing.Size(36, 20)
        Me.txtExampleKnownCos.TabIndex = 7
        Me.txtExampleKnownCos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExampleKnown22
        '
        Me.txtExampleKnown22.Location = New System.Drawing.Point(219, 40)
        Me.txtExampleKnown22.Name = "txtExampleKnown22"
        Me.txtExampleKnown22.ReadOnly = True
        Me.txtExampleKnown22.Size = New System.Drawing.Size(36, 20)
        Me.txtExampleKnown22.TabIndex = 6
        Me.txtExampleKnown22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Example:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(38, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(291, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "=                +               -  (2               x              Cos (        " & _
    "     ))"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(39, 106)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 9)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "2                       2                        2"
        '
        'btnSolveSSA
        '
        Me.btnSolveSSA.Location = New System.Drawing.Point(379, 176)
        Me.btnSolveSSA.Name = "btnSolveSSA"
        Me.btnSolveSSA.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveSSA.TabIndex = 27
        Me.btnSolveSSA.UseVisualStyleBackColor = True
        '
        'picOblique
        '
        Me.picOblique.BackColor = System.Drawing.Color.SkyBlue
        Me.picOblique.Image = Global.WindowsApplication1.My.Resources.Resources.triangleGeneral
        Me.picOblique.Location = New System.Drawing.Point(1, 2)
        Me.picOblique.Name = "picOblique"
        Me.picOblique.Size = New System.Drawing.Size(215, 169)
        Me.picOblique.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOblique.TabIndex = 13
        Me.picOblique.TabStop = False
        '
        'picSSA
        '
        Me.picSSA.BackColor = System.Drawing.Color.SkyBlue
        Me.picSSA.Image = Global.WindowsApplication1.My.Resources.Resources.triangleGeneral
        Me.picSSA.Location = New System.Drawing.Point(1, 2)
        Me.picSSA.Name = "picSSA"
        Me.picSSA.Size = New System.Drawing.Size(215, 169)
        Me.picSSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSSA.TabIndex = 17
        Me.picSSA.TabStop = False
        Me.picSSA.Visible = False
        '
        'grpSAA
        '
        Me.grpSAA.BackColor = System.Drawing.Color.SkyBlue
        Me.grpSAA.Controls.Add(Me.radBCcaSAA)
        Me.grpSAA.Controls.Add(Me.radBCbaSAA)
        Me.grpSAA.Controls.Add(Me.radACabSAA)
        Me.grpSAA.Controls.Add(Me.radACcbSAA)
        Me.grpSAA.Controls.Add(Me.radABbcSAA)
        Me.grpSAA.Controls.Add(Me.radABacSAA)
        Me.grpSAA.Controls.Add(Me.radBCcbSAA)
        Me.grpSAA.Controls.Add(Me.radACcaSAA)
        Me.grpSAA.Controls.Add(Me.radACacSAA)
        Me.grpSAA.Controls.Add(Me.radBCbcSAA)
        Me.grpSAA.Controls.Add(Me.radABbASAA)
        Me.grpSAA.Controls.Add(Me.radABabSAA)
        Me.grpSAA.Location = New System.Drawing.Point(53, 12)
        Me.grpSAA.Name = "grpSAA"
        Me.grpSAA.Size = New System.Drawing.Size(473, 159)
        Me.grpSAA.TabIndex = 15
        Me.grpSAA.TabStop = False
        Me.grpSAA.Text = "Known Values of SAA"
        Me.grpSAA.Visible = False
        '
        'radBCcaSAA
        '
        Me.radBCcaSAA.AutoSize = True
        Me.radBCcaSAA.Location = New System.Drawing.Point(236, 129)
        Me.radBCcaSAA.Name = "radBCcaSAA"
        Me.radBCcaSAA.Size = New System.Drawing.Size(224, 17)
        Me.radBCcaSAA.TabIndex = 11
        Me.radBCcaSAA.TabStop = True
        Me.radBCcaSAA.Text = "Angle ( B ), Angle ( C ), Side ( c ), Find ( a )"
        Me.radBCcaSAA.UseVisualStyleBackColor = True
        '
        'radBCbaSAA
        '
        Me.radBCbaSAA.AutoSize = True
        Me.radBCbaSAA.Location = New System.Drawing.Point(236, 107)
        Me.radBCbaSAA.Name = "radBCbaSAA"
        Me.radBCbaSAA.Size = New System.Drawing.Size(224, 17)
        Me.radBCbaSAA.TabIndex = 10
        Me.radBCbaSAA.TabStop = True
        Me.radBCbaSAA.Text = "Angle ( B ), Angle ( C ), Side ( b ), Find ( a )"
        Me.radBCbaSAA.UseVisualStyleBackColor = True
        '
        'radACabSAA
        '
        Me.radACabSAA.AutoSize = True
        Me.radACabSAA.Location = New System.Drawing.Point(236, 85)
        Me.radACabSAA.Name = "radACabSAA"
        Me.radACabSAA.Size = New System.Drawing.Size(224, 17)
        Me.radACabSAA.TabIndex = 9
        Me.radACabSAA.TabStop = True
        Me.radACabSAA.Text = "Angle ( A ), Angle ( C ), Side ( a ), Find ( b )"
        Me.radACabSAA.UseVisualStyleBackColor = True
        '
        'radACcbSAA
        '
        Me.radACcbSAA.AutoSize = True
        Me.radACcbSAA.Location = New System.Drawing.Point(236, 63)
        Me.radACcbSAA.Name = "radACcbSAA"
        Me.radACcbSAA.Size = New System.Drawing.Size(224, 17)
        Me.radACcbSAA.TabIndex = 8
        Me.radACcbSAA.TabStop = True
        Me.radACcbSAA.Text = "Angle ( A ), Angle ( C ), Side ( c ), Find ( b )"
        Me.radACcbSAA.UseVisualStyleBackColor = True
        '
        'radABbcSAA
        '
        Me.radABbcSAA.AutoSize = True
        Me.radABbcSAA.Location = New System.Drawing.Point(236, 41)
        Me.radABbcSAA.Name = "radABbcSAA"
        Me.radABbcSAA.Size = New System.Drawing.Size(224, 17)
        Me.radABbcSAA.TabIndex = 7
        Me.radABbcSAA.TabStop = True
        Me.radABbcSAA.Text = "Angle ( A ), Angle ( B ), Side ( b ), Find ( c )"
        Me.radABbcSAA.UseVisualStyleBackColor = True
        '
        'radABacSAA
        '
        Me.radABacSAA.AutoSize = True
        Me.radABacSAA.Location = New System.Drawing.Point(236, 19)
        Me.radABacSAA.Name = "radABacSAA"
        Me.radABacSAA.Size = New System.Drawing.Size(224, 17)
        Me.radABacSAA.TabIndex = 6
        Me.radABacSAA.TabStop = True
        Me.radABacSAA.Text = "Angle ( A ), Angle ( B ), Side ( a ), Find ( c )"
        Me.radABacSAA.UseVisualStyleBackColor = True
        '
        'radBCcbSAA
        '
        Me.radBCcbSAA.AutoSize = True
        Me.radBCcbSAA.Location = New System.Drawing.Point(6, 130)
        Me.radBCcbSAA.Name = "radBCcbSAA"
        Me.radBCcbSAA.Size = New System.Drawing.Size(224, 17)
        Me.radBCcbSAA.TabIndex = 5
        Me.radBCcbSAA.TabStop = True
        Me.radBCcbSAA.Text = "Angle ( B ), Angle ( C ), Side ( c ), Find ( b )"
        Me.radBCcbSAA.UseVisualStyleBackColor = True
        '
        'radACcaSAA
        '
        Me.radACcaSAA.AutoSize = True
        Me.radACcaSAA.Location = New System.Drawing.Point(6, 64)
        Me.radACcaSAA.Name = "radACcaSAA"
        Me.radACcaSAA.Size = New System.Drawing.Size(224, 17)
        Me.radACcaSAA.TabIndex = 4
        Me.radACcaSAA.TabStop = True
        Me.radACcaSAA.Text = "Angle ( A ), Angle ( C ), Side ( c ), Find ( a )"
        Me.radACcaSAA.UseVisualStyleBackColor = True
        '
        'radACacSAA
        '
        Me.radACacSAA.AutoSize = True
        Me.radACacSAA.Location = New System.Drawing.Point(6, 86)
        Me.radACacSAA.Name = "radACacSAA"
        Me.radACacSAA.Size = New System.Drawing.Size(224, 17)
        Me.radACacSAA.TabIndex = 3
        Me.radACacSAA.TabStop = True
        Me.radACacSAA.Text = "Angle ( A ), Angle ( C ), Side ( a ), Find ( c )"
        Me.radACacSAA.UseVisualStyleBackColor = True
        '
        'radBCbcSAA
        '
        Me.radBCbcSAA.AutoSize = True
        Me.radBCbcSAA.Location = New System.Drawing.Point(6, 108)
        Me.radBCbcSAA.Name = "radBCbcSAA"
        Me.radBCbcSAA.Size = New System.Drawing.Size(224, 17)
        Me.radBCbcSAA.TabIndex = 2
        Me.radBCbcSAA.TabStop = True
        Me.radBCbcSAA.Text = "Angle ( B ), Angle ( C ), Side ( b ), Find ( c )"
        Me.radBCbcSAA.UseVisualStyleBackColor = True
        '
        'radABbASAA
        '
        Me.radABbASAA.AutoSize = True
        Me.radABbASAA.Location = New System.Drawing.Point(6, 42)
        Me.radABbASAA.Name = "radABbASAA"
        Me.radABbASAA.Size = New System.Drawing.Size(224, 17)
        Me.radABbASAA.TabIndex = 1
        Me.radABbASAA.TabStop = True
        Me.radABbASAA.Text = "Angle ( A ), Angle ( B ), Side ( b ), Find ( a )"
        Me.radABbASAA.UseVisualStyleBackColor = True
        '
        'radABabSAA
        '
        Me.radABabSAA.AutoSize = True
        Me.radABabSAA.Location = New System.Drawing.Point(6, 20)
        Me.radABabSAA.Name = "radABabSAA"
        Me.radABabSAA.Size = New System.Drawing.Size(224, 17)
        Me.radABabSAA.TabIndex = 0
        Me.radABabSAA.TabStop = True
        Me.radABabSAA.Text = "Angle ( A ), Angle ( B ), Side ( a ), Find ( b )"
        Me.radABabSAA.UseVisualStyleBackColor = True
        '
        'grpASA
        '
        Me.grpASA.BackColor = System.Drawing.Color.SkyBlue
        Me.grpASA.Controls.Add(Me.radBCcb)
        Me.grpASA.Controls.Add(Me.radACca)
        Me.grpASA.Controls.Add(Me.radAaCc)
        Me.grpASA.Controls.Add(Me.radBbCc)
        Me.grpASA.Controls.Add(Me.radABba)
        Me.grpASA.Controls.Add(Me.radAaBb)
        Me.grpASA.Location = New System.Drawing.Point(167, 12)
        Me.grpASA.Name = "grpASA"
        Me.grpASA.Size = New System.Drawing.Size(245, 159)
        Me.grpASA.TabIndex = 12
        Me.grpASA.TabStop = False
        Me.grpASA.Text = "Known Values of ASA"
        Me.grpASA.Visible = False
        '
        'radBCcb
        '
        Me.radBCcb.AutoSize = True
        Me.radBCcb.Location = New System.Drawing.Point(6, 133)
        Me.radBCcb.Name = "radBCcb"
        Me.radBCcb.Size = New System.Drawing.Size(224, 17)
        Me.radBCcb.TabIndex = 5
        Me.radBCcb.TabStop = True
        Me.radBCcb.Text = "Angle ( B ), Angle ( C ), Side ( c ), Find ( b )"
        Me.radBCcb.UseVisualStyleBackColor = True
        '
        'radACca
        '
        Me.radACca.AutoSize = True
        Me.radACca.Location = New System.Drawing.Point(6, 64)
        Me.radACca.Name = "radACca"
        Me.radACca.Size = New System.Drawing.Size(224, 17)
        Me.radACca.TabIndex = 4
        Me.radACca.TabStop = True
        Me.radACca.Text = "Angle ( A ), Angle ( C ), Side ( c ), Find ( a )"
        Me.radACca.UseVisualStyleBackColor = True
        '
        'radAaCc
        '
        Me.radAaCc.AutoSize = True
        Me.radAaCc.Location = New System.Drawing.Point(6, 87)
        Me.radAaCc.Name = "radAaCc"
        Me.radAaCc.Size = New System.Drawing.Size(224, 17)
        Me.radAaCc.TabIndex = 3
        Me.radAaCc.TabStop = True
        Me.radAaCc.Text = "Angle ( A ), Side ( a ), Angle ( C ), Find ( c )"
        Me.radAaCc.UseVisualStyleBackColor = True
        '
        'radBbCc
        '
        Me.radBbCc.AutoSize = True
        Me.radBbCc.Location = New System.Drawing.Point(6, 110)
        Me.radBbCc.Name = "radBbCc"
        Me.radBbCc.Size = New System.Drawing.Size(224, 17)
        Me.radBbCc.TabIndex = 2
        Me.radBbCc.TabStop = True
        Me.radBbCc.Text = "Angle ( B ), Side ( b ), Angle ( C ), Find ( c )"
        Me.radBbCc.UseVisualStyleBackColor = True
        '
        'radABba
        '
        Me.radABba.AutoSize = True
        Me.radABba.Location = New System.Drawing.Point(6, 41)
        Me.radABba.Name = "radABba"
        Me.radABba.Size = New System.Drawing.Size(224, 17)
        Me.radABba.TabIndex = 1
        Me.radABba.TabStop = True
        Me.radABba.Text = "Angle ( A ), Angle ( B ), Side ( b ), Find ( a )"
        Me.radABba.UseVisualStyleBackColor = True
        '
        'radAaBb
        '
        Me.radAaBb.AutoSize = True
        Me.radAaBb.Location = New System.Drawing.Point(6, 20)
        Me.radAaBb.Name = "radAaBb"
        Me.radAaBb.Size = New System.Drawing.Size(224, 17)
        Me.radAaBb.TabIndex = 0
        Me.radAaBb.TabStop = True
        Me.radAaBb.Text = "Angle ( A ), Side ( a ), Angle ( B ), Find ( b )"
        Me.radAaBb.UseVisualStyleBackColor = True
        '
        'grpSSA
        '
        Me.grpSSA.BackColor = System.Drawing.Color.SkyBlue
        Me.grpSSA.Controls.Add(Me.radbcC)
        Me.grpSSA.Controls.Add(Me.radbcB)
        Me.grpSSA.Controls.Add(Me.radacC)
        Me.grpSSA.Controls.Add(Me.radacA)
        Me.grpSSA.Controls.Add(Me.radabB)
        Me.grpSSA.Controls.Add(Me.radabA)
        Me.grpSSA.Location = New System.Drawing.Point(12, 64)
        Me.grpSSA.Name = "grpSSA"
        Me.grpSSA.Size = New System.Drawing.Size(555, 71)
        Me.grpSSA.TabIndex = 18
        Me.grpSSA.TabStop = False
        Me.grpSSA.Text = "Known Values of SSA"
        Me.grpSSA.Visible = False
        '
        'radbcC
        '
        Me.radbcC.AutoSize = True
        Me.radbcC.Location = New System.Drawing.Point(358, 43)
        Me.radbcC.Name = "radbcC"
        Me.radbcC.Size = New System.Drawing.Size(170, 17)
        Me.radbcC.TabIndex = 8
        Me.radbcC.TabStop = True
        Me.radbcC.Text = "Side ( b ), Side ( c ), Angle ( C )"
        Me.radbcC.UseVisualStyleBackColor = True
        '
        'radbcB
        '
        Me.radbcB.AutoSize = True
        Me.radbcB.Location = New System.Drawing.Point(182, 43)
        Me.radbcB.Name = "radbcB"
        Me.radbcB.Size = New System.Drawing.Size(170, 17)
        Me.radbcB.TabIndex = 7
        Me.radbcB.TabStop = True
        Me.radbcB.Text = "Side ( b ), Side ( c ), Angle ( B )"
        Me.radbcB.UseVisualStyleBackColor = True
        '
        'radacC
        '
        Me.radacC.AutoSize = True
        Me.radacC.Location = New System.Drawing.Point(358, 20)
        Me.radacC.Name = "radacC"
        Me.radacC.Size = New System.Drawing.Size(170, 17)
        Me.radacC.TabIndex = 5
        Me.radacC.TabStop = True
        Me.radacC.Text = "Side ( a ), Side ( c ), Angle ( C )"
        Me.radacC.UseVisualStyleBackColor = True
        '
        'radacA
        '
        Me.radacA.AutoSize = True
        Me.radacA.Location = New System.Drawing.Point(6, 43)
        Me.radacA.Name = "radacA"
        Me.radacA.Size = New System.Drawing.Size(170, 17)
        Me.radacA.TabIndex = 3
        Me.radacA.TabStop = True
        Me.radacA.Text = "Side ( a ), Side ( c ), Angle ( A )"
        Me.radacA.UseVisualStyleBackColor = True
        '
        'radabB
        '
        Me.radabB.AutoSize = True
        Me.radabB.Location = New System.Drawing.Point(182, 20)
        Me.radabB.Name = "radabB"
        Me.radabB.Size = New System.Drawing.Size(170, 17)
        Me.radabB.TabIndex = 1
        Me.radabB.TabStop = True
        Me.radabB.Text = "Side ( a ), Side ( b ), Angle ( B )"
        Me.radabB.UseVisualStyleBackColor = True
        '
        'radabA
        '
        Me.radabA.AutoSize = True
        Me.radabA.Location = New System.Drawing.Point(6, 20)
        Me.radabA.Name = "radabA"
        Me.radabA.Size = New System.Drawing.Size(170, 17)
        Me.radabA.TabIndex = 0
        Me.radabA.TabStop = True
        Me.radabA.Text = "Side ( a ), Side ( b ), Angle ( A )"
        Me.radabA.UseVisualStyleBackColor = True
        '
        'grpAngleType
        '
        Me.grpAngleType.BackColor = System.Drawing.Color.SkyBlue
        Me.grpAngleType.Controls.Add(Me.radSSS)
        Me.grpAngleType.Controls.Add(Me.radSAS)
        Me.grpAngleType.Controls.Add(Me.radSSA)
        Me.grpAngleType.Controls.Add(Me.radSAA)
        Me.grpAngleType.Controls.Add(Me.radASA)
        Me.grpAngleType.Location = New System.Drawing.Point(208, 12)
        Me.grpAngleType.Name = "grpAngleType"
        Me.grpAngleType.Size = New System.Drawing.Size(163, 135)
        Me.grpAngleType.TabIndex = 11
        Me.grpAngleType.TabStop = False
        Me.grpAngleType.Text = "Select One Angle Type"
        '
        'radSSS
        '
        Me.radSSS.AutoSize = True
        Me.radSSS.Location = New System.Drawing.Point(6, 107)
        Me.radSSS.Name = "radSSS"
        Me.radSSS.Size = New System.Drawing.Size(124, 17)
        Me.radSSS.TabIndex = 4
        Me.radSSS.TabStop = True
        Me.radSSS.Text = "(SSS) Side Side Side"
        Me.radSSS.UseVisualStyleBackColor = True
        '
        'radSAS
        '
        Me.radSAS.AutoSize = True
        Me.radSAS.Location = New System.Drawing.Point(6, 85)
        Me.radSAS.Name = "radSAS"
        Me.radSAS.Size = New System.Drawing.Size(130, 17)
        Me.radSAS.TabIndex = 3
        Me.radSAS.TabStop = True
        Me.radSAS.Text = "(SAS) Side Angle Side"
        Me.radSAS.UseVisualStyleBackColor = True
        '
        'radSSA
        '
        Me.radSSA.AutoSize = True
        Me.radSSA.Location = New System.Drawing.Point(6, 63)
        Me.radSSA.Name = "radSSA"
        Me.radSSA.Size = New System.Drawing.Size(130, 17)
        Me.radSSA.TabIndex = 2
        Me.radSSA.TabStop = True
        Me.radSSA.Text = "(SSA) Side Side Angle"
        Me.radSSA.UseVisualStyleBackColor = True
        '
        'radSAA
        '
        Me.radSAA.AutoSize = True
        Me.radSAA.Location = New System.Drawing.Point(6, 41)
        Me.radSAA.Name = "radSAA"
        Me.radSAA.Size = New System.Drawing.Size(136, 17)
        Me.radSAA.TabIndex = 1
        Me.radSAA.TabStop = True
        Me.radSAA.Text = "(SAA) Side Angle Angle"
        Me.radSAA.UseVisualStyleBackColor = True
        '
        'radASA
        '
        Me.radASA.AutoSize = True
        Me.radASA.Location = New System.Drawing.Point(6, 19)
        Me.radASA.Name = "radASA"
        Me.radASA.Size = New System.Drawing.Size(136, 17)
        Me.radASA.TabIndex = 0
        Me.radASA.TabStop = True
        Me.radASA.Text = "(ASA) Angle Side Angle"
        Me.radASA.UseVisualStyleBackColor = True
        '
        'btnSAS
        '
        Me.btnSAS.Location = New System.Drawing.Point(185, 177)
        Me.btnSAS.Name = "btnSAS"
        Me.btnSAS.Size = New System.Drawing.Size(97, 23)
        Me.btnSAS.TabIndex = 20
        Me.btnSAS.Text = "Next"
        Me.btnSAS.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(185, 177)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(97, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnSSA
        '
        Me.btnSSA.Location = New System.Drawing.Point(185, 177)
        Me.btnSSA.Name = "btnSSA"
        Me.btnSSA.Size = New System.Drawing.Size(97, 23)
        Me.btnSSA.TabIndex = 17
        Me.btnSSA.Text = "Next"
        Me.btnSSA.UseVisualStyleBackColor = True
        Me.btnSSA.Visible = False
        '
        'btnSAA
        '
        Me.btnSAA.Location = New System.Drawing.Point(185, 177)
        Me.btnSAA.Name = "btnSAA"
        Me.btnSAA.Size = New System.Drawing.Size(97, 23)
        Me.btnSAA.TabIndex = 16
        Me.btnSAA.Text = "Next"
        Me.btnSAA.UseVisualStyleBackColor = True
        Me.btnSAA.Visible = False
        '
        'btnASA
        '
        Me.btnASA.Location = New System.Drawing.Point(185, 177)
        Me.btnASA.Name = "btnASA"
        Me.btnASA.Size = New System.Drawing.Size(97, 23)
        Me.btnASA.TabIndex = 14
        Me.btnASA.Text = "Next"
        Me.btnASA.UseVisualStyleBackColor = True
        Me.btnASA.Visible = False
        '
        'frmObliqueTriangles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.math_and_symbols_image3
        Me.ClientSize = New System.Drawing.Size(583, 685)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.panASA)
        Me.Name = "frmObliqueTriangles"
        Me.Text = "Oblique Triangles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panASA.ResumeLayout(False)
        Me.grpSAS.ResumeLayout(False)
        Me.grpSAS.PerformLayout()
        Me.panAngles.ResumeLayout(False)
        Me.panAngles.PerformLayout()
        Me.panSSS.ResumeLayout(False)
        Me.panSSS.PerformLayout()
        Me.panMissingAngleSAA.ResumeLayout(False)
        Me.panMissingAngleSAA.PerformLayout()
        Me.panAnswers1And2.ResumeLayout(False)
        Me.panAnswers1And2.PerformLayout()
        Me.panSolve.ResumeLayout(False)
        Me.panSolve.PerformLayout()
        Me.panSASsolving.ResumeLayout(False)
        Me.panSASsolving.PerformLayout()
        CType(Me.picOblique, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSSA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSAA.ResumeLayout(False)
        Me.grpSAA.PerformLayout()
        Me.grpASA.ResumeLayout(False)
        Me.grpASA.PerformLayout()
        Me.grpSSA.ResumeLayout(False)
        Me.grpSSA.PerformLayout()
        Me.grpAngleType.ResumeLayout(False)
        Me.grpAngleType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panASA As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpSAS As System.Windows.Forms.GroupBox
    Friend WithEvents radaBc As System.Windows.Forms.RadioButton
    Friend WithEvents radbCa As System.Windows.Forms.RadioButton
    Friend WithEvents radcAb As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents panAngles As System.Windows.Forms.Panel
    Friend WithEvents panSSS As System.Windows.Forms.Panel
    Friend WithEvents btnClearSSS As System.Windows.Forms.Button
    Friend WithEvents lblSSSc As System.Windows.Forms.Label
    Friend WithEvents lblSSSb As System.Windows.Forms.Label
    Friend WithEvents lblSSSa As System.Windows.Forms.Label
    Friend WithEvents btnSolveB As System.Windows.Forms.Button
    Friend WithEvents btnSolveC As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnSolveA As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSSSc As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSb As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSa As System.Windows.Forms.TextBox
    Friend WithEvents panMissingAngleSAA As System.Windows.Forms.Panel
    Friend WithEvents lblMissing3rdAngleSAA As System.Windows.Forms.Label
    Friend WithEvents btnFindMissingAngleSAA As System.Windows.Forms.Button
    Friend WithEvents txtMissingAngle1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMissingAngle2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFindingMissingAngle As System.Windows.Forms.Label
    Friend WithEvents panAnswers1And2 As System.Windows.Forms.Panel
    Friend WithEvents lblLength3SSA2 As System.Windows.Forms.Label
    Friend WithEvents lblLength2SSA2 As System.Windows.Forms.Label
    Friend WithEvents lblLength1SSA2 As System.Windows.Forms.Label
    Friend WithEvents lblAngle3SSA2 As System.Windows.Forms.Label
    Friend WithEvents lblAngle2SSA2 As System.Windows.Forms.Label
    Friend WithEvents lblAngle1SSA2 As System.Windows.Forms.Label
    Friend WithEvents lblLength3SSA1 As System.Windows.Forms.Label
    Friend WithEvents lblLength2SSA1 As System.Windows.Forms.Label
    Friend WithEvents lblLength1SSA1 As System.Windows.Forms.Label
    Friend WithEvents lblAngle3SSA1 As System.Windows.Forms.Label
    Friend WithEvents lblAngle2SSA1 As System.Windows.Forms.Label
    Friend WithEvents lblAngle1SSA1 As System.Windows.Forms.Label
    Friend WithEvents btnContinueToSSS As System.Windows.Forms.Button
    Friend WithEvents lblSASanswer As System.Windows.Forms.Label
    Friend WithEvents btnSolveSAS As System.Windows.Forms.Button
    Friend WithEvents lblMissingAngle As System.Windows.Forms.Label
    Friend WithEvents lblSolutionASA As System.Windows.Forms.Label
    Friend WithEvents lblLetterASA As System.Windows.Forms.Label
    Friend WithEvents btnAnswerASA As System.Windows.Forms.Button
    Friend WithEvents panSolve As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtExampleSide2ofASA As System.Windows.Forms.TextBox
    Friend WithEvents txtSide2 As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleSide1ofASA As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleSine2ofASA As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleSine1ofASA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSine1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSine2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSide1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents panSASsolving As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtKnown11 As System.Windows.Forms.TextBox
    Friend WithEvents txtKnown2 As System.Windows.Forms.TextBox
    Friend WithEvents txtKnown1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUnknown As System.Windows.Forms.TextBox
    Friend WithEvents txtKnownCos As System.Windows.Forms.TextBox
    Friend WithEvents txtKnown22 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtExampleKnown11 As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleKnown2 As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleKnown1 As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleUnknown As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleKnownCos As System.Windows.Forms.TextBox
    Friend WithEvents txtExampleKnown22 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSolveSSA As System.Windows.Forms.Button
    Friend WithEvents picSSA As System.Windows.Forms.PictureBox
    Friend WithEvents picOblique As System.Windows.Forms.PictureBox
    Friend WithEvents grpSAA As System.Windows.Forms.GroupBox
    Friend WithEvents radBCcaSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radBCbaSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radACabSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radACcbSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radABbcSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radABacSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radBCcbSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radACcaSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radACacSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radBCbcSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radABbASAA As System.Windows.Forms.RadioButton
    Friend WithEvents radABabSAA As System.Windows.Forms.RadioButton
    Friend WithEvents grpASA As System.Windows.Forms.GroupBox
    Friend WithEvents radBCcb As System.Windows.Forms.RadioButton
    Friend WithEvents radACca As System.Windows.Forms.RadioButton
    Friend WithEvents radAaCc As System.Windows.Forms.RadioButton
    Friend WithEvents radBbCc As System.Windows.Forms.RadioButton
    Friend WithEvents radABba As System.Windows.Forms.RadioButton
    Friend WithEvents radAaBb As System.Windows.Forms.RadioButton
    Friend WithEvents grpSSA As System.Windows.Forms.GroupBox
    Friend WithEvents radbcC As System.Windows.Forms.RadioButton
    Friend WithEvents radbcB As System.Windows.Forms.RadioButton
    Friend WithEvents radacC As System.Windows.Forms.RadioButton
    Friend WithEvents radacA As System.Windows.Forms.RadioButton
    Friend WithEvents radabB As System.Windows.Forms.RadioButton
    Friend WithEvents radabA As System.Windows.Forms.RadioButton
    Friend WithEvents grpAngleType As System.Windows.Forms.GroupBox
    Friend WithEvents radSSS As System.Windows.Forms.RadioButton
    Friend WithEvents radSAS As System.Windows.Forms.RadioButton
    Friend WithEvents radSSA As System.Windows.Forms.RadioButton
    Friend WithEvents radSAA As System.Windows.Forms.RadioButton
    Friend WithEvents radASA As System.Windows.Forms.RadioButton
    Friend WithEvents btnSAS As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSSA As System.Windows.Forms.Button
    Friend WithEvents btnSAA As System.Windows.Forms.Button
    Friend WithEvents btnASA As System.Windows.Forms.Button

End Class
