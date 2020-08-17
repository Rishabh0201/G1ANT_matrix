naukriapp.open
Syntax
naukriapp.open appactivity ⟦text⟧ apppackage ⟦text⟧ automationname ⟦text⟧ devicename ⟦text⟧ platformname ⟦text⟧ platformversion ⟦text⟧
Description
This command starts a new naukriapp session.

Argument	Type	Required	Default Value	Description
appactivity	text	yes		Starting activity of the automated application
apppackage	text	yes		Package of the automated application
automationname	text	no	UiAutomator2	Name of the automating driver
devicename	text	yes	Android	Name of your device to be automated
platformname	text	yes	Android	Name of the automated platform
platformversion	text	no		Version of the automated platform
if	bool	no	true	Executes the command only if a specified condition is true
timeout	timespan	no	♥timeoutcommand	Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed
errorcall	procedure	no		Name of a procedure to call when the command throws an exception or when a given timeout expires
errorjump	label	no		Name of the label to jump to when the command throws an exception or when a given timeout expires
errormessage	text	no		A message that will be shown in case the command throws an exception or when a given timeout expires, and no errorjump argument is specified
errorresult	variable	no		Name of a variable that will store the returned exception. The variable will be of error structure
For more information about if, timeout, errorcall, errorjump, errormessage and errorresult arguments, see Common Arguments page.

Example
This simple script opens a default Google Calculator naukriapp:

naukriapp.open apppackage com.android.calculator2 appactivity com.android.calculator2.Calculator
