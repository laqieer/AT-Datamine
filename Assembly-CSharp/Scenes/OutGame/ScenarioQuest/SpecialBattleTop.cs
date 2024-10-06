// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ScenarioQuest.SpecialBattleTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using Scenes.OutGame.Battle;
using StaqData;
using StaqData.Battle;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.ScenarioQuest
{
  [Token(Token = "0x20034E9")]
  public class SpecialBattleTop : SubScene
  {
    [Token(Token = "0x400E63A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400E63B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private SpecialBattleTop.BattleStatusView battleView;
    [Token(Token = "0x400E63C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private SpecialBattleTopEnemy[] enemies;
    [Token(Token = "0x400E63D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private SpecialBattleTop.Buttons buttons;
    [Token(Token = "0x400E63E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject itemIconObj;
    [Token(Token = "0x400E63F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ApRecoveryHeader apHeader;
    [Token(Token = "0x400E640")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject rankingLockIcon;
    [Token(Token = "0x400E641")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject rankingLockMask;
    [Token(Token = "0x400E642")]
    [FieldOffset(Offset = "0x98")]
    private SpecialBattleTop.Parameter sceneParam;
    [Token(Token = "0x400E643")]
    [FieldOffset(Offset = "0xA0")]
    private SpecialBattleTop.AbortProcess abortProcess;
    [Token(Token = "0x400E644")]
    [FieldOffset(Offset = "0xA4")]
    private SpecialBattleTop.Process process;
    [Token(Token = "0x400E645")]
    [FieldOffset(Offset = "0xA8")]
    private int enemyIndex;
    [Token(Token = "0x400E646")]
    [FieldOffset(Offset = "0xB0")]
    private BattleInfo battleInfo;
    [Token(Token = "0x400E647")]
    [FieldOffset(Offset = "0xB8")]
    private List<(BattleRewardDescriptionData data, bool isFirst)> rewardDatas;
    [Token(Token = "0x400E648")]
    [FieldOffset(Offset = "0xC0")]
    private List<GameObject> rewardIcons;
    [Token(Token = "0x400E649")]
    [FieldOffset(Offset = "0xC8")]
    private bool isLockedRanking;
    [Token(Token = "0x400E64A")]
    [FieldOffset(Offset = "0xD0")]
    private GameObject questDetailPrefab;
    [Token(Token = "0x400E64B")]
    [FieldOffset(Offset = "0xD8")]
    private ItemDetailPopupProvider itemDetailPopup;
    [Token(Token = "0x400E64C")]
    [FieldOffset(Offset = "0xE0")]
    private List<(CanvasGroup canvasGroup, float alpha)> canvasRestoreList;

    [Token(Token = "0x6014C1C")]
    [Address(RVA = "0x1D7324C", Offset = "0x1D7324C", VA = "0x1D7324C")]
    public static void ChangeSubScene(SpecialPeriodData periodData)
    {
    }

    [Token(Token = "0x6014C1D")]
    [Address(RVA = "0x1D7340C", Offset = "0x1D7340C", VA = "0x1D7340C")]
    public static void ChangeSceneReturnBattle(int questID)
    {
    }

    [Token(Token = "0x6014C1E")]
    [Address(RVA = "0x1D73368", Offset = "0x1D73368", VA = "0x1D73368")]
    public static void ChangeSubScene(SpecialBattleTop.Parameter param)
    {
    }

    [Token(Token = "0x170044D0")]
    private static string FormatRootTrackName
    {
      [Token(Token = "0x6014C1F"), Address(RVA = "0x1D7351C", Offset = "0x1D7351C", VA = "0x1D7351C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170044D1")]
    private static string FirstRewardAnimIN
    {
      [Token(Token = "0x6014C20"), Address(RVA = "0x1D7355C", Offset = "0x1D7355C", VA = "0x1D7355C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170044D2")]
    private static string FirstRewardAnimOUT
    {
      [Token(Token = "0x6014C21"), Address(RVA = "0x1D7359C", Offset = "0x1D7359C", VA = "0x1D7359C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170044D3")]
    private bool IsAbort
    {
      [Token(Token = "0x6014C22"), Address(RVA = "0x1D735DC", Offset = "0x1D735DC", VA = "0x1D735DC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170044D4")]
    private bool IsAborting
    {
      [Token(Token = "0x6014C23"), Address(RVA = "0x1D735EC", Offset = "0x1D735EC", VA = "0x1D735EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170044D5")]
    private bool IsInitialized
    {
      [Token(Token = "0x6014C24"), Address(RVA = "0x1D735FC", Offset = "0x1D735FC", VA = "0x1D735FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014C25")]
    [Address(RVA = "0x1D7360C", Offset = "0x1D7360C", VA = "0x1D7360C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014C26")]
    [Address(RVA = "0x1D746A8", Offset = "0x1D746A8", VA = "0x1D746A8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014C27")]
    [Address(RVA = "0x1D74738", Offset = "0x1D74738", VA = "0x1D74738", Slot = "24")]
    public override void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x6014C28")]
    [Address(RVA = "0x1D748D4", Offset = "0x1D748D4", VA = "0x1D748D4", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6014C29")]
    [Address(RVA = "0x1D749A4", Offset = "0x1D749A4", VA = "0x1D749A4")]
    private void Close(Action onFinish = null)
    {
    }

    [Token(Token = "0x6014C2A")]
    [Address(RVA = "0x1D74A80", Offset = "0x1D74A80", VA = "0x1D74A80", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014C2B")]
    [Address(RVA = "0x1D74B10", Offset = "0x1D74B10", VA = "0x1D74B10", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014C2C")]
    [Address(RVA = "0x1D74BA0", Offset = "0x1D74BA0", VA = "0x1D74BA0")]
    private void PostInitializeTimeline()
    {
    }

    [Token(Token = "0x6014C2D")]
    [Address(RVA = "0x1D73DD0", Offset = "0x1D73DD0", VA = "0x1D73DD0")]
    private void SetupAPHeader()
    {
    }

    [Token(Token = "0x6014C2E")]
    [Address(RVA = "0x1D73E74", Offset = "0x1D73E74", VA = "0x1D73E74")]
    private void SetupRewardIcons()
    {
    }

    [Token(Token = "0x6014C2F")]
    [Address(RVA = "0x1D74E3C", Offset = "0x1D74E3C", VA = "0x1D74E3C")]
    private void InitializeRewardIcon(
      (BattleRewardDescriptionData data, bool isFirst) rewardData,
      ItemIcon icon,
      AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6014C30")]
    [Address(RVA = "0x1D75038", Offset = "0x1D75038", VA = "0x1D75038")]
    private void OnClickedRewardIcon(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6014C31")]
    [Address(RVA = "0x1D75060", Offset = "0x1D75060", VA = "0x1D75060")]
    private IEnumerator OpenItemDetail(RewardTypeEnum rewardType, int rewardId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014C32")]
    [Address(RVA = "0x1D74CEC", Offset = "0x1D74CEC", VA = "0x1D74CEC")]
    private void ClearRewardIcons()
    {
    }

    [Token(Token = "0x6014C33")]
    [Address(RVA = "0x1D742CC", Offset = "0x1D742CC", VA = "0x1D742CC")]
    private void SetupBattleStatus()
    {
    }

    [Token(Token = "0x6014C34")]
    [Address(RVA = "0x1D74454", Offset = "0x1D74454", VA = "0x1D74454")]
    private void SetupButtons()
    {
    }

    [Token(Token = "0x170044D6")]
    public static string TextOutsideThePeriod
    {
      [Token(Token = "0x6014C35"), Address(RVA = "0x1D751FC", Offset = "0x1D751FC", VA = "0x1D751FC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6014C36")]
    [Address(RVA = "0x1D73900", Offset = "0x1D73900", VA = "0x1D73900")]
    private bool CheckEndPlayable() => new bool();

    [Token(Token = "0x6014C37")]
    [Address(RVA = "0x1D75284", Offset = "0x1D75284", VA = "0x1D75284")]
    private void GoToGlobalMenu()
    {
    }

    [Token(Token = "0x6014C38")]
    [Address(RVA = "0x1D7532C", Offset = "0x1D7532C", VA = "0x1D7532C")]
    private void BackSubScene()
    {
    }

    [Token(Token = "0x6014C39")]
    [Address(RVA = "0x1D753AC", Offset = "0x1D753AC", VA = "0x1D753AC")]
    private void GoToSortie()
    {
    }

    [Token(Token = "0x6014C3A")]
    [Address(RVA = "0x1D75444", Offset = "0x1D75444", VA = "0x1D75444")]
    private void ShowDetail()
    {
    }

    [Token(Token = "0x6014C3B")]
    [Address(RVA = "0x1D75464", Offset = "0x1D75464", VA = "0x1D75464")]
    private IEnumerator OpenQuestDetailPopup() => (IEnumerator) null;

    [Token(Token = "0x6014C3C")]
    [Address(RVA = "0x1D754F4", Offset = "0x1D754F4", VA = "0x1D754F4")]
    private void ShowRanking()
    {
    }

    [Token(Token = "0x6014C3D")]
    [Address(RVA = "0x1D75104", Offset = "0x1D75104", VA = "0x1D75104")]
    private void SetButtonEvent(CommonButton target, Action eventClick = null)
    {
    }

    [Token(Token = "0x170044D7")]
    private bool enabledClick
    {
      [Token(Token = "0x6014C3E"), Address(RVA = "0x1D75500", Offset = "0x1D75500", VA = "0x1D75500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014C3F")]
    [Address(RVA = "0x1D75510", Offset = "0x1D75510", VA = "0x1D75510")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6014C40")]
    [Address(RVA = "0x1D75720", Offset = "0x1D75720", VA = "0x1D75720")]
    public SpecialBattleTop()
    {
    }

    [Token(Token = "0x20034EA")]
    public class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x6014C46")]
      [Address(RVA = "0x1D732AC", Offset = "0x1D732AC", VA = "0x1D732AC")]
      public Parameter(SpecialPeriodData periodData = null)
      {
      }

      [Token(Token = "0x6014C47")]
      [Address(RVA = "0x1D73B6C", Offset = "0x1D73B6C", VA = "0x1D73B6C")]
      public void Apply(BattleInfo battleInfo)
      {
      }

      [Token(Token = "0x170044D8")]
      public SpecialPeriodData Period
      {
        [Token(Token = "0x6014C48"), Address(RVA = "0x1D7635C", Offset = "0x1D7635C", VA = "0x1D7635C")] get
        {
          return (SpecialPeriodData) null;
        }
        [Token(Token = "0x6014C49"), Address(RVA = "0x1D76364", Offset = "0x1D76364", VA = "0x1D76364")] private set
        {
        }
      }

      [Token(Token = "0x170044D9")]
      public SpecialQuestInfo QuestInfo
      {
        [Token(Token = "0x6014C4A"), Address(RVA = "0x1D7636C", Offset = "0x1D7636C", VA = "0x1D7636C")] get
        {
          return (SpecialQuestInfo) null;
        }
        [Token(Token = "0x6014C4B"), Address(RVA = "0x1D76374", Offset = "0x1D76374", VA = "0x1D76374")] private set
        {
        }
      }

      [Token(Token = "0x170044DA")]
      public BattleInfo BattleInfo
      {
        [Token(Token = "0x6014C4C"), Address(RVA = "0x1D7637C", Offset = "0x1D7637C", VA = "0x1D7637C")] get
        {
          return (BattleInfo) null;
        }
        [Token(Token = "0x6014C4D"), Address(RVA = "0x1D76384", Offset = "0x1D76384", VA = "0x1D76384")] private set
        {
        }
      }

      [Token(Token = "0x170044DB")]
      public int QuestId
      {
        [Token(Token = "0x6014C4E"), Address(RVA = "0x1D7638C", Offset = "0x1D7638C", VA = "0x1D7638C")] get
        {
          return new int();
        }
        [Token(Token = "0x6014C4F"), Address(RVA = "0x1D76394", Offset = "0x1D76394", VA = "0x1D76394")] private set
        {
        }
      }

      [Token(Token = "0x170044DC")]
      public int[] EnemyIds
      {
        [Token(Token = "0x6014C50"), Address(RVA = "0x1D7639C", Offset = "0x1D7639C", VA = "0x1D7639C")] get
        {
          return (int[]) null;
        }
        [Token(Token = "0x6014C51"), Address(RVA = "0x1D763A4", Offset = "0x1D763A4", VA = "0x1D763A4")] private set
        {
        }
      }

      [Token(Token = "0x170044DD")]
      public int Level
      {
        [Token(Token = "0x6014C52"), Address(RVA = "0x1D763AC", Offset = "0x1D763AC", VA = "0x1D763AC")] get
        {
          return new int();
        }
        [Token(Token = "0x6014C53"), Address(RVA = "0x1D763B4", Offset = "0x1D763B4", VA = "0x1D763B4")] private set
        {
        }
      }

      [Token(Token = "0x170044DE")]
      public int TotalHP
      {
        [Token(Token = "0x6014C54"), Address(RVA = "0x1D763BC", Offset = "0x1D763BC", VA = "0x1D763BC")] get
        {
          return new int();
        }
        [Token(Token = "0x6014C55"), Address(RVA = "0x1D763C4", Offset = "0x1D763C4", VA = "0x1D763C4")] private set
        {
        }
      }

      [Token(Token = "0x170044DF")]
      public int CostAP
      {
        [Token(Token = "0x6014C56"), Address(RVA = "0x1D763CC", Offset = "0x1D763CC", VA = "0x1D763CC")] get
        {
          return new int();
        }
        [Token(Token = "0x6014C57"), Address(RVA = "0x1D763D4", Offset = "0x1D763D4", VA = "0x1D763D4")] private set
        {
        }
      }

      [Token(Token = "0x170044E0")]
      public int? FreeRemain
      {
        [Token(Token = "0x6014C58"), Address(RVA = "0x1D763DC", Offset = "0x1D763DC", VA = "0x1D763DC")] get
        {
          return new int?();
        }
        [Token(Token = "0x6014C59"), Address(RVA = "0x1D763E4", Offset = "0x1D763E4", VA = "0x1D763E4")] private set
        {
        }
      }

      [Token(Token = "0x170044E1")]
      public bool NeedFade
      {
        [Token(Token = "0x6014C5A"), Address(RVA = "0x1D763EC", Offset = "0x1D763EC", VA = "0x1D763EC")] get
        {
          return new bool();
        }
        [Token(Token = "0x6014C5B"), Address(RVA = "0x1D763F4", Offset = "0x1D763F4", VA = "0x1D763F4")] set
        {
        }
      }
    }

    [Token(Token = "0x20034EB")]
    [Serializable]
    private class BattleStatusView
    {
      [Token(Token = "0x400E657")]
      [FieldOffset(Offset = "0x10")]
      public TextMeshProUGUI level;
      [Token(Token = "0x400E658")]
      [FieldOffset(Offset = "0x18")]
      public TextMeshProUGUI totalHP;
      [Token(Token = "0x400E659")]
      [FieldOffset(Offset = "0x20")]
      public Text eventDateTime;

      [Token(Token = "0x6014C5C")]
      [Address(RVA = "0x1D76400", Offset = "0x1D76400", VA = "0x1D76400")]
      public BattleStatusView()
      {
      }
    }

    [Token(Token = "0x20034EC")]
    [Serializable]
    private class Buttons
    {
      [Token(Token = "0x400E65A")]
      [FieldOffset(Offset = "0x10")]
      public CommonButton toGlobalMenu;
      [Token(Token = "0x400E65B")]
      [FieldOffset(Offset = "0x18")]
      public CommonButton back;
      [Token(Token = "0x400E65C")]
      [FieldOffset(Offset = "0x20")]
      public StartCostAPButton toSortie;
      [Token(Token = "0x400E65D")]
      [FieldOffset(Offset = "0x28")]
      public CommonButton detail;
      [Token(Token = "0x400E65E")]
      [FieldOffset(Offset = "0x30")]
      public CommonButton ranking;

      [Token(Token = "0x6014C5D")]
      [Address(RVA = "0x1D76408", Offset = "0x1D76408", VA = "0x1D76408")]
      public Buttons()
      {
      }
    }

    [Token(Token = "0x20034ED")]
    public enum BossType
    {
      [Token(Token = "0x400E660")] None,
      [Token(Token = "0x400E661")] Num1,
      [Token(Token = "0x400E662")] Num2,
      [Token(Token = "0x400E663")] Num3,
      [Token(Token = "0x400E664")] Num4,
    }

    [Token(Token = "0x20034EE")]
    private enum Process
    {
      [Token(Token = "0x400E666")] Unknown,
      [Token(Token = "0x400E667")] Initialize,
      [Token(Token = "0x400E668")] Start,
      [Token(Token = "0x400E669")] Active,
      [Token(Token = "0x400E66A")] Popup,
      [Token(Token = "0x400E66B")] End,
      [Token(Token = "0x400E66C")] Finish,
    }

    [Token(Token = "0x20034EF")]
    private enum AbortProcess
    {
      [Token(Token = "0x400E66E")] None,
      [Token(Token = "0x400E66F")] Wait,
      [Token(Token = "0x400E670")] Finish,
    }
  }
}
