# Your README for A2 HERE


https://github.com/user-attachments/assets/e9087a97-1f34-4a22-91ca-7a84c7ed5e7b

Gameplay Instructions: 
1. Use WASD or arrow keys to move player (green circle).
2. Avoid the red box, which moves from left to right and increases in size as it bounces back and forth.

Build Instructions:
1. Create a Player class.
2. Include the fields x, y, w, h for the Player object. Include the field alive to indicate the Player status.
3. Create methods Draw(), Update(), movement methods, and getters/setters.
4. Draw() draws the Player object as a green circle, Update() moves the object in the positive x-direction while alive is true.
5. Create an Obstacle class.
6. Include the fields x, y, w, h for the Obstacle object.
7. Create methods Draw(), Update(), Bounce(), and getters/setters.
8. Draw() draws the Obstacle object as a red box, Update() moves the object in the negative x-direction, Bounce() changes the sign of the x-direction.
9. Create a Game class
10. Include methods Setup(), Update(), Draw(), KeyDown(), MouseClick(), and Collide().
11. Instantiate a Player object and Obstacle object.
12. Update() calls the respective Update() methods from Player and Obstacle. If an obstacle hits the window, Bounce() is called.
13. Draw() calls the respective Draw() methods from Player and Obstacle.
14. Collide() checks if the player contains coordinates within the bounds of the obstacle coordinates. If true, alive is set to false.
