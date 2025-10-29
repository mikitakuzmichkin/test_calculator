using System;

namespace Presentation.CalculatorWindow
{
    public interface ICalculatorWindowView
    {
        public string GetInput();
        public void SetInput(string input);
        public void ResultRequested();
        public event Action OnResultClick;
        public event Action<string> OnInputChanged;
    }
}