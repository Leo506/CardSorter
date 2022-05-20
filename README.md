# CardSorter
Тестовое задание от "Уральский центр систем безопасности"
## Текст задания
Необходимо разработать класс (либо RESTful сервис), предоставляющий интерфейс
+ Создать именованную колоду карт (колода создаётся упорядоченной)
+ Удалить именованную колоду
+ Получить список названий колод
+ Перетасовать колоду
+ Получить колоду по имени (в её текущем упорядоченном/перетасованном состоянии)  

Необходимо спроектировать интерфейсы так, чтобы алгоритм перетасовки мог задаваться через
конфигурацию приложения (путём выбора из «простой» и «эмуляция перетасовки вручную»).  

Необходимо самостоятельно спроектировать API для колоды и все типы данных.  
Примечания:
+ Колоды достаточно хранить в памяти, но подумать о том, как впоследствии работать с БД.
+ Реализацию достаточно сделать для стандартной колоды игральных карт (52 штуки), но
будет плюсом при решении помнить о том, что сортировщику карт всё равно, какую
колоду тасовать.
+ Алгоритм перетасовки достаточно реализовать «простой» (любой, самый быстрый в
реализации); при желании можно реализовать «эмуляцию перетасовки вручную» (колода
делится примерно посередине, части меняются местами, и так много раз).

## Как хранить в бд
"Перетасовщики" после перетасовки возвращают "зерно" (seed), который использовался при перетасовкe. Таким образом в бд не нужно храинить всю колоду.
Достаточно запомнить зерна, количиство перетасовок и "перетасовщиков"

## Как менять "перетасовщиков"
Для того, чтобы изменить способ перетасовки достаточно изменить файл `App.config`. А именно в теге `appSettings` поставить значение `value` в одно из
двух доступных значений: `Simple` и `Human`
