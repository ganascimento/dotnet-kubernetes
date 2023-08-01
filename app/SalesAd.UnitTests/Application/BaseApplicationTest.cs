using Moq;
using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.UnitTests.Application;

public class BaseApplicationTest
{
    protected readonly Mock<IOwnerRepository> _ownerRepository;
    protected readonly Mock<IAnnouncementRepository> _announcementRepository;

    public BaseApplicationTest()
    {
        _ownerRepository = new Mock<IOwnerRepository>();
        _announcementRepository = new Mock<IAnnouncementRepository>();
    }
}