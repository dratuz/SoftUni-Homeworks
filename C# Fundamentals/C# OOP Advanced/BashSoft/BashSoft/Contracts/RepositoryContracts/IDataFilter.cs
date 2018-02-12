namespace BashSoft.Contracts.RepositoryInterfaces
{
    using System.Collections.Generic;

    public interface IDataFilter
    {
        void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilters, int studentsToTake);
    }
}
