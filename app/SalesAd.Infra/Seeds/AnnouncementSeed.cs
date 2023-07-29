using Microsoft.EntityFrameworkCore;
using SalesAd.Domain.Entities;
using SalesAd.Domain.Enums;

namespace SalesAd.Infra.Seeds
{
    public static class AnnouncementSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnnouncementEntity>(p =>
            {
                var announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 100000, 250, AnnouncementTypeEnum.Ground, Guid.Parse("59401ca7-bc66-40d3-ac70-a24409751d97"), description: "Ground test 1"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 200000, 350, AnnouncementTypeEnum.Ground, Guid.Parse("59401ca7-bc66-40d3-ac70-a24409751d97"), description: "Ground test 2 59401ca7"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 300000, 450, AnnouncementTypeEnum.Ground, Guid.Parse("59401ca7-bc66-40d3-ac70-a24409751d97"), description: "Ground test 3 59401ca7"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 400000, 550, AnnouncementTypeEnum.Ground, Guid.Parse("59401ca7-bc66-40d3-ac70-a24409751d97"), description: "Ground test 4 59401ca7"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 500000, 650, AnnouncementTypeEnum.Ground, Guid.Parse("59401ca7-bc66-40d3-ac70-a24409751d97"), description: "Ground test 5 59401ca7"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 210000, 351, AnnouncementTypeEnum.Ground, Guid.Parse("b692b631-897c-4993-a957-e18a3a2dcdbf"), description: "Ground test 2 b692b631"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 310000, 451, AnnouncementTypeEnum.Ground, Guid.Parse("b692b631-897c-4993-a957-e18a3a2dcdbf"), description: "Ground test 3 b692b631"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 410000, 551, AnnouncementTypeEnum.Ground, Guid.Parse("b692b631-897c-4993-a957-e18a3a2dcdbf"), description: "Ground test 4 b692b631"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 510000, 651, AnnouncementTypeEnum.Ground, Guid.Parse("b692b631-897c-4993-a957-e18a3a2dcdbf"), description: "Ground test 5 b692b631"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 220000, 352, AnnouncementTypeEnum.Ground, Guid.Parse("042ad764-addc-43f9-92dd-d050a16e1801"), description: "Ground test 2 042ad764"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 320000, 452, AnnouncementTypeEnum.Ground, Guid.Parse("042ad764-addc-43f9-92dd-d050a16e1801"), description: "Ground test 3 042ad764"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 420000, 552, AnnouncementTypeEnum.Ground, Guid.Parse("042ad764-addc-43f9-92dd-d050a16e1801"), description: "Ground test 4 042ad764"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 520000, 652, AnnouncementTypeEnum.Ground, Guid.Parse("042ad764-addc-43f9-92dd-d050a16e1801"), description: "Ground test 5 042ad764"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 230000, 353, AnnouncementTypeEnum.Ground, Guid.Parse("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), description: "Ground test 2 e1298a81"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 330000, 453, AnnouncementTypeEnum.Ground, Guid.Parse("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), description: "Ground test 3 e1298a81"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 430000, 553, AnnouncementTypeEnum.Ground, Guid.Parse("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), description: "Ground test 4 e1298a81"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 530000, 653, AnnouncementTypeEnum.Ground, Guid.Parse("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"), description: "Ground test 5 e1298a81"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 240000, 353, AnnouncementTypeEnum.Ground, Guid.Parse("5db55f64-1c3d-4ddc-9859-d55060946588"), description: "Ground test 2 5db55f64"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 340000, 453, AnnouncementTypeEnum.Ground, Guid.Parse("5db55f64-1c3d-4ddc-9859-d55060946588"), description: "Ground test 3 5db55f64"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 440000, 553, AnnouncementTypeEnum.Ground, Guid.Parse("5db55f64-1c3d-4ddc-9859-d55060946588"), description: "Ground test 4 5db55f64"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });

                announcementId = Guid.NewGuid();
                p.HasData(new AnnouncementEntity(announcementId, 540000, 653, AnnouncementTypeEnum.Ground, Guid.Parse("5db55f64-1c3d-4ddc-9859-d55060946588"), description: "Ground test 5 5db55f64"));
                p.OwnsOne(pr => pr.Address)
                    .HasData(new { Id = Guid.NewGuid(), AnnouncementId = announcementId, StreetName = "Street DOTNET 7", ZipCode = "14785000", Neighborhood = "Bairro 1", State = "MG", Country = "BR", Number = 12 });
            });
        }
    }
}