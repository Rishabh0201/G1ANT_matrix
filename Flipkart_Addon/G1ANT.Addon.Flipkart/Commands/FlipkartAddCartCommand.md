# flipkart.addcart

## Syntax

```G1ANT
flipkart.addcart type ⟦text⟧
```

## Description
This command is used to add specified product in a cart of flipkart.

| Argument | Type | Required | Default Value | Description |
| -------- | ---- | -------- | ------------- | ----------- |
|`url`| [text](https://manual.g1ant.com/link/G1ANT.Language/G1ANT.Language/Structures/TextStructure.md) | yes |  | Webpage address to load |
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

In the following example the browser waits until Flipkart webpage is loaded and After 5 second starts login in Flipkart acount using given credential. and open new Flipkart tab with your product and add it in your cart:

```G1ANT
flipkart.open 
delay 5
flipkart.login email xxxxxx Pass xxxx search
delay 5
flipkart.addcart "https://www.flipkart.com/anchor-panasonic-14091bk-pedestal-whirl-storm-450mm-fan-two-blades-black-speed-2500-rpm-450-mm-2-blade-fan/p/itm0c24d7e0b7775?pid=FANFRBZBZYFHZGNP&lid=LSTFANFRBZBZYFHZGNPQWTIAM&marketplace=FLIPKART&fm=personalisedRecommendation%2Fp2p-same&iid=R%3As%3Bp%3AFANFTPAJFUGNSAKJ%3Bpt%3Ahp%3Buid%3A136dc056-08ee-c1be-fd13-762dce20d5e4%3B.FANFRBZBZYFHZGNP.LSTFANFRBZBZYFHZGNPQWTIAM&ppt=hp&ppn=homepage&ssid=cf7i1e2vrk0000001596649406464&otracker=hp_reco_Recommended%2BItems_3_15.productCard.PMU_V2_Recommended%2BItems_FANFRBZBZYFHZGNP.LSTFANFRBZBZYFHZGNPQWTIAM_personalisedRecommendation%2Fp2p-same_2&otracker1=hp_reco_WHITELISTED_personalisedRecommendation%2Fp2p-same_Recommended%2BItems_DESKTOP_HORIZONTAL_productCard_cc_3_NA_view-all&cid=FANFRBZBZYFHZGNP.LSTFANFRBZBZYFHZGNPQWTIAM" search

```
