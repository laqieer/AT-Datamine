// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.ExpeditionOrganization
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Expedition.BossList;
using Scenes.Expedition.Popup;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002C99")]
  public class ExpeditionOrganization : MonoBehaviour
  {
    [Token(Token = "0x400BE44")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400BE45")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400BE46")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400BE47")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton partyEditButton;
    [Token(Token = "0x400BE48")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400BE49")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400BE4A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton autoPartyEditButton;
    [Token(Token = "0x400BE4B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text partyNo;
    [Token(Token = "0x400BE4C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject unitSlotObject;
    [Token(Token = "0x400BE4D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text partyReleaceText;
    [Token(Token = "0x400BE4E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject BossExpressionObj;
    [Token(Token = "0x400BE4F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text partyNameText;
    [Token(Token = "0x400BE50")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ExpeditionFieldBanner stageBanner;
    [Token(Token = "0x400BE51")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ExpeditionPartyUnitCell[] unitCells;
    [Token(Token = "0x400BE52")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject prevButtonObj;
    [Token(Token = "0x400BE53")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject nextButtonObj;
    [Token(Token = "0x400BE54")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text recommendCombatPowerText;
    [Token(Token = "0x400BE55")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400BE56")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject combatPowerSuperiority;
    [Token(Token = "0x400BE57")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject combatPowerExclamation;
    [Token(Token = "0x400BE58")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject partyNoObject;
    [Token(Token = "0x400BE59")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x400BE5A")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject containerAnimObj;
    [Token(Token = "0x400BE5B")]
    [FieldOffset(Offset = "0xD0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BE5C")]
    [FieldOffset(Offset = "0xD8")]
    private StyleEditPopup styleEditPrefab;
    [Token(Token = "0x400BE5D")]
    [FieldOffset(Offset = "0xE0")]
    private StyleEditPopup styleEditPopup;
    [Token(Token = "0x400BE5E")]
    [FieldOffset(Offset = "0xE8")]
    private ExpeditionFullTankWarningPopup maxWarningPrefab;
    [Token(Token = "0x400BE5F")]
    [FieldOffset(Offset = "0xF0")]
    private ExpeditionFullTankWarningPopup maxWarningPopup;
    [Token(Token = "0x400BE60")]
    [FieldOffset(Offset = "0xF8")]
    private CharacterUnlockConfirmPopup slotUnlockConfirmPrefab;
    [Token(Token = "0x400BE61")]
    [FieldOffset(Offset = "0x100")]
    private CharacterUnlockConfirmPopup slotUnlockConfirmPopup;
    [Token(Token = "0x400BE62")]
    [FieldOffset(Offset = "0x108")]
    private SlotUnlockEffectPopup slotUnlockEffectPrefab;
    [Token(Token = "0x400BE63")]
    [FieldOffset(Offset = "0x110")]
    private SlotUnlockEffectPopup slotUnlockEffectPopup;
    [Token(Token = "0x400BE64")]
    [FieldOffset(Offset = "0x118")]
    private ExpeditionStyleExpPopup expeditionStyleExpPrefab;
    [Token(Token = "0x400BE65")]
    [FieldOffset(Offset = "0x120")]
    private ExpeditionStyleExpPopup expeditionStyleExpPopup;
    [Token(Token = "0x400BE66")]
    [FieldOffset(Offset = "0x128")]
    private int displayPartyIndex;
    [Token(Token = "0x400BE67")]
    [FieldOffset(Offset = "0x12C")]
    private int editPartyIndex;
    [Token(Token = "0x400BE68")]
    [FieldOffset(Offset = "0x130")]
    private ExpeditionOrganization.ExpeditionPartyData[] expeditionPartyDatas;
    [Token(Token = "0x400BE69")]
    [FieldOffset(Offset = "0x138")]
    private bool isStylePopupOpen;
    [Token(Token = "0x400BE6A")]
    [FieldOffset(Offset = "0x140")]
    private Action<int> closeAction;
    [Token(Token = "0x400BE6B")]
    [FieldOffset(Offset = "0x148")]
    private bool isBoss;
    [Token(Token = "0x400BE6C")]
    [FieldOffset(Offset = "0x14C")]
    private int bossStageId;
    [Token(Token = "0x400BE6D")]
    [FieldOffset(Offset = "0x150")]
    private int bossLevel;
    [Token(Token = "0x400BE6E")]
    [FieldOffset(Offset = "0x158")]
    private BossListPopup bossListPopup;
    [Token(Token = "0x400BE6F")]
    [FieldOffset(Offset = "0x160")]
    private bool flickEnabled;
    [Token(Token = "0x400BE70")]
    [FieldOffset(Offset = "0x161")]
    private bool callApiFlag;
    [Token(Token = "0x400BE71")]
    [FieldOffset(Offset = "0x164")]
    private int recommendCombatPower;
    [Token(Token = "0x400BE72")]
    [FieldOffset(Offset = "0x168")]
    private bool isStageSelectOnly;

    [Token(Token = "0x601173F")]
    [Address(RVA = "0x49380AC", Offset = "0x49380AC", VA = "0x49380AC")]
    public void Initialize(
      AssetCachedSpawner spawner,
      bool isBoss,
      int bossStageId = -1,
      int bossLevel = -1,
      BossListPopup bossListPopup = null,
      bool isStageSelectOnly = false,
      int selectPartyIndex = 0)
    {
    }

    [Token(Token = "0x6011740")]
    [Address(RVA = "0x49380D4", Offset = "0x49380D4", VA = "0x49380D4")]
    public IEnumerator InitializeAsync(Action<int> closeAction, Action finishInitalizeAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011741")]
    [Address(RVA = "0x4938178", Offset = "0x4938178", VA = "0x4938178")]
    private void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x6011742")]
    [Address(RVA = "0x493837C", Offset = "0x493837C", VA = "0x493837C")]
    public void Close()
    {
    }

    [Token(Token = "0x6011743")]
    [Address(RVA = "0x49384E0", Offset = "0x49384E0", VA = "0x49384E0")]
    private void UpdataPartyData()
    {
    }

    [Token(Token = "0x6011744")]
    [Address(RVA = "0x4938F80", Offset = "0x4938F80", VA = "0x4938F80")]
    private void UpdatePartyStyleData()
    {
    }

    [Token(Token = "0x6011745")]
    [Address(RVA = "0x4938A5C", Offset = "0x4938A5C", VA = "0x4938A5C")]
    private void UpdataPartyDataNomal()
    {
    }

    [Token(Token = "0x6011746")]
    [Address(RVA = "0x49384F0", Offset = "0x49384F0", VA = "0x49384F0")]
    private void UpdataPartyDataBoss()
    {
    }

    [Token(Token = "0x6011747")]
    [Address(RVA = "0x4939980", Offset = "0x4939980", VA = "0x4939980")]
    private void UpdateCellExpData()
    {
    }

    [Token(Token = "0x6011748")]
    [Address(RVA = "0x493913C", Offset = "0x493913C", VA = "0x493913C")]
    private void UpdateAllCell()
    {
    }

    [Token(Token = "0x6011749")]
    [Address(RVA = "0x4939F30", Offset = "0x4939F30", VA = "0x4939F30")]
    private int CalcCombatPower(Style style) => new int();

    [Token(Token = "0x601174A")]
    [Address(RVA = "0x4939FC0", Offset = "0x4939FC0", VA = "0x4939FC0")]
    private void UpdateTotalCombatPower(int totalCombatPower)
    {
    }

    [Token(Token = "0x601174B")]
    [Address(RVA = "0x493A1AC", Offset = "0x493A1AC", VA = "0x493A1AC")]
    private void UpdateStageBanner()
    {
    }

    [Token(Token = "0x601174C")]
    [Address(RVA = "0x493AC78", Offset = "0x493AC78", VA = "0x493AC78")]
    private void ChangeStage(string stageId)
    {
    }

    [Token(Token = "0x601174D")]
    [Address(RVA = "0x493AEF8", Offset = "0x493AEF8", VA = "0x493AEF8")]
    private void OnCellButton(int slotIndex)
    {
    }

    [Token(Token = "0x601174E")]
    [Address(RVA = "0x493B6A8", Offset = "0x493B6A8", VA = "0x493B6A8")]
    public void ChangeUnitIndivisual(Style style, int selectSlotIndex)
    {
    }

    [Token(Token = "0x601174F")]
    [Address(RVA = "0x493B50C", Offset = "0x493B50C", VA = "0x493B50C")]
    private void UpdateSelectCell(int onIndex)
    {
    }

    [Token(Token = "0x6011750")]
    [Address(RVA = "0x493BDF0", Offset = "0x493BDF0", VA = "0x493BDF0")]
    private bool CheckMaxExpStyleOrganization() => new bool();

    [Token(Token = "0x6011751")]
    [Address(RVA = "0x493BECC", Offset = "0x493BECC", VA = "0x493BECC")]
    private bool CheckStyleOrganization() => new bool();

    [Token(Token = "0x6011752")]
    [Address(RVA = "0x493BF7C", Offset = "0x493BF7C", VA = "0x493BF7C")]
    private void OnAutoPartyEditButton()
    {
    }

    [Token(Token = "0x6011753")]
    [Address(RVA = "0x493C12C", Offset = "0x493C12C", VA = "0x493C12C")]
    private void FinishAutoPartyFormation(List<Style> autoStyleList)
    {
    }

    [Token(Token = "0x6011754")]
    [Address(RVA = "0x493C27C", Offset = "0x493C27C", VA = "0x493C27C")]
    public IEnumerator LoadPartyAsset(List<Style> autoStyleList, Action closeAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011755")]
    [Address(RVA = "0x493ACD4", Offset = "0x493ACD4", VA = "0x493ACD4")]
    private void OnPartyEditButton()
    {
    }

    [Token(Token = "0x6011756")]
    [Address(RVA = "0x493C320", Offset = "0x493C320", VA = "0x493C320")]
    private void OpenMaxExpWarnPopup(Action decideCallback)
    {
    }

    [Token(Token = "0x6011757")]
    [Address(RVA = "0x493C738", Offset = "0x493C738", VA = "0x493C738")]
    private IEnumerator ConnectAPIBossPartyEdit(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6011758")]
    [Address(RVA = "0x493C7AC", Offset = "0x493C7AC", VA = "0x493C7AC")]
    private IEnumerator ConnectAPIPartyEdit(
      Action<ExpeditionOrganization.ExpeditionOldParty[], List<PlayerUnitType>> finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011759")]
    [Address(RVA = "0x493C878", Offset = "0x493C878", VA = "0x493C878")]
    private IEnumerator ConnectAPIStageChange() => (IEnumerator) null;

    [Token(Token = "0x601175A")]
    [Address(RVA = "0x493C908", Offset = "0x493C908", VA = "0x493C908")]
    private void OnReleaseButton()
    {
    }

    [Token(Token = "0x601175B")]
    [Address(RVA = "0x493D1B8", Offset = "0x493D1B8", VA = "0x493D1B8")]
    private IEnumerator ConnectAPISlotRelease(
      string partyId,
      int unlockSlotindex,
      Action<int> finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601175C")]
    [Address(RVA = "0x493D25C", Offset = "0x493D25C", VA = "0x493D25C")]
    private void FinishSlotReleaseAction(int unlockSlotindex)
    {
    }

    [Token(Token = "0x601175D")]
    [Address(RVA = "0x493D524", Offset = "0x493D524", VA = "0x493D524")]
    private void OpenSlotUnlockEffect(int unlockSlotindex)
    {
    }

    [Token(Token = "0x601175E")]
    [Address(RVA = "0x49382E8", Offset = "0x49382E8", VA = "0x49382E8")]
    private void OnPrevButton()
    {
    }

    [Token(Token = "0x601175F")]
    [Address(RVA = "0x493819C", Offset = "0x493819C", VA = "0x493819C")]
    private void OnNextButton()
    {
    }

    [Token(Token = "0x6011760")]
    [Address(RVA = "0x493BB54", Offset = "0x493BB54", VA = "0x493BB54")]
    private void UpdateParty()
    {
    }

    [Token(Token = "0x6011761")]
    [Address(RVA = "0x4939E2C", Offset = "0x4939E2C", VA = "0x4939E2C")]
    private int GetStyleStoredExperience(Style style) => new int();

    [Token(Token = "0x6011762")]
    [Address(RVA = "0x493D728", Offset = "0x493D728", VA = "0x493D728")]
    public void OnPararaButton()
    {
    }

    [Token(Token = "0x6011763")]
    [Address(RVA = "0x493D900", Offset = "0x493D900", VA = "0x493D900")]
    private void CheckStyleLevelUp(
      ExpeditionOrganization.ExpeditionOldParty[] oldPartys,
      List<PlayerUnitType> playerUnits)
    {
    }

    [Token(Token = "0x6011764")]
    [Address(RVA = "0x493DC94", Offset = "0x493DC94", VA = "0x493DC94")]
    private void SetLoadPartyAssetData()
    {
    }

    [Token(Token = "0x6011765")]
    [Address(RVA = "0x493E3F4", Offset = "0x493E3F4", VA = "0x493E3F4")]
    public ExpeditionOrganization()
    {
    }

    [Token(Token = "0x2002C9A")]
    private class ExpeditionPartyData
    {
      [Token(Token = "0x400BE73")]
      [FieldOffset(Offset = "0x10")]
      public int PartyNo;
      [Token(Token = "0x400BE74")]
      [FieldOffset(Offset = "0x18")]
      public string StageId;
      [Token(Token = "0x400BE75")]
      [FieldOffset(Offset = "0x20")]
      public bool IsPartyLock;
      [Token(Token = "0x400BE76")]
      [FieldOffset(Offset = "0x28")]
      public bool[] IsSlotLock;
      [Token(Token = "0x400BE77")]
      [FieldOffset(Offset = "0x30")]
      public Style[] SetStyles;
      [Token(Token = "0x400BE78")]
      public const int PARTY_SLOT_NUM = 5;

      [Token(Token = "0x6011773")]
      [Address(RVA = "0x493984C", Offset = "0x493984C", VA = "0x493984C")]
      public ExpeditionPartyData()
      {
      }

      [Token(Token = "0x6011774")]
      [Address(RVA = "0x493E948", Offset = "0x493E948", VA = "0x493E948")]
      public void Reset()
      {
      }
    }

    [Token(Token = "0x2002C9B")]
    public class ExpeditionOldParty
    {
      [Token(Token = "0x400BE79")]
      [FieldOffset(Offset = "0x10")]
      public int partyIndex;
      [Token(Token = "0x400BE7A")]
      [FieldOffset(Offset = "0x18")]
      public ExpeditionOrganization.ExpeditionOldStyle[] oldStyles;
      [Token(Token = "0x400BE7B")]
      public const int PARTY_SLOT_NUM = 5;

      [Token(Token = "0x6011775")]
      [Address(RVA = "0x493EA3C", Offset = "0x493EA3C", VA = "0x493EA3C")]
      public ExpeditionOldParty()
      {
      }
    }

    [Token(Token = "0x2002C9C")]
    public class ExpeditionOldStyle
    {
      [Token(Token = "0x400BE7C")]
      [FieldOffset(Offset = "0x10")]
      public int styleId;
      [Token(Token = "0x400BE7D")]
      [FieldOffset(Offset = "0x14")]
      public int StyleLevel;
      [Token(Token = "0x400BE7E")]
      [FieldOffset(Offset = "0x18")]
      public int StyleExp;
      [Token(Token = "0x400BE7F")]
      [FieldOffset(Offset = "0x1C")]
      public float NextLevelExpRate;
      [Token(Token = "0x400BE80")]
      [FieldOffset(Offset = "0x20")]
      public bool IsLock;
      [Token(Token = "0x400BE81")]
      [FieldOffset(Offset = "0x28")]
      public Style OldStyle;

      [Token(Token = "0x6011776")]
      [Address(RVA = "0x493EA98", Offset = "0x493EA98", VA = "0x493EA98")]
      public ExpeditionOldStyle()
      {
      }
    }
  }
}
