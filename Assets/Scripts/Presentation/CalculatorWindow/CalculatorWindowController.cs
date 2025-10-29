using Data;
using Domain;

namespace Presentation.CalculatorWindow
{
    public class CalculatorWindowController
    {
        private readonly ICalculatorWindowView _view;
        private readonly CalculateUseCase _useCase;
        private readonly ICalculatorSaveService _saveService;

        public CalculatorWindowController(ICalculatorWindowView view, CalculateUseCase useCase, ICalculatorSaveService saveService)
        {
            _view = view;
            _useCase = useCase;
            _saveService = saveService;

            _view.OnResultClick += ResultRequest;
            _view.OnInputChanged += HandleInputChanged;
            
            var lastExpression = _saveService.GetlastExample();
            _view.SetInput(lastExpression);
        }
        
        private void ResultRequest()
        {
            var input = _view.GetInput();
            _saveService.SaveExample(input);

            var result = _useCase.Process(input);
            _view.SetInput(result);
        }
        
        private void HandleInputChanged(string input)
        {
            _saveService.SaveExample(input);
        }
    }
}