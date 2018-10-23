﻿using System;
using Xamarin.Forms;

namespace CeoMasterDetail.Models
{
    public class MasterMenuItem
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Color BackgroundColor { get; set; }
        public Type TargetType { get; set; }
        public MasterMenuItem(string Title, string IconSource, Color color, Type TargetType)
        {
            this.Title = Title;
            this.IconSource = IconSource;
            this.BackgroundColor = BackgroundColor;
            this.TargetType = TargetType;
        }
    }
}
