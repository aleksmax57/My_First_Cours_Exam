# My_First_Cours_Exam

## Задача

Написать програму, которая из имеющегося массива строк формирует новый массив
из строк, длина которого меньше либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

### Условия

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделете её в отдельный метод)
3. Снабдите репозиторий сформированным текстовым описанием решенияя (файл README.md)
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе рад этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2. 3 и 4 должны бть расположены в разных коммитах).

### Решение

1. Создём пустой массив строк для хранения информации.
2. Вводим исходный массив строк с клавиатуры или задаём его в коде программы.
3. Создаём цикл for, который будет проводить итерации по элементам исходного массива.
4. Внутри цикла проверяем длину текущей строки с помощью свойства Length. Если длина меньше 4, то добавляем строку в новый массив.
5. После завершения цикла выводим новый массив строк на экран.
