VOCABULARY
	Horizontal - Left to right
	Vertical - Up and down
	Rows - a horizontal group in a grid
	Column - a vertical group in a grid
	Flag - a switch we turn on and off to represent that something happened


Variables are words that hold data
	Variables are TYPE then NAME

Four basic variable types
	int - numbers (1, -500, 6728)
		ex: counting, numbers that can't be less than a whole
	float - numbers w/ decimal point (1.5, -2.333, 10.0, 67.28444)
		ex: speeds, time, things that can be cut into smaller piece
	string - any text! Words, numbers, spaces, characters, anything!
		ex: words, if it can be sent in a text, it is a string!
	bool - true or false.
		ex: yes or no, on or off, between two choices, "IS", "IF"

Common Object Types
	MonoBehaviour -  a script that goes on an object
	Vector2 - positions, min/max
	GameObject - an object in the game
	AudioSource - Makes sound
	Rigidbody2D - Handles movement

SYMBOLS and WHAT THEY MEAN
	MATH SYMBOLS
	* means MULTIPLY
	/ means DIVIDE
	++ means ADD 1(pat++ adds 1 to pat)
	-- means SUBTRACT 1 (pat-- lowers pat by 1)
	+= means INCREASED BY (pat += rick adds rick to pat)
	-= means DECREASED BY (pat -= 10 takes 10 away from pat)

	LOGIC SYMBOLS
	== means IS EQUAL TO
	! means NOT (!happy = not happy)
	&& means AND
	|| means OR
	!= means IS NOT EQUAL TO
	< means LESS THAN
	> means GREATER THAN
	<= means LESS THAN OR EQUAL TO (3 is <= 3 and 3 <= 4)

Words in quotes are a string
	This tells the computer to just use the word, not the variable	
    //say your age - 30
    //say "your age" - your age

INPUT
	MOVEMENT
	float x = Input.GetAxis("Horizontal");	//Reads the players left and right (arrow keys, a-d, control stick) -1 - 1
    float y = Input.GetAxis("Vertical");	//Reads the players up and down (arrow keys, w-s, control stick) -1 - 1
	BUTTONS
	Input.GetButtonDown()

COMPONENTS
	Rigidbody - Lets our object move and be moved by other objects
	Collider - Makes our object touchable. 

COLLIDERS
	Collider: The part of an object you can touch
	Trigger: A Collider you can ENTER. Used for zones, "step on this button", 

PREFABS
	Premade objects you can drag a copy of into your game. You make it so you can reuse it
	Ex: Enemies, coins, world objects, 

GAME EVENTS
	GameEvents are messages that your code can say out loud
		Each GameEvent is its own speific file that you make and name
	GameEventListeners hear those messages and do whatever it is they do when they hear it

SCRIPTABLEOBJECTS: 
	A file you make that holds information.
	Multiple scripts can use the same file

DOING MATH
	MULTIPLICATION *
	DIVISION /
	How to ADD ONE to a variable!
		nameOfYourVariable++; (ex: i++; coins++; score--;)
	How to INCREASE a variable by an amount
		nameOfYourVariable += value; (ex: a +=5; a +=b;)

IMPORTANT FACTS
	Counting starts at 0
		0	1	2	3
		A	B	C	D

	The . is how you get or use an object in code
		jenny.age
		dog.breed
		toaster.Toast();

LISTS
	A List is a number list of objects

	LISTS START COUNTING AT 0
	A LIST WITH 5 OBJECTS GOES FROM 0 TO 4

	INDEX: An object's number in the list

	To get something from a list
	the name of the list[the index number]
		ex: months[11] (this returns DECEMBER)
		ex: cookies[2] (this returns the THIRD cookie)
		ex: alphabet[0] (this would be the letter A)


DICTIONARY
	A Dictionary is a group of objects sorted by something other than numbers in order
		ex: A word dictionary is definitions sorted by words
		the dictionary doesn't go 1. aardvark 2. aardvarks

Properties 
	- Properties are what your script HAS
	- All properties are variables
	- Always lowercase
	- Only properties can be public
	- If it says public, protected, or private, it's a PROPERTY
	- Properties are the first lines of code in the class
	- "The Top of the Script" is where the properties are
	- The NAME of the property is the word in white

	How to get a property
		name.property

Functions 
	- what your script DOES or CAN BE DONE TO IT
	- Functions are always Capitalized
	- Always have ()
	- They contain a list of instruction to complete their task
	- Saying the name of the task instead of the steps

	Function Header: The top part of the Function
		ex: public int CountContents(Box box)	//tells you how much is in the box
	1. public, protected, private
	2. What this function GIVES YOU, or void if it gives you nothing
	3. Name of the Function with a Capital Letter
	4. Inside the () are the Parameters

COMPARISON
	|| OR 
		If the choice has an OR that means EITHER ONE can be true
		Are you Tommy || Patrick? YES
	<= 0
		0 or any number less than 0

{ BRACES }
	The braces are the beginning and the end of a section of code
	They are the BREAD that holds the meat of code sandwiches
	Braces will always show a dotted line between them

HOW TO MAKE YOUR CODE WAIT
	Invoke
	{
		Invoke("name of the function", how long we are waiting)
			ex: Invoke("Explode", timer);
			ex: Invoke("TimesUp", 60);
	}

LOOPS - Code that is done repeatedly	
	for loop
		repeats code a set number of times
		Type for and hit tab twice
		If you change the first i it will change the rest
		replace "length" with the number you are going up to

	foreach loop - for going through a list
	Lets you go through all of the items in a list
	Type foreach and hit tab twice!

	while loop - for doing code while something is true
	type while then hit tab 2 times
	great for removing things from a list

