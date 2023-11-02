using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Monad
{
    public class MaybeMonoBehaviour<T> : MonoBehaviour
    {
        public Maybe<T> Value { get; private set; }

        void Start()
        {
            if (Value.HasValue)
            {

            }
        }

        //public static MaybeMonoBehaviour<T> Some<T1>(Component component) where T1 : Component
        //{
        //    return new MaybeMonoBehaviour<T>
        //    {
        //        Value = component
        //    };
        //}

        //public static MaybeMonoBehaviour<T> GetComponentMaybe<T>(GameObject gameObject) where T : Component
        //{
        //    var component = gameObject.GetComponent<T>();

        //    if (component != null)
        //    {
        //        return MaybeMonoBehaviour.Some(component);
        //    }
        //    else
        //    {
        //        return Maybe<T>.None;
        //    }
        //}

    }

    public class Maybe<T>
    {
        public Maybe(T value)
        {
            Value = value;
        }

        public Maybe()
        {
        }

        public T Value { get; set; }

        public bool HasValue => Value != null;

        public Maybe<T> Bind<R>(Func<T, Maybe<T>> f)
        {
            if (HasValue)
            {
                return f(Value);
            }
            else
            {
                return None;
            }
        }

        public static Maybe<T> None => new();
    }
}
