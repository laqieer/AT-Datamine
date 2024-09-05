// Decompiled with JetBrains decompiler
// Type: Story.Chart.RememberTrackModify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UI.Direction;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006E1")]
  public class RememberTrackModify
  {
    [Token(Token = "0x170005D1")]
    public List<RememberTrackModify.ITrackModify> Modifies
    {
      [Token(Token = "0x6002714"), Address(RVA = "0x366BFB4", Offset = "0x366BFB4", VA = "0x366BFB4")] get
      {
        return (List<RememberTrackModify.ITrackModify>) null;
      }
    }

    [Token(Token = "0x6002715")]
    [Address(RVA = "0x366BFBC", Offset = "0x366BFBC", VA = "0x366BFBC")]
    public void Remember(UITimelineController timeline)
    {
    }

    [Token(Token = "0x6002716")]
    [Address(RVA = "0x366C16C", Offset = "0x366C16C", VA = "0x366C16C")]
    public RememberTrackModify()
    {
    }

    [Token(Token = "0x20006E2")]
    public interface ITrackModify
    {
      [Token(Token = "0x6002717")]
      void Remember(UITimelineController timeline);
    }

    [Token(Token = "0x20006E3")]
    public class Mute : RememberTrackModify.ITrackModify
    {
      [Token(Token = "0x170005D2")]
      public string TrackName
      {
        [Token(Token = "0x6002718"), Address(RVA = "0x366C1E8", Offset = "0x366C1E8", VA = "0x366C1E8")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6002719"), Address(RVA = "0x366C1F0", Offset = "0x366C1F0", VA = "0x366C1F0")] set
        {
        }
      }

      [Token(Token = "0x170005D3")]
      public bool Value
      {
        [Token(Token = "0x600271A"), Address(RVA = "0x366C1F8", Offset = "0x366C1F8", VA = "0x366C1F8")] get
        {
          return new bool();
        }
        [Token(Token = "0x600271B"), Address(RVA = "0x366C200", Offset = "0x366C200", VA = "0x366C200")] set
        {
        }
      }

      [Token(Token = "0x600271C")]
      [Address(RVA = "0x366BDF0", Offset = "0x366BDF0", VA = "0x366BDF0")]
      public Mute(string trackname, bool mute)
      {
      }

      [Token(Token = "0x600271D")]
      [Address(RVA = "0x366C20C", Offset = "0x366C20C", VA = "0x366C20C", Slot = "4")]
      private void Story\u002EChart\u002ERememberTrackModify\u002EITrackModify\u002ERemember(
        UITimelineController timeline)
      {
      }
    }
  }
}
