﻿namespace ClassIsland.Core.Models.SettingsWindow;

/// <summary>
/// 代表设置窗口页面的导航附加信息。
/// </summary>
public class SettingsWindowNavigationData
{
    internal SettingsWindowNavigationData(bool isNavigateFromSettingsWindow, bool isNavigateFromUri, Uri? navigateUri)
    {
        IsNavigateFromSettingsWindow = isNavigateFromSettingsWindow;
        IsNavigateFromUri = isNavigateFromUri;
        NavigateUri = navigateUri;
    }

    /// <summary>
    /// 此页面是否从设置页面导航。
    /// </summary>
    /// <remarks>
    /// 如果这个页面使用 Uri 导航，此属性也为 true
    /// </remarks>
    public bool IsNavigateFromSettingsWindow { get; }

    /// <summary>
    /// 此页面是否从 Uri 导航
    /// </summary>
    public bool IsNavigateFromUri { get; }

    /// <summary>
    /// 导航到此页面的完整 Uri
    /// </summary>
    /// <remarks>
    /// 仅当<see cref="IsNavigateFromUri"/>为 true 时，此属性不为空。
    /// </remarks>
    public Uri? NavigateUri { get; }

}