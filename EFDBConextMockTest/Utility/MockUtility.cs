using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using EFDBContextMockTest.Utility.Async;
using Moq;

namespace EFDBContextMockTest.Utility
{
    public class MockUtility
    {
        public static Mock<DbSet<TEntity>> GenerateMockSet<TEntity>(IQueryable<TEntity> data) where TEntity : class
        {
            var mockSet = new Mock<DbSet<TEntity>>();
            mockSet.As<IQueryable<TEntity>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator);
            return mockSet;
        }

        public static Mock<DbSet<TEntity>> GenerateAsyncMockSet<TEntity>(IQueryable<TEntity> data)
            where TEntity : class
        {
            var mockSet = new Mock<DbSet<TEntity>>();
            mockSet.As<IDbAsyncEnumerable<TEntity>>()
                .Setup(m => m.GetAsyncEnumerator())
                .Returns(new TestDbAsyncEnumerator<TEntity>(data.GetEnumerator()));

            mockSet.As<IQueryable<TEntity>>()
                .Setup(m => m.Provider)
                .Returns(new TestDbAsyncQueryProvider<TEntity>(data.Provider));

            mockSet.As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            return mockSet;
        }
    }
}