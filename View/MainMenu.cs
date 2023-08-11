namespace Persistencia_csharp.View;


    public class MainMenu
    {

        public static int showMenu(){
            Console.WriteLine("################## Sùper tienda ABS ##################");
            Console.WriteLine("1.Registrar Producto: " + "\n" + 
                            "2.Registrar Categoria: " + "\n" + 
                            //"3.Listar Categorias: " + "\n" + 
                            //"4.Listar Productos: " + "\n" + 
                            //"5.Costo total del Inventario:" + "\n" + 
                            "6.Salir" + "\n" );
            int option = int.Parse( Console.ReadLine() );
            return option;
        }
        
    }
