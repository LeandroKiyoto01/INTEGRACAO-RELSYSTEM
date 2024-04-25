namespace Integracao_Semi_Eletronica_IP_WINFORMS_C_
{
    public partial class F_exemplo : Form
    {
        public F_exemplo()
        {
            InitializeComponent();
        }

        private void F_exemplo_Load(object sender, EventArgs e)
        {

        }

        private void ReceberTexto(string texto)
        {
            rtb_log.AppendText(texto);
            rtb_log.SelectionStart = rtb_log.Text.Length;
            rtb_log.ScrollToCaret();
        }

        #region configIP
        private async void btn_salvarIP_Click(object sender, EventArgs e)
        {
            string recebeIP = mtb_ip.Text;
            string recebeMascara = mtb_mascara.Text;
            string recebeGateway = mtb_gateway.Text;
            string recebePorta = tb_porta.Text;

            if (recebeIP.Length == 12 && recebeMascara.Length == 12 && recebeGateway.Length == 12)
            {
                // URL para enviar a solicita��o POST
                string url = $"http://{Globais.IPEquipamento}/setIP?ip={recebeIP}&mascara={recebeMascara}&gateway={recebeGateway}&porta={recebePorta}";

                // Criar inst�ncia do HttpClient
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        // Criar conte�do da solicita��o (vazio para POST)
                        HttpContent conteudo = new StringContent("");

                        // Enviar solicita��o POST
                        HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                        // Verificar se a solicita��o foi bem-sucedida
                        if (resposta.IsSuccessStatusCode)
                        {
                            ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                        }
                        else
                        {
                            ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                    }
                }
            }
            else
            {
                ReceberTexto("\r\nErro: O tamanho dos endere�os IP, m�scara e gateway deve ser 12 caracteres.");
            }
        }
        #endregion

        #region login
        private async void btn_salvarUsuario_Click(object sender, EventArgs e)
        {
            string recebeUsuario = tb_usuario.Text;
            string recebeSenha = tb_senha.Text;

            // Verificar se os campos n�o est�o vazios
            if (!string.IsNullOrEmpty(recebeUsuario) && !string.IsNullOrEmpty(recebeSenha))
            {
                // URL para enviar a solicita��o POST
                string url = $"http://{Globais.IPEquipamento}/setLogin?usuario={recebeUsuario}&senha={recebeSenha}";

                // Criar inst�ncia do HttpClient
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        // Criar conte�do da solicita��o (vazio para POST)
                        HttpContent conteudo = new StringContent("");

                        // Enviar solicita��o POST
                        HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                        // Verificar se a solicita��o foi bem-sucedida
                        if (resposta.IsSuccessStatusCode)
                        {
                            ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                        }
                        else
                        {
                            ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                    }
                }
            }
            else
            {
                // Notificar sobre o erro de campos vazios
                ReceberTexto("\r\nErro: Os campos n�o podem estar vazios.");
            }
        }
        #endregion

        #region giro
        private async void btn_salvarGiro_Click(object sender, EventArgs e)
        {
            string tipoGiro = "1"; // Padr�o: Acesso �nico
            string sentidoGiro = "undefined";
            string inverteGiro = "2";

            if (cb_acessoUnico.Checked)
            {
                tipoGiro = "1";
                cb_acessoDuplo.Checked = false; // Desmarcar o outro CheckBox se este estiver marcado
            }
            else if (cb_acessoDuplo.Checked)
            {
                tipoGiro = "2";
                cb_acessoUnico.Checked = false; // Desmarcar o outro CheckBox se este estiver marcado
            }

            if (cb_ambasLiberadas.Checked)
            {
                sentidoGiro = "1";
            }
            else if (cb_entradaLiberada.Checked)
            {
                sentidoGiro = "2";
            }
            else if (cb_saidaLiberada.Checked)
            {
                sentidoGiro = "3";
            }
            else
            {
                sentidoGiro = "undefined";
            }

            if (cb_inverteGiro.Checked)
            {
                inverteGiro = "1";
            }
            else
            {
                inverteGiro = "2";
            }

            // URL para enviar a solicita��o POST
            string url = $"http://{Globais.IPEquipamento}/setConfigGiro?sentidoGiroID={sentidoGiro}&inverteGiro={inverteGiro}";

            // Criar inst�ncia do HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Criar conte�do da solicita��o (vazio para POST)
                    HttpContent conteudo = new StringContent("");

                    // Enviar solicita��o POST
                    HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                    // Verificar se a solicita��o foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                    }
                    else
                    {
                        ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                }
            }

            // URL para enviar a solicita��o POST
            string url2 = $"http://{Globais.IPEquipamento}/setTipoGiro?tipoGiro={tipoGiro}";

            // Criar inst�ncia do HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Criar conte�do da solicita��o (vazio para POST)
                    HttpContent conteudo = new StringContent("");

                    // Enviar solicita��o POST
                    HttpResponseMessage resposta = await client.PostAsync(url2, conteudo);

                    // Verificar se a solicita��o foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                    }
                    else
                    {
                        ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                }
            }

        }
        #endregion

        #region acionamento
        private async void btn_salvarAcionamento_Click(object sender, EventArgs e)
        {
            string recebeAcionamento = tb_acionamento.Text;

            // Verificar se os campos n�o est�o vazios
            if (!string.IsNullOrEmpty(recebeAcionamento))
            {
                // URL para enviar a solicita��o POST
                string url = $"http://{Globais.IPEquipamento}/setAcionamento?tempoAcionamento={recebeAcionamento}";

                // Criar inst�ncia do HttpClient
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        // Criar conte�do da solicita��o (vazio para POST)
                        HttpContent conteudo = new StringContent("");

                        // Enviar solicita��o POST
                        HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                        // Verificar se a solicita��o foi bem-sucedida
                        if (resposta.IsSuccessStatusCode)
                        {
                            ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                        }
                        else
                        {
                            ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                    }
                }
            }
            else
            {
                // Notificar sobre o erro de campos vazios
                ReceberTexto("\r\nErro: Os campos n�o podem estar vazios.");
            }
        }
        #endregion

        #region liberaAmbos
        private async void btn_liberaAmbos_Click(object sender, EventArgs e)
        {
            // URL para enviar a solicita��o POST
            string url = $"http://{Globais.IPEquipamento}/liberacaoGiro?libera=1";

            // Criar inst�ncia do HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Criar conte�do da solicita��o (vazio para POST)
                    HttpContent conteudo = new StringContent("");

                    // Enviar solicita��o POST
                    HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                    // Verificar se a solicita��o foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                    }
                    else
                    {
                        ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                }
            }
        }
        #endregion

        #region liberaEntrada
        private async void btn_liberaEntrada_Click(object sender, EventArgs e)
        {
            // URL para enviar a solicita��o POST
            string url = $"http://{Globais.IPEquipamento}/liberacaoGiro?libera=2";

            // Criar inst�ncia do HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Criar conte�do da solicita��o (vazio para POST)
                    HttpContent conteudo = new StringContent("");

                    // Enviar solicita��o POST
                    HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                    // Verificar se a solicita��o foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                    }
                    else
                    {
                        ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                }
            }
        }
        #endregion

        #region liberaSaida
        private async void btn_liberaSaida_Click(object sender, EventArgs e)
        {
            // URL para enviar a solicita��o POST
            string url = $"http://{Globais.IPEquipamento}/liberacaoGiro?libera=3";

            // Criar inst�ncia do HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Criar conte�do da solicita��o (vazio para POST)
                    HttpContent conteudo = new StringContent("");

                    // Enviar solicita��o POST
                    HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                    // Verificar se a solicita��o foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                    }
                    else
                    {
                        ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                }
            }
        }
        #endregion

        #region limitadorDeGiro
        private async void btn_salvarLimitador_Click(object sender, EventArgs e)
        {
            string limitadorGiro = "2";

            if (cb_limitadorDeGiro.Checked)
            {
                limitadorGiro = "1"; //ativado
            }
            else
            {
                limitadorGiro = "2"; //desativado
            }

            // URL para enviar a solicita��o POST
            string url = $"http://{Globais.IPEquipamento}/setLimitadorGiro?limitadorGiro={limitadorGiro}&limite={tb_limite.Text}&alerta={tb_alerta.Text}";

            // Criar inst�ncia do HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Criar conte�do da solicita��o (vazio para POST)
                    HttpContent conteudo = new StringContent("");

                    // Enviar solicita��o POST
                    HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                    // Verificar se a solicita��o foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                    }
                    else
                    {
                        ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                }
            }
        }
        #endregion

        #region zerarLimitador
        private async void btn_zerarLimitador_Click(object sender, EventArgs e)
        {
            // URL para enviar a solicita��o POST
            string url = $"http://{Globais.IPEquipamento}/zeraLimitador?zera=1";

            // Criar inst�ncia do HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Criar conte�do da solicita��o (vazio para POST)
                    HttpContent conteudo = new StringContent("");

                    // Enviar solicita��o POST
                    HttpResponseMessage resposta = await client.PostAsync(url, conteudo);

                    // Verificar se a solicita��o foi bem-sucedida
                    if (resposta.IsSuccessStatusCode)
                    {
                        ReceberTexto("\r\nSolicita��o POST enviada com sucesso.");
                    }
                    else
                    {
                        ReceberTexto($"\r\nErro ao enviar solicita��o: {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    ReceberTexto($"\r\nOcorreu um erro: {ex.Message}");
                }
            }
        }
        #endregion
    }
}
