using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Presentation.CalculatorWindow
{
    public class CalculatorWindowView : MonoBehaviour, ICalculatorWindowView
    {
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private Button _resultButton;

        public event Action OnResultClick;
        public event Action<string> OnInputChanged;

        private void Start()
        {
            _resultButton.onClick.AddListener(() => OnResultClick?.Invoke());
            _inputField.onValueChanged.AddListener(InputValueChanged);
        }

        public string GetInput()
        {
            return _inputField.text;
        }

        public void SetInput(string input)
        {
            _inputField.text = input;
        }
        
        public void ResultRequested()
        {
            OnResultClick?.Invoke();
        }
        
        private void InputValueChanged(string value)
        {
            OnInputChanged?.Invoke(value);
        }
    }
}