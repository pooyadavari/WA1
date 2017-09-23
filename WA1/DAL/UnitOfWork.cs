namespace DAL
{
	/// <summary>
	/// Version: 2.1 - Date: 1392/04/09
	/// </summary>
	public class UnitOfWork : System.Object, IUnitOfWork
	{
		public UnitOfWork()
		{
			IsDisposed = false;
		}

		protected bool IsDisposed { get; set; }

		private Models.DatabaseContext _databaseContext;
		protected virtual Models.DatabaseContext DatabaseContext
		{
			get
			{
				if (_databaseContext == null)
				{
					_databaseContext =
						new Models.DatabaseContext();
				}
				return (_databaseContext);
			}
		}

        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository =
                        new ProductRepository(DatabaseContext);
                }
                return (_productRepository);
            }
        }

        public void Save()
		{
			DatabaseContext.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (IsDisposed == false)
			{
				if (disposing)
				{
					_databaseContext.Dispose();
				}
			}

			IsDisposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			System.GC.SuppressFinalize(this);
		}
	}
}
