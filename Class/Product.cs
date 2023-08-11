namespace Persistencia_csharp.Class;

    public class Product
    {

        public string CodProduct { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public double PriceSale { get; set; }
        public double PriceBuy { get; set; }
        public int CategoryID { get; set; }

        public Product()
        {
            if(!File.Exists(Env.FileName)){
                File.WriteAllText(Env.FileName, "");
            }
        }
        public Product(string _codProduct, string _name, int _stock, int _stockMin, int _stockMax, double _priceSale, double _priceBuy, int _categoryID){
            this.CodProduct = _codProduct;
            this.Name = _name;
            this.Stock = _stock;
            this.StockMin = _stockMin;
            this.StockMax = _stockMax;
            this.PriceSale = _priceSale;
            this.PriceBuy = _priceBuy;
            this.CategoryID = _categoryID;
            if(!File.Exists(Env.FileName)){
                File.WriteAllText(Env.FileName, "");
            }
        }


        public static void CreateProduct(){
            try{
                Console.WriteLine("Ingrese el codigo del producto: ");
                string CodProduct = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del producto: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Ingrese el Stock: ");
                int Stock = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Stock Minimo: ");
                int StockMin = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Stock Maximo:");
                int StockMax = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio de Venta:");
                double PriceSale = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio de Compra:");
                double PriceBuy = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la Categoria a la que pertenece:");
                int category = int.Parse(Console.ReadLine());
                Product product = new Product(CodProduct,Name,Stock,StockMin,StockMax,PriceSale,PriceBuy,category);
                
                Env.CampusStore.Products.Add(product);


            }catch(Exception e){

                throw new Exception("Hubo una excepciòn, intentelo de nuevo\n"+e.Message);

            }
        }


        public void ShowProducts(List<Product> products){
            Console.WriteLine("{0,-30} {1,10} {1,10}", "Cod Producto:", " Nombre:", "Stock:");
            foreach (Product product in products)
            {
                Console.WriteLine("{0,-30} {1,10} {1,10}", product.CodProduct , product.Name , product.Stock);

            }

        }
    }
