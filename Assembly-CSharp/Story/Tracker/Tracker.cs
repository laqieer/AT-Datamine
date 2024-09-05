// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Tracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using Story.Tracker.Logic;
using Story.Tracker.UI;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Tracker
{
  [Token(Token = "0x20005D4")]
  public class Tracker : IAvoidRectTransfromAccessor
  {
    [Token(Token = "0x4001D18")]
    [FieldOffset(Offset = "0x10")]
    private TrackerController controller;
    [Token(Token = "0x4001D19")]
    [FieldOffset(Offset = "0x18")]
    private Action<bool> entityActivate;
    [Token(Token = "0x4001D1A")]
    [FieldOffset(Offset = "0x20")]
    private Func<bool> entityIsActive;

    [Token(Token = "0x170004BD")]
    public bool IsBusy
    {
      [Token(Token = "0x60021B5"), Address(RVA = "0x2D9A7E8", Offset = "0x2D9A7E8", VA = "0x2D9A7E8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60021B6")]
    [Address(RVA = "0x2D9A83C", Offset = "0x2D9A83C", VA = "0x2D9A83C")]
    public void Activate()
    {
    }

    [Token(Token = "0x60021B7")]
    [Address(RVA = "0x2D9A85C", Offset = "0x2D9A85C", VA = "0x2D9A85C")]
    public void Deactivate()
    {
    }

    [Token(Token = "0x60021B8")]
    [Address(RVA = "0x2D9A87C", Offset = "0x2D9A87C", VA = "0x2D9A87C")]
    public void Release()
    {
    }

    [Token(Token = "0x170004BE")]
    public bool HasTrackerUI
    {
      [Token(Token = "0x60021B9"), Address(RVA = "0x2D9A8B8", Offset = "0x2D9A8B8", VA = "0x2D9A8B8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60021BA")]
    [Address(RVA = "0x2D9A8E4", Offset = "0x2D9A8E4", VA = "0x2D9A8E4")]
    public void Initialize(MonoBehaviour entity, TrackerUI trackerUI)
    {
    }

    [Token(Token = "0x60021BB")]
    [Address(RVA = "0x2D9AC14", Offset = "0x2D9AC14", VA = "0x2D9AC14")]
    public void InitializeByEmpty()
    {
    }

    [Token(Token = "0x60021BC")]
    [Address(RVA = "0x2D9AC34", Offset = "0x2D9AC34", VA = "0x2D9AC34")]
    public void RegisterMainQuest(Action ondetail)
    {
    }

    [Token(Token = "0x60021BD")]
    [Address(RVA = "0x2D9AC58", Offset = "0x2D9AC58", VA = "0x2D9AC58")]
    public void RegisterSubQuest(Action<int> ondetail)
    {
    }

    [Token(Token = "0x60021BE")]
    [Address(RVA = "0x2D9AC7C", Offset = "0x2D9AC7C", VA = "0x2D9AC7C")]
    public void RegisterAreaEventQuest(Action<int> ondetail)
    {
    }

    [Token(Token = "0x60021BF")]
    [Address(RVA = "0x2D9ACA0", Offset = "0x2D9ACA0", VA = "0x2D9ACA0")]
    public void SetMainQuest(int sequenceID)
    {
    }

    [Token(Token = "0x60021C0")]
    [Address(RVA = "0x2D9AF68", Offset = "0x2D9AF68", VA = "0x2D9AF68")]
    public void Show()
    {
    }

    [Token(Token = "0x60021C1")]
    [Address(RVA = "0x2D9AFB8", Offset = "0x2D9AFB8", VA = "0x2D9AFB8")]
    public void Hide()
    {
    }

    [Token(Token = "0x60021C2")]
    [Address(RVA = "0x2D9B008", Offset = "0x2D9B008", VA = "0x2D9B008")]
    public void Update()
    {
    }

    [Token(Token = "0x60021C3")]
    [Address(RVA = "0x2D9B06C", Offset = "0x2D9B06C", VA = "0x2D9B06C")]
    public void InteractEnable()
    {
    }

    [Token(Token = "0x60021C4")]
    [Address(RVA = "0x2D9B0B4", Offset = "0x2D9B0B4", VA = "0x2D9B0B4")]
    public void InteractDisable()
    {
    }

    [Token(Token = "0x60021C5")]
    [Address(RVA = "0x2D9B0FC", Offset = "0x2D9B0FC", VA = "0x2D9B0FC")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60021C6")]
    [Address(RVA = "0x2D9B16C", Offset = "0x2D9B16C", VA = "0x2D9B16C")]
    private TrackingData MakeAreaEventQuest() => (TrackingData) null;

    [Token(Token = "0x60021C7")]
    [Address(RVA = "0x2D9B5F0", Offset = "0x2D9B5F0", VA = "0x2D9B5F0")]
    private TrackingData MakeSubQuest() => (TrackingData) null;

    [Token(Token = "0x170004BF")]
    public List<UITransfromAvoidElementBase> AvoidIconRectTransformList
    {
      [Token(Token = "0x60021C8"), Address(RVA = "0x2D9C6E4", Offset = "0x2D9C6E4", VA = "0x2D9C6E4", Slot = "4")] get
      {
        return (List<UITransfromAvoidElementBase>) null;
      }
    }

    [Token(Token = "0x60021C9")]
    [Address(RVA = "0x2D9C834", Offset = "0x2D9C834", VA = "0x2D9C834")]
    public Tracker()
    {
    }
  }
}
