// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Logic.TrackerSubSectionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Tracker.UI;
using System;
using System.Collections;

#nullable disable
namespace Story.Tracker.Logic
{
  [Token(Token = "0x20005E3")]
  public class TrackerSubSectionView
  {
    [Token(Token = "0x4001D4A")]
    [FieldOffset(Offset = "0x18")]
    public Func<TrackingProgressData> GetBinded;

    [Token(Token = "0x170004C8")]
    public TrackerSubSectionUI SubSectionUI
    {
      [Token(Token = "0x6002209"), Address(RVA = "0x2D9D8D0", Offset = "0x2D9D8D0", VA = "0x2D9D8D0")] private get
      {
        return (TrackerSubSectionUI) null;
      }
      [Token(Token = "0x600220A"), Address(RVA = "0x2D9D8D8", Offset = "0x2D9D8D8", VA = "0x2D9D8D8")] set
      {
      }
    }

    [Token(Token = "0x170004C9")]
    public float DelaySec
    {
      [Token(Token = "0x600220B"), Address(RVA = "0x2D9D8E0", Offset = "0x2D9D8E0", VA = "0x2D9D8E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170004CA")]
    public bool IsPlaying
    {
      [Token(Token = "0x600220C"), Address(RVA = "0x2D9D8FC", Offset = "0x2D9D8FC", VA = "0x2D9D8FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600220D")]
    [Address(RVA = "0x2D9D920", Offset = "0x2D9D920", VA = "0x2D9D920")]
    public void Update(TrackingProgressData progress)
    {
    }

    [Token(Token = "0x600220E")]
    [Address(RVA = "0x2D9D998", Offset = "0x2D9D998", VA = "0x2D9D998")]
    public void Set(bool check, string title, bool isPurpose)
    {
    }

    [Token(Token = "0x600220F")]
    [Address(RVA = "0x2D9DA80", Offset = "0x2D9DA80", VA = "0x2D9DA80")]
    public void Set(bool check, string title, int current, int max, bool isPurpose)
    {
    }

    [Token(Token = "0x6002210")]
    [Address(RVA = "0x2D9DB3C", Offset = "0x2D9DB3C", VA = "0x2D9DB3C")]
    public void GrayOut(string title)
    {
    }

    [Token(Token = "0x6002211")]
    [Address(RVA = "0x2D9DB78", Offset = "0x2D9DB78", VA = "0x2D9DB78")]
    public void BindRelease()
    {
    }

    [Token(Token = "0x6002212")]
    [Address(RVA = "0x2D9DB80", Offset = "0x2D9DB80", VA = "0x2D9DB80")]
    public void In()
    {
    }

    [Token(Token = "0x6002213")]
    [Address(RVA = "0x2D9DBA0", Offset = "0x2D9DBA0", VA = "0x2D9DBA0")]
    public void Out()
    {
    }

    [Token(Token = "0x6002214")]
    [Address(RVA = "0x2D9DC28", Offset = "0x2D9DC28", VA = "0x2D9DC28")]
    public void Hide()
    {
    }

    [Token(Token = "0x6002215")]
    [Address(RVA = "0x2D9DA28", Offset = "0x2D9DA28", VA = "0x2D9DA28")]
    public void Active()
    {
    }

    [Token(Token = "0x6002216")]
    [Address(RVA = "0x2D9DC40", Offset = "0x2D9DC40", VA = "0x2D9DC40")]
    public bool IsActivate() => new bool();

    [Token(Token = "0x6002217")]
    [Address(RVA = "0x2D9DC68", Offset = "0x2D9DC68", VA = "0x2D9DC68")]
    public void Deactive()
    {
    }

    [Token(Token = "0x6002218")]
    [Address(RVA = "0x2D9DCC4", Offset = "0x2D9DCC4", VA = "0x2D9DCC4")]
    public void CheckAnimation()
    {
    }

    [Token(Token = "0x6002219")]
    [Address(RVA = "0x2D9DCE0", Offset = "0x2D9DCE0", VA = "0x2D9DCE0")]
    public void ChangeAnimation()
    {
    }

    [Token(Token = "0x600221A")]
    [Address(RVA = "0x2D9DCFC", Offset = "0x2D9DCFC", VA = "0x2D9DCFC")]
    private IEnumerator SectionIn(
      bool check,
      string title,
      int current,
      int max,
      bool isPurpose,
      bool isStartOut)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600221B")]
    [Address(RVA = "0x2D9DDDC", Offset = "0x2D9DDDC", VA = "0x2D9DDDC")]
    public void SetTitle(bool check, string title, int current, int max, bool isPurpose)
    {
    }

    [Token(Token = "0x600221C")]
    [Address(RVA = "0x2D9DE68", Offset = "0x2D9DE68", VA = "0x2D9DE68")]
    private IEnumerator SectionChange(
      bool check,
      string title,
      int current,
      int max,
      bool isPurpose)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600221D")]
    [Address(RVA = "0x2D9DF3C", Offset = "0x2D9DF3C", VA = "0x2D9DF3C")]
    public void ChangeTitle(bool check, string title, int current, int max, bool isPurpose)
    {
    }

    [Token(Token = "0x600221E")]
    [Address(RVA = "0x2D9D760", Offset = "0x2D9D760", VA = "0x2D9D760")]
    public TrackerSubSectionView()
    {
    }
  }
}
