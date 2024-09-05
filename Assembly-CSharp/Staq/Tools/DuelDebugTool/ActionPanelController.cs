// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.ActionPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.UIElements;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000971")]
  public class ActionPanelController
  {
    [Token(Token = "0x4002BBC")]
    [FieldOffset(Offset = "0x10")]
    private readonly VisualTreeAsset _turnButtonTemplate;
    [Token(Token = "0x4002BBD")]
    [FieldOffset(Offset = "0x18")]
    private readonly Button _turnAddButton;
    [Token(Token = "0x4002BBE")]
    [FieldOffset(Offset = "0x20")]
    private readonly Button _turnDelButton;
    [Token(Token = "0x4002BBF")]
    [FieldOffset(Offset = "0x28")]
    private readonly GroupBox _turnCountGroupBox;
    [Token(Token = "0x4002BC0")]
    [FieldOffset(Offset = "0x30")]
    private readonly Button _attackerButton;
    [Token(Token = "0x4002BC1")]
    [FieldOffset(Offset = "0x38")]
    private readonly Button _attackerSupporterButton;
    [Token(Token = "0x4002BC2")]
    [FieldOffset(Offset = "0x40")]
    private readonly Button _defenderButton;
    [Token(Token = "0x4002BC3")]
    [FieldOffset(Offset = "0x48")]
    private readonly Button _defenderSupporterButton;
    [Token(Token = "0x4002BC4")]
    [FieldOffset(Offset = "0x50")]
    private readonly Label _turnLabel;
    [Token(Token = "0x4002BC5")]
    [FieldOffset(Offset = "0x58")]
    private readonly DropdownField _actionTypeDropdown;
    [Token(Token = "0x4002BC6")]
    [FieldOffset(Offset = "0x60")]
    private readonly DropdownField _actionGroupDropdown;
    [Token(Token = "0x4002BC7")]
    [FieldOffset(Offset = "0x68")]
    private readonly GroupBox _mainActionGroup;
    [Token(Token = "0x4002BC8")]
    [FieldOffset(Offset = "0x70")]
    private readonly TextField _skillIdTextField;
    [Token(Token = "0x4002BC9")]
    [FieldOffset(Offset = "0x78")]
    private readonly DropdownField _skillIdDropdown;
    [Token(Token = "0x4002BCA")]
    [FieldOffset(Offset = "0x80")]
    private readonly DropdownField _mainActionTypeDropdown;
    [Token(Token = "0x4002BCB")]
    [FieldOffset(Offset = "0x88")]
    private readonly DropdownField _normalAttackTypeDropdown;
    [Token(Token = "0x4002BCC")]
    [FieldOffset(Offset = "0x90")]
    private readonly Toggle _isChaseAttackToggle;
    [Token(Token = "0x4002BCD")]
    [FieldOffset(Offset = "0x98")]
    private readonly DropdownField _elementTypeDropdown;
    [Token(Token = "0x4002BCE")]
    [FieldOffset(Offset = "0xA0")]
    private readonly Toggle _isWeaponBreakToggle;
    [Token(Token = "0x4002BCF")]
    [FieldOffset(Offset = "0xA8")]
    private readonly GroupBox _stratagemActionGroup;
    [Token(Token = "0x4002BD0")]
    [FieldOffset(Offset = "0xB0")]
    private readonly DropdownField _stratagemWeaponTypeDropdown;
    [Token(Token = "0x4002BD1")]
    [FieldOffset(Offset = "0xB8")]
    private readonly DropdownField _stratagemDirectionTypeDropdown;
    [Token(Token = "0x4002BD2")]
    [FieldOffset(Offset = "0xC0")]
    private readonly GroupBox _passiveActionGroup;
    [Token(Token = "0x4002BD3")]
    [FieldOffset(Offset = "0xC8")]
    private readonly DropdownField _passiveActionTypeDropdown;
    [Token(Token = "0x4002BD4")]
    [FieldOffset(Offset = "0xD0")]
    private readonly Toggle _isKOToggle;
    [Token(Token = "0x4002BD5")]
    [FieldOffset(Offset = "0xD8")]
    private readonly Toggle _isCriticalToggle;
    [Token(Token = "0x4002BD6")]
    [FieldOffset(Offset = "0xE0")]
    private readonly Toggle _receiveBadStatusToggle;
    [Token(Token = "0x4002BD7")]
    [FieldOffset(Offset = "0xE8")]
    private readonly DropdownField _receivedBadStatusTypeDropdown;
    [Token(Token = "0x4002BD8")]
    [FieldOffset(Offset = "0xF0")]
    private readonly DuelDebugDataContainer _dataContainer;
    [Token(Token = "0x4002BD9")]
    [FieldOffset(Offset = "0xF8")]
    private readonly VisualElement _instance;
    [Token(Token = "0x4002BDA")]
    private const string DEFAULT_DELIMITER = ":";
    [Token(Token = "0x4002BDB")]
    [FieldOffset(Offset = "0x100")]
    private ActionPanelController.SelectingState _currentSelectingState;
    [Token(Token = "0x4002BDC")]
    [FieldOffset(Offset = "0x104")]
    private int _currentTurn;

    [Token(Token = "0x600355D")]
    [Address(RVA = "0x3529CE4", Offset = "0x3529CE4", VA = "0x3529CE4")]
    public void Show()
    {
    }

    [Token(Token = "0x600355E")]
    [Address(RVA = "0x3529DC0", Offset = "0x3529DC0", VA = "0x3529DC0")]
    public void Hide()
    {
    }

    [Token(Token = "0x600355F")]
    [Address(RVA = "0x3529E9C", Offset = "0x3529E9C", VA = "0x3529E9C")]
    public ActionPanelController(
      DuelDebugDataContainer dataContainer,
      VisualElement visualElement,
      VisualTreeAsset turnButtonTemplate)
    {
    }

    [Token(Token = "0x6003560")]
    [Address(RVA = "0x352B5B8", Offset = "0x352B5B8", VA = "0x352B5B8")]
    private string GetIDString(string id) => (string) null;

    [Token(Token = "0x6003561")]
    [Address(RVA = "0x352B624", Offset = "0x352B624", VA = "0x352B624")]
    private void OnReceiveBadStatusTypeChange(string value)
    {
    }

    [Token(Token = "0x6003562")]
    [Address(RVA = "0x352B7FC", Offset = "0x352B7FC", VA = "0x352B7FC")]
    private void OnReceiveBadStatusChange(bool newValue)
    {
    }

    [Token(Token = "0x6003563")]
    [Address(RVA = "0x352B828", Offset = "0x352B828", VA = "0x352B828")]
    private void OnCriticalChange(bool newValue)
    {
    }

    [Token(Token = "0x6003564")]
    [Address(RVA = "0x352B854", Offset = "0x352B854", VA = "0x352B854")]
    private void OnKOChange(bool newValue)
    {
    }

    [Token(Token = "0x6003565")]
    [Address(RVA = "0x352B880", Offset = "0x352B880", VA = "0x352B880")]
    private void OnChaseAttackChange(bool newValue)
    {
    }

    [Token(Token = "0x6003566")]
    [Address(RVA = "0x352B8AC", Offset = "0x352B8AC", VA = "0x352B8AC")]
    private void OnWeaponBreakChange(bool newValue)
    {
    }

    [Token(Token = "0x6003567")]
    [Address(RVA = "0x352B8D8", Offset = "0x352B8D8", VA = "0x352B8D8")]
    private void OnPassiveActionTypeChange(string newValue)
    {
    }

    [Token(Token = "0x6003568")]
    [Address(RVA = "0x352B96C", Offset = "0x352B96C", VA = "0x352B96C")]
    private void OnStratagemWeaponTypeChange(string newValue)
    {
    }

    [Token(Token = "0x6003569")]
    [Address(RVA = "0x352BA00", Offset = "0x352BA00", VA = "0x352BA00")]
    private void OnStratagemDirectionTypeChange(string newValue)
    {
    }

    [Token(Token = "0x600356A")]
    [Address(RVA = "0x352BA94", Offset = "0x352BA94", VA = "0x352BA94")]
    private void OnElementTypeChange(string newValue)
    {
    }

    [Token(Token = "0x600356B")]
    [Address(RVA = "0x352BB28", Offset = "0x352BB28", VA = "0x352BB28")]
    private void OnNormalAttackTypeChange(string newValue)
    {
    }

    [Token(Token = "0x600356C")]
    [Address(RVA = "0x352BBBC", Offset = "0x352BBBC", VA = "0x352BBBC")]
    private void OnSkillPullDownChange(string newValue)
    {
    }

    [Token(Token = "0x600356D")]
    [Address(RVA = "0x352BC2C", Offset = "0x352BC2C", VA = "0x352BC2C")]
    private void OnSkillIdChange(string newValue)
    {
    }

    [Token(Token = "0x600356E")]
    [Address(RVA = "0x352BC7C", Offset = "0x352BC7C", VA = "0x352BC7C")]
    private void OnMainActionTypeChange(string newValue)
    {
    }

    [Token(Token = "0x600356F")]
    [Address(RVA = "0x352BD10", Offset = "0x352BD10", VA = "0x352BD10")]
    private void OnActionTypeChange(string newValue)
    {
    }

    [Token(Token = "0x6003570")]
    [Address(RVA = "0x352BF50", Offset = "0x352BF50", VA = "0x352BF50")]
    private void OnActionGroupChange(string newValue)
    {
    }

    [Token(Token = "0x6003571")]
    [Address(RVA = "0x352C0A8", Offset = "0x352C0A8", VA = "0x352C0A8")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003572")]
    [Address(RVA = "0x352C0B0", Offset = "0x352C0B0", VA = "0x352C0B0")]
    public void SetSelectingState(ActionPanelController.SelectingState state)
    {
    }

    [Token(Token = "0x6003573")]
    [Address(RVA = "0x352B1DC", Offset = "0x352B1DC", VA = "0x352B1DC")]
    private void InitializeDropDown(DropdownField dropdownField, List<string> options)
    {
    }

    [Token(Token = "0x6003574")]
    [Address(RVA = "0x352B13C", Offset = "0x352B13C", VA = "0x352B13C")]
    private void InitializeDropDown(DropdownField dropDown, System.Type enumType)
    {
    }

    [Token(Token = "0x6003575")]
    [Address(RVA = "0x352C0B8", Offset = "0x352C0B8", VA = "0x352C0B8")]
    private void AddTurnWithNoDataAddition()
    {
    }

    [Token(Token = "0x6003576")]
    [Address(RVA = "0x352C254", Offset = "0x352C254", VA = "0x352C254")]
    public void AddTurn()
    {
    }

    [Token(Token = "0x6003577")]
    [Address(RVA = "0x352C330", Offset = "0x352C330", VA = "0x352C330")]
    public void RemoveTurn()
    {
    }

    [Token(Token = "0x6003578")]
    [Address(RVA = "0x352B208", Offset = "0x352B208", VA = "0x352B208")]
    public void ClearTurn()
    {
    }

    [Token(Token = "0x6003579")]
    [Address(RVA = "0x352B294", Offset = "0x352B294", VA = "0x352B294")]
    private void SyncTurnToDataContainer()
    {
    }

    [Token(Token = "0x600357A")]
    [Address(RVA = "0x352B6B8", Offset = "0x352B6B8", VA = "0x352B6B8")]
    private DuelDebugAction GetCurrentDuelDebugAction() => (DuelDebugAction) null;

    [Token(Token = "0x600357B")]
    [Address(RVA = "0x352B30C", Offset = "0x352B30C", VA = "0x352B30C")]
    public void SyncToDataContainer()
    {
    }

    [Token(Token = "0x600357C")]
    [Address(RVA = "0x352C420", Offset = "0x352C420", VA = "0x352C420")]
    public void Setup(IDuelDebugToolActionSettings actionSettings)
    {
    }

    [Token(Token = "0x2000972")]
    public enum SelectingState
    {
      [Token(Token = "0x4002BDE")] Attacker,
      [Token(Token = "0x4002BDF")] AttackerSupporter,
      [Token(Token = "0x4002BE0")] Defender,
      [Token(Token = "0x4002BE1")] DefenderSupporter,
    }
  }
}
