// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Instance.MovableSingleMobInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Instance
{
  [Token(Token = "0x2002838")]
  public class MovableSingleMobInstance : MovableMobInstanceBase
  {
    [Token(Token = "0x400AB8A")]
    [FieldOffset(Offset = "0x60")]
    protected GameObject modelObject;

    [Token(Token = "0x600FD3B")]
    [Address(RVA = "0x442DCE0", Offset = "0x442DCE0", VA = "0x442DCE0")]
    public void Initialize(
      MovableSingleMobInstanceData instanceData,
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor,
      Transform player)
    {
    }

    [Token(Token = "0x600FD3C")]
    [Address(RVA = "0x442DFE4", Offset = "0x442DFE4", VA = "0x442DFE4", Slot = "6")]
    public override MovableMobType GetMobType() => new MovableMobType();

    [Token(Token = "0x600FD3D")]
    [Address(RVA = "0x442DFEC", Offset = "0x442DFEC", VA = "0x442DFEC")]
    public static MovableSingleMobInstance Create(
      MovableSingleMobInstanceData instanceData,
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor,
      Transform player)
    {
      return (MovableSingleMobInstance) null;
    }

    [Token(Token = "0x600FD3E")]
    [Address(RVA = "0x442E0DC", Offset = "0x442E0DC", VA = "0x442E0DC")]
    public MovableSingleMobInstance()
    {
    }
  }
}
