SELECT cliente.Id, cliente.Nombre, cliente.Direccion, pedido_cliente.No_Ruta, pedido_cliente.Pedido 
FROM (cliente RIGHT JOIN pedido_cliente 
ON cliente.Id = pedido_cliente.Id_Cliente );
