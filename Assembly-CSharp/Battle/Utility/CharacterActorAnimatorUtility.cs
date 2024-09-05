// Decompiled with JetBrains decompiler
// Type: Battle.Utility.CharacterActorAnimatorUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022C6")]
  public sealed class CharacterActorAnimatorUtility
  {
    [Token(Token = "0x4009323")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<int, string> StateLabels;
    [Token(Token = "0x4009324")]
    [FieldOffset(Offset = "0x8")]
    private static readonly Dictionary<int, string> DirLabels;
    [Token(Token = "0x4009325")]
    [FieldOffset(Offset = "0x10")]
    private static readonly Dictionary<(int type, int dir), string> DefaultStateMotionNameMap;

    [Token(Token = "0x600D411")]
    [Address(RVA = "0x19DD1C4", Offset = "0x19DD1C4", VA = "0x19DD1C4")]
    public static string GetState(
      Animator animator,
      Actor.AnimationType type,
      Actor.Direction dir,
      Actor.Direction defaultDirection)
    {
      return (string) null;
    }

    [Token(Token = "0x600D412")]
    [Address(RVA = "0x19DD440", Offset = "0x19DD440", VA = "0x19DD440")]
    public static void UpdateOverride(
      AnimatorOverrideController overrider,
      IDotWeaponAssetData assetData)
    {
    }

    [Token(Token = "0x600D413")]
    [Address(RVA = "0x19DD83C", Offset = "0x19DD83C", VA = "0x19DD83C")]
    private static void UpdateOverrideTo(
      AnimatorOverrideController overrider,
      Actor.AnimationType anim,
      Actor.Direction dir,
      AnimationClip clip)
    {
    }

    [Token(Token = "0x600D414")]
    [Address(RVA = "0x19DDA40", Offset = "0x19DDA40", VA = "0x19DDA40")]
    public CharacterActorAnimatorUtility()
    {
    }

    [Token(Token = "0x600D415")]
    [Address(RVA = "0x19DDA48", Offset = "0x19DDA48", VA = "0x19DDA48")]
    static CharacterActorAnimatorUtility()
    {
    }
  }
}
