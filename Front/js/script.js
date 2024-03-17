let navbar = document.querySelector('.header .flex .navbar');

document.querySelector('#menu-btn').onclick = () =>{
   navbar.classList.toggle('active');
}


let account = document.querySelector('.user-account');

document.querySelector('#proximobtn').onclick = () =>{
   const token = localStorage.getItem('jwtToken');

   fetch('https://localhost:7232/api/Endereco', {
     method: 'GET',
     headers: {
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${token}`
     }
   })
   .then(response => response.json())
   .then(data => {
      document.getElementById('rua').value = data.rua;
      document.getElementById('numero').value = data.numero;
   })
   .catch(error => {
     console.error('Erro no registro:', error);
   });
   account.classList.add('active');   
}

document.querySelector('#user-btn').onclick = () =>{
   document.location.href="pginicial.html";   
}


document.querySelector('#close-account').onclick = () =>{
   account.classList.remove('active');
}




let myOrders = document.querySelector('.my-orders');

document.querySelector('#order-btn').onclick = () =>{
   myOrders.classList.add('active');
}

document.querySelector('#close-orders').onclick = () =>{
   myOrders.classList.remove('active');
}


let cart = document.querySelector('.shopping-cart');


document.querySelector('#cart-btn').onclick = () =>{
   cart.classList.add('active');
}

document.querySelector('#close-cart').onclick = () =>{
   cart.classList.remove('active');
}


window.onscroll = () =>{
   navbar.classList.remove('active');
   myOrders.classList.remove('active');
   cart.classList.remove('active');
};

let slides = document.querySelectorAll('.home-bg .home .slide-container .slide');
let index = 0;

function next(){
   slides[index].classList.remove('active');
   index = (index + 1) % slides.length;
   slides[index].classList.add('active');
}

function prev(){
   slides[index].classList.remove('active');
   index = (index - 1 + slides.length) % slides.length;
   slides[index].classList.add('active');
}

let accordion = document.querySelectorAll('.faq .accordion-container .accordion');

accordion.forEach(acco =>{
   acco.onclick = () =>{
      accordion.forEach(remove => remove.classList.remove('active'));
      acco.classList.add('active');
   }
});

function getPizzas(){
   fetch('https://sua-api.com/pizzas')
  .then(response => response.json())
  .then(data => {
      const pizzasContainer = document.getElementById('pizzas-container');

      data.forEach(pizza => {
      const pizzaElement = document.createElement('div');
      pizzaElement.innerHTML = `
         <div class="price">R$ ${pizza.Preco}</div>
         <img src="images/pizza-6.jpg" alt="">
         <div class="name">${pizza.Titulo}</div>
      `;
      pizzasContainer.appendChild(pizzaElement);
      });
  })
  .catch(error => {
    console.error('Erro ao obter dados das pizzas:', error);
  });
}

document.addEventListener('DOMContentLoaded', function() {
   fetch('https://localhost:7232/api/Pizza/GetAllPizzas')
   .then(response => response.json())
   .then(data => {
         
       const pizzasContainer = document.getElementById('pizzas-container');
 
       data.forEach(pizza => {
       const pizzaElement = document.createElement('div');
       pizzaElement.className = 'box';
       pizzaElement.innerHTML = `
          <div class="price">R$ ${pizza.preco}</div>
          <img src="images/pizza-6.jpg" alt="">
          <div class="name">${pizza.titulo}</div>
          <form action="" method="post">
            <input type="number" min="1" max="100" value="1" class="qty" name="qty">
            <input type="submit" value="+ Carrinho" name="add_to_cart" class="btn">
         </form>
       `;
       pizzasContainer.appendChild(pizzaElement);
       });
   })
   .catch(error => {
     console.error('Erro ao obter dados das pizzas:', error);
   });
});

// document.getElementById('carrinhoForm').addEventListener('submit', function(event) {
//    event.preventDefault(); 

//    const token = localStorage.getItem('jwtToken');

//    fetch('https://localhost:7232/api/Endereco', {
//      method: 'GET',
//      headers: {
//       'Content-Type': 'application/json',
//       'Authorization': `Bearer ${token}`
//      }
//    })
//    .then(response => response.json())
//    .then(data => {
//       document.getElementById('rua').value = data.rua;
//       document.getElementById('numero').value = data.numero;
//    })
//    .catch(error => {
//      console.error('Erro no registro:', error);
//    });
//  });


document.getElementById('pedidoForm').addEventListener('submit', function(event) {
   event.preventDefault(); 

   const token = localStorage.getItem('jwtToken');
 
   const nome = document.getElementById('nomePedido').value;
   const telefone = document.getElementById('numeroTelefone').value;
   const metodoDePagamento = document.getElementById('metododepagamento').value;
   const metodoDeEntrega = document.getElementById('metododeentrega').value;
   const rua = document.getElementById('rua').value;
   const numero = document.getElementById('numero').value;

 
   fetch('https://localhost:7232/api/Pedido/CriarPedido', {
     method: 'POST',
     headers: {
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${token}`
     },
     body: JSON.stringify({
        telefone : telefone,
        nome : nome, 
        mododePagamento : metodoDePagamento,
        modoDeEntrega : metodoDeEntrega,
        rua : rua,
        numero : numero
     })
   })
   .then(response => response.json())
   .then(data => {
     console.log('Pedido realizado com sucesso. ');
   })
   .catch(error => {
     console.error('Erro no registro:', error);
   });
 });

