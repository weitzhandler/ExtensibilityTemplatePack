﻿using System;
using System.Runtime.InteropServices;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;

namespace $safeprojectname$
{
    [Guid("$guid5$")]
    public class MyToolWindow : ToolWindowPane
    {
        public const string Title = "My Tool Window";

        public MyToolWindow() : base(null)
        { }

        public MyToolWindow(DTE2 dte) : base()
        {
            Caption = Title;

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            Content = new MyToolWindowControl(dte);
        }
    }
}
