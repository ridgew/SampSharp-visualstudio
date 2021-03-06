﻿using System;
using System.Windows.Forms;

namespace SampSharp.VisualStudio.PropertyPages
{
    public interface IPropertyPageUi
    {
        event EventHandler<UserEditCompleteEventArgs> UserEditComplete;
        string GetControlValue(Control control);
        void SetControlValue(Control control, string value);
    }
}