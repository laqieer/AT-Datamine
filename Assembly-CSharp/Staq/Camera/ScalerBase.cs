// Decompiled with JetBrains decompiler
// Type: staq.Camera.ScalerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D62")]
  public class ScalerBase : Geometry
  {
    [Token(Token = "0x4010DC1")]
    [FieldOffset(Offset = "0x10")]
    protected float scalerValue;
    [Token(Token = "0x4010DC2")]
    [FieldOffset(Offset = "0x14")]
    private bool valueDirty;

    [Token(Token = "0x6018B2C")]
    [Address(RVA = "0x2642F68", Offset = "0x2642F68", VA = "0x2642F68")]
    public ScalerBase()
    {
    }

    [Token(Token = "0x6018B2D")]
    [Address(RVA = "0x2642F8C", Offset = "0x2642F8C", VA = "0x2642F8C", Slot = "7")]
    public virtual float GetValue() => new float();

    [Token(Token = "0x6018B2E")]
    [Address(RVA = "0x2642F94", Offset = "0x2642F94", VA = "0x2642F94")]
    public void SetValue(float value)
    {
    }

    [Token(Token = "0x6018B2F")]
    [Address(RVA = "0x2642FA0", Offset = "0x2642FA0", VA = "0x2642FA0", Slot = "8")]
    public virtual bool GetDirty() => new bool();

    [Token(Token = "0x6018B30")]
    [Address(RVA = "0x2642FA8", Offset = "0x2642FA8", VA = "0x2642FA8", Slot = "5")]
    public override void SetDirty(bool dirty)
    {
    }

    [Token(Token = "0x6018B31")]
    [Address(RVA = "0x2642FB4", Offset = "0x2642FB4", VA = "0x2642FB4", Slot = "9")]
    public virtual bool EqualsDeclaration(ScalerBase otherBase) => new bool();

    [Token(Token = "0x6018B32")]
    [Address(RVA = "0x2642FBC", Offset = "0x2642FBC", VA = "0x2642FBC", Slot = "10")]
    public virtual ScalerBase GetDestination() => (ScalerBase) null;

    [Token(Token = "0x6018B33")]
    [Address(RVA = "0x2642FC0", Offset = "0x2642FC0", VA = "0x2642FC0", Slot = "11")]
    public virtual bool GetWaitIdle() => new bool();
  }
}
