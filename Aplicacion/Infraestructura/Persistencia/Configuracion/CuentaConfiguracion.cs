﻿using Aplicacion.Dominio.Entidades.Cuenta;
using Aplicacion.Dominio.Entidades.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Infraestructura.Persistencia.Configuracion
{
    public class CuentaConfiguracion : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> entity)
        {
            entity.Property(x => x.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            entity.Property(x => x.Saldo)
                .IsRequired();

            entity.Property(x => x.FechaCreacion)
                .IsRequired();

            entity.Property(x => x.IdUsuario)
            .IsRequired();

            entity.HasOne(x => x.Usuario)
                .WithMany(x => x.Cuentas)
                .HasForeignKey(x => x.IdUsuario);
        }
    }
}
