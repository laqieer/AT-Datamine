// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelMainSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003009")]
  public class AdvViewerModelMainSequence : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x17003F5F")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012C70"), Address(RVA = "0x3FB0FF0", Offset = "0x3FB0FF0", VA = "0x3FB0FF0")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003F60")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012C71"), Address(RVA = "0x3FB0FF8", Offset = "0x3FB0FF8", VA = "0x3FB0FF8")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003F61")]
    public BindingParam<int> ChapterID
    {
      [Token(Token = "0x6012C72"), Address(RVA = "0x3FB1000", Offset = "0x3FB1000", VA = "0x3FB1000")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F62")]
    public BindingParam<StoryTimeSlotTypeEnum> Timeslot
    {
      [Token(Token = "0x6012C73"), Address(RVA = "0x3FB1008", Offset = "0x3FB1008", VA = "0x3FB1008")] get
      {
        return (BindingParam<StoryTimeSlotTypeEnum>) null;
      }
    }

    [Token(Token = "0x17003F63")]
    public BindingParam<int> Weather
    {
      [Token(Token = "0x6012C74"), Address(RVA = "0x3FB1010", Offset = "0x3FB1010", VA = "0x3FB1010")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F64")]
    public BindingParam<string> ScriptFileName
    {
      [Token(Token = "0x6012C75"), Address(RVA = "0x3FB1018", Offset = "0x3FB1018", VA = "0x3FB1018")] get
      {
        return (BindingParam<string>) null;
      }
    }

    [Token(Token = "0x6012C76")]
    [Address(RVA = "0x3FB1020", Offset = "0x3FB1020", VA = "0x3FB1020")]
    public AdvViewerModelMainSequence(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012C77")]
    [Address(RVA = "0x3FB16B8", Offset = "0x3FB16B8", VA = "0x3FB16B8")]
    public void TransitionOut()
    {
    }

    [Token(Token = "0x6012C78")]
    [Address(RVA = "0x3FB178C", Offset = "0x3FB178C", VA = "0x3FB178C")]
    public void Play(int sequenceID)
    {
    }

    [Token(Token = "0x6012C79")]
    [Address(RVA = "0x3FB19B8", Offset = "0x3FB19B8", VA = "0x3FB19B8", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012C7A")]
    [Address(RVA = "0x3FB19BC", Offset = "0x3FB19BC", VA = "0x3FB19BC", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012C7B")]
    [Address(RVA = "0x3FB1368", Offset = "0x3FB1368", VA = "0x3FB1368")]
    public IEnumerable<StoryMainQuestSequenceData> GetMainQuestSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012C7C")]
    [Address(RVA = "0x3FB19C0", Offset = "0x3FB19C0", VA = "0x3FB19C0")]
    public IEnumerable<StoryChapterData> GetChapterList() => (IEnumerable<StoryChapterData>) null;

    [Token(Token = "0x6012C7D")]
    [Address(RVA = "0x3FB1B18", Offset = "0x3FB1B18", VA = "0x3FB1B18")]
    public IEnumerable<StoryTimeSlotTypeEnum> GetTimeslotList()
    {
      return (IEnumerable<StoryTimeSlotTypeEnum>) null;
    }

    [Token(Token = "0x6012C7E")]
    [Address(RVA = "0x3FB1BD8", Offset = "0x3FB1BD8", VA = "0x3FB1BD8")]
    public IEnumerable<StoryWeatherData> GetWeatherList() => (IEnumerable<StoryWeatherData>) null;
  }
}
