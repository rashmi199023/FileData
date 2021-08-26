using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThirdPartyTools;

namespace FileDetailsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VersionTest()
        {
            var arg1 = "-v";
            var arg2 = "C:/test.txt";
            FileDetails f = new FileDetails();
            var version = f.Version(arg2);

        }

        [TestMethod]
        public void SizeTest()
        {
            var arg1 = "-s";
            var arg2 = "C:/test.txt";
            FileDetails f = new FileDetails();
            var version = f.Size(arg2);

        }
    }
}
