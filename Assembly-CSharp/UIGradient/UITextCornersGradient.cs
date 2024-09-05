// Decompiled with JetBrains decompiler
// Type: UIGradient.UITextCornersGradient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UIGradient
{
  [Token(Token = "0x2000375")]
  [AddComponentMenu("UI/Effects/Text 4 Corners Gradient")]
  public class UITextCornersGradient : BaseMeshEffect
  {
    [Token(Token = "0x4001443")]
    [FieldOffset(Offset = "0x20")]
    public Color m_topLeftColor;
    [Token(Token = "0x4001444")]
    [FieldOffset(Offset = "0x30")]
    public Color m_topRightColor;
    [Token(Token = "0x4001445")]
    [FieldOffset(Offset = "0x40")]
    public Color m_bottomRightColor;
    [Token(Token = "0x4001446")]
    [FieldOffset(Offset = "0x50")]
    public Color m_bottomLeftColor;

    [Token(Token = "0x60013DB")]
    [Address(RVA = "0x286F204", Offset = "0x286F204", VA = "0x286F204", Slot = "20")]
    public override void ModifyMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x60013DC")]
    [Address(RVA = "0x286F6E8", Offset = "0x286F6E8", VA = "0x286F6E8")]
    public UITextCornersGradient()
    {
    }
  }
}
