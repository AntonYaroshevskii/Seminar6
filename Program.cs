//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
//Console.WriteLine($"Задача 41");
// Console.WriteLine("Введите числа через пробел: ");
// string stringArray = (Console.ReadLine()!);
// counting(stringArray);

// //-------метод подсчета чисел больше 0-----------
// void counting (string numbers){
//     string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int count = 0;
//     for(int i = 0; i < numS.Length; i++){
//         if(Convert.ToInt32(numS[i]) > 0){
//         count ++;
//         }
//     }
// Console.WriteLine($"Пользователь ввел чисел больше нуля ({count}) ");
// }

// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100,
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

// Console.WriteLine($"Задача 43");
// int[] numArray = GetArray(8, 0, 100);
// Console.WriteLine($"[{String.Join(",",numArray)}]");
// increaseArray(numArray);


// //-----метод создания массива-----------
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for(int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// //------метод сортировки массива по возрастанию-------------
// void increaseArray (int[] array){
//     int temp;
//     for (int i = 0; i < numArray.Length - 1; i++){
//         for (int j = i + 1; j < numArray.Length; j++){
//             if (numArray[i] > numArray[j]){
//                 temp = numArray[i];
//                 numArray[i] = numArray[j];
//                 numArray[j] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine($"[{String.Join(",",numArray)}]");

