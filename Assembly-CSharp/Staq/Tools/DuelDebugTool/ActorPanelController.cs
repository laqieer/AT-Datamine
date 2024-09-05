// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.ActorPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.UIElements;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000975")]
  public class ActorPanelController
  {
    [Token(Token = "0x4002BE7")]
    [FieldOffset(Offset = "0x10")]
    private readonly Toggle _availableToggle;
    [Token(Token = "0x4002BE8")]
    [FieldOffset(Offset = "0x18")]
    private readonly Button _autoSettingButton;
    [Token(Token = "0x4002BE9")]
    [FieldOffset(Offset = "0x20")]
    private readonly TextField _styleIdTextField;
    [Token(Token = "0x4002BEA")]
    [FieldOffset(Offset = "0x28")]
    private readonly DropdownField _styleIdDropdown;
    [Token(Token = "0x4002BEB")]
    [FieldOffset(Offset = "0x30")]
    private readonly TextField _duelMotionTypeTextField;
    [Token(Token = "0x4002BEC")]
    [FieldOffset(Offset = "0x38")]
    private readonly DropdownField _duelMotionTypeDropdown;
    [Token(Token = "0x4002BED")]
    [FieldOffset(Offset = "0x40")]
    private readonly TextField _skillMotionTypeTextField;
    [Token(Token = "0x4002BEE")]
    [FieldOffset(Offset = "0x48")]
    private readonly DropdownField _skillMotionTypeDropdown;
    [Token(Token = "0x4002BEF")]
    [FieldOffset(Offset = "0x50")]
    private readonly TextField _overrideMotionTypeTextField;
    [Token(Token = "0x4002BF0")]
    [FieldOffset(Offset = "0x58")]
    private readonly TextField _weaponIdTextField;
    [Token(Token = "0x4002BF1")]
    [FieldOffset(Offset = "0x60")]
    private readonly DropdownField _weaponIdDropdownField;
    [Token(Token = "0x4002BF2")]
    [FieldOffset(Offset = "0x68")]
    private readonly TextField _weaponClassTextField;
    [Token(Token = "0x4002BF3")]
    [FieldOffset(Offset = "0x70")]
    private readonly DropdownField _weaponClassDropdown;
    [Token(Token = "0x4002BF4")]
    [FieldOffset(Offset = "0x78")]
    private readonly TextField _vehicleStyleIdTextField;
    [Token(Token = "0x4002BF5")]
    [FieldOffset(Offset = "0x80")]
    private readonly DropdownField _vehicleStyleIdDropdown;
    [Token(Token = "0x4002BF6")]
    [FieldOffset(Offset = "0x88")]
    private readonly DropdownField _genderDropdown;
    [Token(Token = "0x4002BF7")]
    [FieldOffset(Offset = "0x90")]
    private readonly Toggle _initialBadStatusToggle;
    [Token(Token = "0x4002BF8")]
    [FieldOffset(Offset = "0x98")]
    private readonly DropdownField _initialBadStatusTypeDropdown;
    [Token(Token = "0x4002BF9")]
    [FieldOffset(Offset = "0xA0")]
    private readonly DuelDebugDataContainer _dataContainer;
    [Token(Token = "0x4002BFA")]
    [FieldOffset(Offset = "0xA8")]
    private readonly VisualElement _instance;
    [Token(Token = "0x4002BFB")]
    private const string DEFAULT_DELIMITER = ":";
    [Token(Token = "0x4002BFC")]
    [FieldOffset(Offset = "0xB0")]
    private DuelDebugActor _currentActor;

    [Token(Token = "0x6003599")]
    [Address(RVA = "0x352DAFC", Offset = "0x352DAFC", VA = "0x352DAFC")]
    public void Show()
    {
    }

    [Token(Token = "0x600359A")]
    [Address(RVA = "0x352DBD8", Offset = "0x352DBD8", VA = "0x352DBD8")]
    public void Hide()
    {
    }

    [Token(Token = "0x600359B")]
    [Address(RVA = "0x352DCB4", Offset = "0x352DCB4", VA = "0x352DCB4")]
    private void InitializeDropDown(DropdownField dropdownField, List<string> options)
    {
    }

    [Token(Token = "0x600359C")]
    [Address(RVA = "0x352DCE0", Offset = "0x352DCE0", VA = "0x352DCE0")]
    private void InitializeDropDown(DropdownField dropDown, System.Type enumType)
    {
    }

    [Token(Token = "0x600359D")]
    [Address(RVA = "0x352DD80", Offset = "0x352DD80", VA = "0x352DD80")]
    public void ChangeCurrentActor(DuelDebugActorType type)
    {
    }

    [Token(Token = "0x600359E")]
    [Address(RVA = "0x352E494", Offset = "0x352E494", VA = "0x352E494")]
    public ActorPanelController(DuelDebugDataContainer dataContainer, VisualElement visualElement)
    {
    }

    [Token(Token = "0x600359F")]
    [Address(RVA = "0x352DDF8", Offset = "0x352DDF8", VA = "0x352DDF8")]
    private void Setup()
    {
    }

    [Token(Token = "0x60035A0")]
    [Address(RVA = "0x352F51C", Offset = "0x352F51C", VA = "0x352F51C")]
    private string GetIDString(string id) => (string) null;

    [Token(Token = "0x60035A1")]
    [Address(RVA = "0x352F588", Offset = "0x352F588", VA = "0x352F588")]
    private void OnAvailableChange(bool newValue)
    {
    }

    [Token(Token = "0x60035A2")]
    [Address(RVA = "0x352F5A8", Offset = "0x352F5A8", VA = "0x352F5A8")]
    private void OnChangeBadStatusType(string newValue)
    {
    }

    [Token(Token = "0x60035A3")]
    [Address(RVA = "0x352F6B0", Offset = "0x352F6B0", VA = "0x352F6B0")]
    private void OnChangeInitialBadStatus(bool newValue)
    {
    }

    [Token(Token = "0x60035A4")]
    [Address(RVA = "0x352F6D0", Offset = "0x352F6D0", VA = "0x352F6D0")]
    private void OnChangeGenderDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035A5")]
    [Address(RVA = "0x352F7D8", Offset = "0x352F7D8", VA = "0x352F7D8")]
    private void OnChangeVehicleIdDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035A6")]
    [Address(RVA = "0x352F834", Offset = "0x352F834", VA = "0x352F834")]
    private void OnChangeWeaponClassDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035A7")]
    [Address(RVA = "0x352F878", Offset = "0x352F878", VA = "0x352F878")]
    private void OnChangeWeaponIdDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035A8")]
    [Address(RVA = "0x352F8D4", Offset = "0x352F8D4", VA = "0x352F8D4")]
    private void OnChangeSkillMotionTypeDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035A9")]
    [Address(RVA = "0x352F918", Offset = "0x352F918", VA = "0x352F918")]
    private void OnChangeDuelMotionTypeDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035AA")]
    [Address(RVA = "0x352F95C", Offset = "0x352F95C", VA = "0x352F95C")]
    private void OnChangeOverrideMotionTypeDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035AB")]
    [Address(RVA = "0x352F9A0", Offset = "0x352F9A0", VA = "0x352F9A0")]
    private void OnChangeStyleId(string newValue)
    {
    }

    [Token(Token = "0x60035AC")]
    [Address(RVA = "0x352F9C8", Offset = "0x352F9C8", VA = "0x352F9C8")]
    private void OnChangeStyleIdDropdown(string newValue)
    {
    }

    [Token(Token = "0x60035AD")]
    [Address(RVA = "0x352FCD4", Offset = "0x352FCD4", VA = "0x352FCD4")]
    public bool GetIsAvailable() => new bool();

    [Token(Token = "0x60035AE")]
    [Address(RVA = "0x352FCF8", Offset = "0x352FCF8", VA = "0x352FCF8")]
    public string GetWeaponClass() => (string) null;

    [Token(Token = "0x60035AF")]
    [Address(RVA = "0x352FD1C", Offset = "0x352FD1C", VA = "0x352FD1C")]
    public int GetWeaponID() => new int();

    [Token(Token = "0x60035B0")]
    [Address(RVA = "0x352FD48", Offset = "0x352FD48", VA = "0x352FD48")]
    public int GetCharacterID() => new int();

    [Token(Token = "0x60035B1")]
    [Address(RVA = "0x352FF04", Offset = "0x352FF04", VA = "0x352FF04")]
    public int GetCharacterStyleID() => new int();

    [Token(Token = "0x60035B2")]
    [Address(RVA = "0x352FF30", Offset = "0x352FF30", VA = "0x352FF30")]
    public string GetDuelMotionType() => (string) null;

    [Token(Token = "0x60035B3")]
    [Address(RVA = "0x352FF54", Offset = "0x352FF54", VA = "0x352FF54")]
    public string GetCommonSkillMotionType() => (string) null;

    [Token(Token = "0x60035B4")]
    [Address(RVA = "0x352FF78", Offset = "0x352FF78", VA = "0x352FF78")]
    public int GetVehicleStyleID() => new int();

    [Token(Token = "0x60035B5")]
    [Address(RVA = "0x352FFA4", Offset = "0x352FFA4", VA = "0x352FFA4")]
    public SexTypeEnum GetGender() => new SexTypeEnum();

    [Token(Token = "0x60035B6")]
    [Address(RVA = "0x35300BC", Offset = "0x35300BC", VA = "0x35300BC")]
    public bool GetIsAbnormalState() => new bool();

    [Token(Token = "0x60035B7")]
    [Address(RVA = "0x35300E0", Offset = "0x35300E0", VA = "0x35300E0")]
    public BattleBadStatusTypeEnum GetAbnormalState() => new BattleBadStatusTypeEnum();

    [Token(Token = "0x60035B8")]
    [Address(RVA = "0x35301F8", Offset = "0x35301F8", VA = "0x35301F8")]
    public int GetMaxHP() => new int();

    [Token(Token = "0x60035B9")]
    [Address(RVA = "0x3530200", Offset = "0x3530200", VA = "0x3530200")]
    public int GetCurrentHP() => new int();
  }
}
