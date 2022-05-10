## GB_ControlWork

## Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

# Текстовое описание решения контрольной задачи

1. Первоначальный входной массив строк задаём на старте выполнения программы. Создаём сразу-же необходимые переменные :
* Переменную типа структура, состоящую из массива целых чисел размером, равным количеству строк входного массива для хранения получаемой информации о строках входного массива; и переменной, в которой будет сохраняться число строк, длина которых удовлетворяет условию задачи (меньше или равна 3 символам).
* Переменную для сохранения размера входного массива строк.
2. Создаём метод, который будет на вход принимать первоначальный массив строк и структуру, поочереди просматривать строки и заносить в массив структуры 0, если символов в строке больше 3-х и 1 в противном случае, так-же добавляя единицу к переменной структуры для подсчёта строк, удовлетворяющих условию задачи.
3. Создаём второй метод, который на вход так-же принимает первоначально заданный массив и структуру. В этом методе создаём новый массив строк выходных данных, который и будет возвращать метод. На основе данных структуры размер выходного массива делаем равным переменной, содержащей количество строк во входном массиве, удовлетворяющих условию задачи. Далее, поочереди проходя массив информации из структуры будем присваивать выходному массиву поочереди строку из входного массива, если в соответствующей строке массива информации из структуры стоит 1. Если ноль - то пропускаем строку и переходим к следующей. Таким образом заполняем весь выходной массив нужными строками.
4. Выводим полученный выходной массив с консоль. 