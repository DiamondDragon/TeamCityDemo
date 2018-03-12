using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamCityDemo.CommandLineTool.Tests
{
    [TestFixture]
    public class DisposableTests
    {
        public string _field;

        string field2;

        public string property1 { get; set; }

        [Test]
        public void DoTest()
        {
            using (var test = new Disposble())
            {
                
            }
        }
    }
}
