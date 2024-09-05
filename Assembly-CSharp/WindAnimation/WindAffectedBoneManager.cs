// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindAffectedBoneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F0F")]
  public class WindAffectedBoneManager : IDisposable
  {
    [Token(Token = "0x4011462")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, WindAffectedBoneAnimationStack> windBoneModelList;

    [Token(Token = "0x60197A1")]
    [Address(RVA = "0x37421B0", Offset = "0x37421B0", VA = "0x37421B0")]
    public bool AddWindBoneModel(string name, GameObject character) => new bool();

    [Token(Token = "0x60197A2")]
    [Address(RVA = "0x3742324", Offset = "0x3742324", VA = "0x3742324")]
    private void RemoveUnreferencedWindBone()
    {
    }

    [Token(Token = "0x60197A3")]
    [Address(RVA = "0x3742580", Offset = "0x3742580", VA = "0x3742580", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60197A4")]
    [Address(RVA = "0x3742714", Offset = "0x3742714", VA = "0x3742714")]
    public void Update()
    {
    }

    [Token(Token = "0x60197A5")]
    [Address(RVA = "0x3742990", Offset = "0x3742990", VA = "0x3742990")]
    public void AddWindParameter(ref WindCommonParameter parameter)
    {
    }

    [Token(Token = "0x60197A6")]
    [Address(RVA = "0x3742AF0", Offset = "0x3742AF0", VA = "0x3742AF0")]
    public void AddWindParameter(string name, ref WindCommonParameter parameter)
    {
    }

    [Token(Token = "0x60197A7")]
    [Address(RVA = "0x3742718", Offset = "0x3742718", VA = "0x3742718")]
    private void UpdateWindParameter()
    {
    }

    [Token(Token = "0x60197A8")]
    [Address(RVA = "0x3742C48", Offset = "0x3742C48", VA = "0x3742C48")]
    public WindAffectedBoneManager()
    {
    }
  }
}
