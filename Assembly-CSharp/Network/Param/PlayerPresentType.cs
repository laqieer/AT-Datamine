// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerPresentType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ACD")]
  [Serializable]
  public class PlayerPresentType
  {
    [Token(Token = "0x40072DC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40072DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int reward_type_id;
    [Token(Token = "0x40072DE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int reward_id;
    [Token(Token = "0x40072DF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int reward_quantity;
    [Token(Token = "0x40072E0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string received_at;
    [Token(Token = "0x40072E1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string receive_limit_at;
    [Token(Token = "0x40072E2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string message;
    [Token(Token = "0x40072E3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string created_at;

    [Token(Token = "0x17001B3E")]
    public string Id
    {
      [Token(Token = "0x6009BB4"), Address(RVA = "0x48F1E28", Offset = "0x48F1E28", VA = "0x48F1E28")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BB5"), Address(RVA = "0x48F1E30", Offset = "0x48F1E30", VA = "0x48F1E30")] set
      {
      }
    }

    [Token(Token = "0x17001B3F")]
    public int RewardTypeId
    {
      [Token(Token = "0x6009BB6"), Address(RVA = "0x48F1E38", Offset = "0x48F1E38", VA = "0x48F1E38")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BB7"), Address(RVA = "0x48F1E40", Offset = "0x48F1E40", VA = "0x48F1E40")] set
      {
      }
    }

    [Token(Token = "0x17001B40")]
    public int RewardId
    {
      [Token(Token = "0x6009BB8"), Address(RVA = "0x48F1E48", Offset = "0x48F1E48", VA = "0x48F1E48")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BB9"), Address(RVA = "0x48F1E50", Offset = "0x48F1E50", VA = "0x48F1E50")] set
      {
      }
    }

    [Token(Token = "0x17001B41")]
    public int RewardQuantity
    {
      [Token(Token = "0x6009BBA"), Address(RVA = "0x48F1E58", Offset = "0x48F1E58", VA = "0x48F1E58")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BBB"), Address(RVA = "0x48F1E60", Offset = "0x48F1E60", VA = "0x48F1E60")] set
      {
      }
    }

    [Token(Token = "0x17001B42")]
    public string ReceivedAt
    {
      [Token(Token = "0x6009BBC"), Address(RVA = "0x48F1E68", Offset = "0x48F1E68", VA = "0x48F1E68")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BBD"), Address(RVA = "0x48F1E70", Offset = "0x48F1E70", VA = "0x48F1E70")] set
      {
      }
    }

    [Token(Token = "0x17001B43")]
    public string ReceiveLimitAt
    {
      [Token(Token = "0x6009BBE"), Address(RVA = "0x48F1E78", Offset = "0x48F1E78", VA = "0x48F1E78")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BBF"), Address(RVA = "0x48F1E80", Offset = "0x48F1E80", VA = "0x48F1E80")] set
      {
      }
    }

    [Token(Token = "0x17001B44")]
    public string Message
    {
      [Token(Token = "0x6009BC0"), Address(RVA = "0x48F1E88", Offset = "0x48F1E88", VA = "0x48F1E88")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BC1"), Address(RVA = "0x48F1E90", Offset = "0x48F1E90", VA = "0x48F1E90")] set
      {
      }
    }

    [Token(Token = "0x17001B45")]
    public string CreatedAt
    {
      [Token(Token = "0x6009BC2"), Address(RVA = "0x48F1E98", Offset = "0x48F1E98", VA = "0x48F1E98")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BC3"), Address(RVA = "0x48F1EA0", Offset = "0x48F1EA0", VA = "0x48F1EA0")] set
      {
      }
    }

    [Token(Token = "0x6009BC4")]
    [Address(RVA = "0x48F1EA8", Offset = "0x48F1EA8", VA = "0x48F1EA8")]
    public PlayerPresentType()
    {
    }
  }
}
