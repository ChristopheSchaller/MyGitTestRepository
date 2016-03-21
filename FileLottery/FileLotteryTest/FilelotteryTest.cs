using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileLottery;

namespace FileLotteryTest
{
    [TestClass]
    public class FilelotteryTest
    {
        private Lottery _target;

        [TestInitialize]
        public void Initialize()
        {
            _target = new Lottery();
        }

        [TestMethod]
        public void OnlyOneFileInTheDirectory_NextPath_shouldReturnTheOnlyFileFromTheDirectory()
        {
        }
    }
}
