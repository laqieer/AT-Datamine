// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerTitleEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DBB")]
  [Serializable]
  public class APIPlayerTitleEditRequest
  {
    [Token(Token = "0x4007F07")]
    [FieldOffset(Offset = "0x10")]
    public int pre_title_id;
    [Token(Token = "0x4007F08")]
    [FieldOffset(Offset = "0x14")]
    public int post_title_id;
    [Token(Token = "0x4007F09")]
    [FieldOffset(Offset = "0x18")]
    public int title_frame_id;

    [Token(Token = "0x600AFBB")]
    [Address(RVA = "0x1A511D0", Offset = "0x1A511D0", VA = "0x1A511D0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AFBC")]
    [Address(RVA = "0x1A51218", Offset = "0x1A51218", VA = "0x1A51218")]
    public APIPlayerTitleEditRequest()
    {
    }
  }
}
