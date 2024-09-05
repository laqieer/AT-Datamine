// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Data.GuildMemberInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;

#nullable disable
namespace Scenes.Guild.Data
{
  [Token(Token = "0x2002C1D")]
  public class GuildMemberInfo : IPlayerTitleInfo
  {
    [Token(Token = "0x17003B8D")]
    public string GuildId
    {
      [Token(Token = "0x6011437"), Address(RVA = "0x4A1ACBC", Offset = "0x4A1ACBC", VA = "0x4A1ACBC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6011438"), Address(RVA = "0x4A1ACC4", Offset = "0x4A1ACC4", VA = "0x4A1ACC4")] private set
      {
      }
    }

    [Token(Token = "0x17003B8E")]
    public string PlayerId
    {
      [Token(Token = "0x6011439"), Address(RVA = "0x4A1ACCC", Offset = "0x4A1ACCC", VA = "0x4A1ACCC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601143A"), Address(RVA = "0x4A1ACD4", Offset = "0x4A1ACD4", VA = "0x4A1ACD4")] private set
      {
      }
    }

    [Token(Token = "0x17003B8F")]
    public string PlayerName
    {
      [Token(Token = "0x601143B"), Address(RVA = "0x4A1ACDC", Offset = "0x4A1ACDC", VA = "0x4A1ACDC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601143C"), Address(RVA = "0x4A1ACE4", Offset = "0x4A1ACE4", VA = "0x4A1ACE4")] private set
      {
      }
    }

    [Token(Token = "0x17003B90")]
    public int PlayerEmblemId
    {
      [Token(Token = "0x601143D"), Address(RVA = "0x4A1ACEC", Offset = "0x4A1ACEC", VA = "0x4A1ACEC")] get
      {
        return new int();
      }
      [Token(Token = "0x601143E"), Address(RVA = "0x4A1ACF4", Offset = "0x4A1ACF4", VA = "0x4A1ACF4")] private set
      {
      }
    }

    [Token(Token = "0x17003B91")]
    public int Experience
    {
      [Token(Token = "0x601143F"), Address(RVA = "0x4A1ACFC", Offset = "0x4A1ACFC", VA = "0x4A1ACFC")] get
      {
        return new int();
      }
      [Token(Token = "0x6011440"), Address(RVA = "0x4A1AD04", Offset = "0x4A1AD04", VA = "0x4A1AD04")] private set
      {
      }
    }

