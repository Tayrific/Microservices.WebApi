using Microsoft.EntityFrameworkCore;

namespace Products.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}
