// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Logic.TrackerView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using Story.Tracker.UI;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Story.Tracker.Logic
{
  [Token(Token = "0x20005EA")]
  public class TrackerView
  {
    [Token(Token = "0x170004DE")]
    public TrackerUI TrackerUI
    {
      [Token(Token = "0x6002262"), Address(RVA = "0x2D9E9F8", Offset = "0x2D9E9F8", VA = "0x2D9E9F8")] private get
      {
        return (TrackerUI) null;
      }
      [Token(Token = "0x6002263"), Address(RVA = "0x2D9EA00", Offset = "0x2D9EA00", VA = "0x2D9EA00")] set
      {
      }
    }

    [Token(Token = "0x170004DF")]
    public TrackerMainSectionUI MainSectionUI
    {
      [Token(Token = "0x6002264"), Address(RVA = "0x2D9EA08", Offset = "0x2D9EA08", VA = "0x2D9EA08")] private get
      {
        return (TrackerMainSectionUI) null;
      }
      [Token(Token = "0x6002265"), Address(RVA = "0x2D9EA10", Offset = "0x2D9EA10", VA = "0x2D9EA10")] set
      {
      }
    }

    [Token(Token = "0x170004E0")]
    public TrackerSubSectionView[] SubSectionViews
    {
      [Token(Token = "0x6002266"), Address(RVA = "0x2D9EA18", Offset = "0x2D9EA18", VA = "0x2D9EA18")] private get
      {
        return (TrackerSubSectionView[]) null;
      }
      [Token(Token = "0x6002267"), Address(RVA = "0x2D9EA20", Offset = "0x2D9EA20", VA = "0x2D9EA20")] set
      {
      }
    }

    [Token(Token = "0x170004E1")]
    public IEnumerable<UITransfromAvoidElementBase> TransformAvoidElements
    {
      [Token(Token = "0x6002268"), Address(RVA = "0x2D9E568", Offset = "0x2D9E568", VA = "0x2D9E568")] get
      {
        return (IEnumerable<UITransfromAvoidElementBase>) null;
      }
    }

    [Token(Token = "0x6002269")]
    [Address(RVA = "0x2D9EA28", Offset = "0x2D9EA28", VA = "0x2D9EA28")]
    private IEnumerable<TrackerSubSectionView> GetEnumerableView()
    {
      return (IEnumerable<TrackerSubSectionView>) null;
    }

    [Token(Token = "0x600226A")]
    [Address(RVA = "0x2D9EA30", Offset = "0x2D9EA30", VA = "0x2D9EA30")]
    public IEnumerator WaitPlaying() => (IEnumerator) null;

    [Token(Token = "0x170004E2")]
    public bool IsBusy
    {
      [Token(Token = "0x600226B"), Address(RVA = "0x2D9EAC0", Offset = "0x2D9EAC0", VA = "0x2D9EAC0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600226C"), Address(RVA = "0x2D9EAC8", Offset = "0x2D9EAC8", VA = "0x2D9EAC8")] private set
      {
      }
    }

    [Token(Token = "0x600226D")]
    [Address(RVA = "0x2D9E770", Offset = "0x2D9E770", VA = "0x2D9E770")]
    public void Show()
    {
    }

    [Token(Token = "0x600226E")]
    [Address(RVA = "0x2D9E788", Offset = "0x2D9E788", VA = "0x2D9E788")]
    public void Hide()
    {
    }

    [Token(Token = "0x600226F")]
    [Address(RVA = "0x2D9E91C", Offset = "0x2D9E91C", VA = "0x2D9E91C")]
    public void InteractEnable()
    {
    }

    [Token(Token = "0x6002270")]
    [Address(RVA = "0x2D9E944", Offset = "0x2D9E944", VA = "0x2D9E944")]
    public void InteractDisable()
    {
    }

    [Token(Token = "0x6002271")]
    [Address(RVA = "0x2D9E584", Offset = "0x2D9E584", VA = "0x2D9E584")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x6002272")]
    [Address(RVA = "0x2D9E708", Offset = "0x2D9E708", VA = "0x2D9E708")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6002273")]
    [Address(RVA = "0x2D9E620", Offset = "0x2D9E620", VA = "0x2D9E620")]
    public void Bind(TrackingData trackerModel, Action<TrackingData> onDetail)
    {
    }

    [Token(Token = "0x6002274")]
    [Address(RVA = "0x2D9E87C", Offset = "0x2D9E87C", VA = "0x2D9E87C")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x6002275")]
    [Address(RVA = "0x2D9EB04", Offset = "0x2D9EB04", VA = "0x2D9EB04")]
    public void SubSectionHide()
    {
    }

    [Token(Token = "0x6002276")]
    [Address(RVA = "0x2D9E808", Offset = "0x2D9E808", VA = "0x2D9E808")]
    public IEnumerator MainQuestIn(TrackingData trackingData) => (IEnumerator) null;

    [Token(Token = "0x6002277")]
    [Address(RVA = "0x2D9E7A0", Offset = "0x2D9E7A0", VA = "0x2D9E7A0")]
    public IEnumerator UpdateAnimation() => (IEnumerator) null;

    [Token(Token = "0x6002278")]
    [Address(RVA = "0x2D9E8A8", Offset = "0x2D9E8A8", VA = "0x2D9E8A8")]
    public IEnumerator QuestIn(TrackingData trackingData) => (IEnumerator) null;

    [Token(Token = "0x6002279")]
    [Address(RVA = "0x2D9EBE0", Offset = "0x2D9EBE0", VA = "0x2D9EBE0")]
    public void CompleteAnimation(TrackingData trackingData, Action callback = null)
    {
    }

    [Token(Token = "0x600227A")]
    [Address(RVA = "0x2D9ECE8", Offset = "0x2D9ECE8", VA = "0x2D9ECE8")]
    private IEnumerator CompleteSubsectionAnimation(IEnumerator<TrackingProgressData> progresses)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600227B")]
    [Address(RVA = "0x2D9ED84", Offset = "0x2D9ED84", VA = "0x2D9ED84")]
    private IEnumerator WaitLastAnimation(TrackerSubSectionView subSection) => (IEnumerator) null;

    [Token(Token = "0x600227C")]
    [Address(RVA = "0x2D9D768", Offset = "0x2D9D768", VA = "0x2D9D768")]
    public TrackerView()
    {
    }
  }
}
