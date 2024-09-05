// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.Status.TrainingStatusPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.Status
{
  [Token(Token = "0x20004ED")]
  [Serializable]
  public class TrainingStatusPane
  {
    [Token(Token = "0x40019D7")]
    [FieldOffset(Offset = "0x10")]
    private UnitCustomizeStateHandler stateHandler;
    [Token(Token = "0x40019D8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] awakeIcons;
    [Token(Token = "0x40019D9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button awakeButton;
    [Token(Token = "0x40019DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] limitbreakIcons;
    [Token(Token = "0x40019DB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button limitbreakButton;
    [Token(Token = "0x40019DC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UnitDetailItemIcon trustMasterIcon;
    [Token(Token = "0x40019DD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Slider abilityBoardSlider;
    [Token(Token = "0x40019DE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image[] abilityBoardMaskImages;
    [Token(Token = "0x40019DF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text abilityBoardProgressText;
    [Token(Token = "0x40019E0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button abilityBoardButton;

    [Token(Token = "0x6001C1E")]
    [Address(RVA = "0x2C318A8", Offset = "0x2C318A8", VA = "0x2C318A8")]
    public void Initialize(UnitCustomizeStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001C1F")]
    [Address(RVA = "0x2C3285C", Offset = "0x2C3285C", VA = "0x2C3285C")]
    public void Update(UnitDetailInfo unitDetailInfo)
    {
    }

    [Token(Token = "0x6001C20")]
    [Address(RVA = "0x2C32CC0", Offset = "0x2C32CC0", VA = "0x2C32CC0")]
    private void UpdateAwakeIcon(int awakeCount)
    {
    }

    [Token(Token = "0x6001C21")]
    [Address(RVA = "0x2C32D2C", Offset = "0x2C32D2C", VA = "0x2C32D2C")]
    private void UpdateLimitbreakIcon(int limitbreak)
    {
    }

    [Token(Token = "0x6001C22")]
    [Address(RVA = "0x2C32D98", Offset = "0x2C32D98", VA = "0x2C32D98")]
    private void OnClickAwakeButton()
    {
    }

    [Token(Token = "0x6001C23")]
    [Address(RVA = "0x2C32DB0", Offset = "0x2C32DB0", VA = "0x2C32DB0")]
    private void OnClickLimitBreakButton()
    {
    }

    [Token(Token = "0x6001C24")]
    [Address(RVA = "0x2C32DC8", Offset = "0x2C32DC8", VA = "0x2C32DC8")]
    private void OnClickAbilityBoardButton()
    {
    }

    [Token(Token = "0x6001C25")]
    [Address(RVA = "0x2C32DFC", Offset = "0x2C32DFC", VA = "0x2C32DFC")]
    private void OnLongPressTrustMasterDetail()
    {
    }

    [Token(Token = "0x6001C26")]
    [Address(RVA = "0x2C32E70", Offset = "0x2C32E70", VA = "0x2C32E70")]
    public TrainingStatusPane()
    {
    }
  }
}
