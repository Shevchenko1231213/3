namespace Lab3.Contracts
{
    public interface IStringRepository
    {
        string[] SortByAscending();
        string[] SortByDescending();
        string SortByAscii();
    }
}
