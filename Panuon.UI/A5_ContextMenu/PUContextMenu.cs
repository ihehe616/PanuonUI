﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI
{
    public class PUContextMenu : ContextMenu
    {
        static PUContextMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PUContextMenu), new FrameworkPropertyMetadata(typeof(PUContextMenu)));
        }

        #region Property
        /// <summary>
        /// 获取或设置当鼠标悬浮在子项上时，子项的背景颜色。默认值为#33888888。
        /// </summary>
        public Brush CoverBrush
        {
            get { return (Brush)GetValue(CoverBrushProperty); }
            set { SetValue(CoverBrushProperty, value); }
        }

        public static readonly DependencyProperty CoverBrushProperty =
            DependencyProperty.Register("CoverBrush", typeof(Brush), typeof(PUContextMenu));


        /// <summary>
        /// 获取或设置边框的圆角大小，默认值为0。
        /// </summary>
        public CornerRadius BorderCornerRadius
        {
            get { return (CornerRadius)GetValue(BorderCornerRadiusProperty); }
            set { SetValue(BorderCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty BorderCornerRadiusProperty =
            DependencyProperty.Register("BorderCornerRadius", typeof(CornerRadius), typeof(PUContextMenu));


        /// <summary>
        /// 获取或设置边框的阴影颜色。默认值为#44444444。
        /// </summary>
        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register("ShadowColor", typeof(Color), typeof(PUContextMenu));


        #endregion
    }
}
