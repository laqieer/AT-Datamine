// Decompiled with JetBrains decompiler
// Type: UIGradient.UICornersGradient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UIGradient
{
  [Token(Token = "0x2000371")]
  [AddComponentMenu("UI/Effects/4 Corners Gradient")]
  public class UICornersGradient : BaseMeshEffect
  {
    [Token(Token = "0x4001434")]
    [FieldOffset(Offset = "0x20")]
    public Color m_topLeftColor;
    [Token(Token = "0x4001435")]
    [FieldOffset(Offset = "0x30")]
    public Color m_topRightColor;
    [Token(Token = "0x4001436")]
    [FieldOffset(Offset = "0x40")]
    public Color m_bottomRightColor;
    [Token(Token = "0x4001437")]
    [FieldOffset(Offset = "0x50")]
    public Color m_bottomLeftColor;

    [Token(Token = "0x60013CD")]
    [Address(RVA = "0x286E08C", Offset = "0x286E08C", VA = "0x286E08C", Slot = "20")]
    public override void ModifyMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x60013CE")]
    [Address(RVA = "0x286E7BC", Offset = "0x286E7BC", VA = "0x286E7BC")]
    public UICornersGradient()
    {
    }
  }
}
