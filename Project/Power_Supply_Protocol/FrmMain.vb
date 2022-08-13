Option Strict Off

Public Class FRMMain

#Region "Variables Definition"

    Private STR_InSerial As String = ""
    Private VP_Str_Erro As String = ""
    Private VP_Vol_Out As String = "000"
    Private VP_Vol_In As String = "000"
    Private VP_Cur_Out As String = "000"
    Private VP_Cur_In As String = "000"
    Private VP_Data_Turn As Byte = 0

    Private RP_Str_Erro As String = ""
    Private RP_Vol_Out As String = "000"
    Private RP_Vol_In As String = "000"
    Private RP_Cur_Out As String = "000"
    Private RP_Cur_In As String = "000"
    Private RP_Data_Turn As Byte = 0
    Private RP_Time_Counter As Byte = 1

#End Region

#Region "Form Events"

    Private Sub FRMMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            NumUpDown_RP_Set_Current.ReadOnly = Not RdoBtn_RealMachine.Checked
            NumUpDown_RP_Set_Voltage.ReadOnly = Not RdoBtn_RealMachine.Checked
            NumUpDown_VP_Set_Current.ReadOnly = Not RdoBtn_VirtualMachine.Checked
            NumUpDown_VP_Set_Voltage.ReadOnly = Not RdoBtn_VirtualMachine.Checked

            MSCom.BaudRate = 9600
            MSCom.DataBits = 8
            MSCom.Parity = IO.Ports.Parity.None
            MSCom.PortName = "COM1"
            MSCom.StopBits = IO.Ports.StopBits.One
            TmrHandler.Enabled = True
            If MSCom.IsOpen = False Then MSCom.Open()
            RP_Data_Turn = 1
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Port Events"

    Private Sub MSCom_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles MSCom.DataReceived
        Try
            If MSCom.BytesToRead > 0 Then
                STR_InSerial = MSCom.ReadExisting
                If RdoBtn_RealMachine.Checked Then
                    If RP_Data_Turn = 1 Then
                        RP_Vol_In = Mid(STR_InSerial, 1, 3)
                        RP_Cur_In = Mid(STR_InSerial, 4, 3)
                        RP_Data_Turn = 0
                    Else
                        Dim Char_InSerial() As Char
                        ReDim Char_InSerial(STR_InSerial.Length - 1)
                        Char_InSerial = STR_InSerial.ToCharArray
                        RP_Str_Erro = RP_Str_Erro & "Recieved String: " & STR_InSerial & " ||Recieve String Length: " & STR_InSerial.Length & vbNewLine
                        RP_Str_Erro = RP_Str_Erro & "Recieve Characters" & vbNewLine
                        For I As Integer = 0 To UBound(Char_InSerial)
                            RP_Str_Erro = RP_Str_Erro & AscW(Char_InSerial(I)) & vbNewLine
                        Next I
                        RP_Data_Turn = 0
                    End If
                Else
                    Dim Char_OutSerial() As Char
                    If Mid(STR_InSerial, 1, 1) = "8" Then
                        MSCom.Write(VP_Vol_Out & VP_Cur_Out)

                    ElseIf Mid(STR_InSerial, 1, 1) = "1" Then
                        VP_Cur_In = Mid(STR_InSerial, 2, 4)
                        ReDim Char_OutSerial(1)
                        Char_OutSerial(1) = "1"
                        MSCom.Write(Char_OutSerial)
                        VP_Data_Turn = 2

                    ElseIf Mid(STR_InSerial, 1, 1) = "2" Then
                        VP_Vol_In = Mid(STR_InSerial, 2, 4)
                        ReDim Char_OutSerial(1)
                        Char_OutSerial(1) = "1"
                        MSCom.Write(Char_OutSerial)
                        VP_Data_Turn = 1
                    End If
                End If
            End If
        Catch ex As Exception
            If RdoBtn_RealMachine.Checked Then
                RP_Str_Erro = RP_Str_Erro & vbNewLine & STR_InSerial
            Else
                VP_Str_Erro = VP_Str_Erro & vbNewLine & STR_InSerial
            End If

        End Try
    End Sub

