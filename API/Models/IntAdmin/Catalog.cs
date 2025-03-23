using API.Models.IntAdmin.Interfaces;

namespace API.Models.IntAdmin
{
    public class Catalog : ICatalog
    {
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public List<ICategory> Categories { get; set; } = new List<ICategory>();

        public Catalog(int catalogId, string name, string description, string status, List<ICategory> categories)
        {
            CatalogId = catalogId;
            Name = name;
            Description = description;
            Status = status;
            Categories = categories;
        }

        // Constructor por defecto para escenarios de serializaci�n u otras necesidades.
        public Catalog() { }

        public Result<ICatalog> AddCatalog(ICatalog catalog)
        {
            // L�gica para agregar un nuevo cat�logo (ej. guardar en base de datos o colecci�n)
            return Result<ICatalog>.Success(catalog);
        }

        public Result<ICatalog> UpdateCatalog(ICatalog catalog)
        {
            // L�gica para actualizar un cat�logo existente
            return Result<ICatalog>.Success(catalog);
        }

        public Result<ICatalog> GetCatalogById(int catalogId)
        {
            // L�gica para obtener un cat�logo por su ID
            var catalog = new Catalog(catalogId, "Cat�logo de Ejemplo", "Descripci�n de cat�logo de ejemplo", "Activo", new List<ICategory>());
            return Result<ICatalog>.Success(catalog);
        }

        public Result<List<ICatalog>> GetAllCatalogs()
        {
            // L�gica para obtener todos los cat�logos
            var catalogs = new List<ICatalog>
            {
                new Catalog(1, "Cat�logo 1", "Descripci�n del cat�logo 1", "Activo", new List<ICategory>()),
                new Catalog(2, "Cat�logo 2", "Descripci�n del cat�logo 2", "Inactivo", new List<ICategory>())
            };
            return Result<List<ICatalog>>.Success(catalogs);
        }

        public Result<bool> RemoveCatalog(int catalogId)
        {
            // L�gica para eliminar un cat�logo por su ID
            return Result<bool>.Success(true);
        }
    }
}
