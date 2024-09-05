// Decompiled with JetBrains decompiler
// Type: Home.HomeTimeAnnouncementClock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B44")]
  public class HomeTimeAnnouncementClock : SingletonMonoBehaviour<HomeTimeAnnouncementClock>
  {
    [Token(Token = "0x4003399")]
    [FieldOffset(Offset = "0x19")]
    private bool isFirstTimeAnnoucement;
    [Token(Token = "0x400339A")]
    [FieldOffset(Offset = "0x1C")]
    private int lastTimeAnnoumcenentHour;

    [Token(Token = "0x600402C")]
    [Address(RVA = "0x2A2455C", Offset = "0x2A2455C", VA = "0x2A2455C", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x600402D")]
    [Address(RVA = "0x2A24560", Offset = "0x2A24560", VA = "0x2A24560")]
    private void UpdateTimeAnnouncementClock()
    {
    }

    [Token(Token = "0x600402E")]
    [Address(RVA = "0x2A24600", Offset = "0x2A24600", VA = "0x2A24600")]
    public void Announce()
    {
    }

    [Token(Token = "0x600402F")]
    [Address(RVA = "0x2A22FB8", Offset = "0x2A22FB8", VA = "0x2A22FB8")]
    public bool CanSpeakTimeAnnouncement() => new bool();

    [Token(Token = "0x6004030")]
    [Address(RVA = "0x2A24620", Offset = "0x2A24620", VA = "0x2A24620")]
    public int CurrentTimeAnnouncementId() => new int();

    [Token(Token = "0x6004031")]
    [Address(RVA = "0x2A24848", Offset = "0x2A24848", VA = "0x2A24848")]
    public HomeTimeAnnouncementClock()
    {
    }
  }
}
