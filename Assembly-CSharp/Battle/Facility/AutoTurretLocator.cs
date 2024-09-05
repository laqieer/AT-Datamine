// Decompiled with JetBrains decompiler
// Type: Battle.Facility.AutoTurretLocator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Facility
{
  [Token(Token = "0x2002541")]
  public sealed class AutoTurretLocator : MonoBehaviour
  {
    [Token(Token = "0x400A02B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public Transform main;
    [Token(Token = "0x400A02C")]
    [FieldOffset(Offset = "0x20")]
    public Transform battery;
    [Token(Token = "0x400A02D")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 originLocalEulerAngles;

    [Token(Token = "0x600E61B")]
    [Address(RVA = "0x486C728", Offset = "0x486C728", VA = "0x486C728")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E61C")]
    [Address(RVA = "0x486C76C", Offset = "0x486C76C", VA = "0x486C76C")]
    public void Remap()
    {
    }

    [Token(Token = "0x600E61D")]
    [Address(RVA = "0x486C7DC", Offset = "0x486C7DC", VA = "0x486C7DC")]
    public AutoTurretLocator()
    {
    }

    [Token(Token = "0x2002542")]
    private class LocatorName
    {
      [Token(Token = "0x400A02E")]
      public const string MAIN = "Ef_Wep";

      [Token(Token = "0x600E61E")]
      [Address(RVA = "0x486C7E4", Offset = "0x486C7E4", VA = "0x486C7E4")]
      public LocatorName()
      {
      }
    }
  }
}
