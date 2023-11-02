# Fall2020_CSC403_Project

                      
                        Fall23_NOOBDAS
                        
Planned User Stories for Sprint 1:
•	As a user, I can win or loss the game.
•	As a user, I can play the game again.
•	As a user, I can increase my health.
•	As a user, I can see my health in the main screen.
•	As a user, I see the enemy disappear after its health is 0.
Detail of Planned Tasks:
•	Create a win pop up with sound track.
•	Create a loss pop up with sound track.
•	Create a 'Play Again' button while displaying the result.
•	Create an 'Exit Game' button while displaying the result.
•	Create healing objects.
•	Create a method to increase the health when player hit the object.
•	Create welcome window.
•	Create a Skin class with all skins.
•	Create a method to update the skin in the game based on selection.
•	Create a box in the top right corner to show health score.
•	Create a method to update the score board when changed.
•	Create a new function to remove the object when health is 0.
•	Add a Sound track to the resources and call 'play' method when enemy died.
Individual Signed Tasks:
Alekhya:
•	Create a win pop up with sound track.
•	Create a loss pop up with sound track.

A new window has been created as part of the implementation, which is automatically triggered when either the player’s or the boss enemy’s health is 0. The game result, window background and the sound track are set based on the game’s result(win/loss).

•	Create a 'Play Again' button while displaying the result.
•	Create an 'Exit Game' button while displaying the result.

Two buttons are inserted into the result window. Play again button restarts the game, while the exit button ends the game.

Sairam:
•	Create healing objects.
As part of this task, a new class – HealingObjects extending existing class BattleCharacter has been created with functions – Image get,set and Color get,set. Two healing object (goldcoin and diamond) are inserted into the game in appropriate positions after adjusting the walls and enemies.
•	Create a method to increase the health when player hit the object.
New conditions are added into method tmrPlayerMove_Tick in frmLevel.cs. When the player hits the healing object, the player health is set to 20 and the object disappears.
	
Vamshi:
•	Create welcome window.
A new window to select skins is created. The application starting point from game window is changed to skin selection/welcome window.
•	Create a Skin class with all skins.
Four buttons with skin as the background image on the welcome window are inserted.
•	Create a method to update the skin in the game based on selection.
Upon selection of the skin (click on skin button), the flow is directed to the frmLevel.cs(game window) and the player image is set to the button’s background image.



Narender:
•	Create a box in the top right corner to show health score.
•	Create a method to update the score board when changed.
As part of this user story, two labels- one of the displaying health bar and one for defining are created in the top right corner of the game. The bar shows the health percentage in green when health is greater than 60% and turns red when health is less than 60%
•	Create a new function to remove the object when health is 0.
Upon hitting the enemy and completing the fight, the enemy is removed.
•	Add a Sound track to the resources and call 'play' method when enemy died.
As the enemy is removed, a sound track is played .


	


 

![image](https://github.com/alekhya-latech/Fall23_NOOBDAS/assets/146388849/3794c0b2-fad3-4d1b-8b75-9d49d18a1e9d)
