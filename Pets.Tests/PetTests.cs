using NUnit.Framework;

namespace PetProject.Tests
{
    [TestFixture]
    public class PetTests
    {
        [SetUp]
        protected void SetUp()
        {
            
        }

        [Test]
        public void DogTalkToOwnerReturnsWoof()
        {
            string expected = "Woof!";
            string actual = new Dog().TalkToOwner();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DogTalkToOwnerReturnsMeow()
        {
            string expected = "Meow!";
            string actual = new Dog().TalkToOwner();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CatTalkToOwnerReturnsMeow()
        {
            string expected = "Meow!";
            string actual = new Cat().TalkToOwner();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CatTalkToOwnerReturnsWoof()
        {
            string expected = "Woof!";
            string actual = new Cat().TalkToOwner();

            Assert.AreEqual(expected, actual);
        }
    }    
}
