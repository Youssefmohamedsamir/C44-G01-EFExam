using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BaseEntity
{
    internal class EnitityBook : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title)
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(b => b.Price)
                   .HasColumnType("decimal(8,2)");

            builder.Property(b => b.PublicationYear)
                   .HasDefaultValue(DateTime.Now.Year);
        }
    }
}
