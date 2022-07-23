# Low-Budget-Paint-Application
A very small C# project, developed in Visual .Net, that I worked on while pulling a few all-nighters back in high school and that shares some of the features found on the Paint software on Windows.

The features available in this knock-off version of Paint:
* a color picker is provided so that the user can choose the desired color for their brush
* the user can change the thickness of the brush by entering the number of pixels the thickness should be in a designated text field
* the user can free-hand draw, draw a line, a circle or a rectangle
* in the case the user chooses to draw a circle, the coordinates of the center of the circle will be displayed on the right side of the window
* in the case the user chooses to draw a rectangle, the width and height measurements of the shape will be displayed
* at any given point, the coordinates of the mouse cursor on the screen are displayed on the right side of the window
* the user has the option to erase the entire drawing surface

## Bugs that I got reminded of before uploading the project here and that I should probably fix in the future :)
* if there is something drawn on the screen, and the user changes the mode of drawing (for example, if a circle was drawn, but now the user wants to switch to drawing a rectangle), the previous drawing will be instantly erased upon selecting the new drawing mode -> therefore I should stop the drawing surface from refreshing itself when a new drawing option is selected
