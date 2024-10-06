// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Logic.TrackerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Tracker.Logic
{
  [Token(Token = "0x20005E9")]
  public class TrackerController
  {
    [Token(Token = "0x4001D69")]
    [FieldOffset(Offset = "0x10")]
    private TrackingData mainquestTrackingData;
    [Token(Token = "0x4001D6A")]
    [FieldOffset(Offset = "0x18")]
    private TrackingData trackingData;
    [Token(Token = "0x4001D6B")]
    [FieldOffset(Offset = "0x20")]
    private TrackerView trackerView;
    [Token(Token = "0x4001D6C")]
    [FieldOffset(Offset = "0x28")]
    private MonoBehaviour coroutineWorker;

    [Token(Token = "0x170004D9")]
    public bool IsBusy
    {
      [Token(Token = "0x6002249"), Address(RVA = "0x2D9A81C", Offset = "0x2D9A81C", VA = "0x2D9A81C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004DA")]
    public Action OnDetailMainQuest
    {
      [Token(Token = "0x600224A"), Address(RVA = "0x2D9E538", Offset = "0x2D9E538", VA = "0x2D9E538")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600224B"), Address(RVA = "0x2D9E540", Offset = "0x2D9E540", VA = "0x2D9E540")] set
      {
      }
    }

    [Token(Token = "0x170004DB")]
    public Action<int> OnDetailSubQuest
    {
      [Token(Token = "0x600224C"), Address(RVA = "0x2D9E548", Offset = "0x2D9E548", VA = "0x2D9E548")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x600224D"), Address(RVA = "0x2D9E550", Offset = "0x2D9E550", VA = "0x2D9E550")] set
      {
      }
    }

    [Token(Token = "0x170004DC")]
    public Action<int> OnDetailAreaEventQuest
    {
      [Token(Token = "0x600224E"), Address(RVA = "0x2D9E558", Offset = "0x2D9E558", VA = "0x2D9E558")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x600224F"), Address(RVA = "0x2D9E560", Offset = "0x2D9E560", VA = "0x2D9E560")] set
      {
      }
    }

    [Token(Token = "0x170004DD")]
    public IEnumerable<UITransfromAvoidElementBase> TransformAvoidElements
    {
      [Token(Token = "0x6002250"), Address(RVA = "0x2D9C7A8", Offset = "0x2D9C7A8", VA = "0x2D9C7A8")] get
      {
        return (IEnumerable<UITransfromAvoidElementBase>) null;
      }
    }

    [Token(Token = "0x6002251")]
    [Address(RVA = "0x2D9A8C8", Offset = "0x2D9A8C8", VA = "0x2D9A8C8")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x6002252")]
    [Address(RVA = "0x2D9B96C", Offset = "0x2D9B96C", VA = "0x2D9B96C")]
    public void SetSubQuest(TrackingData trackingData)
    {
    }

    [Token(Token = "0x6002253")]
    [Address(RVA = "0x2D9B4E0", Offset = "0x2D9B4E0", VA = "0x2D9B4E0")]
    public void SetAreaEventQuest(TrackingData trackingData)
    {
    }

    [Token(Token = "0x6002254")]
    [Address(RVA = "0x2D9E6F8", Offset = "0x2D9E6F8", VA = "0x2D9E6F8")]
    public void SetMainQuest(TrackingData mainquestTrackingData)
    {
    }

    [Token(Token = "0x6002255")]
    [Address(RVA = "0x2D9E700", Offset = "0x2D9E700", VA = "0x2D9E700")]
    public void SetView(TrackerView view)
    {
    }

    [Token(Token = "0x6002256")]
    [Address(RVA = "0x2D9ABDC", Offset = "0x2D9ABDC", VA = "0x2D9ABDC")]
    public void Initialize(MonoBehaviour coroutineWorker)
    {
    }

    [Token(Token = "0x6002257")]
    [Address(RVA = "0x2D9AF90", Offset = "0x2D9AF90", VA = "0x2D9AF90")]
    public void Show()
    {
    }

    [Token(Token = "0x6002258")]
    [Address(RVA = "0x2D9AFE0", Offset = "0x2D9AFE0", VA = "0x2D9AFE0")]
    public void Hide()
    {
    }

    [Token(Token = "0x6002259")]
    [Address(RVA = "0x2D9B030", Offset = "0x2D9B030", VA = "0x2D9B030")]
    public void UpdateAnimation()
    {
    }

    [Token(Token = "0x600225A")]
    [Address(RVA = "0x2D9BA18", Offset = "0x2D9BA18", VA = "0x2D9BA18")]
    public void ShowMainQuest()
    {
    }

    [Token(Token = "0x600225B")]
    [Address(RVA = "0x2D9B58C", Offset = "0x2D9B58C", VA = "0x2D9B58C")]
    public void ShowQuest()
    {
    }

    [Token(Token = "0x600225C")]
    [Address(RVA = "0x2D9B09C", Offset = "0x2D9B09C", VA = "0x2D9B09C")]
    public void InteractEnable()
    {
    }

    [Token(Token = "0x600225D")]
    [Address(RVA = "0x2D9B0E4", Offset = "0x2D9B0E4", VA = "0x2D9B0E4")]
    public void InteractDisable()
    {
    }

    [Token(Token = "0x600225E")]
    [Address(RVA = "0x2D9C898", Offset = "0x2D9C898", VA = "0x2D9C898")]
    public TrackerController()
    {
    }
  }
}
