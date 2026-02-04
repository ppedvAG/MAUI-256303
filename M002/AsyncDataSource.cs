namespace M001;

public class AsyncDataSource
{
	public async IAsyncEnumerable<int> Generiere()
	{
		while (true)
		{
			await Task.Delay(Random.Shared.Next(1000, 10000));
			yield return Random.Shared.Next();
		}
	}
}
