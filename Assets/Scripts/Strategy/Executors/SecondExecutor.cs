using UnityEngine;

namespace Strategy.Executors
{
    public class SecondExecutor : IStrategyExe
    {
        public ExeType MyType => ExeType.Second;
        public void Run()
        {
            Debug.Log("run second");
        }
    }
}