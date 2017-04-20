public interface IBehaviourTree
{
    string Key { get; }

    bool Add(string key,IBehaviourTree leaf);
    bool Excute();
}
