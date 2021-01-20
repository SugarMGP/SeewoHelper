﻿using Sunny.UI;

namespace SeewoHelper
{
    /// <summary>
    /// 提供 <see cref="Sunny.UI.UIMessageBox"/> 类下相关的扩展方法
    /// </summary>
    internal class MessageBoxExtensions
    {
        /// <summary>
        /// 显示提示框
        /// </summary>
        public static bool Show(string text, string caption, bool showMask = false, UIMessageBoxButtons buttons = UIMessageBoxButtons.OK)
        {
            return UIMessageBox.Show(text, caption, Program.style.ProgramStyle, buttons, showMask);
        }

        /// <summary>
        /// 显示询问信息提示框
        /// </summary>
        public static bool ShowAsk(string text, bool showMask = false)
        {
            return Show(text, "询问", showMask, UIMessageBoxButtons.OKCancel);
        }

        /// <summary>
        /// 显示错误信息提示框
        /// </summary>
        public static void ShowError(string text, bool showMask = false)
        {
            Show(text, "错误", showMask);
        }

        /// <summary>
        /// 显示信息提示框
        /// </summary>
        public static void ShowInfo(string text, bool showMask = false)
        {
            Show(text, "提示", showMask);
        }

        /// <summary>
        /// 显示成功信息提示框
        /// </summary>
        public static void ShowSuccess(string text, bool showMask = false)
        {
            Show(text, "成功", showMask);
        }

        /// <summary>
        /// 显示警告信息提示框
        /// </summary>
        public static void ShowWarning(string text, bool showMask = false)
        {
            Show(text, "警告", showMask);
        }
    }
}
