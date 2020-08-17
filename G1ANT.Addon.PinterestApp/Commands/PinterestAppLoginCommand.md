pinterestapp.login
Syntax
pinterestapp.login email ⟦text⟧ pass ⟦text⟧
Description
This command login in the pinterest app.

Argument	Type	Required	Default Value	Description
email	text	yes		Provide Email id
pass	text	yes		Provide login password
if	bool	no	true	Executes the command only if a specified condition is true
timeout	timespan	no	♥timeoutcommand	Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed
errorcall	procedure	no		Name of a procedure to call when the command throws an exception or when a given timeout expires
errorjump	label	no		Name of the label to jump to when the command throws an exception or when a given timeout expires
errormessage	text	no		A message that will be shown in case the command throws an exception or when a given timeout expires, and no errorjump argument is specified
errorresult	variable	no		Name of a variable that will store the returned exception. The variable will be of error structure
For more information about if, timeout, errorcall, errorjump, errormessage and errorresult arguments, see Common Arguments page.

Note: the pinterestapp. commands require opening a mobile app with the pinterestapp.open command first.

Example
This sample script opens pinterest app application, then login in it using given credential. After 3 seconds the robot closes the session:

pinterestapp.open 
pinterestapp.login email xxxxx pass xxxxx
delay 3
pinterestapp.close
