// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Instance.MovablePairMobInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Instance
{
  [Token(Token = "0x2002837")]
  public class MovablePairMobInstance : MovableMobInstanceBase
  {
    [Token(Token = "0x400AB89")]
    [FieldOffset(Offset = "0x60")]
    private readonly List<GameObject> mobs;

    [Token(Token = "0x600FD36")]
    [Address(RVA = "0x442D5F0", Offset = "0x442D5F0", VA = "0x442D5F0")]
    public void Initialize(
      MovablePairMobInstanceData data,
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor,
      Transform player)
    {
    }

    [Token(Token = "0x600FD37")]
    [Address(RVA = "0x442D93C", Offset = "0x442D93C", VA = "0x442D93C")]
    private GameObject CreateMob(MovableSingleMobInstanceData param, Vector3 offset)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600FD38")]
    [Address(RVA = "0x442DB70", Offset = "0x442DB70", VA = "0x442DB70", Slot = "6")]
    public override MovableMobType GetMobType() => new MovableMobType();

    [Token(Token = "0x600FD39")]
    [Address(RVA = "0x442DB78", Offset = "0x442DB78", VA = "0x442DB78")]
    public static MovablePairMobInstance Create(
      MovablePairMobInstanceData data,
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor,
      Transform player)
    {
      return (MovablePairMobInstance) null;
    }

    [Token(Token = "0x600FD3A")]
    [Address(RVA = "0x442DC68", Offset = "0x442DC68", VA = "0x442DC68")]
    public MovablePairMobInstance()
    {
    }
  }
}
