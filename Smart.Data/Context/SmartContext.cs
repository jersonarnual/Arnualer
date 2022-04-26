using Microsoft.EntityFrameworkCore;

namespace Smart.Data.Context
{
    public class SmartContext: DbContext 
    {
        public SmartContext()
        {

        }
        public SmartContext(DbContextOptions<SmartContext> options):base(options)
        {

        }

    }
}
