using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class CardSeedConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
                new Card
                {
                    Id = 1,
                    CardType = "debit cards",
                },

                new Card
                {
                    Id = 2,
                    CardType = "credit cards",
                }
            );
        }
    }
}
