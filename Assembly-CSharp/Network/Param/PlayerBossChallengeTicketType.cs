// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBossChallengeTicketType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A96")]
  [Serializable]
  public class PlayerBossChallengeTicketType
  {
    [Token(Token = "0x40071FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40071FC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001A48")]
    public int ItemId
    {
      [Token(Token = "0x60099A6"), Address(RVA = "0x48F0C28", Offset = "0x48F0C28", VA = "0x48F0C28")] get
      {
        return new int();
      }
      [Token(Token = "0x60099A7"), Address(RVA = "0x48F0C30", Offset = "0x48F0C30", VA = "0x48F0C30")] set
      {
      }
    }

    [Token(Token = "0x17001A49")]
    public int StackCount
    {
      [Token(Token = "0x60099A8"), Address(RVA = "0x48F0C38", Offset = "0x48F0C38", VA = "0x48F0C38")] get
      {
        return new int();
      }
      [Token(Token = "0x60099A9"), Address(RVA = "0x48F0C40", Offset = "0x48F0C40", VA = "0x48F0C40")] set
      {
      }
    }

    [Token(Token = "0x60099AA")]
    [Address(RVA = "0x48F0C48", Offset = "0x48F0C48", VA = "0x48F0C48")]
    public PlayerBossChallengeTicketType()
    {
    }
  }
}
