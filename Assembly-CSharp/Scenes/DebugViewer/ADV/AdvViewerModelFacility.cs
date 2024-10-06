// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelFacility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using FreeMap;
using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.ButtonEvent.Facility.Types;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002FD2")]
  public class AdvViewerModelFacility : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CC64")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<int, StoryFreeActionAreaSettingData> paramDict;
    [Token(Token = "0x400CC65")]
    [FieldOffset(Offset = "0x50")]
    private bool isPrepare;

    [Token(Token = "0x17003F0F")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012B16"), Address(RVA = "0x42A3724", Offset = "0x42A3724", VA = "0x42A3724")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003F10")]
    public BindingParam<IEnumerable<StoryFacilityAttachData>> FacilityList
    {
      [Token(Token = "0x6012B17"), Address(RVA = "0x42A372C", Offset = "0x42A372C", VA = "0x42A372C")] get
      {
        return (BindingParam<IEnumerable<StoryFacilityAttachData>>) null;
      }
    }

    [Token(Token = "0x17003F11")]
    public BindingParam<int> AttachID
    {
      [Token(Token = "0x6012B18"), Address(RVA = "0x42A3734", Offset = "0x42A3734", VA = "0x42A3734")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F12")]
    public BindingParam<int> EncounterID
    {
      [Token(Token = "0x6012B19"), Address(RVA = "0x42A373C", Offset = "0x42A373C", VA = "0x42A373C")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F13")]
    public BindingParam<int> SequenceId
    {
      [Token(Token = "0x6012B1A"), Address(RVA = "0x42A3744", Offset = "0x42A3744", VA = "0x42A3744")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F14")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012B1B"), Address(RVA = "0x42A374C", Offset = "0x42A374C", VA = "0x42A374C")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003F15")]
    public BindingParam<IEnumerable<StoryFacilityEncountBonusDetailData>> EncounterList
    {
      [Token(Token = "0x6012B1C"), Address(RVA = "0x42A3754", Offset = "0x42A3754", VA = "0x42A3754")] get
      {
        return (BindingParam<IEnumerable<StoryFacilityEncountBonusDetailData>>) null;
      }
    }

    [Token(Token = "0x17003F16")]
    public BindingParam<bool> TypeLotteryIsSuccess
    {
      [Token(Token = "0x6012B1D"), Address(RVA = "0x42A375C", Offset = "0x42A375C", VA = "0x42A375C")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x17003F17")]
    public BindingParam<bool> CanPlay
    {
      [Token(Token = "0x6012B1E"), Address(RVA = "0x42A3764", Offset = "0x42A3764", VA = "0x42A3764")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012B1F")]
    [Address(RVA = "0x4298AB8", Offset = "0x4298AB8", VA = "0x4298AB8")]
    public AdvViewerModelFacility(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012B20")]
    [Address(RVA = "0x42A4040", Offset = "0x42A4040", VA = "0x42A4040")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012B21")]
    [Address(RVA = "0x42A4164", Offset = "0x42A4164", VA = "0x42A4164")]
    public void Play()
    {
    }

    [Token(Token = "0x6012B22")]
    [Address(RVA = "0x42A42B0", Offset = "0x42A42B0", VA = "0x42A42B0")]
    private void PlayInternal(
      StoryFacilityAttachData attach,
      StoryFacilityEncountBonusDetailData encounter)
    {
    }

    [Token(Token = "0x6012B23")]
    [Address(RVA = "0x42A4618", Offset = "0x42A4618", VA = "0x42A4618", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012B24")]
    [Address(RVA = "0x42A461C", Offset = "0x42A461C", VA = "0x42A461C", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012B25")]
    [Address(RVA = "0x42A376C", Offset = "0x42A376C", VA = "0x42A376C")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012B26")]
    [Address(RVA = "0x42A3E08", Offset = "0x42A3E08", VA = "0x42A3E08")]
    public IEnumerable<StoryFacilityEncountBonusDetailData> GetEncounterList()
    {
      return (IEnumerable<StoryFacilityEncountBonusDetailData>) null;
    }

    [Token(Token = "0x6012B27")]
    [Address(RVA = "0x4298DF8", Offset = "0x4298DF8", VA = "0x4298DF8")]
    public IEnumerable<StoryFacilityAttachData> GetFacilityList()
    {
      return (IEnumerable<StoryFacilityAttachData>) null;
    }

    [Token(Token = "0x6012B28")]
    [Address(RVA = "0x42A4DA4", Offset = "0x42A4DA4", VA = "0x42A4DA4")]
    private IEnumerator OnBegin(
      StoryFacilityAttachData attach,
      StoryFacilityEncountBonusDetailData detail)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012B29")]
    [Address(RVA = "0x42A4E48", Offset = "0x42A4E48", VA = "0x42A4E48")]
    private void OnEndAdv()
    {
    }

    [Token(Token = "0x6012B2A")]
    [Address(RVA = "0x42A4EDC", Offset = "0x42A4EDC", VA = "0x42A4EDC")]
    private FreeMapFacilityIconEvent CreateDebugFacilityIconEvent(
      StaqData.Facility facility,
      FreeMapCommonElement element)
    {
      return (FreeMapFacilityIconEvent) null;
    }

    [Token(Token = "0x2002FD3")]
    private interface IEncounter
    {
      [Token(Token = "0x6012B2F")]
      void Set(int detalID);
    }

    [Token(Token = "0x2002FD4")]
    private interface IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012B30")]
      void Load(FreeMapPlayerInstance activePlayer);

      [Token(Token = "0x6012B31")]
      IEnumerator DebugPlay();
    }

    [Token(Token = "0x2002FD5")]
    private class DebugGeneral : 
      General,
      AdvViewerModelFacility.IDebugFacilityAdvPlayer,
      AdvViewerModelFacility.IEncounter
    {
      [Token(Token = "0x6012B32")]
      [Address(RVA = "0x42A5258", Offset = "0x42A5258", VA = "0x42A5258")]
      public DebugGeneral(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012B33")]
      [Address(RVA = "0x42A5424", Offset = "0x42A5424", VA = "0x42A5424", Slot = "30")]
      public void Set(int encountDetailID)
      {
      }

      [Token(Token = "0x6012B34")]
      [Address(RVA = "0x42A550C", Offset = "0x42A550C", VA = "0x42A550C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012B35")]
      [Address(RVA = "0x42A551C", Offset = "0x42A551C", VA = "0x42A551C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012B36")]
      [Address(RVA = "0x42A55AC", Offset = "0x42A55AC", VA = "0x42A55AC", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012B37")]
      [Address(RVA = "0x42A5634", Offset = "0x42A5634", VA = "0x42A5634", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012B38")]
      [Address(RVA = "0x42A56BC", Offset = "0x42A56BC", VA = "0x42A56BC", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012B39")]
      [Address(RVA = "0x42A56C0", Offset = "0x42A56C0", VA = "0x42A56C0", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x2002FD6")]
      private class DebugPrepare : General.Prepare
      {
        [Token(Token = "0x6012B3A")]
        [Address(RVA = "0x42A5490", Offset = "0x42A5490", VA = "0x42A5490")]
        public DebugPrepare(int encounterDetailID)
        {
        }

        [Token(Token = "0x6012B3B")]
        [Address(RVA = "0x42A5748", Offset = "0x42A5748", VA = "0x42A5748", Slot = "4")]
        public override IEnumerator Execute(int facilityID) => (IEnumerator) null;
      }
    }

    [Token(Token = "0x2002FDC")]
    private class DebugMenu : Menu, AdvViewerModelFacility.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012B5A")]
      [Address(RVA = "0x42A5260", Offset = "0x42A5260", VA = "0x42A5260")]
      public DebugMenu(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012B5B")]
      [Address(RVA = "0x42A5B8C", Offset = "0x42A5B8C", VA = "0x42A5B8C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012B5C")]
      [Address(RVA = "0x42A5B9C", Offset = "0x42A5B9C", VA = "0x42A5B9C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012B5D")]
      [Address(RVA = "0x42A5BAC", Offset = "0x42A5BAC", VA = "0x42A5BAC", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012B5E")]
      [Address(RVA = "0x42A5C34", Offset = "0x42A5C34", VA = "0x42A5C34", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012B5F")]
      [Address(RVA = "0x42A5CBC", Offset = "0x42A5CBC", VA = "0x42A5CBC", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012B60")]
      [Address(RVA = "0x42A5CC0", Offset = "0x42A5CC0", VA = "0x42A5CC0", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x2002FE0")]
    private class DebugReading : Reading, AdvViewerModelFacility.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012B73")]
      [Address(RVA = "0x42A5268", Offset = "0x42A5268", VA = "0x42A5268")]
      public DebugReading(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012B74")]
      [Address(RVA = "0x42A5E8C", Offset = "0x42A5E8C", VA = "0x42A5E8C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012B75")]
      [Address(RVA = "0x42A5E9C", Offset = "0x42A5E9C", VA = "0x42A5E9C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012B76")]
      [Address(RVA = "0x42A5EAC", Offset = "0x42A5EAC", VA = "0x42A5EAC", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012B77")]
      [Address(RVA = "0x42A5F34", Offset = "0x42A5F34", VA = "0x42A5F34", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012B78")]
      [Address(RVA = "0x42A5FBC", Offset = "0x42A5FBC", VA = "0x42A5FBC", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012B79")]
      [Address(RVA = "0x42A5FC0", Offset = "0x42A5FC0", VA = "0x42A5FC0", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x2002FE4")]
    private class DebugLottery : Lottery, AdvViewerModelFacility.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x17003F2E")]
      public bool IsSuccess
      {
        [Token(Token = "0x6012B8C"), Address(RVA = "0x42A618C", Offset = "0x42A618C", VA = "0x42A618C")] get
        {
          return new bool();
        }
        [Token(Token = "0x6012B8D"), Address(RVA = "0x42A6194", Offset = "0x42A6194", VA = "0x42A6194")] set
        {
        }
      }

      [Token(Token = "0x6012B8E")]
      [Address(RVA = "0x42A5270", Offset = "0x42A5270", VA = "0x42A5270")]
      public DebugLottery(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012B8F")]
      [Address(RVA = "0x42A61A0", Offset = "0x42A61A0", VA = "0x42A61A0", Slot = "29")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012B90")]
      [Address(RVA = "0x42A61B0", Offset = "0x42A61B0", VA = "0x42A61B0", Slot = "30")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012B91")]
      [Address(RVA = "0x42A61C0", Offset = "0x42A61C0", VA = "0x42A61C0", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012B92")]
      [Address(RVA = "0x42A6248", Offset = "0x42A6248", VA = "0x42A6248", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012B93")]
      [Address(RVA = "0x42A62D0", Offset = "0x42A62D0", VA = "0x42A62D0", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012B94")]
      [Address(RVA = "0x42A62D4", Offset = "0x42A62D4", VA = "0x42A62D4", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6012B95")]
      [Address(RVA = "0x42A635C", Offset = "0x42A635C", VA = "0x42A635C", Slot = "28")]
      protected override void ApiCall(Adv2Manager.OnProccessSignal signal)
      {
      }
    }

    [Token(Token = "0x2002FE8")]
    private class DebugDifficulty : Difficulty, AdvViewerModelFacility.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012BAC")]
      [Address(RVA = "0x42A5278", Offset = "0x42A5278", VA = "0x42A5278")]
      public DebugDifficulty(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012BAD")]
      [Address(RVA = "0x42A6B0C", Offset = "0x42A6B0C", VA = "0x42A6B0C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012BAE")]
      [Address(RVA = "0x42A6B1C", Offset = "0x42A6B1C", VA = "0x42A6B1C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012BAF")]
      [Address(RVA = "0x42A6B2C", Offset = "0x42A6B2C", VA = "0x42A6B2C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012BB0")]
      [Address(RVA = "0x42A6BB4", Offset = "0x42A6BB4", VA = "0x42A6BB4", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012BB1")]
      [Address(RVA = "0x42A6C3C", Offset = "0x42A6C3C", VA = "0x42A6C3C", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012BB2")]
      [Address(RVA = "0x42A6C40", Offset = "0x42A6C40", VA = "0x42A6C40", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x2002FEC")]
    private class DebugRental : Rental, AdvViewerModelFacility.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012BC5")]
      [Address(RVA = "0x42A5280", Offset = "0x42A5280", VA = "0x42A5280")]
      public DebugRental(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012BC6")]
      [Address(RVA = "0x42A6E0C", Offset = "0x42A6E0C", VA = "0x42A6E0C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012BC7")]
      [Address(RVA = "0x42A6E1C", Offset = "0x42A6E1C", VA = "0x42A6E1C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012BC8")]
      [Address(RVA = "0x42A6E2C", Offset = "0x42A6E2C", VA = "0x42A6E2C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012BC9")]
      [Address(RVA = "0x42A6EB4", Offset = "0x42A6EB4", VA = "0x42A6EB4", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012BCA")]
      [Address(RVA = "0x42A6F3C", Offset = "0x42A6F3C", VA = "0x42A6F3C", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012BCB")]
      [Address(RVA = "0x42A6F40", Offset = "0x42A6F40", VA = "0x42A6F40", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x2002FF0")]
    private class DebugWorkMediation : WorkMediation, AdvViewerModelFacility.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012BDE")]
      [Address(RVA = "0x42A5288", Offset = "0x42A5288", VA = "0x42A5288")]
      public DebugWorkMediation(
        FreeMapFacilityEventUIParam param,
        FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012BDF")]
      [Address(RVA = "0x42A710C", Offset = "0x42A710C", VA = "0x42A710C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012BE0")]
      [Address(RVA = "0x42A711C", Offset = "0x42A711C", VA = "0x42A711C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012BE1")]
      [Address(RVA = "0x42A71AC", Offset = "0x42A71AC", VA = "0x42A71AC", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012BE2")]
      [Address(RVA = "0x42A7234", Offset = "0x42A7234", VA = "0x42A7234", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012BE3")]
      [Address(RVA = "0x42A72BC", Offset = "0x42A72BC", VA = "0x42A72BC", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012BE4")]
      [Address(RVA = "0x42A72C0", Offset = "0x42A72C0", VA = "0x42A72C0", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }
  }
}
