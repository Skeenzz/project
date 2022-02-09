using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payments>
    {
        public void Configure(EntityTypeBuilder<Payments> builder)
        {
            builder.HasData(
                new Payments
                {
                    Id = 1,
                    PaymentType = "debit cards",
                },

                new Payments
                {
                    Id = 2,
                    PaymentType = "credit cards",
                },
                new Payments
                {
                    Id = 3,
                    PaymentType = "Paylah",
                },
                new Payments
                {
                    Id = 4,
                    PaymentType = "PayPal",
                }
            );
        }
    }
}
