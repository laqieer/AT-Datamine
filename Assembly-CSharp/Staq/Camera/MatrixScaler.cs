// Decompiled with JetBrains decompiler
// Type: staq.Camera.MatrixScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D65")]
  public class MatrixScaler : ScalerBase
  {
    [Token(Token = "0x4010DC7")]
    [FieldOffset(Offset = "0x18")]
    private ScalerBase scaler;
    [Token(Token = "0x4010DC8")]
    [FieldOffset(Offset = "0x20")]
    private Matrix2x2 matrix;
    [Token(Token = "0x4010DC9")]
    [FieldOffset(Offset = "0x30")]
    private float w;

    [Token(Token = "0x6018B40")]
    [Address(RVA = "0x2643284", Offset = "0x2643284", VA = "0x2643284")]
    public MatrixScaler(Matrix2x2 inputMatrix, ScalerBase inputScaler, float inputW)
    {
    }

    [Token(Token = "0x6018B41")]
    [Address(RVA = "0x26432F0", Offset = "0x26432F0", VA = "0x26432F0", Slot = "7")]
    public override float GetValue() => new float();

    [Token(Token = "0x6018B42")]
    [Address(RVA = "0x2643370", Offset = "0x2643370", VA = "0x2643370", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018B43")]
    [Address(RVA = "0x26433A4", Offset = "0x26433A4", VA = "0x26433A4", Slot = "5")]
    public override void SetDirty(bool dirty)
    {
    }

    [Token(Token = "0x6018B44")]
    [Address(RVA = "0x26433D0", Offset = "0x26433D0", VA = "0x26433D0", Slot = "9")]
    public override bool EqualsDeclaration(ScalerBase otherBase) => new bool();

    [Token(Token = "0x6018B45")]
    [Address(RVA = "0x26434C0", Offset = "0x26434C0", VA = "0x26434C0", Slot = "6")]
    public override void RegistContainer(GeometryContainer geometryContainer)
    {
    }
  }
}
