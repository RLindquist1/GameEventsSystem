# GameEventsSystem
A modular GameEvent system for Unity.

<h2>Usage</h2>
<p>
  This system is intended to make Unity projects more modular by replacing direct function calls with Events. Rather than a direct object/script reference that has to be set in the editor for each new scene, your prefabs can use <b>GameEvents</b> to interact with each other without needing hard references.
</p>
<p>
  A <b>GameEvent</b> can be created from the Create Asset Menu. Simply right-click in the project tab and you can select "Create->GameEvents" to see the menu. Once you have made a <b>GameEvent</b> you can set its default parameters and <b>Raise</b> it with those parameters from the inspector. These defaults will be used if a script <b>Raises</b> this <b>GameEvent</b> without providing different ones.
</p>
<p>
  To receive <b>GameEvents</b>, you need a <b>Listener</b> component on the same object as the receiving script. This <b>Listener</b> will automatically register itself with the <b>GameEvent</b> system on game start. The <b>Listener</b> component has an Event parameter that can be set to any function on your script that has the appropriate parameters (e.g. an IntVector3EventListener component can call any function with parameters Int, Vector3 in that order. For parameters Vector3, Int you would need a Vector3IntEventListener). The function that you set in the <b>Listener</b> will be called with the default or supplied arguments whenever the <b>GameEvent</b> that you set is <b>Raised</b>
</p>
<p>
  To send <b>GameEvents</b> you need a reference to the <b>GameEvent</b> that you want to <b>Raise</b> in your script. To do this you will need to import the correct namespace. The basic functions are under the "GameEvents" namespace, with extensions containing any two-argument <b>GameEvents</b> for which the first argument matches their type (e.g. "GameEvents/IntExtension" would contain "IntVector2GameEvent" and "IntBoolGameEvent", but NOT "Vector2IntGameEvent" or "BoolIntGameEvent"). To <b>Raise</b> a <b>GameEvent</b>, simply call "<i>yourGameEvent</i>.Raise().
</p>
<p>
  If you do not provide any arguments when <b>Raising</b> a <b>GameEvent</b> that uses them, the Default values set for that <b>GameEvent</b> in the inspector will be used. These values are also used when the "Raise Event" button in the inspector is pressed.
</p>
