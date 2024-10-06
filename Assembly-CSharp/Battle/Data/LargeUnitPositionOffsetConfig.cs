// Decompiled with JetBrains decompiler
// Type: Battle.Data.LargeUnitPositionOffsetConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F0")]
  [Serializable]
  public class LargeUnitPositionOffsetConfig
  {
    [Token(Token = "0x400A686")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string description;
    [Token(Token = "0x400A687")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tooltip("各ターゲットアイコンのオフセット座標")]
    private List<Vector3> largeUnitPositionOffset;

    [Token(Token = "0x170032E4")]
    public List<Vector3> LargeUnitPositionOffset
    {
      [Token(Token = "0x600F0DF"), Address(RVA = "0x41ABC28", Offset = "0x41ABC28", VA = "0x41ABC28")] get
      {
        return (List<Vector3>) null;
      }
    }

    [Token(Token = "0x600F0E0")]
    [Address(RVA = "0x41ABC30", Offset = "0x41ABC30", VA = "0x41ABC30")]
    public LargeUnitPositionOffsetConfig()
    {
    }
  }
}
