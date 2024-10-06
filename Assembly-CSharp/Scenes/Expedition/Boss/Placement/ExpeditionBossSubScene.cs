// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Boss.Placement.ExpeditionBossSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Expedition;
using Battle.Expedition.Data;
using Battle.UI;
using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.Expedition.Main;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Boss.Placement
{
  [Token(Token = "0x2002D4F")]
  public class ExpeditionBossSubScene : SubScene
  {
    [Token(Token = "0x400C268")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject orthographicCanvas;
    [Token(Token = "0x400C269")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400C26A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI turnText;
    [Token(Token = "0x400C26B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI recommendCombatPowerText;
    [Token(Token = "0x400C26C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI combatPowerText;
    [Token(Token = "0x400C26D")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private List<BattlePartyPlayerSlot> slotList;
    [Token(Token = "0x400C26E")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private FieldUnitSimpleStatus unitDetailUI;
    [Token(Token = "0x400C26F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton battleStartButton;
    [Token(Token = "0x400C270")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject battleStartNormalObj;
    [Token(Token = "0x400C271")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject battleStartLockObj;
    [Token(Token = "0x400C272")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C273")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Transform uiObjectParent;
    [Token(Token = "0x400C274")]
    [FieldOffset(Offset = "0xB8")]
    private ExpeditionSceneParameter sceneParameter;
    [Token(Token = "0x400C275")]
    [FieldOffset(Offset = "0xC0")]
    private ExpeditionBossSubSceneParameter subSceneParameter;
    [Token(Token = "0x400C276")]
    [FieldOffset(Offset = "0xC8")]
    private ExpeditionBattle battle;
    [Token(Token = "0x400C277")]
    [FieldOffset(Offset = "0xD0")]
    private bool isInitialized;
    [Token(Token = "0x400C278")]
    [FieldOffset(Offset = "0xD1")]
    private bool isStartBattle;
    [Token(Token = "0x400C279")]
    [FieldOffset(Offset = "0xD4")]
    private int turnLimit;
    [Token(Token = "0x400C27A")]
    [FieldOffset(Offset = "0xD8")]
    private int bossTurn;
    [Token(Token = "0x400C27B")]
    [FieldOffset(Offset = "0xDC")]
    private bool isFastMode;
    [Token(Token = "0x400C27C")]
    [FieldOffset(Offset = "0xE0")]
    private int recommendCombatPower;
    [Token(Token = "0x400C27D")]
    [FieldOffset(Offset = "0xE4")]
    private bool IsExecuteBack;

    [Token(Token = "0x6011B5D")]
    [Address(RVA = "0x42B5E58", Offset = "0x42B5E58", VA = "0x42B5E58", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter)
    {
    }

    [Token(Token = "0x6011B5E")]
    [Address(RVA = "0x42B6098", Offset = "0x42B6098", VA = "0x42B6098", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011B5F")]
    [Address(RVA = "0x42B5F4C", Offset = "0x42B5F4C", VA = "0x42B5F4C")]
    private void TimelineIn()
    {
    }

    [Token(Token = "0x6011B60")]
    [Address(RVA = "0x42B6128", Offset = "0x42B6128", VA = "0x42B6128")]
    public void TimelineOut(Action outFinishAction)
    {
    }

    [Token(Token = "0x6011B61")]
    [Address(RVA = "0x42B62B8", Offset = "0x42B62B8", VA = "0x42B62B8")]
    public void OnClickToGlobalMenu()
    {
    }

    [Token(Token = "0x6011B62")]
    [Address(RVA = "0x42B648C", Offset = "0x42B648C", VA = "0x42B648C", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6011B63")]
    [Address(RVA = "0x42B6B40", Offset = "0x42B6B40", VA = "0x42B6B40", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6011B64")]
    [Address(RVA = "0x42B70D8", Offset = "0x42B70D8", VA = "0x42B70D8")]
    private void Update()
    {
    }

    [Token(Token = "0x6011B65")]
    [Address(RVA = "0x42B7678", Offset = "0x42B7678", VA = "0x42B7678", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6011B66")]
    [Address(RVA = "0x42B7714", Offset = "0x42B7714", VA = "0x42B7714", Slot = "8")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6011B67")]
    [Address(RVA = "0x42B673C", Offset = "0x42B673C", VA = "0x42B673C")]
    private void SetPlayerSlot(List<ExpeditionBattleData.UnitInfo> unitInfos)
    {
    }

    [Token(Token = "0x6011B68")]
    [Address(RVA = "0x42B77C4", Offset = "0x42B77C4", VA = "0x42B77C4")]
    private int CalcCombatPower(Style style) => new int();

    [Token(Token = "0x6011B69")]
    [Address(RVA = "0x42B7854", Offset = "0x42B7854", VA = "0x42B7854")]
    public void OnClickBossEdit()
    {
    }

    [Token(Token = "0x6011B6A")]
    [Address(RVA = "0x42B7A10", Offset = "0x42B7A10", VA = "0x42B7A10")]
    private void UpdatePartyDataByCloseBossEdit(int partyIndex)
    {
    }

    [Token(Token = "0x6011B6B")]
    [Address(RVA = "0x42B7AC8", Offset = "0x42B7AC8", VA = "0x42B7AC8")]
    public void OnClickMenu()
    {
    }

    [Token(Token = "0x6011B6C")]
    [Address(RVA = "0x42B6F00", Offset = "0x42B6F00", VA = "0x42B6F00")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6011B6D")]
    [Address(RVA = "0x42B7AD4", Offset = "0x42B7AD4", VA = "0x42B7AD4")]
    public void OnClickFast()
    {
    }

    [Token(Token = "0x6011B6E")]
    [Address(RVA = "0x42B7B08", Offset = "0x42B7B08", VA = "0x42B7B08")]
    public void OnClickStart()
    {
    }

    [Token(Token = "0x6011B6F")]
    [Address(RVA = "0x42B7DFC", Offset = "0x42B7DFC", VA = "0x42B7DFC")]
    private void ShowUnitDetailUI(int manageNo)
    {
    }

    [Token(Token = "0x6011B70")]
    [Address(RVA = "0x42B79E8", Offset = "0x42B79E8", VA = "0x42B79E8")]
    private void HideUnitDetailUI()
    {
    }

    [Token(Token = "0x6011B71")]
    [Address(RVA = "0x42B7F70", Offset = "0x42B7F70", VA = "0x42B7F70")]
    private void ShowUnitDetail(UnitParameterData unit, int barrierIndex)
    {
    }

    [Token(Token = "0x6011B72")]
    [Address(RVA = "0x42B71BC", Offset = "0x42B71BC", VA = "0x42B71BC")]
    private void CheckUnitDeath()
    {
    }

    [Token(Token = "0x6011B73")]
    [Address(RVA = "0x42B80CC", Offset = "0x42B80CC", VA = "0x42B80CC")]
    public void ShowUnit(
      BoardData board,
      UnitParameterData unit,
      BattlePlayerData owner,
      bool isNeedLp,
      int barrierIndex,
      Action<UnitPanel> finishInitializeAction)
    {
    }

    [Token(Token = "0x6011B74")]
    [Address(RVA = "0x42B84A0", Offset = "0x42B84A0", VA = "0x42B84A0")]
    public BattlePopupPanel ShowStyle(StyleModel style) => (BattlePopupPanel) null;

    [Token(Token = "0x6011B75")]
    [Address(RVA = "0x42B84FC", Offset = "0x42B84FC", VA = "0x42B84FC")]
    private StylePanel ShowStyle(out StyleModel model) => (StylePanel) null;

    [Token(Token = "0x6011B76")]
    [Address(RVA = "0x42B871C", Offset = "0x42B871C", VA = "0x42B871C")]
    public EquipmentPanel ShowWeapon(WeaponModel weapon) => (EquipmentPanel) null;

    [Token(Token = "0x6011B77")]
    [Address(RVA = "0x42B8778", Offset = "0x42B8778", VA = "0x42B8778")]
    private EquipmentPanel ShowWeaponInfo(out WeaponModel model) => (EquipmentPanel) null;

    [Token(Token = "0x6011B78")]
    [Address(RVA = "0x42B8C34", Offset = "0x42B8C34", VA = "0x42B8C34")]
    public EquipmentPanel ShowAccessory(AccessoryModel acc) => (EquipmentPanel) null;

    [Token(Token = "0x6011B79")]
    [Address(RVA = "0x42B8C90", Offset = "0x42B8C90", VA = "0x42B8C90")]
    private EquipmentPanel ShowAccessory(out AccessoryModel model) => (EquipmentPanel) null;

    [Token(Token = "0x6011B7A")]
    [Address(RVA = "0x42B9144", Offset = "0x42B9144", VA = "0x42B9144")]
    public EquipmentPanel ShowUnitTrust(TrustModel trust) => (EquipmentPanel) null;

    [Token(Token = "0x6011B7B")]
    [Address(RVA = "0x42B91A0", Offset = "0x42B91A0", VA = "0x42B91A0")]
    private EquipmentPanel ShowUnitTrust(out TrustModel model) => (EquipmentPanel) null;

    [Token(Token = "0x6011B7C")]
    [Address(RVA = "0x42B9680", Offset = "0x42B9680", VA = "0x42B9680")]
    public EquipmentPanel ShowMindEquipment(MindEquipmentModel mindEquipment)
    {
      return (EquipmentPanel) null;
    }

    [Token(Token = "0x6011B7D")]
    [Address(RVA = "0x42B96DC", Offset = "0x42B96DC", VA = "0x42B96DC")]
    private EquipmentPanel ShowMindEquipment(out MindEquipmentModel model) => (EquipmentPanel) null;

    [Token(Token = "0x6011B7E")]
    [Address(RVA = "0x42B9CA4", Offset = "0x42B9CA4", VA = "0x42B9CA4")]
    public SkillDetailPanel ShowSkillDetail(SkillModel skill) => (SkillDetailPanel) null;

    [Token(Token = "0x6011B7F")]
    [Address(RVA = "0x42B9D00", Offset = "0x42B9D00", VA = "0x42B9D00")]
    private SkillDetailPanel ShowSkillDetail(out SkillModel model) => (SkillDetailPanel) null;

    [Token(Token = "0x6011B80")]
    [Address(RVA = "0x42B9E7C", Offset = "0x42B9E7C", VA = "0x42B9E7C")]
    private BattleConditionDetailPanel ShowBattleConditionDetail(StatusConditionModel[] models)
    {
      return (BattleConditionDetailPanel) null;
    }

    [Token(Token = "0x6011B81")]
    [Address(RVA = "0x42B9F1C", Offset = "0x42B9F1C", VA = "0x42B9F1C")]
    public ExpeditionBossSubScene()
    {
    }
  }
}
