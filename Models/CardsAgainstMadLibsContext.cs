using Microsoft.EntityFrameworkCore;

namespace CardsAgainstMadLibs.Models
{
    public class CardsAgainstMadLibsContext : DbContext
    {
        public CardsAgainstMadLibsContext(DbContextOptions options) : base(options){}
        
    }
}