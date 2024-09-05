// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerCurrencyItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A9F")]
  [Serializable]
  public class PlayerCurrencyItemType
  {
    [Token(Token = "0x4007219")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x400721A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001A66")]
    public int ItemId
    {
      [Token(Token = "0x60099EB"), Address(RVA = "0x48F0E50", Offset = "0x48F0E50", VA = "0x48F0E50")] get
      {
        return new int();
      }
      [Token(Token = "0x60099EC"), Address(RVA = "0x48F0E58", Offset = "0x48F0E58", VA = "0x48F0E58")] set
      {
      }
    }

    [Token(Token = "0x17001A67")]
    public int StackCount
    {
      [Token(Token = "0x60099ED"), Address(RVA = "0x48F0E60", Offset = "0x48F0E60", VA = "0x48F0E60")] get
      {
        return new int();
      }
      [Token(Token = "0x60099EE"), Address(RVA = "0x48F0E68", Offset = "0x48F0E68", VA = "0x48F0E68")] set
      {
      }
    }

    [Token(Token = "0x60099EF")]
    [Address(RVA = "0x48F0E70", Offset = "0x48F0E70", VA = "0x48F0E70")]
    public PlayerCurrencyItemType()
    {
    }
  }
}
