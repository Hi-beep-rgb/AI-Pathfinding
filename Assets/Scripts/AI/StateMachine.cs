using UnityEngine;


//Handles initialisation of states, switching of states
//It handles calling Update and FixedUpdate for the currently active state

public class StateMachine
{
    public State currentState, lastState;

    //declare all states here
    public IdleState idleState;
    public RunState runState;
    public AttackState attackState;


    //constructor
    public StateMachine( AIScript ai )
    {
        //initialise all states here
        idleState = new IdleState(ai, this);
        runState = new RunState(ai, this);
        attackState = new AttackState(ai, this);
    }

    public void Init(State startingState)
    {
        currentState = startingState;
        lastState = null;
        startingState.Enter();
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();

        lastState = currentState;
        currentState = newState;
        newState.Enter();
    }

    public void Update()
    {
        currentState.Update();
    }

    public void FixedUpdate()
    {
        currentState.FixedUpdate();
    }

}
