// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleCharacterLp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A89")]
  [Serializable]
  public class PlayerBattleCharacterLp
  {
    [Token(Token = "0x40071BD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int character_id;
    [Token(Token = "0x40071BE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int lp;

    [Token(Token = "0x17001A01")]
    public int CharacterId
    {
      [Token(Token = "0x6009914"), Address(RVA = "0x48F069C", Offset = "0x48F069C", VA = "0x48F069C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009915"), Address(RVA = "0x48F06A4", Offset = "0x48F06A4", VA = "0x48F06A4")] set
      {
      }
    }

    [Token(Token = "0x17001A02")]
    public int Lp
    {
      [Token(Token = "0x6009916"), Address(RVA = "0x48F06AC", Offset = "0x48F06AC", VA = "0x48F06AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009917"), Address(RVA = "0x48F06B4", Offset = "0x48F06B4", VA = "0x48F06B4")] set
      {
      }
    }

    [Token(Token = "0x6009918")]
    [Address(RVA = "0x48F06BC", Offset = "0x48F06BC", VA = "0x48F06BC")]
    public PlayerBattleCharacterLp()
    {
    }
  }
}
