using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                new Payment
                {
                    Id = 1,
                    PaymentType = "debit cards",
                },

                new Payment
                {
                    Id = 2,
                    PaymentType = "credit cards",
                },
                new Payment
                {
                    Id = 3,
                    PaymentType = "Paylah",
                },
                new Payment
                {
                    Id = 4,
                    PaymentType = "PayPal",
                }
            );
        }
    }
}