#End Region

#Region "Time Events"

    Private Sub TmrHandler_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrHandler.Tick
        Try
            If RdoBtn_VirtualMachine.Checked Then

                If VP_Data_Turn = 1 Then
                    NumUpDown_VP_Set_Voltage.Value = Val(VP_Vol_In) / 10.0
                ElseIf VP_Data_Turn = 2 Then
                    NumUpDown_VP_Set_Current.Value = Val(VP_Cur_In) / 10.0
                End If
                VP_Data_Turn = 0
                VP_Vol_Out = (NumUpDown_VP_Set_Voltage.Value * 10.0).ToString("000")
                VP_Cur_Out = (NumUpDown_VP_Set_Current.Value * 10.0).ToString("000")
                NumUpDown_VP_Get_Voltage.Value = (Val(VP_Vol_In) / 10.0)
                NumUpDown_VP_Get_Current.Value = (Val(VP_Cur_In) / 10.0)
                Txt_VP_ErrTable.Text = VP_Str_Erro

            Else
                If RP_Time_Counter = 1 Then

                    RP_Data_Turn = RP_Time_Counter
                    MSCom.Write("8")
                    RP_Time_Counter = 2

                ElseIf RP_Time_Counter = 2 Then

                    Dim Volt_Temp As Integer = NumUpDown_RP_Set_Voltage.Value * 10
                    Dim Volt_Check As Integer = 2
                    While Volt_Temp > 0
                        Volt_Check = Volt_Check + (Volt_Temp Mod 10)
                        Volt_Temp = Volt_Temp \ 10
                    End While
                    Volt_Check = Volt_Check Mod 10
                    RP_Vol_Out = "2" & (NumUpDown_RP_Set_Voltage.Value * 10).ToString("0000") & Volt_Check.ToString("0")
                    RP_Data_Turn = RP_Time_Counter
                    MSCom.Write(RP_Vol_Out)
                    RP_Time_Counter = 3

                Else

                    Dim Curr_Temp As Integer = NumUpDown_RP_Set_Current.Value * 10
                    Dim Curr_Check As Integer = 1
                    While Curr_Temp > 0
                        Curr_Check = Curr_Check + (Curr_Temp Mod 10)
                        Curr_Temp = Curr_Temp \ 10
                    End While
                    Curr_Check = Curr_Check Mod 10
                    RP_Cur_Out = "1" & (NumUpDown_RP_Set_Current.Value * 10).ToString("0000") & Curr_Check.ToString("0")
                    RP_Data_Turn = RP_Time_Counter
                    MSCom.Write(RP_Cur_Out)
                    RP_Time_Counter = 1

                End If

                NumUpDown_RP_Get_Voltage.Value = Val(RP_Vol_In) / 10.0
                NumUpDown_RP_Get_Current.Value = Val(RP_Cur_In) / 10.0
                Txt_RP_ErrTable.Text = RP_Str_Erro

            End If

        Catch ex As Exception
            If RdoBtn_RealMachine.Checked Then
                RP_Str_Erro = RP_Str_Erro & vbNewLine & ex.Message & vbNewLine & ex.ToString
            Else
                VP_Str_Erro = VP_Str_Erro & vbNewLine & ex.Message & vbNewLine & ex.ToString
            End If
        End Try
    End Sub

#End Region

#Region "Component Events"

    Private Sub RdoBtn_RealMachine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoBtn_RealMachine.CheckedChanged
        NumUpDown_RP_Set_Current.ReadOnly = Not RdoBtn_RealMachine.Checked
        NumUpDown_RP_Set_Voltage.ReadOnly = Not RdoBtn_RealMachine.Checked
    End Sub

    Private Sub RdoBtn_VirtualMachine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoBtn_VirtualMachine.CheckedChanged
        NumUpDown_VP_Set_Current.ReadOnly = Not RdoBtn_VirtualMachine.Checked
        NumUpDown_VP_Set_Voltage.ReadOnly = Not RdoBtn_VirtualMachine.Checked
    End Sub

#End Region

End Class
