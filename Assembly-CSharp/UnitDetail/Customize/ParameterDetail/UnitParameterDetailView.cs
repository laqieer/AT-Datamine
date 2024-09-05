// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.UnitParameterDetailView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004FB")]
  public class UnitParameterDetailView : MonoBehaviour
  {
    [Token(Token = "0x40019FD")]
    private const string In = "In_StatusDetail";
    [Token(Token = "0x40019FE")]
    private const string Out = "Out_StatusDetail";
    [Token(Token = "0x40019FF")]
    private const string CorrectParameterPartsPrefabName = "StatusDetail_CorrectParameter_Parts";
    [Token(Token = "0x4001A00")]
    private const string BasicParamterPartsDummyPrefabName = "StatusDetail_BasicParameter_Parts_Dummy";
    [Token(Token = "0x4001A01")]
    private const string BasicParamterPartsDummy2PrefabName = "StatusDetail_BasicParameter_Parts_Dummy_2";
    [Token(Token = "0x4001A02")]
    private const string BattleParamterPartsDummyPrefabName = "StatusDetail_BattleParameter_Parts_Dummy";
    [Token(Token = "0x4001A03")]
    private const string BattleParamterPartsDummy2PrefabName = "StatusDetail_BattleParameter_Parts_Dummy_2";
    [Token(Token = "0x4001A04")]
    private const string CorrectParameterPartsDummyPrefabName = "StatusDetail_CorrectParameter_Parts_Dummy";
    [Token(Token = "0x4001A05")]
    private const string CorrectParameterPartsDummy2PrefabName = "StatusDetail_CorrectParameter_Parts_Dummy_2";
    [Token(Token = "0x4001A06")]
    private const string ParameterPartsDummyPrefabName = "StatusDetail_Parameter_Parts_Dummy";
    [Token(Token = "0x4001A07")]
    private const string ParameterPartsDummy2PrefabName = "StatusDetail_Parameter_Parts_Dummy_2";
    [Token(Token = "0x4001A08")]
    [FieldOffset(Offset = "0x18")]
    private UnitCustomizeStateHandler stateHandler;
    [Token(Token = "0x4001A09")]
    [FieldOffset(Offset = "0x20")]
    private BasicParameterCell basicParamterCellPrefab;
    [Token(Token = "0x4001A0A")]
    [FieldOffset(Offset = "0x28")]
    private BasicParameterAdditionCell basicParamterAdditionCellPrefab;
    [Token(Token = "0x4001A0B")]
    [FieldOffset(Offset = "0x30")]
    private BattleParameterCell battleParameterCellPrefab;
    [Token(Token = "0x4001A0C")]
    [FieldOffset(Offset = "0x38")]
    private BattleParameterAdditionCell battleParameterAdditionCellPrefab;
    [Token(Token = "0x4001A0D")]
    [FieldOffset(Offset = "0x40")]
    private CorrectParameterCell correctParameterCellPrefab;
    [Token(Token = "0x4001A0E")]
    [FieldOffset(Offset = "0x48")]
    private CorrectParameterAdditionCell correctParameterAdditionCellPrefab;
    [Token(Token = "0x4001A0F")]
    [FieldOffset(Offset = "0x50")]
    private ParameterCell parameterCellPrefab;
    [Token(Token = "0x4001A10")]
    [FieldOffset(Offset = "0x58")]
    private ParameterAdditionCell parameterAdditionCellPrefab;
    [Token(Token = "0x4001A11")]
    [FieldOffset(Offset = "0x60")]
    private List<BasicParameterCell> basicParameterCellList;
    [Token(Token = "0x4001A12")]
    [FieldOffset(Offset = "0x68")]
    private List<BasicParameterAdditionCell> basicParameterAddtionCellList;
    [Token(Token = "0x4001A13")]
    [FieldOffset(Offset = "0x70")]
    private List<BattleParameterCell> battleParameterCellList;
    [Token(Token = "0x4001A14")]
    [FieldOffset(Offset = "0x78")]
    private List<BattleParameterAdditionCell> battleParameterAdditionCellList;
    [Token(Token = "0x4001A15")]
    [FieldOffset(Offset = "0x80")]
    private List<CorrectParameterCell> correctParameterCellList;
    [Token(Token = "0x4001A16")]
    [FieldOffset(Offset = "0x88")]
    private List<CorrectParameterAdditionCell> correctParameterAdditionCellList;
    [Token(Token = "0x4001A17")]
    [FieldOffset(Offset = "0x90")]
    private List<ParameterCell> reinforcementParameterCellList;
    [Token(Token = "0x4001A18")]
    [FieldOffset(Offset = "0x98")]
    private List<ParameterAdditionCell> reinforcementParameterAdditionCellList;
    [Token(Token = "0x4001A19")]
    [FieldOffset(Offset = "0xA0")]
    private List<ParameterCell> reinforcementParameter2CellList;
    [Token(Token = "0x4001A1A")]
    [FieldOffset(Offset = "0xA8")]
    private List<ParameterAdditionCell> reinforcementParameter2AdditionCellList;
    [Token(Token = "0x4001A1B")]
    [FieldOffset(Offset = "0xB0")]
    private List<ParameterCell> resistanceParameterCellList;
    [Token(Token = "0x4001A1C")]
    [FieldOffset(Offset = "0xB8")]
    private List<ParameterAdditionCell> resistanceParameterAdditionCellList;
    [Token(Token = "0x4001A1D")]
    [FieldOffset(Offset = "0xC0")]
    private List<ParameterCell> resistanceParameter2CellList;
    [Token(Token = "0x4001A1E")]
    [FieldOffset(Offset = "0xC8")]
    private List<ParameterAdditionCell> resistanceParameter2AdditionCellList;
    [Token(Token = "0x4001A1F")]
    [FieldOffset(Offset = "0xD0")]
    private List<ParameterCell> specialAttackParameterCellList;
    [Token(Token = "0x4001A20")]
    [FieldOffset(Offset = "0xD8")]
    private List<ParameterAdditionCell> specialAttackParameterAdditionCellList;
    [Token(Token = "0x4001A21")]
    [FieldOffset(Offset = "0xE0")]
    private List<ParameterCell> specialAttackResistanceParameterCellList;
    [Token(Token = "0x4001A22")]
    [FieldOffset(Offset = "0xE8")]
    private List<ParameterAdditionCell> specialAttackResistanceParameterAdditionCellList;
    [Token(Token = "0x4001A23")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x4001A24")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text combatPower;
    [Token(Token = "0x4001A25")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private Text averageLevelup;
    [Token(Token = "0x4001A26")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Text level;
    [Token(Token = "0x4001A27")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Text abilityBoard;
    [Token(Token = "0x4001A28")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Image[] limitBreakIcons;
    [Token(Token = "0x4001A29")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private Image[] awakeIcons;
    [Token(Token = "0x4001A2A")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private Transform basicParameterPartsRoot;
    [Token(Token = "0x4001A2B")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private Transform basicParameterAdditionPartsRoot;
    [Token(Token = "0x4001A2C")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private Transform battleParameterPartsRoot;
    [Token(Token = "0x4001A2D")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private Transform battleParameterAdditionPartsRoot;
    [Token(Token = "0x4001A2E")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private Transform reinforcementParameterPartsRoot;
    [Token(Token = "0x4001A2F")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private Transform reinforcementParameterAdditionPartsRoot;
    [Token(Token = "0x4001A30")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private Transform reinforcementParameter2PartsRoot;
    [Token(Token = "0x4001A31")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private Transform reinforcementParameter2AdditionPartsRoot;
    [Token(Token = "0x4001A32")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private Transform resistanceParameterPartsRoot;
    [Token(Token = "0x4001A33")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private Transform resistanceParameterAdditionPartsRoot;
    [Token(Token = "0x4001A34")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private Transform resistanceParameter2PartsRoot;
    [Token(Token = "0x4001A35")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private Transform resistanceParameter2AdditionPartsRoot;
    [Token(Token = "0x4001A36")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private Transform specialAttackParameterPartsRoot;
    [Token(Token = "0x4001A37")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private Transform specialAttackParameterAdditionPartsRoot;
    [Token(Token = "0x4001A38")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private Transform specialAttackResistanceParameterPartsRoot;
    [Token(Token = "0x4001A39")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private Transform specialAttackResistanceParameterAdditionPartsRoot;
    [Token(Token = "0x4001A3A")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private Transform correctParameterPartsRoot;
    [Token(Token = "0x4001A3B")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private Transform correctParameterAdditionPartsRoot;
    [Token(Token = "0x4001A3C")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private Button backButton;
    [Token(Token = "0x4001A3D")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    private Button parameterDetailButton;
    [Token(Token = "0x4001A3E")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private Button featureDetailButton;
    [Token(Token = "0x4001A3F")]
    [FieldOffset(Offset = "0x1D0")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001A40")]
    private const int BattleParameterDisplayCount = 9;
    [Token(Token = "0x4001A41")]
    private const int ResistanceParameterDisplayCount = 11;
    [Token(Token = "0x4001A42")]
    private const int ResistanceParameter2DisplayCount = 12;
    [Token(Token = "0x4001A43")]
    private const int SpecialAttackParameterDisplayCount = 3;
    [Token(Token = "0x4001A44")]
    [FieldOffset(Offset = "0x1D8")]
    private bool IsActiveBasicParameter;
    [Token(Token = "0x4001A45")]
    [FieldOffset(Offset = "0x1D9")]
    private bool IsActiveBattleParameter;
    [Token(Token = "0x4001A46")]
    [FieldOffset(Offset = "0x1DA")]
    private bool IsActiveReinforcementParameter;
    [Token(Token = "0x4001A47")]
    [FieldOffset(Offset = "0x1DB")]
    private bool IsActiveReinforcement2Parameter;
    [Token(Token = "0x4001A48")]
    [FieldOffset(Offset = "0x1DC")]
    private bool IsActiveResistanceParameter;
    [Token(Token = "0x4001A49")]
    [FieldOffset(Offset = "0x1DD")]
    private bool IsActiveResistance2Parameter;
    [Token(Token = "0x4001A4A")]
    [FieldOffset(Offset = "0x1DE")]
    private bool IsActiveSpecialAttackParameter;
    [Token(Token = "0x4001A4B")]
    [FieldOffset(Offset = "0x1DF")]
    private bool IsActiveSpecialAttackResistanceParameter;
    [Token(Token = "0x4001A4C")]
    [FieldOffset(Offset = "0x1E0")]
    private bool IsActiveCorrectParameter;

    [Token(Token = "0x17000396")]
    public UITweenGroup TweenGroup
    {
      [Token(Token = "0x6001C61"), Address(RVA = "0x2C341CC", Offset = "0x2C341CC", VA = "0x2C341CC")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x6001C62")]
    [Address(RVA = "0x2C2E058", Offset = "0x2C2E058", VA = "0x2C2E058")]
    public void Initialize(UnitCustomizeStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001C63")]
    [Address(RVA = "0x2C30428", Offset = "0x2C30428", VA = "0x2C30428")]
    public void UpdateView(Style style)
    {
    }

    [Token(Token = "0x6001C64")]
    [Address(RVA = "0x2C2FD64", Offset = "0x2C2FD64", VA = "0x2C2FD64")]
    public void UpdateView(Style style, ItemInfoBase itemInfo = null)
    {
    }

    [Token(Token = "0x6001C65")]
    [Address(RVA = "0x2C30528", Offset = "0x2C30528", VA = "0x2C30528")]
    public void PlayIn(UIAnimationController animationController)
    {
    }

    [Token(Token = "0x6001C66")]
    [Address(RVA = "0x2C305AC", Offset = "0x2C305AC", VA = "0x2C305AC")]
    public void PlayOut(UIAnimationController animationController)
    {
    }

    [Token(Token = "0x6001C67")]
    [Address(RVA = "0x2C35C40", Offset = "0x2C35C40", VA = "0x2C35C40")]
    public void OnClickBackButton()
    {
    }

    [Token(Token = "0x6001C68")]
    [Address(RVA = "0x2C35C58", Offset = "0x2C35C58", VA = "0x2C35C58")]
    public void OnClickFeatureDetailButton()
    {
    }

    [Token(Token = "0x6001C69")]
    [Address(RVA = "0x2C35C74", Offset = "0x2C35C74", VA = "0x2C35C74")]
    public void OnClickInformationButton()
    {
    }

    [Token(Token = "0x6001C6A")]
    [Address(RVA = "0x2C35C8C", Offset = "0x2C35C8C", VA = "0x2C35C8C")]
    public void OnClickBasicParamerButton()
    {
    }

    [Token(Token = "0x6001C6B")]
    [Address(RVA = "0x2C35CC8", Offset = "0x2C35CC8", VA = "0x2C35CC8")]
    public void OnClickBattleParamerButton()
    {
    }

    [Token(Token = "0x6001C6C")]
    [Address(RVA = "0x2C35D04", Offset = "0x2C35D04", VA = "0x2C35D04")]
    public void OnClickReinforcementParameterButton()
    {
    }

    [Token(Token = "0x6001C6D")]
    [Address(RVA = "0x2C35D40", Offset = "0x2C35D40", VA = "0x2C35D40")]
    public void OnClickReinforcement2ParamerButton()
    {
    }

    [Token(Token = "0x6001C6E")]
    [Address(RVA = "0x2C35D7C", Offset = "0x2C35D7C", VA = "0x2C35D7C")]
    public void OnClickResistanceParamerButton()
    {
    }

    [Token(Token = "0x6001C6F")]
    [Address(RVA = "0x2C35DB8", Offset = "0x2C35DB8", VA = "0x2C35DB8")]
    public void OnClickResistance2ParamerButton()
    {
    }

    [Token(Token = "0x6001C70")]
    [Address(RVA = "0x2C35DF4", Offset = "0x2C35DF4", VA = "0x2C35DF4")]
    public void OnClickSpecialAttackParamerButton()
    {
    }

    [Token(Token = "0x6001C71")]
    [Address(RVA = "0x2C35E30", Offset = "0x2C35E30", VA = "0x2C35E30")]
    public void OnClickSpecialAttackResistanceParamerButton()
    {
    }

    [Token(Token = "0x6001C72")]
    [Address(RVA = "0x2C35E6C", Offset = "0x2C35E6C", VA = "0x2C35E6C")]
    public void OnClickCorrectParamerButton()
    {
    }

    [Token(Token = "0x6001C73")]
    [Address(RVA = "0x2C35BD0", Offset = "0x2C35BD0", VA = "0x2C35BD0")]
    public void ShowButtons()
    {
    }

    [Token(Token = "0x6001C74")]
    [Address(RVA = "0x2C2EF24", Offset = "0x2C2EF24", VA = "0x2C2EF24")]
    public void HideButtons()
    {
    }

    [Token(Token = "0x6001C75")]
    [Address(RVA = "0x2C2F514", Offset = "0x2C2F514", VA = "0x2C2F514")]
    public void UpdateUnitImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6001C76")]
    [Address(RVA = "0x2C341D4", Offset = "0x2C341D4", VA = "0x2C341D4")]
    private void UpdateOverview(Style style)
    {
    }

    [Token(Token = "0x6001C77")]
    [Address(RVA = "0x2C35EA8", Offset = "0x2C35EA8", VA = "0x2C35EA8")]
    private List<Equipment> GetEquipments(Style style, ItemInfoBase itemInfo)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x6001C78")]
    [Address(RVA = "0x2C344E4", Offset = "0x2C344E4", VA = "0x2C344E4")]
    private void UpdateBasicParameter(Style unit, ItemInfoBase itemInfo = null)
    {
    }

    [Token(Token = "0x6001C79")]
    [Address(RVA = "0x2C3626C", Offset = "0x2C3626C", VA = "0x2C3626C")]
    private void UpdateBasicParamterCell(
      BasicParameterType basicParameterType,
      Style unit,
      IBasicParameter changedParameter)
    {
    }

    [Token(Token = "0x6001C7A")]
    [Address(RVA = "0x2C34620", Offset = "0x2C34620", VA = "0x2C34620")]
    private void UpdateBattleParameter(Style style, ItemInfoBase itemInfo = null)
    {
    }

    [Token(Token = "0x6001C7B")]
    [Address(RVA = "0x2C36420", Offset = "0x2C36420", VA = "0x2C36420")]
    private void UpdateBattleParameterCell(
      BattleParameterType battleParameterType,
      Style style,
      IBattleParameter changedParameter)
    {
    }

    [Token(Token = "0x6001C7C")]
    [Address(RVA = "0x2C34770", Offset = "0x2C34770", VA = "0x2C34770")]
    public void UpdateCorrectparameter(Style style)
    {
    }

    [Token(Token = "0x6001C7D")]
    [Address(RVA = "0x2C3656C", Offset = "0x2C3656C", VA = "0x2C3656C")]
    private void UpdateCorrectParameterCell(
      string label,
      BattleParameterType battleParameterType,
      int offsetRate,
      StyleParameter.ChangedParameter<StyleParameter> changedParameter,
      StyleMasterBonusParameter.ChangedParameter<StyleMasterBonusParameter> styleMasterBonusParam)
    {
    }

    [Token(Token = "0x6001C7E")]
    [Address(RVA = "0x2C34BC0", Offset = "0x2C34BC0", VA = "0x2C34BC0")]
    public void UpdateReinforcementParameter(
      Style style,
      StyleParameter.EquipmentParameter equipmentParameter,
      ItemInfoBase itemInfo = null,
      StyleParameter.EquipmentParameter beforeEquipmentParameter = null)
    {
    }

    [Token(Token = "0x6001C7F")]
    [Address(RVA = "0x2C36718", Offset = "0x2C36718", VA = "0x2C36718")]
    private void UpdateReinforcementParameterCell(
      string label,
      int index,
      ElementTypeEnum elementType,
      Style unit,
      FeatureWraper<ElementTypeEnum, int> equipmentWraper)
    {
    }

    [Token(Token = "0x6001C80")]
    [Address(RVA = "0x2C368A8", Offset = "0x2C368A8", VA = "0x2C368A8")]
    private void UpdateReinforcementParameterCell(
      string label,
      int index,
      AttackTypeEnum attackType,
      Style unit,
      FeatureWraper<AttackTypeEnum, int> equipmentWraper)
    {
    }

    [Token(Token = "0x6001C81")]
    [Address(RVA = "0x2C36A34", Offset = "0x2C36A34", VA = "0x2C36A34")]
    private void UpdateReinforcementParameter2Cell(string label, int index)
    {
    }

    [Token(Token = "0x6001C82")]
    [Address(RVA = "0x2C352B4", Offset = "0x2C352B4", VA = "0x2C352B4")]
    public void UpdateResistanceParameter(
      Style style,
      StyleParameter.EquipmentParameter equipmentParameter,
      ItemInfoBase itemInfo = null,
      StyleParameter.EquipmentParameter beforeEquipmentParameter = null)
    {
    }

    [Token(Token = "0x6001C83")]
    [Address(RVA = "0x2C36AE8", Offset = "0x2C36AE8", VA = "0x2C36AE8")]
    private void UpdateResistanceParameterCell(
      string label,
      int index,
      ElementTypeEnum elementType,
      Style unit,
      FeatureWraper<ElementTypeEnum, int> equipmentWraper)
    {
    }

    [Token(Token = "0x6001C84")]
    [Address(RVA = "0x2C36C78", Offset = "0x2C36C78", VA = "0x2C36C78")]
    private void UpdateResistanceParameterCell(
      string label,
      int index,
      AttackTypeEnum attackType,
      Style unit,
      FeatureWraper<AttackTypeEnum, int> equipmentWraper)
    {
    }

    [Token(Token = "0x6001C85")]
    [Address(RVA = "0x2C36E04", Offset = "0x2C36E04", VA = "0x2C36E04")]
    private void UpdateResistanceParameter2Cell(string label, int index)
    {
    }

    [Token(Token = "0x6001C86")]
    [Address(RVA = "0x2C359A8", Offset = "0x2C359A8", VA = "0x2C359A8")]
    public void UpdateSpecialAttackParameter(Style style)
    {
    }

    [Token(Token = "0x6001C87")]
    [Address(RVA = "0x2C36EB8", Offset = "0x2C36EB8", VA = "0x2C36EB8")]
    private void UpdateSpecialAttackParameterCell(string label, int index)
    {
    }

    [Token(Token = "0x6001C88")]
    [Address(RVA = "0x2C35ABC", Offset = "0x2C35ABC", VA = "0x2C35ABC")]
    public void UpdateSpecialAttackResistanceParameter(Style style)
    {
    }

    [Token(Token = "0x6001C89")]
    [Address(RVA = "0x2C36F6C", Offset = "0x2C36F6C", VA = "0x2C36F6C")]
    private void UpdateSpecialAttackResistanceParameterCell(string label, int index)
    {
    }

    [Token(Token = "0x6001C8A")]
    [Address(RVA = "0x2C37020", Offset = "0x2C37020", VA = "0x2C37020")]
    public UnitParameterDetailView()
    {
    }
  }
}
