// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindAffectedBone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F0A")]
  public class WindAffectedBone : IDisposable
  {
    [Token(Token = "0x401144F")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, WindAffectedBone.Parameter> dynamicBones;
    [Token(Token = "0x4011450")]
    [FieldOffset(Offset = "0x18")]
    private bool enabled;
    [Token(Token = "0x4011451")]
    [FieldOffset(Offset = "0x20")]
    private string updateAnimationName;
    [Token(Token = "0x4011452")]
    [FieldOffset(Offset = "0x28")]
    private string modelName;
    [Token(Token = "0x4011453")]
    [FieldOffset(Offset = "0x30")]
    private WindCommonParameter parameter;
    [Token(Token = "0x4011454")]
    [FieldOffset(Offset = "0x38")]
    private float ellipseTime;
    [Token(Token = "0x4011455")]
    [FieldOffset(Offset = "0x3C")]
    private int interpolationCount;
    [Token(Token = "0x4011456")]
    [FieldOffset(Offset = "0x40")]
    private Vector3 prevGravity;
    [Token(Token = "0x4011457")]
    [FieldOffset(Offset = "0x4C")]
    private Vector3 interGravity;
    [Token(Token = "0x4011458")]
    [FieldOffset(Offset = "0x58")]
    private Vector3 prevForce;
    [Token(Token = "0x4011459")]
    [FieldOffset(Offset = "0x64")]
    private int interpolationFrame;

    [Token(Token = "0x1700520E")]
    public bool Enabled
    {
      [Token(Token = "0x6019781"), Address(RVA = "0x3740920", Offset = "0x3740920", VA = "0x3740920")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019782"), Address(RVA = "0x3740928", Offset = "0x3740928", VA = "0x3740928")] set
      {
      }
    }

    [Token(Token = "0x1700520F")]
    public int InterpolationFrame
    {
      [Token(Token = "0x6019783"), Address(RVA = "0x3740AAC", Offset = "0x3740AAC", VA = "0x3740AAC")] get
      {
        return new int();
      }
      [Token(Token = "0x6019784"), Address(RVA = "0x3740AB4", Offset = "0x3740AB4", VA = "0x3740AB4")] set
      {
      }
    }

    [Token(Token = "0x6019785")]
    [Address(RVA = "0x3740ABC", Offset = "0x3740ABC", VA = "0x3740ABC")]
    public WindAffectedBone(string name, GameObject model)
    {
    }

    [Token(Token = "0x6019786")]
    [Address(RVA = "0x3740D58", Offset = "0x3740D58", VA = "0x3740D58")]
    public bool HasAnyMissingReference() => new bool();

    [Token(Token = "0x6019787")]
    [Address(RVA = "0x3740E54", Offset = "0x3740E54", VA = "0x3740E54", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6019788")]
    [Address(RVA = "0x3740EA4", Offset = "0x3740EA4", VA = "0x3740EA4")]
    public void Update(ref WindCommonParameter updateParam)
    {
    }

    [Token(Token = "0x6019789")]
    [Address(RVA = "0x3741194", Offset = "0x3741194", VA = "0x3741194")]
    private Vector3 CalcInterpolationParameter(int interFrame, Vector3 nowParam, Vector3 prevParam)
    {
      return new Vector3();
    }

    [Token(Token = "0x601978A")]
    [Address(RVA = "0x3740C64", Offset = "0x3740C64", VA = "0x3740C64")]
    private void TraverseHierarchy(Transform transform)
    {
    }

    [Token(Token = "0x601978B")]
    [Address(RVA = "0x374189C", Offset = "0x374189C", VA = "0x374189C")]
    private void AddDynamicBone(Transform transform, DynamicBone dynamicBone)
    {
    }

    [Token(Token = "0x601978C")]
    [Address(RVA = "0x37413A8", Offset = "0x37413A8", VA = "0x37413A8")]
    private void ApplyForce(Vector3 force)
    {
    }

    [Token(Token = "0x601978D")]
    [Address(RVA = "0x37411F8", Offset = "0x37411F8", VA = "0x37411F8")]
    private void ApplyForceAndGravity(Vector3 force, Vector3 gravity)
    {
    }

    [Token(Token = "0x601978E")]
    [Address(RVA = "0x3741130", Offset = "0x3741130", VA = "0x3741130")]
    private Vector3 CalcEnvironmentalWind(
      float power,
      Vector3 direction,
      float fluctuationPower,
      float fluctuationFrequency)
    {
      return new Vector3();
    }

    [Token(Token = "0x601978F")]
    [Address(RVA = "0x3741A5C", Offset = "0x3741A5C", VA = "0x3741A5C")]
    private Vector3 CalcFluctuation(float fluctuationPower, float fluctuationFrequency)
    {
      return new Vector3();
    }

    [Token(Token = "0x6019790")]
    [Address(RVA = "0x374152C", Offset = "0x374152C", VA = "0x374152C")]
    private void ApplyCircularSpreadWind()
    {
    }

    [Token(Token = "0x6019791")]
    [Address(RVA = "0x3741C84", Offset = "0x3741C84", VA = "0x3741C84")]
    private static void FullName(StringBuilder sb, Transform obj)
    {
    }

    [Token(Token = "0x6019792")]
    [Address(RVA = "0x37419BC", Offset = "0x37419BC", VA = "0x37419BC")]
    private static string FullName(Transform transform) => (string) null;

    [Token(Token = "0x2003F0B")]
    public class Parameter
    {
      [Token(Token = "0x401145A")]
      [FieldOffset(Offset = "0x10")]
      public Transform transform;
      [Token(Token = "0x401145B")]
      [FieldOffset(Offset = "0x18")]
      public DynamicBone dynamicBone;

      [Token(Token = "0x6019793")]
      [Address(RVA = "0x3741A30", Offset = "0x3741A30", VA = "0x3741A30")]
      public Parameter(Transform transform, DynamicBone dynamicBone)
      {
      }
    }
  }
}
