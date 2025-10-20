﻿using System.Runtime.InteropServices;
using System.Security;
using System;

namespace Avril_FSD
{
    [SuppressUnmanagedCodeSecurity]
    public static class Library_For_WriteEnableForThreadsAt_CLIENTINPUTACTION
    {
        [DllImport("LIBWriteEnableForThreadsAtCLIENTINPUTACTION.dll", EntryPoint = "?Initialise_WriteEnable@CLIBWriteEnableForThreadsAtCLIENTINPUTACTION@Avril_FSD@@SAPAXXZ")]
        public static extern IntPtr Initialise_WriteEnable();

        [DllImport("LIBWriteEnableForThreadsAtCLIENTINPUTACTION.dll", EntryPoint = "?Write_End@CLIBWriteEnableForThreadsAtCLIENTINPUTACTION@Avril_FSD@@SAXPAVWriteEnableForThreadsAt_CLIENTINPUTACTION_Framework@2@E@Z")]
        public static extern void Write_End(IntPtr obj, byte coreId);

        [DllImport("LIBWriteEnableForThreadsAtCLIENTINPUTACTION.dll", EntryPoint = "?Write_Start@CLIBWriteEnableForThreadsAtCLIENTINPUTACTION@Avril_FSD@@SAXPAVWriteEnableForThreadsAt_CLIENTINPUTACTION_Framework@2@E@Z")]
        public static extern void Write_Start(IntPtr obj, byte coreId);
    }
}