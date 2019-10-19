using System;
using Crwating_Mock_Object_Using_Moq5_9.Mocking;
using Moq;
using NUnit.Framework;

namespace VideoServiceTests5_9
{
    [TestFixture]
    public class VideoServiceTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
           
            _fileReader.Setup(fr => fr.Read("Video.txt")).Returns("");

            var result = _videoservice.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

    }
}
