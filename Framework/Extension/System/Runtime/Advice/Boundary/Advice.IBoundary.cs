﻿using System;

namespace System.Runtime
{
    public sealed partial class Advice
    {
        public interface IBoundary
        {
            void Argument(IntPtr pointer);
            void Before();
            void Resume();
            void Yield();
            void Return<T>(ref T value, ref Exception exception);
            void Throw<T>(ref T value, ref Exception exception);
        }
    }
}