using API.Models.IntAdmin.Interfaces;

namespace API.Models.IntAdmin
{
    public class Category : ICategory
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Category(int categoryId, string name, string status, List<Item> items)
        {
            CategoryId = categoryId;
            Name = name;
            Status = status;
            Items = items;
        }

        // Constructor por defecto para escenarios de serializaci�n u otras necesidades.
        public Category() { }

        public Result<ICategory> AddCategory(ICategory category)
        {
            // L�gica para agregar una nueva categor�a (ej. guardar en base de datos o colecci�n)
            return Result<ICategory>.Success(category);
        }

        public Result<ICategory> UpdateCategory(ICategory category)
        {
            // L�gica para actualizar una categor�a existente
            return Result<ICategory>.Success(category);
        }

        public Result<ICategory> GetCategoryById(int categoryId)
        {
            // L�gica para obtener una categor�a por su ID
            var category = new Category(categoryId, "Categor�a de Ejemplo", "Activo", new List<Item>());
            return Result<ICategory>.Success(category);
        }

        public Result<List<ICategory>> GetAllCategories()
        {
            // L�gica para obtener todas las categor�as
            var categories = new List<ICategory>
            {
                new Category(1, "Categor�a 1", "Activo", new List<Item>()),
                new Category(2, "Categor�a 2", "Inactivo", new List<Item>())
            };
            return Result<List<ICategory>>.Success(categories);
        }

        public Result<bool> RemoveCategory(int categoryId)
        {
            // L�gica para eliminar una categor�a por su ID
            return Result<bool>.Success(true);
        }
    }
}
