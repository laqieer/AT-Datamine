// Decompiled with JetBrains decompiler
// Type: GameCore.URLScheme.URLSchemeParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace GameCore.URLScheme
{
  [Token(Token = "0x2000BD7")]
  public class URLSchemeParameterModel
  {
    [Token(Token = "0x40035DA")]
    [FieldOffset(Offset = "0x10")]
    public List<DeepLinkData> Links;
    [Token(Token = "0x40035DB")]
    [FieldOffset(Offset = "0x18")]
    public Action<DeepLinkData> OnLinkUsed;

    [Token(Token = "0x60043B4")]
    [Address(RVA = "0x3642DBC", Offset = "0x3642DBC", VA = "0x3642DBC")]
    public static URLSchemeParameterModel CreateForSerialCode() => (URLSchemeParameterModel) null;

    [Token(Token = "0x60043B5")]
    [Address(RVA = "0x3642F18", Offset = "0x3642F18", VA = "0x3642F18")]
    private static List<DeepLinkData> GetUris() => (List<DeepLinkData>) null;

    [Token(Token = "0x60043B6")]
    [Address(RVA = "0x36430C4", Offset = "0x36430C4", VA = "0x36430C4")]
    public URLSchemeParameterModel(DeepLinkData[] uris)
    {
    }

    [Token(Token = "0x60043B7")]
    [Address(RVA = "0x3643410", Offset = "0x3643410", VA = "0x3643410")]
    private (int, string) GetSerialCodeParam(DeepLinkData deepLinkData) => ();

    [Token(Token = "0x60043B8")]
    [Address(RVA = "0x36434E4", Offset = "0x36434E4", VA = "0x36434E4")]
    public IEnumerator RequestSerialRegister(
      DeepLinkData deepLinkData,
      Action<APISerialRegisterResponse> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60043B9")]
    [Address(RVA = "0x3643588", Offset = "0x3643588", VA = "0x3643588")]
    public void Used(DeepLinkData deepLinkData)
    {
    }
  }
}
