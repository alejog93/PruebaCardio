Imports Newtonsoft.Json

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim api = New DBApi()

        Dim persona = New Persona()
        persona.Tittle = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit"
        persona.ID = "1"

        Dim url = "https://jsonplaceholder.typicode.com/posts "

        Dim headers = New List(Of Parametro) From {
            New Parametro("Authorization", "bearer asdasdas"),
            New Parametro("Cookie", "asdasdasdas")
        }

        Dim parametros = New List(Of Parametro)

        Dim response = api.Post(url, headers, parametros, persona)

        Dim result = JsonConvert.DeserializeObject(Of respuesta)(response)

        txtId.Text = result.id.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim api = New DBApi()

        Dim url = "https://jsonplaceholder.typicode.com/posts"

        Dim headers = New List(Of Parametro) From {
            New Parametro("Authorization", "bearer asdasdas"),
            New Parametro("Cookie", "asdasdasdas")
        }

        Dim parametros = New List(Of Parametro) From {
            New Parametro("Nombre", "Saulo de Tarso"),
            New Parametro("Oficio", "Predicador")
        }

        Dim response = api.Post(url, headers, parametros, Nothing)

        Dim result = JsonConvert.DeserializeObject(Of respuesta)(response)

        txtId.Text = result.Title.ToString()
    End Sub
End Class

Class respuesta
    Public Property ID As String
    Public Property Title As String
End Class
