// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAdvertisementHistoryType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A7E")]
  [Serializable]
  public class PlayerAdvertisementHistoryType
  {
    [Token(Token = "0x4007194")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int master_id;
    [Token(Token = "0x4007195")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int status_id;
    [Token(Token = "0x4007196")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string advertisement_at;
    [Token(Token = "0x4007197")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string reward_received_at;
    [Token(Token = "0x4007198")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool callback_received;

    [Token(Token = "0x170019D8")]
    public int MasterId
    {
      [Token(Token = "0x60098B7"), Address(RVA = "0x48F03A8", Offset = "0x48F03A8", VA = "0x48F03A8")] get
      {
        return new int();
      }
      [Token(Token = "0x60098B8"), Address(RVA = "0x48F03B0", Offset = "0x48F03B0", VA = "0x48F03B0")] set
      {
      }
    }

    [Token(Token = "0x170019D9")]
    public int StatusId
    {
      [Token(Token = "0x60098B9"), Address(RVA = "0x48F03B8", Offset = "0x48F03B8", VA = "0x48F03B8")] get
      {
        return new int();
      }
      [Token(Token = "0x60098BA"), Address(RVA = "0x48F03C0", Offset = "0x48F03C0", VA = "0x48F03C0")] set
      {
      }
    }

    [Token(Token = "0x170019DA")]
    public string AdvertisementAt
    {
      [Token(Token = "0x60098BB"), Address(RVA = "0x48F03C8", Offset = "0x48F03C8", VA = "0x48F03C8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098BC"), Address(RVA = "0x48F03D0", Offset = "0x48F03D0", VA = "0x48F03D0")] set
      {
      }
    }

    [Token(Token = "0x170019DB")]
    public string RewardReceivedAt
    {
      [Token(Token = "0x60098BD"), Address(RVA = "0x48F03D8", Offset = "0x48F03D8", VA = "0x48F03D8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098BE"), Address(RVA = "0x48F03E0", Offset = "0x48F03E0", VA = "0x48F03E0")] set
      {
      }
    }

    [Token(Token = "0x170019DC")]
    public bool CallbackReceived
    {
      [Token(Token = "0x60098BF"), Address(RVA = "0x48F03E8", Offset = "0x48F03E8", VA = "0x48F03E8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60098C0"), Address(RVA = "0x48F03F0", Offset = "0x48F03F0", VA = "0x48F03F0")] set
      {
      }
    }

    [Token(Token = "0x60098C1")]
    [Address(RVA = "0x48F03FC", Offset = "0x48F03FC", VA = "0x48F03FC")]
    public PlayerAdvertisementHistoryType()
    {
    }
  }
}
