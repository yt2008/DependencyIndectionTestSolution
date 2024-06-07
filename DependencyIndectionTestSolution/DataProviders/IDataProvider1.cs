namespace DependencyIndectionTestSolution.DataProviders
{
    public interface IDataProvider1
    {
        Task<IEnumerable<WeatherForecast>> GetData1Async();
    }
}
