//External Functions for Unity

EXTERNAL EndGame()


// Stat Variables

VAR energy = 8
VAR comfort = 5
VAR hunger = 2
VAR bladder = 10
VAR hygiene = 5


// Initialize Unity UI

~ energy = 8
~ comfort = 5
~ hunger = 2
~ bladder = 10
~ hygiene = 5



-> morning


/*--------------------------------------------------------------------------------

	Start the demo!

--------------------------------------------------------------------------------*/

=== morning ===
#location: apartment
#time: morning

{MorningWakeUp()}
+ [Get Out of Bed]
    You pushed yourself up out of bed. {MorningCondition()}
-
+ [Get Ready]
    You brush your teeth and take your medicine like normal, then turn your attention to food. 
    \-----
    You lost 1 Energy from getting ready.
    ~ energy -= 1
    
-
+ [Eat] -> breakfast


= breakfast

What would you like to eat for breakfast?

+ [Prepacked Meal]
	     {~You settled on cereal this morning. It’s quick and it’s easy. | It's a toast kind of morning. {~This time with butter.| A quick swipe of peanut butter makes all the difference. | Some jelly on top adds just enough sweetness.} | Just a container of yogurt should be fine.} 
	     \-----
	     You lost 5 Bladder from eating. 	     
	     ~ bladder -= 5
	     You gained 3 Hunger from eating. 
	     ~ hunger += 3
	     
+ [Recipe]
	    
	    {~Today was a pancake morning. Sure, you’re a bit tired now but nothing beats the smell of freshly cooked pancakes. | You're exhausted already, but that omlette sure was worth it.}
	    \-----
	    You lost 2 Energy from cooking.
	    ~ energy -= 2
	    You lost 5 Bladder from eating. 
	    ~ bladder -= 5

	    You gained 5 Hunger from eating.
	    ~ hunger += 5
	    You gained 2 Comfort from the homecooked meal.
	    ~ comfort += 2


- 
+ [Continue Getting Ready] -> shower


= shower

- You still have some time this morning. 
Would you like to take a shower? 
+ [Yes]
    
    Ah, that was a wonderful shower. You feel a bit more tired, but you’re clean and ready to face the day. It felt great. Now it’s time to get dressed and head out.
    \-----
    You lost 2 Energy from taking a shower.
    You lost 1 Energy from getting dressed. 
    ~ energy -= 3
    You gained 2 Comfort and 5 Hygiene from taking a shower.
    ~ comfort += 2
    ~ hygiene += 5
    #showerSFX
    
    
+ [No]
    No time for a shower this morning. You’d rather just get to work. You get dressed as normal and head to work. 
    \-----
    You lost 3 Hygiene from not taking a shower.
    You lost 1 Energy from getting dressed.
    ~ hygiene -= 3
    ~ energy -= 1

- 
+ [Leave for Work]
Looks like it's time to go to work!
{
- energy <= 2:
You're exhausted. You only have {energy} Energy left. Just go back to bed.
- energy <= 5:
You only have {energy} Energy left and you haven't even left the house. It's going to be a rough day.
- energy > 5:
Well, you have {energy} Energy right now. Not the worst start you've had to your day.

}
-
+ [Restart]
{ResetStats()}
-> morning
+ [End]
{EndGame()}
-> DONE

-> END







/*--------------------------------------------------------------------------------

    Variety Functions -- Morning

--------------------------------------------------------------------------------*/

=== function MorningWakeUp
~ temp randomNumber = RANDOM(1, 3)
{ randomNumber:
- 1:
You wake up to your alarm blaring.
- 2: 
You wake up before your alarm, looking over just in time to see it start beeping.
- 3:
You woke up to your alarm, sort of. Actually, you smashed the snooze button once. Just enough for some extra sleep but not enough to change your morning routine.
\-----
You gained 1 Energy from a little extra sleep.
~ energy += 1
}
 

=== function MorningCondition
~ temp randomNumber = RANDOM(1, 3)
{ randomNumber:
- 1:
Your muscles ache, but nothing more than usual. 
- 2: 
You actually feel pretty good this morning, for once.
\-----
You gained 1 Comfort from feeling good.
~ comfort += 1
- 3:
You feel really groggy, must not have slept well. 
\-----
You lost 2 Energy from not sleeping well.
~ energy -= 2
}


/*--------------------------------------------------------------------------------

    Stat Update Functions

--------------------------------------------------------------------------------*/


=== function ResetStats
~ energy = 8
~ comfort = 5
~ hunger = 2
~ bladder = 10
~ hygiene = 5


/*--------------------------------------------------------------------------------

	Fallback External Functions

--------------------------------------------------------------------------------*/


=== function EndGame()
~ return
