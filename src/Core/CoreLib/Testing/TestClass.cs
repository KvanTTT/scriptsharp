// TestClass.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Testing {

    [Imported]
    [IgnoreNamespace]
    public abstract class TestClass {

        public virtual void Cleanup() {
        }

        public virtual void Setup() {
        }
    }
}
