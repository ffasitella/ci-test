using System;

namespace TravisCI
{
    public class GuidGenerator
    {
        public GuidGenerator() { }
        
        public Guid GetNewGuid() => Guid.NewGuid();
    }
}
