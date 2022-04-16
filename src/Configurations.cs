﻿using Sunny.UI;
using System;
using System.IO;

namespace SeewoHelper
{
    public static class Configurations
    {
        /// <summary>
        /// <see cref="SeewoHelper.FileSorterConfig"/> 配置
        /// </summary>
        public static readonly Configuration<FileSorterConfig> FileSorterConfig = new(Path.Combine(Constants.ConfigurationDirectory, "FileSorterConfig.json"), new(ExtraFileSortingWay.None, Array.Empty<FileSortingInfo>()));

        /// <summary>
        /// <see cref="SeewoHelper.UISettings"/> 配置
        /// </summary>
        public static readonly Configuration<UISettings> UISettings = new(Path.Combine(Constants.ConfigurationDirectory, "UISettings.json"), new UISettings(UIStyle.Blue, LogLevel.Info, false, false, true, true));
    }
}
