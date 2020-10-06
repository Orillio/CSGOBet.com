***

**Метод** IsAuthenticated - получает true или false в зависимости от того, аутентифицирован пользователь или нет. url - ``/api/isAuth``

***

**Метод** GetPlayerSummary - получает json информацию о пользователе. url - ``/authApi/userInfo/summary``

***

**Метод** GetUserInventory - получает json информацию об инвентаре пользователя. Сами предметы из инвентаря будут находиться в json в объекте rgInventory 
url - ``/authApi/userInfo/getInventory`` 
![](https://image.prntscr.com/image/CUzzXBSSTPC3DmK2rKnHWw.png)
***

**Метод** GetInventoryItemInfo - получает полную json иформацию о предмете из ``CSGO`` **Важно** : На вход принимается параметр classId (это уникальный идентификатор предмета)
**classId можно добыть с помощью метода GetUserInventory(там будут находиться неполная информация о предметах в том числе и classId)**. url - ``/authApi/itemsService/getItemInfo?{ПАРАМЕТР classId ОБЯЗАТЕЛЕН}``
![](https://image.prntscr.com/image/gfbplHuVStOAq618gKUBjA.png)
### То что будет на выходе этого метода
![](https://image.prntscr.com/image/jxj65qnJQU6tcnOJZJCQyg.png)
***

**Метод** GetInventoryItemsInfo - этот метод похож на предыдущий, но он возвращает несколько предметов по classId. **Внимание** На вход принимается уже не classId, а data, что является json строкой. url - ``/authApi/itemsService/getItemsInfo``

### Пример запроса, который должен приходить на сервер
![](https://image.prntscr.com/image/3yR1qILbRKKbMuUrgWzG7w.png)
#### Где classId1, classId2, classId3 - это предметы, информацию о которых хочешь получить.
***
