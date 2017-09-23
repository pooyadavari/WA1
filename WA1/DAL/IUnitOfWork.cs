namespace DAL
{
	/// <summary>
	/// Version: 2.1 - Date: 1392/04/09
	/// </summary>
	public interface IUnitOfWork : System.IDisposable
	{
		IProductRepository ProductRepository { get; }		

		void Save();
	}
}
