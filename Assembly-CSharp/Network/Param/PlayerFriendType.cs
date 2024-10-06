// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerFriendType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB6")]
  [Serializable]
  public class PlayerFriendType : IPlayerBasicProfileInfo, IPlayerTitleInfo
  {
    [Token(Token = "0x400727C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string target_player_id;
    [Token(Token = "0x400727D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int status;
    [Token(Token = "0x400727E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string applied_at;
    [Token(Token = "0x400727F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerListProfileType target_player_profile;

    [Token(Token = "0x17001AC9")]
    public string TargetPlayerId
    {
      [Token(Token = "0x6009AC8"), Address(RVA = "0x48F154C", Offset = "0x48F154C", VA = "0x48F154C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AC9"), Address(RVA = "0x48F1554", Offset = "0x48F1554", VA = "0x48F1554")] set
      {
      }
    }

    [Token(Token = "0x17001ACA")]
    public int Status
    {
      [Token(Token = "0x6009ACA"), Address(RVA = "0x48F155C", Offset = "0x48F155C", VA = "0x48F155C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009ACB"), Address(RVA = "0x48F1564", Offset = "0x48F1564", VA = "0x48F1564")] set
      {
      }
    }

    [Token(Token = "0x17001ACB")]
    public string AppliedAt
    {
      [Token(Token = "0x6009ACC"), Address(RVA = "0x48F156C", Offset = "0x48F156C", VA = "0x48F156C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009ACD"), Address(RVA = "0x48F1574", Offset = "0x48F1574", VA = "0x48F1574")] set
      {
      }
    }

    [Token(Token = "0x17001ACC")]
    public PlayerListProfileType TargetPlayerProfile
    {
      [Token(Token = "0x6009ACE"), Address(RVA = "0x48F157C", Offset = "0x48F157C", VA = "0x48F157C")] get
      {
        return (PlayerListProfileType) null;
      }
      [Token(Token = "0x6009ACF"), Address(RVA = "0x48F1584", Offset = "0x48F1584", VA = "0x48F1584")] set
      {
      }
    }

    [Token(Token = "0x17001ACD")]
    private string StaqData\u002EIPlayerBasicProfileInfo\u002EName
    {
      [Token(Token = "0x6009AD0"), Address(RVA = "0x48F158C", Offset = "0x48F158C", VA = "0x48F158C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001ACE")]
    private string StaqData\u002EIPlayerBasicProfileInfo\u002EId
    {
      [Token(Token = "0x6009AD1"), Address(RVA = "0x48F15A8", Offset = "0x48F15A8", VA = "0x48F15A8", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001ACF")]
    private int StaqData\u002EIPlayerBasicProfileInfo\u002EExperience
    {
      [Token(Token = "0x6009AD2"), Address(RVA = "0x48F15B0", Offset = "0x48F15B0", VA = "0x48F15B0", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001AD0")]
    private int StaqData\u002EIPlayerBasicProfileInfo\u002ESymbolUnitMasterId
    {
      [Token(Token = "0x6009AD3"), Address(RVA = "0x48F15CC", Offset = "0x48F15CC", VA = "0x48F15CC", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001AD1")]
    private DateTime StaqData\u002EIPlayerBasicProfileInfo\u002ELastSignedInAt
    {
      [Token(Token = "0x6009AD4"), Address(RVA = "0x48F15E8", Offset = "0x48F15E8", VA = "0x48F15E8", Slot = "8")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17001AD2")]
    private int StaqData\u002EIPlayerTitleInfo\u002EPreTitleId
    {
      [Token(Token = "0x6009AD5"), Address(RVA = "0x48F1674", Offset = "0x48F1674", VA = "0x48F1674", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001AD3")]
    private int StaqData\u002EIPlayerTitleInfo\u002EPostTitleId
    {
      [Token(Token = "0x6009AD6"), Address(RVA = "0x48F1690", Offset = "0x48F1690", VA = "0x48F1690", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001AD4")]
    private int StaqData\u002EIPlayerTitleInfo\u002ETitleFrameId
    {
      [Token(Token = "0x6009AD7"), Address(RVA = "0x48F16AC", Offset = "0x48F16AC", VA = "0x48F16AC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001AD5")]
    public IPlayerBasicProfileInfo PlayerBasicProfile
    {
      [Token(Token = "0x6009AD8"), Address(RVA = "0x48F16C8", Offset = "0x48F16C8", VA = "0x48F16C8")] get
      {
        return (IPlayerBasicProfileInfo) null;
      }
    }

    [Token(Token = "0x6009AD9")]
    [Address(RVA = "0x48F16CC", Offset = "0x48F16CC", VA = "0x48F16CC")]
    public PlayerFriendType()
    {
    }
  }
}
