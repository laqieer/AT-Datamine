// Decompiled with JetBrains decompiler
// Type: DuelDebugToolCharacterActionSettingsPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000111")]
public class DuelDebugToolCharacterActionSettingsPanelController : 
  MonoBehaviour,
  IDuelDebugToolActionSettings
{
  [Token(Token = "0x40005AA")]
  [FieldOffset(Offset = "0x18")]
  private DuelDebugToolController duelDebugToolController;
  [Token(Token = "0x40005AB")]
  [FieldOffset(Offset = "0x20")]
  private MasterDataManager masterDataManager;
  [Token(Token = "0x40005AC")]
  private const string DEFAULT_DELIMITER = ":";
  [Token(Token = "0x40005AD")]
  [FieldOffset(Offset = "0x28")]
  public int turnIndex;
  [Token(Token = "0x40005AE")]
  [FieldOffset(Offset = "0x2C")]
  public DuelCharacterController.DuelCharacterRole role;
  [Token(Token = "0x40005AF")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  [Space(20f)]
  private Text title;
  [Token(Token = "0x40005B0")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Dropdown actionTypeDropDown;
  [Token(Token = "0x40005B1")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private GameObject characterStatusSettingsContainer;
  [Token(Token = "0x40005B2")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private GameObject mainActionSettingsContainer;
  [Token(Token = "0x40005B3")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private GameObject passiveActionSettingsContainer;
  [Token(Token = "0x40005B4")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private GameObject normalAttackSettingsContainer;
  [Token(Token = "0x40005B5")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private GameObject stratagemSettingsContainer;
  [Token(Token = "0x40005B6")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private GameObject stratagemSettingsContainer2;
  [Token(Token = "0x40005B7")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private InputField oldHPInputField;
  [Token(Token = "0x40005B8")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private InputField newHPInputField;
  [Token(Token = "0x40005B9")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private Toggle isAbnormalStageToggle;
  [Token(Token = "0x40005BA")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private Dropdown abnormalStateDropDown;
  [Token(Token = "0x40005BB")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private Dropdown skillIDDropDown;
  [Token(Token = "0x40005BC")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private InputField skillIDInputField;
  [Token(Token = "0x40005BD")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private InputField duelResourceNameInputField;
  [Token(Token = "0x40005BE")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private Text duelResourceNameText;
  [Token(Token = "0x40005BF")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private Dropdown mainActionTypeDropDown;
  [Token(Token = "0x40005C0")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private Dropdown normalAttackTypeDropDown;
  [Token(Token = "0x40005C1")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private Toggle isChaseAttackToggle;
  [Token(Token = "0x40005C2")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private Dropdown stratagemWeaponTypeDropDown;
  [Token(Token = "0x40005C3")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private Dropdown stratagemDirectionTypeDropDown;
  [Token(Token = "0x40005C4")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private Dropdown elementTypeDropDown;
  [Token(Token = "0x40005C5")]
  [FieldOffset(Offset = "0xE0")]
  [SerializeField]
  private Toggle isKOToggle;
  [Token(Token = "0x40005C6")]
  [FieldOffset(Offset = "0xE8")]
  [SerializeField]
  private Text isKOText;
  [Token(Token = "0x40005C7")]
  [FieldOffset(Offset = "0xF0")]
  [SerializeField]
  private Toggle isCriticalToggle;
  [Token(Token = "0x40005C8")]
  [FieldOffset(Offset = "0xF8")]
  [SerializeField]
  private Text isCriticalText;
  [Token(Token = "0x40005C9")]
  [FieldOffset(Offset = "0x100")]
  [SerializeField]
  private Toggle isWeaponBreakToggle;
  [Token(Token = "0x40005CA")]
  [FieldOffset(Offset = "0x108")]
  [SerializeField]
  private Dropdown passiveActionTypeDropDown;

  [Token(Token = "0x6000769")]
  [Address(RVA = "0x4854E30", Offset = "0x4854E30", VA = "0x4854E30")]
  public void Initialize(
    DuelDebugToolController duelDebugToolController,
    int turnIndex,
    DuelCharacterController.DuelCharacterRole role)
  {
  }

  [Token(Token = "0x600076A")]
  [Address(RVA = "0x4855CA8", Offset = "0x4855CA8", VA = "0x4855CA8")]
  public void UpdateTurnIndex(int turnIndex)
  {
  }

  [Token(Token = "0x600076B")]
  [Address(RVA = "0x48559AC", Offset = "0x48559AC", VA = "0x48559AC")]
  private void InitializeDropDown(Dropdown dropDown, List<string> optionTextList)
  {
  }

  [Token(Token = "0x600076C")]
  [Address(RVA = "0x4855E0C", Offset = "0x4855E0C", VA = "0x4855E0C")]
  private void InitializeDropDown(Dropdown dropDown, List<int> optionTextList)
  {
  }

  [Token(Token = "0x600076D")]
  [Address(RVA = "0x48557D8", Offset = "0x48557D8", VA = "0x48557D8")]
  private void InitializeDropDown(Dropdown dropDown, System.Type enumType, List<string> excludedValueList = null)
  {
  }

  [Token(Token = "0x600076E")]
  [Address(RVA = "0x4855BA8", Offset = "0x4855BA8", VA = "0x4855BA8")]
  private void SetDropDownValue(Dropdown dropDown, string valueString)
  {
  }

  [Token(Token = "0x600076F")]
  [Address(RVA = "0x4855FBC", Offset = "0x4855FBC", VA = "0x4855FBC")]
  private void SetDropDownValue(Dropdown dropDown, string valueString, string delimiter)
  {
  }

  [Token(Token = "0x6000770")]
  [Address(RVA = "0x4855B40", Offset = "0x4855B40", VA = "0x4855B40")]
  private string GetIDString(string IDWithNameString) => (string) null;

  [Token(Token = "0x6000771")]
  [Address(RVA = "0x48560C8", Offset = "0x48560C8", VA = "0x48560C8")]
  public void OnActionTypeDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x6000772")]
  [Address(RVA = "0x485629C", Offset = "0x485629C", VA = "0x485629C")]
  private void SetToNormalAttack()
  {
  }

  [Token(Token = "0x6000773")]
  [Address(RVA = "0x4856358", Offset = "0x4856358", VA = "0x4856358")]
  public void OnIsAbnormalStateToggleValueChanged(bool isAvailable)
  {
  }

  [Token(Token = "0x6000774")]
  [Address(RVA = "0x4856388", Offset = "0x4856388", VA = "0x4856388")]
  public void OnSkillIDDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x6000775")]
  [Address(RVA = "0x48565C4", Offset = "0x48565C4", VA = "0x48565C4")]
  public void OnMainActionTypeDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x6000776")]
  [Address(RVA = "0x48569F0", Offset = "0x48569F0", VA = "0x48569F0")]
  private int GetDefaultSkillID(SkillCategoryTypeEnum category) => new int();

  [Token(Token = "0x6000777")]
  [Address(RVA = "0x485695C", Offset = "0x485695C", VA = "0x485695C")]
  private void SetImageColor(GameObject target, Color color)
  {
  }

  [Token(Token = "0x6000778")]
  [Address(RVA = "0x4856AF8", Offset = "0x4856AF8", VA = "0x4856AF8")]
  public void OnPassiveActionTypeDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x6000779")]
  [Address(RVA = "0x4856D48", Offset = "0x4856D48", VA = "0x4856D48", Slot = "4")]
  public DuelCharacterAnimation.AnimationType GetActionType()
  {
    return new DuelCharacterAnimation.AnimationType();
  }

  [Token(Token = "0x600077A")]
  [Address(RVA = "0x4856E88", Offset = "0x4856E88", VA = "0x4856E88", Slot = "5")]
  public ActiveSkillActionGroup GetActionGroup() => new ActiveSkillActionGroup();

  [Token(Token = "0x600077B")]
  [Address(RVA = "0x4856E90", Offset = "0x4856E90", VA = "0x4856E90", Slot = "7")]
  public DuelCharacterAnimation.MainAnimationType GetMainActionType()
  {
    return new DuelCharacterAnimation.MainAnimationType();
  }

  [Token(Token = "0x600077C")]
  [Address(RVA = "0x4856FD0", Offset = "0x4856FD0", VA = "0x4856FD0", Slot = "13")]
  public DuelCharacterAnimation.PassiveAnimationType GetPassiveActionType()
  {
    return new DuelCharacterAnimation.PassiveAnimationType();
  }

  [Token(Token = "0x600077D")]
  [Address(RVA = "0x4857110", Offset = "0x4857110", VA = "0x4857110", Slot = "9")]
  public ElementTypeEnum GetElementType() => new ElementTypeEnum();

  [Token(Token = "0x600077E")]
  [Address(RVA = "0x4857250", Offset = "0x4857250", VA = "0x4857250", Slot = "11")]
  public DuelCharacterAnimation.NormalAttackType GetNormalAttackType()
  {
    return new DuelCharacterAnimation.NormalAttackType();
  }

  [Token(Token = "0x600077F")]
  [Address(RVA = "0x4857390", Offset = "0x4857390", VA = "0x4857390", Slot = "16")]
  public bool GetIsAbnormalState() => new bool();

  [Token(Token = "0x6000780")]
  [Address(RVA = "0x48573AC", Offset = "0x48573AC", VA = "0x48573AC", Slot = "17")]
  public BattleBadStatusTypeEnum GetAbnormalState() => new BattleBadStatusTypeEnum();

  [Token(Token = "0x6000781")]
  [Address(RVA = "0x48574EC", Offset = "0x48574EC", VA = "0x48574EC", Slot = "18")]
  public int GetOldHP() => new int();

  [Token(Token = "0x6000782")]
  [Address(RVA = "0x485750C", Offset = "0x485750C", VA = "0x485750C", Slot = "19")]
  public int GetNewHP() => new int();

  [Token(Token = "0x6000783")]
  [Address(RVA = "0x485752C", Offset = "0x485752C", VA = "0x485752C", Slot = "8")]
  public bool GetIsChaseAttack() => new bool();

  [Token(Token = "0x6000784")]
  [Address(RVA = "0x4857548", Offset = "0x4857548", VA = "0x4857548", Slot = "14")]
  public bool GetIsKO() => new bool();

  [Token(Token = "0x6000785")]
  [Address(RVA = "0x4857564", Offset = "0x4857564", VA = "0x4857564", Slot = "15")]
  public bool GetIsCritical() => new bool();

  [Token(Token = "0x6000786")]
  [Address(RVA = "0x4857580", Offset = "0x4857580", VA = "0x4857580", Slot = "12")]
  public bool GetIsWeaponBreak() => new bool();

  [Token(Token = "0x6000787")]
  [Address(RVA = "0x485759C", Offset = "0x485759C", VA = "0x485759C", Slot = "10")]
  public string GetDuelResourceName() => (string) null;

  [Token(Token = "0x6000788")]
  [Address(RVA = "0x48575B8", Offset = "0x48575B8", VA = "0x48575B8", Slot = "6")]
  public string GetSkillID() => (string) null;

  [Token(Token = "0x6000789")]
  [Address(RVA = "0x48575D4", Offset = "0x48575D4", VA = "0x48575D4", Slot = "20")]
  public WeaponTypeEnum GetStratagemWeaponType() => new WeaponTypeEnum();

  [Token(Token = "0x600078A")]
  [Address(RVA = "0x4857714", Offset = "0x4857714", VA = "0x4857714", Slot = "21")]
  public StratagemDirectionTypeEnum GetStratagemDirectionType() => new StratagemDirectionTypeEnum();

  [Token(Token = "0x600078B")]
  [Address(RVA = "0x4857854", Offset = "0x4857854", VA = "0x4857854")]
  public DuelDebugToolCharacterActionSettingsPanelController()
  {
  }
}
