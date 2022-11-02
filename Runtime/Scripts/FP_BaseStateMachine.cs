using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace FuzzPhyte.FSM
{
    public class FP_BaseStateMachine : MonoBehaviour
    {
        public SO_BaseState CurrentState { get; set; }
        //base state reference
        [Tooltip("Base State")]
        [SerializeField]
        private SO_BaseState _initialState;
        private Dictionary<Type, Component> _cachedComponents;

        private void Awake()
        {
            CurrentState = _initialState;
            _cachedComponents = new Dictionary<Type, Component>();
        }
        private void Update()
        {
            CurrentState.Execute(this);
        }
        public new T GetComponent<T>()where T: Component
        {
            if (_cachedComponents.ContainsKey(typeof(T)))
            {
                return _cachedComponents[typeof(T)] as T;
            }
            var component = base.GetComponent<T>();
            if (component != null)
            {
                _cachedComponents.Add(typeof(T), component);
            }
            return component;
        }
    }
}
