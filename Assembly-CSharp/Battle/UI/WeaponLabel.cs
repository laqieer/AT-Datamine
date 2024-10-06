// Decompiled with JetBrains decompiler
// Type: Battle.UI.WeaponLabel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200243B")]
  public sealed class WeaponLabel : MonoBehaviour
  {
    [Token(Token = "0x4009B18")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image iconImage;
    [Token(Token = "0x4009B19")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text weaponName;
    [Token(Token = "0x4009B1A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text durability;
    [Token(Token = "0x4009B1B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text maxDurability;

    [Token(Token = "0x600DDFF")]
    [Address(RVA = "0x1E2CCE0", Offset = "0x1E2CCE0", VA = "0x1E2CCE0")]
    public void Set(IDirector director, UnitParameterData owner, GameObject buttonSwitchWeapon)
    {
    }

    [Token(Token = "0x600DE00")]
    [Address(RVA = "0x1E2CED0", Offset = "0x1E2CED0", VA = "0x1E2CED0")]
    private void Set(
      Sprite iconImage,
      string weaponName,
      int currentDurability,
      int maxDurability)
    {
    }

    [Token(Token = "0x600DE01")]
    [Address(RVA = "0x1E2D040", Offset = "0x1E2D040", VA = "0x1E2D040")]
    public WeaponLabel()
    {
    }
  }
}
