// Decompiled with JetBrains decompiler
// Type: Battle.UI.EquipmentThumbnailViewController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Tween;
using Il2CppDummyDll;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002347")]
  public class EquipmentThumbnailViewController : MonoBehaviour
  {
    [Token(Token = "0x40095C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x40095C4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40095C5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x40095C6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image typeIcon;
    [Token(Token = "0x40095C7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image elementIcon;
    [Token(Token = "0x40095C8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ActiveObjectContainers rarityStars;
    [Token(Token = "0x40095C9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ActiveObjectContainers rarity;

    [Token(Token = "0x600D799")]
    [Address(RVA = "0x1B88438", Offset = "0x1B88438", VA = "0x1B88438")]
    public void SetWeapon(WeaponParameterData weaponParameterData)
    {
    }

    [Token(Token = "0x600D79A")]
    [Address(RVA = "0x1B88830", Offset = "0x1B88830", VA = "0x1B88830")]
    public void SetAccessory(AccessoryData accessoryData)
    {
    }

    [Token(Token = "0x600D79B")]
    [Address(RVA = "0x1B88A04", Offset = "0x1B88A04", VA = "0x1B88A04")]
    public EquipmentThumbnailViewController()
    {
    }
  }
}
