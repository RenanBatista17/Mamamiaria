document.getElementById('registroForm').addEventListener('submit', function(event) {
    event.preventDefault(); // Evita o envio padrão do formulário
  
    const nome = document.getElementById('nome').value;
    const email = document.getElementById('email').value;
    const senha = document.getElementById('senha').value;
    const cpf = document.getElementById('cpf').value;
    const idade = document.getElementById('idade').value;
    // Obtenha os outros valores dos campos do formulário
  
    fetch('https://localhost:7232/api/User/Register', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
         email : email,
         passWord : senha,
         nome : nome, 
         cpf : cpf,
         idade : idade
        // Outros dados necessários para o registro
      })
    })
    .then(response => response.json())
    .then(data => {
      const token = data.token;
      console.log('Registro realizado com sucesso. Token JWT obtido:', token);
  
      // Armazenar o token em localStorage ou sessionStorage para uso posterior
      localStorage.setItem('jwtToken', token);
      document.location.href="enderecoCadastro.html";
    })
    .catch(error => {
      console.error('Erro no registro:', error);
    });
  });
 
  document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault(); // Evita o envio padrão do formulário
  
    const email = document.getElementById('emaillogin').value;
    const senha = document.getElementById('senhalogin').value;
    
    // Obtenha os outros valores dos campos do formulário
  
    fetch('https://localhost:7232/api/User/Login', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
         email : email,
         passWord : senha
        // Outros dados necessários para o registro
      })
    })
    .then(response => response.json())
    .then(data => {
      const token = data.token;
      console.log('Login realizado com sucesso. Token JWT obtido:', token);
      document.location.href="index.html";
  
      // Armazenar o token em localStorage ou sessionStorage para uso posterior
      localStorage.setItem('jwtToken', token);
    })
    .catch(error => {
      console.error('Erro no Login:', error);
    });
  });

 