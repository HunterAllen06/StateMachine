<details>
<summary>Disclaimer</summary>
This repo primarily exists for personal use, and so projects I'm working on that have multiple programmers can share these utility/helper classes. Again, please note that these tools are built for my own projects; <b><ins>this means that they could change in functionality at any time</ins></b>. If you plan on using them long term, I strongly suggest sticking to one version/installing a packing and sticking to it, or paying very close attention to each update/commit. Feel free to use these in your own projects or base your own code off of mine, no credit needed; just don't claim it as your own.
</details>

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
