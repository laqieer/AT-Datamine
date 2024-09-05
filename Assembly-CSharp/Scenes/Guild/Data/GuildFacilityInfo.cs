// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Data.GuildFacilityInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Guild.Data
{
  [Token(Token = "0x2002C1A")]
  public class GuildFacilityInfo
  {
    [Token(Token = "0x17003B82")]
    public List<GuildFacilityDetailInfo> Facilities
    {
      [Token(Token = "0x6011410"), Address(RVA = "0x4A1A36C", Offset = "0x4A1A36C", VA = "0x4A1A36C")] get
      {
        return (List<GuildFacilityDetailInfo>) null;
      }
      [Token(Token = "0x6011411"), Address(RVA = "0x4A1A374", Offset = "0x4A1A374", VA = "0x4A1A374")] private set
      {
      }
    }

    [Token(Token = "0x17003B83")]
    public int InvestCount
    {
      [Token(Token = "0x6011412"), Address(RVA = "0x4A1A37C", Offset = "0x4A1A37C", VA = "0x4A1A37C")] get
      {
        return new int();
      }
      [Token(Token = "0x6011413"), Address(RVA = "0x4A1A384", Offset = "0x4A1A384", VA = "0x4A1A384")] private set
      {
      }
    }

    [Token(Token = "0x17003B84")]
    public List<int> LevelChangedIds
    {
      [Token(Token = "0x6011414"), Address(RVA = "0x4A1A38C", Offset = "0x4A1A38C", VA = "0x4A1A38C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6011415"), Address(RVA = "0x4A1A394", Offset = "0x4A1A394", VA = "0x4A1A394")] private set
      {
      }
    }

    [Token(Token = "0x17003B85")]
    public bool AnyLevelChanged
    {
      [Token(Token = "0x6011416"), Address(RVA = "0x4A1A39C", Offset = "0x4A1A39C", VA = "0x4A1A39C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6011417")]
    [Address(RVA = "0x4A18A9C", Offset = "0x4A18A9C", VA = "0x4A18A9C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011418")]
    [Address(RVA = "0x4A1A3E4", Offset = "0x4A1A3E4", VA = "0x4A1A3E4")]
    public void Reset()
    {
    }

    [Token(Token = "0x6011419")]
    [Address(RVA = "0x4A1A46C", Offset = "0x4A1A46C", VA = "0x4A1A46C")]
    public void ApplyFacilities(List<GuildFacilityDetailInfo> facilities)
    {
    }

    [Token(Token = "0x601141A")]
    [Address(RVA = "0x4A0E0F8", Offset = "0x4A0E0F8", VA = "0x4A0E0F8")]
    public void ApplyInvestCount(int investCount)
    {
    }

    [Token(Token = "0x601141B")]
    [Address(RVA = "0x4A19A14", Offset = "0x4A19A14", VA = "0x4A19A14")]
    public void ApplyFacilityLevelChanged(List<int> ids)
    {
    }

    [Token(Token = "0x601141C")]
    [Address(RVA = "0x4A1982C", Offset = "0x4A1982C", VA = "0x4A1982C")]
    public void ApplyExperience(int facilityId, int exp)
    {
    }

    [Token(Token = "0x601141D")]
    [Address(RVA = "0x4A1A47C", Offset = "0x4A1A47C", VA = "0x4A1A47C")]
    public IBattleParameter GetBonusParameter() => (IBattleParameter) null;

    [Token(Token = "0x601141E")]
    [Address(RVA = "0x4A18A94", Offset = "0x4A18A94", VA = "0x4A18A94")]
    public GuildFacilityInfo()
    {
    }
  }
}
