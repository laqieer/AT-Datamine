// Decompiled with JetBrains decompiler
// Type: Battle.AttentionDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Direction;
using Battle.UI;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002265")]
  public class AttentionDirector : MonoBehaviour, ISubDirector<IDirector>
  {
    [Token(Token = "0x40090B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform UIRootTransform;
    [Token(Token = "0x40090B6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattlePhaseDirection battlePhaseDirection;
    [Token(Token = "0x40090B7")]
    [FieldOffset(Offset = "0x28")]
    private BattleWinDirection battleWinDirection;
    [Token(Token = "0x40090B8")]
    [FieldOffset(Offset = "0x30")]
    private BattleLoseDirection battleLoseDirection;
    [Token(Token = "0x40090B9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BattlePhaseDirection arenaPhaseDirection;
    [Token(Token = "0x40090BA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private AttentionTween attentionTween;
    [Token(Token = "0x40090BB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private DefeatTween defeatTween;
    [Token(Token = "0x40090BC")]
    [FieldOffset(Offset = "0x50")]
    private BattleStartDirection battleStartDirection;
    [Token(Token = "0x40090BD")]
    [FieldOffset(Offset = "0x58")]
    private BoardData board;
    [Token(Token = "0x40090BE")]
    [FieldOffset(Offset = "0x60")]
    private BattleRetreatLostUI battleRetreatLostUI;
    [Token(Token = "0x40090BF")]
    [FieldOffset(Offset = "0x68")]
    private UIManager ui;
    [Token(Token = "0x40090C0")]
    [FieldOffset(Offset = "0x70")]
    private bool logOpen;

    [Token(Token = "0x17002D62")]
    public bool Initialized
    {
      [Token(Token = "0x600D10A"), Address(RVA = "0x195273C", Offset = "0x195273C", VA = "0x195273C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D10B"), Address(RVA = "0x1952744", Offset = "0x1952744", VA = "0x1952744")] private set
      {
      }
    }

    [Token(Token = "0x17002D63")]
    public int BattleQuestId
    {
      [Token(Token = "0x600D10C"), Address(RVA = "0x1952750", Offset = "0x1952750", VA = "0x1952750")] get
      {
        return new int();
      }
      [Token(Token = "0x600D10D"), Address(RVA = "0x1952758", Offset = "0x1952758", VA = "0x1952758")] set
      {
      }
    }

    [Token(Token = "0x17002D64")]
    public int BattleClearId
    {
      [Token(Token = "0x600D10E"), Address(RVA = "0x1952760", Offset = "0x1952760", VA = "0x1952760")] get
      {
        return new int();
      }
      [Token(Token = "0x600D10F"), Address(RVA = "0x1952768", Offset = "0x1952768", VA = "0x1952768")] set
      {
      }
    }

    [Token(Token = "0x17002D65")]
    public int BattleFailId
    {
      [Token(Token = "0x600D110"), Address(RVA = "0x1952770", Offset = "0x1952770", VA = "0x1952770")] get
      {
        return new int();
      }
      [Token(Token = "0x600D111"), Address(RVA = "0x1952778", Offset = "0x1952778", VA = "0x1952778")] set
      {
      }
    }

    [Token(Token = "0x17002D66")]
    public UnityAction<BattleVoiceTimingEnum> PlayVoiceAction
    {
      [Token(Token = "0x600D112"), Address(RVA = "0x1952780", Offset = "0x1952780", VA = "0x1952780")] get
      {
        return (UnityAction<BattleVoiceTimingEnum>) null;
      }
      [Token(Token = "0x600D113"), Address(RVA = "0x1952788", Offset = "0x1952788", VA = "0x1952788")] set
      {
      }
    }

    [Token(Token = "0x17002D67")]
    public virtual bool IsPlaying
    {
      [Token(Token = "0x600D114"), Address(RVA = "0x1952790", Offset = "0x1952790", VA = "0x1952790", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D115")]
    [Address(RVA = "0x1952850", Offset = "0x1952850", VA = "0x1952850", Slot = "5")]
    public void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600D116")]
    [Address(RVA = "0x1952974", Offset = "0x1952974", VA = "0x1952974")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600D117")]
    [Address(RVA = "0x19529FC", Offset = "0x19529FC", VA = "0x19529FC", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600D118")]
    [Address(RVA = "0x1952A48", Offset = "0x1952A48", VA = "0x1952A48", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600D119")]
    [Address(RVA = "0x1952A90", Offset = "0x1952A90", VA = "0x1952A90", Slot = "9")]
    public virtual void InitializeDirection(AttentionTween.Mode mode = AttentionTween.Mode.AllyPhase)
    {
    }

    [Token(Token = "0x600D11A")]
    [Address(RVA = "0x1952DF4", Offset = "0x1952DF4", VA = "0x1952DF4", Slot = "10")]
    public virtual void FinishDirection(AttentionTween.Mode mode = AttentionTween.Mode.AllyPhase)
    {
    }

    [Token(Token = "0x600D11B")]
    [Address(RVA = "0x1952F24", Offset = "0x1952F24", VA = "0x1952F24", Slot = "11")]
    public virtual bool IsDirectionInitialized(AttentionTween.Mode mode = AttentionTween.Mode.AllyPhase)
    {
      return new bool();
    }

    [Token(Token = "0x600D11C")]
    [Address(RVA = "0x1952FB8", Offset = "0x1952FB8", VA = "0x1952FB8", Slot = "12")]
    public virtual void PlaySystemAttention(AttentionTween.Mode mode, UnityAction onCompleted = null)
    {
    }

    [Token(Token = "0x600D11D")]
    [Address(RVA = "0x19531BC", Offset = "0x19531BC", VA = "0x19531BC", Slot = "13")]
    public virtual void PlayDefeatAttention(
      Sprite charaTexture,
      string charaName,
      UnityAction onCompleted = null)
    {
    }

    [Token(Token = "0x600D11E")]
    [Address(RVA = "0x195322C", Offset = "0x195322C", VA = "0x195322C", Slot = "14")]
    public virtual void PlayWithdrawalAttention(
      UnitParameterData unit,
      bool isAutoBattlePauseUnitLost,
      bool enableLost,
      UnityAction onCompleted = null)
    {
    }

    [Token(Token = "0x600D11F")]
    [Address(RVA = "0x1953198", Offset = "0x1953198", VA = "0x1953198")]
    private void SetOnCompletedTo(TweenWrapper target, UnityAction callback)
    {
    }

    [Token(Token = "0x600D120")]
    [Address(RVA = "0x1953134", Offset = "0x1953134", VA = "0x1953134")]
    private void LogWindowTemporaryClose()
    {
    }

    [Token(Token = "0x600D121")]
    [Address(RVA = "0x1952EC0", Offset = "0x1952EC0", VA = "0x1952EC0")]
    private void LogWindowTemporaryOpen()
    {
    }

    [Token(Token = "0x600D122")]
    [Address(RVA = "0x195326C", Offset = "0x195326C", VA = "0x195326C")]
    public AttentionDirector()
    {
    }
  }
}
