// Decompiled with JetBrains decompiler
// Type: Battle.UI.PlayerCommandPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Process;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002333")]
  public class PlayerCommandPanel : MonoBehaviour, IDisposable
  {
    [Token(Token = "0x400955B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button endTurnButton;
    [Token(Token = "0x400955C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button useItemButton;
    [Token(Token = "0x400955D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button rewindButton;
    [Token(Token = "0x400955E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerCommandSimpleBattleLog simpleBattleLog;
    [Token(Token = "0x400955F")]
    [FieldOffset(Offset = "0x38")]
    private UIManager UI;
    [Token(Token = "0x4009560")]
    [FieldOffset(Offset = "0x40")]
    private ICommandPanelEventHandler eventHandler;
    [Token(Token = "0x4009561")]
    [FieldOffset(Offset = "0x48")]
    private int rewindLeftCount;
    [Token(Token = "0x4009562")]
    [FieldOffset(Offset = "0x4C")]
    private bool rewindEnableSetting;
    [Token(Token = "0x4009563")]
    [FieldOffset(Offset = "0x50")]
    private int freeRollbackLimit;
    [Token(Token = "0x4009564")]
    [FieldOffset(Offset = "0x54")]
    private bool canItemUseButton;

    [Token(Token = "0x17002E61")]
    public bool IsRewindEnable
    {
      [Token(Token = "0x600D732"), Address(RVA = "0x1D25F8C", Offset = "0x1D25F8C", VA = "0x1D25F8C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D733")]
    [Address(RVA = "0x1D25FB0", Offset = "0x1D25FB0", VA = "0x1D25FB0")]
    public void Initialize(UIManager uiManager, ISystemFlags systemFlags, bool hasItem)
    {
    }

    [Token(Token = "0x600D734")]
    [Address(RVA = "0x1D26230", Offset = "0x1D26230", VA = "0x1D26230")]
    public void SetRewindParameter(bool rewindEnableSetting, BattleCore core)
    {
    }

    [Token(Token = "0x600D735")]
    [Address(RVA = "0x1D2635C", Offset = "0x1D2635C", VA = "0x1D2635C", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600D736")]
    [Address(RVA = "0x1D26384", Offset = "0x1D26384", VA = "0x1D26384")]
    public void SetEventHandler(ICommandPanelEventHandler handler)
    {
    }

    [Token(Token = "0x600D737")]
    [Address(RVA = "0x1D26360", Offset = "0x1D26360", VA = "0x1D26360")]
    public void ReleaseEventHandler()
    {
    }

    [Token(Token = "0x600D738")]
    [Address(RVA = "0x1D2655C", Offset = "0x1D2655C", VA = "0x1D2655C")]
    public void Show()
    {
    }

    [Token(Token = "0x600D739")]
    [Address(RVA = "0x1D26580", Offset = "0x1D26580", VA = "0x1D26580")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D73A")]
    [Address(RVA = "0x1D265A4", Offset = "0x1D265A4", VA = "0x1D265A4")]
    public void OnPushTurnEndButton()
    {
    }

    [Token(Token = "0x600D73B")]
    [Address(RVA = "0x1D26A48", Offset = "0x1D26A48", VA = "0x1D26A48")]
    public void OnPushUseItemButton()
    {
    }

    [Token(Token = "0x600D73C")]
    [Address(RVA = "0x1D26AF4", Offset = "0x1D26AF4", VA = "0x1D26AF4")]
    public void OnPushRewindButton()
    {
    }

    [Token(Token = "0x600D73D")]
    [Address(RVA = "0x1D26BA0", Offset = "0x1D26BA0", VA = "0x1D26BA0")]
    public void CloseBattleLog()
    {
    }

    [Token(Token = "0x600D73E")]
    [Address(RVA = "0x1D26C4C", Offset = "0x1D26C4C", VA = "0x1D26C4C")]
    public void SetLogText(string log_text)
    {
    }

    [Token(Token = "0x600D73F")]
    [Address(RVA = "0x1D26C9C", Offset = "0x1D26C9C", VA = "0x1D26C9C")]
    public void EnablePlayerCommandButton(bool enable)
    {
    }

    [Token(Token = "0x600D740")]
    [Address(RVA = "0x1D262E0", Offset = "0x1D262E0", VA = "0x1D262E0")]
    public void UpdateRewindButton(BattleCore core)
    {
    }

    [Token(Token = "0x600D741")]
    [Address(RVA = "0x1D26D20", Offset = "0x1D26D20", VA = "0x1D26D20")]
    public PlayerCommandPanel()
    {
    }
  }
}
