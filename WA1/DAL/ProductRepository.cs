using System.Linq;
using System.Data.Entity;

namespace DAL
{
	public class ProductRepository : Repository<Models.Product>, IProductRepository
	{
		public ProductRepository(Models.DatabaseContext databaseContext)
			: base(databaseContext)
		{
		}
	}
}
