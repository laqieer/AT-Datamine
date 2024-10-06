// Decompiled with JetBrains decompiler
// Type: Battle.Unit.Barrier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022EB")]
  public sealed class Barrier : IBarrier, IDisposable
  {
    [Token(Token = "0x40093A6")]
    private const string MAIN_BARRIER_ROOT_NAME = "root";
    [Token(Token = "0x40093A7")]
    private const string CRACK_OBJECT_NAME = "crack";
    [Token(Token = "0x40093A8")]
    private const string REVIVAL_OBJECT_NAME = "root_create";
    [Token(Token = "0x40093A9")]
    private const string DESTRUCTION_OBJECT_NAME = "root_break";
    [Token(Token = "0x40093AA")]
    private const float MAX_CRACK_VALUE = 1f;
    [Token(Token = "0x40093AB")]
    private const float MIN_CRACK_VALUE = 0.0f;
    [Token(Token = "0x40093AC")]
    private const float CRACK_RATE = 0.5f;
    [Token(Token = "0x40093AD")]
    [FieldOffset(Offset = "0x10")]
    private ParticleSystem mainParticle;
    [Token(Token = "0x40093AE")]
    [FieldOffset(Offset = "0x18")]
    private Transform mainBarrierRoot;
    [Token(Token = "0x40093AF")]
    [FieldOffset(Offset = "0x20")]
    private ParticleSystem crack;
    [Token(Token = "0x40093B0")]
    [FieldOffset(Offset = "0x28")]
    private Transform revival;
    [Token(Token = "0x40093B1")]
    [FieldOffset(Offset = "0x30")]
    private Transform destruction;
    [Token(Token = "0x40093B2")]
    [FieldOffset(Offset = "0x38")]
    private float prevCrackValue;
    [Token(Token = "0x40093B3")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 positionOffset;
    [Token(Token = "0x40093B4")]
    [FieldOffset(Offset = "0x48")]
    private bool isShowing;

    [Token(Token = "0x600D585")]
    [Address(RVA = "0x1D15078", Offset = "0x1D15078", VA = "0x1D15078")]
    public Barrier(GameObject root, Vector3 positionOffset)
    {
    }

    [Token(Token = "0x600D586")]
    [Address(RVA = "0x1D1527C", Offset = "0x1D1527C", VA = "0x1D1527C", Slot = "9")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600D587")]
    [Address(RVA = "0x1D1535C", Offset = "0x1D1535C", VA = "0x1D1535C", Slot = "4")]
    public void Show()
    {
    }

    [Token(Token = "0x600D588")]
    [Address(RVA = "0x1D15430", Offset = "0x1D15430", VA = "0x1D15430", Slot = "5")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D589")]
    [Address(RVA = "0x1D1546C", Offset = "0x1D1546C", VA = "0x1D1546C", Slot = "6")]
    public void UpdateCrack(float hpRate)
    {
    }

    [Token(Token = "0x600D58A")]
    [Address(RVA = "0x1D156B4", Offset = "0x1D156B4", VA = "0x1D156B4")]
    private void ApplyCrackValue(float value)
    {
    }

    [Token(Token = "0x600D58B")]
    [Address(RVA = "0x1D15600", Offset = "0x1D15600", VA = "0x1D15600")]
    private float ToActualRangedValue(float hpRate) => new float();

    [Token(Token = "0x600D58C")]
    [Address(RVA = "0x1D15748", Offset = "0x1D15748", VA = "0x1D15748", Slot = "7")]
    public void UpdatePosition(Vector3 position)
    {
    }

    [Token(Token = "0x600D58D")]
    [Address(RVA = "0x1D15624", Offset = "0x1D15624", VA = "0x1D15624", Slot = "8")]
    public void Revival()
    {
    }
  }
}
