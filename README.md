# translit

Хм не думал что нет пакетов для транслита в nuget.
Исправил это :)


## Usage

Basic usage with default parameter.  By default select Russian codetable to transliterate
```C#
var instance = Fabric.GetInstance();
var result = instance.Transliterate("Тест");
```

With language 
```C#
var sample = "Маск придумав, як відправити пікап Tesla Cybertruck в космос";
var trans = Fabric.GetInstance(Lang.UA);
var actual = trans.Transliterate(sample);
```
### Helpers
Fetching safe string for web. 
```C#
  var teststring = "Марий Эл";
  var result = _trans.Transliterate(teststring).GetWebSafe(); 
```

Transliterate extension. By default create instance of russian table, but you select another language.
```C#
string src = "жыццё";
var actual = src.Translit(Lang.BY)
             .GetWebSafe();
```


## Supported language

- Russian
- Belorussian
- Ukrainian
- Hungary
- Makedony



## Изменения

15 декабря 2019 - Fix typos. Add coverage test's. Add extension method for fast transliterate.

14 декабря 2019 - Добавил поддержку языков, нового фреймворка, примеры кода. 

21 августа 2019 - добавил поддержку .net core
