// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AAF")]
  [Serializable]
  public class PlayerExpeditionType
  {
    [Token(Token = "0x4007257")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007258")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int remain_boss_challenge_count;
    [Token(Token = "0x4007259")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int remain_boss_challenge_ticket_count;
    [Token(Token = "0x400725A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int remain_boss_challenge_coin_count;
    [Token(Token = "0x400725B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int remain_rapid_ticket_count;
    [Token(Token = "0x400725C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int remain_rapid_coin_count;
    [Token(Token = "0x400725D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int box_level;
    [Token(Token = "0x400725E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string search_at;

    [Token(Token = "0x17001AA4")]
    public string Id
    {
      [Token(Token = "0x6009A77"), Address(RVA = "0x48F12B4", Offset = "0x48F12B4", VA = "0x48F12B4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A78"), Address(RVA = "0x48F12BC", Offset = "0x48F12BC", VA = "0x48F12BC")] set
      {
      }
    }

    [Token(Token = "0x17001AA5")]
    public int RemainBossChallengeCount
    {
      [Token(Token = "0x6009A79"), Address(RVA = "0x48F12C4", Offset = "0x48F12C4", VA = "0x48F12C4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A7A"), Address(RVA = "0x48F12CC", Offset = "0x48F12CC", VA = "0x48F12CC")] set
      {
      }
    }

    [Token(Token = "0x17001AA6")]
    public int RemainBossChallengeTicketCount
    {
      [Token(Token = "0x6009A7B"), Address(RVA = "0x48F12D4", Offset = "0x48F12D4", VA = "0x48F12D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A7C"), Address(RVA = "0x48F12DC", Offset = "0x48F12DC", VA = "0x48F12DC")] set
      {
      }
    }

    [Token(Token = "0x17001AA7")]
    public int RemainBossChallengeCoinCount
    {
      [Token(Token = "0x6009A7D"), Address(RVA = "0x48F12E4", Offset = "0x48F12E4", VA = "0x48F12E4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A7E"), Address(RVA = "0x48F12EC", Offset = "0x48F12EC", VA = "0x48F12EC")] set
      {
      }
    }

    [Token(Token = "0x17001AA8")]
    public int RemainRapidTicketCount
    {
      [Token(Token = "0x6009A7F"), Address(RVA = "0x48F12F4", Offset = "0x48F12F4", VA = "0x48F12F4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A80"), Address(RVA = "0x48F12FC", Offset = "0x48F12FC", VA = "0x48F12FC")] set
      {
      }
    }

    [Token(Token = "0x17001AA9")]
    public int RemainRapidCoinCount
    {
      [Token(Token = "0x6009A81"), Address(RVA = "0x48F1304", Offset = "0x48F1304", VA = "0x48F1304")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A82"), Address(RVA = "0x48F130C", Offset = "0x48F130C", VA = "0x48F130C")] set
      {
      }
    }

    [Token(Token = "0x17001AAA")]
    public int BoxLevel
    {
      [Token(Token = "0x6009A83"), Address(RVA = "0x48F1314", Offset = "0x48F1314", VA = "0x48F1314")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A84"), Address(RVA = "0x48F131C", Offset = "0x48F131C", VA = "0x48F131C")] set
      {
      }
    }

    [Token(Token = "0x17001AAB")]
    public string SearchAt
    {
      [Token(Token = "0x6009A85"), Address(RVA = "0x48F1324", Offset = "0x48F1324", VA = "0x48F1324")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A86"), Address(RVA = "0x48F132C", Offset = "0x48F132C", VA = "0x48F132C")] set
      {
      }
    }

    [Token(Token = "0x6009A87")]
    [Address(RVA = "0x48F1334", Offset = "0x48F1334", VA = "0x48F1334")]
    public PlayerExpeditionType()
    {
    }
  }
}
