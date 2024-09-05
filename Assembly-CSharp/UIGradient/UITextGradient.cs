// Decompiled with JetBrains decompiler
// Type: UIGradient.UITextGradient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UIGradient
{
  [Token(Token = "0x2000376")]
  [AddComponentMenu("UI/Effects/Text Gradient")]
  public class UITextGradient : BaseMeshEffect
  {
    [Token(Token = "0x4001447")]
    [FieldOffset(Offset = "0x20")]
    public Color m_color1;
    [Token(Token = "0x4001448")]
    [FieldOffset(Offset = "0x30")]
    public Color m_color2;
    [Token(Token = "0x4001449")]
    [FieldOffset(Offset = "0x40")]
    [Range(-180f, 180f)]
    public float m_angle;

    [Token(Token = "0x60013DD")]
    [Address(RVA = "0x286F6FC", Offset = "0x286F6FC", VA = "0x286F6FC", Slot = "20")]
    public override void ModifyMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x60013DE")]
    [Address(RVA = "0x286FC78", Offset = "0x286FC78", VA = "0x286FC78")]
    public UITextGradient()
    {
    }
  }
}
