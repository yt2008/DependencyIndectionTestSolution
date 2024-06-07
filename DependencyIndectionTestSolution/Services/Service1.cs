using DependencyIndectionTestSolution.DataProviders;

namespace DependencyIndectionTestSolution.Services
{
    public class Service1 : IService1
    {
        private readonly IDataProvider1 _dataProvider1;
        public Service1(IDataProvider1 dataProvider1)
        {
            _dataProvider1 = dataProvider1;
        }

        public async Task<IEnumerable<WeatherForecast>> GetResult1Async()
        {
            return await _dataProvider1.GetData1Async();
        }
    }
}
