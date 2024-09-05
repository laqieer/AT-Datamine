// Decompiled with JetBrains decompiler
// Type: Battle.UI.BadStatusIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200242A")]
  [Serializable]
  internal class BadStatusIconParam
  {
    [Token(Token = "0x4009ACD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BattleBadStatusTypeEnum badStatus;
    [Token(Token = "0x4009ACE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string iconName;

    [Token(Token = "0x17002F9B")]
    public BattleBadStatusTypeEnum BadStatus
    {
      [Token(Token = "0x600DDA4"), Address(RVA = "0x1E2B0AC", Offset = "0x1E2B0AC", VA = "0x1E2B0AC")] get
      {
        return new BattleBadStatusTypeEnum();
      }
    }

    [Token(Token = "0x17002F9C")]
    public string IconName
    {
      [Token(Token = "0x600DDA5"), Address(RVA = "0x1E2B0B4", Offset = "0x1E2B0B4", VA = "0x1E2B0B4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002F9D")]
    public Sprite Icon
    {
      [Token(Token = "0x600DDA6"), Address(RVA = "0x1E2B0BC", Offset = "0x1E2B0BC", VA = "0x1E2B0BC")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600DDA7"), Address(RVA = "0x1E2B0C4", Offset = "0x1E2B0C4", VA = "0x1E2B0C4")] set
      {
      }
    }

    [Token(Token = "0x600DDA8")]
    [Address(RVA = "0x1E2B0CC", Offset = "0x1E2B0CC", VA = "0x1E2B0CC")]
    public BadStatusIconParam()
    {
    }
  }
}
