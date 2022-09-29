Public Class Form1


    Dim pic(8) As PictureBox
    Dim picture(8) As PictureBox
    Dim numdelay(8) As TextBox

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim swap As Boolean
        Dim CopyBox As Integer
        Dim pointer As Integer
        Dim list(8) As Integer
        Button3.Visible = False
        Button4.Visible = False
        list(1) = TextBox1.Text
        list(2) = TextBox2.Text
        list(3) = TextBox3.Text
        list(4) = TextBox4.Text
        list(5) = TextBox5.Text
        list(6) = TextBox6.Text
        list(7) = TextBox7.Text
        list(8) = TextBox8.Text

        Do
            swap = False
            For pointer = 1 To 7
                If list(pointer) > list(pointer + 1) Then
                    CopyBox = list(pointer)
                    list(pointer) = list(pointer + 1)
                    list(pointer + 1) = CopyBox
                    swap = True
                End If

            Next pointer
        Loop Until swap = False

        TextBox9.Text = list(1)
        TextBox10.Text = list(2)
        TextBox11.Text = list(3)
        TextBox12.Text = list(4)
        TextBox13.Text = list(5)
        TextBox14.Text = list(6)
        TextBox15.Text = list(7)
        TextBox16.Text = list(8)
        Button3.Visible = True
        Button4.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim swap As Boolean
        Dim CopyBox As Integer
        Dim pointer As Integer
        Dim setthing(8) As Integer
        Dim list(8) As Integer
        Dim copynum(8) As Integer


        Button3.Visible = False
        Button4.Visible = False

        list(1) = TextBox1.Text
        List(2) = TextBox2.Text
        List(3) = TextBox3.Text
        List(4) = TextBox4.Text
        List(5) = TextBox5.Text
        List(6) = TextBox6.Text
        List(7) = TextBox7.Text
        List(8) = TextBox8.Text


        Do
            swap = False
            For pointer = 1 To 7
                If list(pointer) > list(pointer + 1) Then
                    pic(pointer).Visible = True
                    pic(pointer + 1).Visible = True
                    delay(1)
                    Label2.Text = "swap"
                    Label2.BackColor = Color.Green

                    CopyBox = list(pointer)
                    TextBox17.Text = CopyBox
                    delay(1)
                    list(pointer) = list(pointer + 1)

                    list(pointer + 1) = CopyBox

                    swap = True
                    pic(pointer).Visible = False
                    pic(pointer + 1).Visible = False

                Else
                    Label2.Text = "No Swap"
                    Label2.BackColor = Color.Red

                End If
                TextBox1.Text = list(1)
                TextBox2.Text = list(2)
                TextBox3.Text = list(3)
                TextBox4.Text = list(4)
                TextBox5.Text = list(5)
                TextBox6.Text = list(6)
                TextBox7.Text = list(7)
                TextBox8.Text = list(8)
            Next pointer

        Loop Until swap = False
        Label2.Text = "Finished"
        Label2.BackColor = Color.Blue

        Button3.Visible = True
        Button4.Visible = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pic(1) = PictureBox1
        pic(2) = PictureBox2
        pic(3) = PictureBox3
        pic(4) = PictureBox4
        pic(5) = PictureBox5
        pic(6) = PictureBox6
        pic(7) = PictureBox7
        pic(8) = PictureBox8

        picture(1) = PictureBox9
        picture(2) = PictureBox10
        picture(3) = PictureBox11
        picture(4) = PictureBox12
        picture(5) = PictureBox13
        picture(6) = PictureBox14
        picture(7) = PictureBox15
        picture(8) = PictureBox16

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
       


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox17.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox10.Text = ""
        Label2.Text = ""
        Label2.BackColor = Color.White
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim x As Integer
        Dim rn As Integer
        Dim text(8) As Integer
       
        Randomize()
        For x = 1 To 8
            rn = Int(Rnd() * 99) + 1
            text(x) = rn

        Next
        TextBox1.Text = text(1)
        TextBox2.Text = text(2)
        TextBox3.Text = text(3)
        TextBox4.Text = text(4)
        TextBox5.Text = text(5)
        TextBox6.Text = text(6)
        TextBox7.Text = text(7)
        TextBox8.Text = text(8)
        

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim copybox As Integer
        Dim list(8) As Integer
        Dim up As Integer
        Dim sp As Integer
        Button3.Visible = False
        Button4.Visible = False
        list(1) = TextBox1.Text
        list(2) = TextBox2.Text
        list(3) = TextBox3.Text
        list(4) = TextBox4.Text
        list(5) = TextBox5.Text
        list(6) = TextBox6.Text
        list(7) = TextBox7.Text
        list(8) = TextBox8.Text

        For sp = 1 To 8
            up = sp
            copybox = list(sp)
            While up > 0 And list(up - 1) > copybox
                list(up) = list(up - 1)
                up = up - 1
            End While
            list(up) = copybox
        Next

        TextBox1.Text = list(1)
        TextBox2.Text = list(2)
        TextBox3.Text = list(3)
        TextBox4.Text = list(4)
        TextBox5.Text = list(5)
        TextBox6.Text = list(6)
        TextBox7.Text = list(7)
        TextBox8.Text = list(8)
        Button3.Visible = True
        Button4.Visible = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim copybox As Integer
        Dim list(8) As Integer
        Dim up As Integer
        Dim sp As Integer
        Button3.Visible = False
        Button4.Visible = False
        list(1) = TextBox1.Text
        list(2) = TextBox2.Text
        list(3) = TextBox3.Text
        list(4) = TextBox4.Text
        list(5) = TextBox5.Text
        list(6) = TextBox6.Text
        list(7) = TextBox7.Text
        list(8) = TextBox8.Text

            For sp = 1 To 8
                up = sp
                picture(up).Visible = True
                pic(sp).Visible = True

                delay(1)
                picture(up).Visible = False
                copybox = list(sp)
                TextBox17.Text = copybox
                While up > 0 AndAlso list(up - 1) > copybox
                    list(up) = list(up - 1)
                    up = up - 1
                    picture(up).Visible = True

                    delay(1)
                    picture(up).Visible = False

                End While
                list(up) = copybox
                picture(up).Visible = True
                delay(1)
            picture(up).Visible = False
            pic(sp).Visible = False
                TextBox1.Text = list(1)
                TextBox2.Text = list(2)
                TextBox3.Text = list(3)
                TextBox4.Text = list(4)
                TextBox5.Text = list(5)
                TextBox6.Text = list(6)
                TextBox7.Text = list(7)
                TextBox8.Text = list(8)
            Next
        Label2.Text = "Finished"
        Label2.BackColor = Color.Blue
        Button3.Visible = True
        Button4.Visible = True
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    End Sub
End Class
