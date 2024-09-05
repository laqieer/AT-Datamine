// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExchangeItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA6")]
  [Serializable]
  public class PlayerExchangeItemType
  {
    [Token(Token = "0x4007239")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x400723A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001A86")]
    public int ItemId
    {
      [Token(Token = "0x6009A32"), Address(RVA = "0x48F108C", Offset = "0x48F108C", VA = "0x48F108C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A33"), Address(RVA = "0x48F1094", Offset = "0x48F1094", VA = "0x48F1094")] set
      {
      }
    }

    [Token(Token = "0x17001A87")]
    public int StackCount
    {
      [Token(Token = "0x6009A34"), Address(RVA = "0x48F109C", Offset = "0x48F109C", VA = "0x48F109C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A35"), Address(RVA = "0x48F10A4", Offset = "0x48F10A4", VA = "0x48F10A4")] set
      {
      }
    }

    [Token(Token = "0x6009A36")]
    [Address(RVA = "0x48F10AC", Offset = "0x48F10AC", VA = "0x48F10AC")]
    public PlayerExchangeItemType()
    {
    }
  }
}