TRANSFORM
	The Transform has an object's position, scale, and rotation

	transform.position tells you where this object is

	PARENTING an object means making something hold it
	A PARENT holds a CHILD
	When the PARENT moves, the CHILD moves
	The CHILD can move without the PARENT moving
		Ex: Arm and a Hand

CHECKING THINGS
	We use the if-statement to check to see if something is true
	when the statement inside of the if is true, the code is run
	ex:
		if(age >= 18)
		{
			You can see an R-rated movie
		}
	Add else if when there is a second option

	Add else when there is a default option

CHECKING THINGS WITH ?
	A quick way to write an if statement that has TWO OPTIONS in one line
	
	PATTERN:
		____________________ ? _______ : _______;
		what we are checking ? optionA : optionB
	
	YOU DO NOT NEED TO WRITE IF!

	Ex: If you order dinner before 4:00pm it is cheaper
	float costOfDinner = time < 4:00pm ? $10.00 : $12.50;
	
	You can use this to check if something is null

	PATTERN:
		thing you want to know if you have ? if you have it: if you don't have it

RULES FOR CHECKING THINGS
	the basic types always return SOMETHING
		int and float always give a number
		string returns text, even if it is " " empty
		bool ALWAYS returns TRUE or FALSE. NO EXCEPTIONS
	Everything else will return itself or NOTHING, which we call null
		Ex: Everybody in the world is capable of wearing a hat. Everyone has a property called hat. 
		If they are wearing a hat, then their hat property holds that hat. 
		If they are NOT wearing a hat, then their hat property holds null, which means empty
		

RAYCASTING
	A RAY is an ARROW

	The direction from point A to B is
	B - A

	A Raycast is an invisible laser that can tell you what it hit
	Raycasts come in many shapes!
	They are used to detect if something is nearby without having to make a new object in Unity
	The Raycast will give you this information
	- What you hit
	- How far away it was
	- How MANY things it hit (if you ask for that)
	- Where it hit it

KEYBOARD SHORTCUTS
	CTRL moves through text faster
	SHIFT selects groups of text
	CTRL+SHIFT moves and selects groups of text

	HOTKEYS
	C Copy
	X Cut
	V Paste
	S Save
	A All (selects every line of text)
	D Duplicate (UNITY EDITOR ONLY)
	F Find

HOW TO GET A RANDOM NUMBER
	FOR INTS
		Random.Range(lowest number you want, highest number you want plus 1);
		ex: Random.Range(0,10) returns 0,1,2,3,4,5,6,7,8,or 9

	FOR FLOATS
		Random.Range(LOW #, HIGH #)
		ex: Random.Range(1,5) returns 1, 2, 3, 4, or 5

LERP
	Lets you find a specific point between two points

	Time.deltaTime tells you how much time has passed since the last frame

UPDATE AND FRAMES
	60 FPS means 60 frames per second
	frames per second means that you are running your code 60 times every second that passes
		ex: if your code said "hello", it would say hello 60 times in one second

	if we run our code for only HALF OF A SECOND, how many frames will be run?
		60fps for 1/2seconds would run 30 times

MATHF
	MathF does Math for you on Floats (that's what f means)
	Clamp = Keeps a number between two numbers

Why White?
	If we have an object that we want to be able to change the color of
	We make sure that the color of the object's picture is white
	In Unity you can change the color of anything, doesn't matter what, but the colors will always MIX
	For example, if your picture is of something yellow and you set its color to be blue, the colors will mix and instead it will be green
	If the picture is WHITE then the color will be mixed with white and thus not change at all

CREATING AND DESTROYING
	CREATE
		You can't create, only make copies!
		INSTANTIATE means to make a copy
		Instantiate(what, where, rotation);

	DESTROY
		Destroy(name of the object);
		If you want to wait before Destroying...
		Destroy(name of the object, how long to wait);
		
enum (enumerated type)
	An enum is a type (like string or int) that YOU set the values of 

	Ex: Direction can be North, South, East or West
	Ex:	CarGear: Drive, Reverse, Neutral, Park

SCOPE
	The SCOPE of a variable is who can use it
	public variables (called properties) can be used by everyone
	private variables can only be used inside of the same script
	LOCAL variables are only used in the functions they are in

AXES
	2D = Two dimensional = two axes of movement
	An axis is a set of two directions that you can move between
	The X axis of movement is left and	right
	the Y axis of movement is up and  down
	The Z axis of movement is forwards and backwards

INHERITANCE
	Inheritance is when one script does what another script does but in a different, specific way

	The more generic top script is the PARENT
	The more specific inheriting script is the CHILD

	virtual: A function the parent has that a child can do differently
	override: How to change how a virtual function is done

	Ex: Animal.cs is the PARENT script
		- public virtual void Eat()
		- public virtual void Move()

		Bird.cs is a CHILD script
		- public override void Move() is changed to be flying code

		Mosquito.cs is a CHILD script
		- public override void Eat() is changed to be blood sucking

THE CONDITIONAL OPERATOR ?
	Lets you assign a variable based on a condition
	It's the same as using if() but quicker

	variable = condition ? ifTrue : ifFalse;

	If the condition is true, the variabel is equal to whatever "ifTrue" is, and vice versa

	int dozen = isABaker ? 13 : 12;

	bool canSeeRMovie = customer.age >= 18 ? true : false;


These are our stats:
	health
	speed
	size
	dist
	power
	rate
	force
