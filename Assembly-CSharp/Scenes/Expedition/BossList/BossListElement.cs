// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList
{
  [Token(Token = "0x2002D0D")]
  public class BossListElement : InfiniteCellBase
  {
    [Token(Token = "0x400C123")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text stageCountText;
    [Token(Token = "0x400C124")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text battlePowerText;
    [Token(Token = "0x400C125")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject challengeObject;
    [Token(Token = "0x400C126")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton challengeButton;
    [Token(Token = "0x400C127")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mopupObject;
    [Token(Token = "0x400C128")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton mopupButton;
    [Token(Token = "0x400C129")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C12A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject lockObject;
    [Token(Token = "0x400C12B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject cautionObject;
    [Token(Token = "0x400C12C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject superiorityObject;
    [Token(Token = "0x400C12D")]
    [FieldOffset(Offset = "0x78")]
    private ExpeditionBossDescriptionData masterData;
    [Token(Token = "0x400C130")]
    [FieldOffset(Offset = "0x89")]
    private bool isChallenge;
    [Token(Token = "0x400C131")]
    [FieldOffset(Offset = "0x8A")]
    private bool isBadgeView;
    [Token(Token = "0x400C132")]
    [FieldOffset(Offset = "0x90")]
    private WeakReference<BossListElement.Parameter> oldParam;

    [Token(Token = "0x17003C74")]
    public ItemDetailPopupProvider ItemDetailPopupGenerator
    {
      [Token(Token = "0x6011A15"), Address(RVA = "0x46ACED0", Offset = "0x46ACED0", VA = "0x46ACED0")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x6011A16"), Address(RVA = "0x46ACED8", Offset = "0x46ACED8", VA = "0x46ACED8")] set
      {
      }
    }

    [Token(Token = "0x17003C75")]
    public int ExpeditionBossDescriptionDataId
    {
      [Token(Token = "0x6011A17"), Address(RVA = "0x46ACEE0", Offset = "0x46ACEE0", VA = "0x46ACEE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003C76")]
    public bool IsLock
    {
      [Token(Token = "0x6011A18"), Address(RVA = "0x46ACEF8", Offset = "0x46ACEF8", VA = "0x46ACEF8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011A19"), Address(RVA = "0x46ACF00", Offset = "0x46ACF00", VA = "0x46ACF00")] private set
      {
      }
    }

    [Token(Token = "0x17003C77")]
    private int RecommendCombat
    {
      [Token(Token = "0x6011A1A"), Address(RVA = "0x46ACF0C", Offset = "0x46ACF0C", VA = "0x46ACF0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6011A1B")]
    [Address(RVA = "0x46ACF24", Offset = "0x46ACF24", VA = "0x46ACF24", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6011A1C")]
    [Address(RVA = "0x46AD0BC", Offset = "0x46AD0BC", VA = "0x46AD0BC")]
    private void Initialize(
      int stageCount,
      ExpeditionBossDescriptionData expeditionBossDescriptionData,
      int totalCombat,
      int clearBossLevel,
      int remainChallengeCount,
      Action<bool> challengeCallback,
      float? resetScroll)
    {
    }

    [Token(Token = "0x6011A1D")]
    [Address(RVA = "0x46AD51C", Offset = "0x46AD51C", VA = "0x46AD51C")]
    public void UpdateTotalCombat(int totalCombat)
    {
    }

    [Token(Token = "0x6011A1E")]
    [Address(RVA = "0x46AD6BC", Offset = "0x46AD6BC", VA = "0x46AD6BC")]
    public void UpdateChallengeBadge(int remainCount)
    {
    }

    [Token(Token = "0x6011A1F")]
    [Address(RVA = "0x46AD50C", Offset = "0x46AD50C", VA = "0x46AD50C")]
    private static bool CheckLock(int bossLevel, int clearBossLevel) => new bool();

    [Token(Token = "0x6011A20")]
    [Address(RVA = "0x46AD74C", Offset = "0x46AD74C", VA = "0x46AD74C")]
    public static string GetChallengeButtonText(int bossLevel, int clearBossLevel) => (string) null;

    [Token(Token = "0x6011A21")]
    [Address(RVA = "0x46AD6B0", Offset = "0x46AD6B0", VA = "0x46AD6B0")]
    private static bool IsChallenge(int bossLevel, int clearBossLevel) => new bool();

    [Token(Token = "0x6011A22")]
    [Address(RVA = "0x46AD7F8", Offset = "0x46AD7F8", VA = "0x46AD7F8")]
    public BossListElement()
    {
    }

    [Token(Token = "0x2002D0E")]
    public class Parameter
    {
      [Token(Token = "0x400C133")]
      [FieldOffset(Offset = "0x10")]
      public int stageCount;
      [Token(Token = "0x400C134")]
      [FieldOffset(Offset = "0x18")]
      public ExpeditionBossDescriptionData expeditionBossDescriptionData;
      [Token(Token = "0x400C135")]
      [FieldOffset(Offset = "0x20")]
      public int totalCombat;
      [Token(Token = "0x400C136")]
      [FieldOffset(Offset = "0x24")]
      public int clearBossLevel;
      [Token(Token = "0x400C137")]
      [FieldOffset(Offset = "0x28")]
      public int remainChallengeCount;
      [Token(Token = "0x400C138")]
      [FieldOffset(Offset = "0x30")]
      public Action<bool> challengeCallback;
      [Token(Token = "0x400C139")]
      [FieldOffset(Offset = "0x38")]
      public float? scrollPosition;

      [Token(Token = "0x6011A23")]
      [Address(RVA = "0x46AD878", Offset = "0x46AD878", VA = "0x46AD878")]
      public Parameter()
      {
      }
    }
  }
}
