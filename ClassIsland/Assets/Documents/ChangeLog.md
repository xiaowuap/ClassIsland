# 新增功能

1.3.2.0 (1.4-Firefly Beta2) 的新增功能

> **您当前正在使用的是 1.4-Firefly 的测试版本，可能包含未完善和不稳定的功能。**

## 集控

您可以将ClassIsland实例加入到集控中，以统一分发课表、时间表等信息，并控制各实例的行为。

[了解更多…](https://github.com/HelloWRC/ClassIsland/wiki/%E9%9B%86%E6%8E%A7)

[#43](https://github.com/HelloWRC/ClassIsland/issues/43)

![1711241863976](pack://application:,,,/ClassIsland;component/Assets/Documents/image/ChangeLog/1711241863976.png)

![1711241942861](pack://application:,,,/ClassIsland;component/Assets/Documents/image/ChangeLog/1711241942861.png)

## 从NTP服务器获取当前时间

ClassIsland现在支持从服务器同步当前的精确时间。您可以前往[【设置】->【基本】](ci://app/settings/general)调整相关设置。

![1711863876445](pack://application:,,,/ClassIsland;component/Assets/Documents/image/ChangeLog/1711863876445.png)

## 朗读提醒内容

在发出提醒时，ClassIsland可以大声读出提醒的内容。此功能默认禁用，您可以前往[【设置】->【提醒】](ci://app/settings/notification)调整相关设置。

![1711241957988](pack://application:,,,/ClassIsland;component/Assets/Documents/image/ChangeLog/1711241957988.png)

***



# 1.3.2.0

> 1.4-Firefly 测试版，可能包含未完善和不稳定的功能。

## 新增功能
- 【应用】从NTP服务器获取当前时间
- 【提醒】支持使用EdgeTTS朗读服务

## 优化与Bug修复
- 【提醒】在播放大于等于一小时的时间时不发出语音（[#51](https://github.com/HelloWRC/ClassIsland/issues/51)）



***


# 1.3.1.0

> 1.4-Firefly 测试版，可能包含未完善和不稳定的功能。

## 新增功能
- 【集控】手动加入集控
- 【集控】拉取与合并档案信息
- 【集控】加载功能限制策略
- 【提醒】朗读提醒内容
- 【帮助文档】加入新增共能内容

## 优化与Bug修复
- 【UI】修复加载动画中版本号被进度条遮挡的问题