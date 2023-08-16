namespace AsyncAwaitTest;

public class Test
{
    public async Task<int> FirstMethodAsync()
    {
        var client = new HttpClient();

        Task<int> getStringTask = SecondMethodAsync();

        DoFirstIndependentWork();

        int contents = await getStringTask;

        return contents;
    }


    public async Task<int> SecondMethodAsync()
    {
        var client = new HttpClient();
        
        for (int j = 0; j < int.MaxValue; j++)
        {
        }

        Task<string> getStringTask = RunForAWhileAsync();

        DoSecondIndependentWork();

        string contents = await getStringTask;

        return contents.Length;
    }

    public async Task<string> RunForAWhileAsync()
    {
        await Task.Delay(1000);
        
        for (int i = 0; i < int.MaxValue; i++)
        {
            for (int j = 0; j < int.MaxValue; j++)
            {
                Console.WriteLine("FOR-A-WHILE");
            }
        }

        return "nejaky-string";
    }

    public void DoFirstIndependentWork()
    {
        for (int i = 0; i < int.MaxValue; i++)
        {
            for (int j = 0; j < int.MaxValue; j++)
            {
                Console.WriteLine("FIRST-INDEPENDENT");
            }
        }
    }

    public void DoSecondIndependentWork()
    {
        for (int i = 0; i < int.MaxValue; i++)
        {
            for (int j = 0; j < int.MaxValue; j++)
            {
                Console.WriteLine("SECOND-INDEPENDENT");
            }
        }
    }
}