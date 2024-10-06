// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelTalkAdvEvent
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
  [Token(Token = "0x2003071")]
  public class AdvViewerModelTalkAdvEvent : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CE34")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<int, StoryFreeActionAreaSettingData> paramDict;
    [Token(Token = "0x400CE35")]
    [FieldOffset(Offset = "0x58")]
    private bool isPrepare;

    [Token(Token = "0x17003FD3")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012F04"), Address(RVA = "0x431A498", Offset = "0x431A498", VA = "0x431A498")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003FD4")]
    public BindingParam<IEnumerable<StoryFreeActionTalkADVEventData>> TalkAdvEventList
    {
      [Token(Token = "0x6012F05"), Address(RVA = "0x431A4A0", Offset = "0x431A4A0", VA = "0x431A4A0")] get
      {
        return (BindingParam<IEnumerable<StoryFreeActionTalkADVEventData>>) null;
      }
    }

    [Token(Token = "0x17003FD5")]
    public BindingParam<IEnumerable<StoryFreeActionTalkADVEventTextData>> TalkAdvEventTextList
    {
      [Token(Token = "0x6012F06"), Address(RVA = "0x431A4A8", Offset = "0x431A4A8", VA = "0x431A4A8")] get
      {
        return (BindingParam<IEnumerable<StoryFreeActionTalkADVEventTextData>>) null;
      }
    }

    [Token(Token = "0x17003FD6")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012F07"), Address(RVA = "0x431A4B0", Offset = "0x431A4B0", VA = "0x431A4B0")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003FD7")]
    public BindingParam<int> SequenceId
    {
      [Token(Token = "0x6012F08"), Address(RVA = "0x431A4B8", Offset = "0x431A4B8", VA = "0x431A4B8")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FD8")]
    public BindingParam<int> TalkEventAdvID
    {
      [Token(Token = "0x6012F09"), Address(RVA = "0x431A4C0", Offset = "0x431A4C0", VA = "0x431A4C0")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FD9")]
    public BindingParam<int> TalkEventTextAdvID
    {
      [Token(Token = "0x6012F0A"), Address(RVA = "0x431A4C8", Offset = "0x431A4C8", VA = "0x431A4C8")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FDA")]
    public BindingParam<bool> CanPlay
    {
      [Token(Token = "0x6012F0B"), Address(RVA = "0x431A4D0", Offset = "0x431A4D0", VA = "0x431A4D0")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012F0C")]
    [Address(RVA = "0x431A4D8", Offset = "0x431A4D8", VA = "0x431A4D8")]
    public AdvViewerModelTalkAdvEvent(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012F0D")]
    [Address(RVA = "0x431B000", Offset = "0x431B000", VA = "0x431B000")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012F0E")]
    [Address(RVA = "0x431B23C", Offset = "0x431B23C", VA = "0x431B23C")]
    public void Play()
    {
    }

    [Token(Token = "0x6012F0F")]
    [Address(RVA = "0x431B624", Offset = "0x431B624", VA = "0x431B624", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012F10")]
    [Address(RVA = "0x431B628", Offset = "0x431B628", VA = "0x431B628", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012F11")]
    [Address(RVA = "0x431A960", Offset = "0x431A960", VA = "0x431A960")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012F12")]
    [Address(RVA = "0x431A844", Offset = "0x431A844", VA = "0x431A844")]
    public IEnumerable<StoryFreeActionTalkADVEventData> GetTalkAdvEventList()
    {
      return (IEnumerable<StoryFreeActionTalkADVEventData>) null;
    }

    [Token(Token = "0x6012F13")]
    [Address(RVA = "0x431A8C4", Offset = "0x431A8C4", VA = "0x431A8C4")]
    public IEnumerable<StoryFreeActionTalkADVEventTextData> GetTalkAdvEventTextList()
    {
      return (IEnumerable<StoryFreeActionTalkADVEventTextData>) null;
    }

    [Token(Token = "0x6012F14")]
    [Address(RVA = "0x431BDC8", Offset = "0x431BDC8", VA = "0x431BDC8")]
    private IEnumerator OnBeginAdv(int demoInfoID) => (IEnumerator) null;

    [Token(Token = "0x6012F15")]
    [Address(RVA = "0x431BE68", Offset = "0x431BE68", VA = "0x431BE68")]
    private void OnEndAdv()
    {
    }
  }
}
