// Decompiled with JetBrains decompiler
// Type: Network.Param.RewardGiveResultEntityType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B0C")]
  [Serializable]
  public class RewardGiveResultEntityType
  {
    [Token(Token = "0x4007431")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int reward_type_id;
    [Token(Token = "0x4007432")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int reward_id;
    [Token(Token = "0x4007433")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int reward_quantity;
    [Token(Token = "0x4007434")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool is_new;
    [Token(Token = "0x4007435")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string reward_result_id;

    [Token(Token = "0x17001C93")]
    public int RewardTypeId
    {
      [Token(Token = "0x6009E9D"), Address(RVA = "0x48F35C4", Offset = "0x48F35C4", VA = "0x48F35C4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E9E"), Address(RVA = "0x48F35CC", Offset = "0x48F35CC", VA = "0x48F35CC")] set
      {
      }
    }

    [Token(Token = "0x17001C94")]
    public int RewardId
    {
      [Token(Token = "0x6009E9F"), Address(RVA = "0x48F35D4", Offset = "0x48F35D4", VA = "0x48F35D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EA0"), Address(RVA = "0x48F35DC", Offset = "0x48F35DC", VA = "0x48F35DC")] set
      {
      }
    }

    [Token(Token = "0x17001C95")]
    public int RewardQuantity
    {
      [Token(Token = "0x6009EA1"), Address(RVA = "0x48F35E4", Offset = "0x48F35E4", VA = "0x48F35E4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EA2"), Address(RVA = "0x48F35EC", Offset = "0x48F35EC", VA = "0x48F35EC")] set
      {
      }
    }

    [Token(Token = "0x17001C96")]
    public bool IsNew
    {
      [Token(Token = "0x6009EA3"), Address(RVA = "0x48F35F4", Offset = "0x48F35F4", VA = "0x48F35F4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009EA4"), Address(RVA = "0x48F35FC", Offset = "0x48F35FC", VA = "0x48F35FC")] set
      {
      }
    }

    [Token(Token = "0x17001C97")]
    public string RewardResultId
    {
      [Token(Token = "0x6009EA5"), Address(RVA = "0x48F3608", Offset = "0x48F3608", VA = "0x48F3608")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009EA6"), Address(RVA = "0x48F3610", Offset = "0x48F3610", VA = "0x48F3610")] set
      {
      }
    }

    [Token(Token = "0x6009EA7")]
    [Address(RVA = "0x48F3618", Offset = "0x48F3618", VA = "0x48F3618")]
    public RewardGiveResultEntityType()
    {
    }
  }
}
