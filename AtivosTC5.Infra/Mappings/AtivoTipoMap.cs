﻿using AtivosTC5.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivosTC5.Infra.Mappings
{
    public class AtivoTipoMap : IEntityTypeConfiguration<AtivoTipo>
    {
        public void Configure(EntityTypeBuilder<AtivoTipo> builder)
        {
            throw new NotImplementedException();
        }
    }
}
