// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.MaterialFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FB6")]
  public sealed class MaterialFactory : IDisposable
  {
    [Token(Token = "0x4011710")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, Material> m_Materials;

    [Token(Token = "0x60199FD")]
    [Address(RVA = "0x37834F0", Offset = "0x37834F0", VA = "0x37834F0")]
    public MaterialFactory()
    {
    }

    [Token(Token = "0x60199FE")]
    [Address(RVA = "0x3783570", Offset = "0x3783570", VA = "0x3783570")]
    public Material Get(string shaderName) => (Material) null;

    [Token(Token = "0x60199FF")]
    [Address(RVA = "0x3783774", Offset = "0x3783774", VA = "0x3783774", Slot = "4")]
    public void Dispose()
    {
    }
  }
}
