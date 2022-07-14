# spaceshipgame
documented making of a spaceship driving game in unity

left engine -> A
right engine -> D
move forward -> A+D

### V1.0
A force of gravity pulls the spaceship to the bottom of the screen. The size of the spaceship is customizable and the rotation will adjust accordingly taking into account engine power and speed. This is calculated with the inverse tangent of the angle of rotation in a triangle formed by the width of the spaceship and the engine power vector. 
![spaceship_01](https://user-images.githubusercontent.com/92323990/179017001-55a358eb-15e8-417a-9d06-aa0ae5b243e8.gif)

### V1.1
A planet is added that pulls the spaceship towards it, with an increased strength if the spaceship is closer to it.
![spaceship_02](https://user-images.githubusercontent.com/92323990/179023256-964e9472-a160-49a6-a771-735eea482f20.gif)
