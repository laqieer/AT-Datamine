// Decompiled with JetBrains decompiler
// Type: Network.Param.GachaResultHistoryEntityType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A60")]
  [Serializable]
  public class GachaResultHistoryEntityType
  {
    [Token(Token = "0x40070F6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int reward_type_id;
    [Token(Token = "0x40070F7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int reward_id;
    [Token(Token = "0x40070F8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int reward_quantity;
    [Token(Token = "0x40070F9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool is_bonus;
    [Token(Token = "0x40070FA")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    private bool is_substitute_by_duplicate;

    [Token(Token = "0x1700192C")]
    public int RewardTypeId
    {
      [Token(Token = "0x600974E"), Address(RVA = "0x48EF8C8", Offset = "0x48EF8C8", VA = "0x48EF8C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600974F"), Address(RVA = "0x48EF8D0", Offset = "0x48EF8D0", VA = "0x48EF8D0")] set
      {
      }
    }

    [Token(Token = "0x1700192D")]
    public int RewardId
    {
      [Token(Token = "0x6009750"), Address(RVA = "0x48EF8D8", Offset = "0x48EF8D8", VA = "0x48EF8D8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009751"), Address(RVA = "0x48EF8E0", Offset = "0x48EF8E0", VA = "0x48EF8E0")] set
      {
      }
    }

    [Token(Token = "0x1700192E")]
    public int RewardQuantity
    {
      [Token(Token = "0x6009752"), Address(RVA = "0x48EF8E8", Offset = "0x48EF8E8", VA = "0x48EF8E8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009753"), Address(RVA = "0x48EF8F0", Offset = "0x48EF8F0", VA = "0x48EF8F0")] set
      {
      }
    }

    [Token(Token = "0x1700192F")]
    public bool IsBonus
    {
      [Token(Token = "0x6009754"), Address(RVA = "0x48EF8F8", Offset = "0x48EF8F8", VA = "0x48EF8F8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009755"), Address(RVA = "0x48EF900", Offset = "0x48EF900", VA = "0x48EF900")] set
      {
      }
    }

    [Token(Token = "0x17001930")]
    public bool IsSubstituteByDuplicate
    {
      [Token(Token = "0x6009756"), Address(RVA = "0x48EF90C", Offset = "0x48EF90C", VA = "0x48EF90C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009757"), Address(RVA = "0x48EF914", Offset = "0x48EF914", VA = "0x48EF914")] set
      {
      }
    }

    [Token(Token = "0x6009758")]
    [Address(RVA = "0x48EF920", Offset = "0x48EF920", VA = "0x48EF920")]
    public GachaResultHistoryEntityType()
    {
    }
  }
}
