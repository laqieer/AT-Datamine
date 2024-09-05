// Decompiled with JetBrains decompiler
// Type: Network.Param.LoginBonusInfoType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A75")]
  [Serializable]
  public class LoginBonusInfoType
  {
    [Token(Token = "0x4007179")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int loginbonus_id;
    [Token(Token = "0x400717A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int total_login_days;
    [Token(Token = "0x400717B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int loginbonus_reward_id;
    [Token(Token = "0x400717C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<int> past_loginbonus_reward_ids;

    [Token(Token = "0x170019BD")]
    public int LoginbonusId
    {
      [Token(Token = "0x6009878"), Address(RVA = "0x48F01A4", Offset = "0x48F01A4", VA = "0x48F01A4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009879"), Address(RVA = "0x48F01AC", Offset = "0x48F01AC", VA = "0x48F01AC")] set
      {
      }
    }

    [Token(Token = "0x170019BE")]
    public int TotalLoginDays
    {
      [Token(Token = "0x600987A"), Address(RVA = "0x48F01B4", Offset = "0x48F01B4", VA = "0x48F01B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600987B"), Address(RVA = "0x48F01BC", Offset = "0x48F01BC", VA = "0x48F01BC")] set
      {
      }
    }

    [Token(Token = "0x170019BF")]
    public int LoginbonusRewardId
    {
      [Token(Token = "0x600987C"), Address(RVA = "0x48F01C4", Offset = "0x48F01C4", VA = "0x48F01C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600987D"), Address(RVA = "0x48F01CC", Offset = "0x48F01CC", VA = "0x48F01CC")] set
      {
      }
    }

    [Token(Token = "0x170019C0")]
    public List<int> PastLoginbonusRewardIds
    {
      [Token(Token = "0x600987E"), Address(RVA = "0x48F01D4", Offset = "0x48F01D4", VA = "0x48F01D4")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600987F"), Address(RVA = "0x48F01DC", Offset = "0x48F01DC", VA = "0x48F01DC")] set
      {
      }
    }

    [Token(Token = "0x6009880")]
    [Address(RVA = "0x48F01E4", Offset = "0x48F01E4", VA = "0x48F01E4")]
    public LoginBonusInfoType()
    {
    }
  }
}
