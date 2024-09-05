// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.OmitNameUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032C7")]
  public class OmitNameUtility
  {
    [Token(Token = "0x400DAB5")]
    [FieldOffset(Offset = "0x10")]
    private int omitLen;
    [Token(Token = "0x400DAB6")]
    [FieldOffset(Offset = "0x18")]
    private string omitSuffix;

    [Token(Token = "0x6013E78")]
    [Address(RVA = "0x1AEB5F8", Offset = "0x1AEB5F8", VA = "0x1AEB5F8")]
    private OmitNameUtility(int omitLen, string omitSuffix)
    {
    }

    [Token(Token = "0x6013E79")]
    [Address(RVA = "0x1AEB628", Offset = "0x1AEB628", VA = "0x1AEB628")]
    public static OmitNameUtility ItemThumbName() => (OmitNameUtility) null;

    [Token(Token = "0x6013E7A")]
    [Address(RVA = "0x1AEB6A8", Offset = "0x1AEB6A8", VA = "0x1AEB6A8")]
    public static OmitNameUtility MapName() => (OmitNameUtility) null;

    [Token(Token = "0x6013E7B")]
    [Address(RVA = "0x1AEB728", Offset = "0x1AEB728", VA = "0x1AEB728")]
    public static OmitNameUtility AreaQuestScenario() => (OmitNameUtility) null;

    [Token(Token = "0x6013E7C")]
    [Address(RVA = "0x1AEB7A8", Offset = "0x1AEB7A8", VA = "0x1AEB7A8")]
    public string Omit(string name) => (string) null;
  }
}
