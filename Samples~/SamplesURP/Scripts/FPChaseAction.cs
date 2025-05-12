namespace FuzzPhyte.FSM.Samples
{
    using UnityEngine;
    using UnityEngine.AI;
    using FuzzPhyte.FSM;
    using FuzzPhyte.Utility;
    [CreateAssetMenu(fileName = "FPChaseAction", menuName = "FuzzPhyte/FSM/Action/FPChaseAction")]
    public class FPChaseAction : FSM_BaseAction
    {
        public override void Execute(FP_BaseStateMachine stateMachine)
        {
            var navMeshAgent = stateMachine.GetComponent<NavMeshAgent>();
            var enemySightSensor = stateMachine.GetComponent<FPEnemySightSensor>();

            navMeshAgent.SetDestination(enemySightSensor.Player.position);
        }
    }
}
