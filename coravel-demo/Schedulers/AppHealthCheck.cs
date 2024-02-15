using Coravel.Invocable;
using coravel_demo.DL;

namespace coravel_demo.Schedulers
{
	public class AppHealthCheck : IInvocable
	{
		public Task Invoke()
		{
			var result = new FetchDetails().GetWeatherForecast();
			Console.WriteLine($"Sample Invocable ran! {result.FirstOrDefault().TemperatureC}");
			return Task.CompletedTask;
		}
	}
}
