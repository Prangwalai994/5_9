using System;
using Moq;
using NUnit.Framework;

namespace VideoServiceTests5_9
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var mockFileReader = new Mock<IFileReader>();
            fileReader.Setup(fr => fr.Read("Video.txt")).Returns("");


            var service = new VideoService(fileReader.Object);


            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

    }
}
