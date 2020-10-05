***

**Метод** IsAuthenticated - получает true или false в зависимости от того, аутентифицирован пользователь или нет. url - ``/api/isAuth``

***

**Метод** GetPlayerSummary - получает json информацию о пользователе. url - ``/authApi/userInfo/summary``

***

**Метод** GetUserInventory - получает json информацию об инвентаре пользователя. url - ``/authApi/userInfo/getInventory``

***

**Метод** GetInventoryItemInfo - получает полную json иформацию о предмете из ``CSGO`` **Важно** : На вход принимается параметр classId (это уникальный идентификатор предмета)
**classId можно добыть с помощью метода GetUserInventory(там будут находиться неполная информация о предметах в том числе и classId)**. url - ``/authApi/itemsService/getItemInfo?{ПАРАМЕТР classId ОБЯЗАТЕЛЕН}``

***

**Метод** GetInventoryItemsInfo - этот метод похож на предыдущий, но он возвращает несколько предметов по classId. **Внимание** На вход принимается уже не classId, а data, что является json строкой. url - ``/authApi/itemsService/getItemsInfo``

***