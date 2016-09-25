СПП лабораторная №2
===
#HEADING

---
В рамках данной лабораторной работы необходимо реализовать многопоточный генератор DTO-классов. Перечень и структура классов задаются в JSON файле. Данный документ имеет следующую структуру:
```
{
    "classDescriptions": [
        {
            "className": "SomethingWicked",
            "properties": [
                {
                    "name": "FirstProperty",
                    "type": "integer",
                    "format": "int32"
                },
                {
                    "name": "SecondProperty",
                    "type": "integer",
                    "format": "int64"
                },
                {
                    "name": "ThirdProperty",
                    "type": "number",
                    "format": "float"
                }
            ]
        },
        {
            "className": "SomethingGood",
            ...
        }
    ]
}

```
Результирующий DTO-класс представлен следующим образом:
```
public sealed class SomethingWicked {
        public int FirstProperty { get; set; }
        public long SecondProperty { get; set; }
        public float ThirdProperty { get; set; }
    }
```