namespace DataFlow.Core
{
    public class LabeledBuffer : Buffer<string>
    {
        public void PrintAllUpper()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToUpper());
            }
        }
    }
}
