// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.TimelinePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035DF")]
  public class TimelinePlayer : ICoroutineTask, ITimelinePlayer
  {
    [Token(Token = "0x400EA6A")]
    [FieldOffset(Offset = "0x10")]
    private Queue<TimelinePlayer.Request> queue;
    [Token(Token = "0x400EA6B")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, string> loadedAssetBundleLabels;
    [Token(Token = "0x400EA6C")]
    [FieldOffset(Offset = "0x20")]
    private UITimelineController timelineController;

    [Token(Token = "0x170046AD")]
    public bool Queueing
    {
      [Token(Token = "0x6015379"), Address(RVA = "0x4D8BF1C", Offset = "0x4D8BF1C", VA = "0x4D8BF1C", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601537A")]
    [Address(RVA = "0x4D8B3B8", Offset = "0x4D8B3B8", VA = "0x4D8B3B8")]
    public TimelinePlayer(UITimelineController timelineController)
    {
    }

    [Token(Token = "0x601537B")]
    [Address(RVA = "0x4D8BF6C", Offset = "0x4D8BF6C", VA = "0x4D8BF6C", Slot = "5")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x601537C")]
    [Address(RVA = "0x4D8BFFC", Offset = "0x4D8BFFC", VA = "0x4D8BFFC")]
    private void PlayTimeline(TimelinePlayer.Request request)
    {
    }

    [Token(Token = "0x601537D")]
    [Address(RVA = "0x4D8C074", Offset = "0x4D8C074", VA = "0x4D8C074", Slot = "6")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x601537E")]
    [Address(RVA = "0x4D8C078", Offset = "0x4D8C078", VA = "0x4D8C078", Slot = "7")]
    private void Scenes\u002EOutGame\u002EInfo\u002ECommon\u002EUI\u002EITimelinePlayer\u002EOpen(
      Action onFinish)
    {
    }

    [Token(Token = "0x601537F")]
    [Address(RVA = "0x4D8C118", Offset = "0x4D8C118", VA = "0x4D8C118", Slot = "8")]
    private void Scenes\u002EOutGame\u002EInfo\u002ECommon\u002EUI\u002EITimelinePlayer\u002EClose(
      Action onFinish)
    {
    }

    [Token(Token = "0x20035E0")]
    private class Request
    {
      [Token(Token = "0x170046AE")]
      public UITimelineController.DirectionType DirectionType
      {
        [Token(Token = "0x6015380"), Address(RVA = "0x4D8C1B4", Offset = "0x4D8C1B4", VA = "0x4D8C1B4")] get
        {
          return new UITimelineController.DirectionType();
        }
        [Token(Token = "0x6015381"), Address(RVA = "0x4D8C1BC", Offset = "0x4D8C1BC", VA = "0x4D8C1BC")] set
        {
        }
      }

      [Token(Token = "0x170046AF")]
      public Action OnFinish
      {
        [Token(Token = "0x6015382"), Address(RVA = "0x4D8C1C4", Offset = "0x4D8C1C4", VA = "0x4D8C1C4")] get
        {
          return (Action) null;
        }
        [Token(Token = "0x6015383"), Address(RVA = "0x4D8C1CC", Offset = "0x4D8C1CC", VA = "0x4D8C1CC")] set
        {
        }
      }

      [Token(Token = "0x6015384")]
      [Address(RVA = "0x4D8C110", Offset = "0x4D8C110", VA = "0x4D8C110")]
      public Request()
      {
      }
    }
  }
}
