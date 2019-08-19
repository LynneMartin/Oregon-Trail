# Welcome to the Oregon Trail Adventure!

### Story

A widow decides that Kansas City harbors too many memories of her beloved departed husband, and, in order to move on, must leave and start anew with her young daughter. At church, she overhears talk of a second wave of people leaving in 3 weeks for the wide open spaces of the Western Territories. This is EXACTLY the change she's needing to make in her life, so she heads home to pack up, sells her home to purchase a covered wagon, 2 mules, food and supplies for the trip.

The scene begins in Independence, Missouri, where she meets up with the wagon train to set off towards a new life. They travel through 4 States during this adventure; Nebraska, Wyoming, Idaho, and finally settling in Baker City, Oregon.

The young widow must navigate across swift rivers, come across potentially hostile Natives, avoid starvation and deadly disease, and cross seemingly impossible mountainous terrain before he can reach her destination. Making the right decisions in every situation is vital for survival. One wrong decision and her family can perish! It is a risky and exhausting journey. Can you guide them safely to Oregon?

### Gameplay

Oregon Trail is a simple text-based adventure game. You will need to know the following commands to play.

-	Command `go <direction>`:
	- Moves your player from "room" to "room." Each room represents a State and a challenge you must overcome.
	- Directions: `north`, `south`, `east`, `west`
- Command `take <item>`:
	- If an item can be picked up this command will put the item in your inventory
- Command `use <item>`:
	- Uses an item from your inventory or in the "room."
- Command `look`:
	- Displays the Description of the current "room" or situation.
- Command `inventory`:
	- This command will list of the current items in your inventory.


### Rooms/States

There are four key "rooms" in this story. Entering a room/State will trigger an event. You will need to navigate through the State, avoiding dangerous situations, and pick up the items or supplies necessary to complete your journey at the destination. A basic breakdown of the rooms:

<!-- SECTION The first room/State you enter -->
- Nebraska
	<!-- - Description: "You find yourself in a small hall there doesnt appear to be anything of interest here. <List Exits> You see a passage to the ['North', 'South <key> ? UseKey : "Locked"']", -->

<!-- SECTION Halfway point! -->
- Wyoming
	<!-- - Description: "You see a room with several sleeping guards, The room smells of sweaty men. The bed closest to you is empty and there are several uniforms tossed about."
	- Actions: {
		
		- use bed: "You climb into the bed and pretend to be asleep. A few minutes later several guards walk into the room. One approaches you to wake you... (GUARD) "Hey Get Up! it's your turn for watch, Go relieve Shigeru in the Guard Room" Quickly you climb out of the bed",
		
		- use bed * 2: "(GUARD) What do you think your doing? Hey your not Leroy, Quick Jenkins sieze him.... Jenkins a bit over-zelous swings his sword cleaving you in half... <DEATH MESSAGE>",
		
		- take uniform: "You placed the Guard Uniform in your inventory"
	},
	- Items: ['Guard Uniform'],
	- Exits: ['South'] -->

<!-- SECTION Nearly there!-->
- Idaho
	<!-- - Description: "You step into the large castle courtyard there is a flowing fountain in the middle of the grounds and a few guards patrolling the area 
	- Events
		- <Using Guard Uniform> 
			-"Oi, long night tonight I wish I was in my bed. If your just getting on shift your should go talk to the captain." 
		- <!Using Guard Uniform> 
			- "To your left you see a guard approaching you. (GUARD) Wat who the blazes are you? Quickly he raises the alarm and several of the crossbow men turn and fire on you. You realize you have made a grave mistake as a bolt slams into your body... <DEATH MESSAGE>">"
	
	- Actions: {
	
		- use key: "You approach the door and slide the key into the lock. It clicks, The door can now be opened",

	},
	
	- Items: [],

	- Exits: ['South', 'West', 'North'] -->

<!-- SECTION Final leg of the journey. Don't give up now! -->
- Oregon
	<!-- - Description: "As you approach the captains Quarters you swallow hard and notice your lips are dry, Stepping into the room you see a few small tables and maps of the countryside sprawled out. 
	
	- Events 
		<!-- - <CAPTAIN_IN_ROOM && INVENTORYCHECK !`broken lock`> 
			- The captain on shift greets you (CAPTAIN) New recruit huh. Well lets stick you in the guard room you can't screw things up there. Go relieve (He pauses and glancing at his reports) private Miyamoto.
		- <CAPTAIN_IN_ROOM && INVENTORYCHECK `broken lock`> 
			- "What are you doing back here? I told you to stay in the Guard Room" 
		- <!CAPTAIN_IN_ROOM>
			- "With the captain gone you look around and notice a pouch of vials hung from the back of the chair the captain was sitting at. The vials are holding a green liquid.">",
	
	- Actions: {
	
		- use brocke lock: "What an escaped prisoner... When did this happen? Quick take this (He slams a silver key on the table and jots down a quick note) go fetch a messenger boy for me and have him take this note the Gate Captain Ezio, but keep this quite. If That prisoner is really has escaped it will be both our heads. (CAPTAIN) I'll go rouse the guards, (The captain runs to the door north heading for the Barracks)",
		
		- take key: "Quickly you pocket the silver key"
	},
	- Items: ["key", "note", "vial"],
	- Exits: ['north', 'east'] -->


### Victory Conditions

You will likely succeed or fail in this game. Here are some messages:

- DEATH MESSAGES: 
	- "The Natives don't trust you, so they killed you, your daughter, and your little 		dog, too. And they ate your oxen."
	- "You ran out of food! Your oxen were stolen, and your family dies of starvation."
	- "The water is too high and swift! Your family is swept away and drowns. But your 		oxen escape to safety, so that's nice."
	- "You are out of repair supplies! In harsh mountain weather, your family dies. And 	your oxen eat you."
- Natives Allow Passage: "You succeeded where so many others failed. The Dark Lords' reign of terror is over."
- No Starvation Today: "Sweet relief! Your family are fed and healthy. And your oxen 		won't eat you."
- River Passage: "You made it across the river safely! Onward!"
- Mountain Pass: "Your wagon wheels held up and you reached the other side of the mountain pass in one piece! You are home!"

### Cheaters Guide

Simply put, this is a game that can be completed with the following steps.

<!-- - Go North
- Use Bed // For Points Only
- Take Uniform 
- Use Uniform
- Go South
- Go West
- Go South
- Go West
- Take Tools
- Go North
- Use Hammer
- Take Lock
- Go South
- Go West
- Go West
- Use Lock
- Take Vial
- Go East
- Go North
- Go North
- Go East
- Take Overcoat
- Use Note
- Go North
- Take Key
- Go South
- Go West
- Go South
- Go South
- Go East
- Go North
- Use Overcoat
- Go South
- Go West
- Go North
- Go North
- Use Key // For Points Only 
- Go East
- Go North
- Use Window  -->
