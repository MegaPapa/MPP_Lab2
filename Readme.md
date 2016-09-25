HEADING
===
#��� ������������ �2

---
� ������ ������ ������������ ������ ���������� ����������� ������������� ��������� DTO-�������. �������� � ��������� ������� �������� � JSON �����. ������ �������� ����� ��������� ���������:
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
�������������� DTO-����� ����������� ��������� �������:
```
public sealed class SomethingWicked {
        public int FirstProperty { get; set; }
        public long SecondProperty { get; set; }
        public float ThirdProperty { get; set; }
    }
```