// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerRecoveryItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AD2")]
  [Serializable]
  public class PlayerRecoveryItemType
  {
    [Token(Token = "0x40072FA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40072FB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001B5C")]
    public int ItemId
    {
      [Token(Token = "0x6009BF5"), Address(RVA = "0x48F2034", Offset = "0x48F2034", VA = "0x48F2034")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BF6"), Address(RVA = "0x48F203C", Offset = "0x48F203C", VA = "0x48F203C")] set
      {
      }
    }

    [Token(Token = "0x17001B5D")]
    public int StackCount
    {
      [Token(Token = "0x6009BF7"), Address(RVA = "0x48F2044", Offset = "0x48F2044", VA = "0x48F2044")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BF8"), Address(RVA = "0x48F204C", Offset = "0x48F204C", VA = "0x48F204C")] set
      {
      }
    }

    [Token(Token = "0x6009BF9")]
    [Address(RVA = "0x48F2054", Offset = "0x48F2054", VA = "0x48F2054")]
    public PlayerRecoveryItemType()
    {
    }
  }
}
