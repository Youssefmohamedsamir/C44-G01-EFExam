using Exam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BaseEntity
{
    internal class EntityAuthor : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
         
            builder.Property(a => a.FirstName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(a => a.LastName)
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
    }
}
