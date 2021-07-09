namespace Strategy
{
    public interface IStrategyExe
    {
        ExeType MyType { get; }
        void Run();
    }
}