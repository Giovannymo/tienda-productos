namespace Persistencia_csharp.Class;

    public class Category
    {
        public int CategoryID { get; set; }
        public string Description { get; set; }

        public Category(){

        }

        public Category(int _categoryID, string _description){
            this.CategoryID = _categoryID;
            this.Description = _description;
        }

        public static void CreateCategory(){
            try{

                Console.WriteLine("Ingrese el ID de la categoria");
                int idCategory = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre de la categoria: ");
                string NameCategory = Console.ReadLine();

                Category category = new Category(idCategory, NameCategory);
                Env.CampusStore.Categories.Add(category);
            

            }catch(Exception e){
                throw new Exception("Hubo una excepciòn, intentelo de nuevo\n"+e.Message);
            }
        }


        public IEnumerable<Category> ShowCategories()
        {
            return from category in Env.CampusStore.Categories
                select category;
        }

        
    }
