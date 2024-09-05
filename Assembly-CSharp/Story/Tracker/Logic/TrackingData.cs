// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Logic.TrackingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.Tracker.Logic
{
  [Token(Token = "0x20005F8")]
  public class TrackingData
  {
    [Token(Token = "0x170004F1")]
    public Handle Handle
    {
      [Token(Token = "0x60022B7"), Address(RVA = "0x2DA0FAC", Offset = "0x2DA0FAC", VA = "0x2DA0FAC")] get
      {
        return new Handle();
      }
      [Token(Token = "0x60022B8"), Address(RVA = "0x2DA0FB4", Offset = "0x2DA0FB4", VA = "0x2DA0FB4")] set
      {
      }
    }

    [Token(Token = "0x170004F2")]
    public string Title
    {
      [Token(Token = "0x60022B9"), Address(RVA = "0x2DA0FBC", Offset = "0x2DA0FBC", VA = "0x2DA0FBC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60022BA"), Address(RVA = "0x2DA0FC4", Offset = "0x2DA0FC4", VA = "0x2DA0FC4")] set
      {
      }
    }

    [Token(Token = "0x170004F3")]
    public string SummaryPlan
    {
      [Token(Token = "0x60022BB"), Address(RVA = "0x2DA0FCC", Offset = "0x2DA0FCC", VA = "0x2DA0FCC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60022BC"), Address(RVA = "0x2DA0FD4", Offset = "0x2DA0FD4", VA = "0x2DA0FD4")] set
      {
      }
    }

    [Token(Token = "0x170004F4")]
    public List<TrackingProgressData> Progresses
    {
      [Token(Token = "0x60022BD"), Address(RVA = "0x2DA0FDC", Offset = "0x2DA0FDC", VA = "0x2DA0FDC")] get
      {
        return (List<TrackingProgressData>) null;
      }
      [Token(Token = "0x60022BE"), Address(RVA = "0x2DA0FE4", Offset = "0x2DA0FE4", VA = "0x2DA0FE4")] set
      {
      }
    }

    [Token(Token = "0x170004F5")]
    public IEnumerable<TrackingProgressData> ShowProgressess
    {
      [Token(Token = "0x60022BF"), Address(RVA = "0x2DA0A04", Offset = "0x2DA0A04", VA = "0x2DA0A04")] get
      {
        return (IEnumerable<TrackingProgressData>) null;
      }
    }

    [Token(Token = "0x170004F6")]
    public bool Complete
    {
      [Token(Token = "0x60022C0"), Address(RVA = "0x2DA0C88", Offset = "0x2DA0C88", VA = "0x2DA0C88")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60022C1")]
    [Address(RVA = "0x2D9E96C", Offset = "0x2D9E96C", VA = "0x2D9E96C")]
    public TrackingData()
    {
    }
  }
}
