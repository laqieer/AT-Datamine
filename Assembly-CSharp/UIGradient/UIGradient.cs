// Decompiled with JetBrains decompiler
// Type: UIGradient.UIGradient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UIGradient
{
  [Token(Token = "0x2000372")]
  [AddComponentMenu("UI/Effects/Gradient")]
  public class UIGradient : BaseMeshEffect
  {
    [Token(Token = "0x4001438")]
    [FieldOffset(Offset = "0x20")]
    public Color m_color1;
    [Token(Token = "0x4001439")]
    [FieldOffset(Offset = "0x30")]
    public Color m_color2;
    [Token(Token = "0x400143A")]
    [FieldOffset(Offset = "0x40")]
    [Range(-180f, 180f)]
    public float m_angle;
    [Token(Token = "0x400143B")]
    [FieldOffset(Offset = "0x44")]
    public bool m_ignoreRatio;

    [Token(Token = "0x60013CF")]
    [Address(RVA = "0x286E7D0", Offset = "0x286E7D0", VA = "0x286E7D0", Slot = "20")]
    public override void ModifyMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x60013D0")]
    [Address(RVA = "0x286EE2C", Offset = "0x286EE2C", VA = "0x286EE2C")]
    public UIGradient()
    {
    }
  }
}
