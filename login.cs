		////////////////////////////////////////////////////////////
		// EVENTO DE CLICK DO BOTAO			
		private void button1_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////
            // VERIFICA ESPAÇO EM BRANCO E RETORNA MENSSAGEM DE ERRO!
            this.Hide();
            if (TextBox1.Text == "" && TextBox2.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!");
            }

            ////////////////////////////////////////////////////////////
            // VERIFICA O LOGIN DE USUARIO

            if (TextBox1.Text == "ravokthc" & TextBox2.Text == "6256811")

            {
                MessageBox.Show("Bem Vindo RavokTHC, Bola mais um Baseado para nois!", "Login efetuado com Sucesso!", MessageBoxButtons.OK);
                Painel newForm = new Painel();
                newForm.Show();
            }

            ////////////////////////////////////////////////////////////
            // RETORNA ERRO DE LOGIN INVALIDO

            else
            {
                MessageBox.Show("Falha no Login", "Usuario ou Senha invalidos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
