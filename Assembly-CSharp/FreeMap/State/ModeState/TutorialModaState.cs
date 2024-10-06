// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.TutorialModaState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200181B")]
  public class TutorialModaState : ModeStateBase
  {
    [Token(Token = "0x4006951")]
    [FieldOffset(Offset = "0x38")]
    private TutorialMainPhase main;
    [Token(Token = "0x4006952")]
    [FieldOffset(Offset = "0x40")]
    private IntroChapterSequenceFreeActionSettingData introFreeActionSettings;

    [Token(Token = "0x17001583")]
    public SwipeMoveTutorialUI SwipeTutorialUI
    {
      [Token(Token = "0x6008858"), Address(RVA = "0x43DD3D8", Offset = "0x43DD3D8", VA = "0x43DD3D8")] get
      {
        return (SwipeMoveTutorialUI) null;
      }
      [Token(Token = "0x6008859"), Address(RVA = "0x43DD3E0", Offset = "0x43DD3E0", VA = "0x43DD3E0")] set
      {
      }
    }

    [Token(Token = "0x17001584")]
    public int FreeActionPlayerId
    {
      [Token(Token = "0x600885A"), Address(RVA = "0x43DD3E8", Offset = "0x43DD3E8", VA = "0x43DD3E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600885B"), Address(RVA = "0x43DD3F0", Offset = "0x43DD3F0", VA = "0x43DD3F0")] set
      {
      }
    }

    [Token(Token = "0x17001585")]
    public int EscapeFreeActionPlayerId
    {
      [Token(Token = "0x600885C"), Address(RVA = "0x43DD3F8", Offset = "0x43DD3F8", VA = "0x43DD3F8")] get
      {
        return new int();
      }
      [Token(Token = "0x600885D"), Address(RVA = "0x43DD400", Offset = "0x43DD400", VA = "0x43DD400")] set
      {
      }
    }

    [Token(Token = "0x17001586")]
    public bool IsTalkActionContentsStatus
    {
      [Token(Token = "0x600885E"), Address(RVA = "0x43DD408", Offset = "0x43DD408", VA = "0x43DD408")] get
      {
        return new bool();
      }
      [Token(Token = "0x600885F"), Address(RVA = "0x43DD410", Offset = "0x43DD410", VA = "0x43DD410")] set
      {
      }
    }

    [Token(Token = "0x6008860")]
    [Address(RVA = "0x43DD41C", Offset = "0x43DD41C", VA = "0x43DD41C")]
    public TutorialModaState(
      FreeMapStateManager entity,
      IntroChapterSequenceFreeActionSettingData param)
    {
    }

    [Token(Token = "0x6008861")]
    [Address(RVA = "0x43DD454", Offset = "0x43DD454", VA = "0x43DD454", Slot = "4")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6008862")]
    [Address(RVA = "0x43DD458", Offset = "0x43DD458", VA = "0x43DD458", Slot = "5")]
    public override bool IsPreStartEnded() => new bool();

    [Token(Token = "0x6008863")]
    [Address(RVA = "0x43DD460", Offset = "0x43DD460", VA = "0x43DD460", Slot = "6")]
    public override sealed void Start()
    {
    }

    [Token(Token = "0x6008864")]
    [Address(RVA = "0x43DD548", Offset = "0x43DD548", VA = "0x43DD548")]
    protected void OnStart()
    {
    }

    [Token(Token = "0x6008865")]
    [Address(RVA = "0x43DD8D8", Offset = "0x43DD8D8", VA = "0x43DD8D8")]
    private IEnumerator InitializeWait(InitializeStatePhase<TutorialModaState> phase)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008866")]
    [Address(RVA = "0x43DD968", Offset = "0x43DD968", VA = "0x43DD968", Slot = "7")]
    public override sealed void End()
    {
    }

    [Token(Token = "0x6008867")]
    [Address(RVA = "0x43DDA50", Offset = "0x43DDA50", VA = "0x43DDA50")]
    protected void OnEnd()
    {
    }

    [Token(Token = "0x6008868")]
    [Address(RVA = "0x43DDB2C", Offset = "0x43DDB2C", VA = "0x43DDB2C", Slot = "8")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x6008869")]
    [Address(RVA = "0x43DDB94", Offset = "0x43DDB94", VA = "0x43DDB94", Slot = "17")]
    public override bool IsFinalized() => new bool();

    [Token(Token = "0x600886A")]
    [Address(RVA = "0x43DDBDC", Offset = "0x43DDBDC", VA = "0x43DDBDC", Slot = "9")]
    public override void FreeMapUIShow()
    {
    }

    [Token(Token = "0x600886B")]
    [Address(RVA = "0x43DDC0C", Offset = "0x43DDC0C", VA = "0x43DDC0C", Slot = "10")]
    public override void FreeMapUIRefreshActionPlaying()
    {
    }

    [Token(Token = "0x600886C")]
    [Address(RVA = "0x43DDC3C", Offset = "0x43DDC3C", VA = "0x43DDC3C", Slot = "11")]
    public override void FreeMapUIHide()
    {
    }

    [Token(Token = "0x600886D")]
    [Address(RVA = "0x43DDC6C", Offset = "0x43DDC6C", VA = "0x43DDC6C", Slot = "12")]
    public override void FreeMapHeaderUIInteractEnable()
    {
    }

    [Token(Token = "0x600886E")]
    [Address(RVA = "0x43DDCE4", Offset = "0x43DDCE4", VA = "0x43DDCE4", Slot = "13")]
    public override void FreeMapHeaderUIInteractDisable()
    {
    }

    [Token(Token = "0x600886F")]
    [Address(RVA = "0x43DDD5C", Offset = "0x43DDD5C", VA = "0x43DDD5C", Slot = "14")]
    public override void FreeMapTrackerUIInteractEnable()
    {
    }

    [Token(Token = "0x6008870")]
    [Address(RVA = "0x43DDD80", Offset = "0x43DDD80", VA = "0x43DDD80", Slot = "15")]
    public override void FreeMapTrackerUIInteractDisable()
    {
    }

    [Token(Token = "0x6008871")]
    [Address(RVA = "0x43DDDA4", Offset = "0x43DDDA4", VA = "0x43DDDA4")]
    public TutorialModaState.TutorialAdvData GetTutorialAdvData(
      TutorialModaState.TutorialAdvType type)
    {
      return new TutorialModaState.TutorialAdvData();
    }

    [Token(Token = "0x6008872")]
    [Address(RVA = "0x43DDE18", Offset = "0x43DDE18", VA = "0x43DDE18")]
    public float GetSwipTutorialUIDisplayTimeSetting() => new float();

    [Token(Token = "0x6008873")]
    [Address(RVA = "0x43DDE34", Offset = "0x43DDE34", VA = "0x43DDE34")]
    public int GetEscapeStageAreaID() => new int();

    [Token(Token = "0x200181C")]
    public enum TutorialAdvType
    {
      [Token(Token = "0x4006954")] TalkActionFreeMove,
      [Token(Token = "0x4006955")] EscapeActionFreeMove,
    }

    [Token(Token = "0x200181D")]
    public struct TutorialAdvData
    {
      [Token(Token = "0x4006956")]
      [FieldOffset(Offset = "0x0")]
      public string AssetName;
      [Token(Token = "0x4006957")]
      [FieldOffset(Offset = "0x8")]
      public string AssetFileName;

      [Token(Token = "0x6008874")]
      [Address(RVA = "0x43DDE10", Offset = "0x43DDE10", VA = "0x43DDE10")]
      public TutorialAdvData(string AssetName, string AssetFileName)
      {
      }
    }
  }
}
