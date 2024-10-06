// Decompiled with JetBrains decompiler
// Type: Alonedite.AlonediteSceneObjectSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Alonedite
{
  [Token(Token = "0x2002869")]
  public class AlonediteSceneObjectSet : MonoBehaviour
  {
    [Token(Token = "0x400AC31")]
    [FieldOffset(Offset = "0x18")]
    public Transform chara_location_1_001;
    [Token(Token = "0x400AC32")]
    [FieldOffset(Offset = "0x20")]
    public Transform chara_location_1_501;
    [Token(Token = "0x400AC33")]
    [FieldOffset(Offset = "0x28")]
    public Transform chara_location_1_502;
    [Token(Token = "0x400AC34")]
    [FieldOffset(Offset = "0x30")]
    public Transform chara_location_2_001;
    [Token(Token = "0x400AC35")]
    [FieldOffset(Offset = "0x38")]
    public Transform chara_location_2_501;
    [Token(Token = "0x400AC36")]
    [FieldOffset(Offset = "0x40")]
    public Transform chara_location_2_502;
    [Token(Token = "0x400AC37")]
    [FieldOffset(Offset = "0x48")]
    public Transform chara_location_3_001;
    [Token(Token = "0x400AC38")]
    [FieldOffset(Offset = "0x50")]
    public Transform chara_location_3_501;
    [Token(Token = "0x400AC39")]
    [FieldOffset(Offset = "0x58")]
    public Transform chara_location_3_502;
    [Token(Token = "0x400AC3A")]
    [FieldOffset(Offset = "0x60")]
    public Transform chara_location_4_001;
    [Token(Token = "0x400AC3B")]
    [FieldOffset(Offset = "0x68")]
    public Transform chara_location_4_501;
    [Token(Token = "0x400AC3C")]
    [FieldOffset(Offset = "0x70")]
    public Transform chara_location_4_502;
    [Token(Token = "0x400AC3D")]
    [FieldOffset(Offset = "0x78")]
    public Transform weaponTransformParent_1;
    [Token(Token = "0x400AC3E")]
    [FieldOffset(Offset = "0x80")]
    public Transform weaponTransformParent_2;
    [Token(Token = "0x400AC3F")]
    [FieldOffset(Offset = "0x88")]
    public Transform weaponTransformParent_3;
    [Token(Token = "0x400AC40")]
    [FieldOffset(Offset = "0x90")]
    public Transform weaponTransformParent_4;
    [Token(Token = "0x400AC41")]
    [FieldOffset(Offset = "0x98")]
    public Animator mainCameraAnimator;
    [Token(Token = "0x400AC42")]
    [FieldOffset(Offset = "0xA0")]
    public BranchSelectionGlareEffect effect1;
    [Token(Token = "0x400AC43")]
    [FieldOffset(Offset = "0xA8")]
    public BranchSelectionGlareEffect effect2;
    [Token(Token = "0x400AC44")]
    [FieldOffset(Offset = "0xB0")]
    public BranchSelectionGlareEffect effect3;
    [Token(Token = "0x400AC45")]
    [FieldOffset(Offset = "0xB8")]
    public BranchSelectionGlareEffect effect4;

    [Token(Token = "0x600FE9B")]
    [Address(RVA = "0x40EFFCC", Offset = "0x40EFFCC", VA = "0x40EFFCC")]
    public Transform GetWeaponTransformParent(int styleId, int numberOfCharacters, bool isPrimary = false)
    {
      return (Transform) null;
    }

    [Token(Token = "0x600FE9C")]
    [Address(RVA = "0x40F00AC", Offset = "0x40F00AC", VA = "0x40F00AC")]
    public Transform GetCharacterTransfromParent(
      int styleId,
      int numberOfCharacters,
      bool isPrimary = false)
    {
      return (Transform) null;
    }

    [Token(Token = "0x600FE9D")]
    [Address(RVA = "0x40F01C0", Offset = "0x40F01C0", VA = "0x40F01C0")]
    public void StopEffects()
    {
    }

    [Token(Token = "0x600FE9E")]
    [Address(RVA = "0x40F0240", Offset = "0x40F0240", VA = "0x40F0240")]
    public BranchSelectionGlareEffect GetEffect(
      int styleId,
      int numberOfCharacters,
      bool isPrimary = false)
    {
      return (BranchSelectionGlareEffect) null;
    }

    [Token(Token = "0x600FE9F")]
    [Address(RVA = "0x40F02D8", Offset = "0x40F02D8", VA = "0x40F02D8")]
    public AlonediteSceneObjectSet()
    {
    }
  }
}
