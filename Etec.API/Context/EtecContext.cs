using Etec.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etec.API.Context
{
    public class EtecContext: DbContext
    {
        public DbSet<Aluno> AlunoSet { get; set; }
    }
}
