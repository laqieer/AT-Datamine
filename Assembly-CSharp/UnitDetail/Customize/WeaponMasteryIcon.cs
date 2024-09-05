// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.WeaponMasteryIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize
{
  [Token(Token = "0x20004EB")]
  public class WeaponMasteryIcon : MonoBehaviour
  {
    [Token(Token = "0x40019CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x40019CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image weaponIcon;
    [Token(Token = "0x40019CF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mastery;

    [Token(Token = "0x6001C19")]
    [Address(RVA = "0x2C329B8", Offset = "0x2C329B8", VA = "0x2C329B8")]
    public void UpdateIcon(string mastery)
    {
    }

    [Token(Token = "0x6001C1A")]
    [Address(RVA = "0x2C32C50", Offset = "0x2C32C50", VA = "0x2C32C50")]
    public void UpdateIcon(Sprite iconSprite, string mastery)
    {
    }

    [Token(Token = "0x6001C1B")]
    [Address(RVA = "0x2C329DC", Offset = "0x2C329DC", VA = "0x2C329DC")]
    public void Show()
    {
    }

    [Token(Token = "0x6001C1C")]
    [Address(RVA = "0x2C32C98", Offset = "0x2C32C98", VA = "0x2C32C98")]
    public void Hide()
    {
    }

    [Token(Token = "0x6001C1D")]
    [Address(RVA = "0x2C32CB8", Offset = "0x2C32CB8", VA = "0x2C32CB8")]
    public WeaponMasteryIcon()
    {
    }

    [Token(Token = "0x20004EC")]
    public enum MasteryRank
    {
      [Token(Token = "0x40019D1")] E = 1,
      [Token(Token = "0x40019D2")] D = 2,
      [Token(Token = "0x40019D3")] C = 3,
      [Token(Token = "0x40019D4")] B = 4,
      [Token(Token = "0x40019D5")] A = 5,
      [Token(Token = "0x40019D6")] S = 6,
    }
  }
}
