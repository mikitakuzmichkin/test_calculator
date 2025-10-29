namespace Data
{
    public interface ICalculatorSaveService
    {
        public string GetlastExample();
        public void SaveExample(string input);
    }
}