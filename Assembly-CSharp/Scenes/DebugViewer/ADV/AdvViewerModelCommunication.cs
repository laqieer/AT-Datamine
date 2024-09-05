// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelCommunication
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
  [Token(Token = "0x2002FBE")]
  public class AdvViewerModelCommunication : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CC1B")]
    [FieldOffset(Offset = "0x58")]
    private bool humanParamMaxInPlay;
    [Token(Token = "0x400CC1C")]
    [FieldOffset(Offset = "0x60")]
    private Dictionary<int, StoryFreeActionAreaSettingData> paramDict;
    [Token(Token = "0x400CC1D")]
    [FieldOffset(Offset = "0x68")]
    private bool isPrepare;

    [Token(Token = "0x17003EF8")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012AA7"), Address(RVA = "0x429EED0", Offset = "0x429EED0", VA = "0x429EED0")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003EF9")]
    public BindingParam<IEnumerable<StoryCommunicationParamData>> ParamList
    {
      [Token(Token = "0x6012AA8"), Address(RVA = "0x429EED8", Offset = "0x429EED8", VA = "0x429EED8")] get
      {
        return (BindingParam<IEnumerable<StoryCommunicationParamData>>) null;
      }
    }

    [Token(Token = "0x17003EFA")]
    public BindingParam<int> CommuIdentifier
    {
      [Token(Token = "0x6012AA9"), Address(RVA = "0x429EEE0", Offset = "0x429EEE0", VA = "0x429EEE0")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003EFB")]
    public BindingParam<string> ScriptFileName
    {
      [Token(Token = "0x6012AAA"), Address(RVA = "0x429EEE8", Offset = "0x429EEE8", VA = "0x429EEE8")] get
      {
        return (BindingParam<string>) null;
      }
    }

    [Token(Token = "0x17003EFC")]
    public BindingParam<int> SequenceId
    {
      [Token(Token = "0x6012AAB"), Address(RVA = "0x429EEF0", Offset = "0x429EEF0", VA = "0x429EEF0")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003EFD")]
    public BindingParam<int> CommuParamId
    {
      [Token(Token = "0x6012AAC"), Address(RVA = "0x429EEF8", Offset = "0x429EEF8", VA = "0x429EEF8")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003EFE")]
    public BindingParam<bool> IsTargetRankup
    {
      [Token(Token = "0x6012AAD"), Address(RVA = "0x429EF00", Offset = "0x429EF00", VA = "0x429EF00")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x17003EFF")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012AAE"), Address(RVA = "0x429EF08", Offset = "0x429EF08", VA = "0x429EF08")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003F00")]
    public BindingParam<bool> Enable
    {
      [Token(Token = "0x6012AAF"), Address(RVA = "0x429EF10", Offset = "0x429EF10", VA = "0x429EF10")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012AB0")]
    [Address(RVA = "0x4298258", Offset = "0x4298258", VA = "0x4298258")]
    public AdvViewerModelCommunication(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012AB1")]
    [Address(RVA = "0x429F7C0", Offset = "0x429F7C0", VA = "0x429F7C0")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012AB2")]
    [Address(RVA = "0x429A6B4", Offset = "0x429A6B4", VA = "0x429A6B4")]
    public void Play()
    {
    }

    [Token(Token = "0x6012AB3")]
    [Address(RVA = "0x429F958", Offset = "0x429F958", VA = "0x429F958", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012AB4")]
    [Address(RVA = "0x429F95C", Offset = "0x429F95C", VA = "0x429F95C", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012AB5")]
    [Address(RVA = "0x429F960", Offset = "0x429F960", VA = "0x429F960")]
    public void SethumanParamMaxInPlay(bool max)
    {
    }

    [Token(Token = "0x6012AB6")]
    [Address(RVA = "0x4298848", Offset = "0x4298848", VA = "0x4298848")]
    public IEnumerable<StoryCommunicationParamData> GetParamList()
    {
      return (IEnumerable<StoryCommunicationParamData>) null;
    }

    [Token(Token = "0x6012AB7")]
    [Address(RVA = "0x42986F0", Offset = "0x42986F0", VA = "0x42986F0")]
    public IEnumerable<StoryCommunicationIdentifierData> GetIdentifierList()
    {
      return (IEnumerable<StoryCommunicationIdentifierData>) null;
    }

    [Token(Token = "0x6012AB8")]
    [Address(RVA = "0x429EF18", Offset = "0x429EF18", VA = "0x429EF18")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012AB9")]
    [Address(RVA = "0x429F97C", Offset = "0x429F97C", VA = "0x429F97C")]
    private static StoryFreeActionAreaSettingData AnySearchAreaSetting(
      AdvViewerModelFreeMap freemapModel,
      StoryCommunicationParamData commuParam,
      StoryMainQuestSequenceData seq,
      bool isTargetRaunlup,
      StoryCommunicationRankupTermData[] conditions)
    {
      return (StoryFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x6012ABA")]
    [Address(RVA = "0x42A07F4", Offset = "0x42A07F4", VA = "0x42A07F4")]
    private static bool RouteAndTermCondition(
      StoryMainQuestSequenceData seq,
      StoryCommunicationRankupTermData[] conditions)
    {
      return new bool();
    }

    [Token(Token = "0x6012ABB")]
    [Address(RVA = "0x42A0958", Offset = "0x42A0958", VA = "0x42A0958")]
    private IEnumerator OnPlayCommunication(int commuParamID) => (IEnumerator) null;

    [Token(Token = "0x6012ABC")]
    [Address(RVA = "0x42A09F8", Offset = "0x42A09F8", VA = "0x42A09F8")]
    private IEnumerator OnPlayRankupCommunication(int commuParamID) => (IEnumerator) null;

    [Token(Token = "0x6012ABD")]
    [Address(RVA = "0x42A0A98", Offset = "0x42A0A98", VA = "0x42A0A98")]
    private void OnEndAdv()
    {
    }

    [Token(Token = "0x2002FBF")]
    public enum PlayADVType
    {
      [Token(Token = "0x400CC1F")] Default,
      [Token(Token = "0x400CC20")] Rankup,
    }

    [Token(Token = "0x2002FC0")]
    public enum EnableAdvType
    {
      [Token(Token = "0x400CC22")] Disable,
      [Token(Token = "0x400CC23")] Normal,
      [Token(Token = "0x400CC24")] Rankup,
      [Token(Token = "0x400CC25")] Both,
    }
  }
}
