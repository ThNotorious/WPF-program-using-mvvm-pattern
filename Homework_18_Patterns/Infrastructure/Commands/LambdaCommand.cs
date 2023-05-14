﻿using Homework_18_Patterns.Infrastructure.Commands.Base;
using System;

namespace Homework_18_Patterns.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool>? _canExecute;

        public LambdaCommand(Action<object> Execute, Func<object, bool>? CanExecute = null) 
        {
            _execute = Execute ?? throw new ArgumentException(nameof(Execute));
            _canExecute = CanExecute;
        }


        public override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

        public override void Execute(object? parameter) => _execute(parameter);
    }
}
