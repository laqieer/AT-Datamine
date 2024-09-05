// Decompiled with JetBrains decompiler
// Type: Home.HomeVoicePack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B51")]
  public class HomeVoicePack
  {
    [Token(Token = "0x1700096B")]
    public List<HomeVoicePack.HomeSerif> SerifList
    {
      [Token(Token = "0x6004086"), Address(RVA = "0x2A274F8", Offset = "0x2A274F8", VA = "0x2A274F8")] get
      {
        return (List<HomeVoicePack.HomeSerif>) null;
      }
    }

    [Token(Token = "0x6004087")]
    [Address(RVA = "0x2A27500", Offset = "0x2A27500", VA = "0x2A27500")]
    public HomeVoicePack.HomeSerif GetByTimeAnnouncement(int timeAnnouncementId)
    {
      return new HomeVoicePack.HomeSerif();
    }

    [Token(Token = "0x6004088")]
    [Address(RVA = "0x2A27608", Offset = "0x2A27608", VA = "0x2A27608")]
    public HomeVoicePack.HomeSerif GetRandom() => new HomeVoicePack.HomeSerif();

    [Token(Token = "0x6004089")]
    [Address(RVA = "0x2A276A4", Offset = "0x2A276A4", VA = "0x2A276A4")]
    public HomeVoicePack()
    {
    }

    [Token(Token = "0x2000B52")]
    public readonly struct HomeSerif
    {
      [Token(Token = "0x40033C1")]
      [FieldOffset(Offset = "0x0")]
      public readonly string SerifText;
      [Token(Token = "0x40033C2")]
      [FieldOffset(Offset = "0x8")]
      public readonly int TimelineActId;
      [Token(Token = "0x40033C3")]
      [FieldOffset(Offset = "0x10")]
      public readonly string VoiceBankId;
      [Token(Token = "0x40033C4")]
      [FieldOffset(Offset = "0x18")]
      public readonly string VoiceId;
      [Token(Token = "0x40033C5")]
      [FieldOffset(Offset = "0x20")]
      public readonly int TimeAnnouncementId;

      [Token(Token = "0x600408A")]
      [Address(RVA = "0x2A27720", Offset = "0x2A27720", VA = "0x2A27720")]
      public HomeSerif(
        string serifText,
        int timelineActId,
        string voiceBankId,
        string voiceId,
        int timeAnnouncementId)
      {
      }
    }
  }
}
