// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerArenaBattleTicketType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A86")]
  [Serializable]
  public class PlayerArenaBattleTicketType
  {
    [Token(Token = "0x40071B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40071B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x170019F4")]
    public int ItemId
    {
      [Token(Token = "0x60098F7"), Address(RVA = "0x48F05B4", Offset = "0x48F05B4", VA = "0x48F05B4")] get
      {
        return new int();
      }
      [Token(Token = "0x60098F8"), Address(RVA = "0x48F05BC", Offset = "0x48F05BC", VA = "0x48F05BC")] set
      {
      }
    }

    [Token(Token = "0x170019F5")]
    public int StackCount
    {
      [Token(Token = "0x60098F9"), Address(RVA = "0x48F05C4", Offset = "0x48F05C4", VA = "0x48F05C4")] get
      {
        return new int();
      }
      [Token(Token = "0x60098FA"), Address(RVA = "0x48F05CC", Offset = "0x48F05CC", VA = "0x48F05CC")] set
      {
      }
    }

    [Token(Token = "0x60098FB")]
    [Address(RVA = "0x48F05D4", Offset = "0x48F05D4", VA = "0x48F05D4")]
    public PlayerArenaBattleTicketType()
    {
    }
  }
}
