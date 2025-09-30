using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BaseEntity
{
    internal class EntityFine : IEntityTypeConfiguration<Fine>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Fine> builder)
        {
            builder.Property(f => f.IssuedDate)
               .HasDefaultValueSql("GETDATE()");
        }
    }
}
