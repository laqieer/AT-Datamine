// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBlockType
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
  [Token(Token = "0x2001A95")]
  [Serializable]
  public class PlayerBlockType : IPlayerBasicProfileInfo, IPlayerTitleInfo
  {
    [Token(Token = "0x40071F9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string target_player_id;
    [Token(Token = "0x40071FA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerListProfileType target_player_profile;

    [Token(Token = "0x17001A3D")]
    public string TargetPlayerId
    {
      [Token(Token = "0x6009998"), Address(RVA = "0x48F0AC0", Offset = "0x48F0AC0", VA = "0x48F0AC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009999"), Address(RVA = "0x48F0AC8", Offset = "0x48F0AC8", VA = "0x48F0AC8")] set
      {
      }
    }

    [Token(Token = "0x17001A3E")]
    public PlayerListProfileType TargetPlayerProfile
    {
      [Token(Token = "0x600999A"), Address(RVA = "0x48F0AD0", Offset = "0x48F0AD0", VA = "0x48F0AD0")] get
      {
        return (PlayerListProfileType) null;
      }
      [Token(Token = "0x600999B"), Address(RVA = "0x48F0AD8", Offset = "0x48F0AD8", VA = "0x48F0AD8")] set
      {
      }
    }

    [Token(Token = "0x17001A3F")]
    private string StaqData\u002EIPlayerBasicProfileInfo\u002EName
    {
      [Token(Token = "0x600999C"), Address(RVA = "0x48F0AE0", Offset = "0x48F0AE0", VA = "0x48F0AE0", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001A40")]
    private string StaqData\u002EIPlayerBasicProfileInfo\u002EId
    {
      [Token(Token = "0x600999D"), Address(RVA = "0x48F0AFC", Offset = "0x48F0AFC", VA = "0x48F0AFC", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001A41")]
    private int StaqData\u002EIPlayerBasicProfileInfo\u002EExperience
    {
      [Token(Token = "0x600999E"), Address(RVA = "0x48F0B04", Offset = "0x48F0B04", VA = "0x48F0B04", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A42")]
    private int StaqData\u002EIPlayerBasicProfileInfo\u002ESymbolUnitMasterId
    {
      [Token(Token = "0x600999F"), Address(RVA = "0x48F0B20", Offset = "0x48F0B20", VA = "0x48F0B20", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A43")]
    private DateTime StaqData\u002EIPlayerBasicProfileInfo\u002ELastSignedInAt
    {
      [Token(Token = "0x60099A0"), Address(RVA = "0x48F0B3C", Offset = "0x48F0B3C", VA = "0x48F0B3C", Slot = "8")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17001A44")]
    private int StaqData\u002EIPlayerTitleInfo\u002EPreTitleId
    {
      [Token(Token = "0x60099A1"), Address(RVA = "0x48F0BC8", Offset = "0x48F0BC8", VA = "0x48F0BC8", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A45")]
    private int StaqData\u002EIPlayerTitleInfo\u002EPostTitleId
    {
      [Token(Token = "0x60099A2"), Address(RVA = "0x48F0BE4", Offset = "0x48F0BE4", VA = "0x48F0BE4", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A46")]
    private int StaqData\u002EIPlayerTitleInfo\u002ETitleFrameId
    {
      [Token(Token = "0x60099A3"), Address(RVA = "0x48F0C00", Offset = "0x48F0C00", VA = "0x48F0C00", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A47")]
    public IPlayerBasicProfileInfo PlayerBasicProfile
    {
      [Token(Token = "0x60099A4"), Address(RVA = "0x48F0C1C", Offset = "0x48F0C1C", VA = "0x48F0C1C")] get
      {
        return (IPlayerBasicProfileInfo) null;
      }
    }

    [Token(Token = "0x60099A5")]
    [Address(RVA = "0x48F0C20", Offset = "0x48F0C20", VA = "0x48F0C20")]
    public PlayerBlockType()
    {
    }
  }
}
