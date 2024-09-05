// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ItemList.ArmouryItemThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.ItemList
{
  [Token(Token = "0x2003866")]
  internal class ArmouryItemThumb : InfiniteCellBase
  {
    [Token(Token = "0x400F649")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArmoryCommonThumbBase thumbBase;
    [Token(Token = "0x400F64A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ArmouryDisplayEquippedIcon equippedIcon;
    [Token(Token = "0x400F64B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform itemNameBase;
    [Token(Token = "0x400F64C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI itemNameText;
    [Token(Token = "0x400F64D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject effectiveDate;
    [Token(Token = "0x400F64E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI effectiveDateText;
    [Token(Token = "0x400F64F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI numPieces;

    [Token(Token = "0x17004925")]
    private ArmouryItemThumbResource Resource
    {
      [Token(Token = "0x60162B8"), Address(RVA = "0x1DEED20", Offset = "0x1DEED20", VA = "0x1DEED20")] get
      {
        return (ArmouryItemThumbResource) null;
      }
    }

    [Token(Token = "0x60162B9")]
    [Address(RVA = "0x1DEEDA8", Offset = "0x1DEEDA8", VA = "0x1DEEDA8", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60162BA")]
    [Address(RVA = "0x1DEF61C", Offset = "0x1DEF61C", VA = "0x1DEF61C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60162BB")]
    [Address(RVA = "0x1DEF330", Offset = "0x1DEF330", VA = "0x1DEF330")]
    private void SetupEffectiveDate()
    {
    }

    [Token(Token = "0x60162BC")]
    [Address(RVA = "0x1DEF638", Offset = "0x1DEF638", VA = "0x1DEF638")]
    public ArmouryItemThumb()
    {
    }
  }
}
