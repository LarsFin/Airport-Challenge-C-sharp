# Airport Challenge ~ C#

Attempting to TDD the Airport challenge in C#, see user stories below;

Can land planes at airport and determine they are present at the airport [✓]
```
As an air traffic controller 
So I can get passengers to a destination 
I want to instruct a plane to land at an airport
```

Can takeoff planes and determine they are no longer at the airport [✓]
```
As an air traffic controller 
So I can get passengers on the way to their destination 
I want to instruct a plane to take off from an airport and confirm that it is no longer in the airport
```

Can't takeoff planes while weather is stormy [ ]
```
As an air traffic controller 
To ensure safety 
I want to prevent takeoff when weather is stormy 
```

Can't land planes while weather is stormy [ ]
```
As an air traffic controller 
To ensure safety 
I want to prevent landing when weather is stormy 
```

Can't land a plane when the hangar is full [ ]
```
As an air traffic controller 
To ensure safety 
I want to prevent landing when the airport is full 
```

Default capacity for airports that can be set upon instantiation [ ]
```
As the system designer
So that the software can be used for many different airports
I would like a default airport capacity that can be overridden as appropriate
```

---

Using Moq, installed using Nuget (packet manager for visual studios). 


The code below creates a mock instance of the Plane class. 
```
var mockPlane = new Mock<Plane>("TestPlane")
```

So with moq something interesting that I learnt is that you can only override virtual methods. So on the Land() method within the Plane class
I had alter it to be virtual. 

```
public virtual void Land()
        {
            flying = false;
        }
```

Just downloaded StyleCop for my VS. I now have 129 warnings to go through which should be interesting.
StyleCop checks through your files to make sure you are following C# conventions. I thought it would be wise
to check them out to ensure that the code is readable to other programmers.

download StyleCop here;

https://marketplace.visualstudio.com/items?itemName=ChrisDahlberg.StyleCop

To run StyleCop either go to the tools in the HUD or alternatively *Ctrl + shft + Y* for shortcut.
Although pedantic in the case of doing the airport challenge Documentation headers seem an interesting
way of showcasing method intentions and also making code easier to read and learn from. 