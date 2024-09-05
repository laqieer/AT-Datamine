// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelSystemMenuEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x200306B")]
  public class AdvViewerModelSystemMenuEvent : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CE1B")]
    [FieldOffset(Offset = "0x40")]
    private StoryFreeActionLayoutData selectedLayout;
    [Token(Token = "0x400CE1C")]
    [FieldOffset(Offset = "0x48")]
    private StoryFreeActionAreaSettingData selectedAreaSetting;
    [Token(Token = "0x400CE1D")]
    [FieldOffset(Offset = "0x50")]
    private bool isPrepare;

    [Token(Token = "0x17003FCB")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012EE1"), Address(RVA = "0x4318E3C", Offset = "0x4318E3C", VA = "0x4318E3C")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003FCC")]
    public BindingParam<IEnumerable<StoryFreeActionSystemMenuEventData>> AdvEventList
    {
      [Token(Token = "0x6012EE2"), Address(RVA = "0x4318E44", Offset = "0x4318E44", VA = "0x4318E44")] get
      {
        return (BindingParam<IEnumerable<StoryFreeActionSystemMenuEventData>>) null;
      }
    }

    [Token(Token = "0x17003FCD")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012EE3"), Address(RVA = "0x4318E4C", Offset = "0x4318E4C", VA = "0x4318E4C")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003FCE")]
    public BindingParam<int> SequenceId
    {
      [Token(Token = "0x6012EE4"), Address(RVA = "0x4318E54", Offset = "0x4318E54", VA = "0x4318E54")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FCF")]
    public BindingParam<int> AdvEventID
    {
      [Token(Token = "0x6012EE5"), Address(RVA = "0x4318E5C", Offset = "0x4318E5C", VA = "0x4318E5C")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FD0")]
    public BindingParam<bool> CanPlay
    {
      [Token(Token = "0x6012EE6"), Address(RVA = "0x4318E64", Offset = "0x4318E64", VA = "0x4318E64")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012EE7")]
    [Address(RVA = "0x4318E6C", Offset = "0x4318E6C", VA = "0x4318E6C")]
    public AdvViewerModelSystemMenuEvent(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012EE8")]
    [Address(RVA = "0x4319360", Offset = "0x4319360", VA = "0x4319360")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012EE9")]
    [Address(RVA = "0x4319C14", Offset = "0x4319C14", VA = "0x4319C14")]
    public void Play()
    {
    }

    [Token(Token = "0x6012EEA")]
    [Address(RVA = "0x4319F00", Offset = "0x4319F00", VA = "0x4319F00", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012EEB")]
    [Address(RVA = "0x4319F04", Offset = "0x4319F04", VA = "0x4319F04", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012EEC")]
    [Address(RVA = "0x431914C", Offset = "0x431914C", VA = "0x431914C")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012EED")]
    [Address(RVA = "0x43190CC", Offset = "0x43190CC", VA = "0x43190CC")]
    public IEnumerable<StoryFreeActionSystemMenuEventData> GetEventList()
    {
      return (IEnumerable<StoryFreeActionSystemMenuEventData>) null;
    }

    [Token(Token = "0x6012EEE")]
    [Address(RVA = "0x4319F08", Offset = "0x4319F08", VA = "0x4319F08")]
    private IEnumerator OnBeginAdv(int demoInfoID) => (IEnumerator) null;

    [Token(Token = "0x6012EEF")]
    [Address(RVA = "0x4319FA8", Offset = "0x4319FA8", VA = "0x4319FA8")]
    private void OnEndAdv()
    {
    }

    [Token(Token = "0x6012EF0")]
    [Address(RVA = "0x4319FAC", Offset = "0x4319FAC", VA = "0x4319FAC")]
    public IEnumerable<StoryFreeActionSettingData> GetFreeActionSettingList()
    {
      return (IEnumerable<StoryFreeActionSettingData>) null;
    }
  }
}
