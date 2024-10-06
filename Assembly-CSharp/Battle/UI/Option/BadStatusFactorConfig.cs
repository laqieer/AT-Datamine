// Decompiled with JetBrains decompiler
// Type: Battle.UI.Option.BadStatusFactorConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.UI.Option
{
  [Token(Token = "0x2002448")]
  [Serializable]
  public class BadStatusFactorConfig
  {
    [Token(Token = "0x4009B95")]
    [FieldOffset(Offset = "0x10")]
    [Tooltip("表示する状態異常のリスト")]
    [SerializeField]
    public List<BattleBadStatusTypeEnum> badStatusColmns;

    [Token(Token = "0x600DE5B")]
    [Address(RVA = "0x1E32074", Offset = "0x1E32074", VA = "0x1E32074")]
    public BadStatusFactorConfig()
    {
    }
  }
}
