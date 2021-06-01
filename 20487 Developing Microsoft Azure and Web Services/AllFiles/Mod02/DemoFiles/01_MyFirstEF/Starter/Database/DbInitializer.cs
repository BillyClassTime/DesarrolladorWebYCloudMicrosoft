
namespace MyFirstEF.Database
{

    public static class DbInitializer
    {
        public static void Initializa(MyDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }

}