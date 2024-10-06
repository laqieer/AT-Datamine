// Decompiled with JetBrains decompiler
// Type: Network.Param.IBattleSettingsParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A71")]
  public interface IBattleSettingsParameters
  {
    [Token(Token = "0x170019B0")]
    bool IsAutoSetting { [Token(Token = "0x6009866")] get; [Token(Token = "0x6009867")] set; }

    [Token(Token = "0x170019B1")]
    bool IsSkipArrange { [Token(Token = "0x6009868")] get; [Token(Token = "0x6009869")] set; }

    [Token(Token = "0x170019B2")]
    bool Speed { [Token(Token = "0x600986A")] get; [Token(Token = "0x600986B")] set; }

    [Token(Token = "0x170019B3")]
    bool Duel { [Token(Token = "0x600986C")] get; [Token(Token = "0x600986D")] set; }

    [Token(Token = "0x170019B4")]
    bool Grid { [Token(Token = "0x600986E")] get; [Token(Token = "0x600986F")] set; }
  }
}
