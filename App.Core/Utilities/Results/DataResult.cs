﻿using FluentValidation.Results;

namespace App.Core.Utilities.Results
{
  public class DataResult<T> : Result, IDataResult<T>
  {
    public T Data { get; }
    public ValidationResult ValidationResult { get; }

    public DataResult(T data, bool success, string message) : base(success, message)
    {
      Data = data;

    }
    public DataResult(T data, bool success) : base(success)
    {
      Data = data;
    }
    public DataResult(T data, bool success, ValidationResult validationResult) : base(success)
    {
      Data = data;
      ValidationResult = validationResult;
    }
  }
}
