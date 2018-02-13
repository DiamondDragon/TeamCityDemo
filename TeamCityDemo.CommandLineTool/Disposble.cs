using System;
using System.Threading.Tasks;

namespace TeamCityDemo.CommandLineTool
{
    public class Disposble : IDisposable
    {
        public async void TestMethod()
        {
            await Task.Yield();
        }

        public void Dispose()
        {
        }
    }
}