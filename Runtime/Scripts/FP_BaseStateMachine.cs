namespace FuzzPhyte.FSM
{
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    public class FP_BaseStateMachine : MonoBehaviour
    {
        public FSM_BaseState CurrentState { get; set; }
        //base state reference
        [Tooltip("Base State")]
        [SerializeField]
        protected FSM_BaseState _initialState;
        protected Dictionary<Type, Component> _cachedComponents;
        
        public virtual void Awake()
        {
            CurrentState = _initialState;
            _cachedComponents = new Dictionary<Type, Component>();
        }
        public virtual void Update()
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
