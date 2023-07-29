using Microsoft.EntityFrameworkCore;
using SalesAd.Domain.Entities;

namespace SalesAd.Infra.Seeds
{
    public static class OwnerSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OwnerEntity>().HasData(
                new OwnerEntity(Guid.Parse("59401ca7-bc66-40d3-ac70-a24409751d97"), "Marcos dos Santos", new DateTime(2000, 01, 10), "11912345678", "marcossantos@email.com", true),
                new OwnerEntity(Guid.Parse("b692b631-897c-4993-a957-e18a3a2dcdbf"), "Ana Ferreira", new DateTime(2005, 03, 15), "11912345679", "anaferreira@email.com", true),
                new OwnerEntity(Guid.Parse("042ad764-addc-43f9-92dd-d050a16e1801"), "Luiz Rodrigues", new DateTime(2001, 08, 28), "11912345658", "luizr@email.com", true),
                new OwnerEntity(Guid.Parse("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), "Mario Nascimento", new DateTime(1999, 04, 07), "11912345620", "marionas@email.com", true),
                new OwnerEntity(Guid.Parse("5db55f64-1c3d-4ddc-9859-d55060946588"), "Maria Alves", new DateTime(1999, 08, 07), "11912345620", "mariaalves@email.com", true)
            );
        }
    }
}