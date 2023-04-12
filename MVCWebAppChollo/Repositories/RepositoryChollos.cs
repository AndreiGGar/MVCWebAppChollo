using Microsoft.EntityFrameworkCore;
using MVCWebAppChollo.Data;
using MVCWebAppChollo.Models;

namespace MVCWebAppChollo.Repositories
{
    public class RepositoryChollos
    {
        private DataContext context;

        public RepositoryChollos(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Chollo>> GetChollosAsync()
        {
            var consulta = from datos in this.context.Chollos
                           orderby datos.Fecha descending
                           select datos;
            return await consulta.ToListAsync();
        }
    }
}
