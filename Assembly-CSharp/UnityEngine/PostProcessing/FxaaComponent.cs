// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.FxaaComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F5E")]
  public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
  {
    [Token(Token = "0x17005255")]
    public override bool active
    {
      [Token(Token = "0x601991A"), Address(RVA = "0x3434D24", Offset = "0x3434D24", VA = "0x3434D24", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601991B")]
    [Address(RVA = "0x3434D94", Offset = "0x3434D94", VA = "0x3434D94")]
    public void Render(RenderTexture source, RenderTexture destination)
    {
    }

    [Token(Token = "0x601991C")]
    [Address(RVA = "0x3434F94", Offset = "0x3434F94", VA = "0x3434F94")]
    public FxaaComponent()
    {
    }

    [Token(Token = "0x2003F5F")]
    private static class Uniforms
    {
      [Token(Token = "0x401158A")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _QualitySettings;
      [Token(Token = "0x401158B")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _ConsoleSettings;

      [Token(Token = "0x601991D")]
      [Address(RVA = "0x3434FDC", Offset = "0x3434FDC", VA = "0x3434FDC")]
      static Uniforms()
      {
      }
    }
  }
}
