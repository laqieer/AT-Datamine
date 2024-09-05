// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.UserLutComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F6D")]
  public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
  {
    [Token(Token = "0x1700525D")]
    public override bool active
    {
      [Token(Token = "0x6019954"), Address(RVA = "0x343A828", Offset = "0x343A828", VA = "0x343A828", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019955")]
    [Address(RVA = "0x343A934", Offset = "0x343A934", VA = "0x343A934", Slot = "10")]
    public override void Prepare(Material uberMaterial)
    {
    }

    [Token(Token = "0x6019956")]
    [Address(RVA = "0x343AA74", Offset = "0x343AA74", VA = "0x343AA74")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6019957")]
    [Address(RVA = "0x343AB9C", Offset = "0x343AB9C", VA = "0x343AB9C")]
    public UserLutComponent()
    {
    }

    [Token(Token = "0x2003F6E")]
    private static class Uniforms
    {
      [Token(Token = "0x4011600")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _UserLut;
      [Token(Token = "0x4011601")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _UserLut_Params;

      [Token(Token = "0x6019958")]
      [Address(RVA = "0x343ABE4", Offset = "0x343ABE4", VA = "0x343ABE4")]
      static Uniforms()
      {
      }
    }
  }
}
