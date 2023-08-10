using N21_HT1;

var MyList = new CustomList<int>();


MyList.Add(1);
MyList.Add(2);
MyList.Add(3);
MyList.Add(4);

//AddRange orali qo'shish
MyList.AddRange(5, 6, 7, 8, 9, 10);

Console.WriteLine(MyList);

//Insert 
//MyList.Insert(1, 999); 

//Insert Range Test
//MyList.InsertRange(2, 5, 6, 7);


//MyList.Remove(2); // remove qilish


//MyList.RemoveAt(1); // index bo'yicha o'chirish


//var arrayB = new int[5];
//MyList.CopyTo(arrayB); //exceptionimizga o'tadi sababi arrayB arraysi uzunligi Mylist uzunligidan kichik

//var arrayC = new int[10];
//MyList.CopyTo(arrayC); // arrayC ga MyList elementlarini ko'chirib beradi

//Console.WriteLine(MyList.Contains(5));
//Console.WriteLine(MyList.Contains(103));


//Console.WriteLine(MyList.IndexOf(10)); // 10 soni 9- indexda shuning uchun consolega 9 chiqadi