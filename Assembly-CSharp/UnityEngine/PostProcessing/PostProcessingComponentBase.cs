// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponentBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FAD")]
  public abstract class PostProcessingComponentBase
  {
    [Token(Token = "0x40116F2")]
    [FieldOffset(Offset = "0x10")]
    public PostProcessingContext context;

    [Token(Token = "0x60199D1")]
    [Address(RVA = "0x343E59C", Offset = "0x343E59C", VA = "0x343E59C", Slot = "4")]
    public virtual DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x1700528E")]
    public abstract bool active { [Token(Token = "0x60199D2")] get; }

    [Token(Token = "0x60199D3")]
    [Address(RVA = "0x343E5A4", Offset = "0x343E5A4", VA = "0x343E5A4", Slot = "6")]
    public virtual void OnEnable()
    {
    }

    [Token(Token = "0x60199D4")]
    [Address(RVA = "0x343E5A8", Offset = "0x343E5A8", VA = "0x343E5A8", Slot = "7")]
    public virtual void OnDisable()
    {
    }

    [Token(Token = "0x60199D5")]
    public abstract PostProcessingModel GetModel();

    [Token(Token = "0x60199D6")]
    [Address(RVA = "0x343E5AC", Offset = "0x343E5AC", VA = "0x343E5AC")]
    protected PostProcessingComponentBase()
    {
    }
  }
}
