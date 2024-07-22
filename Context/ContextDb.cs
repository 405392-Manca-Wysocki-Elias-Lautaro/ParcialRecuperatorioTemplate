using Microsoft.EntityFrameworkCore;

namespace ParcialRecuperatorio.Context;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) : base(options)
    {
            
    }
}