# jungfranco.helpers


#Использование библиотеки (как достать ID из ссылки)

```c#
var parse = LinkParser.Parse("wall123_123");

switch (parse.Type)
{
   case TargetData.TypeOfTarget.Chat:
      Console.WriteLine(parse.Id1);
        break;
   case TargetData.TypeOfTarget.Photo:
      Console.WriteLine(parse.Id1 + " " + parse.Id2);
        break;
}
```

#Передвижение формы 
``` C#
using jf = JungFranco.Helpers.Events;
...

jf.MouseDown.Handle = Handle;
MouseDown += jf.MouseDown.MouseOffset;
```

#Ввод только цифр в TextBox
``` C#
using jf = JungFranco.Helpers.Events;
...

textBox1.KeyPress += jf.KeyPress.IsNumber;
```
