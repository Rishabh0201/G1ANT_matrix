lineapp.open ```

Description
This command initialises (open) line app.

Argument	Type	Required	Default Value	Description
appactivity	text	no	com.amazon.micron.StartupActivity	Starting activity of the automated application
apppackage	text	no	in.amazon.mShop.android.shopping	Package of the automated application
automationname	text	no	UiAutomator2	Name of the automating driver
devicename	text	no	Android	Name of your device to be automated
platformname	text	no	Android	Name of the automated platform
platformversion	text	no		Version of the automated platform
if	bool	no	true	Executes the command only if a specified condition is true
timeout	timespan	no	♥timeoutcommand	Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed
errorcall	procedure	no		Name of a procedure to call when the command throws an exception or when a given timeout expires
errorjump	label	no		Name of the label to jump to when the command throws an exception or when a given timeout expires
errormessage	text	no		A message that will be shown in case the command throws an exception or when a given timeout expires, and no errorjump argument is specified
errorresult	variable	no		Name of a variable that will store the returned exception. The variable will be of error structure
For more information about if, timeout, errorcall, errorjump, errormessage and errorresult arguments, see Common Arguments page.

Example
This simple script opens a line app:

lineapp.open
