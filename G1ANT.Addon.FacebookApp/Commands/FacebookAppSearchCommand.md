facebookapp.search
Syntax
facebookapp.search search ⟦text⟧
Description
This command Search a given element in facebook app.

Argument	Type	Required	Default Value	Description
search	text	yes		Name of product which you want to search
if	bool	no	true	Executes the command only if a specified condition is true
timeout	timespan	no	♥timeoutcommand	Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed
errorcall	procedure	no		Name of a procedure to call when the command throws an exception or when a given timeout expires
errorjump	label	no		Name of the label to jump to when the command throws an exception or when a given timeout expires
errormessage	text	no		A message that will be shown in case the command throws an exception or when a given timeout expires, and no errorjump argument is specified
errorresult	variable	no		Name of a variable that will store the returned exception. The variable will be of error structure
For more information about if, timeout, errorcall, errorjump, errormessage and errorresult arguments, see Common Arguments page.

Note: the facebookapp. commands require opening a mobile app with the facebookapp.open command first.

Example
In this script, facebook app is opened, the robot waits 5 seconds and then login in facebook app using given credential. After that wait for 5 second and search headphone in facebook App:

facebookapp.open 
delay 5
facebookapp.login email xxxxxx pass xxxxx
delay 5
facebookapp.search "headphone"
