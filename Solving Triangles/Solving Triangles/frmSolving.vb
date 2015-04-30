Public Class frmSolving

    Private Sub btnSolve_Click(sender As System.Object, e As System.EventArgs) Handles btnSolve.Click
        Dim strSideA As String
        Dim strSideB As String
        Dim strSideC As String
        Dim strSideD As String
        Dim strSideE As String
        Dim strSideF As String
        Dim strSideP As String
        Dim strSideQ As String
        Dim strSideR As String

        Dim decSideA As Decimal
        Dim decSideB As Decimal
        Dim decSideC As Decimal
        Dim decSideD As Decimal
        Dim decSideE As Decimal
        Dim decSideF As Decimal
        Dim decSideP As Decimal
        Dim decSideQ As Decimal
        Dim decSideR As Decimal

        Dim AngleA As Decimal
        Dim AngleB As Decimal
        Dim AngleC As Decimal
        Dim AngleD As Decimal
        Dim AngleE As Decimal
        Dim AngleF As Decimal
        Dim AngleP As Decimal
        Dim AngleQ As Decimal
        Dim AngleR As Decimal

        Dim xSolveA As Decimal
        Dim xSolveB As Decimal
        Dim xSolveC As Decimal
        Dim xSolveD As Decimal
        Dim xSolveE As Decimal
        Dim xSolveF As Decimal
        Dim xSolveP As Decimal
        Dim xSolveQ As Decimal
        Dim xSolveR As Decimal


        'convert all to decimal
        'A
        strSideA = txta.Text
        If IsNumeric(txta.Text) Then
            decSideA = Convert.ToDecimal(strSideA)
            If decSideA < 0 Then
                MsgBox("Please enter a posetive number for Side Length a", , "")
                txta.Text = "a"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length a", , "")
            txta.Text = "a"
        End If

        'B
        strSideB = txtb.Text
        If IsNumeric(txtb.Text) Then
            decSideB = Convert.ToDecimal(strSideB)
            If decSideB < 0 Then
                MsgBox("Please enter a posetive number for Side Length b", , "")
                txtb.Text = "b"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length b", , "")
            txtb.Text = "b"
        End If

        'C
        strSideC = txtc.Text
        If IsNumeric(txtc.Text) Then
            decSideC = Convert.ToDecimal(strSideC)
            If decSideC < 0 Then
                MsgBox("Please enter a posetive number for Side Length c", , "")
                txtc.Text = "c"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length c", , "")
            txtc.Text = "c"
        End If

        'D
        strSideD = txtd.Text
        If IsNumeric(txtd.Text) Then
            decSideD = Convert.ToDecimal(strSideD)
            If decSideD < 0 Then
                MsgBox("Please enter a posetive number for Side Length d", , "")
                txtd.Text = "d"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length d", , "")
            txtd.Text = "d"
        End If

        'E
        strSideE = txte.Text
        If IsNumeric(txte.Text) Then
            decSideE = Convert.ToDecimal(strSideE)
            If decSideE < 0 Then
                MsgBox("Please enter a posetive number for Side Length e", , "")
                txte.Text = "e"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length e", , "")
            txte.Text = "e"
        End If

        'F
        strSideF = txtf.Text
        If IsNumeric(txtf.Text) Then
            decSideF = Convert.ToDecimal(strSideF)
            If decSideF < 0 Then
                MsgBox("Please enter a posetive number for Side Length f", , "")
                txtf.Text = "f"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length f", , "")
            txtf.Text = "f"
        End If

        'P
        strSideP = txtp.Text
        If IsNumeric(txtp.Text) Then
            decSideP = Convert.ToDecimal(strSideP)
            If decSideP < 0 Then
                MsgBox("Please enter a posetive number for Side Length p", , "")
                txtp.Text = "p"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length p", , "")
            txtp.Text = "p"
        End If

        'Q
        strSideQ = txtq.Text
        If IsNumeric(txtq.Text) Then
            decSideQ = Convert.ToDecimal(strSideQ)
            If decSideQ < 0 Then
                MsgBox("Please enter a posetive number for Side Length q", , "")
                txtq.Text = "q"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length q", , "")
            txtq.Text = "q"
        End If

        'R
        strSideR = txtr.Text
        If IsNumeric(txtr.Text) Then
            decSideR = Convert.ToDecimal(strSideR)
            If decSideR < 0 Then
                MsgBox("Please enter a posetive number for Side Length r", , "")
                txtr.Text = "r"
            End If
        Else
            MsgBox("Please enter a numeric number for Side Length r", , "")
            txtr.Text = "r"
        End If

        'start Inverse Cosine SSS for the known sides
        If (decSideA > 0 And decSideB > 0 And decSideC > 0) Then
            xSolveA = ((Math.Pow(decSideB, 2) + Math.Pow(decSideC, 2) - Math.Pow(decSideA, 2)) / (2 * decSideB * decSideC))
            xSolveB = ((Math.Pow(decSideC, 2) + Math.Pow(decSideA, 2) - Math.Pow(decSideB, 2)) / (2 * decSideC * decSideA))
            xSolveC = ((Math.Pow(decSideA, 2) + Math.Pow(decSideB, 2) - Math.Pow(decSideC, 2)) / (2 * decSideA * decSideB))
            xSolveD = ((Math.Pow(decSideE, 2) + Math.Pow(decSideF, 2) - Math.Pow(decSideD, 2)) / (2 * decSideE * decSideF))
            xSolveE = ((Math.Pow(decSideF, 2) + Math.Pow(decSideD, 2) - Math.Pow(decSideE, 2)) / (2 * decSideF * decSideD))
            xSolveF = ((Math.Pow(decSideD, 2) + Math.Pow(decSideE, 2) - Math.Pow(decSideF, 2)) / (2 * decSideD * decSideE))
            xSolveP = ((Math.Pow(decSideQ, 2) + Math.Pow(decSideR, 2) - Math.Pow(decSideP, 2)) / (2 * decSideQ * decSideR))
            xSolveQ = ((Math.Pow(decSideR, 2) + Math.Pow(decSideP, 2) - Math.Pow(decSideQ, 2)) / (2 * decSideR * decSideP))
            xSolveR = ((Math.Pow(decSideP, 2) + Math.Pow(decSideQ, 2) - Math.Pow(decSideR, 2)) / (2 * decSideP * decSideQ))

            'First Triangle Qualifications
            If (decSideA + decSideB <= decSideC) Then
                txta.BackColor = Color.Red
                txtb.BackColor = Color.Red
                txtc.BackColor = Color.Red
                lblAngleA.Text = "Angle A: "
                lblAngleB.Text = "Angle B: "
                lblAngleC.Text = "Angle C: "
                MsgBox("Side Lengths: a,b,c, do not form a triangle.", , "Not a Triangle")
            ElseIf (decSideA + decSideC <= decSideB) Then
                txta.BackColor = Color.Red
                txtb.BackColor = Color.Red
                txtc.BackColor = Color.Red
                lblAngleA.Text = "Angle A: "
                lblAngleB.Text = "Angle B: "
                lblAngleC.Text = "Angle C: "
                MsgBox("Side Lengths: a,b,c, do not form a triangle.", , "Not a Triangle")
            ElseIf (decSideB + decSideC <= decSideA) Then
                txta.BackColor = Color.Red
                txtb.BackColor = Color.Red
                txtc.BackColor = Color.Red
                lblAngleA.Text = "Angle A: "
                lblAngleB.Text = "Angle B: "
                lblAngleC.Text = "Angle C: "
                MsgBox("Side Lengths: a,b,c, do not form a triangle.", , "Not a Triangle")
            Else
                txta.BackColor = Color.LightGreen
                txtb.BackColor = Color.LightGreen
                txtc.BackColor = Color.LightGreen
                'Solve
                AngleA = Math.Atan(-xSolveA / Math.Sqrt(-xSolveA * xSolveA + 1)) + 2 * Math.Atan(1)
                lblAngleA.Text = "Angle A: " & (AngleA * (180 / Math.PI)).ToString("F1") & Chr(176)

                AngleB = Math.Atan(-xSolveB / Math.Sqrt(-xSolveB * xSolveB + 1)) + 2 * Math.Atan(1)
                lblAngleB.Text = "Angle B: " & (AngleB * (180 / Math.PI)).ToString("F1") & Chr(176)

                AngleC = Math.Atan(-xSolveC / Math.Sqrt(-xSolveC * xSolveC + 1)) + 2 * Math.Atan(1)
                lblAngleC.Text = "Angle C: " & (AngleC * (180 / Math.PI)).ToString("F1") & Chr(176)
            End If

            'Second Triangle Qualifications
            If (decSideD + decSideE <= decSideF) Then
                txtd.BackColor = Color.Red
                txte.BackColor = Color.Red
                txtf.BackColor = Color.Red
                lblAngleD.Text = "Angle D: "
                lblAngleE.Text = "Angle E: "
                lblAngleF.Text = "Angle F: "
                MsgBox("Side Lengths: d,e,f, do not form a triangle.", , "Not a Triangle")
            ElseIf (decSideE + decSideF <= decSideD) Then
                txtd.BackColor = Color.Red
                txte.BackColor = Color.Red
                txtf.BackColor = Color.Red
                lblAngleD.Text = "Angle D: "
                lblAngleE.Text = "Angle E: "
                lblAngleF.Text = "Angle F: "
                MsgBox("Side Lengths: d,e,f, do not form a triangle.", , "Not a Triangle")
            ElseIf (decSideF + decSideD <= decSideE) Then
                txtd.BackColor = Color.Red
                txte.BackColor = Color.Red
                txtf.BackColor = Color.Red
                lblAngleD.Text = "Angle D: "
                lblAngleE.Text = "Angle E: "
                lblAngleF.Text = "Angle F: "
                MsgBox("Side Lengths: d,e,f, do not form a triangle.", , "Not a Triangle")
            Else
                txtd.BackColor = Color.LightGreen
                txte.BackColor = Color.LightGreen
                txtf.BackColor = Color.LightGreen
                'Solve
                AngleD = Math.Atan(-xSolveD / Math.Sqrt(-xSolveD * xSolveD + 1)) + 2 * Math.Atan(1)
                lblAngleD.Text = "Angle D: " & (AngleD * (180 / Math.PI)).ToString("F1") & Chr(176)

                AngleE = Math.Atan(-xSolveE / Math.Sqrt(-xSolveE * xSolveE + 1)) + 2 * Math.Atan(1)
                lblAngleE.Text = "Angle E: " & (AngleE * (180 / Math.PI)).ToString("F1") & Chr(176)

                AngleF = Math.Atan(-xSolveF / Math.Sqrt(-xSolveF * xSolveF + 1)) + 2 * Math.Atan(1)
                lblAngleF.Text = "Angle F: " & (AngleF * (180 / Math.PI)).ToString("F1") & Chr(176)
            End If

            'Third Triangle Qualifications
            If (decSideP + decSideQ <= decSideR) Then
                txtp.BackColor = Color.Red
                txtq.BackColor = Color.Red
                txtr.BackColor = Color.Red
                lblAngleP.Text = "Angle P: "
                lblAngleQ.Text = "Angle Q: "
                lblAngleR.Text = "Angle R: "
                MsgBox("Side Lengths: p,q,r, do not form a triangle.", , "Not a Triangle")
            ElseIf (decSideQ + decSideR <= decSideP) Then
                txtp.BackColor = Color.Red
                txtq.BackColor = Color.Red
                txtr.BackColor = Color.Red
                lblAngleP.Text = "Angle P: "
                lblAngleQ.Text = "Angle Q: "
                lblAngleR.Text = "Angle R: "
                MsgBox("Side Lengths: p,q,r, do not form a triangle.", , "Not a Triangle")
            ElseIf (decSideR + decSideP <= decSideQ) Then
                txtp.BackColor = Color.Red
                txtq.BackColor = Color.Red
                txtr.BackColor = Color.Red
                lblAngleP.Text = "Angle P: "
                lblAngleQ.Text = "Angle Q: "
                lblAngleR.Text = "Angle R: "
                MsgBox("Side Lengths: p,q,r, do not form a triangle.", , "Not a Triangle")
            Else
                txtp.BackColor = Color.LightGreen
                txtq.BackColor = Color.LightGreen
                txtr.BackColor = Color.LightGreen
                'Solve
                AngleP = Math.Atan(-xSolveP / Math.Sqrt(-xSolveP * xSolveP + 1)) + 2 * Math.Atan(1)
                lblAngleP.Text = "Angle P: " & (AngleP * (180 / Math.PI)).ToString("F1") & Chr(176)

                AngleQ = Math.Atan(-xSolveQ / Math.Sqrt(-xSolveQ * xSolveQ + 1)) + 2 * Math.Atan(1)
                lblAngleQ.Text = "Angle Q: " & (AngleQ * (180 / Math.PI)).ToString("F1") & Chr(176)

                AngleR = Math.Atan(-xSolveR / Math.Sqrt(-xSolveR * xSolveR + 1)) + 2 * Math.Atan(1)
                lblAngleR.Text = "Angle R: " & (AngleR * (180 / Math.PI)).ToString("F1") & Chr(176)
            End If

            'Solve other Angles
            lblAngleN.Text = "Angle N: " & (180 - (AngleC * (180 / Math.PI)) - (AngleQ * (180 / Math.PI))).ToString("F1") & Chr(176)
            lblAngleG.Text = "Angle G: " & (180 - (AngleC * (180 / Math.PI)) - (AngleF * (180 / Math.PI))).ToString("F1") & Chr(176)
            lblAngleM.Text = "Angle M:" & (180 - (AngleR * (180 / Math.PI))).ToString("F1") & Chr(176)
            lblAngleH.Text = "Angle H:" & (180 - (AngleE * (180 / Math.PI))).ToString("F1") & Chr(176)
            lblAngleJ.Text = "Angle J: " & (360 - (AngleC * (180 / Math.PI)) - (AngleQ * (180 / Math.PI)) - (180 - (AngleC * (180 / Math.PI)) - _
                                            (AngleQ * (180 / Math.PI))) - (AngleF * (180 / Math.PI)) - (180 - (AngleC * (180 / Math.PI)) - (AngleF * _
                                            (180 / Math.PI)))).ToString("F1") & Chr(176)
            lblAngleI.Text = "Angle I:  " & (180 - (180 - (AngleC * (180 / Math.PI)) - (AngleF * (180 / Math.PI))) - (180 - (AngleE * _
                                            (180 / Math.PI)))).ToString("F1") & Chr(176)
            lblAngleO.Text = "Angle O: " & (180 - (180 - (AngleR * (180 / Math.PI))) - (180 - (AngleC * (180 / Math.PI)) - (AngleQ * _
                                            (180 / Math.PI)))).ToString("F1") & Chr(176)

            'Finding Sides
            lblSideA.Text = "Side Length a: " & decSideA.ToString("F2")
            lblSideB.Text = "Side Length b: " & decSideB.ToString("F2")
            lblSideC.Text = "Side Length c: " & decSideC.ToString("F2")
            lblSideD.Text = "Side Length d: " & decSideD.ToString("F2")
            lblSideE.Text = "Side Length e: " & decSideE.ToString("F2")
            lblSideF.Text = "Side Length f:  " & decSideF.ToString("F2")
            lblSideP.Text = "Side Length p: " & decSideP.ToString("F2")
            lblSideQ.Text = "Side Length q: " & decSideQ.ToString("F2")
            lblSideR.Text = "Side Length r:  " & decSideR.ToString("F2")
            lblSideI.Text = "Side Length i:   " & decSideD.ToString("F2")
            lblSideO.Text = "Side Length o: " & decSideP.ToString("F2")



            Dim angleG As Decimal = (180 - (AngleC * (180 / Math.PI)))
            Dim angleH As Decimal = (180 - (AngleE * (180 / Math.PI)))
            Dim angleI As Decimal = (180 - (180 - (AngleC * (180 / Math.PI)) - (AngleF * (180 / Math.PI))) - (180 - (AngleE * _
                                            (180 / Math.PI))))
            Dim angleJ As Decimal = (360 - (AngleC * (180 / Math.PI)) - (AngleQ * (180 / Math.PI)) - (180 - (AngleC * (180 / Math.PI)) - _
                                            (AngleQ * (180 / Math.PI))) - (AngleF * (180 / Math.PI)) - (180 - (AngleC * (180 / Math.PI)) - (AngleF * _
                                            (180 / Math.PI))))
            Dim angleK As Decimal
            Dim angleL As Decimal
            Dim angleM As Decimal = (180 - (AngleR * (180 / Math.PI)))
            Dim angleN As Decimal = (180 - (AngleC * (180 / Math.PI)))
            Dim angleO As Decimal = (180 - (180 - (AngleR * (180 / Math.PI))) - (180 - (AngleC * (180 / Math.PI)) - (AngleQ * _
                                            (180 / Math.PI))))

            Dim decORadians As Decimal
            Dim decMRadians As Decimal
            Dim decHRadians As Decimal
            Dim decIRadians As Decimal
            Dim decJRadians As Decimal
            Dim decK As Decimal
            Dim decl As Decimal
            Dim decj As Decimal

            'find side K
            decMRadians = angleM * (Math.PI / 180)
            decORadians = angleO * (Math.PI / 180)
            decK = Math.Sin(decMRadians) * (decSideP / Math.Sin(decORadians))
            lblSideK.Text = "Side Length k: " & decK.ToString("F2")

            'find side L
            decHRadians = angleH * (Math.PI / 180)
            decIRadians = angleI * (Math.PI / 180)
            decl = Math.Sin(decHRadians) * (decSideD / Math.Sin(decIRadians))
            lblSideL.Text = "Side Length l:  " & decl.ToString("F2")

            'find side length J
            decJRadians = angleJ * (Math.PI / 180)
            decj = Math.Sqrt((Math.Pow(decK, 2) + Math.Pow(decl, 2)) - (2 * decK * decl * Math.Cos(decJRadians)))
            lblSideJ.Text = "Side Length j:  " & decj.ToString("F2")

            Dim xK As Decimal
            Dim xL As Decimal


            'find Angle K
            xK = ((Math.Pow(decl, 2) + Math.Pow(decj, 2) - Math.Pow(decK, 2)) / (2 * decl * decj))
            angleK = Math.Atan(-xK / Math.Sqrt(-xK * xK + 1)) + 2 * Math.Atan(1)
            lblAngleK.Text = "Angle K: " & (angleK * (180 / Math.PI)).ToString("F1") & Chr(176)

            'find Angle L
            xL = ((Math.Pow(decK, 2) + Math.Pow(decj, 2) - Math.Pow(decl, 2)) / (2 * decK * decj))
            angleL = Math.Atan(-xL / Math.Sqrt(-xL * xL + 1)) + 2 * Math.Atan(1)
            lblAngleL.Text = "Angle L: " & (angleL * (180 / Math.PI)).ToString("F1") & Chr(176)

            'find other sides
            lblSideH.Text = "Side Length h: " & decl.ToString("F2")
            lblSideM.Text = "Side Length m:" & decK.ToString("F2")

            Dim decN As Decimal
            Dim decG As Decimal
            Dim decNRadians As Decimal
            Dim decGRadians As Decimal

            'change to radians
            decNRadians = angleN * (Math.PI / 180)
            decGRadians = angleG * (Math.PI / 180)

            'find side length N
            decN = Math.Sin(decNRadians) * (decSideP / Math.Sin(decORadians))
            lblSideN.Text = "Side Length n: " & decN.ToString("F2")

            'find side length G
            decG = Math.Sin(decGRadians) * (decSideD / Math.Sin(decIRadians))
            lblSideG.Text = "Side Length g: " & decG.ToString("F2")

            'find AB
            lblDistance.Text = "AB: " & decj.ToString("F2")

            'triangle checks
            If (decSideD + decl < decG) Then
                
            ElseIf (decl + decG < decSideD) Then
                lbli.BackColor = Color.LightGreen
                lblh.BackColor = Color.LightGreen
                lblg.BackColor = Color.LightGreen
            ElseIf (decSideD + decG < decl) Then
                lbli.BackColor = Color.LightGreen
                lblh.BackColor = Color.LightGreen
                lblg.BackColor = Color.LightGreen
            Else
                lbli.BackColor = Color.LightGreen
                lblh.BackColor = Color.LightGreen
                lblg.BackColor = Color.LightGreen
            End If

            If (decSideP + decK < decN) Then
                lblo.BackColor = Color.LightGreen
                lblm.BackColor = Color.LightGreen
                lbln.BackColor = Color.LightGreen
            ElseIf (decK + decN < decSideP) Then
                lblo.BackColor = Color.LightGreen
                lblm.BackColor = Color.LightGreen
                lbln.BackColor = Color.LightGreen
                
            ElseIf (decSideP + decN < decK) Then
                lblo.BackColor = Color.LightGreen
                lblm.BackColor = Color.LightGreen
                lbln.BackColor = Color.LightGreen
            Else
                lblo.BackColor = Color.LightGreen
                lblm.BackColor = Color.LightGreen
                lbln.BackColor = Color.LightGreen
            End If

            If (decK + decl < decj) Then
                lblj.BackColor = Color.Red
                lblk.BackColor = Color.Red
                lbll.BackColor = Color.Red
                lblSideJ.Text = "Side Length j: "
                lblSideK.Text = "Side Length k: "
                lblSideL.Text = "Side Length l: "
                lblAngleJ.Text = "Angle J: "
                lblAngleK.Text = "Angle K: "
                lblAngleL.Text = "Angle L: "
                MsgBox("Side Lengths: j,k,l, do not form a triangle.", , "Not a Triangle")
            ElseIf (decK + decj < decl) Then
                lblj.BackColor = Color.Red
                lblk.BackColor = Color.Red
                lbll.BackColor = Color.Red
                lblSideJ.Text = "Side Length j: "
                lblSideK.Text = "Side Length k: "
                lblSideL.Text = "Side Length l: "
                lblAngleJ.Text = "Angle J: "
                lblAngleK.Text = "Angle K: "
                lblAngleL.Text = "Angle L: "
                MsgBox("Side Lengths: j,k,l, do not form a triangle.", , "Not a Triangle")
            ElseIf (decl + decj < decK) Then
                lblj.BackColor = Color.Red
                lblk.BackColor = Color.Red
                lbll.BackColor = Color.Red
                lblSideJ.Text = "Side Length j: "
                lblSideK.Text = "Side Length k: "
                lblSideL.Text = "Side Length l: "
                lblAngleJ.Text = "Angle J: "
                lblAngleK.Text = "Angle K: "
                lblAngleL.Text = "Angle L: "
                MsgBox("Side Lengths: j,k,l, do not form a triangle.", , "Not a Triangle")
            Else
                lblj.BackColor = Color.LightGreen
                lblk.BackColor = Color.LightGreen
                lbll.BackColor = Color.LightGreen
            End If

        End If
    End Sub

    'frm load
    Private Sub frmSolving_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblSideA.Text = "Side Length a: "
        lblSideB.Text = "Side Length b: "
        lblSideC.Text = "Side Length c: "
        lblSideD.Text = "Side Length d: "
        lblSideE.Text = "Side Length e: "
        lblSideF.Text = "Side Length f: "
        lblSideG.Text = "Side Length g: "
        lblSideH.Text = "Side Length h: "
        lblSideI.Text = "Side Length i: "
        lblSideJ.Text = "Side Length j: "
        lblSideK.Text = "Side Length k: "
        lblSideL.Text = "Side Length l: "
        lblSideM.Text = "Side Length m: "
        lblSideN.Text = "Side Length n: "
        lblSideO.Text = "Side Length o: "
        lblSideP.Text = "Side Length p: "
        lblSideQ.Text = "Side Length q: "
        lblSideR.Text = "Side Length r: "

        lblAngleA.Text = "Angle A: "
        lblAngleB.Text = "Angle B: "
        lblAngleC.Text = "Angle C: "
        lblAngleD.Text = "Angle D: "
        lblAngleE.Text = "Angle E: "
        lblAngleF.Text = "Angle F: "
        lblAngleG.Text = "Angle G: "
        lblAngleH.Text = "Angle H: "
        lblAngleI.Text = "Angle I: "
        lblAngleJ.Text = "Angle J: "
        lblAngleK.Text = "Angle K: "
        lblAngleL.Text = "Angle L: "
        lblAngleM.Text = "Angle M: "
        lblAngleN.Text = "Angle N: "
        lblAngleO.Text = "Angle O: "
        lblAngleP.Text = "Angle P: "
        lblAngleQ.Text = "Angle Q: "
        lblAngleR.Text = "Angle R: "

        txta.BackColor = Color.SeaShell
        txtb.BackColor = Color.SeaShell
        txtc.BackColor = Color.SeaShell
        txtd.BackColor = Color.SeaShell
        txte.BackColor = Color.SeaShell
        txtf.BackColor = Color.SeaShell
        txtp.BackColor = Color.SeaShell
        txtq.BackColor = Color.SeaShell
        txtr.BackColor = Color.SeaShell
        lbli.BackColor = Color.White
        lblh.BackColor = Color.White
        lblg.BackColor = Color.White
        lbll.BackColor = Color.White
        lblk.BackColor = Color.White
        lblo.BackColor = Color.White
        lblm.BackColor = Color.White
        lbln.BackColor = Color.White
        lblj.BackColor = Color.White

        txta.Text = "a"
        txtb.Text = "b"
        txtc.Text = "c"
        txtd.Text = "d"
        txte.Text = "e"
        txtf.Text = "f"
        txtp.Text = "p"
        txtq.Text = "q"
        txtr.Text = "r"

        txtc.Focus()
        Threading.Thread.Sleep(4000)

    End Sub

    'clear
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        lblSideA.Text = "Side Length a: "
        lblSideB.Text = "Side Length b: "
        lblSideC.Text = "Side Length c: "
        lblSideD.Text = "Side Length d: "
        lblSideE.Text = "Side Length e: "
        lblSideF.Text = "Side Length f: "
        lblSideG.Text = "Side Length g: "
        lblSideH.Text = "Side Length h: "
        lblSideI.Text = "Side Length i: "
        lblSideJ.Text = "Side Length j: "
        lblSideK.Text = "Side Length k: "
        lblSideL.Text = "Side Length l: "
        lblSideM.Text = "Side Length m: "
        lblSideN.Text = "Side Length n: "
        lblSideO.Text = "Side Length o: "
        lblSideP.Text = "Side Length p: "
        lblSideQ.Text = "Side Length q: "
        lblSideR.Text = "Side Length r: "

        lblAngleA.Text = "Angle A: "
        lblAngleB.Text = "Angle B: "
        lblAngleC.Text = "Angle C: "
        lblAngleD.Text = "Angle D: "
        lblAngleE.Text = "Angle E: "
        lblAngleF.Text = "Angle F: "
        lblAngleG.Text = "Angle G: "
        lblAngleH.Text = "Angle H: "
        lblAngleI.Text = "Angle I: "
        lblAngleJ.Text = "Angle J: "
        lblAngleK.Text = "Angle K: "
        lblAngleL.Text = "Angle L: "
        lblAngleM.Text = "Angle M: "
        lblAngleN.Text = "Angle N: "
        lblAngleO.Text = "Angle O: "
        lblAngleP.Text = "Angle P: "
        lblAngleQ.Text = "Angle Q: "
        lblAngleR.Text = "Angle R: "

        txta.BackColor = Color.SeaShell
        txtb.BackColor = Color.SeaShell
        txtc.BackColor = Color.SeaShell
        txtd.BackColor = Color.SeaShell
        txte.BackColor = Color.SeaShell
        txtf.BackColor = Color.SeaShell
        txtp.BackColor = Color.SeaShell
        txtq.BackColor = Color.SeaShell
        txtr.BackColor = Color.SeaShell
        lbli.BackColor = Color.White
        lblh.BackColor = Color.White
        lblg.BackColor = Color.White
        lbll.BackColor = Color.White
        lblk.BackColor = Color.White
        lblo.BackColor = Color.White
        lblm.BackColor = Color.White
        lbln.BackColor = Color.White
        lblj.BackColor = Color.White

        txta.Text = "a"
        txtb.Text = "b"
        txtc.Text = "c"
        txtd.Text = "d"
        txte.Text = "e"
        txtf.Text = "f"
        txtp.Text = "p"
        txtq.Text = "q"
        txtr.Text = "r"

    End Sub

    'exit
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Close()

    End Sub

    'menu strip solve
    Private Sub SolveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SolveToolStripMenuItem.Click

        btnSolve_Click(Nothing, e)

    End Sub

    'menu strip clear
    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        btnClear_Click(Nothing, e)

    End Sub

    'menu strip exit
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        btnExit_Click(Nothing, e)

    End Sub
End Class
