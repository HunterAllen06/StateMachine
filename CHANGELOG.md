# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)

## [1.1.0] - October 27th, 2026

### Added

- 'where T : IStateMachine<T>' statements have been added in the following classes:
	- StateMachineBase.cs
	- StateMachine.cs
	- NetworkStateMachine.cs
	- BaseState.cs
	- IStateMachine.cs
- Additional members that previously only existed in BaseState.cs were added in IState.cs
- Added an Extensions class only really meant to be used for classes in the package
- BaseState.AddTransition(ITransition transition)

### Changed

- References to BaseState<T> and Transition have been changed to IState and ITransition respectively in the following classes:
	- StateMachineBase.cs
- Return type of StateMachineBase.AddGlobalTransition switched from void to ITransition
- StateMachine is no longer abstract
- StateMachine.StateMachineBase is now virtual
- StateMachine.OnInitialize has switched from abstract to virtual
- NetworkStateMachine.StateMachineBase is now virtual
- IStateMachine.StateMachineBase is now abstract
- BaseState is no longer abstract
- BaseState.Transitions has switched from being a field to being a property

### Fixed

- BaseState function summaries are no longer incorrect