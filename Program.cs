
internal class Program
{
    

    public int contadorProductos = 0;
    public string[] codigosProducto = new string[300];
    public string[] descripcionesProducto = new string[300];
    public string[] unidadesMedidasProductos = new string[300];
    public int[] cantidadesProducto = new int[300];
    public decimal[] preciosProducto = new decimal[300];

    public int contadorUsuarios = 0;
    public string[] idsUsuario = new string[300];
    public string[] nombresUsuarios = new string[300];
    public string[] contrasenasUsuarios = new string[300];


    public int contadorClientes = 0;
    public string[] codigosClientes = new string[300];
    public string[] nombresCLientes = new string[300];
    public string[] nitsClientes = new string[300];
    public string[] direccionClientes = new string[300];


    public int contadorVentas = 0;
    public int[] idVentas = new int[300];
    public string[] codigosClientesVenta = new string[300];
    public string[] Cod_serieVentas = new string[300];
    public string[,] productosVenta = new string[300, 300];
    public int[] contadorProductosVenta = new int[300];
    public int[,] cantidadesVenta = new int[300, 300];


    private static void Main(string[] args)
    {



        Program tda = new Program();

        tda.programaInicial();


    }




    public void programaInicial()
    {

        string usuario = "";
        string contrasena = "";

        

        do
        {
            Console.Clear();
            Console.WriteLine("         Bienvenido al programa");
            Console.WriteLine("   Por favor, ingrese sus credenciales:");
            Console.WriteLine();

            Console.Write("\tUsuario: ");
            usuario = Console.ReadLine();
            Console.Write("\tContraseña: ");
            contrasena = Console.ReadLine();




            if (usuario == "Admin" && contrasena == "Admin2023&")
            {
                Console.Clear();
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("*                          ¡Bienvenido, login Exitoso                   *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                MostrarMenuPrincipal();
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("!!!Error!!! Usuario o contraseña incorrectos. precione cualquier tecla para intentar nuevamente.");
                Console.ReadKey();
            }
        } while (true);
    }

    public void MostrarMenuPrincipal()
    {



        int op = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*                        ¡Bienvenido a SuperMarkBasic                   *");
            Console.WriteLine("*************************************************************************");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Bienvenido Selecciona Una Opcion");
            Console.WriteLine("1. Catalogos");
            Console.WriteLine("2. Inventarios");
            Console.WriteLine("3. Ventas");
            Console.WriteLine("4. Salir");

            op = int.Parse(Console.ReadLine());


            switch (op)
            {

                case 1:

                    MenuCatalogos();

                    break;

                case 2:

                    MenuInventarios();
                    break;

                case 3:

                    MenuVentas();
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("  =) Gracias por utilizar el programa =), esta saliendo.");
                    Console.ReadKey();

                    break;


                default:
                    Console.WriteLine();
                    Console.WriteLine("Error, Introdusca una opcion Valida, presione una tecla para continuar");
                    Console.ReadKey();
                    MostrarMenuPrincipal();
                    break;
            }

        } while (op > 0 && op < 4);

    }


