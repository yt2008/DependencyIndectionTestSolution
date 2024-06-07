namespace DependencyIndectionTestSolution.Services
{
    public interface IService1
    {
        Task<IEnumerable<WeatherForecast>> GetResult1Async();
    }
}
