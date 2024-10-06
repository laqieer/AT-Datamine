// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FB1")]
  public class PostProcessingContext
  {
    [Token(Token = "0x40116F4")]
    [FieldOffset(Offset = "0x10")]
    public PostProcessingProfile profile;
    [Token(Token = "0x40116F5")]
    [FieldOffset(Offset = "0x18")]
    public Camera camera;
    [Token(Token = "0x40116F6")]
    [FieldOffset(Offset = "0x20")]
    public MaterialFactory materialFactory;
    [Token(Token = "0x40116F7")]
    [FieldOffset(Offset = "0x28")]
    public RenderTextureFactory renderTextureFactory;

    [Token(Token = "0x17005290")]
    public bool interrupted
    {
      [Token(Token = "0x60199E2"), Address(RVA = "0x343E5B4", Offset = "0x343E5B4", VA = "0x343E5B4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60199E3"), Address(RVA = "0x343E5BC", Offset = "0x343E5BC", VA = "0x343E5BC")] private set
      {
      }
    }

    [Token(Token = "0x60199E4")]
    [Address(RVA = "0x342FB38", Offset = "0x342FB38", VA = "0x342FB38")]
    public void Interrupt()
    {
    }

    [Token(Token = "0x60199E5")]
    [Address(RVA = "0x343D1F0", Offset = "0x343D1F0", VA = "0x343D1F0")]
    public PostProcessingContext Reset() => (PostProcessingContext) null;

    [Token(Token = "0x17005291")]
    public bool isGBufferAvailable
    {
      [Token(Token = "0x60199E6"), Address(RVA = "0x342F388", Offset = "0x342F388", VA = "0x342F388")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005292")]
    public bool isHdr
    {
      [Token(Token = "0x60199E7"), Address(RVA = "0x3432F3C", Offset = "0x3432F3C", VA = "0x3432F3C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005293")]
    public int width
    {
      [Token(Token = "0x60199E8"), Address(RVA = "0x342EE18", Offset = "0x342EE18", VA = "0x342EE18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17005294")]
    public int height
    {
      [Token(Token = "0x60199E9"), Address(RVA = "0x342EE34", Offset = "0x342EE34", VA = "0x342EE34")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17005295")]
    public Rect viewport
    {
      [Token(Token = "0x60199EA"), Address(RVA = "0x3432030", Offset = "0x3432030", VA = "0x3432030")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x60199EB")]
    [Address(RVA = "0x343CCA8", Offset = "0x343CCA8", VA = "0x343CCA8")]
    public PostProcessingContext()
    {
    }
  }
}
