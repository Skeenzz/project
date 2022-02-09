using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class ReviewsSeedConfiguration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.HasData(
                new Reviews
                {
                    Id=1,
                    Name = "john tan",
                    ProfilePic = "url",
                    reviews = "Drives too fast"
                }
                );
        }
    }
}


