pinterestapp.scroll
Syntax
pinterestapp.scroll search ⟦text⟧ by ⟦text⟧ swipedir ⟦text⟧ scrollamount ⟦integer⟧
Description
This command emulates scrolling in a mobile application. If no element is provided as the search argument value, the command scrolls the entire screen. If an element is provided, the screen is scrolled until the desired element becomes visible.

Argument	Type	Required	Default Value	Description
search	text	no		Name of the element to be scrolled
by	text	no		Specifies an element selector: id, accessibilityid, text, partialid, xy, xpath
swipedir	text	no	up	Scrolling direction: up or down
scrollamount	integer	no		Scrolling amount as a percentage of the screen: from 0 to 100
if	bool	no	true	Executes the command only if a specified condition is true
timeout	timespan	no	♥timeoutcommand	Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed
errorcall	procedure	no		Name of a procedure to call when the command throws an exception or when a given timeout expires
errorjump	label	no		Name of the label to jump to when the command throws an exception or when a given timeout expires
errormessage	text	no		A message that will be shown in case the command throws an exception or when a given timeout expires, and no errorjump argument is specified
errorresult	variable	no		Name of a variable that will store the returned exception. The variable will be of error structure
For more information about if, timeout, errorcall, errorjump, errormessage and errorresult arguments, see Common Arguments page.

Note: the appium. commands require opening a mobile app with the appium.open command first.

Example
This script shows scrolling a map in Google Maps. First, the map is scrolled 50 percent in the default direction (up), then, after a 5-second delay, it’s scrolled again, but this time in the opposite direction (down). After another 5-second delay, the app is closed.

Note: If the first scrolling action cannot be seen, increase the first delay — it allows a map to be fully loaded.

pinterestapp.open apppackage com.google.android.apps.maps appactivity com.google.android.maps.MapsActivity
delay 5
pinterestapp.scroll scrollamount 50
delay 5
pinterestapp.scroll swipedir down scrollamount 50
delay 5
pinterestapp.close
