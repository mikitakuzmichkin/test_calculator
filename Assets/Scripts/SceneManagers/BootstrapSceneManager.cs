using Data;
using Domain;
using Presentation.CalculatorWindow;

namespace SceneManagers
{
    using UnityEngine;

    public class BootstrapSceneManager : MonoBehaviour
    {
        [SerializeField] private CalculatorWindowView _view;

        private CalculatorWindowController _controller;

        private void Start()
        {
            var storage = new CalculatorPrefsSaveService();
            var useCase = new CalculateUseCase();
            
            _controller = new CalculatorWindowController(_view, useCase, storage);
        }
    }
}