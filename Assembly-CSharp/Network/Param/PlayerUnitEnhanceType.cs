// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitEnhanceType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF9")]
  [Serializable]
  public class PlayerUnitEnhanceType
  {
    [Token(Token = "0x40073CF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40073D0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001C31")]
    public int ItemId
    {
      [Token(Token = "0x6009DC6"), Address(RVA = "0x48F2EE4", Offset = "0x48F2EE4", VA = "0x48F2EE4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DC7"), Address(RVA = "0x48F2EEC", Offset = "0x48F2EEC", VA = "0x48F2EEC")] set
      {
      }
    }

    [Token(Token = "0x17001C32")]
    public int StackCount
    {
      [Token(Token = "0x6009DC8"), Address(RVA = "0x48F2EF4", Offset = "0x48F2EF4", VA = "0x48F2EF4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DC9"), Address(RVA = "0x48F2EFC", Offset = "0x48F2EFC", VA = "0x48F2EFC")] set
      {
      }
    }

    [Token(Token = "0x6009DCA")]
    [Address(RVA = "0x48F2F04", Offset = "0x48F2F04", VA = "0x48F2F04")]
    public PlayerUnitEnhanceType()
    {
    }
  }
}
