using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Monad
{
    public class Result<T>
    {
        public T Value { get; private set; }
        public string Error { get; private set; }
        public bool IsSuccess { get; private set; }

        private Result(T value)
        {
            Value = value;
            IsSuccess = true;
        }

        private Result(string error)
        {
            Error = error;
            IsSuccess = false;
        }

        public void PrintMessage()
        {
            if (IsSuccess)
            {
                Debug.Log("<color=white>[Result]</color> " + Value);
            }
            else
            {
                Debug.Log("<color=red>[Error]</color> " + Error);
            }
        }

        public static Result<T> Success(T value)
        {
            return new Result<T>(value);
        }

        public static Result<T> Failure(string error)
        {
            return new Result<T>(error);
        }
    }
}