    public void MenuCatalogos()
    {


        int op = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                                SuperMarkBasic                        *");
            Console.WriteLine("*                                Menú Catalogos                        *");
            Console.WriteLine("************************************************************************");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Por favor, Selecciona Una Opcion");
            Console.WriteLine("1. Usuarios");
            Console.WriteLine("2. Clientes");
            Console.WriteLine("3. Productos");
            Console.WriteLine("4. Salir");
            op = int.Parse(Console.ReadLine());


            switch (op)
            {

                case 1:

                    MenuCatalogosUsuario();

                    break;
                case 2:
                    MenuCatalogosCliente();
                    break;
                case 3:
                    MenuCatalogosProducto();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Esta saliendo al menú principal");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Error, Introdusca una opcion Valida, presione una tecla para continuar");
                    Console.ReadKey();
                    MenuCatalogos();
                    break;


            }

        } while (op > 0 && op < 4);


    }


    public void MenuCatalogosUsuario()
    {



        int op = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                                SuperMarkBasic                        *");
            Console.WriteLine("*                            Menú Catalogos Usuario                    *");
            Console.WriteLine("************************************************************************");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Bienvenido Selecciona Una Opcion");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Actualizar");
            Console.WriteLine("3. Consultar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
            op = int.Parse(Console.ReadLine());


            switch (op)
            {

                case 1:

                    AgregarUsuario();

                    break;

                case 2:

                    actualizarUsuario();

                    break;

                case 3:
                    MostrarListaUsuarios();


                    break;

                case 4:

                    EliminarUsuario();

                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Esta saliendo al submenu");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();

                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Error, Introdusca una opcion Valida, presione una tecla para continuar");
                    Console.ReadKey();
                    MenuCatalogosUsuario();

                    break;
            }

        } while (op > 0 && op < 5);


    }


    public void MenuCatalogosCliente()
    {



        int op = 0;



        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                                SuperMarkBasic                        *");
            Console.WriteLine("*                            Menú Catalogos Cliente                    *");
            Console.WriteLine("************************************************************************");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Bienvenido Selecciona Una Opcion");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Actualizar");
            Console.WriteLine("3. Consultar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
            op = int.Parse(Console.ReadLine());


            switch (op)
            {

                case 1:

                    AgregarCliente();

                    break;

                case 2:

                    actualizarCliente();

                    break;

                case 3:
                    MostrarListaClientes();


                    break;

                case 4:

                    EliminarCliente();

                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Esta saliendo al submenu");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();

                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Error, Introdusca una opcion Valida, presione una tecla para continuar");
                    Console.ReadKey();
                    MenuCatalogosCliente();

                    break;
            }

        } while (op > 0 && op < 5);
    }


    public void MenuCatalogosProducto()
    {



        int op = 0;



        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                                SuperMarkBasic                        *");
            Console.WriteLine("*                            Menú Catalogos Producto                   *");
            Console.WriteLine("************************************************************************");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Bienvenido Selecciona Una Opcion");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Actualizar");
            Console.WriteLine("3. Consultar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
            op = int.Parse(Console.ReadLine());


            switch (op)
            {

                case 1:

                    AgregarProducto();

                    break;

                case 2:

                    ActualizarDatosProducto();

                    break;

                case 3:
                    MostrarListaProductos();


                    break;

                case 4:

                    EliminarProducto();

                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Esta saliendo al submenu");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();

                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Error, Introdusca una opcion Valida, presione una tecla para continuar");
                    Console.ReadKey();
                    MenuCatalogosProducto();

                    break;
            }

        } while (op > 0 && op < 5);
    }

    public void MenuInventarios()
    {


        int op = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                                SuperMarkBasic                        *");
            Console.WriteLine("*                               Menú Inventarios                       *");
            Console.WriteLine("************************************************************************");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Por favor, Selecciona Una Opcion");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Actualizar");
            Console.WriteLine("3. Consultar");
            Console.WriteLine("4. Salir");
            op = int.Parse(Console.ReadLine());


            switch (op)
            {

                case 1:

                    agregarInventarioProducto();

                    break;
                case 2:
                    ActualizarInventarioProducto();
                    break;
                case 3:
                    MostrarInventario();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Esta volviendo al menú principal, precione cualquier tecla para continuar:");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Error, Introdusca una opcion Valida, presione una tecla para continuar");
                    Console.ReadKey();
                    MenuInventarios();
                    break;

            }

        } while (op > 0 && op < 4);


    }


    public void MenuVentas()
    {


        int op = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                                SuperMarkBasic                        *");
            Console.WriteLine("*                                  Menú Ventas                         *");
            Console.WriteLine("************************************************************************");

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Por favor, Selecciona Una Opcion");
            Console.WriteLine("1. Realizar Venta");
            Console.WriteLine("2. Actualizar Venta");
            Console.WriteLine("3. Consultar Ventas");
            Console.WriteLine("4. Facturacion");
            Console.WriteLine("5. Salir");
            op = int.Parse(Console.ReadLine());


            switch (op)
            {

                case 1:

                    RealizarVenta();

                    break;

                case 2:

                    ActualizarVenta();
                    break;
                case 3:

                    ConsultaVentas();


                    break;
                case 4:


                    FacturarVenta();

                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Esta volviendo al menú principal, precione cualquier tecla para continuar:");

                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Error, Introdusca una opcion Valida, presione una tecla para continuar");
                    Console.ReadKey();
                    MenuInventarios();
                    break;

            }

        } while (op > 0 && op < 5);


    }





    public void AgregarProducto()
    {
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("*  Ingresó a la Opción de Agregar Productos   *");
        Console.WriteLine("***********************************************");
        Console.WriteLine();

        while (true)
        {


            Console.Write("Código del producto " + (contadorProductos + 1) + ": ");
            string codigo = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(codigo))
            {

                Console.WriteLine("---> Código inválido. Por favor ingrese un código válido.");
                codigo = Console.ReadLine().Trim();
            }

            // Verificamos si el código del producto ya existe
            bool codigoExiste = false;
            for (int i = 0; i < contadorProductos; i++)
            {
                if (codigosProducto[i] == codigo)
                {
                    Console.WriteLine();
                    codigoExiste = true;
                    Console.WriteLine("---> El código del producto ya existe. Por favor ingrese otro código.");
                    Console.WriteLine();
                    break;
                }
            }


            //Si el codigo no existe:
            if (!codigoExiste)
            {

                Console.Write("Descripción del producto: ");
                string descripcion = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(descripcion))
                {
                    Console.WriteLine();
                    Console.WriteLine("---> Descripción inválida. Por favor ingrese una descripción válida.");
                    descripcion = Console.ReadLine().Trim();
                }


                Console.Write("Cantidad del producto: ");
                string cantidadString = Console.ReadLine().Trim();
                int cantidad;
                while (!int.TryParse(cantidadString, out cantidad) || cantidad <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("---> Cantidad inválida. Por favor ingrese un número entero mayor a cero.");
                    cantidadString = Console.ReadLine().Trim();
                }


                Console.Write("Unidad de Medida del producto: ");
                string unMedida = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(unMedida))
                {
                    Console.WriteLine("---> Unidad de Medida Invalida, por favor ingrese una unidad valida");
                    unMedida = Console.ReadLine().Trim();
                }

                Console.Write("Precio unitario del producto: ");
                string precioString = Console.ReadLine().Trim();
                decimal precio;
                while (!decimal.TryParse(precioString, out precio) || precio <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("---> Precio inválido. Por favor ingrese un número mayor a cero.");
                    precioString = Console.ReadLine().Trim();
                }

                // Agregamos los datos del producto a los arrays
                codigosProducto[contadorProductos] = codigo;
                descripcionesProducto[contadorProductos] = descripcion;
                cantidadesProducto[contadorProductos] = cantidad;
                preciosProducto[contadorProductos] = precio;
                unidadesMedidasProductos[contadorProductos] = unMedida;

                contadorProductos++;

                Console.WriteLine();
                Console.WriteLine("El producto se agregó exitosamente.");

                Console.WriteLine("¿Desea agregar otro producto? (S/N): ");

                string respuesta = Console.ReadLine().Trim().ToLower();
                if (respuesta != "s" && respuesta != "si")
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }


    public void ActualizarDatosProducto()
    {

        Console.Clear();
        Console.WriteLine("*   Ingresó a la Opcion para Actualizar datos de producto   *");
        Console.WriteLine("*************************************************************");
        Console.WriteLine();
        Console.Write("Ingrese el código del producto a actualizar: ");
        string codigo = Console.ReadLine().Trim();

        // Verificamos si el código del producto existe
        bool codigoExiste = false;
        int indiceProducto = -1;
        for (int i = 0; i < contadorProductos; i++)
        {
            if (codigosProducto[i] == codigo)
            {
                codigoExiste = true;
                indiceProducto = i;
                break;
            }
        }

        //si el codigo existe:
        if (codigoExiste)
        {
            Console.WriteLine();
            Console.WriteLine("Datos del producto a actualizar:");
            Console.WriteLine("Código: " + codigosProducto[indiceProducto]);
            Console.WriteLine("Descripción: " + descripcionesProducto[indiceProducto]);
            Console.WriteLine("Cantidad: " + cantidadesProducto[indiceProducto]);
            Console.WriteLine("Unidad de Medida: " + unidadesMedidasProductos[indiceProducto]);
            Console.WriteLine("Precio unitario: " + preciosProducto[indiceProducto]);

            Console.WriteLine();
            Console.Write("Ingrese la nueva Descripción del producto: ");
            string descripcion = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(descripcion))
            {
                Console.WriteLine("Descripción inválida. Por favor ingrese una descripción válida.");
                descripcion = Console.ReadLine().Trim();
            }


            Console.Write("Ingrese la nueva cantidad: ");
            string cantidadString = Console.ReadLine().Trim();
            int cantidad;
            while (!int.TryParse(cantidadString, out cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida. Por favor ingrese un número entero mayor a cero.");
                cantidadString = Console.ReadLine().Trim();
            }

            Console.Write("Ingrese la nueva Unidad de Medida del producto: ");
            string unMedida = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(unMedida))
            {
                Console.WriteLine("Unidad de Medida inválida. Por favor ingrese una unidad válida.");
                unMedida = Console.ReadLine().Trim();
            }


            Console.Write("Ingrese el nuevo precio unitario: ");
            string precioString = Console.ReadLine().Trim();
            decimal precio;
            while (!decimal.TryParse(precioString, out precio) || precio <= 0)
            {
                Console.WriteLine("Precio inválido. Por favor ingrese un número mayor a cero.");
                precioString = Console.ReadLine().Trim();
            }

            // Actualizamos los datos del producto
            cantidadesProducto[indiceProducto] = cantidad;
            preciosProducto[indiceProducto] = precio;
            descripcionesProducto[indiceProducto] = descripcion;
            unidadesMedidasProductos[indiceProducto] = unMedida;

            Console.WriteLine();
            Console.WriteLine("Datos actualizados correctamente.");

            Console.Write("¿Desea actualizar otro producto? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToLower();
            if (respuesta == "s" || respuesta == "si")
            {
                ActualizarDatosProducto();
            }
        }
        else
        {
            Console.WriteLine("El código del producto no existe.");
            Console.ReadKey();
        }
    }

    public void MostrarListaProductos()
    {
        Console.Clear(); Console.Clear();
        Console.WriteLine("*  Ingresó a la opcion de Consulta de Productos  *");
        Console.WriteLine("**************************************************");
        Console.WriteLine();


        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Mostrar todos los productos");
        Console.WriteLine("2. Buscar producto por código");
        Console.Write("Opción: ");


        string opcion = Console.ReadLine();

        Console.WriteLine();
        if (opcion == "1")
        {
            //se muestran todos los productos
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                    Lista de  todos los productos:                                 |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Codigo Producto".PadRight(20) + "| Descrip. Producto".PadRight(20) + "| Cantidad".PadRight(20) + "| Unidad de Medida".PadRight(20) + "| Precio Unitario".PadRight(20) + "|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            for (int i = 0; i < contadorProductos; i++)
            {

                Console.WriteLine("| " + codigosProducto[i].PadRight(18) + "| " + descripcionesProducto[i].PadRight(18) + "| " + cantidadesProducto[i].ToString().PadLeft(18) + "| " + unidadesMedidasProductos[i].PadRight(18) + "| " + preciosProducto[i].ToString("C").PadLeft(18) + "|");


            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
        else if (opcion == "2")
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write("Ingrese el código del producto a buscar: ");
            string codigoABuscar = Console.ReadLine();
            Console.WriteLine();

            // Buscamos el producto en el array
            bool encontrado = false;
            for (int i = 0; i < contadorProductos; i++)
            {
                if (codigosProducto[i] == codigoABuscar)
                {
                    Console.WriteLine();
                    Console.WriteLine("Se ha encontrado el producto: ");
                    Console.WriteLine("  Código: " + codigosProducto[i]);
                    Console.WriteLine("  Descripción: " + descripcionesProducto[i]);
                    Console.WriteLine("  Cantidad: " + cantidadesProducto[i]);
                    Console.WriteLine("  Unidad de Medida: " + unidadesMedidasProductos[i]);
                    Console.WriteLine("  Precio unitario: " + preciosProducto[i]);
                    Console.WriteLine();
                    encontrado = true;
                    break;
                }
            }

            //si no se encontró el producto
            if (!encontrado)
            {
                Console.WriteLine();
                Console.WriteLine("No se encontró ningún producto con el código ingresado.");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Opción inválida.");
        }
        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }



    public void EliminarProducto()
    {

        Console.Clear();
        Console.WriteLine("*  Ingresó a la opcion de Eliminar Productos  *");
        Console.WriteLine("***********************************************");
        Console.WriteLine();
        Console.WriteLine("Ingresa el codigo del producto a eliminar:");
        string codigoProducto = Console.ReadLine();


        //buscamos el codigo del producto
        int index = -1;
        for (int i = 0; i < contadorProductos; i++)
        {
            if (codigosProducto[i] == codigoProducto)
            {
                index = i;
                break;
            }
        }


        // si el index es diferente a -1 es que si se encontro el producto
        if (index != -1)
        {
            Console.WriteLine();
            Console.WriteLine($"¿Está seguro de que desea eliminar el producto {descripcionesProducto[index]}? (S/N)");
            if (Console.ReadLine().ToUpper() == "S")
            {
                for (int i = index; i < contadorProductos - 1; i++)
                {
                    codigosProducto[i] = codigosProducto[i + 1];
                    descripcionesProducto[i] = descripcionesProducto[i + 1];
                    cantidadesProducto[i] = cantidadesProducto[i + 1];
                    preciosProducto[i] = preciosProducto[i + 1];
                }

                // Actualizamos el contador de productos y borrar el último elemento
                contadorProductos--;
                codigosProducto[contadorProductos] = null;
                descripcionesProducto[contadorProductos] = null;
                cantidadesProducto[contadorProductos] = 0;
                preciosProducto[contadorProductos] = 0;

                Console.WriteLine();
                Console.WriteLine("---> Producto eliminado correctamente");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("---> No se pudo eliminar, el producto no existe");
            Console.ReadKey();
        }
    }






    public void AgregarUsuario()
    {

        Console.Clear();
        Console.WriteLine("*  Ingresó a la opcion de agregar usuarios *");
        Console.WriteLine("********************************************");
        Console.WriteLine();
        Console.WriteLine("Ingrese los datos que se le solicitan a continuacion:");
        while (true)
        {

            Console.WriteLine();
            Console.Write("Id del usuario " + (contadorUsuarios + 1) + ": ");
            string idUser = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(idUser))
            {

                Console.WriteLine("-----> Id inválido. Por favor ingrese un código válido.");
                idUser = Console.ReadLine().Trim();
            }

            // Verificamos si el código del usuario ya existe
            bool idExiste = false;
            for (int i = 0; i < contadorUsuarios; i++)
            {
                if (idsUsuario[i] == idUser)
                {
                    Console.WriteLine();
                    idExiste = true;
                    Console.WriteLine("----> El código del usuario ya existe. Por favor ingrese otro código.");
                    break;
                }
            }

            if (!idExiste)
            {

                Console.Write("Nombre del Usuario: ");
                string nombreUsuario = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(nombreUsuario))
                {
                    Console.WriteLine("-----> Nombre del Usuario inválido. Por favor ingrese una Nombre válido.");
                    nombreUsuario = Console.ReadLine().Trim();
                }



                Console.Write("Contraseña del Usuario: ");
                string contrasenaUsuario = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(contrasenaUsuario))
                {
                    Console.WriteLine("-----> Contraseña del Usuario inválida. Por favor ingrese una contraseña válida.");
                    contrasenaUsuario = Console.ReadLine().Trim();
                }




                idsUsuario[contadorUsuarios] = idUser;
                nombresUsuarios[contadorUsuarios] = nombreUsuario;
                contrasenasUsuarios[contadorUsuarios] = contrasenaUsuario;


                contadorUsuarios++;
                Console.WriteLine();
                Console.WriteLine("El Usuario se se agregó exitosamente.");
                Console.WriteLine();

                Console.Write("---> ¿Desea agregar otro Usuario? (S/N): ");
                string respuesta = Console.ReadLine().Trim().ToLower();
                if (respuesta != "s" && respuesta != "si")
                {
                    break;
                }
            }
        }
    }


    public void actualizarUsuario()
    {


        Console.Clear();
        Console.WriteLine("*  Ingresó a la Opcion de Actualizar datos de usuario  *");
        Console.WriteLine("********************************************************");
        Console.WriteLine();
        Console.Write("Ingrese el ID del usuario a actualizar: ");
        string idUsuario = Console.ReadLine().Trim();

        bool idUsuarioExiste = false;
        int indiceUsuario = -1;
        for (int i = 0; i < contadorUsuarios; i++)
        {
            if (idsUsuario[i] == idUsuario)
            {
                idUsuarioExiste = true;
                indiceUsuario = i;
                break;
            }
        }

        if (idUsuarioExiste)
        {
            Console.WriteLine();
            Console.WriteLine("  Datos del usuario a actualizar:");
            Console.WriteLine();
            Console.WriteLine("     ID de usuario: " + idsUsuario[indiceUsuario]);
            Console.WriteLine("     Nombre de usuario: " + nombresUsuarios[indiceUsuario]);
            Console.WriteLine("     Contraseña: " + contrasenasUsuarios[indiceUsuario]);
            Console.WriteLine();

            Console.Write("Ingrese el nuevo nombre de usuario: ");
            string nombreUsuario = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(nombreUsuario))
            {
                Console.WriteLine();
                Console.WriteLine("---> Nombre de usuario inválido. Por favor ingrese un nombre de usuario válido.");
                nombreUsuario = Console.ReadLine().Trim();
            }


            Console.Write("Ingrese la nueva contraseña: ");
            string contraseña = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(contraseña))
            {
                Console.WriteLine();
                Console.WriteLine("---> Contraseña inválida. Por favor ingrese una contraseña válida.");
                contraseña = Console.ReadLine().Trim();
            }


            nombresUsuarios[indiceUsuario] = nombreUsuario;
            contrasenasUsuarios[indiceUsuario] = contraseña;

            Console.WriteLine();
            Console.WriteLine("Datos actualizados correctamente.");
            Console.WriteLine();
            Console.Write("---> ¿Desea actualizar otro usuario? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToLower();
            if (respuesta == "s" || respuesta == "si")
            {
                actualizarUsuario();
            }
        }
        else
        {
            Console.WriteLine("El ID de usuario no existe.");
            Console.ReadKey();
        }


    }


    public void MostrarListaUsuarios()
    {
        Console.Clear();

        Console.WriteLine("*  Ingresó a la opcion de Consulta de Usuarios  *");
        Console.WriteLine("*************************************************");
        Console.WriteLine();
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Mostrar todos los usuarios");
        Console.WriteLine("2. Buscar usuario por id");
        Console.Write("   Opción: ");


        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.Clear();
            Console.WriteLine("*                     Lista de Todos Los Usuarios                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine();

            //se muestran todos los usuarios

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("| Id Usuario".PadRight(20) + "| Nombre Usuario".PadRight(25) + "| Contraseña Usuario".PadRight(25) + "|");
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = 0; i < contadorUsuarios; i++)
            {

                Console.WriteLine("| " + idsUsuario[i].PadRight(18) + "| " + nombresUsuarios[i].PadRight(23) + "| " + contrasenasUsuarios[i].ToString().PadRight(23) + "| ");


            }
            Console.WriteLine("----------------------------------------------------------------------");


        }
        else if (opcion == "2")
        {
            //se busca el codigo ingresado y solo se muestra ese usuario
            Console.Clear();
            Console.Write("Ingrese el ID del usuario a consultar: ");
            string idABuscar = Console.ReadLine();

            Console.WriteLine();
            bool encontrado = false;
            for (int i = 0; i < contadorUsuarios; i++)
            {
                if (idsUsuario[i] == idABuscar)
                {
                    Console.WriteLine("Se encontró el usuario: ");
                    Console.WriteLine();
                    Console.WriteLine("   ID: " + idsUsuario[i]);
                    Console.WriteLine("   Nombre de usuario: " + nombresUsuarios[i]);
                    Console.WriteLine("   Contraseña: " + contrasenasUsuarios[i]);
                    Console.WriteLine();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún usuario con el ID ingresado.");
            }
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }

        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }


    public void EliminarUsuario()
    {
        Console.Clear();
        Console.WriteLine("*  Ingresó a la Opcion de Eliminar usuarios  *");
        Console.WriteLine("**********************************************");
        Console.WriteLine();
        Console.WriteLine("Ingresa el id del usuario a eliminar:");
        string idUsuario = Console.ReadLine();

        int index = -1;
        for (int i = 0; i < contadorUsuarios; i++)
        {
            if (idsUsuario[i] == idUsuario)
            {
                index = i;
                break;
            }
        }

        //si index <> -1 es que si se encontró el codigo del usuario que se quiere eliminar
        if (index != -1)
        {
            Console.WriteLine();
            Console.WriteLine($"¿Está seguro de que desea eliminar el usuario {nombresUsuarios[index]}? (S/N)");
            if (Console.ReadLine().ToUpper() == "S")
            {
                for (int i = index; i < contadorUsuarios - 1; i++)
                {
                    idsUsuario[i] = idsUsuario[i + 1];
                    nombresUsuarios[i] = nombresUsuarios[i + 1];
                    contrasenasUsuarios[i] = contrasenasUsuarios[i + 1];
                }

                // Actualizamos el contador de usuarios y borrar el último elemento
                contadorUsuarios--;
                idsUsuario[contadorUsuarios] = null;
                nombresUsuarios[contadorUsuarios] = null;
                contrasenasUsuarios[contadorUsuarios] = null;

                Console.WriteLine();
                Console.WriteLine("---> Usuario eliminado correctamente");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("---> No se pudo eliminar, el usuario no existe");
            Console.ReadKey();
        }
    }






    public void AgregarCliente()
    {

        Console.Clear();
        Console.WriteLine("*  Ingresó a la opcion de agregar Clientes *");
        Console.WriteLine("********************************************");
        Console.WriteLine();
        Console.WriteLine("Ingrese los datos que se solicitan a continuacion:");

        while (true)
        {

            Console.WriteLine();
            Console.Write("Código del Cliente " + (contadorClientes + 1) + ": ");
            string codigoCliente = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(codigoCliente))
            {
                Console.WriteLine();
                Console.WriteLine("---> Código inválido. Por favor ingrese un código válido.");
                codigoCliente = Console.ReadLine().Trim();
            }

            // Verificamos si el código del cliente ya existe
            bool codigoExiste = false;
            for (int i = 0; i < contadorClientes; i++)
            {
                if (codigosClientes[i] == codigoCliente)
                {
                    Console.WriteLine();
                    codigoExiste = true;
                    Console.WriteLine("---> El código del cliente ya existe. Por favor ingrese otro código.");
                    break;
                }
            }

            if (!codigoExiste)
            {

                Console.Write("Nombre del Cliente: ");
                string nombreCliente = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(nombreCliente))
                {
                    Console.WriteLine("---> Nombre del Cliente inválido. Por favor ingrese una Nombre válido.");
                    nombreCliente = Console.ReadLine().Trim();
                }



                Console.Write("Nit del Cliente: ");
                string nitCliente = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(nitCliente))
                {
                    Console.WriteLine("---> Nit del Cliente,  inválido. Por favor ingrese un nit válido.");
                    nitCliente = Console.ReadLine().Trim();
                }



                Console.Write("Direccion del Cliente: ");
                string direccionCliente = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(direccionCliente))
                {
                    Console.WriteLine("---> Direccion del Cliente,  inválida. Por favor ingrese una direccion válida.");
                    direccionCliente = Console.ReadLine().Trim();
                }


                // Agregar los datos del cliente a los arrays
                codigosClientes[contadorClientes] = codigoCliente;
                nombresCLientes[contadorClientes] = nombreCliente;
                nitsClientes[contadorClientes] = nitCliente;
                direccionClientes[contadorClientes] = direccionCliente;


                contadorClientes++;
                Console.WriteLine();
                Console.WriteLine("El Cliente se agregó exitosamente.");

                Console.WriteLine();
                Console.Write("¿Desea agregar otro Cliente? (S/N): ");
                string respuesta = Console.ReadLine().Trim().ToLower();
                if (respuesta != "s" && respuesta != "si")
                {
                    break;
                }
            }
        }
    }


    public void actualizarCliente()
    {


        Console.Clear();
        Console.WriteLine("*  Ingresó a la Opcion de Actualizar datos de Cliente  *");
        Console.WriteLine("********************************************************");
        Console.WriteLine();
        Console.Write("Ingrese el codigo del Cliente a actualizar: ");
        string codigoCliente = Console.ReadLine().Trim();

        bool ClienteExiste = false;
        int indiceCliente = -1;
        for (int i = 0; i < contadorClientes; i++)
        {
            if (codigosClientes[i] == codigoCliente)
            {
                ClienteExiste = true;
                indiceCliente = i;
                break;
            }
        }

        if (ClienteExiste)
        {
            Console.WriteLine();
            Console.WriteLine("Datos del Cliente a actualizar:");
            Console.WriteLine();
            Console.WriteLine("Codigo de Cliente: " + codigosClientes[indiceCliente]);
            Console.WriteLine("Nombre de Cliente: " + nombresCLientes[indiceCliente]);
            Console.WriteLine("Nit del Cliente: " + nitsClientes[indiceCliente]);
            Console.WriteLine("Direccion del Cliente: " + direccionClientes[indiceCliente]);
            Console.WriteLine();

            Console.Write("Ingrese el nuevo nombre de Cliente: ");
            string nombreCliente = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(nombreCliente))
            {
                Console.WriteLine();
                Console.WriteLine("---> Nombre de Cliente inválido. Por favor ingrese un nombre de Cliente válido.");
                nombreCliente = Console.ReadLine().Trim();
            }


            Console.Write("Ingrese el nuevo nit del Cliente: ");
            string nitCliente = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(nitCliente))
            {
                Console.WriteLine("---> Nit inválido. Por favor ingrese un nit valido.");
                nitCliente = Console.ReadLine().Trim();
            }


            Console.Write("Ingrese la nueva dirección del Cliente: ");
            string direccionCliente = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(direccionCliente))
            {
                Console.WriteLine("---> Dirección Invalida. Por favor ingrese una dirección valida.");
                direccionCliente = Console.ReadLine().Trim();
            }

            // Actualizamos los datos del Cliente
            nombresCLientes[indiceCliente] = nombreCliente;
            nitsClientes[indiceCliente] = nitCliente;
            direccionClientes[indiceCliente] = direccionCliente;

            Console.WriteLine();
            Console.WriteLine("Datos actualizados correctamente.");

            Console.Write("---> ¿Desea actualizar otro cliente? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToLower();
            if (respuesta == "s" || respuesta == "si")
            {
                actualizarCliente();
            }
        }
        else
        {
            Console.WriteLine("El codigo de cliente no existe.");
        }


    }


    public void MostrarListaClientes()
    {
        Console.Clear();

        Console.WriteLine("*  Ingresó a la opcion de Consulta de Clientes  *");
        Console.WriteLine("*************************************************");
        Console.WriteLine();
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Mostrar todos los Clientes");
        Console.WriteLine("2. Buscar Cliente por codigo");
        Console.Write("   Opción: ");


        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                 Lista de todos los Clientes:                                       ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Codigo Cliente".PadRight(17) + "| Nombre Cliente".PadRight(36) + "| Nit Cliente".PadRight(16) + "| Direccion de Cliente".PadRight(30) + "|");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            for (int i = 0; i < contadorClientes; i++)
            {

                Console.WriteLine("| " + codigosClientes[i].PadRight(15) + "| " + nombresCLientes[i].PadRight(34) + "| " + nitsClientes[i].PadRight(14) + "| " + direccionClientes[i].PadRight(28) + "|");


            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

        }
        else if (opcion == "2")
        {
            Console.Clear();
            Console.Write("Ingrese el codigo del Cliente a consultar: ");
            string codABuscar = Console.ReadLine();

            Console.WriteLine();
            bool encontrado = false;
            for (int i = 0; i < contadorClientes; i++)
            {
                if (codigosClientes[i] == codABuscar)
                {
                    Console.WriteLine("Se encontró el Cliente: ");
                    Console.WriteLine();
                    Console.WriteLine("   Codigo: " + codigosClientes[i]);
                    Console.WriteLine("   Nombre de Cliente: " + nombresCLientes[i]);
                    Console.WriteLine("   Nit de Cliente: " + nitsClientes[i]);
                    Console.WriteLine("   Dirección de Cliente: " + direccionClientes[i]);
                    Console.WriteLine();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine();
                Console.WriteLine("---> No se encontró ningún codigo de Cliente con el codigo ingresado.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Opción inválida.");
            Console.ReadKey();
        }
        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }



    public void EliminarCliente()
    {
        Console.Clear();
        Console.WriteLine("*  Ingresó a la Opcion de Eliminar Clientes  *");
        Console.WriteLine("**********************************************");
        Console.WriteLine();
        Console.WriteLine("Ingresa el codigo del Cliente a eliminar:");
        string codigoCliente = Console.ReadLine();

        int index = -1;
        for (int i = 0; i < contadorClientes; i++)
        {
            if (codigosClientes[i] == codigoCliente)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine();
            Console.WriteLine($"¿Está seguro de que desea eliminar el Cliente {nombresCLientes[index]}? (S/N)");
            if (Console.ReadLine().ToUpper() == "S")
            {
                for (int i = index; i < contadorClientes - 1; i++)
                {
                    codigosClientes[i] = codigosClientes[i + 1];
                    nombresCLientes[i] = nombresCLientes[i + 1];
                    nitsClientes[i] = nitsClientes[i + 1];
                    direccionClientes[i] = direccionClientes[i + 1];
                }

                // Actualizamos el contador de Clientes y borrar el último elemento
                contadorClientes--;
                codigosClientes[contadorClientes] = null;
                nombresCLientes[contadorClientes] = null;
                nitsClientes[contadorClientes] = null;
                direccionClientes[contadorClientes] = null;

                Console.WriteLine();
                Console.WriteLine("---> Cliente eliminado correctamente");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("---> No se pudo eliminar, el cliente no existe");
            Console.ReadKey();
        }
    }

    public void agregarInventarioProducto()
    {

        Console.Clear();
        Console.WriteLine("*  Ingresó a la opción de sumar o restar inventario  *");
        Console.WriteLine("******************************************************");
        Console.WriteLine();
        Console.Write("Ingrese el código del producto al cual le sumará o restará producto: ");
        string codigo = Console.ReadLine().Trim();

        // Verificamos si el código del producto existe
        bool codigoExiste = false;
        int indiceProducto = -1;
        for (int i = 0; i < contadorProductos; i++)
        {
            if (codigosProducto[i] == codigo)
            {
                codigoExiste = true;
                indiceProducto = i;
                break;
            }
        }

        if (codigoExiste)
        {
            Console.WriteLine();
            Console.WriteLine("Producto Encontrado:");
            Console.WriteLine("   Código: " + codigosProducto[indiceProducto]);
            Console.WriteLine("   Descripción: " + descripcionesProducto[indiceProducto]);
            Console.WriteLine("   Cantidad: " + cantidadesProducto[indiceProducto]);
            Console.WriteLine("   Precio unitario: " + preciosProducto[indiceProducto]);
            Console.WriteLine("   Precio Total del producto: " + (cantidadesProducto[indiceProducto] * preciosProducto[indiceProducto]));


            int op = 0;



            do
            {
                Console.WriteLine();
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("   1. Sumar inventario: ");
                Console.WriteLine("   2. Restar inventario: ");
                Console.Write("---> ");

                op = int.Parse(Console.ReadLine());

                if (op != 1 && op != 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("---> Error: La opción ingresada no es válida.");
                }

            } while (op != 1 && op != 2);

            if (op == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad que sumará al la existencia del producto actual: ");
                int cant = int.Parse(Console.ReadLine());

                cantidadesProducto[indiceProducto] = cantidadesProducto[indiceProducto] + cant;

                Console.WriteLine();
                Console.WriteLine("Cantidad sumada exitosamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad que restará a la existencia del producto actual: ");
                int cant = int.Parse(Console.ReadLine());

                if (cant > cantidadesProducto[indiceProducto])
                {
                    Console.WriteLine("---> No puede restar una cantidad mayor a la que se cuenta de inventario del producto actual");
                }
                else
                {
                    cantidadesProducto[indiceProducto] = cantidadesProducto[indiceProducto] - cant;
                    Console.WriteLine();
                    Console.WriteLine("Cantidad restada exitosamente");
                    Console.ReadKey();
                }
            }


            Console.WriteLine();

            Console.Write("¿Desea realizar otra operación? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToLower();
            if (respuesta == "s" || respuesta == "si")
            {
                agregarInventarioProducto();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("El código del producto no existe.");
            Console.ReadKey();
        }
    }


    public void ActualizarInventarioProducto()
    {

        Console.Clear();
        Console.WriteLine("*  Ingresó a la Opción para actualizar inventario de producto  *");
        Console.WriteLine("****************************************************************");
        Console.WriteLine();
        Console.Write("Ingrese el código del producto a actualizar: ");
        Console.WriteLine();
        string codigo = Console.ReadLine().Trim();

        // Verificamos si el código del producto existe
        bool codigoExiste = false;
        int indiceProducto = -1;
        for (int i = 0; i < contadorProductos; i++)
        {
            if (codigosProducto[i] == codigo)
            {
                codigoExiste = true;
                indiceProducto = i;
                break;
            }
        }

        if (codigoExiste)
        {
            Console.WriteLine();
            Console.WriteLine("Datos del producto encontrado:");
            Console.WriteLine("   Código: " + codigosProducto[indiceProducto]);
            Console.WriteLine("   Descripción: " + descripcionesProducto[indiceProducto]);
            Console.WriteLine("   Cantidad: " + cantidadesProducto[indiceProducto]);
            Console.WriteLine("   Unidad de Medida: " + unidadesMedidasProductos[indiceProducto]);
            Console.WriteLine("   Precio unitario: " + preciosProducto[indiceProducto]);


            Console.Write("Ingrese la nueva cantidad: ");
            string cantidadString = Console.ReadLine().Trim();
            int cantidad;
            while (!int.TryParse(cantidadString, out cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida. Por favor ingrese un número entero mayor a cero.");
                cantidadString = Console.ReadLine().Trim();
            }



            // Actualizar la cantidad del producto
            cantidadesProducto[indiceProducto] = cantidad;

            Console.WriteLine();
            Console.WriteLine("Cantidad de producto actualizada correctamente.");

            Console.WriteLine();
            Console.Write("¿Desea actualizar la cantidad de otro producto? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToLower();
            if (respuesta == "s" || respuesta == "si")
            {
                ActualizarInventarioProducto();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("El código del producto no existe.");
            Console.ReadKey();
        }
    }


    public void MostrarInventario()
    {
        Console.Clear(); Console.Clear();
        Console.WriteLine("*  Ingresó a la opcion de Consulta de Inventario  *");
        Console.WriteLine("***************************************************");
        Console.WriteLine();


        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Mostrar todos los productos del inventario");
        Console.WriteLine("2. Buscar producto por código");
        Console.Write("Opción: ");


        string opcion = Console.ReadLine();

        Console.WriteLine();
        if (opcion == "1")
        {
            //mostramos todos los productos
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                              Lista de  todos los productos:                                          |"); Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Codigo Producto".PadRight(20) + "| Descrip. Producto".PadRight(20) + "| Cantidad".PadRight(20) + "| Unidad de Medida".PadRight(20) + "| Precio Unitario".PadRight(20) + "| Total ".PadRight(18) + "|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < contadorProductos; i++)
            {
                Console.WriteLine("| " + codigosProducto[i].PadRight(18) + "| " + descripcionesProducto[i].PadRight(18) + "| " + cantidadesProducto[i].ToString().PadLeft(18) + "| " + unidadesMedidasProductos[i].PadRight(18) + "| " + preciosProducto[i].ToString("C").PadLeft(18) + "|" + (cantidadesProducto[i] * preciosProducto[i]).ToString("C").PadLeft(16) + " |");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
        else if (opcion == "2")
        {
            // Pedimos el código del producto a buscar
            Console.Write("Ingrese el código del producto: ");
            string codigoABuscar = Console.ReadLine();
            Console.WriteLine();

            // Buscamos solo el producto
            bool encontrado = false;
            for (int i = 0; i < contadorProductos; i++)
            {
                if (codigosProducto[i] == codigoABuscar)
                {
                    Console.WriteLine();
                    Console.WriteLine("Se ha encontrado el producto: ");
                    Console.WriteLine("  Código: " + codigosProducto[i]);
                    Console.WriteLine("  Descripción: " + descripcionesProducto[i]);
                    Console.WriteLine("  Cantidad: " + cantidadesProducto[i]);
                    Console.WriteLine("  Unidad de Medida: " + unidadesMedidasProductos[i]);
                    Console.WriteLine("  Precio unitario: " + preciosProducto[i]);
                    Console.WriteLine("  Precio Total Por Producto: " + (cantidadesProducto[i] * preciosProducto[i]));
                    Console.WriteLine();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine();
                Console.WriteLine("No se encontró ningún producto con el código ingresado.");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Opción inválida.");
        }

        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }


    public void RealizarVenta()
    {
        bool realizarVenta = true;
        Console.Clear();


        while (realizarVenta)
        {
            Console.Clear();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                              Nuevas Ventas                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ingrese el código de cliente:");
            string codigoCliente = Console.ReadLine();

            int indiceCliente = Array.IndexOf(codigosClientes, codigoCliente);
            if (indiceCliente == -1)
            {
                Console.WriteLine();
                Console.WriteLine("---> El código de cliente no existe. Intente nuevamente.");
                Console.ReadKey();
                continue;
            }

            int idVenta = contadorVentas + 1;
            idVentas[contadorVentas] = idVenta;
            codigosClientesVenta[contadorVentas] = codigoCliente;
            Cod_serieVentas[contadorVentas] = "";

            bool agregarProducto = true;
            int contadorProductosVentaActual = 0; // contador para rastrear la cantidad de productos en la venta actual

            while (agregarProducto)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese el código del producto:");
                Console.Write("---> ");
                string codigoProducto = Console.ReadLine();

                int indiceProducto = Array.IndexOf(codigosProducto, codigoProducto);
                if (indiceProducto == -1)
                {
                    Console.WriteLine("---> El producto no existe, intente nuevamente");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Ingrese la cantidad a facturar:");
                Console.Write("---> ");
                int cantidad = int.Parse(Console.ReadLine());

                if (cantidad > cantidadesProducto[indiceProducto])
                {
                    Console.WriteLine();
                    Console.WriteLine("---> No hay suficiente cantidad disponible, intente nuevamente");
                    Console.ReadKey();
                    continue;
                }



                productosVenta[contadorVentas, contadorProductosVentaActual] = codigoProducto;
                cantidadesVenta[contadorVentas, contadorProductosVentaActual] = cantidad;


                contadorProductosVentaActual++; // Actualizamos antes de incrementar contadorProductosVenta[contadorVentas]

                contadorProductosVenta[contadorVentas]++; // Incrementamos la cantidad de productos en la venta actual

                cantidadesProducto[indiceProducto] -= cantidad;

                Console.WriteLine();
                Console.WriteLine("¿Desea agregar otro producto? (S/N)");
                string respuesta = Console.ReadLine();
                agregarProducto = (respuesta.ToLower() == "s");
            }

            contadorVentas++;
            Console.WriteLine();
            Console.WriteLine("¿Desea realizar otra venta? (S/N)");
            string respuestaVenta = Console.ReadLine();
            realizarVenta = (respuestaVenta.ToLower() == "s");
        }
        Console.WriteLine();
        Console.WriteLine("Las ventas se han registrado correctamente.");
        Console.ReadKey();
    }


    public void ConsultaVentas()
    {
        int op = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("*  Ingresó a la opcion de Consulta de Ventas  *");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Mostrar todas las Ventas");
            Console.WriteLine("2. Mostrar Venta por numero de ID");
            Console.Write("---> ");

            op = int.Parse(Console.ReadLine());

            if (op != 1 && op != 2)
            {
                Console.WriteLine();
                Console.WriteLine("---> Error: La opción ingresada no es válida.");
                Console.ReadKey();
            }

        } while (op != 1 && op != 2);

        if (op == 1)
        {

            MostrarVentas();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Ingresa el Id de la venta");
            int idventa = int.Parse(Console.ReadLine());

            ConsultarProductosVenta(idventa);
        }
    }


    public void ConsultarProductosVenta(int idVenta)
    {
        int indiceVenta = Array.IndexOf(idVentas, idVenta);
        if (indiceVenta == -1)
        {
            Console.WriteLine();
            Console.WriteLine("ID de venta inválido.");
            Console.ReadKey();
            return;
        }

        string codigoCliente = codigosClientesVenta[indiceVenta];
        string serieVenta = Cod_serieVentas[indiceVenta];
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                           Resultados de la Venta Buscada                                         ");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                                    Venta Id.{0}                                 Serie: {1}       ", idVenta, serieVenta);
        Console.WriteLine("                                             Codigo del Cliente: {0}                                               ", codigoCliente);
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| No. Producto".PadRight(20) + "| Codigo. Producto".PadRight(20) + "| Descripcion Producto".PadRight(25) + "| Cantidad".PadRight(16) + "| P.Unitario".PadRight(16) + "| Total".PadRight(20) + "|");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

        for (int i = 0; i < contadorProductosVenta[indiceVenta]; i++)
        {

            string codigoProducto = productosVenta[indiceVenta, i];

            int ind = Array.IndexOf(codigosProducto, codigoProducto);

            string descripProd = descripcionesProducto[ind];
            int cantidad = cantidadesVenta[indiceVenta, i];
            decimal precioUnitario = preciosProducto[ind];
            decimal totalPorProducto = precioUnitario * cantidad;

            Console.WriteLine("| " + (i + 1).ToString().PadLeft(18) + "| " + codigoProducto.PadRight(18) + "| " + descripProd.PadRight(23) + "| " + cantidad.ToString().PadLeft(14) + "| " + precioUnitario.ToString("C").PadLeft(14) + "| " + totalPorProducto.ToString("C").PadLeft(18) + "|");
        }
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

        Console.ReadKey();
    }


    public void MostrarVentas()
    {
        if (contadorVentas == 0)
        {
            Console.WriteLine();
            Console.WriteLine("No hay ventas registradas.");
            Console.ReadKey();
            return;
        }
        decimal totalVenta = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                                Ventas Registradas                                                ");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.ResetColor();
        for (int i = 0; i < contadorVentas; i++)
        {
            int idVenta = idVentas[i];
            string codigoCliente = codigosClientesVenta[i];
            string serieVentas = Cod_serieVentas[i];

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                    Venta Id.{0}                                     Serie: {1}   ", idVenta, serieVentas);
            Console.WriteLine("                                             Codigo del Cliente: {0}                                               ", codigoCliente);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| No. Producto".PadRight(20) + "| Codigo. Producto".PadRight(20) + "| Descripcion Producto".PadRight(25) + "| Cantidad".PadRight(16) + "| P.Unitario".PadRight(16) + "| Total".PadRight(20) + "|");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");




            for (int j = 0; j < contadorProductosVenta[i]; j++)
            {


                string codigoProducto = productosVenta[i, j];

                int ind = Array.IndexOf(codigosProducto, codigoProducto);

                string descripProd = descripcionesProducto[ind];

                int cantidad = cantidadesVenta[i, j];

                decimal precioUnitario = preciosProducto[ind];
                decimal totalPorProducto = precioUnitario * cantidad;



                totalVenta = totalVenta + totalPorProducto;

                Console.WriteLine("| " + (j + 1).ToString().PadLeft(18) + "| " + codigoProducto.PadRight(18) + "| " + descripProd.PadRight(23) + "| " + cantidad.ToString().PadLeft(14) + "| " + precioUnitario.ToString("C").PadLeft(14) + "| " + totalPorProducto.ToString("C").PadLeft(18) + "|");

            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }

        Console.ReadKey();
    }


    public void ActualizarVenta()
    {

        Console.Clear();
        Console.WriteLine("*  Ingresó a la opcion de Actualización de Ventas  *");
        Console.WriteLine("***************************************************");
        Console.WriteLine();
        Console.WriteLine("Ingresa el id de la venta que necesita Actualizar:");
        Console.Write("---> ");
        int idventa = int.Parse(Console.ReadLine());


        int indiceVenta = Array.IndexOf(idVentas, idventa);
        if (indiceVenta == -1)
        {
            Console.WriteLine();
            Console.WriteLine("---> El Id de venta ingresado, aun no esta registrado.");
            Console.ReadKey();
            return;
        }


        string serieVenta = Cod_serieVentas[indiceVenta];

        if (serieVenta == "")
        {
            Console.WriteLine();
            Console.WriteLine("Productos de la venta Id.{0}:", idventa);
            Console.WriteLine("----------------------------------------------------");

            int ind; ;
            for (int i = 0; i < contadorProductosVenta[indiceVenta]; i++)
            {
                ind = Array.IndexOf(codigosProducto, productosVenta[indiceVenta, i]);

                Console.WriteLine("{0}.  {1}, {2}, Cantidad: {3}",
                    i + 1,
                    productosVenta[indiceVenta, i],
                    descripcionesProducto[ind],
                    cantidadesVenta[indiceVenta, i]);
            }

            Console.WriteLine();
            Console.WriteLine("  Seleccione una opción:");
            Console.WriteLine("  1. Agregar Productos a Venta");
            Console.WriteLine("  2. Quitar productos de venta");
            Console.WriteLine();
            Console.Write("---> ");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                AgregarProductoAVenta(idventa);
            }
            else if (op == 2)
            {
                EliminarProductoDeVenta(idventa);
            }
            else
            {
                Console.WriteLine("Opcion Invalida, regresará al menú anterior");
                Console.ReadLine();
            }


            Console.WriteLine();

        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("  La venta ya ha sido facturada, ya no es posible modificar esta venta");
            Console.WriteLine();

            Console.WriteLine("---> Presione cualquier tecla para regresar al menú");
            Console.ReadKey();


        }


    }



    public void AgregarProductoAVenta(int numeroVenta)
    {



        if (numeroVenta >= 1 && numeroVenta <= contadorVentas)
        {
            int indiceVenta = numeroVenta - 1;
            bool agregarProducto = true;

            while (agregarProducto)
            {


                Console.WriteLine();
                Console.WriteLine("Ingrese el código del producto a agregar:");
                string codigoProducto = Console.ReadLine();


                int indiceProducto = Array.IndexOf(codigosProducto, codigoProducto);
                if (indiceProducto == -1)
                {
                    Console.WriteLine();
                    Console.WriteLine("---> El producto no existe, intente nuevamente");
                    Console.WriteLine();
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Ingrese la cantidad del producto a agregar:");
                int cantidadProducto = int.Parse(Console.ReadLine());

                int indiceProductoInventario = Array.IndexOf(codigosProducto, codigoProducto);

                // Verificamos si el código del producto es válido
                if (indiceProductoInventario != -1)
                {
                    cantidadesProducto[indiceProductoInventario] -= cantidadProducto;

                    productosVenta[indiceVenta, contadorProductosVenta[indiceVenta]] = codigoProducto;
                    cantidadesVenta[indiceVenta, contadorProductosVenta[indiceVenta]] = cantidadProducto;
                    contadorProductosVenta[indiceVenta]++;

                    Console.WriteLine("El producto ha sido agregado a la venta exitosamente.");
                    Console.WriteLine();

                    Console.WriteLine("¿Desea agregar otro producto a la venta? (S/N)");
                    string respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() != "S")
                    {
                        agregarProducto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Código de producto inválido.");
                }
            }
        }
        else
        {
            Console.WriteLine("Número de venta inválido.");
        }
    }



    public void EliminarProductoDeVenta(int numeroVenta)
    {


        // Verificamos si el número de venta es válido
        if (numeroVenta >= 1 && numeroVenta <= contadorVentas)
        {
            int indiceVenta = numeroVenta - 1;

            bool eliminarProducto = true;

            while (eliminarProducto)
            {

                Console.WriteLine();
                Console.WriteLine("Ingrese el número de producto a eliminar:");
                int numeroProducto = Convert.ToInt32(Console.ReadLine());

                if (numeroProducto >= 1 && numeroProducto <= contadorProductosVenta[indiceVenta])
                {
                    int indiceProducto = numeroProducto - 1;

                    string codigoProducto = productosVenta[indiceVenta, indiceProducto];
                    int cantidadProducto = cantidadesVenta[indiceVenta, indiceProducto];

                    int indiceProductoInventario = Array.IndexOf(codigosProducto, codigoProducto);
                    cantidadesProducto[indiceProductoInventario] += cantidadProducto;

                    for (int i = indiceProducto; i < contadorProductosVenta[indiceVenta] - 1; i++)
                    {
                        productosVenta[indiceVenta, i] = productosVenta[indiceVenta, i + 1];
                        cantidadesVenta[indiceVenta, i] = cantidadesVenta[indiceVenta, i + 1];

                    }

                    contadorProductosVenta[indiceVenta]--;
                    productosVenta[indiceVenta, contadorProductosVenta[indiceVenta]] = null;
                    cantidadesVenta[indiceVenta, contadorProductosVenta[indiceVenta]] = 0;

                    Console.WriteLine();
                    Console.WriteLine("El producto ha sido eliminado de la venta exitosamente.");

                    Console.WriteLine();
                    Console.WriteLine("¿Desea eliminar otro producto de la venta? (S/N)");
                    string respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() != "S")
                    {
                        eliminarProducto = false;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Ide de producto inválido.");
                    Console.ReadKey();
                }
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Id de venta inválido.");
            Console.ReadKey();
        }

    }

    public void FacturarVenta()
    {

        Console.Clear();
        Console.WriteLine("*  Ingresó a la opcion de Facturacion de Ventas  *");
        Console.WriteLine("***************************************************");
        Console.WriteLine();
        Console.WriteLine("Ingresa el id de la venta que necesita facturar:");
        Console.Write("---> ");
        int idventa = int.Parse(Console.ReadLine());


        int indiceVenta = Array.IndexOf(idVentas, idventa);
        if (indiceVenta == -1)
        {
            Console.WriteLine();
            Console.WriteLine("--->ID de venta inválido.");
            return;
        }


        string serieVenta = Cod_serieVentas[indiceVenta];



        if (serieVenta == "")
        {
            Console.WriteLine();
            Console.WriteLine("La venta aun no ha sido facturada, ingrese el numero de serie: ");
            Cod_serieVentas[indiceVenta] = Console.ReadLine();


            while (string.IsNullOrEmpty(Cod_serieVentas[indiceVenta]))
            {

                Console.WriteLine("---> Código de Serie Invalido. Por favor ingrese un Código válido.");
                Cod_serieVentas[indiceVenta] = Console.ReadLine();
            }


            Console.WriteLine();
            Console.WriteLine("   Venta Facturada Exitosamente, precione cualquier tecla para ver la factura: ");
            Console.ReadKey();
            Factura(idventa);


        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("  La venta ya ha sido facturada,el numero de serie es: " + serieVenta);
            Console.WriteLine();
            Console.WriteLine("¿Desea imprimir la factura nuevamente (S/N)?");
            string resp = Console.ReadLine();

            if (resp.ToLower() == "s")
            {
                Factura(idventa);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("---> Presione cualquier tecla para regresar al menú");
            }


        }

        Console.ReadKey();
    }

    public void Factura(int idVenta)
    {
        int indiceVenta = Array.IndexOf(idVentas, idVenta);



        string codigoCliente = codigosClientesVenta[indiceVenta];

        int indiceCliente = Array.IndexOf(codigosClientes, codigoCliente);

        string nombre = nombresCLientes[indiceCliente];
        string nit = nitsClientes[indiceCliente];
        string direccion = direccionClientes[indiceCliente];


        string serieVenta = Cod_serieVentas[indiceVenta];

        decimal totalFac = 0, iva = 0, totalFactura = 0;

        string fecha = DateTime.Now.ToString("dd-MM-yyyy");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine("|" + "Factura SuperMarkBasic ".PadLeft(53) + "Serie: ".PadLeft(15) + (serieVenta + "-" + idVenta).PadRight(12) + "|");
        Console.WriteLine("|" + "Venta Id.".PadLeft(45) + idVenta.ToString().PadRight(35) + "|");
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine("|                                                                                |");
        Console.WriteLine("|" + "Fecha: ".PadLeft(68) + fecha.PadRight(11) + " |");
        Console.WriteLine("| Nombre:".PadRight(15) + nombre.PadRight(65) + " |");
        Console.WriteLine("| Nit:".PadRight(15) + nit.PadRight(65) + " |");
        Console.WriteLine("| Dirección:".PadRight(15) + direccion.PadRight(65) + " |");
        Console.WriteLine("|                                                                                |");
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine("| Cantidad".PadRight(15) + "| Descripcion".PadRight(25) + "| Prec.Unit.".PadRight(20) + "| Total".PadRight(20) + " | ");
        Console.WriteLine("----------------------------------------------------------------------------------");

        for (int i = 0; i < contadorProductosVenta[indiceVenta]; i++)
        {

            string codigoProducto = productosVenta[indiceVenta, i];

            int ind = Array.IndexOf(codigosProducto, codigoProducto);

            string descripProd = descripcionesProducto[ind];
            int cantidad = cantidadesVenta[indiceVenta, i];
            decimal precioUnitario = preciosProducto[ind];
            decimal totalPorProducto = precioUnitario * cantidad;


            totalFac = totalFac + totalPorProducto;




            Console.WriteLine("| " + cantidad.ToString().PadLeft(13) + "| " + descripProd.PadRight(23) + "| " + precioUnitario.ToString("C").PadLeft(18) + "| " + totalPorProducto.ToString("C").PadLeft(18) + " | ");
        }
        iva = ((totalFac / 100) * 12);
        decimal subtotal = totalFac - iva;

        decimal descuento = Descuento(totalFac);

        decimal totalFinal = totalFac - descuento;


        Console.WriteLine("|--------------------------------------------------------------------------------|");
        Console.WriteLine("|" + "Subtotal: ".PadLeft(60) + subtotal.ToString("C").PadLeft(19) + " |");
        Console.WriteLine("|" + "(+)Iva: ".PadLeft(60) + iva.ToString("C").PadLeft(19) + " |");
        Console.WriteLine("|" + "(-)Descuento por compra: ".PadLeft(60) + descuento.ToString("C").PadLeft(19) + " |");
        Console.WriteLine("|                                                                    ------------|");
        Console.WriteLine("|" + "Total A Pagar: ".PadLeft(60) + totalFinal.ToString("C").PadLeft(19) + " |");
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine("| Los Descuentos por oferta sobre el monto total de la compra se aplican en base |");
        Console.WriteLine("| a lo siguiente:                                                                |");
        Console.WriteLine("|     --> Q. 1.00 hasta Q. 100.00      descuento sobre monto gastado de 5%       |");
        Console.WriteLine("|     --> Q. 101.00 hasta Q. 200.00    descuento sobre monto gastado de 7%       |");
        Console.WriteLine("|     --> Q. 201.00 en adelante        descuento sobre monto gastado de 10%      |");
        Console.WriteLine("|________________________________________________________________________________|");

        Console.ResetColor();
        Console.WriteLine();
        Console.Write("Preciona cualquier tecla para regresar al menú");
        Console.ReadKey();
    }


    public static decimal Descuento(decimal cantidad)
    {
        decimal descuento = 0;
        if (cantidad > 0 && cantidad <= 100)
        {

            descuento = (cantidad / 100) * 5;

        }
        else if (cantidad > 100 && cantidad <= 200)
        {

            descuento = (cantidad / 100) * 7;
        }
        else
        {
            descuento = (cantidad / 100) * 10;
        }

        return descuento;
    }

}
