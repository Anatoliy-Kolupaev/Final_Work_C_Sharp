## Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

# Решение:

## Ввод  массива из строк:
*Первоначальный массив можно ввести с клавиатуры, либо задать на старте.* Данное условие реализовано следующим образом: 

Данное условие реализовано при помощи ввода с клавеатуры **Y** или **N**.

- При вводе **Y** программа запросит ввести количество элементов массива которые хочет ввести пользователь. Далее пользователь будет вводить поэлементно то кол-во элементов которе указал. Тем самым заполнит массив.

- При вводе **N** первоначальный массив будет задан **["hello", "2", "world", ":-)"] -> ["2", ":-)"]**

## Метод CheckArray:
Данный метод проверяет и считает количество элементов, размер которых *меньше либо равна 3 символам*.

- Счет осуществляется передором массива **array** и сравнением с **lenhtMax** = 3.
 
- Полученный результат сохраняется в переменную **index**

Далее содаем новый массив **newArray** длинной равной **index**

## Метод FillArray:
Данный метот заполняет массив строк на основании условя задачи. (*длина которых меньше либо равна 3 символа*)

- Заполнение осуществляется перебором массива **array** с проверкой условия **lenghtMax** и добовлением элементов в массив **newArray**

- Получаем заполненный массив **newArray** удовлетворяющий условия задачи.

## Метод PrintArray:
Данный метод выводит на экран массив строк.

- Используется в программе несколько раз, для того чтобы увидеть первоначальный массив и ожидаемый результат