// Decompiled with JetBrains decompiler
// Type: StaqData.StoryGachaInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002138")]
  public class StoryGachaInfo
  {
    [Token(Token = "0x17002C65")]
    public int Number
    {
      [Token(Token = "0x600CB5B"), Address(RVA = "0x1BA9770", Offset = "0x1BA9770", VA = "0x1BA9770")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB5C"), Address(RVA = "0x1BA9778", Offset = "0x1BA9778", VA = "0x1BA9778")] private set
      {
      }
    }

    [Token(Token = "0x17002C66")]
    public int GroupId
    {
      [Token(Token = "0x600CB5D"), Address(RVA = "0x1BA9780", Offset = "0x1BA9780", VA = "0x1BA9780")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB5E"), Address(RVA = "0x1BA9788", Offset = "0x1BA9788", VA = "0x1BA9788")] private set
      {
      }
    }

    [Token(Token = "0x17002C67")]
    public string Title
    {
      [Token(Token = "0x600CB5F"), Address(RVA = "0x1BA9790", Offset = "0x1BA9790", VA = "0x1BA9790")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB60"), Address(RVA = "0x1BA9798", Offset = "0x1BA9798", VA = "0x1BA9798")] private set
      {
      }
    }

    [Token(Token = "0x17002C68")]
    public bool IsReleased
    {
      [Token(Token = "0x600CB61"), Address(RVA = "0x1BA97A0", Offset = "0x1BA97A0", VA = "0x1BA97A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CB62"), Address(RVA = "0x1BA97A8", Offset = "0x1BA97A8", VA = "0x1BA97A8")] private set
      {
      }
    }

    [Token(Token = "0x17002C69")]
    public int ReleaseSequenceId
    {
      [Token(Token = "0x600CB63"), Address(RVA = "0x1BA97B4", Offset = "0x1BA97B4", VA = "0x1BA97B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB64"), Address(RVA = "0x1BA97BC", Offset = "0x1BA97BC", VA = "0x1BA97BC")] private set
      {
      }
    }

    [Token(Token = "0x17002C6A")]
    public string ReleaseMessageText
    {
      [Token(Token = "0x600CB65"), Address(RVA = "0x1BA97C4", Offset = "0x1BA97C4", VA = "0x1BA97C4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB66"), Address(RVA = "0x1BA97CC", Offset = "0x1BA97CC", VA = "0x1BA97CC")] private set
      {
      }
    }

    [Token(Token = "0x17002C6B")]
    public StoryGachaNoticeType NoticeStatus
    {
      [Token(Token = "0x600CB67"), Address(RVA = "0x1BA97D4", Offset = "0x1BA97D4", VA = "0x1BA97D4")] get
      {
        return new StoryGachaNoticeType();
      }
      [Token(Token = "0x600CB68"), Address(RVA = "0x1BA97DC", Offset = "0x1BA97DC", VA = "0x1BA97DC")] private set
      {
      }
    }

    [Token(Token = "0x17002C6C")]
    public bool NeedReleaseNotification
    {
      [Token(Token = "0x600CB69"), Address(RVA = "0x1BA97E4", Offset = "0x1BA97E4", VA = "0x1BA97E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CB6A")]
    [Address(RVA = "0x1BA95E0", Offset = "0x1BA95E0", VA = "0x1BA95E0")]
    public static StoryGachaInfo CreateFromServerData(StoryGachaInfoType serverData)
    {
      return (StoryGachaInfo) null;
    }

    [Token(Token = "0x600CB6B")]
    [Address(RVA = "0x1BA97FC", Offset = "0x1BA97FC", VA = "0x1BA97FC")]
    public string GetSequenceName() => (string) null;

    [Token(Token = "0x600CB6C")]
    [Address(RVA = "0x1BA97F4", Offset = "0x1BA97F4", VA = "0x1BA97F4")]
    public StoryGachaInfo()
    {
    }
  }
}
