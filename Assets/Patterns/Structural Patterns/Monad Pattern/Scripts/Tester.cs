using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Monad
{
    public class Tester : MonoBehaviour
    {
        void Start()
        {
            var result = Divide(10, 2);

            if (result.IsSuccess)
            {
                Debug.Log("Result: " + result.Value);
            }
            else
            {
                Debug.LogError("Error: " + result.Error);
            }

            var result2 = Divide(10, 0);
            result2.PrintMessage();

            var result3 = Divide(20, 2);
            result3.PrintMessage();
        }

        public Result<int> Divide(int num, int divisor)
        {
            if (divisor == 0)
            {
                return Result<int>.Failure("Division by zero is not allowed.");
            }
            return Result<int>.Success(num / divisor);
        }
    }
}
