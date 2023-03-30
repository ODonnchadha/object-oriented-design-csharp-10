using OODesign.Library.Models;
using Xunit;

namespace OODesign.Test.Models
{
    public class CarShould
    {
        private Car? car;

        [Fact()]
        public void Start()
        {
            // Arrange.
            var c = new Car();

            // Act.
            var result = c.Start();

            // Assert.
            Assert.True(result);

        }

        [Fact()]
        public void Stop()
        {
            // Arrange.
            var c = new Car();

            // Act.
            var result = c.Stop();

            // Assert.
            Assert.True(result);
        }
    }
}
