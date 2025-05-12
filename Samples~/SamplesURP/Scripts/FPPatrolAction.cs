namespace FuzzPhyte.FSM.Samples
{
    using UnityEngine;
    using UnityEngine.AI;
    [CreateAssetMenu(fileName = "FPPatrolAction", menuName = "FuzzPhyte/FSM/Action/FPPatrolAction")]
    public class FPPatrolAction : FSM_BaseAction
    {
        public override void Execute(FP_BaseStateMachine stateMachine)
        {
            var navMeshAgent = stateMachine.GetComponent<NavMeshAgent>();
            var patrolPoints = stateMachine.GetComponent<FPPatrolPoint>();

            if (patrolPoints.HasReached(navMeshAgent))
                navMeshAgent.SetDestination(patrolPoints.GetNext().position);
        }
    }
}
