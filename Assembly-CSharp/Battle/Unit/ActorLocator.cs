// Decompiled with JetBrains decompiler
// Type: Battle.Unit.ActorLocator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022DE")]
  [RequireComponent(typeof (CharacterActor))]
  public sealed class ActorLocator : MonoBehaviour
  {
    [Token(Token = "0x400936B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform mainWeapon;
    [Token(Token = "0x400936C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform subWeapon;
    [Token(Token = "0x400936D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform headEffect;
    [Token(Token = "0x400936E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform bodyEffect;
    [Token(Token = "0x400936F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform bottomEffect;
    [Token(Token = "0x4009370")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform weaponEffect;
    [Token(Token = "0x4009371")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform invisible;
    [Token(Token = "0x4009372")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<string, Transform> locators;

    [Token(Token = "0x17002E03")]
    public Transform MainWeapon
    {
      [Token(Token = "0x600D4C3"), Address(RVA = "0x19E8A20", Offset = "0x19E8A20", VA = "0x19E8A20")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E04")]
    public Transform SubWeapon
    {
      [Token(Token = "0x600D4C4"), Address(RVA = "0x19E8A28", Offset = "0x19E8A28", VA = "0x19E8A28")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E05")]
    public Transform HeadEffect
    {
      [Token(Token = "0x600D4C5"), Address(RVA = "0x19E8A30", Offset = "0x19E8A30", VA = "0x19E8A30")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E06")]
    public Transform BodyEffect
    {
      [Token(Token = "0x600D4C6"), Address(RVA = "0x19E8A38", Offset = "0x19E8A38", VA = "0x19E8A38")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E07")]
    public Transform BottomEffect
    {
      [Token(Token = "0x600D4C7"), Address(RVA = "0x19E8A40", Offset = "0x19E8A40", VA = "0x19E8A40")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E08")]
    public Transform WeaponEffect
    {
      [Token(Token = "0x600D4C8"), Address(RVA = "0x19E8A48", Offset = "0x19E8A48", VA = "0x19E8A48")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E09")]
    public Transform Invisible
    {
      [Token(Token = "0x600D4C9"), Address(RVA = "0x19E8A50", Offset = "0x19E8A50", VA = "0x19E8A50")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600D4CA")]
    [Address(RVA = "0x19E8A58", Offset = "0x19E8A58", VA = "0x19E8A58")]
    public Transform GetLocator(string name) => (Transform) null;

    [Token(Token = "0x600D4CB")]
    [Address(RVA = "0x19E8B0C", Offset = "0x19E8B0C", VA = "0x19E8B0C")]
    public void Remap()
    {
    }

    [Token(Token = "0x600D4CC")]
    [Address(RVA = "0x19E8E0C", Offset = "0x19E8E0C", VA = "0x19E8E0C")]
    public ActorLocator()
    {
    }

    [Token(Token = "0x20022DF")]
    private class LocatorName
    {
      [Token(Token = "0x4009373")]
      public const string MainWeapon = "Wpn_Back";
      [Token(Token = "0x4009374")]
      public const string SubWeapon = "Wpn_Front";
      [Token(Token = "0x4009375")]
      public const string HeadEffect = "Ef_Head";
      [Token(Token = "0x4009376")]
      public const string BodyEffect = "Ef_Hip";
      [Token(Token = "0x4009377")]
      public const string BottomEffect = "root";
      [Token(Token = "0x4009378")]
      public const string WeaponEffect = "Ef_Wep";
      [Token(Token = "0x4009379")]
      public const string Invisible = "Invisible";

      [Token(Token = "0x600D4CD")]
      [Address(RVA = "0x19E8E88", Offset = "0x19E8E88", VA = "0x19E8E88")]
      public LocatorName()
      {
      }
    }
  }
}
