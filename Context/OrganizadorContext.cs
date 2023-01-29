using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    //DbContext é a classe pai que vem do EntityFramework
    public class OrganizadorContext : DbContext
    {
        //Recebe a configuração do Db
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }
        //Propriedade que se refera a entidade (uma classe no programa e uma tabela no Db)
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}