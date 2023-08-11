using Newtonsoft.Json;
using Persistencia_csharp.View;
namespace Persistencia_csharp.Class;



internal class Program
{
    private static void Main(string[] args)
    {
        int option = 0;
        string json;
        if(!Env.ExistFile(Env.FileName)){
            File.WriteAllText(Env.FileName, "");
        }else{
            Env.LoadDataProducts(Env.FileName);
        }
        Env.ShowData("Categorias: ",Env.CampusStore.Categories);
        Env.ShowData("Productos: ",Env.CampusStore.Products);
        do
        {
            option = MainMenu.showMenu();

            switch (option)
            {

                case 1:
                    Product.CreateProduct();
                    json = JsonConvert.SerializeObject(Env.CampusStore, Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    //string json = JsonConvert.SerializeObject(Env.Products, Formatting.Indented);
                    //File.WriteAllText(Env.FileName, json);
                    break;
                case 2:
                    Category.CreateCategory();
                    json = JsonConvert.SerializeObject(Env.CampusStore, Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;
                case 3:
                    break;
                
                case 4:
                     break;
                case 6:
                    Console.WriteLine("Cerramos el chuzo.");
                    break;
            }


        } while (option != 6);
    }

}