using Localiza.Frotas.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Localiza.Frotas.Infra.Repository.EF
{
    public class FrotaRepository : IVeiculoRepository
    {
        private readonly FrotaContext dbContext;
        public FrotaRepository(FrotaContext dbContext) => this.dbContext = dbContext;
        public void Add(Veiculo veiculo)
        {
            dbContext.veiculos.Add(veiculo);
            dbContext.SaveChanges();
        }

        public void Delete(Veiculo veiculo)
        {
            dbContext.veiculos.Remove(veiculo);
            dbContext.SaveChanges();
        }

        public IEnumerable<Veiculo> GetAll() => dbContext.veiculos.ToListAsync().Result;

        public Veiculo GetById(Guid id) => dbContext.veiculos.SingleOrDefaultAsync().Result;

        public void Update(Veiculo veiculo)
        {
            dbContext.Entry(veiculo).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
