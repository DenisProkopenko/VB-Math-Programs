
'Program Name:  Solving Triangles
'Designer:      Denis Prokopenko
'Date:          11/11/2013 to 12/XX/2013
'Purpose:       This aplication allows the user to solve trig functions
'               This program also Guides the user step by step in solving the equasions.

Option Strict Off

Public Class frmObliqueTriangles

    'code to display instructions in a new window
    Private Sub btnInstructions_Click(sender As System.Object, e As System.EventArgs) Handles btnInstructions.Click

        frmInstructions.ShowDialog()        'open new window

    End Sub

    'to display next options
    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click

        If radASA.Checked = True Then               'if radASA is checked Then....
            grpASA.Visible = True                   'visible
            grpSAA.Visible = False                  'invisible
            panSolve.Visible = False                'invisible
            panAngles.Visible = False               'invisible
            panMissingAngleSAA.Visible = False      'invisible
            btnASA.Visible = True                   'visible
            panMissingAngleSAA.Visible = False      'invisible
            grpAngleType.Visible = False            'invisible
            grpASA.Visible = True                   'visible
            grpSAA.Visible = False                  'invisible
            btnNext.Visible = False                 'invisible
            btnASA.Visible = True                   'visible
            btnSAA.Visible = False                  'invisible
            btnSAS.Visible = False                  'invisible
            grpSAS.Visible = False                  'invisible
            btnSolveSAS.Visible = False             'invisible
            panSSS.Visible = False                  'visible

        ElseIf radSAA.Checked = True Then           'if radSAA is checked Then....
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = True                   'visible
            panSolve.Visible = False                'invisible
            panAngles.Visible = True                'visible
            panMissingAngleSAA.Visible = False      'invisible
            picOblique.Visible = False              'invisible
            btnSAA.Visible = True                   'visible
            grpAngleType.Visible = False            'invisible
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = True                   'visible
            btnNext.Visible = False                 'invisible
            btnASA.Visible = False                  'invisible
            btnSAA.Visible = True                   'visible
            btnSAS.Visible = False                  'invisible
            grpSAS.Visible = False                  'invisible
            btnSolveSAS.Visible = False             'invisible
            panSSS.Visible = False                  'visible

        ElseIf radSSA.Checked = True Then           'if radSSA is checked Then....
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = False                  'invisible
            panSolve.Visible = False                'invisible
            panAngles.Visible = False               'invisible
            panMissingAngleSAA.Visible = False      'invisible
            picOblique.Visible = False              'invisible
            btnSAA.Visible = False                  'invisible
            grpAngleType.Visible = False            'invisible
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = False                  'invisible
            grpSSA.Visible = True                   'invisible
            btnNext.Visible = False                 'invisible
            btnASA.Visible = False                  'invisible
            btnSAA.Visible = False                  'invisible
            btnSSA.Visible = True                   'visible
            btnSAS.Visible = False                  'invisible
            grpSAS.Visible = False                  'invisible
            btnSolveSAS.Visible = False             'invisible
            panSSS.Visible = False                  'visible

        ElseIf radSAS.Checked = True Then           'if radSAS is checked Then....
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = False                  'invisible
            panSolve.Visible = True                 'visible
            panAngles.Visible = False               'invisible
            panMissingAngleSAA.Visible = False      'invisible
            picOblique.Visible = True               'visible
            btnSAA.Visible = False                  'invisible
            grpAngleType.Visible = False            'invisible
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = False                  'invisible
            grpSSA.Visible = False                  'invisible
            btnNext.Visible = False                 'invisible
            btnASA.Visible = False                  'invisible
            btnSAA.Visible = False                  'invisible
            btnSSA.Visible = False                  'invisible
            btnSAS.Visible = True                   'visible
            grpSAS.Visible = True                   'visible
            btnSolveSAS.Visible = False             'invisible
            panSSS.Visible = False                  'visible

        ElseIf radSSS.Checked = True Then           '
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = False                  'invisible
            panAngles.Visible = False               'invisible
            panMissingAngleSAA.Visible = False      'invisible
            btnSAA.Visible = False                  'invisible
            grpAngleType.Visible = True             'invisible
            grpASA.Visible = False                  'invisible
            grpSAA.Visible = False                  'invisible
            grpSSA.Visible = False                  'invisible
            btnNext.Visible = True                  'invisible
            btnASA.Visible = False                  'invisible
            btnSAA.Visible = False                  'invisible
            btnSSA.Visible = False                  'invisible
            btnSolveSAS.Visible = False             'invisible
            btnSAS.Visible = False                  'invisible
            grpSAS.Visible = False                  'invisible
            picOblique.Visible = True               'visible
            panSolve.Visible = False                'invisible
            panSSS.Visible = True                   'visible
            panAngles.Visible = True                'visible
            btnContinueToSSS.Visible = False        '
            panSASsolving.Visible = False           '
            btnSolveSAS.Visible = False             '

        Else                                        '
            MsgBox("Please select an Angle Type", , "Oops")
            grpAngleType.Visible = True             'visible
            btnNext.Visible = True                  'visible
        End If                                      'end if function

        txtExampleSine1ofASA.Clear()                'clear
        txtExampleSine2ofASA.Clear()                'clear
        txtExampleSide1ofASA.Clear()                'clear
        txtExampleSide2ofASA.Clear()                'clear
        txtSide1.Clear()                            'clear
        txtSine1.Clear()                            'clear
        txtSine2.Clear()                            'clear
        txtSide2.Clear()                            'clear
        txtMissingAngle1.Clear()                    'clear
        txtMissingAngle2.Clear()                    'clear
        lblMissing3rdAngleSAA.Text = ""             'empty
        txtSSSa.Clear()                             'clear
        txtSSSb.Clear()                             'clear
        txtSSSc.Clear()                             'clear
        txtSSSa.ReadOnly = False                    'Write able
        txtSSSb.ReadOnly = False                    'Write able
        txtSSSc.ReadOnly = False                    'Write able

    End Sub

    'to display next options
    Private Sub btnASA_Click(sender As System.Object, e As System.EventArgs) Handles btnASA.Click

        If radAaBb.Checked = True Then          'ready everything to solve for  a
            txtExampleSine1ofASA.Text = "A"     'set text in a text box
            txtExampleSine2ofASA.Text = "B"     'set text in a text box
            txtExampleSide1ofASA.Text = "a"     'set text in a text box
            txtExampleSide2ofASA.Text = "b"     'set text in a text box

            txtSide2.Text = "b"                 'set text in a text box
            btnAnswerASA.Text = "Find ( b )"    '
            lblLetterASA.Text = "b: "           '

        ElseIf radABba.Checked = True Then      'ready everything to solve for  b
            txtExampleSine1ofASA.Text = "B"     'set text in a text box
            txtExampleSine2ofASA.Text = "A"     'set text in a text box
            txtExampleSide1ofASA.Text = "b"     'set text in a text box
            txtExampleSide2ofASA.Text = "a"     'set text in a text box

            txtSide2.Text = "a"                 'set text in a text box
            btnAnswerASA.Text = "Find ( a )"    'change text in a button
            lblLetterASA.Text = "a: "           'set text in a label

        ElseIf radACca.Checked = True Then      'ready everything to solve for  c
            txtExampleSine1ofASA.Text = "A"     'set text in a text box
            txtExampleSine2ofASA.Text = "C"     'set text in a text box
            txtExampleSide1ofASA.Text = "a"     'set text in a text box
            txtExampleSide2ofASA.Text = "c"     'set text in a text box

            txtSide2.Text = "a"                 'set text in a text box
            btnAnswerASA.Text = "Find ( a )"    'change text in a button
            lblLetterASA.Text = "a: "           'set text in a label

        ElseIf radAaCc.Checked = True Then      'ready everything to solve for  a
            txtExampleSine1ofASA.Text = "A"     'set text in a text box
            txtExampleSine2ofASA.Text = "C"     'set text in a text box
            txtExampleSide1ofASA.Text = "a"     'set text in a text box
            txtExampleSide2ofASA.Text = "c"     'set text in a text box

            txtSide2.Text = "c"                 'set text in a text box
            btnAnswerASA.Text = "Find ( c )"    'change text in a button
            lblLetterASA.Text = "c: "           'set text in a label

        ElseIf radBbCc.Checked = True Then      'ready everything to solve for  c
            txtExampleSine1ofASA.Text = "B"     'set text in a text box
            txtExampleSine2ofASA.Text = "C"     'set text in a text box
            txtExampleSide1ofASA.Text = "b"     'set text in a text box
            txtExampleSide2ofASA.Text = "c"     'set text in a text box

            txtSide2.Text = "c"                 'set text in a text box
            btnAnswerASA.Text = "Find ( c )"    'change text in a button
            lblLetterASA.Text = "c: "           'set text in a label

        ElseIf radBCcb.Checked = True Then      'ready everything to solve for  b
            txtExampleSine1ofASA.Text = "C"     'set text in a text box
            txtExampleSine2ofASA.Text = "B"     'set text in a text box
            txtExampleSide1ofASA.Text = "c"     'set text in a text box
            txtExampleSide2ofASA.Text = "b"     'set text in a text box

            txtSide2.Text = "b"                 'set text in a text box
            btnAnswerASA.Text = "Find ( b )"    'change text in a button
            lblLetterASA.Text = "b: "           'set text in a label

        Else                                    '
            MsgBox("Please select known values of ASA", , "Oops")
        End If                                  '

        txtSide1.Clear()                        'clear
        txtSine1.Clear()                        'clear
        txtSine2.Clear()                        'clear
        txtSide2.ReadOnly = True                'read only
        lblSolutionASA.Visible = False          'invisible
        picOblique.Visible = True               'visible
        panSolve.Visible = True                 'visible
        panAngles.Visible = True                'visible
        panSolve.Visible = True                 'visible
        btnAnswerASA.Visible = True             'visible
        btnSSA.Visible = False                  'invisible
        lblSolutionASA.Text = ""                'empty label
        lblLetterASA.Visible = False            'invisible
        lblMissingAngle.Visible = False         'invisible

    End Sub

    'to display next options
    Private Sub btnSAA_Click(sender As System.Object, e As System.EventArgs) Handles btnSAA.Click

        If radABabSAA.Checked = True Then       'if radio button is checked
            panMissingAngleSAA.Visible = False  'invisible
            txtExampleSine1ofASA.Text = "A"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "B"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "a"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "b"     'set a letter in a text box
            txtSide2.Text = "b"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( b )"    'change text in a button
            panSolve.Enabled = True             'enabled

        ElseIf radABbASAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = False  'invisible
            txtExampleSine1ofASA.Text = "B"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "A"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "b"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "a"     'set a letter in a text box
            txtSide2.Text = "a"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( a )"    'change text in a button
            panSolve.Enabled = True             'enabled

        ElseIf radACcaSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = False  'invisible
            txtExampleSine1ofASA.Text = "C"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "A"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "c"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "a"     'set a letter in a text box
            txtSide2.Text = "a"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( a )"    'change text in a button
            panSolve.Enabled = True             'enabled

        ElseIf radACacSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = False  'invisible
            txtExampleSine1ofASA.Text = "A"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "C"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "a"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "c"     'set a letter in a text box
            txtSide2.Text = "c"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( c )"    'change text in a button
            panSolve.Enabled = True             'enabled

        ElseIf radBCbcSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = False  'invisible
            txtExampleSine1ofASA.Text = "B"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "C"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "b"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "c"     'set a letter in a text box
            txtSide2.Text = "c"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( c )"    'change text in a button
            panSolve.Enabled = True             'enabled

        ElseIf radBCcbSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = False  'invisible
            txtExampleSine1ofASA.Text = "C"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "B"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "c"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "b"     'set a letter in a text box
            txtSide2.Text = "b"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( b )"    'change text in a button
            panSolve.Enabled = True             'enabled

        ElseIf radABacSAA.Checked = True Then   'if radio button is checked, complications start here
            panMissingAngleSAA.Visible = True   'visible
            panSolve.Visible = True             'visible
            txtExampleSine1ofASA.Text = "A"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "C"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "a"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "c"     'set a letter in a text box
            txtSide2.Text = "c"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( c )"    'change text in a button
            lblLetterASA.Text = "c:"            'set a letter in a text box
            lblLetterASA.Visible = False        'invisible
            panSolve.Enabled = False            'disabled
            lblMissingAngle.Visible = False     'invisible

        ElseIf radABbcSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = True   'visible
            panSolve.Visible = True             'visible
            txtExampleSine1ofASA.Text = "B"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "C"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "b"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "c"     'set a letter in a text box
            txtSide2.Text = "c"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( c )"    'change text in a button
            lblLetterASA.Text = "c:"            'set a letter in a text box
            lblLetterASA.Visible = False        'invisible
            panSolve.Enabled = False            'disabled
            lblMissingAngle.Visible = False     'invisible

        ElseIf radACcbSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = True   'visible
            panSolve.Visible = True             'visible
            txtExampleSine1ofASA.Text = "C"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "B"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "c"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "b"     'set a letter in a text box
            txtSide2.Text = "b"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( b )"    'change text in a button
            lblLetterASA.Text = "b:"            'set a letter in a text box
            lblLetterASA.Visible = False        'invisible
            panSolve.Enabled = False            'disabled
            lblMissingAngle.Visible = False     'invisible

        ElseIf radACabSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = True   'visible
            panSolve.Visible = True             'visible
            txtExampleSine1ofASA.Text = "A"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "B"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "a"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "b"     'set a letter in a text box
            txtSide2.Text = "b"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( b )"    'change text in a button
            lblLetterASA.Text = "b:"            'set a letter in a text box
            lblLetterASA.Visible = False        'invisible
            panSolve.Enabled = False            'disabled
            lblMissingAngle.Visible = False     'invisible

        ElseIf radBCbaSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = True   'visible
            panSolve.Visible = True             'visible
            txtExampleSine1ofASA.Text = "B"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "A"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "b"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "a"     'set a letter in a text box
            txtSide2.Text = "a"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( a )"    'change text in a button
            lblLetterASA.Text = "a:"            'set a letter in a text box 
            lblLetterASA.Visible = False        'invisible
            panSolve.Enabled = False            'disabled
            lblMissingAngle.Visible = False     'invisible

        ElseIf radBCcaSAA.Checked = True Then   'if radio button is checked
            panMissingAngleSAA.Visible = True   'visible
            panSolve.Visible = True             'visible
            txtExampleSine1ofASA.Text = "C"     'set a letter in a text box
            txtExampleSine2ofASA.Text = "A"     'set a letter in a text box
            txtExampleSide1ofASA.Text = "c"     'set a letter in a text box
            txtExampleSide2ofASA.Text = "a"     'set a letter in a text box
            txtSide2.Text = "a"                 'set a letter in a text box
            btnAnswerASA.Text = "Find ( a )"    'change text in a button
            lblLetterASA.Text = "a:"            'set a letter in a text box
            lblLetterASA.Visible = False        'invisible
            panSolve.Enabled = False            'disabled
            lblMissingAngle.Visible = False     'invisible

        Else                                    '
            MsgBox("Please select one of the options from the Known Values of SAA", , "Known Values of SAA Error")
        End If                                  '

        panAngles.Visible = True                'visible
        picOblique.Visible = True               'visible
        panSolve.Visible = True                 'visible
        grpASA.Visible = False                  'invisible
        grpSAA.Visible = True                   'visible
        txtSide2.ReadOnly = True                'read only
        txtMissingAngle1.Clear()                'cleared
        txtMissingAngle2.Clear()                'cleared
        lblMissing3rdAngleSAA.Text = ""         'empty text
        txtSine1.Clear()                        'cleared
        txtSine2.Clear()                        'cleared
        txtSide1.Clear()                        'cleared
        lblLetterASA.Visible = False            'invisible
        lblSolutionASA.Visible = True           'visible
        lblSolutionASA.Text = ""                'empty text
        lblMissingAngle.Text = ""               'empty text
        lblMissingAngle.Visible = False         'invisible
        btnAnswerASA.Visible = False            'invisible
        btnSSA.Visible = False                  'invisible
    End Sub                                     '

    'solving for the missing side in ASA
    Private Sub btnAnswerASA_Click(sender As System.Object, e As System.EventArgs) Handles btnAnswerASA.Click

        Dim strSine2 As String                                  'clear room in ram for string value
        Dim decSine2 As Decimal                                 'clear room in ram for decimal value
        Dim decSine2Radians As Decimal                          'clear room in ram for decimal value
        Dim strSine1 As String                                  'clear room in ram for string value
        Dim decSine1 As Decimal                                 'clear room in ram for decimal value
        Dim decSine1Radians As Decimal                          'clear room in ram for decimal value
        Dim strSide As String                                   'clear room in ram for string value
        Dim decSide As Decimal                                  'clear room in ram for decimal value
        Dim decTotal As Decimal                                 'clear room in ram for decimal value

        strSine2 = txtSine2.Text                                'text box is a string
        If IsNumeric(txtSine2.Text) Then                        'if numeric then
            decSine2 = Convert.ToDecimal(strSine2)              'convert to decimal
            If decSine2 > 0 Then                                'if greater than 0 then
                decSine2Radians = decSine2 * ((Math.PI) / 180)  'convert to radian
            Else                                                '
                MsgBox("Please enter a posetive number for the second angle", , "Second Angle Error")
            End If                                              '
        Else                                                    '
            MsgBox("Please enter a numeric value for the second angle", , "Second Angle Error")
        End If                                                  '

        strSine1 = txtSine1.Text                                'text box is a string
        If IsNumeric(txtSine1.Text) Then                        'if numeric then
            decSine1 = Convert.ToDecimal(strSine1)              'convert to decimal
            If decSine1 > 0 Then                                'if greater than 0 then
                decSine1Radians = decSine1 * ((Math.PI) / 180)  'convert to radian
            Else                                                '
                MsgBox("Please enter a posetive number for the first angle", , "First Angle Error")
            End If                                              '
        Else                                                    '
            MsgBox("Please enter a numeric value for the first angle", , "First Angle Error")
        End If                                                  '

        strSide = txtSide1.Text                                 'text box is a string
        If IsNumeric(txtSide1.Text) Then                        'if numeric then
            decSide = Convert.ToDecimal(strSide)                'convert to decimal
            If strSide < 0 Then                                 '
                MsgBox("Please enter a posetive number for the dide length", , "Side Length Error")
            End If                                              '
        Else                                                    '
            MsgBox("Please enter a numeric value for the side length", , "Side Length Error")
        End If                                                  '

        Try                                                     '
            decTotal = (Math.Sin(decSine2Radians)) * (decSide / (Math.Sin(decSine1Radians))) 'calculations
        Catch Exception As SystemException                      'exception                            
            MsgBox("Side lengths cannot be zero", , "Cannot divide by zero")
            lblMissingAngle.Text = ""                           'empty label
        End Try                                                 '

        If decTotal >= 0 Then                                   'if greater than zero
            lblMissingAngle.Text = "Missing Angle: " & (180 - decSine1 - decSine2).ToString("F1") & Chr(176) 'find missing angle
            If decTotal < 0 Then                                'if less than zero
                lblMissingAngle.Text = ""                       'empty label
            End If                                              '
        Else                                                    '
            lblMissingAngle.Text = ""                           'empty label
        End If                                                  '

        If radAaBb.Checked = True Then                          'if radio button is checked then
            lblLetterASA.Text = "b:"                            'place a letter in a label
        ElseIf radABba.Checked = True Then                      'if radio button is checked then
            lblLetterASA.Text = "a:"                            'place a letter in a label
        ElseIf radACca.Checked = True Then                      'if radio button is checked then
            lblLetterASA.Text = "a:"                            'place a letter in a label
        ElseIf radAaCc.Checked = True Then                      'if radio button is checked then
            lblLetterASA.Text = "c:"                            'place a letter in a label
        ElseIf radBbCc.Checked = True Then                      'if radio button is checked then
            lblLetterASA.Text = "c:"                            'place a letter in a label
        ElseIf radBCcb.Checked = True Then                      'if radio button is checked then
            lblLetterASA.Text = "b:"                            'place a letter in a label
        End If                                                  '

        lblSolutionASA.Text = decTotal.ToString("F2")           'answer placed into a label with 2 past decimal
        lblLetterASA.Visible = True                             'visible
        lblSolutionASA.Visible = True                           'visible
        lblMissingAngle.Visible = True                          'visible
    End Sub

    'solving for the missing angle
    Private Sub btnFindMissingAngleSAA_Click(sender As System.Object, e As System.EventArgs) Handles btnFindMissingAngleSAA.Click

        Dim strAngle1 As String                         'clear room in ram for string value
        Dim decAngle1 As Decimal                        'clear room in ram for decimal value
        Dim strAngle2 As String                         'clear room in ram for string value
        Dim decAngle2 As Decimal                        'clear room in ram for decimal value
        Dim decMissingAngle As Decimal                  'clear room in ram for decimal value

        strAngle1 = txtMissingAngle1.Text               'text box is a string
        If IsNumeric(txtMissingAngle1.Text) Then        'if numeric then
            decAngle1 = Convert.ToDecimal(strAngle1)    'convert to decimal
            btnAnswerASA.Visible = True                 'visible
            If decAngle1 < 0 Then                       'if less than zero
                MsgBox("Please enter a posetive number for the Known 1st Angle", , "Known 1st Angle Error")
                txtMissingAngle1.Clear()                'clear text box
                btnAnswerASA.Visible = False            'invisible
            ElseIf decAngle1 > 180 Then                 'if more than 180 degrees
                MsgBox("A single Angle of a triangle cannot be more than 180" & Chr(176), , "Known 1st Angle Error")
                txtMissingAngle1.Clear()                'clear text box
            End If                                      '
        Else                                            '
            MsgBox("Please enter a numeric number for the Known 1st Angle", , "Known 1st Angle Error")
            txtMissingAngle1.Clear()                    'clear text box
        End If                                          '

        strAngle2 = txtMissingAngle2.Text               'text box is a string
        If IsNumeric(txtMissingAngle2.Text) Then        'if numeric then
            decAngle2 = Convert.ToDecimal(strAngle2)    'convert to decimal
            btnAnswerASA.Visible = True                 'visible
            If decAngle2 < 0 Then                       'if less than zero
                MsgBox("Please enter a posetive number for the Known 2nd Angle", , "Known 2nd Angle Error")
                txtMissingAngle2.Clear()                'clear text box
                btnAnswerASA.Visible = False            'invisible
            ElseIf decAngle2 > 180 Then                 'if more than 180 degrees
                MsgBox("A single Angle of a triangle cannot be more than 180" & Chr(176), , "Known 2nd Angle Error")
                txtMissingAngle1.Clear()                'clear text box
            End If                                      '
        Else                                            '
            MsgBox("Please enter a numeric number for the Known 2nd Angle", , "Known 2nd Angle Error")
            txtMissingAngle2.Clear()                    '
        End If                                          '

        decMissingAngle = 180 - decAngle1 - decAngle2   'calculation

        lblMissing3rdAngleSAA.Text = "3rd Angle: " & decMissingAngle.ToString("F1") & Chr(176) 'answer set into label with 1 past the decimal
        panSolve.Visible = True                         'visible
        txtSine2.Text = decMissingAngle.ToString("")    'missing angle placed into text box
        txtSine2.ReadOnly = True                        'read only
        panSolve.Enabled = True                         'enabled
        lblLetterASA.Visible = True                     'isible

    End Sub

    'preporations to solve SSA
    Private Sub btnSSA_Click(sender As System.Object, e As System.EventArgs) Handles btnSSA.Click
        If radabA.Checked = True Then
            txtExampleSine1ofASA.Text = "A"
            txtExampleSide1ofASA.Text = "a"
            txtExampleSine2ofASA.Text = "B"
            txtExampleSide2ofASA.Text = "b"
            txtSine2.Text = "B"
            panAngles.Visible = True
        ElseIf radabB.Checked = True Then
            txtExampleSine1ofASA.Text = "B"
            txtExampleSide1ofASA.Text = "b"
            txtExampleSine2ofASA.Text = "A"
            txtExampleSide2ofASA.Text = "a"
            txtSine2.Text = "A"
            panAngles.Visible = True
        ElseIf radacC.Checked = True Then
            txtExampleSine1ofASA.Text = "C"
            txtExampleSide1ofASA.Text = "c"
            txtExampleSine2ofASA.Text = "A"
            txtExampleSide2ofASA.Text = "a"
            txtSine2.Text = "A"
            panAngles.Visible = True
        ElseIf radacA.Checked = True Then
            txtExampleSine1ofASA.Text = "A"
            txtExampleSide1ofASA.Text = "a"
            txtExampleSine2ofASA.Text = "C"
            txtExampleSide2ofASA.Text = "c"
            txtSine2.Text = "C"
            panAngles.Visible = True
        ElseIf radbcB.Checked = True Then
            txtExampleSine1ofASA.Text = "B"
            txtExampleSide1ofASA.Text = "b"
            txtExampleSine2ofASA.Text = "A"
            txtExampleSide2ofASA.Text = "a"
            txtSine2.Text = "A"
            panAngles.Visible = True
        ElseIf radbcC.Checked = True Then
            txtExampleSine1ofASA.Text = "C"
            txtExampleSide1ofASA.Text = "c"
            txtExampleSine2ofASA.Text = "B"
            txtExampleSide2ofASA.Text = "b"
            txtSine2.Text = "B"
            panAngles.Visible = True
        Else
            MsgBox("Please select one of the Known Values of SSA", , "Known Values of SSA Error")
            panAngles.Visible = False
        End If

        txtSine2.ReadOnly = True
        txtSide2.ReadOnly = False
        panMissingAngleSAA.Visible = False
        panSolve.Visible = True
        btnSolveSSA.Visible = True
        picOblique.Visible = False
        picSSA.Visible = True
        txtSine2.BackColor = Color.WhiteSmoke
        txtSide2.BackColor = Color.White
        btnSolveSSA.Text = "Solve SSA"
        panAnswers1And2.Visible = True

        lblAngle1SSA1.Text = ""
        lblAngle2SSA1.Text = ""
        lblAngle3SSA1.Text = ""
        lblLength1SSA1.Text = ""
        lblLength2SSA1.Text = ""
        lblLength3SSA1.Text = ""
        lblAngle1SSA2.Text = ""
        lblAngle2SSA2.Text = ""
        lblAngle3SSA2.Text = ""
        lblLength1SSA2.Text = ""
        lblLength2SSA2.Text = ""
        lblLength3SSA2.Text = ""
    End Sub



    'codes to solve SSA
    'Not finished, too complicated
    Private Sub btnSolveSSA_Click(sender As System.Object, e As System.EventArgs) Handles btnSolveSSA.Click
        Dim strSide2 As String
        Dim decSide2 As Decimal
        Dim decSine2Radians As Decimal
        Dim strSine1 As String
        Dim decSine1 As Decimal
        Dim decSine1Radians As Decimal
        Dim strSide1 As String
        Dim decSide1 As Decimal

        Dim decAngle1SSA1 As Decimal
        Dim decAngle2SSA1 As Decimal
        Dim decAngle3SSA1 As Decimal
        Dim decLength1SSA1 As Decimal
        Dim declength2SSA1 As Decimal
        Dim decLength3SSA1 As Decimal

        Dim decAngle1SSA2 As Decimal
        Dim decAngle2SSA2 As Decimal
        Dim decAngle3SSA2 As Decimal
        Dim decLength1SSA2 As Decimal
        Dim declength2SSA2 As Decimal
        Dim decLength3SSA2 As Decimal

        strSine1 = txtSine1.Text
        If IsNumeric(txtSine1.Text) Then
            decSine1 = Convert.ToDecimal(strSine1)
            If decSine1 > 0 Then
                decSine1Radians = (decSine1 * ((Math.PI) / 180))
            Else
                MsgBox("Please enter a posetive number for the first angle.", , "First Angle Error")
            End If
        Else
            MsgBox("Please enter a numeric number for the first angle.", , "First Angle Error")
        End If

        strSide1 = txtSide1.Text
        If IsNumeric(txtSide1.Text) Then
            decSide1 = Convert.ToDecimal(strSide1)
            If strSide1 < 0 Then
                MsgBox("Please enter a posetive number for the dide length.", , "Side 1 Length Error")
            End If
        Else
            MsgBox("Please enter a numeric value for the side length.", , "Side 1 Length Error")
        End If

        strSide2 = txtSide2.Text
        If IsNumeric(txtSide1.Text) Then
            decSide2 = Convert.ToDecimal(strSide2)
            If strSide2 < 0 Then
                MsgBox("Please enter a posetive number for the dide length.", , "Side 2 Length Error")
            End If
        Else
            MsgBox("Please enter a numeric value for the side length.", , "Side 2 Length Error")
        End If



        Try
            decSine2Radians = (decSide2 * (Math.Sin(decSine1Radians) / decSide1))
        Catch Exception As OverflowException
            MsgBox("Please check your sides, they cannot be zero.", , "Division By Zero Error")
            lblAngle1SSA1.Text = ""
            lblAngle2SSA1.Text = ""
            lblAngle3SSA1.Text = ""
            lblLength1SSA1.Text = ""
            lblLength2SSA1.Text = ""
            lblLength3SSA1.Text = ""
            lblAngle1SSA2.Text = ""
            lblAngle2SSA2.Text = ""
            lblAngle3SSA2.Text = ""
            lblLength1SSA2.Text = ""
            lblLength2SSA2.Text = ""
            lblLength3SSA2.Text = ""
        End Try


        If decSine2Radians > 1 Then
            MsgBox("There are NO SOLUTIONS for this type of triangle, Press OK to go back.", , "No Solution Message")
            panAnswers1And2.Visible = True
            lblAngle1SSA1.Text = ""
            lblAngle2SSA1.Text = ""
            lblAngle3SSA1.Text = ""
            lblLength1SSA1.Text = ""
            lblLength2SSA1.Text = ""
            lblLength3SSA1.Text = ""
            lblAngle1SSA2.Text = ""
            lblAngle2SSA2.Text = ""
            lblAngle3SSA2.Text = ""
            lblLength1SSA2.Text = ""
            lblLength2SSA2.Text = ""
            lblLength3SSA2.Text = ""
        ElseIf decSine2Radians = 1 Then
            MsgBox("The angle is 90 degrees, Please press OK to continue.", , "Angle is Just Right")



            lblAngle1SSA1.Text = ""
            lblAngle2SSA1.Text = ""
            lblAngle3SSA1.Text = ""
            lblLength1SSA1.Text = ""
            lblLength2SSA1.Text = ""
            lblLength3SSA1.Text = ""
            lblAngle1SSA2.Text = ""
            lblAngle2SSA2.Text = ""
            lblAngle3SSA2.Text = ""
            lblLength1SSA2.Text = ""
            lblLength2SSA2.Text = ""
            lblLength3SSA2.Text = ""
        ElseIf decSine2Radians < 1 Then
            panAnswers1And2.Visible = True
            If (decSide1 > decSide2) Then
                MsgBox("There will be 2 solutions, press OK to continue.", , "Two Solutions")


                Dim Angle1 As Decimal
                Dim Angle2 As Decimal
                Dim Angle3 As Decimal
                Dim Side1 As Decimal
                Dim Side2 As Decimal
                Dim Side3 As Decimal
                Dim Angle11 As Decimal
                Dim Angle12 As Decimal
                Dim Angle13 As Decimal
                Dim Side11 As Decimal
                Dim Side12 As Decimal
                Dim Side13 As Decimal



                lblAngle1SSA1.Text = "Angle A: "
                lblAngle2SSA1.Text = "Angle B: "
                lblAngle3SSA1.Text = "Angle C: "
                lblLength1SSA1.Text = "Side Length a: "
                lblLength2SSA1.Text = "Side Length b: "
                lblLength3SSA1.Text = "Side Length c: "
                lblAngle1SSA2.Text = "Angle A: "
                lblAngle2SSA2.Text = "Angle B: "
                lblAngle3SSA2.Text = "Angle C: "
                lblLength1SSA2.Text = "Side Length a: "
                lblLength2SSA2.Text = "Side Length b: "
                lblLength3SSA2.Text = "Side Length c: "

            ElseIf (decSide1 <= decSide2) Then
                panAnswers1And2.Visible = True
                MsgBox("There will only be 1 solution, press OK to continue", , "One Solution")
                If (radabA.Checked = True And (decSide1 <= decSide2)) Then


                    Dim Angle1 As Decimal
                    Dim Angle2 As Decimal
                    Dim Angle3 As Decimal
                    Dim Side1 As Decimal
                    Dim Side2 As Decimal
                    Dim Side3 As Decimal
                    Dim x As Decimal
                    Dim decAngleCRadians As Decimal

                    Angle1 = decSine1

                    x = decSide2 * (Math.Sin(decSine1Radians) / decSide2)

                    Angle2 = Math.Atan(x / Math.Sqrt(-x * x + 1))
                    Angle3 = (180 - (Angle2 * (180 / Math.PI)) - Angle1)

                    decAngleCRadians = Angle3 * (Math.PI / 180)

                    Side1 = decSide1
                    Side2 = decSide2

                    Side3 = Math.Sin(decAngleCRadians) * (decSide2 / Math.Sin(Angle2))


                    lblAngle1SSA1.Text = "Angle A: " & Angle1.ToString("F1") & Chr(176)
                    lblAngle2SSA1.Text = "Angle B: " & (Angle2 * (180 / Math.PI)).ToString("F1") & Chr(176)
                    lblAngle3SSA1.Text = "Angle C: " & Angle3.ToString("F1") & Chr(176)
                    lblLength1SSA1.Text = "Side Length a: "
                    lblLength2SSA1.Text = "Side Length b: "
                    lblLength3SSA1.Text = "Side Length c: "
                    lblAngle1SSA2.Text = ""
                    lblAngle2SSA2.Text = ""
                    lblAngle3SSA2.Text = ""
                    lblLength1SSA2.Text = ""
                    lblLength2SSA2.Text = ""
                    lblLength3SSA2.Text = ""
                ElseIf (radabB.Checked = True And (decSide1 <= decSide2)) Then


                    Dim Angle1 As Decimal
                    Dim Angle2 As Decimal
                    Dim Angle3 As Decimal
                    Dim Side1 As Decimal
                    Dim Side2 As Decimal
                    Dim Side3 As Decimal
                    Dim x As Decimal
                    Dim decAngleCRadians As Decimal

                    Angle2 = decSine1

                    x = decSide2 * (Math.Sin(decSine1Radians) / decSide2)

                    Angle3 = Math.Atan(x / Math.Sqrt(-x * x + 1))
                    Angle1 = (180 - (Angle2 * (180 / Math.PI)) - Angle1)

                    decAngleCRadians = Angle3 * (Math.PI / 180)

                    Side2 = decSide1
                    Side3 = decSide2

                    Side1 = Math.Sin(decAngleCRadians) * (decSide2 / Math.Sin(Angle2))

                    lblAngle1SSA1.Text = "Angle A: " & Angle1.ToString("F1") & Chr(176)
                    lblAngle2SSA1.Text = "Angle B: " & Angle2.ToString("F1") & Chr(176)
                    lblAngle3SSA1.Text = "Angle C: " & (Angle3 * (180 / Math.PI)).ToString("F1") & Chr(176)
                    lblLength1SSA1.Text = "Side Length a: "
                    lblLength2SSA1.Text = "Side Length b: "
                    lblLength3SSA1.Text = "Side Length c: "
                    lblAngle1SSA2.Text = ""
                    lblAngle2SSA2.Text = ""
                    lblAngle3SSA2.Text = ""
                    lblLength1SSA2.Text = ""
                    lblLength2SSA2.Text = ""
                    lblLength3SSA2.Text = ""
                End If
            ElseIf (radacC.Checked = True And (decSide1 <= decSide2)) Then


                Dim Angle1 As Decimal
                Dim Angle2 As Decimal
                Dim Angle3 As Decimal
                Dim Side1 As Decimal
                Dim Side2 As Decimal
                Dim Side3 As Decimal
                Dim x As Decimal
                Dim decAngleCRadians As Decimal

                Angle3 = decSine1

                x = decSide2 * (Math.Sin(decSine1Radians) / decSide2)

                Angle1 = Math.Atan(x / Math.Sqrt(-x * x + 1))
                Angle2 = (180 - (Angle2 * (180 / Math.PI)) - Angle1)

                decAngleCRadians = Angle3 * (Math.PI / 180)

                Side3 = decSide1
                Side2 = decSide2

                Side1 = Math.Sin(decAngleCRadians) * (decSide2 / Math.Sin(Angle2))

                lblAngle1SSA1.Text = "Angle A: "
                lblAngle2SSA1.Text = "Angle B: "
                lblAngle3SSA1.Text = "Angle C: "
                lblLength1SSA1.Text = "Side Length a: "
                lblLength2SSA1.Text = "Side Length b: "
                lblLength3SSA1.Text = "Side Length c: "
                lblAngle1SSA2.Text = ""
                lblAngle2SSA2.Text = ""
                lblAngle3SSA2.Text = ""
                lblLength1SSA2.Text = ""
                lblLength2SSA2.Text = ""
                lblLength3SSA2.Text = ""

            ElseIf (radabA.Checked = True And (decSide1 <= decSide2)) Then


                Dim Angle1 As Decimal
                Dim Angle2 As Decimal
                Dim Angle3 As Decimal
                Dim Side1 As Decimal
                Dim Side2 As Decimal
                Dim Side3 As Decimal
                Dim x As Decimal
                Dim decAngleCRadians As Decimal

                Angle1 = decSine1

                x = decSide2 * (Math.Sin(decSine1Radians) / decSide2)

                Angle2 = Math.Atan(x / Math.Sqrt(-x * x + 1))
                Angle3 = (180 - (Angle2 * (180 / Math.PI)) - Angle1)

                decAngleCRadians = Angle3 * (Math.PI / 180)

                Side1 = decSide1
                Side3 = decSide2

                Side2 = Math.Sin(decAngleCRadians) * (decSide2 / Math.Sin(Angle2))

                lblAngle1SSA1.Text = "Angle A: " & Angle1.ToString("F1") & Chr(176)
                lblAngle2SSA1.Text = "Angle B: " & (Angle2 * (180 / Math.PI)).ToString("F1") & Chr(176)
                lblAngle3SSA1.Text = "Angle C: " & Angle3.ToString("F1") & Chr(176)
                lblLength1SSA1.Text = "Side Length a: " & Side1.ToString("F2")
                lblLength2SSA1.Text = "Side Length b: " & Side3.ToString("F2")
                lblLength3SSA1.Text = "Side Length c: " & Side2.ToString("F2")
                lblAngle1SSA2.Text = ""
                lblAngle2SSA2.Text = ""
                lblAngle3SSA2.Text = ""
                lblLength1SSA2.Text = ""
                lblLength2SSA2.Text = ""
                lblLength3SSA2.Text = ""

            ElseIf (radabB.Checked = True And (decSide1 <= decSide2)) Then


                Dim Angle1 As Decimal
                Dim Angle2 As Decimal
                Dim Angle3 As Decimal
                Dim Side1 As Decimal
                Dim Side2 As Decimal
                Dim Side3 As Decimal
                Dim x As Decimal
                Dim decAngleCRadians As Decimal

                Angle2 = decSine1

                x = decSide2 * (Math.Sin(decSine1Radians) / decSide2)

                Angle3 = Math.Atan(x / Math.Sqrt(-x * x + 1))
                Angle1 = (180 - (Angle2 * (180 / Math.PI)) - Angle1)

                decAngleCRadians = Angle3 * (Math.PI / 180)

                Side2 = decSide1
                Side1 = decSide2

                Side3 = Math.Sin(decAngleCRadians) * (decSide2 / Math.Sin(Angle2))

                lblAngle1SSA1.Text = "Angle A: " & Angle2.ToString("F1") & Chr(176)
                lblAngle2SSA1.Text = "Angle B: " & (Angle3 * (180 / Math.PI)).ToString("F1") & Chr(176)
                lblAngle3SSA1.Text = "Angle C: " & Angle1.ToString("F1") & Chr(176)
                lblLength1SSA1.Text = "Side Length a: " & Side2.ToString("F2")
                lblLength2SSA1.Text = "Side Length b: " & Side3.ToString("F2")
                lblLength3SSA1.Text = "Side Length c: " & Side1.ToString("F2")
                lblAngle1SSA2.Text = ""
                lblAngle2SSA2.Text = ""
                lblAngle3SSA2.Text = ""
                lblLength1SSA2.Text = ""
                lblLength2SSA2.Text = ""
                lblLength3SSA2.Text = ""
            ElseIf (radacC.Checked = True And (decSide1 <= decSide2)) Then


                Dim Angle1 As Decimal
                Dim Angle2 As Decimal
                Dim Angle3 As Decimal
                Dim Side1 As Decimal
                Dim Side2 As Decimal
                Dim Side3 As Decimal
                Dim x As Decimal
                Dim decAngleCRadians As Decimal

                Angle3 = decSine1

                x = decSide2 * (Math.Sin(decSine1Radians) / decSide2)

                Angle1 = Math.Atan(x / Math.Sqrt(-x * x + 1))
                Angle2 = (180 - (Angle2 * (180 / Math.PI)) - Angle1)

                decAngleCRadians = Angle3 * (Math.PI / 180)

                Side3 = decSide1
                Side1 = decSide2

                Side2 = Math.Sin(decAngleCRadians) * (decSide2 / Math.Sin(Angle2))

                lblAngle1SSA1.Text = "Angle A: " & Angle3.ToString("F1") & Chr(176)
                lblAngle2SSA1.Text = "Angle B: " & (Angle1 * (180 / Math.PI)).ToString("F1") & Chr(176)
                lblAngle3SSA1.Text = "Angle C: " & Angle2.ToString("F1") & Chr(176)
                lblLength1SSA1.Text = "Side Length a: " & Side3.ToString("F2")
                lblLength2SSA1.Text = "Side Length b: " & Side2.ToString("F2")
                lblLength3SSA1.Text = "Side Length c: " & Side1.ToString("F2")
                lblAngle1SSA2.Text = ""
                lblAngle2SSA2.Text = ""
                lblAngle3SSA2.Text = ""
                lblLength1SSA2.Text = ""
                lblLength2SSA2.Text = ""
                lblLength3SSA2.Text = ""

            End If

        End If


    End Sub


    'prepares everything for calculations for SAS
    Private Sub btnSAS_Click(sender As System.Object, e As System.EventArgs) Handles btnSAS.Click
        If radcAb.Checked = True Then
            txtExampleUnknown.Text = "a"
            txtUnknown.Text = "a"
            txtExampleKnown1.Text = "b"
            txtExampleKnown11.Text = "b"
            txtExampleKnown2.Text = "c"
            txtExampleKnown22.Text = "c"
            txtExampleKnownCos.Text = "A"
            btnSolveSAS.Visible = True
            panSASsolving.Visible = True
            panAngles.Visible = True
            panSolve.Visible = True
        ElseIf radbCa.Checked = True Then
            txtExampleUnknown.Text = "c"
            txtUnknown.Text = "c"
            txtExampleKnown1.Text = "a"
            txtExampleKnown11.Text = "a"
            txtExampleKnown2.Text = "b"
            txtExampleKnown22.Text = "b"
            txtExampleKnownCos.Text = "C"
            btnSolveSAS.Visible = True
            panSASsolving.Visible = True
            panAngles.Visible = True
            panSolve.Visible = True
        ElseIf radaBc.Checked = True Then
            txtExampleUnknown.Text = "b"
            txtUnknown.Text = "b"
            txtExampleKnown1.Text = "a"
            txtExampleKnown11.Text = "a"
            txtExampleKnown2.Text = "c"
            txtExampleKnown22.Text = "c"
            txtExampleKnownCos.Text = "B"
            btnSolveSAS.Visible = True
            panSASsolving.Visible = True
            panAngles.Visible = True
            panSolve.Visible = True
        Else
            MsgBox("Please select the known values of ASA", , "Known Values of ASA Error")
            btnSolveSAS.Visible = False
            btnSAS.Visible = True
            grpSAS.Visible = True
            panSASsolving.Visible = False
            panAngles.Visible = False
            txtExampleUnknown.Clear()
            txtUnknown.Clear()
            txtExampleKnown1.Clear()
            txtExampleKnown11.Clear()
            txtExampleKnown2.Clear()
            txtExampleKnown22.Clear()
            txtExampleKnownCos.Clear()
        End If

        panSolve.Visible = False
        txtKnown1.Clear()
        txtKnown11.Clear()
        txtKnown2.Clear()
        txtKnown22.Clear()
        txtKnownCos.Clear()
        btnSolveSAS.Visible = True
        lblSASanswer.Text = ""

    End Sub

    'calculations for SAS
    Private Sub btnSolveSAS_Click(sender As System.Object, e As System.EventArgs) Handles btnSolveSAS.Click

        Dim strUnknown As String
        Dim decUnknown As Decimal
        Dim strKnown1 As String
        Dim decKnown1 As Decimal
        Dim strKnown11 As String
        Dim decknown11 As Decimal
        Dim strKnown2 As String
        Dim decknown2 As Decimal
        Dim strKnown22 As String
        Dim decknown22 As Decimal
        Dim strCos As String
        Dim decCos As Decimal
        Dim decCosRadians As Decimal
        Dim decPartOne As Decimal
        Dim decPartTwo As Decimal

        If radcAb.Checked = True Then
            txtUnknown.Text = "a"
            strUnknown = "a: "
        ElseIf radbCa.Checked = True Then
            txtUnknown.Text = "c"
            strUnknown = "c: "
        ElseIf radaBc.Checked = True Then
            txtUnknown.Text = "b"
            strUnknown = "b: "
        End If

        btnContinueToSSS.Visible = False

        strKnown1 = txtKnown1.Text
        If IsNumeric(txtKnown1.Text) Then
            decKnown1 = Convert.ToDecimal(strKnown1)
            txtSSSa.Clear()                             'clear
            txtSSSb.Clear()                             'clear
            txtSSSc.Clear()                             'clear
            txtSSSa.ReadOnly = False                    'Write able
            txtSSSb.ReadOnly = False                    'Write able
            txtSSSc.ReadOnly = False                    'Write able
            If decKnown1 <= 0 Then
                MsgBox("Please enter a posetive number in the first box", , "First Box Error")
                txtKnown1.Clear()
            End If
        Else
            MsgBox("Please enter a numeric number in the First box", , "First Box Error")
            txtKnown11.Clear()
        End If
        strKnown11 = txtKnown11.Text
        If IsNumeric(txtKnown11.Text) Then
            decknown11 = Convert.ToDecimal(strKnown11)
            If decknown11 <= 0 Then
                MsgBox("Please enter a posetive number in the third box", , "Third Box Error")
                txtKnown11.Clear()
            End If
        Else
            MsgBox("Please enter a numeric number in the third box", , "Third Box Error")
            txtKnown11.Clear()
        End If
        strKnown2 = txtKnown2.Text
        If IsNumeric(txtKnown2.Text) Then
            decknown2 = Convert.ToDecimal(strKnown2)
            If decknown2 <= 0 Then
                MsgBox("Please enter a posetive number in the second box", , "Second Box Error")
                txtKnown2.Clear()
            End If
        Else
            MsgBox("Please enter a numeric number in the second box", , "Scond Box Error")
            txtKnown2.Clear()
        End If
        strKnown22 = txtKnown22.Text
        If IsNumeric(txtKnown22.Text) Then
            decknown22 = Convert.ToDecimal(strKnown22)
            If decknown22 <= 0 Then
                MsgBox("Please enter a posetive number in the fourth box", , "Fourth Box Error")
                txtKnown22.Clear()
            End If
        Else
            MsgBox("Please enter a numeric number in the fourth box", , "Fourth Box Error")
            txtKnown22.Clear()
        End If
        strCos = txtKnownCos.Text
        If IsNumeric(txtKnownCos.Text) Then
            decCos = Convert.ToDecimal(strCos)
            MsgBox("Now you know 3 sides of a triangle, continue to SSS to find all the angles", , "")
            btnContinueToSSS.Visible = True
            If decCos > 0 Then
                decCosRadians = decCos * (Math.PI / 180)
            ElseIf decCos <= 0 Then
                MsgBox("Please enter a posetive number in the Last box", , "Last Box Error")
                txtKnownCos.Clear()
            End If
        Else
            MsgBox("Please enter a numeric number in the last box", , "Last Box Error")
            txtKnownCos.Clear()
        End If

        decPartOne = Math.Pow(decKnown1, 2) + Math.Pow(decknown2, 2)
        decPartTwo = (2 * decKnown1 * decknown2 * Math.Cos(decCosRadians))
        decUnknown = Math.Sqrt(decPartOne - decPartTwo)

        lblSASanswer.Text = strUnknown & decUnknown.ToString("F2")

        If radcAb.Checked = True Then
            txtSSSa.Text = decUnknown.ToString
            txtSSSa.ReadOnly = True
            txtSSSb.ReadOnly = False
            txtSSSc.ReadOnly = False
        ElseIf radbCa.Checked = True Then
            txtSSSc.Text = decUnknown.ToString
            txtSSSa.ReadOnly = False
            txtSSSb.ReadOnly = False
            txtSSSc.ReadOnly = True
        ElseIf radaBc.Checked = True Then
            txtSSSb.Text = decUnknown.ToString
            txtSSSa.ReadOnly = False
            txtSSSb.ReadOnly = True
            txtSSSc.ReadOnly = False
        End If

    End Sub

    'to solve for A in SSS
    Private Sub btnSolveA_Click(sender As System.Object, e As System.EventArgs) Handles btnSolveA.Click
        Dim x As Decimal
        Dim Angle As Decimal
        Dim a As Decimal
        Dim b As Decimal
        Dim c As Decimal

        Try
            If IsNumeric(txtSSSa.Text) Then
                a = Convert.ToDecimal(txtSSSa.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( a )", , "Side Length ( a ) Error")
                    txtSSSa.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( a )", , "Side Length ( a ) Error")
                txtSSSa.Clear()
            End If
            If IsNumeric(txtSSSb.Text) Then
                b = Convert.ToDecimal(txtSSSb.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( b )", , "Side Length ( b ) Error")
                    txtSSSb.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( b )", , "Side Length ( b ) Error")
                txtSSSb.Clear()
            End If
            If IsNumeric(txtSSSc.Text) Then
                c = Convert.ToDecimal(txtSSSc.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( b )", , "Side Length ( b ) Error")
                    txtSSSc.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( b )", , "Side Length ( b ) Error")
                txtSSSc.Clear()
            End If
            If (a > 0 And b > 0 And c > 0) Then
                x = ((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))
                txtSSSa.ReadOnly = True
                txtSSSb.ReadOnly = True
                txtSSSc.ReadOnly = True
                txtSSSa.BackColor = Color.LimeGreen
                txtSSSb.BackColor = Color.LimeGreen
                txtSSSc.BackColor = Color.LimeGreen
                btnSolveA.Enabled = False
            End If
        Catch ex As OverflowException

        End Try

        Try
            If (a + b <= c) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            ElseIf (a + c <= b) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            ElseIf (b + c <= a) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            Else
                Angle = Math.Atan(-x / Math.Sqrt(-x * x + 1)) + 2 * Math.Atan(1)
                lblSSSa.Text = "Angle A: " & (Angle * (180 / Math.PI)).ToString("F1") & Chr(176)
            End If

        Catch ex As OverflowException
        End Try

    End Sub

    'to solve for B in SSS
    Private Sub btnSolveB_Click(sender As System.Object, e As System.EventArgs) Handles btnSolveB.Click
        Dim x As Decimal
        Dim Angle As Decimal
        Dim a As Decimal
        Dim b As Decimal
        Dim c As Decimal

        Try
            If IsNumeric(txtSSSa.Text) Then
                a = Convert.ToDecimal(txtSSSa.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( a )", , "Side Length ( a ) Error")
                    txtSSSa.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( a )", , "Side Length ( a ) Error")
                txtSSSa.Clear()
            End If
            If IsNumeric(txtSSSb.Text) Then
                b = Convert.ToDecimal(txtSSSb.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( b )", , "Side Length ( b ) Error")
                    txtSSSb.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( b )", , "Side Length ( b ) Error")
                txtSSSb.Clear()
            End If
            If IsNumeric(txtSSSc.Text) Then
                c = Convert.ToDecimal(txtSSSc.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( b )", , "Side Length ( b ) Error")
                    txtSSSc.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( b )", , "Side Length ( b ) Error")
                txtSSSc.Clear()
            End If
            If (a > 0 And b > 0 And c > 0) Then
                x = ((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) / (2 * c * a))
                txtSSSa.ReadOnly = True
                txtSSSb.ReadOnly = True
                txtSSSc.ReadOnly = True
                txtSSSa.BackColor = Color.LimeGreen
                txtSSSb.BackColor = Color.LimeGreen
                txtSSSc.BackColor = Color.LimeGreen
                btnSolveB.Enabled = False
            End If
        Catch ex As Exception
        End Try

        Try
            If (a + b <= c) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            ElseIf (a + c <= b) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            ElseIf (b + c <= a) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            Else
                Angle = Math.Atan(-x / Math.Sqrt(-x * x + 1)) + 2 * Math.Atan(1)
                lblSSSb.Text = "Angle B: " & (Angle * (180 / Math.PI)).ToString("F1") & Chr(176)
            End If
        Catch ex As OverflowException
        End Try


    End Sub

    'to solve for C in SSS
    Private Sub btnSolveC_Click(sender As System.Object, e As System.EventArgs) Handles btnSolveC.Click
        Dim x As Decimal
        Dim Angle As Decimal
        Dim a As Decimal
        Dim b As Decimal
        Dim c As Decimal

        Try
            If IsNumeric(txtSSSa.Text) Then
                a = Convert.ToDecimal(txtSSSa.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( a )", , "Side Length ( a ) Error")
                    txtSSSa.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( a )", , "Side Length ( a ) Error")
                txtSSSa.Clear()
            End If
            If IsNumeric(txtSSSb.Text) Then
                b = Convert.ToDecimal(txtSSSb.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( b )", , "Side Length ( b ) Error")
                    txtSSSb.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( b )", , "Side Length ( bc ) Error")
                txtSSSb.Clear()
            End If
            If IsNumeric(txtSSSc.Text) Then
                c = Convert.ToDecimal(txtSSSc.Text)
                If a < 0 Then
                    MsgBox("Please enter a posetive value for Side Length ( c )", , "Side Length ( c ) Error")
                    txtSSSc.Clear()
                End If
            Else
                MsgBox("Please enter a numeric number for Side Length ( c )", , "Side Length ( c ) Error")
                txtSSSc.Clear()
            End If
            If (a > 0 And b > 0 And c > 0) Then
                x = ((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b))
                txtSSSa.ReadOnly = True
                txtSSSb.ReadOnly = True
                txtSSSc.ReadOnly = True
                txtSSSa.BackColor = Color.LimeGreen
                txtSSSb.BackColor = Color.LimeGreen
                txtSSSc.BackColor = Color.LimeGreen
                btnSolveC.Enabled = False
            End If
        Catch ex As Exception
        End Try

        Try
            If (a + b <= c) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            ElseIf (a + c <= b) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            ElseIf (b + c <= a) Then
                txtSSSa.BackColor = Color.Red
                txtSSSb.BackColor = Color.Red
                txtSSSc.BackColor = Color.Red
                btnSolveA.Enabled = False
                btnSolveB.Enabled = False
                btnSolveC.Enabled = False
                MsgBox("The sum of two side lengths is less than or equal to the length of the third side. This is not a Triangle", , "Not a Triangle")
            Else
                Angle = Math.Atan(-x / Math.Sqrt(-x * x + 1)) + 2 * Math.Atan(1)
                lblSSSc.Text = "Angle C: " & (Angle * (180 / Math.PI)).ToString("F1") & Chr(176)
            End If
        Catch ex As OverflowException
        End Try



    End Sub

    'clear codes for SSS
    Private Sub btnClearSSS_Click(sender As System.Object, e As System.EventArgs) Handles btnClearSSS.Click

        txtSSSa.BackColor = Color.White 'color change
        txtSSSb.BackColor = Color.White 'color change
        txtSSSc.BackColor = Color.White 'color change
        txtSSSa.ReadOnly = False        'can write
        txtSSSb.ReadOnly = False        'can write
        txtSSSc.ReadOnly = False        'can write
        lblSSSa.Text = ""               'clear
        lblSSSb.Text = ""               'clear
        lblSSSc.Text = ""               'clear
        btnSolveA.Enabled = True        'enabled
        btnSolveB.Enabled = True        'enabled
        btnSolveC.Enabled = True        'enabled
        txtSSSa.Clear()                 'cleared
        txtSSSb.Clear()                 'cleared
        txtSSSc.Clear()                 'cleared


    End Sub

    'form load codes
    Private Sub frmTriangles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        btnSAS.Enabled = True           '
        grpAngleType.Enabled = True     '
        btnNext.Enabled = True          '
        btnContinueToSSS.Visible = False 'invisible

        lblAngle1SSA1.Text = ""         'empty
        lblAngle2SSA1.Text = ""         'empty
        lblAngle3SSA1.Text = ""         'empty
        lblLength1SSA1.Text = ""        'empty
        lblLength2SSA1.Text = ""        'empty
        lblLength3SSA1.Text = ""        'empty
        lblAngle1SSA2.Text = ""         'empty
        lblAngle2SSA2.Text = ""         'empty
        lblAngle3SSA2.Text = ""         'empty
        lblLength1SSA2.Text = ""        'empty
        lblLength2SSA2.Text = ""        'empty
        lblLength3SSA2.Text = ""        'empty

        panAngles.Visible = False       'invisible
        picOblique.Visible = False      'invisible
        panSolve.Visible = False        'invisible
        grpASA.Visible = False          'invisible
        grpSAA.Visible = False          'invisible
        grpAngleType.Visible = True    'invisible
        grpSSA.Visible = False          'invisible
        txtSide2.ReadOnly = False       'not read only
        txtMissingAngle1.Clear()        'cleared
        txtMissingAngle2.Clear()        'cleared
        lblMissing3rdAngleSAA.Text = "" 'empty
        txtSine1.Clear()                'cleared
        txtSine2.Clear()                'cleared
        txtSide1.Clear()                'cleared
        lblLetterASA.Visible = False    'invisible
        lblSolutionASA.Visible = False  'invisible
        lblSolutionASA.Text = ""        'empty
        lblMissingAngle.Text = ""       'empty
        lblMissingAngle.Visible = False 'invisible
        btnAnswerASA.Visible = False    'invisible
        btnSSA.Visible = False          'invisible

        txtExampleSine1ofASA.Text = ""  'empty
        txtExampleSine2ofASA.Text = ""  'empty
        txtExampleSide1ofASA.Text = ""  'empty
        txtExampleSide2ofASA.Text = ""  'empty
        txtSide2.Text = ""              'empty
        btnNext.Visible = True         'invisible
        panAnswers1And2.Visible = False 'invisible
        btnSolveSSA.Visible = False     'invisible
        btnSAS.Visible = False          'invisible
        grpSAS.Visible = False          'invisible
        btnSolveSAS.Visible = False     'invisible
        panASA.Visible = True          'invisible
        btnClear.Visible = True        'invisible
        txtKnown1.Clear()               'cleared
        txtKnown11.Clear()              'cleared
        txtKnown2.Clear()               'cleared
        txtKnown22.Clear()              'cleared
        txtKnownCos.Clear()             'cleared
        lblSASanswer.Text = ""          'empty

        radAaBb.Checked = False         'unchecked
        radAaCc.Checked = False         'unchecked
        radabA.Checked = False          'unchecked
        radABabSAA.Checked = False      'unchecked
        radABacSAA.Checked = False      'unchecked
        radabB.Checked = False          'unchecked
        radABba.Checked = False         'unchecked
        radABbASAA.Checked = False      'unchecked
        radABbcSAA.Checked = False      'unchecked
        radaBc.Checked = False          'unchecked
        radacA.Checked = False          'unchecked
        radACabSAA.Checked = False      'unchecked
        radacC.Checked = False          'unchecked
        radACca.Checked = False         'unchecked
        radACcaSAA.Checked = False      'unchecked
        radACcbSAA.Checked = False      'unchecked
        radASA.Checked = False          'unchecked
        radBbCc.Checked = False         'unchecked
        radbCa.Checked = False          'unchecked
        radbcB.Checked = False          'unchecked
        radBCbaSAA.Checked = False      'unchecked
        radBCbcSAA.Checked = False      'unchecked
        radbcC.Checked = False          'unchecked
        radBCcaSAA.Checked = False      'unchecked
        radBCcb.Checked = False         'unchecked
        radBCcbSAA.Checked = False      'unchecked
        radcAb.Checked = False          'unchecked
        radSAA.Checked = False          'unchecked
        radSAS.Checked = False          'unchecked
        radSSA.Checked = False          'unchecked
        radSSS.Checked = False          'unchecked
        txtSSSa.BackColor = Color.White 'color change
        txtSSSb.BackColor = Color.White 'color change
        txtSSSc.BackColor = Color.White 'color change
        txtSSSa.ReadOnly = False        'can write
        txtSSSb.ReadOnly = False        'can write
        txtSSSc.ReadOnly = False        'can write
        lblSSSa.Text = ""               'clear
        lblSSSb.Text = ""               'clear
        lblSSSc.Text = ""               'clear
        btnSolveA.Enabled = True        'enabled
        btnSolveB.Enabled = True        'enabled
        btnSolveC.Enabled = True        'enabled
        txtSSSa.Clear()                 'cleared
        txtSSSb.Clear()                 'cleared
        txtSSSc.Clear()                 'cleared
        panSASsolving.Visible = False   'invisible
        panSSS.Visible = False          'invisible
        btnSAA.Visible = False          'invisible
        btnContinueToSSS.Visible = False 'invisible
        grpSAS.Visible = False         'invisible
        radSSA.Enabled = False

        Threading.Thread.Sleep(4000)    'splash screen sleep
    End Sub

    'codes for the clear button
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        btnSAS.Enabled = True           '
        grpAngleType.Enabled = True     '
        btnNext.Enabled = True          '
        btnContinueToSSS.Visible = False 'invisible

        lblAngle1SSA1.Text = ""         'empty
        lblAngle2SSA1.Text = ""         'empty
        lblAngle3SSA1.Text = ""         'empty
        lblLength1SSA1.Text = ""        'empty
        lblLength2SSA1.Text = ""        'empty
        lblLength3SSA1.Text = ""        'empty
        lblAngle1SSA2.Text = ""         'empty
        lblAngle2SSA2.Text = ""         'empty
        lblAngle3SSA2.Text = ""         'empty
        lblLength1SSA2.Text = ""        'empty
        lblLength2SSA2.Text = ""        'empty
        lblLength3SSA2.Text = ""        'empty

        panAngles.Visible = False       'invisible
        picOblique.Visible = False      'invisible
        panSolve.Visible = False        'invisible
        grpASA.Visible = False          'invisible
        grpSAA.Visible = False          'invisible
        grpAngleType.Visible = True    'invisible
        grpSSA.Visible = False          'invisible
        txtSide2.ReadOnly = False       'not read only
        txtMissingAngle1.Clear()        'cleared
        txtMissingAngle2.Clear()        'cleared
        lblMissing3rdAngleSAA.Text = "" 'empty
        txtSine1.Clear()                'cleared
        txtSine2.Clear()                'cleared
        txtSide1.Clear()                'cleared
        lblLetterASA.Visible = False    'invisible
        lblSolutionASA.Visible = False  'invisible
        lblSolutionASA.Text = ""        'empty
        lblMissingAngle.Text = ""       'empty
        lblMissingAngle.Visible = False 'invisible
        btnAnswerASA.Visible = False    'invisible
        btnSSA.Visible = False          'invisible

        txtExampleSine1ofASA.Text = ""  'empty
        txtExampleSine2ofASA.Text = ""  'empty
        txtExampleSide1ofASA.Text = ""  'empty
        txtExampleSide2ofASA.Text = ""  'empty
        txtSide2.Text = ""              'empty
        btnNext.Visible = True         'invisible
        panAnswers1And2.Visible = False 'invisible
        btnSolveSSA.Visible = False     'invisible
        btnSAS.Visible = False          'invisible
        grpSAS.Visible = False          'invisible
        panASA.Visible = True          'invisible
        btnClear.Visible = True        'invisible
        txtKnown1.Clear()               'cleared
        txtKnown11.Clear()              'cleared
        txtKnown2.Clear()               'cleared
        txtKnown22.Clear()              'cleared
        txtKnownCos.Clear()             'cleared
        btnSolveSAS.Visible = False     'invisible
        lblSASanswer.Text = ""          'empty

        radAaBb.Checked = False         'unchecked
        radAaCc.Checked = False         'unchecked
        radabA.Checked = False          'unchecked
        radABabSAA.Checked = False      'unchecked
        radABacSAA.Checked = False      'unchecked
        radabB.Checked = False          'unchecked
        radABba.Checked = False         'unchecked
        radABbASAA.Checked = False      'unchecked
        radABbcSAA.Checked = False      'unchecked
        radaBc.Checked = False          'unchecked
        radacA.Checked = False          'unchecked
        radACabSAA.Checked = False      'unchecked
        radacC.Checked = False          'unchecked
        radACca.Checked = False         'unchecked
        radACcaSAA.Checked = False      'unchecked
        radACcbSAA.Checked = False      'unchecked
        radASA.Checked = False          'unchecked
        radBbCc.Checked = False         'unchecked
        radbCa.Checked = False          'unchecked
        radbcB.Checked = False          'unchecked
        radBCbaSAA.Checked = False      'unchecked
        radBCbcSAA.Checked = False      'unchecked
        radbcC.Checked = False          'unchecked
        radBCcaSAA.Checked = False      'unchecked
        radBCcb.Checked = False         'unchecked
        radBCcbSAA.Checked = False      'unchecked
        radcAb.Checked = False          'unchecked
        radSAA.Checked = False          'unchecked
        radSAS.Checked = False          'unchecked
        radSSA.Checked = False          'unchecked
        radSSS.Checked = False          'unchecked
        txtSSSa.BackColor = Color.White 'color change
        txtSSSb.BackColor = Color.White 'color change
        txtSSSc.BackColor = Color.White 'color change
        txtSSSa.ReadOnly = False        'can write
        txtSSSb.ReadOnly = False        'can write
        txtSSSc.ReadOnly = False        'can write
        lblSSSa.Text = ""               'clear
        lblSSSb.Text = ""               'clear
        lblSSSc.Text = ""               'clear
        btnSolveA.Enabled = True        'enabled
        btnSolveB.Enabled = True        'enabled
        btnSolveC.Enabled = True        'enabled
        panSASsolving.Visible = False   'invisible
        panSSS.Visible = False          'invisible
        btnSAA.Visible = False          'invisible
        btnContinueToSSS.Visible = False 'invisible
        panSASsolving.Visible = False   'invisible
        grpSAS.Visible = False          'invisible
        radSSA.Enabled = False

    End Sub

    'menu strip -instructions-
    Private Sub InstructionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click

        btnInstructions_Click(Nothing, e)

    End Sub

    'menu strip -clear-
    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        btnClear_Click(Nothing, e)

    End Sub

    'menu strip -close-
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Close()

    End Sub

    'continue to SSS button function
    Private Sub btnContinueToSSS_Click(sender As System.Object, e As System.EventArgs) Handles btnContinueToSSS.Click
        grpASA.Visible = False                  'invisible
        grpSAA.Visible = False                  'invisible
        panAngles.Visible = False               'invisible
        panMissingAngleSAA.Visible = False      'invisible
        btnSAA.Visible = False                  'invisible
        grpAngleType.Visible = True             'invisible
        grpASA.Visible = False                  'invisible
        grpSAA.Visible = False                  'invisible
        grpSSA.Visible = False                  'invisible
        btnNext.Visible = True                  'invisible
        btnASA.Visible = False                  'invisible
        btnSAA.Visible = False                  'invisible
        btnSSA.Visible = False                  'invisible
        btnSolveSAS.Visible = False             'invisible
        btnSAS.Visible = False                  'invisible
        grpSAS.Visible = False                  'invisible
        picOblique.Visible = True               'visible
        panSolve.Visible = False                'invisible
        panSSS.Visible = True                   'visible
        panAngles.Visible = True                'visible
        btnContinueToSSS.Visible = False        '
        panSASsolving.Visible = False           '
        btnSolveSAS.Visible = False             '
        btnContinueToSSS.Visible = False        '
        grpAngleType.Enabled = False            '
        btnNext.Enabled = False                 '


    End Sub

    'to execute the clear everything button, from the right triangle solving screen
    Private Sub btnClearRight_Click(sender As System.Object, e As System.EventArgs)

        btnClear_Click(Nothing, e)

    End Sub

    'exit Button
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
