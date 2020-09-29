This scene contains several cubes frozen in time. When the game starts Time.TimeScale is set to 0. 
When you press E, the GameStart GameEvent is raised by the GameEventSender.
The GameStart event then calls the OnEventRaised() function on its listener, which is attached to the GameEventReceiver.
The Listener on the GameEventReceiver then calls the function set in the inspector on its attached script, which sets Time.TimeScale to 1.
When Time.TimeScale is set to 1, the game starts and the cubes fall.

You can send this event via the GameEventSender by pressing "E", or via the GameStart GameEvent itself by pressing the "Raise Event" button in the inspector.