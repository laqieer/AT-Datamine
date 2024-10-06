// Decompiled with JetBrains decompiler
// Type: DuelDebugToolCharacterSettingsPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000116")]
public class DuelDebugToolCharacterSettingsPanelController : 
  MonoBehaviour,
  IDuelDebugToolCharacterSettings
{
  [Token(Token = "0x40005D2")]
  [FieldOffset(Offset = "0x18")]
  private DuelDebugToolController duelDebugToolController;
  [Token(Token = "0x40005D3")]
  [FieldOffset(Offset = "0x20")]
  private MasterDataManager masterDataManager;
  [Token(Token = "0x40005D4")]
  private const string DEFAULT_DELIMITER = ":";
  [Token(Token = "0x40005D5")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Toggle isAvailableToggle;
  [Token(Token = "0x40005D6")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private GameObject characterSettingsContainer;
  [Token(Token = "0x40005D7")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Dropdown characterStyleIDDropDown;
  [Token(Token = "0x40005D8")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private InputField characterStyleIDInputField;
  [Token(Token = "0x40005D9")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private Dropdown characterIDDropDown;
  [Token(Token = "0x40005DA")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private InputField characterIDInputField;
  [Token(Token = "0x40005DB")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private Dropdown overrideMotionTypeDropDown;
  [Token(Token = "0x40005DC")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private InputField overrideMotionTypeInputField;
  [Token(Token = "0x40005DD")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private Dropdown duelMotionTypeDropDown;
  [Token(Token = "0x40005DE")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private TMP_InputField duelMotionTypeInputField;
  [Token(Token = "0x40005DF")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private Dropdown commonSkillMotionTypeDropDown;
  [Token(Token = "0x40005E0")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private TMP_InputField commonSkillMotionTypeInputField;
  [Token(Token = "0x40005E1")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private Dropdown weaponIDDropDown;
  [Token(Token = "0x40005E2")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private InputField weaponIDInputField;
  [Token(Token = "0x40005E3")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private Dropdown weaponClassDropDown;
  [Token(Token = "0x40005E4")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Dropdown vehicleStyleIDDropDown;
  [Token(Token = "0x40005E5")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private InputField vehicleStyleIDInputField;
  [Token(Token = "0x40005E6")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private Dropdown vehicleCharacterIDDropDown;
  [Token(Token = "0x40005E7")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private InputField vehicleCharacterIDInputField;
  [Token(Token = "0x40005E8")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private Dropdown genderDropDown;
  [Token(Token = "0x40005E9")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private InputField currentHPInputField;
  [Token(Token = "0x40005EA")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private InputField maxHPInputField;
  [Token(Token = "0x40005EB")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private Toggle isAbnormalStageToggle;
  [Token(Token = "0x40005EC")]
  [FieldOffset(Offset = "0xE0")]
  [SerializeField]
  private Dropdown abnormalStateDropDown;

  [Token(Token = "0x6000796")]
  [Address(RVA = "0x4857A7C", Offset = "0x4857A7C", VA = "0x4857A7C")]
  public void Initialize(
    DuelDebugToolController duelDebugToolController,
    bool isAvailable,
    string defaultCharacterStyleID = null)
  {
  }

  [Token(Token = "0x6000797")]
  [Address(RVA = "0x4858734", Offset = "0x4858734", VA = "0x4858734")]
  private void InitializeDropDown(Dropdown dropDown, List<string> optionTextList)
  {
  }

  [Token(Token = "0x6000798")]
  [Address(RVA = "0x4858BC0", Offset = "0x4858BC0", VA = "0x4858BC0")]
  private void InitializeDropDown(Dropdown dropDown, List<int> optionTextList)
  {
  }

  [Token(Token = "0x6000799")]
  [Address(RVA = "0x4858930", Offset = "0x4858930", VA = "0x4858930")]
  private void InitializeDropDown(Dropdown dropDown, System.Type enumType)
  {
  }

  [Token(Token = "0x600079A")]
  [Address(RVA = "0x48589BC", Offset = "0x48589BC", VA = "0x48589BC")]
  private void SetDropDownValue(Dropdown dropDown, string valueString)
  {
  }

  [Token(Token = "0x600079B")]
  [Address(RVA = "0x4858ABC", Offset = "0x4858ABC", VA = "0x4858ABC")]
  private void SetDropDownValue(Dropdown dropDown, string valueString, string delimiter)
  {
  }

  [Token(Token = "0x600079C")]
  [Address(RVA = "0x48588C8", Offset = "0x48588C8", VA = "0x48588C8")]
  private string GetIDString(string IDWithNameString) => (string) null;

  [Token(Token = "0x600079D")]
  [Address(RVA = "0x4858D78", Offset = "0x4858D78", VA = "0x4858D78")]
  public void OnIsAvailableToggleValueChanged(bool isAvailable)
  {
  }

  [Token(Token = "0x600079E")]
  [Address(RVA = "0x4858D98", Offset = "0x4858D98", VA = "0x4858D98")]
  public void OnCharacterStyleIDDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x600079F")]
  [Address(RVA = "0x48590E4", Offset = "0x48590E4", VA = "0x48590E4")]
  public void OnCharacterIDDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x60007A0")]
  [Address(RVA = "0x485916C", Offset = "0x485916C", VA = "0x485916C")]
  public void OnVehicleStyleIDDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x60007A1")]
  [Address(RVA = "0x48593A0", Offset = "0x48593A0", VA = "0x48593A0")]
  public void OnVehicleCharacterIDDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x60007A2")]
  [Address(RVA = "0x4859428", Offset = "0x4859428", VA = "0x4859428")]
  public void OnWeaponIDDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x60007A3")]
  [Address(RVA = "0x4859608", Offset = "0x4859608", VA = "0x4859608")]
  public void OnCommonSkillMotionTypeValueChanged(int value)
  {
  }

  [Token(Token = "0x60007A4")]
  [Address(RVA = "0x485968C", Offset = "0x485968C", VA = "0x485968C")]
  public void OnDuelMotionTypeValueChanged(int value)
  {
  }

  [Token(Token = "0x60007A5")]
  [Address(RVA = "0x4859710", Offset = "0x4859710", VA = "0x4859710")]
  public void OnWeaponClassificationDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x60007A6")]
  [Address(RVA = "0x4859920", Offset = "0x4859920", VA = "0x4859920")]
  public void OnIsAbnormalStateToggleValueChanged(bool isAvailable)
  {
  }

  [Token(Token = "0x60007A7")]
  [Address(RVA = "0x4859950", Offset = "0x4859950", VA = "0x4859950", Slot = "4")]
  public bool GetIsAvailable() => new bool();

  [Token(Token = "0x60007A8")]
  [Address(RVA = "0x485996C", Offset = "0x485996C", VA = "0x485996C", Slot = "5")]
  public string GetWeaponClass() => (string) null;

  [Token(Token = "0x60007A9")]
  [Address(RVA = "0x48599E0", Offset = "0x48599E0", VA = "0x48599E0", Slot = "7")]
  public int GetWeaponID() => new int();

  [Token(Token = "0x60007AA")]
  [Address(RVA = "0x4859A00", Offset = "0x4859A00", VA = "0x4859A00", Slot = "8")]
  public int GetCharacterID() => new int();

  [Token(Token = "0x60007AB")]
  [Address(RVA = "0x4859A20", Offset = "0x4859A20", VA = "0x4859A20", Slot = "9")]
  public int GetCharacterStyleID() => new int();

  [Token(Token = "0x60007AC")]
  [Address(RVA = "0x4859A40", Offset = "0x4859A40", VA = "0x4859A40", Slot = "10")]
  public string GetDuelMotionType() => (string) null;

  [Token(Token = "0x60007AD")]
  [Address(RVA = "0x4859A5C", Offset = "0x4859A5C", VA = "0x4859A5C", Slot = "11")]
  public string GetCommonSkillMotionType() => (string) null;

  [Token(Token = "0x60007AE")]
  [Address(RVA = "0x4859A78", Offset = "0x4859A78", VA = "0x4859A78", Slot = "6")]
  public string GetOverrideMotionType() => (string) null;

  [Token(Token = "0x60007AF")]
  [Address(RVA = "0x4859A94", Offset = "0x4859A94", VA = "0x4859A94")]
  public int GetVehicleCharacterID() => new int();

  [Token(Token = "0x60007B0")]
  [Address(RVA = "0x4859AB4", Offset = "0x4859AB4", VA = "0x4859AB4", Slot = "12")]
  public int GetVehicleStyleID() => new int();

  [Token(Token = "0x60007B1")]
  [Address(RVA = "0x4859AD4", Offset = "0x4859AD4", VA = "0x4859AD4", Slot = "13")]
  public SexTypeEnum GetGender() => new SexTypeEnum();

  [Token(Token = "0x60007B2")]
  [Address(RVA = "0x4859C14", Offset = "0x4859C14", VA = "0x4859C14", Slot = "14")]
  public bool GetIsAbnormalState() => new bool();

  [Token(Token = "0x60007B3")]
  [Address(RVA = "0x4859C30", Offset = "0x4859C30", VA = "0x4859C30", Slot = "15")]
  public BattleBadStatusTypeEnum GetAbnormalState() => new BattleBadStatusTypeEnum();

  [Token(Token = "0x60007B4")]
  [Address(RVA = "0x4859D70", Offset = "0x4859D70", VA = "0x4859D70", Slot = "16")]
  public int GetMaxHP() => new int();

  [Token(Token = "0x60007B5")]
  [Address(RVA = "0x4859D90", Offset = "0x4859D90", VA = "0x4859D90", Slot = "17")]
  public int GetCurrentHP() => new int();

  [Token(Token = "0x60007B6")]
  [Address(RVA = "0x4859DB0", Offset = "0x4859DB0", VA = "0x4859DB0")]
  public DuelDebugToolCharacterSettingsPanelController()
  {
  }
}
