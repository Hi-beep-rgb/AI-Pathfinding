//This is a derived class of State
//This means it inherits fields and methods from State.cs

using UnityEngine;

public class RunState : State
{
    //protected float speed;
    //protected float rotationSpeed;


    public RunState(AIScript ai, StateMachine sm) : base(ai, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();

        path.anim.Play("Male_Sword_Walk");
        Debug.Log("entering running state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("exiting running state");
    }

    public override void Update()
    {
        if(path.nma.velocity.magnitude <= 0f)
        {
            sm.ChangeState(sm.idleState);
        }

        //UIscript.ui.DrawText("*** This is the running state ***\n");
        //UIscript.ui.DrawText("Left/Right arrows = Move Sprite");
        //UIscript.ui.DrawText("E = Idle State");
        //UIscript.ui.DrawText("Space = Jump state");
    }

    public override void FixedUpdate()
    {
    }
}
