Public Class frmangkhana

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsum.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResult5.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim Vistra, Frista, sell As Integer
        Dim VistraCom, FristaCom, TotalCommition As Long
        Vistra = txtsum.Text
        Frista = txtsum1.Text

        sell = Vistra + Frista

        VistraCom = Vistra * 5 / 100
        FristaCom = Frista * 10 / 100

        txtcom.Text = VistraCom
        txtcom1.Text = FristaCom

        TotalCommition = VistraCom + FristaCom
        
        lblResult5.Text = sell
        lblResult6.Text = TotalCommition



    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsum1.TextChanged

    End Sub

    Private Sub txtsum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcom.Click, txtcom1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox.Click, Label11.Click

    End Sub
End Class
