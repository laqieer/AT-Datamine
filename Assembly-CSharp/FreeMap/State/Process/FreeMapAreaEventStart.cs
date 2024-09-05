// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapAreaEventStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017BF")]
  public class FreeMapAreaEventStart : FreeMapProcess
  {
    [Token(Token = "0x60086A6")]
    [Address(RVA = "0x43D0C6C", Offset = "0x43D0C6C", VA = "0x43D0C6C")]
    public FreeMapAreaEventStart(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60086A7")]
    [Address(RVA = "0x43D0C70", Offset = "0x43D0C70", VA = "0x43D0C70")]
    public static FreeMapProcess PreLoad(
      FreeMapStateManager entity,
      StoryFreeActionSettingData setting)
    {
      return (FreeMapProcess) null;
    }

    [Token(Token = "0x60086A8")]
    [Address(RVA = "0x43D0FC0", Offset = "0x43D0FC0", VA = "0x43D0FC0", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x20017C0")]
    private class AreaSetup : FreeMapProcess
    {
      [Token(Token = "0x1700155E")]
      protected PlayingStoryInfo StoryInfo
      {
        [Token(Token = "0x60086A9"), Address(RVA = "0x43D1220", Offset = "0x43D1220", VA = "0x43D1220")] get
        {
          return (PlayingStoryInfo) null;
        }
      }

      [Token(Token = "0x1700155F")]
      protected StoryFreeActionSettingData SettingData
      {
        [Token(Token = "0x60086AA"), Address(RVA = "0x43D123C", Offset = "0x43D123C", VA = "0x43D123C")] get
        {
          return (StoryFreeActionSettingData) null;
        }
      }

      [Token(Token = "0x60086AB")]
      [Address(RVA = "0x43D0EEC", Offset = "0x43D0EEC", VA = "0x43D0EEC")]
      public AreaSetup(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60086AC")]
      [Address(RVA = "0x43D1258", Offset = "0x43D1258", VA = "0x43D1258", Slot = "4")]
      public override void Begin()
      {
      }
    }

    [Token(Token = "0x20017C1")]
    private class AreaStarted : FreeMapProcess
    {
      [Token(Token = "0x17001560")]
      protected PlayingStoryInfo StoryInfo
      {
        [Token(Token = "0x60086AD"), Address(RVA = "0x43D1370", Offset = "0x43D1370", VA = "0x43D1370")] get
        {
          return (PlayingStoryInfo) null;
        }
      }

      [Token(Token = "0x17001561")]
      protected StoryFreeActionSettingData SettingData
      {
        [Token(Token = "0x60086AE"), Address(RVA = "0x43D138C", Offset = "0x43D138C", VA = "0x43D138C")] get
        {
          return (StoryFreeActionSettingData) null;
        }
      }

      [Token(Token = "0x60086AF")]
      [Address(RVA = "0x43D121C", Offset = "0x43D121C", VA = "0x43D121C")]
      public AreaStarted(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60086B0")]
      [Address(RVA = "0x43D13A8", Offset = "0x43D13A8", VA = "0x43D13A8", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
