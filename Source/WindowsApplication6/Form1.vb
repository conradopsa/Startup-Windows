Imports Microsoft.Win32
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'HKCU
        Dim local As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Dim reg As RegistryKey = Registry.CurrentUser.OpenSubKey(local, True)
        reg.SetValue("TESTE [HKCU]", Application.ExecutablePath)
        reg.SetValue("TESTE [HKCU] /attrib", """" & Application.ExecutablePath & """ /teste -teste --teste123 \dadasd")

        Dim local2 As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\Run"
        Dim reg2 As RegistryKey = Registry.CurrentUser.OpenSubKey(local2, True)
        reg2.SetValue("TESTE [HKCU--POLICIES]", Application.ExecutablePath)

        Dim local3 As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce"
        Dim reg3 As RegistryKey = Registry.CurrentUser.OpenSubKey(local3, True)
        reg3.SetValue("TESTE [HKCU--RUNONCE]", Application.ExecutablePath)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'HKLM
        Dim local As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Dim reg As RegistryKey = Registry.LocalMachine.OpenSubKey(local, True)
        reg.SetValue("TESTE [HKLM]", Application.ExecutablePath)
        reg.SetValue("TESTE [HKLM] /attrib", """" & Application.ExecutablePath & """ /teste -teste --teste123 \dadasd")

        Dim local2 As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\Run"
        Dim reg2 As RegistryKey = Registry.LocalMachine.OpenSubKey(local2, True)
        reg2.SetValue("TESTE [HKLM--POLICIES]", Application.ExecutablePath)

        Dim local3 As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce"
        Dim reg3 As RegistryKey = Registry.LocalMachine.OpenSubKey(local3, True)
        reg3.SetValue("TESTE [HKLM--RUNONCE]", Application.ExecutablePath)

        Dim local5 As String = "SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\RunOnce"
        Dim reg5 As RegistryKey = Registry.LocalMachine.OpenSubKey(local5, True)
        reg5.SetValue("TESTE [HKLM--RUNONCE]", Application.ExecutablePath)

        Dim local6 As String = "SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run"
        Dim reg6 As RegistryKey = Registry.LocalMachine.OpenSubKey(local6, True)
        reg6.SetValue("TESTE [HKLM_Wow6432Node]", Application.ExecutablePath)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IO.File.Copy(Application.ExecutablePath,
                     Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) _
                     & "\Microsoft\Windows\Start Menu\Programs\Startup\teste.exe")

        IO.File.Copy(Application.ExecutablePath,
                     Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) _
                     & "\Microsoft\Windows\Start Menu\Programs\Startup\teste2.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim local As String = "Software\Microsoft\Windows\CurrentVersion\explorer\Shell Folders"
        Dim reg As RegistryKey = Registry.LocalMachine.OpenSubKey(local, True)
        reg.SetValue("TESTE [HKLM_Wow6432Node]", Application.ExecutablePath)
    End Sub
End Class
