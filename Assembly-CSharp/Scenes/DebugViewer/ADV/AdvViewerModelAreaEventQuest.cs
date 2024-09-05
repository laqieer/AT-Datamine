// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelAreaEventQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002FB4")]
  public class AdvViewerModelAreaEventQuest : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CBF2")]
    [FieldOffset(Offset = "0x38")]
    private StoryFreeActionAreaSettingData selectedAreaSetting;
    [Token(Token = "0x400CBF3")]
    [FieldOffset(Offset = "0x40")]
    private StoryMainQuestSequenceData selectSeq;
    [Token(Token = "0x400CBF4")]
    [FieldOffset(Offset = "0x48")]
    private bool isPrepare;

    [Token(Token = "0x17003EED")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012A6F"), Address(RVA = "0x429D374", Offset = "0x429D374", VA = "0x429D374")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003EEE")]
    public BindingParam<IEnumerable<StoryAreaEventQuestTaskData>> TaskList
    {
      [Token(Token = "0x6012A70"), Address(RVA = "0x429D37C", Offset = "0x429D37C", VA = "0x429D37C")] get
      {
        return (BindingParam<IEnumerable<StoryAreaEventQuestTaskData>>) null;
      }
    }

    [Token(Token = "0x17003EEF")]
    public BindingParam<int> AreaEventQuestID
    {
      [Token(Token = "0x6012A71"), Address(RVA = "0x429D384", Offset = "0x429D384", VA = "0x429D384")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003EF0")]
    public BindingParam<int> AreaEventQuestTaskID
    {
      [Token(Token = "0x6012A72"), Address(RVA = "0x429D38C", Offset = "0x429D38C", VA = "0x429D38C")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003EF1")]
    public BindingParam<bool> CanPlay
    {
      [Token(Token = "0x6012A73"), Address(RVA = "0x429D394", Offset = "0x429D394", VA = "0x429D394")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012A74")]
    [Address(RVA = "0x4298F58", Offset = "0x4298F58", VA = "0x4298F58")]
    public AdvViewerModelAreaEventQuest(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012A75")]
    [Address(RVA = "0x429D5D0", Offset = "0x429D5D0", VA = "0x429D5D0")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012A76")]
    [Address(RVA = "0x429AF08", Offset = "0x429AF08", VA = "0x429AF08")]
    public void Play()
    {
    }

    [Token(Token = "0x6012A77")]
    [Address(RVA = "0x429E060", Offset = "0x429E060", VA = "0x429E060", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012A78")]
    [Address(RVA = "0x429E064", Offset = "0x429E064", VA = "0x429E064", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012A79")]
    [Address(RVA = "0x429D39C", Offset = "0x429D39C", VA = "0x429D39C")]
    public IEnumerable<StoryAreaEventQuestTaskData> GetTaskList()
    {
      return (IEnumerable<StoryAreaEventQuestTaskData>) null;
    }

    [Token(Token = "0x6012A7A")]
    [Address(RVA = "0x4299168", Offset = "0x4299168", VA = "0x4299168")]
    public IEnumerable<StoryAreaEventQuestData> GetAreaEventQuestList()
    {
      return (IEnumerable<StoryAreaEventQuestData>) null;
    }

    [Token(Token = "0x6012A7B")]
    [Address(RVA = "0x429E068", Offset = "0x429E068", VA = "0x429E068")]
    private IEnumerator OnBeginReceipt(StoryAreaEventQuestTaskData task) => (IEnumerator) null;

    [Token(Token = "0x6012A7C")]
    [Address(RVA = "0x429E104", Offset = "0x429E104", VA = "0x429E104")]
    private IEnumerator OnBeginTask(StoryAreaEventQuestTaskData task) => (IEnumerator) null;

    [Token(Token = "0x6012A7D")]
    [Address(RVA = "0x429E1A0", Offset = "0x429E1A0", VA = "0x429E1A0")]
    private IEnumerator OnBeginComplete(StoryAreaEventQuestTaskData task) => (IEnumerator) null;

    [Token(Token = "0x6012A7E")]
    [Address(RVA = "0x429E23C", Offset = "0x429E23C", VA = "0x429E23C")]
    private void OnEndAdvFreeMapInstance(FreeMapInstance instance)
    {
    }
  }
}
