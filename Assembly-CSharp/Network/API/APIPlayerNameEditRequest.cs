// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerNameEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DA3")]
  [Serializable]
  public class APIPlayerNameEditRequest
  {
    [Token(Token = "0x4007E78")]
    [FieldOffset(Offset = "0x10")]
    public string name;

    [Token(Token = "0x600AEF1")]
    [Address(RVA = "0x1A4EFE8", Offset = "0x1A4EFE8", VA = "0x1A4EFE8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AEF2")]
    [Address(RVA = "0x1A4F030", Offset = "0x1A4F030", VA = "0x1A4F030")]
    public APIPlayerNameEditRequest()
    {
    }
  }
}
