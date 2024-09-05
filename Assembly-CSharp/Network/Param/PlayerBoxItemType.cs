// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBoxItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A97")]
  [Serializable]
  public class PlayerBoxItemType
  {
    [Token(Token = "0x40071FD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40071FE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001A4A")]
    public int ItemId
    {
      [Token(Token = "0x60099AB"), Address(RVA = "0x48F0C50", Offset = "0x48F0C50", VA = "0x48F0C50")] get
      {
        return new int();
      }
      [Token(Token = "0x60099AC"), Address(RVA = "0x48F0C58", Offset = "0x48F0C58", VA = "0x48F0C58")] set
      {
      }
    }

    [Token(Token = "0x17001A4B")]
    public int StackCount
    {
      [Token(Token = "0x60099AD"), Address(RVA = "0x48F0C60", Offset = "0x48F0C60", VA = "0x48F0C60")] get
      {
        return new int();
      }
      [Token(Token = "0x60099AE"), Address(RVA = "0x48F0C68", Offset = "0x48F0C68", VA = "0x48F0C68")] set
      {
      }
    }

    [Token(Token = "0x60099AF")]
    [Address(RVA = "0x48F0C70", Offset = "0x48F0C70", VA = "0x48F0C70")]
    public PlayerBoxItemType()
    {
    }
  }
}
