using UnityEngine;

namespace Strategy.Executors
{
    public class FirstExecutor : IStrategyExe
    {
        public ExeType MyType => ExeType.First;
        public void Run()
        {
            Debug.Log("run first");
        }
    }
}