    [Token(Token = "0x17003B92")]
    public int PreTitleId
    {
      [Token(Token = "0x6011441"), Address(RVA = "0x4A1AD0C", Offset = "0x4A1AD0C", VA = "0x4A1AD0C", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x6011442"), Address(RVA = "0x4A1AD14", Offset = "0x4A1AD14", VA = "0x4A1AD14")] private set
      {
      }
    }

    [Token(Token = "0x17003B93")]
    public int PostTitleId
    {
      [Token(Token = "0x6011443"), Address(RVA = "0x4A1AD1C", Offset = "0x4A1AD1C", VA = "0x4A1AD1C", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x6011444"), Address(RVA = "0x4A1AD24", Offset = "0x4A1AD24", VA = "0x4A1AD24")] private set
      {
      }
    }

    [Token(Token = "0x17003B94")]
    public int TitleFrameId
    {
      [Token(Token = "0x6011445"), Address(RVA = "0x4A1AD2C", Offset = "0x4A1AD2C", VA = "0x4A1AD2C", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x6011446"), Address(RVA = "0x4A1AD34", Offset = "0x4A1AD34", VA = "0x4A1AD34")] private set
      {
      }
    }

    [Token(Token = "0x17003B95")]
    public DateTime LastSignedInAt
    {
      [Token(Token = "0x6011447"), Address(RVA = "0x4A1AD3C", Offset = "0x4A1AD3C", VA = "0x4A1AD3C")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6011448"), Address(RVA = "0x4A1AD44", Offset = "0x4A1AD44", VA = "0x4A1AD44")] private set
      {
      }
    }

    [Token(Token = "0x17003B96")]
    public int Role
    {
      [Token(Token = "0x6011449"), Address(RVA = "0x4A1AD4C", Offset = "0x4A1AD4C", VA = "0x4A1AD4C")] get
      {
        return new int();
      }
      [Token(Token = "0x601144A"), Address(RVA = "0x4A1AD54", Offset = "0x4A1AD54", VA = "0x4A1AD54")] private set
      {
      }
    }

    [Token(Token = "0x17003B97")]
    public int ContributionPoint
    {
      [Token(Token = "0x601144B"), Address(RVA = "0x4A1AD5C", Offset = "0x4A1AD5C", VA = "0x4A1AD5C")] get
      {
        return new int();
      }
      [Token(Token = "0x601144C"), Address(RVA = "0x4A1AD64", Offset = "0x4A1AD64", VA = "0x4A1AD64")] private set
      {
      }
    }

    [Token(Token = "0x17003B98")]
    public GuildRoleTypeEnum? RoleType
    {
      [Token(Token = "0x601144D"), Address(RVA = "0x4A0A804", Offset = "0x4A0A804", VA = "0x4A0A804")] get
      {
        return new GuildRoleTypeEnum?();
      }
    }

    [Token(Token = "0x17003B99")]
    public string Comment
    {
      [Token(Token = "0x601144E"), Address(RVA = "0x4A1AD6C", Offset = "0x4A1AD6C", VA = "0x4A1AD6C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601144F"), Address(RVA = "0x4A1AD74", Offset = "0x4A1AD74", VA = "0x4A1AD74")] private set
      {
      }
    }

    [Token(Token = "0x17003B9A")]
    public DateTime JoinedAt
    {
      [Token(Token = "0x6011450"), Address(RVA = "0x4A1AD7C", Offset = "0x4A1AD7C", VA = "0x4A1AD7C")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6011451"), Address(RVA = "0x4A1AD84", Offset = "0x4A1AD84", VA = "0x4A1AD84")] private set
      {
      }
    }

    [Token(Token = "0x17003B9B")]
    public int SymbolUnitId
    {
      [Token(Token = "0x6011452"), Address(RVA = "0x4A1AD8C", Offset = "0x4A1AD8C", VA = "0x4A1AD8C")] get
      {
        return new int();
      }
      [Token(Token = "0x6011453"), Address(RVA = "0x4A1AD94", Offset = "0x4A1AD94", VA = "0x4A1AD94")] private set
      {
      }
    }

    [Token(Token = "0x6011454")]
    [Address(RVA = "0x4A1AD9C", Offset = "0x4A1AD9C", VA = "0x4A1AD9C")]
    public GuildMemberInfo()
    {
    }

    [Token(Token = "0x17003B9C")]
    public int Level
    {
      [Token(Token = "0x6011455"), Address(RVA = "0x4A0A868", Offset = "0x4A0A868", VA = "0x4A0A868")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003B9D")]
    public int NextLevelExp
    {
      [Token(Token = "0x6011456"), Address(RVA = "0x4A14F84", Offset = "0x4A14F84", VA = "0x4A14F84")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003B9E")]
    public float NextLevelExpRate
    {
      [Token(Token = "0x6011457"), Address(RVA = "0x4A14FB4", Offset = "0x4A14FB4", VA = "0x4A14FB4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6011458")]
    [Address(RVA = "0x4A1ADA4", Offset = "0x4A1ADA4", VA = "0x4A1ADA4")]
    private PlayerExpData GetNowLevelData(bool isNext = false) => (PlayerExpData) null;

    [Token(Token = "0x6011459")]
    [Address(RVA = "0x4A0A044", Offset = "0x4A0A044", VA = "0x4A0A044")]
    public void ApplyGuildId(string guildId)
    {
    }

    [Token(Token = "0x601145A")]
    [Address(RVA = "0x4A1AEA4", Offset = "0x4A1AEA4", VA = "0x4A1AEA4")]
    public void ApplyPlayerId(string playerId)
    {
    }

    [Token(Token = "0x601145B")]
    [Address(RVA = "0x4A1AEAC", Offset = "0x4A1AEAC", VA = "0x4A1AEAC")]
    public void ApplyPlayerName(string playerName)
    {
    }

    [Token(Token = "0x601145C")]
    [Address(RVA = "0x4A1AEB4", Offset = "0x4A1AEB4", VA = "0x4A1AEB4")]
    public void ApplyEmblemId(int emblemId)
    {
    }

    [Token(Token = "0x601145D")]
    [Address(RVA = "0x4A1AEBC", Offset = "0x4A1AEBC", VA = "0x4A1AEBC")]
    public void ApplyExperience(int experience)
    {
    }

    [Token(Token = "0x601145E")]
    [Address(RVA = "0x4A1AED0", Offset = "0x4A1AED0", VA = "0x4A1AED0")]
    public void ApplyTitleInfo(IPlayerTitleInfo playerTitleInfo)
    {
    }

    [Token(Token = "0x601145F")]
    [Address(RVA = "0x4A1B050", Offset = "0x4A1B050", VA = "0x4A1B050")]
    public void ApplyTitleInfo(int titleId, int postId, int frameId)
    {
    }

    [Token(Token = "0x6011460")]
    [Address(RVA = "0x4A1B038", Offset = "0x4A1B038", VA = "0x4A1B038")]
    public void ApplyPreTitleId(int preTitleId)
    {
    }

    [Token(Token = "0x6011461")]
    [Address(RVA = "0x4A1B040", Offset = "0x4A1B040", VA = "0x4A1B040")]
    public void ApplyPostTitleId(int postTitleId)
    {
    }

    [Token(Token = "0x6011462")]
    [Address(RVA = "0x4A1B048", Offset = "0x4A1B048", VA = "0x4A1B048")]
    public void ApplyTitleFrameId(int titleFrameId)
    {
    }

    [Token(Token = "0x6011463")]
    [Address(RVA = "0x4A1B05C", Offset = "0x4A1B05C", VA = "0x4A1B05C")]
    public void ApplyLastSignedInAt(DateTime lastSignedInAt)
    {
    }

    [Token(Token = "0x6011464")]
    [Address(RVA = "0x4A1B064", Offset = "0x4A1B064", VA = "0x4A1B064")]
    public void ApplyLastSignedInAt(string lastSignedInAt)
    {
    }

    [Token(Token = "0x6011465")]
    [Address(RVA = "0x4A1B0E0", Offset = "0x4A1B0E0", VA = "0x4A1B0E0")]
    public void ApplyRole(int role)
    {
    }

    [Token(Token = "0x6011466")]
    [Address(RVA = "0x4A1B0E8", Offset = "0x4A1B0E8", VA = "0x4A1B0E8")]
    public void ApplyContributionPoint(int contributionPoint)
    {
    }

    [Token(Token = "0x6011467")]
    [Address(RVA = "0x4A1B0F0", Offset = "0x4A1B0F0", VA = "0x4A1B0F0")]
    public void ApplyComment(string comment)
    {
    }

    [Token(Token = "0x6011468")]
    [Address(RVA = "0x4A1B0F8", Offset = "0x4A1B0F8", VA = "0x4A1B0F8")]
    public void ApplyJoinedAt(DateTime joinedAt)
    {
    }

    [Token(Token = "0x6011469")]
    [Address(RVA = "0x4A1B100", Offset = "0x4A1B100", VA = "0x4A1B100")]
    public void ApplyJoinedAt(string joinedAt)
    {
    }

    [Token(Token = "0x601146A")]
    [Address(RVA = "0x4A1B17C", Offset = "0x4A1B17C", VA = "0x4A1B17C")]
    public void ApplySymbolUnitId(int symbolUnitId)
    {
    }

    [Token(Token = "0x601146B")]
    [Address(RVA = "0x4A1B184", Offset = "0x4A1B184", VA = "0x4A1B184")]
    public void ApplyGuildMemberType(GuildMemberType guildMemberType)
    {
    }
  }
}
