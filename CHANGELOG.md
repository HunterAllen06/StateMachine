# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)

## [1.1.0] - October 27th, 2026

### Added

- 'where T : IStateMachine<T>' statements have been added in the following classes:
	- [StateMachineBase.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/StateMachineBase.cs)
	- [StateMachine.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/StateMachine.cs)
	- [NetworkStateMachine.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/NetworkStateMachine.cs)
	- [BaseState.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/BaseState.cs)
	- [IStateMachine.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/IStateMachine.cs)
- Additional members that previously only existed in [BaseState.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/BaseState.cs) were added in [IState.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/IState.cs)
- Added an [Extensions](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/Extensions.cs) class only really meant to be used for classes in the package
- [BaseState.AddTransition(ITransition transition)](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/BaseState.cs#L43)

### Changed

- References to [BaseState<T>](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/BaseState.cs) and [Transition](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/Transition.cs) have been changed to [IState](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/IState.cs) and [ITransition](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/ITransition.cs) respectively in the following classes:
	- [StateMachineBase.cs](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/StateMachine.cs)
- Return type of [StateMachineBase.AddGlobalTransition](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/StateMachineBase.cs#L79) switched from void to [ITransition](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/ITransition.cs)
- [StateMachine](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/StateMachine.cs) is no longer abstract
- [StateMachine.StateMachineBase](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/StateMachine.cs#L11) is now virtual
- [StateMachine.OnInitialize](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/StateMachine.cs#L23) has switched from abstract to virtual
- [NetworkStateMachine.StateMachineBase](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/NetworkStateMachine.cs#L13) is now virtual
- [IStateMachine.StateMachineBase](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/IStateMachine.cs#L5) is now abstract
- [BaseState](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/BaseState.cs) is no longer abstract
- [BaseState.Transitions](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/BaseState.cs#L18) has switched from being a field to being a property

### Fixed

- [BaseState](https://github.com/HunterAllen06/StateMachine/blob/main/Runtime/StateMachine/BaseState.cs) function summaries are no longer incorrect
