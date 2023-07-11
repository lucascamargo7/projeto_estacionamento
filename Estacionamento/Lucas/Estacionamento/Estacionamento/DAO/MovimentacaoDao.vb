Imports FirebirdSql.Data.FirebirdClient
Public Class MovimentacaoDao

    Public Sub registroEntrada(ByVal c As ClsVeiculo)
        Dim sql As String = ""

        Try
            sql = "Insert into movimentacao (placa, descricao, data, entrada, tipo) values "
            sql = sql & "(@placa, @descricao, @data, @entrada, @tipo)"

            Connection.conOpen()
            Dim cmd As New FbCommand(sql, Connection.cnn)
            cmd.Parameters.Add("@placa", c.placa)
            cmd.Parameters.Add("@descricao", c.descricao)
            cmd.Parameters.Add("@tipo", c.tipo)
            cmd.Parameters.Add("@data", DateTime.Now.ToShortDateString())
            cmd.Parameters.Add("@entrada", DateTime.Now.ToShortTimeString())
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        Connection.conClose()
    End Sub

    Public Function retornaListaMovimentacao() As List(Of ClsVeiculo)

        Dim sql As String
        Dim listaVeiculos As New List(Of ClsVeiculo)

        Try
            sql = "select entrada, placa, descricao, tipo from movimentacao where data = @data and saida is null"
            Connection.conOpen()
            Dim cmd As New FbCommand(sql, Connection.cnn)
            cmd.Parameters.Add("@data", DateTime.Now.ToShortDateString())
            Dim dr As FbDataReader = cmd.ExecuteReader()

            Do While dr.Read
                Dim veiculos As New ClsVeiculo
                veiculos.placa = dr.Item("placa").ToString()
                veiculos.descricao = dr.Item("descricao").ToString()
                veiculos.entrada = Convert.ToDateTime(dr.Item("entrada")).ToString("HH:mm")
                veiculos.tipo = dr.Item("tipo").ToString()
                listaVeiculos.Add(veiculos)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        Connection.conClose()
        Return listaVeiculos

    End Function

    Public Function retornaListaPesquisaVeiculos(ByVal descricao As String) As List(Of ClsVeiculo)

        Dim sql As String
        Dim listaVeiculos As New List(Of ClsVeiculo)

        Try
            sql = "select entrada, placa, descricao, tipo from movimentacao where upper(placa) like upper(@descricao) and data = @data and saida is null or upper(descricao) like upper(@descricao) and data = @data and saida is null"
            Connection.conOpen()
            Dim cmd As New FbCommand(sql, Connection.cnn)
            cmd.Parameters.Add("@data", DateTime.Now.ToShortDateString())
            cmd.Parameters.Add("@descricao", "%" & descricao & "%")
            Dim dr As FbDataReader = cmd.ExecuteReader()

            Do While dr.Read
                Dim veiculos As New ClsVeiculo
                veiculos.placa = dr.Item("placa").ToString()
                veiculos.descricao = dr.Item("descricao").ToString()
                veiculos.entrada = Convert.ToDateTime(dr.Item("entrada")).ToString("HH:mm")
                veiculos.tipo = dr.Item("tipo").ToString()
                listaVeiculos.Add(veiculos)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        Connection.conClose()
        Return listaVeiculos

    End Function

    Public Function RetornaListaTiposVeiculos() As List(Of ClsVeiculo)
        Dim sql As String
        Dim veiculos As New List(Of ClsVeiculo)

        Try
            sql = "select * from valores"
            Connection.conOpen()

            Dim cmd As New FbCommand(sql, Connection.cnn)
            Dim dr As FbDataReader = cmd.ExecuteReader()
            If dr.Read = True Then
                Do While dr.Read
                    Dim veiculo As New ClsVeiculo
                    veiculo.tipo = dr.Item("tipo").ToString()
                    veiculo.valor_hora = dr.Item("hora").ToString()
                    veiculo.valor_meiahora = dr.Item("meiahora").ToString()
                    veiculo.valor_acrescimo = dr.Item("acrescimo").ToString
                    veiculos.Add(veiculo)
                Loop
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

        Return veiculos

    End Function

    Public Function retornaValores(ByVal tipo As String) As List(Of ClsVendas)
        Dim sql As String
        Dim veiculos As New List(Of ClsVendas)

        Try
            sql = "select meiahora, hora, acrescimo from valores where tipo = @tipo"
            Connection.conOpen()
            Dim cmd As New FbCommand(sql, Connection.cnn)
            cmd.Parameters.Add("@tipo", tipo)
            Dim dr As FbDataReader = cmd.ExecuteReader()
            Do While dr.Read
                Dim veiculo As New ClsVendas
                veiculo.valor_hora = dr.Item("hora").ToString()
                veiculo.valor_meiahora = dr.Item("meiahora").ToString()
                veiculo.valor_acrescimo = dr.Item("acrescimo").ToString
                veiculos.Add(veiculo)
            Loop


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

        Return veiculos

    End Function



    Public Sub finalizaVenda(ByVal c As ClsVendas)
        Dim sql As String = ""
        Try
            sql = "update movimentacao set saida = @saida, total_horas = @total_horas, total = @total_valor where placa=@placa and data=@data"

            Connection.conOpen()
            Dim cmd As New FbCommand(sql, Connection.cnn)
            cmd.Parameters.Add("@placa", c.placa)
            cmd.Parameters.Add("@saida", c.saida)
            cmd.Parameters.Add("@total_horas", c.total_horas)
            cmd.Parameters.Add("@total_valor", c.total_valor)
            cmd.Parameters.Add("@data", DateTime.Now.ToShortDateString())
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        Connection.conClose()
    End Sub

End Class
