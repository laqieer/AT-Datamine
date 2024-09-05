// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Data.GuildJoinRequestPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Guild.Data
{
  [Token(Token = "0x2002C1C")]
  public class GuildJoinRequestPlayerInfo
  {
    [Token(Token = "0x17003B86")]
    public string PlayerId
    {
      [Token(Token = "0x6011421"), Address(RVA = "0x4A1AB18", Offset = "0x4A1AB18", VA = "0x4A1AB18")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6011422"), Address(RVA = "0x4A1AB20", Offset = "0x4A1AB20", VA = "0x4A1AB20")] private set
      {
      }
    }

    [Token(Token = "0x17003B87")]
    public string PlayerName
    {
      [Token(Token = "0x6011423"), Address(RVA = "0x4A1AB28", Offset = "0x4A1AB28", VA = "0x4A1AB28")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6011424"), Address(RVA = "0x4A1AB30", Offset = "0x4A1AB30", VA = "0x4A1AB30")] private set
      {
      }
    }

    [Token(Token = "0x17003B88")]
    public int Experience
    {
      [Token(Token = "0x6011425"), Address(RVA = "0x4A1AB38", Offset = "0x4A1AB38", VA = "0x4A1AB38")] get
      {
        return new int();
      }
      [Token(Token = "0x6011426"), Address(RVA = "0x4A1AB40", Offset = "0x4A1AB40", VA = "0x4A1AB40")] private set
      {
      }
    }

    [Token(Token = "0x17003B89")]
    public int Level
    {
      [Token(Token = "0x6011427"), Address(RVA = "0x4A1AB48", Offset = "0x4A1AB48", VA = "0x4A1AB48")] get
      {
        return new int();
      }
      [Token(Token = "0x6011428"), Address(RVA = "0x4A1AB50", Offset = "0x4A1AB50", VA = "0x4A1AB50")] private set
      {
      }
    }

    [Token(Token = "0x17003B8A")]
    public string GuildId
    {
      [Token(Token = "0x6011429"), Address(RVA = "0x4A1AB58", Offset = "0x4A1AB58", VA = "0x4A1AB58")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601142A"), Address(RVA = "0x4A1AB60", Offset = "0x4A1AB60", VA = "0x4A1AB60")] private set
      {
      }
    }

    [Token(Token = "0x17003B8B")]
    public DateTime RequestedAt
    {
      [Token(Token = "0x601142B"), Address(RVA = "0x4A1AB68", Offset = "0x4A1AB68", VA = "0x4A1AB68")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x601142C"), Address(RVA = "0x4A1AB70", Offset = "0x4A1AB70", VA = "0x4A1AB70")] private set
      {
      }
    }

    [Token(Token = "0x17003B8C")]
    public DateTime LastSignedInAt
    {
      [Token(Token = "0x601142D"), Address(RVA = "0x4A1AB78", Offset = "0x4A1AB78", VA = "0x4A1AB78")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x601142E"), Address(RVA = "0x4A1AB80", Offset = "0x4A1AB80", VA = "0x4A1AB80")] private set
      {
      }
    }

    [Token(Token = "0x601142F")]
    [Address(RVA = "0x4A1AB88", Offset = "0x4A1AB88", VA = "0x4A1AB88")]
    public void ApplyPlayerId(string playerId)
    {
    }

    [Token(Token = "0x6011430")]
    [Address(RVA = "0x4A1AB90", Offset = "0x4A1AB90", VA = "0x4A1AB90")]
    public void ApplyPlayerName(string playerName)
    {
    }

    [Token(Token = "0x6011431")]
    [Address(RVA = "0x4A1AB98", Offset = "0x4A1AB98", VA = "0x4A1AB98")]
    public void ApplyExperience(int experience)
    {
    }

    [Token(Token = "0x6011432")]
    [Address(RVA = "0x4A1AC4C", Offset = "0x4A1AC4C", VA = "0x4A1AC4C")]
    public void ApplyGuildId(string guildId)
    {
    }

    [Token(Token = "0x6011433")]
    [Address(RVA = "0x4A1AC54", Offset = "0x4A1AC54", VA = "0x4A1AC54")]
    public void ApplyRequestedAt(DateTime requestedAt)
    {
    }

    [Token(Token = "0x6011434")]
    [Address(RVA = "0x4A1AC5C", Offset = "0x4A1AC5C", VA = "0x4A1AC5C")]
    public void ApplyLastSignedInAt(DateTime lastSignedInAt)
    {
    }

    [Token(Token = "0x6011435")]
    [Address(RVA = "0x4A1ABB0", Offset = "0x4A1ABB0", VA = "0x4A1ABB0")]
    private void OnExperienceChanged(int value)
    {
    }

    [Token(Token = "0x6011436")]
    [Address(RVA = "0x4A1AC64", Offset = "0x4A1AC64", VA = "0x4A1AC64")]
    public GuildJoinRequestPlayerInfo()
    {
    }
  }
}
