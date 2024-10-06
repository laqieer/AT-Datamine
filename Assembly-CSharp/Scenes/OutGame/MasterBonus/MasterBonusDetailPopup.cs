// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.MasterBonusDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003518")]
  public class MasterBonusDetailPopup : PopupBase
  {
    [Token(Token = "0x400E6F4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    [Space]
    [Header("ボーナス値の表示制御用オブジェクト")]
    private ContainerMasterBonusDetail currentMasterBonusValues;
    [Token(Token = "0x400E6F5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ContainerMasterBonusDetail nextMasterBonusValues;
    [Token(Token = "0x400E6F6")]
    [FieldOffset(Offset = "0x98")]
    [Header("ボタン")]
    [SerializeField]
    [Space]
    private CommonButton buttonClose;
    [Token(Token = "0x400E6F7")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    [Header("経験値の表示制御")]
    [Space]
    private Text textCurrentLevel;
    [Token(Token = "0x400E6F8")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text textNextLevel;
    [Token(Token = "0x400E6F9")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text textDeltaNextLevelExperience;
    [Token(Token = "0x400E6FA")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Slider sliderExp;
    [Token(Token = "0x400E6FB")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    [Header("マスターボーナスの名前/アイコンの表示")]
    [Space]
    private Text textMasterBonus;
    [Token(Token = "0x400E6FC")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Image iconMasterBonus;
    [Token(Token = "0x400E6FD")]
    [FieldOffset(Offset = "0xD0")]
    [Space]
    [Header("次のレベルがある時に表示するオブジェクト")]
    [SerializeField]
    private GameObject objectNextLevelText;
    [Token(Token = "0x400E6FE")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject objectNextLevel;
    [Token(Token = "0x400E6FF")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject objectArrow;
    [Token(Token = "0x400E700")]
    [FieldOffset(Offset = "0xE8")]
    [Header("最大レベルの時に表示するオブジェクト")]
    [Space]
    [SerializeField]
    private GameObject objectMaxLevelText;
    [Token(Token = "0x400E701")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject objectMaxLevel;
    [Token(Token = "0x400E702")]
    [FieldOffset(Offset = "0xF8")]
    public Action<MasterBonusDetailPopup> OnClickCloseEvent;

    [Token(Token = "0x6014D28")]
    [Address(RVA = "0x1B3C12C", Offset = "0x1B3C12C", VA = "0x1B3C12C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6014D29")]
    [Address(RVA = "0x1B3C1BC", Offset = "0x1B3C1BC", VA = "0x1B3C1BC")]
    private void SetCurrentLevel(int currentLevel)
    {
    }

    [Token(Token = "0x6014D2A")]
    [Address(RVA = "0x1B3C204", Offset = "0x1B3C204", VA = "0x1B3C204")]
    private void SetNextLevel(int nextLevel, int maxLv)
    {
    }

    [Token(Token = "0x6014D2B")]
    [Address(RVA = "0x1B3C364", Offset = "0x1B3C364", VA = "0x1B3C364")]
    private void SetExperience(
      int currentExperience,
      int nextLevelExperience,
      int nowLevelExperienceFrom,
      bool isMaxLevel)
    {
    }

    [Token(Token = "0x6014D2C")]
    [Address(RVA = "0x1B3C3F4", Offset = "0x1B3C3F4", VA = "0x1B3C3F4")]
    public void SetupMasterBonusValues(ContainerMasterBonusDetailResource resource, int maxLv)
    {
    }

    [Token(Token = "0x6014D2D")]
    [Address(RVA = "0x1B3CC40", Offset = "0x1B3CC40", VA = "0x1B3CC40", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6014D2E")]
    [Address(RVA = "0x1B3CC60", Offset = "0x1B3CC60", VA = "0x1B3CC60", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6014D2F")]
    [Address(RVA = "0x1B3CD04", Offset = "0x1B3CD04", VA = "0x1B3CD04", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6014D30")]
    [Address(RVA = "0x1B3CDA0", Offset = "0x1B3CDA0", VA = "0x1B3CDA0")]
    public MasterBonusDetailPopup()
    {
    }
  }
}
