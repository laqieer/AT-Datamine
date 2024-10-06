// Decompiled with JetBrains decompiler
// Type: WeaponMoverCorrector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001B4")]
public class WeaponMoverCorrector : MonoBehaviour
{
  [Token(Token = "0x4000A8B")]
  [FieldOffset(Offset = "0x18")]
  public float weaponCorrectionWeight;
  [Token(Token = "0x4000A8C")]
  [FieldOffset(Offset = "0x1C")]
  public float cameraCorrectionWeight;
  [Token(Token = "0x4000A8D")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 correctedLocalPosition;
  [Token(Token = "0x4000A8E")]
  [FieldOffset(Offset = "0x30")]
  private GameObject skillVCRoot;
  [Token(Token = "0x4000A8F")]
  private const string NODE_NAME_J_ROOT = "J_Root";
  [Token(Token = "0x4000A90")]
  private const string NODE_NAME_WEAPON_MOVER_L = "J_Weapon_Mover_L";
  [Token(Token = "0x4000A91")]
  private const string NODE_NAME_WEAPON_MOVER_R = "J_Weapon_Mover_R";

  [Token(Token = "0x6000B4A")]
  [Address(RVA = "0x4BC82B0", Offset = "0x4BC82B0", VA = "0x4BC82B0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000B4B")]
  [Address(RVA = "0x4BC83F0", Offset = "0x4BC83F0", VA = "0x4BC83F0")]
  public static WeaponMoverCorrector CreateWeaponMoverCorrector(
    GameObject characterModelRoot,
    GameObject skillVCRoot)
  {
    return (WeaponMoverCorrector) null;
  }

  [Token(Token = "0x6000B4C")]
  [Address(RVA = "0x4BC86AC", Offset = "0x4BC86AC", VA = "0x4BC86AC")]
  public void SetCorrectionValue(Vector3 position)
  {
  }

  [Token(Token = "0x6000B4D")]
  [Address(RVA = "0x4BC86B8", Offset = "0x4BC86B8", VA = "0x4BC86B8")]
  public WeaponMoverCorrector()
  {
  }
}
