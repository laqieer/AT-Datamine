// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionSoul_tankLevel_upRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C33")]
  [Serializable]
  public class APIExpeditionSoul_tankLevel_upRequest
  {
    [Token(Token = "0x40078C2")]
    [FieldOffset(Offset = "0x10")]
    public int soul_type_id;

    [Token(Token = "0x600A5FB")]
    [Address(RVA = "0x19095B8", Offset = "0x19095B8", VA = "0x19095B8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A5FC")]
    [Address(RVA = "0x1909600", Offset = "0x1909600", VA = "0x1909600")]
    public APIExpeditionSoul_tankLevel_upRequest()
    {
    }
  }
}
