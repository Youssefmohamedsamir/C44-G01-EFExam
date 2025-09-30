using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BaseEntity
{
    internal class EntityMember:IEntityTypeConfiguration<Member>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.Email)
              .HasMaxLength(100);

            builder.Property(m => m.PhoneNumber)
                   .HasMaxLength(11);
        }
    }
   
}
