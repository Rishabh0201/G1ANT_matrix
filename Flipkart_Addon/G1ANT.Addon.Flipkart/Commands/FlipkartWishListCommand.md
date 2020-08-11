# flipkart.wishlist

## Syntax

```G1ANT
flipkart.wishlist type ⟦text⟧
```

## Description
This command add a product in a wishlist of Flipkart.

| Argument | Type | Required | Default Value | Description |
| -------- | ---- | -------- | ------------- | ----------- |
|`url`| [text](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/TextStructure.md) | yes |  | URL of product which you want to add in wishlist |
|`nowait` | [bool](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/BooleanStructure.md) | no | false | By default, waits until the webpage fully loads |
| `if`           | [bool](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/BooleanStructure.md) | no       | true                                                        | Executes the command only if a specified condition is true   |
| `timeout`      | [timespan](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/TimeSpanStructure.md) | no       | [♥timeoutselenium](https://manual.g1ant.com/link/G1ANT.Addon.Selenium/G1ANT.Addon.Selenium/Variables/TimeoutSeleniumVariable.md) | Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed |
| `errorcall`    | [procedure](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/ProcedureStructure.md) | no       |                                                             | Name of a procedure to call when the command throws an exception or when a given `timeout` expires |
| `errorjump`    | [label](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/LabelStructure.md) | no       |                                                             | Name of the label to jump to when the command throws an exception or when a given `timeout` expires |
| `errormessage` | [text](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/TextStructure.md) | no       |                                                             | A message that will be shown in case the command throws an exception or when a given `timeout` expires, and no `errorjump` argument is specified |
| `errorresult`  | [variable](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/VariableStructure.md) | no       |                                                             | Name of a variable that will store the returned exception. The variable will be of [error](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/ErrorStructure.md) structure  |

For more information about `if`, `timeout`, `errorcall`, `errorjump`, `errormessage` and `errorresult` arguments, see [Common Arguments](https://manual.g1ant.com/link/G1ANT.Manual/appendices/common-arguments.md) page.

> **Note:** the `flipkart.` commands require opening a browser with the `flipkart.open` command first.

## Example

In the following example the browser waits until Flipkart webpage is loaded, and After 5 second starts login in Flipkart acount using given credential. open new amazon tab with your product and add it in wishlist:

```G1ANT
flipkart.open 
delay 5
flipkart.login phone xxxxxx Pass xxxx search
delay 5
flipkart.wishlist "https://www.flipkart.com/dragon-war-ele-g9-thor-wired-gaming-mouse/p/itmdtrev54tu7yfe?pid=ACCDTREV54TU7YFE&lid=LSTACCDTREV54TU7YFEJ8PSFR&marketplace=FLIPKART&srno=b_1_7&otracker=dynamic_omu_infinite_Gaming%2B_8_1.dealCard.OMU_INFINITE_Gaming%2B_7YOOF242I05J&fm=neo%2Fmerchandising&iid=49b347f5-a6cf-4ab5-94ce-eed2636824df.ACCDTREV54TU7YFE.SEARCH&ppt=browse&ppn=browse&ssid=jxkmus578g0000001596710095562" search

```
