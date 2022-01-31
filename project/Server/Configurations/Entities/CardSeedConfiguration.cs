using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class CardSeedConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
                new Card
                {
                    Id = 1,
                    CardType = "debit cards",
                },

                new Card
                {
                    Id = 1,
                    CardType = "credit cards",
                }
            );
        }
    }
}
