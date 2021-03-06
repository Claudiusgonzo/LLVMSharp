// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System;

namespace LLVMSharp.Interop
{
    public unsafe partial struct LLVMRemarkStringRef
    {
        public LLVMRemarkStringRef(IntPtr handle)
        {
            Handle = handle;
        }

        public IntPtr Handle;

        public static implicit operator LLVMRemarkStringRef(LLVMRemarkOpaqueString* value)
        {
            return new LLVMRemarkStringRef((IntPtr)value);
        }

        public static implicit operator LLVMRemarkOpaqueString*(LLVMRemarkStringRef value)
        {
            return (LLVMRemarkOpaqueString*)value.Handle;
        }
    }
}
