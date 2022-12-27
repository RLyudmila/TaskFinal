# Задача

Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо  равна 3 символа. Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями. Лучше обойтись исключительно массивами.
# Описание алгоритма решения

1. Объявляем два массива: изначальный и вторый такой же длины.
2. Потом метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия ( <=3 ), если условие истинно элемент первого массива заносится в count элемента второго массива. Переменная count для того чтобы поочередно пересылать из первого массива во второй без пробелов. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется пока не закончится цикл.
3. последний метод - вывод результатат на экран
