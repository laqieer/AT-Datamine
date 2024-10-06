// Decompiled with JetBrains decompiler
// Type: staq.SaveData.URLSchemeDataExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D52")]
  public static class URLSchemeDataExtension
  {
    [Token(Token = "0x6018AE3")]
    [Address(RVA = "0x2640A28", Offset = "0x2640A28", VA = "0x2640A28")]
    public static Offset<URLSchemeData> ToOffset(
      this URLSchemeParameterSaveData.URLSchemeParameterData data,
      FlatBufferBuilder fbb)
    {
      return new Offset<URLSchemeData>();
    }

    [Token(Token = "0x6018AE4")]
    [Address(RVA = "0x2640C8C", Offset = "0x2640C8C", VA = "0x2640C8C")]
    public static Offset<staq.SaveSchema.URLSchemeParameterDetail> ToOffset(
      this URLSchemeParameterSaveData.URLSchemeParameterDetail data,
      FlatBufferBuilder fbb)
    {
      return new Offset<staq.SaveSchema.URLSchemeParameterDetail>();
    }

    [Token(Token = "0x6018AE5")]
    [Address(RVA = "0x2640CCC", Offset = "0x2640CCC", VA = "0x2640CCC")]
    public static URLSchemeParameterSaveData.URLSchemeParameterData ToURLSchemeParameterData(
      this URLSchemeData bufferObject)
    {
      return (URLSchemeParameterSaveData.URLSchemeParameterData) null;
    }

    [Token(Token = "0x6018AE6")]
    [Address(RVA = "0x2640E98", Offset = "0x2640E98", VA = "0x2640E98")]
    public static URLSchemeParameterSaveData.URLSchemeParameterDetail ToURLSchemeParameterData(
      this staq.SaveSchema.URLSchemeParameterDetail bufferObject)
    {
      return (URLSchemeParameterSaveData.URLSchemeParameterDetail) null;
    }
  }
}
