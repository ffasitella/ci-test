using Xunit;


namespace TravisCI
{
    public class UnitTest1
    {
        [Fact]
        public void GetNewGuidTest()
        {
            var guidGenerator = new GuidGenerator();
            var guid1 = guidGenerator.GetNewGuid();
            var guid2 = guidGenerator.GetNewGuid();
            Assert.NotEqual(guid1, guid2);
        }
    }
}
