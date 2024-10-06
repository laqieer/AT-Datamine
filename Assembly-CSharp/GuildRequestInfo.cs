// Decompiled with JetBrains decompiler
// Type: GuildRequestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x20001CC")]
public class GuildRequestInfo
{
  [Token(Token = "0x170000E2")]
  public string requestingGuildID
  {
    [Token(Token = "0x6000BAF"), Address(RVA = "0x4C70524", Offset = "0x4C70524", VA = "0x4C70524")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000BB0"), Address(RVA = "0x4C7052C", Offset = "0x4C7052C", VA = "0x4C7052C")] private set
    {
    }
  }

  [Token(Token = "0x170000E3")]
  public string requestingAt
  {
    [Token(Token = "0x6000BB1"), Address(RVA = "0x4C70534", Offset = "0x4C70534", VA = "0x4C70534")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000BB2"), Address(RVA = "0x4C7053C", Offset = "0x4C7053C", VA = "0x4C7053C")] private set
    {
    }
  }

  [Token(Token = "0x170000E4")]
  public bool IsGuildRequesting
  {
    [Token(Token = "0x6000BB3"), Address(RVA = "0x4C70544", Offset = "0x4C70544", VA = "0x4C70544")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000BB4")]
  [Address(RVA = "0x4C705C4", Offset = "0x4C705C4", VA = "0x4C705C4")]
  public void Apply(string guildID, string requestTime)
  {
  }

  [Token(Token = "0x6000BB5")]
  [Address(RVA = "0x4C705CC", Offset = "0x4C705CC", VA = "0x4C705CC")]
  public void ResetData()
  {
  }

  [Token(Token = "0x6000BB6")]
  [Address(RVA = "0x4C7061C", Offset = "0x4C7061C", VA = "0x4C7061C")]
  public GuildRequestInfo()
  {
  }
}
