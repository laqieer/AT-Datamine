// Decompiled with JetBrains decompiler
// Type: GameCore.Graphics.LineGraphic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Graphics
{
  [Token(Token = "0x200145B")]
  public class LineGraphic : MaskableGraphic
  {
    [Token(Token = "0x4005DD2")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private float width;
    [Token(Token = "0x4005DD3")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Vector2[] positions;

    [Token(Token = "0x60072C8")]
    [Address(RVA = "0x4051E34", Offset = "0x4051E34", VA = "0x4051E34", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x60072C9")]
    [Address(RVA = "0x40521FC", Offset = "0x40521FC", VA = "0x40521FC")]
    private Vector2 ExpansionToLeft(Vector2 position, Vector2 verticalVector) => new Vector2();

    [Token(Token = "0x60072CA")]
    [Address(RVA = "0x40525D4", Offset = "0x40525D4", VA = "0x40525D4")]
    private Vector2 ExpansionToRight(Vector2 position, Vector2 verticalVector) => new Vector2();

    [Token(Token = "0x60072CB")]
    [Address(RVA = "0x4052220", Offset = "0x4052220", VA = "0x4052220")]
    private UIVertex SimpleVert(Vector2 position) => new UIVertex();

    [Token(Token = "0x60072CC")]
    [Address(RVA = "0x40525F8", Offset = "0x40525F8", VA = "0x40525F8")]
    public void SetPositions(Vector2[] positions)
    {
    }

    [Token(Token = "0x60072CD")]
    [Address(RVA = "0x4052104", Offset = "0x4052104", VA = "0x4052104")]
    private Vector2 CalculateVerticalVector(Vector2 vec) => new Vector2();

    [Token(Token = "0x60072CE")]
    [Address(RVA = "0x40526E0", Offset = "0x40526E0", VA = "0x40526E0")]
    public LineGraphic()
    {
    }
  }
}
