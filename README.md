# Alarm-WindowsForms

基于 WindowsForms 使用 C# 语言实现的简单 Windows 窗体程序——小闹钟。

## 说明

学校作业项目，为方便个人开发以及与同学交流而开源。**不欢迎 PR、Fork 以及抄袭**，请自觉遵守 Apache 协议！

P.S. 我另使用 Xamarin.Form 完成了一个相同功能的**跨平台**实现(iOS、Android、Windows 10 UWP)，详见 [cdfmlr/MyClock](https://github.com/cdfmlr/MyClock)。

## 功能实现

1. 做一个小闹钟窗体应用程序。
2. 具备实时显示数字时钟的功能，方便使用者获取当前的时间。
3. 具备实时绘制表盘时钟的功能，该表盘时钟如下图1所示，根据当前时间再来绘制秒针、分针和时针。
4. 具备整点报时的功能，当处于整点时，系统进行报时。
5. 具备定点报时的功能，根据使用者的设定，进行报时。
6. 把使用者设置的报时时间，记录在文本文件中，系统在启动时，自动加载该文本文件以便获取定点报时的时间。
7. 系统最小化时，缩小为系统托盘。

## Tips

> 由于本人对 C# 语言、Windows 系统、WindowsForms、Visual Studio 都不甚熟悉，故在开发时对解决方案中文件的命名出现了一些意外，解决方案被命名为 `WindowsFormsApp2`，整个 UI 响应被放入 `Form1.cs`, 而其他各类全放入了 `Class1.cs`。

程序主要结构如下：

```
WindowsFormsApp2: 小闹钟程序
    |-- Form1.cs  UI 响应
    |    |-- 在程序载入时绘制界面，读取储存的闹钟数据
    |    |-- 在 Timer Tick (每1秒) 时，调用 update 函数
    |	 |	 动态更新圆盘时钟并检测是否整点报时或闹钟提醒
    |    |-- 在用户添加新闹钟时创建 Alarm 实例
    |	 |	 借助 AlarmDatabase 储存，并写入磁盘
    |    |-- 在用户编辑/删除闹钟时，借助 AlarmDatabase 修改/删除 Alarm 实例
    |	 |	 同时也从磁盘文件中修改/删除数据
    |    |-- 在最小化/关闭时处理最小化到系统托盘
    |-- Class1.cs 相关类
         |-- class Alarm: 闹钟类，代表程序运行时的一个闹钟对象
         |-- class AlarmDatabase: 闹钟数据库
         |      处理将内存中的闹钟数据储存到磁盘以及从磁盘读取已保存的数据
         |-- class TickMarkDrawHelper: 计算表盘刻度坐标的辅助类
```

## 协议

Apache © CDFMLR 2019, 保留一切权利。

