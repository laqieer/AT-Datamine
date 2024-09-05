// Decompiled with JetBrains decompiler
// Type: Gacha.StoryGachaNotificationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveData;
using StaqData;
using System;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001570")]
  internal class StoryGachaNotificationData
  {
    [Token(Token = "0x400625D")]
    [FieldOffset(Offset = "0x20")]
    public Action<bool> DetailReleaseNotifyChanged;

    [Token(Token = "0x1700129A")]
    private StoryGachaSaveData saveData
    {
      [Token(Token = "0x600795F"), Address(RVA = "0x2295934", Offset = "0x2295934", VA = "0x2295934")] get
      {
        return (StoryGachaSaveData) null;
      }
    }

    [Token(Token = "0x1700129B")]
    public bool IsReleased
    {
      [Token(Token = "0x6007960"), Address(RVA = "0x22959AC", Offset = "0x22959AC", VA = "0x22959AC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007961"), Address(RVA = "0x22959B4", Offset = "0x22959B4", VA = "0x22959B4")] private set
      {
      }
    }

    [Token(Token = "0x1700129C")]
    public int GroupId
    {
      [Token(Token = "0x6007962"), Address(RVA = "0x22959C0", Offset = "0x22959C0", VA = "0x22959C0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007963"), Address(RVA = "0x22959C8", Offset = "0x22959C8", VA = "0x22959C8")] private set
      {
      }
    }

    [Token(Token = "0x1700129D")]
    public string Title
    {
      [Token(Token = "0x6007964"), Address(RVA = "0x22959D0", Offset = "0x22959D0", VA = "0x22959D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007965"), Address(RVA = "0x22959D8", Offset = "0x22959D8", VA = "0x22959D8")] private set
      {
      }
    }

    [Token(Token = "0x1700129E")]
    public bool IsReleaseNotifiedInGachaTop
    {
      [Token(Token = "0x6007966"), Address(RVA = "0x22959E0", Offset = "0x22959E0", VA = "0x22959E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700129F")]
    public bool IsReleaseNotifiedInGachaDetail
    {
      [Token(Token = "0x6007967"), Address(RVA = "0x2295A04", Offset = "0x2295A04", VA = "0x2295A04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170012A0")]
    public bool IsReleaseNotifiedInFreeAction
    {
      [Token(Token = "0x6007968"), Address(RVA = "0x2295A28", Offset = "0x2295A28", VA = "0x2295A28")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170012A1")]
    public bool DetailNeedUnlockNotification
    {
      [Token(Token = "0x6007969"), Address(RVA = "0x2295A4C", Offset = "0x2295A4C", VA = "0x2295A4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600796A")]
    [Address(RVA = "0x2295A6C", Offset = "0x2295A6C", VA = "0x2295A6C")]
    public static StoryGachaNotificationData Create(StoryGachaInfo storyGachaInfo)
    {
      return (StoryGachaNotificationData) null;
    }

    [Token(Token = "0x600796B")]
    [Address(RVA = "0x2295AF0", Offset = "0x2295AF0", VA = "0x2295AF0")]
    public static StoryGachaNotificationData Create(string title)
    {
      return (StoryGachaNotificationData) null;
    }

    [Token(Token = "0x600796C")]
    [Address(RVA = "0x2295AE8", Offset = "0x2295AE8", VA = "0x2295AE8")]
    private StoryGachaNotificationData()
    {
    }

    [Token(Token = "0x600796D")]
    [Address(RVA = "0x2295B5C", Offset = "0x2295B5C", VA = "0x2295B5C")]
    public void NotifiedInFreeAction()
    {
    }

    [Token(Token = "0x600796E")]
    [Address(RVA = "0x2295BA8", Offset = "0x2295BA8", VA = "0x2295BA8")]
    public void NotifiedInStoryGachaTop()
    {
    }

    [Token(Token = "0x600796F")]
    [Address(RVA = "0x2295BDC", Offset = "0x2295BDC", VA = "0x2295BDC")]
    public void NotifiedInStoryGachaDetail()
    {
    }
  }
}
