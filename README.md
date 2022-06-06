# tps_laboratorio_ii

#TPFinal

## Flujo de programa
El programa permite levantar desde un archivo xml los datos para trabajar de manera inicial con productos. En caso de no poder hacerlo lo hace con una lista harcodeada.
La forma de hacer un pedido es clonar la lista de productos generando un clon con nuevas direcciones de memoria, la original no se modifica hasta no estar efectuada la compra.
Los cambios en la lista de ventas se guardan cada vez que se efectua una compra, y en el caso de la lista de alimentos cada vez que se borra o se agrega uno nuevo.

## Temas utilizados

###Excepciones
Se crearon excepciones unicas para evitar la carga de datos erroneos en los productos, como por ejemplo el stock o el precio

###Pruebas Unitarias
Derrarrolladas en un projecto aparte donde se se testea el correcto funcionamiento de la funcion de incrementar ID y de la implemetacion de una excepcion.

###Tipos Genericos
Se aplico dentro del serializador para permitir manejo de datos tipo Venta o Producto

###Interfaces
Se imnplento la interfacce ID utilizada tanto en la clave Venta como Producto

###Archivos
Su uso permite el uso de un ID unico en cada instancia de un nuevo Producto, leyendo el id desde un archivo txt

###Serializacion
En cada ejecucion del programama se verifica la lista de productos desde un archivo xml, lo mismo para la lista de ventas. Ambas se actualizacion con cada modificacion de las mismas.
