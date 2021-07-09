using System.Collections.Generic;

namespace Strategy
{
    public class StrategyManager
    {
        private readonly List<IStrategyExe> _executors;

        public StrategyManager(List<IStrategyExe> executors)
        {
            _executors = executors;
        }

        public void Run(ExeType type)
        {
            foreach (var exe in _executors)
            {
                if (exe.MyType == type) exe.Run();
            }
        }
    }
}