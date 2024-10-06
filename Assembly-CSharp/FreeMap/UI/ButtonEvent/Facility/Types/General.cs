// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Facility.Types.General
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Story.Adv;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Facility.Types
{
  [Token(Token = "0x2001749")]
  public class General : FreeMapFacilityIconEvent
  {
    [Token(Token = "0x4006775")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapFacilityEventUIParam param;
    [Token(Token = "0x4006776")]
    [FieldOffset(Offset = "0x70")]
    protected FreeMap.UI.ButtonEvent.EventHandler eventHandler;
    [Token(Token = "0x4006777")]
    [FieldOffset(Offset = "0x78")]
    protected Queue<General.ISequence> advSequences;
    [Token(Token = "0x4006778")]
    [FieldOffset(Offset = "0x80")]
    protected General.ISequence current;
    [Token(Token = "0x4006779")]
    [FieldOffset(Offset = "0x88")]
    protected General.Prepare prepare;
    [Token(Token = "0x400677A")]
    [FieldOffset(Offset = "0x90")]
    protected AdvRequest encountAdvRequest;
    [Token(Token = "0x400677B")]
    [FieldOffset(Offset = "0x98")]
    protected Func<int> GetUseBuffItem;

    [Token(Token = "0x60083D8")]
    [Address(RVA = "0x4062C28", Offset = "0x4062C28", VA = "0x4062C28")]
    public General(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x60083D9")]
    [Address(RVA = "0x4062DA8", Offset = "0x4062DA8", VA = "0x4062DA8", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x60083DA")]
    [Address(RVA = "0x4062DD0", Offset = "0x4062DD0", VA = "0x4062DD0")]
    private IEnumerator LoadIconEventCoroutine(FreeMapPlayerInstance activePlayer)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60083DB")]
    [Address(RVA = "0x4062E6C", Offset = "0x4062E6C", VA = "0x4062E6C", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x60083DC")]
    [Address(RVA = "0x4062F18", Offset = "0x4062F18", VA = "0x4062F18")]
    private General.ISequence PickupNext() => (General.ISequence) null;

    [Token(Token = "0x60083DD")]
    [Address(RVA = "0x4062F8C", Offset = "0x4062F8C", VA = "0x4062F8C")]
    private IEnumerator FacilityPrepare() => (IEnumerator) null;

    [Token(Token = "0x60083DE")]
    [Address(RVA = "0x406301C", Offset = "0x406301C", VA = "0x406301C", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x60083DF")]
    [Address(RVA = "0x40630AC", Offset = "0x40630AC", VA = "0x40630AC")]
    protected IEnumerator PlaySequence() => (IEnumerator) null;

    [Token(Token = "0x60083E0")]
    [Address(RVA = "0x406313C", Offset = "0x406313C", VA = "0x406313C")]
    protected IEnumerator FacilityEndAPI() => (IEnumerator) null;

    [Token(Token = "0x200174A")]
    protected class Prepare
    {
      [Token(Token = "0x400677C")]
      [FieldOffset(Offset = "0x10")]
      protected StoryFacilityPrepareResult result;

      [Token(Token = "0x60083E1")]
      [Address(RVA = "0x40631CC", Offset = "0x40631CC", VA = "0x40631CC")]
      public StoryFacilityPrepareResult GetResult() => (StoryFacilityPrepareResult) null;

      [Token(Token = "0x60083E2")]
      [Address(RVA = "0x40631D4", Offset = "0x40631D4", VA = "0x40631D4", Slot = "4")]
      public virtual IEnumerator Execute(int facilityID) => (IEnumerator) null;

      [Token(Token = "0x60083E3")]
      [Address(RVA = "0x4062DA0", Offset = "0x4062DA0", VA = "0x4062DA0")]
      public Prepare()
      {
      }
    }

    [Token(Token = "0x200174C")]
    protected interface ISequence
    {
      [Token(Token = "0x60083EA")]
      bool IsLoadedIconEvent();

      [Token(Token = "0x60083EB")]
      IEnumerator Load(FreeMap.UI.ButtonEvent.EventHandler eventHandler);

      [Token(Token = "0x60083EC")]
      IEnumerator Play(FreeMap.UI.ButtonEvent.EventHandler eventHandler);

      [Token(Token = "0x170014B6")]
      bool Canceled { [Token(Token = "0x60083ED")] get; }

      [Token(Token = "0x60083EE")]
      AdvRequest GetAdvRequest();

      [Token(Token = "0x170014B7")]
      AdvDemoInfoData DemoInfo { [Token(Token = "0x60083EF")] get; }
    }

    [Token(Token = "0x200174D")]
    private class GeneralFacilitySequence : General.ISequence
    {
      [Token(Token = "0x4006782")]
      [FieldOffset(Offset = "0x10")]
      private AdvStageHandler advHandler;
      [Token(Token = "0x4006783")]
      [FieldOffset(Offset = "0x18")]
      private AdvStageFacility advStage;
      [Token(Token = "0x4006784")]
      [FieldOffset(Offset = "0x20")]
      private FreeMapFacilityEventUIParam param;

      [Token(Token = "0x170014B8")]
      public bool Canceled
      {
        [Token(Token = "0x60083F0"), Address(RVA = "0x406340C", Offset = "0x406340C", VA = "0x406340C", Slot = "7")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170014B9")]
      public AdvDemoInfoData DemoInfo
      {
        [Token(Token = "0x60083F1"), Address(RVA = "0x4063428", Offset = "0x4063428", VA = "0x4063428", Slot = "9")] get
        {
          return (AdvDemoInfoData) null;
        }
      }

      [Token(Token = "0x60083F2")]
      [Address(RVA = "0x40634CC", Offset = "0x40634CC", VA = "0x40634CC")]
      public GeneralFacilitySequence(FreeMapFacilityEventUIParam param)
      {
      }

      [Token(Token = "0x60083F3")]
      [Address(RVA = "0x4063548", Offset = "0x4063548", VA = "0x4063548", Slot = "5")]
      public IEnumerator Load(FreeMap.UI.ButtonEvent.EventHandler eventHandler)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x60083F4")]
      [Address(RVA = "0x40635E4", Offset = "0x40635E4", VA = "0x40635E4", Slot = "4")]
      public bool IsLoadedIconEvent() => new bool();

      [Token(Token = "0x60083F5")]
      [Address(RVA = "0x4063600", Offset = "0x4063600", VA = "0x4063600", Slot = "6")]
      public IEnumerator Play(FreeMap.UI.ButtonEvent.EventHandler eventHandler)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x60083F6")]
      [Address(RVA = "0x406369C", Offset = "0x406369C", VA = "0x406369C", Slot = "8")]
      public AdvRequest GetAdvRequest() => (AdvRequest) null;

      [Token(Token = "0x60083F7")]
      [Address(RVA = "0x40637C0", Offset = "0x40637C0", VA = "0x40637C0")]
      public int GetUseBuffItem() => new int();
    }

    [Token(Token = "0x2001750")]
    private class EncountSequence : General.ISequence
    {
      [Token(Token = "0x400678D")]
      [FieldOffset(Offset = "0x10")]
      private StoryFacilityEncountBonusDetailData encountDetail;
      [Token(Token = "0x400678E")]
      [FieldOffset(Offset = "0x18")]
      private AdvStageCommunication advStage;
      [Token(Token = "0x400678F")]
      [FieldOffset(Offset = "0x20")]
      private AdvStageHandler advHandler;
      [Token(Token = "0x4006790")]
      [FieldOffset(Offset = "0x28")]
      private FreeMapFacilityEventUIParam param;

      [Token(Token = "0x170014BE")]
      public bool Canceled
      {
        [Token(Token = "0x6008404"), Address(RVA = "0x4063E38", Offset = "0x4063E38", VA = "0x4063E38", Slot = "7")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170014BF")]
      public AdvDemoInfoData DemoInfo
      {
        [Token(Token = "0x6008405"), Address(RVA = "0x4063E54", Offset = "0x4063E54", VA = "0x4063E54", Slot = "9")] get
        {
          return (AdvDemoInfoData) null;
        }
      }

      [Token(Token = "0x6008406")]
      [Address(RVA = "0x4063EF8", Offset = "0x4063EF8", VA = "0x4063EF8")]
      public EncountSequence(FreeMapFacilityEventUIParam param, int encountDetailID)
      {
      }

      [Token(Token = "0x6008407")]
      [Address(RVA = "0x4063FEC", Offset = "0x4063FEC", VA = "0x4063FEC", Slot = "5")]
      public IEnumerator Load(FreeMap.UI.ButtonEvent.EventHandler eventHandler)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6008408")]
      [Address(RVA = "0x4064088", Offset = "0x4064088", VA = "0x4064088", Slot = "4")]
      public bool IsLoadedIconEvent() => new bool();

      [Token(Token = "0x6008409")]
      [Address(RVA = "0x40640A4", Offset = "0x40640A4", VA = "0x40640A4", Slot = "6")]
      public IEnumerator Play(FreeMap.UI.ButtonEvent.EventHandler eventHandler)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x600840A")]
      [Address(RVA = "0x4064140", Offset = "0x4064140", VA = "0x4064140", Slot = "8")]
      public AdvRequest GetAdvRequest() => (AdvRequest) null;
    }
  }
}
