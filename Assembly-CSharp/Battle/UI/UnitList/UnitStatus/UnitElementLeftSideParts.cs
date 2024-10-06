// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitList.UnitStatus.UnitElementLeftSideParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI.UnitList.UnitStatus
{
  [Token(Token = "0x2002445")]
  public class UnitElementLeftSideParts : UnitStatusFactorBase
  {
    [Token(Token = "0x4009B82")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton unitButton;
    [Token(Token = "0x4009B83")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [HideInInspector]
    private UnitStatusTween tweener;
    [Token(Token = "0x4009B84")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text unitName;
    [Token(Token = "0x4009B85")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x4009B86")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image unitTroopsNumber;
    [Token(Token = "0x4009B87")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image unitImageBg;
    [Token(Token = "0x4009B88")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Sprite ownBgSprite;
    [Token(Token = "0x4009B89")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Sprite enemyBgSprite;
    [Token(Token = "0x4009B8A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Sprite neutralBgSprite;
    [Token(Token = "0x4009B8B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Sprite allyBgSprite;
    [Token(Token = "0x4009B8C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Image unitElementIcon;
    [Token(Token = "0x4009B8D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject lpIconBase;
    [Token(Token = "0x4009B8E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private List<Image> lpIcons;
    [Token(Token = "0x4009B8F")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject doubleFrameObject;
    [Token(Token = "0x4009B90")]
    [FieldOffset(Offset = "0xB8")]
    private List<string> playAnimationList;
    [Token(Token = "0x4009B91")]
    [FieldOffset(Offset = "0xC0")]
    private UnitParameterData targetUnit;
    [Token(Token = "0x4009B92")]
    [FieldOffset(Offset = "0xC8")]
    public UnityAction<UnitParameterData> onSelectUnit;

    [Token(Token = "0x600DE50")]
    [Address(RVA = "0x1E3195C", Offset = "0x1E3195C", VA = "0x1E3195C", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600DE51")]
    [Address(RVA = "0x1E31A08", Offset = "0x1E31A08", VA = "0x1E31A08", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600DE52")]
    [Address(RVA = "0x1E31C58", Offset = "0x1E31C58", VA = "0x1E31C58")]
    private void SetUnitForceColor(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DE53")]
    [Address(RVA = "0x1E31D40", Offset = "0x1E31D40", VA = "0x1E31D40")]
    private void SetUnitLP(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DE54")]
    [Address(RVA = "0x1E31E68", Offset = "0x1E31E68", VA = "0x1E31E68")]
    private void SetDoubled(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DE55")]
    [Address(RVA = "0x1E31F7C", Offset = "0x1E31F7C", VA = "0x1E31F7C")]
    private void SetAlive(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DE56")]
    [Address(RVA = "0x1E31FC4", Offset = "0x1E31FC4", VA = "0x1E31FC4")]
    public void OnClickUnitListItem()
    {
    }

    [Token(Token = "0x600DE57")]
    [Address(RVA = "0x1E31FE4", Offset = "0x1E31FE4", VA = "0x1E31FE4", Slot = "6")]
    public override void SetFactor(UnitStatusFactorBase.UnitListShowFactor factor)
    {
    }

    [Token(Token = "0x600DE58")]
    [Address(RVA = "0x1E31FE8", Offset = "0x1E31FE8", VA = "0x1E31FE8")]
    public UnitElementLeftSideParts()
    {
    }
  }
}
