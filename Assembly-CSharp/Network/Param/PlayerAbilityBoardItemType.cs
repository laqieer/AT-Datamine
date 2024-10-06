// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAbilityBoardItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A7B")]
  [Serializable]
  public class PlayerAbilityBoardItemType
  {
    [Token(Token = "0x400718E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x400718F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x170019D2")]
    public int ItemId
    {
      [Token(Token = "0x60098A8"), Address(RVA = "0x48F0330", Offset = "0x48F0330", VA = "0x48F0330")] get
      {
        return new int();
      }
      [Token(Token = "0x60098A9"), Address(RVA = "0x48F0338", Offset = "0x48F0338", VA = "0x48F0338")] set
      {
      }
    }

    [Token(Token = "0x170019D3")]
    public int StackCount
    {
      [Token(Token = "0x60098AA"), Address(RVA = "0x48F0340", Offset = "0x48F0340", VA = "0x48F0340")] get
      {
        return new int();
      }
      [Token(Token = "0x60098AB"), Address(RVA = "0x48F0348", Offset = "0x48F0348", VA = "0x48F0348")] set
      {
      }
    }

    [Token(Token = "0x60098AC")]
    [Address(RVA = "0x48F0350", Offset = "0x48F0350", VA = "0x48F0350")]
    public PlayerAbilityBoardItemType()
    {
    }
  }
}
