// Decompiled with JetBrains decompiler
// Type: Scenes.Home.Balloons.HomeEventQuestBalloonModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Home.Balloons
{
  [Token(Token = "0x2002B68")]
  public class HomeEventQuestBalloonModel
  {
    [Token(Token = "0x400B8DA")]
    [FieldOffset(Offset = "0x10")]
    public readonly string WarningToasterKey;

    [Token(Token = "0x17003A8F")]
    public int EventID
    {
      [Token(Token = "0x6010F61"), Address(RVA = "0x1C71C0C", Offset = "0x1C71C0C", VA = "0x1C71C0C")] get
      {
        return new int();
      }
      [Token(Token = "0x6010F62"), Address(RVA = "0x1C71C14", Offset = "0x1C71C14", VA = "0x1C71C14")] private set
      {
      }
    }

    [Token(Token = "0x17003A90")]
    public EventBalloonTypeEnum EventType
    {
      [Token(Token = "0x6010F63"), Address(RVA = "0x1C71C1C", Offset = "0x1C71C1C", VA = "0x1C71C1C")] get
      {
        return new EventBalloonTypeEnum();
      }
      [Token(Token = "0x6010F64"), Address(RVA = "0x1C71C24", Offset = "0x1C71C24", VA = "0x1C71C24")] private set
      {
      }
    }

    [Token(Token = "0x17003A91")]
    public string BannerImageName
    {
      [Token(Token = "0x6010F65"), Address(RVA = "0x1C71C2C", Offset = "0x1C71C2C", VA = "0x1C71C2C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6010F66"), Address(RVA = "0x1C71C34", Offset = "0x1C71C34", VA = "0x1C71C34")] private set
      {
      }
    }

    [Token(Token = "0x17003A92")]
    public bool NotFoundData
    {
      [Token(Token = "0x6010F67"), Address(RVA = "0x1C71C3C", Offset = "0x1C71C3C", VA = "0x1C71C3C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010F68"), Address(RVA = "0x1C71C44", Offset = "0x1C71C44", VA = "0x1C71C44")] private set
      {
      }
    }

    [Token(Token = "0x17003A93")]
    public bool IsCloseBanner
    {
      [Token(Token = "0x6010F69"), Address(RVA = "0x1C71C50", Offset = "0x1C71C50", VA = "0x1C71C50")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010F6A"), Address(RVA = "0x1C71C58", Offset = "0x1C71C58", VA = "0x1C71C58")] private set
      {
      }
    }

    [Token(Token = "0x17003A94")]
    public bool IsEventLock
    {
      [Token(Token = "0x6010F6B"), Address(RVA = "0x1C71C64", Offset = "0x1C71C64", VA = "0x1C71C64")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010F6C"), Address(RVA = "0x1C71C6C", Offset = "0x1C71C6C", VA = "0x1C71C6C")] private set
      {
      }
    }

    [Token(Token = "0x6010F6D")]
    [Address(RVA = "0x1C71C78", Offset = "0x1C71C78", VA = "0x1C71C78")]
    public static HomeEventQuestBalloonModel Create() => (HomeEventQuestBalloonModel) null;

    [Token(Token = "0x6010F6E")]
    [Address(RVA = "0x1C71E2C", Offset = "0x1C71E2C", VA = "0x1C71E2C")]
    public void SwitchShowBannerFlag()
    {
    }

    [Token(Token = "0x6010F6F")]
    [Address(RVA = "0x1C71D28", Offset = "0x1C71D28", VA = "0x1C71D28")]
    private void Init()
    {
    }

    [Token(Token = "0x6010F70")]
    [Address(RVA = "0x1C71CD8", Offset = "0x1C71CD8", VA = "0x1C71CD8")]
    public HomeEventQuestBalloonModel()
    {
    }
  }
}
