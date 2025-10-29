using UnityEngine;

namespace Data
{
    public class CalculatorPrefsSaveService : ICalculatorSaveService
    {
        private const string Key = "CalculatorInput";
        
        public string GetlastExample()
        {
            return PlayerPrefs.GetString(Key, "");
        }

        public void SaveExample(string input)
        {
            PlayerPrefs.SetString(Key, input);
            PlayerPrefs.Save();
        }
    }
}