using UnityEngine;

namespace Strategy.Executors
{
    public class ThirdExecutor : IStrategyExe
    {
        public ExeType MyType => ExeType.AnybodyDoSomething;
        public void Run()
        {
            Debug.LogAssertion("i do anything always");
        }
    }
}