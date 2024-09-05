// Decompiled with JetBrains decompiler
// Type: Battle.UI.Option.UnitListConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UI.Option
{
  [Token(Token = "0x2002447")]
  [Serializable]
  public class UnitListConfig
  {
    [Token(Token = "0x4009B94")]
    [FieldOffset(Offset = "0x10")]
    [Tooltip("状態異常関連の設定")]
    [SerializeField]
    public BadStatusFactorConfig badStatusFactor;

    [Token(Token = "0x600DE5A")]
    [Address(RVA = "0x1E3206C", Offset = "0x1E3206C", VA = "0x1E3206C")]
    public UnitListConfig()
    {
    }
  }
}
