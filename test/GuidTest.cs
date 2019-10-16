using Xunit;


namespace TravisCI
{
    public class UnitTest1
    {
        [Fact]
        public void GetNewGuidTest()
        {
            var guidGenerator = new GuidGenerator();
            Assert.NotEqual(guidGenerator.GetNewGuid(), guidGenerator.GetNewGuid());
        }
    }
}
