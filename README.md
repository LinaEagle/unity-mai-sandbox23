# Тамагочи

*Краткое описание проекта и основных особенностей.*

Тамагочи со странным существом из примитивов.
- Android, Windows
- Альбомная ориентация

## GDD
*P.S. Может быть как частью readme, так и отдельным доком. Если второе, нужно убедиться, что к нему есть доступ у рабочей группы и проверяющих.*

### Концепция
Выбираем существо, которое нужно кормить, гладить, а также нужно следить, чтобы ничего с ним не случилось.
### Визуальный стиль
Минималистичный, все объекты состоят из примитивов, но формы узнаваемые, упор на анимации взаимодествия с существом. Интерфейс тоже минималистичный, либо полупрозрачный, либо ориентрированный визуал самой игры.

![ ](References/Tamagochi-ref.png)

### Жизненный цикл
1. Выбрали существо (если есть выбор существа или окраса), даем ему имя.
2. Кормим, гладим и т.д., реагируем на случаные события
3. Существо умирает по какой-либо причине, игрок получает очки за длительность и качество ухода, добавляется запись в историю существ.
4. Возвращаемся к пункту 1.
### Механики и фичи
*На примере концепции модульной разработки опишем механики и фичи. В нашем контексте* 
- *Core - это то, что успеем обязательно*,
- *Additional - постараемся успеть, если будет время*,
- *Juice - вишенка на торте, которая необязательная, но хочется. Постараемся успеть, если будет время.*

![ ](References/modular_development.PNG)

#### Core механики
Существо обладает потребностями, которые игрок должен закрывать действиями. С течением реального времени значения характеристик снижаются, их нужно пополнять действиями.
- голод - нужно кормить. Еда может быть разной, некоторая влияет на радость. Если голод падает до нуля, существо умирает.
- общение - нужно гладить и проводить время с существом.
- радость - нужно играть, некоторые игры влияют на общение
#### Additional механики
- добавить характеристику
    - здоровье - болезни влияют на здоровье, как и некоторая еда, игры и низкие показатели других характеристик. Если здоровье падает до нуля, существо умирает.
- добавить случайные события типа 
    - болезни, 
    - привередливого отношения существа к опредленной еде, 
    - укусов в плохом настроении.
- добавить мини-игры, которые являются действиями игры и общения в существом
#### Juice механики
- Перенести существо в AR. Можно размещать его на поверхности через Plane Detection, добавить Occlusion в iOS.

## Билд
*Ссылка на архив с рабочим билдом под целевую платформу*

[Билд под Win](https://drive.google.com/file/d/1oE2ZX5m1h2943UiBjDg-bg7DRsVxSp--/view?usp=sharing)

## Инструкция по запуску
Инструкция по развертке проекта, если она требуется. Онв не требуется, если достаточно отрыть проект и выбрать опцию **Build and Run**.