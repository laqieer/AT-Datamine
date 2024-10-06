// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.LeftPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.UIElements;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x200098B")]
  public class LeftPanelController
  {
    [Token(Token = "0x4002C65")]
    [FieldOffset(Offset = "0x10")]
    private readonly GroupBox _menuGroup;
    [Token(Token = "0x4002C66")]
    [FieldOffset(Offset = "0x18")]
    private readonly Button _saveButton;
    [Token(Token = "0x4002C67")]
    [FieldOffset(Offset = "0x20")]
    private readonly Button _loadButton;
    [Token(Token = "0x4002C68")]
    [FieldOffset(Offset = "0x28")]
    private readonly Button _resetButton;
    [Token(Token = "0x4002C69")]
    [FieldOffset(Offset = "0x30")]
    private readonly Button _environmentButton;
    [Token(Token = "0x4002C6A")]
    [FieldOffset(Offset = "0x38")]
    private readonly Button _attackerButton;
    [Token(Token = "0x4002C6B")]
    [FieldOffset(Offset = "0x40")]
    private readonly Button _attackerSupporterButton;
    [Token(Token = "0x4002C6C")]
    [FieldOffset(Offset = "0x48")]
    private readonly Button _defenderButton;
    [Token(Token = "0x4002C6D")]
    [FieldOffset(Offset = "0x50")]
    private readonly Button _defenderSupporterButton;
    [Token(Token = "0x4002C6E")]
    [FieldOffset(Offset = "0x58")]
    private readonly Button _actions;
    [Token(Token = "0x4002C6F")]
    [FieldOffset(Offset = "0x60")]
    private readonly Button _initializeButton;
    [Token(Token = "0x4002C70")]
    [FieldOffset(Offset = "0x68")]
    private readonly Button _playButton;
    [Token(Token = "0x4002C71")]
    [FieldOffset(Offset = "0x70")]
    private readonly Button _clearButton;
    [Token(Token = "0x4002C72")]
    [FieldOffset(Offset = "0x78")]
    private readonly Button _closeButton;
    [Token(Token = "0x4002C73")]
    [FieldOffset(Offset = "0x80")]
    private readonly DuelDebugDataContainer _dataContainer;
    [Token(Token = "0x4002C74")]
    [FieldOffset(Offset = "0x88")]
    private readonly VisualElement _instance;
    [Token(Token = "0x4002C75")]
    [FieldOffset(Offset = "0x90")]
    public Action OnClickSave;
    [Token(Token = "0x4002C76")]
    [FieldOffset(Offset = "0x98")]
    public Action OnClickLoad;
    [Token(Token = "0x4002C77")]
    [FieldOffset(Offset = "0xA0")]
    public Action OnClickReset;
    [Token(Token = "0x4002C78")]
    [FieldOffset(Offset = "0xA8")]
    public Action OnClickEnvironment;
    [Token(Token = "0x4002C79")]
    [FieldOffset(Offset = "0xB0")]
    public Action OnClickAttacker;
    [Token(Token = "0x4002C7A")]
    [FieldOffset(Offset = "0xB8")]
    public Action OnClickAttackerSupporter;
    [Token(Token = "0x4002C7B")]
    [FieldOffset(Offset = "0xC0")]
    public Action OnClickDefender;
    [Token(Token = "0x4002C7C")]
    [FieldOffset(Offset = "0xC8")]
    public Action OnClickDefenderSupporter;
    [Token(Token = "0x4002C7D")]
    [FieldOffset(Offset = "0xD0")]
    public Action OnClickActions;
    [Token(Token = "0x4002C7E")]
    [FieldOffset(Offset = "0xD8")]
    public Action OnClickInitialize;
    [Token(Token = "0x4002C7F")]
    [FieldOffset(Offset = "0xE0")]
    public Action OnClickPlay;
    [Token(Token = "0x4002C80")]
    [FieldOffset(Offset = "0xE8")]
    public Action OnClickClear;

    [Token(Token = "0x6003642")]
    [Address(RVA = "0x3534B1C", Offset = "0x3534B1C", VA = "0x3534B1C")]
    public void Show()
    {
    }

    [Token(Token = "0x6003643")]
    [Address(RVA = "0x3534BF8", Offset = "0x3534BF8", VA = "0x3534BF8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6003644")]
    [Address(RVA = "0x3532FFC", Offset = "0x3532FFC", VA = "0x3532FFC")]
    public void ShowMenu()
    {
    }

    [Token(Token = "0x6003645")]
    [Address(RVA = "0x3533138", Offset = "0x3533138", VA = "0x3533138")]
    public void HideMenu()
    {
    }

    [Token(Token = "0x6003646")]
    [Address(RVA = "0x35324AC", Offset = "0x35324AC", VA = "0x35324AC")]
    public LeftPanelController(VisualElement visualElement)
    {
    }

    [Token(Token = "0x6003647")]
    [Address(RVA = "0x3534CD4", Offset = "0x3534CD4", VA = "0x3534CD4")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003648")]
    [Address(RVA = "0x3534CD8", Offset = "0x3534CD8", VA = "0x3534CD8")]
    private void onClickSave()
    {
    }

    [Token(Token = "0x6003649")]
    [Address(RVA = "0x3534CF4", Offset = "0x3534CF4", VA = "0x3534CF4")]
    private void onClickLoad()
    {
    }

    [Token(Token = "0x600364A")]
    [Address(RVA = "0x3534D10", Offset = "0x3534D10", VA = "0x3534D10")]
    private void onClickReset()
    {
    }

    [Token(Token = "0x600364B")]
    [Address(RVA = "0x3534D2C", Offset = "0x3534D2C", VA = "0x3534D2C")]
    private void onClickEnvironment()
    {
    }

    [Token(Token = "0x600364C")]
    [Address(RVA = "0x3534D48", Offset = "0x3534D48", VA = "0x3534D48")]
    public void onClickAttacker()
    {
    }

    [Token(Token = "0x600364D")]
    [Address(RVA = "0x3534D6C", Offset = "0x3534D6C", VA = "0x3534D6C")]
    public void onClickAttackerSupporter()
    {
    }

    [Token(Token = "0x600364E")]
    [Address(RVA = "0x3534D90", Offset = "0x3534D90", VA = "0x3534D90")]
    public void onClickDefender()
    {
    }

    [Token(Token = "0x600364F")]
    [Address(RVA = "0x3534DB4", Offset = "0x3534DB4", VA = "0x3534DB4")]
    public void onClickDefenderSupporter()
    {
    }

    [Token(Token = "0x6003650")]
    [Address(RVA = "0x3534DD8", Offset = "0x3534DD8", VA = "0x3534DD8")]
    public void onClickActions()
    {
    }

    [Token(Token = "0x6003651")]
    [Address(RVA = "0x3534DFC", Offset = "0x3534DFC", VA = "0x3534DFC")]
    public void onClickInitialize()
    {
    }

    [Token(Token = "0x6003652")]
    [Address(RVA = "0x3534E20", Offset = "0x3534E20", VA = "0x3534E20")]
    public void onClickPlay()
    {
    }

    [Token(Token = "0x6003653")]
    [Address(RVA = "0x3534E44", Offset = "0x3534E44", VA = "0x3534E44")]
    public void onClickClear()
    {
    }
  }
}
