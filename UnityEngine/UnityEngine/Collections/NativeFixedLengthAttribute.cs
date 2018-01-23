﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Collections.NativeFixedLengthAttribute
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Collections
{
  [RequiredByNativeCode]
  [AttributeUsage(AttributeTargets.Field)]
  public class NativeFixedLengthAttribute : Attribute
  {
    public int FixedLength;

    public NativeFixedLengthAttribute(int fixedLength)
    {
      this.FixedLength = fixedLength;
    }
  }
}