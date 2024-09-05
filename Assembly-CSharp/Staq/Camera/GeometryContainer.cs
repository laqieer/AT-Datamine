// Decompiled with JetBrains decompiler
// Type: staq.Camera.GeometryContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D5F")]
  public class GeometryContainer
  {
    [Token(Token = "0x4010DBD")]
    [FieldOffset(Offset = "0x10")]
    private List<WeakReference<Geometry>> geometries;

    [Token(Token = "0x6018B24")]
    [Address(RVA = "0x264288C", Offset = "0x264288C", VA = "0x264288C")]
    public void Regist(Geometry registGeometry)
    {
    }

    [Token(Token = "0x6018B25")]
    [Address(RVA = "0x2642A44", Offset = "0x2642A44", VA = "0x2642A44")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x6018B26")]
    [Address(RVA = "0x2642C80", Offset = "0x2642C80", VA = "0x2642C80")]
    public void SetDirty(bool dirty)
    {
    }

    [Token(Token = "0x6018B27")]
    [Address(RVA = "0x2642E20", Offset = "0x2642E20", VA = "0x2642E20")]
    public GeometryContainer()
    {
    }
  }
}
