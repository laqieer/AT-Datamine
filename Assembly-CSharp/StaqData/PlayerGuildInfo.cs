// Decompiled with JetBrains decompiler
// Type: StaqData.PlayerGuildInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002008")]
  public class PlayerGuildInfo
  {
    [Token(Token = "0x17002783")]
    public string GuildId
    {
      [Token(Token = "0x600BEA9"), Address(RVA = "0x2002DFC", Offset = "0x2002DFC", VA = "0x2002DFC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BEAA"), Address(RVA = "0x2002E04", Offset = "0x2002E04", VA = "0x2002E04")] private set
      {
      }
    }

    [Token(Token = "0x17002784")]
    public GuildRoleTypeEnum Role
    {
      [Token(Token = "0x600BEAB"), Address(RVA = "0x2002E0C", Offset = "0x2002E0C", VA = "0x2002E0C")] get
      {
        return new GuildRoleTypeEnum();
      }
      [Token(Token = "0x600BEAC"), Address(RVA = "0x2002E14", Offset = "0x2002E14", VA = "0x2002E14")] private set
      {
      }
    }

    [Token(Token = "0x17002785")]
    public bool IsRoleRewardReceived
    {
      [Token(Token = "0x600BEAD"), Address(RVA = "0x2002E1C", Offset = "0x2002E1C", VA = "0x2002E1C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BEAE"), Address(RVA = "0x2002E24", Offset = "0x2002E24", VA = "0x2002E24")] private set
      {
      }
    }

    [Token(Token = "0x17002786")]
    public bool IsAttendRewardReceived
    {
      [Token(Token = "0x600BEAF"), Address(RVA = "0x2002E30", Offset = "0x2002E30", VA = "0x2002E30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BEB0"), Address(RVA = "0x2002E38", Offset = "0x2002E38", VA = "0x2002E38")] private set
      {
      }
    }

    [Token(Token = "0x17002787")]
    public bool IsJoined
    {
      [Token(Token = "0x600BEB1"), Address(RVA = "0x2002E44", Offset = "0x2002E44", VA = "0x2002E44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002788")]
    public DateTime JoinCoolTimeEndAt
    {
      [Token(Token = "0x600BEB2"), Address(RVA = "0x2002E64", Offset = "0x2002E64", VA = "0x2002E64")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600BEB3"), Address(RVA = "0x2002E6C", Offset = "0x2002E6C", VA = "0x2002E6C")] private set
      {
      }
    }

    [Token(Token = "0x600BEB4")]
    [Address(RVA = "0x2002E74", Offset = "0x2002E74", VA = "0x2002E74")]
    public void Apply(PlayerGuildInfo playerGuildInfo)
    {
    }

    [Token(Token = "0x600BEB5")]
    [Address(RVA = "0x2002EA0", Offset = "0x2002EA0", VA = "0x2002EA0")]
    public void Apply(string guildId, GuildRoleTypeEnum role)
    {
    }

    [Token(Token = "0x600BEB6")]
    [Address(RVA = "0x2002EAC", Offset = "0x2002EAC", VA = "0x2002EAC")]
    public void ApplyGuildID(string guildId)
    {
    }

    [Token(Token = "0x600BEB7")]
    [Address(RVA = "0x2002EB4", Offset = "0x2002EB4", VA = "0x2002EB4")]
    public void ApplyGuildJoinCoolTimeEndAt(string strJoinCoolTimeEndAt)
    {
    }

    [Token(Token = "0x600BEB8")]
    [Address(RVA = "0x2002F30", Offset = "0x2002F30", VA = "0x2002F30")]
    public void ApplyRole(GuildRoleTypeEnum role)
    {
    }

    [Token(Token = "0x600BEB9")]
    [Address(RVA = "0x2002F38", Offset = "0x2002F38", VA = "0x2002F38")]
    public void ApplyRoleRewardReceived(bool value)
    {
    }

    [Token(Token = "0x600BEBA")]
    [Address(RVA = "0x2002F44", Offset = "0x2002F44", VA = "0x2002F44")]
    public void ApplyAttendRewardReceived(bool value)
    {
    }

    [Token(Token = "0x600BEBB")]
    [Address(RVA = "0x2002F50", Offset = "0x2002F50", VA = "0x2002F50")]
    public PlayerGuildInfo()
    {
    }
  }
}
