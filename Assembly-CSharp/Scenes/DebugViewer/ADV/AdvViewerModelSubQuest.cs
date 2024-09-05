// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelSubQuest
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
  [Token(Token = "0x2003060")]
  public class AdvViewerModelSubQuest : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CDF3")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<int, StoryFreeActionAreaSettingData> paramDict;
    [Token(Token = "0x400CDF4")]
    [FieldOffset(Offset = "0x50")]
    private bool isPrepare;

    [Token(Token = "0x17003FBE")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012E9E"), Address(RVA = "0x3FC9AA4", Offset = "0x3FC9AA4", VA = "0x3FC9AA4")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003FBF")]
    public BindingParam<IEnumerable<StorySubquestTaskData>> TaskList
    {
      [Token(Token = "0x6012E9F"), Address(RVA = "0x3FC9AAC", Offset = "0x3FC9AAC", VA = "0x3FC9AAC")] get
      {
        return (BindingParam<IEnumerable<StorySubquestTaskData>>) null;
      }
    }

    [Token(Token = "0x17003FC0")]
    public BindingParam<int> SubquestID
    {
      [Token(Token = "0x6012EA0"), Address(RVA = "0x3FC9AB4", Offset = "0x3FC9AB4", VA = "0x3FC9AB4")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FC1")]
    public BindingParam<int> SubquestTaskID
    {
      [Token(Token = "0x6012EA1"), Address(RVA = "0x3FC9ABC", Offset = "0x3FC9ABC", VA = "0x3FC9ABC")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FC2")]
    public BindingParam<int> SequenceId
    {
      [Token(Token = "0x6012EA2"), Address(RVA = "0x3FC9AC4", Offset = "0x3FC9AC4", VA = "0x3FC9AC4")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003FC3")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012EA3"), Address(RVA = "0x3FC9ACC", Offset = "0x3FC9ACC", VA = "0x3FC9ACC")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003FC4")]
    public BindingParam<bool> CanPlay
    {
      [Token(Token = "0x6012EA4"), Address(RVA = "0x3FC9AD4", Offset = "0x3FC9AD4", VA = "0x3FC9AD4")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012EA5")]
    [Address(RVA = "0x3FC9ADC", Offset = "0x3FC9ADC", VA = "0x3FC9ADC")]
    public AdvViewerModelSubQuest(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012EA6")]
    [Address(RVA = "0x3FCA858", Offset = "0x3FCA858", VA = "0x3FCA858")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012EA7")]
    [Address(RVA = "0x3FCAAE4", Offset = "0x3FCAAE4", VA = "0x3FCAAE4")]
    public void Play()
    {
    }

    [Token(Token = "0x6012EA8")]
    [Address(RVA = "0x3FCB0D4", Offset = "0x3FCB0D4", VA = "0x3FCB0D4", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012EA9")]
    [Address(RVA = "0x3FCB0D8", Offset = "0x3FCB0D8", VA = "0x3FCB0D8", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012EAA")]
    [Address(RVA = "0x3FC9DF4", Offset = "0x3FC9DF4", VA = "0x3FC9DF4")]
    public IEnumerable<StorySubquestTaskData> GetTaskList()
    {
      return (IEnumerable<StorySubquestTaskData>) null;
    }

    [Token(Token = "0x6012EAB")]
    [Address(RVA = "0x3FCB0DC", Offset = "0x3FCB0DC", VA = "0x3FCB0DC")]
    public IEnumerable<StorySubquestData> GetSubQuestList()
    {
      return (IEnumerable<StorySubquestData>) null;
    }

    [Token(Token = "0x6012EAC")]
    [Address(RVA = "0x3FCA0A8", Offset = "0x3FCA0A8", VA = "0x3FCA0A8")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012EAD")]
    [Address(RVA = "0x3FCAF78", Offset = "0x3FCAF78", VA = "0x3FCAF78")]
    private IEnumerator OnBeginReceipt(StorySubquestTaskData task) => (IEnumerator) null;

    [Token(Token = "0x6012EAE")]
    [Address(RVA = "0x3FCAFEC", Offset = "0x3FCAFEC", VA = "0x3FCAFEC")]
    private IEnumerator OnBeginTask(StorySubquestTaskData task) => (IEnumerator) null;

    [Token(Token = "0x6012EAF")]
    [Address(RVA = "0x3FCB060", Offset = "0x3FCB060", VA = "0x3FCB060")]
    private IEnumerator OnBeginComplete(StorySubquestTaskData task) => (IEnumerator) null;

    [Token(Token = "0x6012EB0")]
    [Address(RVA = "0x3FCBAEC", Offset = "0x3FCBAEC", VA = "0x3FCBAEC")]
    private void OnEndAdv(FreeMapInstance instance)
    {
    }
  }
}
