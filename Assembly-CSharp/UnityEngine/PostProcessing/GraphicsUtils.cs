// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GraphicsUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FB5")]
  public static class GraphicsUtils
  {
    [Token(Token = "0x401170E")]
    [FieldOffset(Offset = "0x0")]
    private static Texture2D s_WhiteTexture;
    [Token(Token = "0x401170F")]
    [FieldOffset(Offset = "0x8")]
    private static Mesh s_Quad;

    [Token(Token = "0x17005297")]
    public static bool isLinearColorSpace
    {
      [Token(Token = "0x60199F5"), Address(RVA = "0x3434B98", Offset = "0x3434B98", VA = "0x3434B98")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005298")]
    public static bool supportsDX11
    {
      [Token(Token = "0x60199F6"), Address(RVA = "0x343EA88", Offset = "0x343EA88", VA = "0x343EA88")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005299")]
    public static Texture2D whiteTexture
    {
      [Token(Token = "0x60199F7"), Address(RVA = "0x343DF30", Offset = "0x343DF30", VA = "0x343DF30")] get
      {
        return (Texture2D) null;
      }
    }

    [Token(Token = "0x1700529A")]
    public static Mesh quad
    {
      [Token(Token = "0x60199F8"), Address(RVA = "0x3437BB4", Offset = "0x3437BB4", VA = "0x3437BB4")] get
      {
        return (Mesh) null;
      }
    }

    [Token(Token = "0x60199F9")]
    [Address(RVA = "0x343A4BC", Offset = "0x343A4BC", VA = "0x343A4BC")]
    public static void Blit(Material material, int pass)
    {
    }

    [Token(Token = "0x60199FA")]
    [Address(RVA = "0x343EAB4", Offset = "0x343EAB4", VA = "0x343EAB4")]
    public static void ClearAndBlit(
      Texture source,
      RenderTexture destination,
      Material material,
      int pass,
      bool clearColor = true,
      bool clearDepth = false)
    {
    }

    [Token(Token = "0x60199FB")]
    [Address(RVA = "0x34302A8", Offset = "0x34302A8", VA = "0x34302A8")]
    public static void Destroy(Object obj)
    {
    }

    [Token(Token = "0x60199FC")]
    [Address(RVA = "0x343E460", Offset = "0x343E460", VA = "0x343E460")]
    public static void Dispose()
    {
    }
  }
}
