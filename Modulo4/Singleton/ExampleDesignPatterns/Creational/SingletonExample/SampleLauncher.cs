namespace Singleton
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
            CustomerRepository repository = new CustomerRepository();
            CreateCustomerUseCase useCase = new CreateCustomerUseCase(repository);
            useCase.Execute("id", "name");
		}
	}
}
