document.getElementById('enderecoForm').addEventListener('submit', function(event) {
    event.preventDefault(); // Evita o envio padrão do formulário

    const token = localStorage.getItem('jwtToken');
  
    const rua = document.getElementById('rua').value;
    const numero = document.getElementById('numero').value;
    const cidade = document.getElementById('cidade').value;
    const estado = document.getElementById('estado').value;
    const cep = document.getElementById('cep').value;
    // Obtenha os outros valores dos campos do formulário
  
    fetch('https://localhost:7232/api/Endereco', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'Authorization': `Bearer ${token}`       
      },
      body: JSON.stringify({
         rua : rua,
         numero : numero,
         cidade : cidade, 
         estado : estado,
         cep : cep
        // Outros dados necessários para o registro
      })
    })
    .then(response => response.json())
    .then(data => {
      
      console.log('Registro de endereço realizado com sucesso. Token JWT obtido:', data.endereco);
  
      document.location.href="index.html";
    })
    .catch(error => {
      console.error('Erro no registro:', error);
    });
  });