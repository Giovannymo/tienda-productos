namespace Persistencia_csharp.Class;

    public static class Env
    {
        private static string fileName = "products.json";
        private static CampusStore campusStore = new CampusStore();
        public static string FileName {get => fileName; set => fileName = value; }
        
        public static CampusStore CampusStore{
            get{ return campusStore;}
            set{ campusStore = value;}
        }

        public static void LoadDataProducts(string nameFile){
            using(StreamReader reader = new StreamReader(nameFile))
            {
                string json = reader.ReadToEnd();
                if(string.IsNullOrWhiteSpace(json)){
                    new CampusStore();
                    return;
                }
                Env.CampusStore = System.Text.Json.JsonSerializer.Deserialize<CampusStore>(json, new System.Text.Json.JsonSerializerOptions(){
                    PropertyNameCaseInsensitive = true
                }) ?? new CampusStore();
            }
        }

        public static bool ExistFile(string nameFile)
        {
            if(!File.Exists(nameFile)){
                return false;
            }
            return true;
        }

        public static void ShowData<T>(string title, IEnumerable<T> list) {
            Console.WriteLine("{0,-30}", title);
            foreach (var element in list){
                Type typeClass = element.GetType();
                var propieties = typeClass.GetProperties();
                
                foreach (var propiety in propieties)
                {
                    Console.WriteLine($"{propiety.Name}: {propiety.GetValue(element)}");
                }
            }
            Console.ReadKey();
        }
        


        //private static List<Product> products = new List<Product>();
        //private static List<Category> categories = new List<Category>();
        //public static List<Product> Products {get => products; set => products = value;}
        //public static List<Category> Categories {get => categories; set => categories = value;}

        
        
    }
