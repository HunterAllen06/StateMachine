[DISCLAIMER](https://gist.github.com/HunterAllen06/100914a4aeb15675c98dd71db1362fa6)
# StateMachine
A <a href="https://en.wikipedia.org/wiki/Finite-state_machine">Finite State Machine</a> system for Unity projects.

## StateMachine
The MonoBehaviour to derive from for state machine behaviour.
```cs
void Start()
{
    var state1 = new State1();
    var state2 = new State2();
    var condition1 = new Condition1();
    var condition2 = new Condition2();

    state1.AddTransition(state2, condition1); // Will transition from state 1 -> state 2 if condition 1 evaluates to true.
    state2.AddTransition(state1, condition2); // Will transition from state 2 -> state 1 if condition 2 evaluates to true.
}
```
