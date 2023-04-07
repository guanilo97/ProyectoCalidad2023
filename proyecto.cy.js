describe('registro', () =>{
  it('visit login', () => {
      cy.visit('http://localhost:63716/UsuarioCliente/Registrarse')
      cy.get('#Nombre').type('agusto')
      cy.get('#DNI').type('12345678')
      cy.get('#Apodo').type('hhh')
      cy.get('#Direccion').type('chepen')
      cy.get('#Telefono').type('123456789')
      cy.get('#Correo').type('agusto_01@hotmail.com')
      cy.get('#Contrasenia').type('agusto123')
      cy.get('#RepitaContasenia').type('agusto123')
      cy.get('#regis').click()
      cy.get('button').should('have.value', 'Registrarme')
   })
 });

describe('login proyecto', () =>{
   it('visit login', () => {
   cy.visit('http://localhost:63716/Auth/Login')
    cy.get('#userNameInput').type('pedro_01@hotmail.com')
    cy.get('#passwordInput').type('pedro123')
    cy.get('#submitButton').click()
    cy.get('button').should('have.value', 'Acceder')
     })
   });


describe('Agregar_Productos', () =>{
   it('visit login', () => {
   cy.visit('http://localhost:63716/Auth/Login')
    cy.get('#userNameInput').type('pedro_01@hotmail.com')
    cy.get('#passwordInput').type('pedro123')
    cy.get('#submitButton').click()
    cy.get('#productos').click()
    cy.get('#AgregarAlcarrito').click()
    cy.get('#modalpedidos').click()
    cy.get('#completar').click()
    cy.get('#entrega').type('Jr. Cruz de piedra 661')
    cy.get('#fecha').type('18/11/2022')
    cy.get('#cel').type('994141309')
    cy.get('#aceptar').click()
    cy.visit('http://localhost:63716/Home/MisPedidos')
     })
   });

describe('cotizacion', () =>{
   it('visit login', () => {
   cy.visit('http://localhost:63716/Auth/Login')
    cy.get('#userNameInput').type('pedro_01@hotmail.com')
    cy.get('#passwordInput').type('pedro123')
    cy.get('#submitButton').click()
    cy.get('#cotizacion').click()
    cy.get('#imagedoc').selectFile('C:/Users/HP/Downloads/cama.jpg')
    cy.get('#nombreproducto').type('Prueba')
    cy.get('#medidasPro').type('30x80')
    cy.get('#cantidadPro').type('1')
    cy.get('#DescripcionPro').type('funcion')
    cy.get('#Agregar').click()
    cy.get('#registrarcotizacion').click()
    cy.visit('http://localhost:63716/Home/MisCotizaciones')
     })
   });
   describe('login admin', () =>{
      it('visit crear productos', () => {
      cy.visit('http://localhost:63716/Auth/Login')
       cy.get('#userNameInput').type('jefri_gch@hotmail.com')
       cy.get('#passwordInput').type('jefrivalentin123')
       cy.get('#submitButton').click()
       cy.get('#prdiuctos').click()
       cy.get('#crearcate').click()
       cy.get('#crearca').click()
       cy.get('#Nombre').type('cama')
       cy.get('#Descripcion').type('cualquier material')

       prdiuctos
      })
   });

   describe('login admin', () =>{
      it('visit crear productos', () => {
      cy.visit('http://localhost:63716/Auth/Login')
       cy.get('#userNameInput').type('jefri_gch@hotmail.com')
       cy.get('#passwordInput').type('jefrivalentin123')
       cy.get('#submitButton').click()
       cy.get('#prdiuctos').click()
       cy.get('#crearpro').click()
       cy.get('#crear').click()
       cy.get('#imagedoc').selectFile('C:/Users/HP/Downloads/cama.jpg')
       cy.get('#imagedoc').selectFile('C:/Users/HP/Downloads/cama.jpg')
       cy.get('#imagedoc').selectFile('C:/Users/HP/Downloads/cama.jpg')
       cy.get('#Nombre').type('cama')
       cy.get('#Medidas').type('40x80')
       cy.get('#Precio').type('200')
       cy.get('#Id_Categoria').select('cama')
       cy.get('#Id_Categoria').select('3004').should('have.value', '3004')
       cy.get('#Descripcion').type('cama hecha de cedro')
       cy.get('#guardar').click()
       

        })
      });
      describe('login admin', () =>{
         it('administrar pedidos', () => {
         cy.visit('http://localhost:63716/Auth/Login')
          cy.get('#userNameInput').type('jefri_gch@hotmail.com')
          cy.get('#passwordInput').type('jefrivalentin123')
          cy.get('#submitButton').click()
          cy.get('#pedidos').click()
          cy.get('#nuevo').click()
          cy.get('#iniciar').click()
          cy.get('.swal2-popup swal2-modal swal2-icon-warning swal2-show').next()
          cy.get('.swal2-confirm btn btn-success').click()
          cy.get('#Descripcion').type('cualquier material')
          cy.visit('http://localhost:63716/PedidoAdmin/EnConstruccion')
         })
      });
