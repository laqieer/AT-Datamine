// Decompiled with JetBrains decompiler
// Type: Network.APIDasConnectListResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019E5")]
  [Serializable]
  public class APIDasConnectListResponse
  {
    [Token(Token = "0x4006EFF")]
    [FieldOffset(Offset = "0x10")]
    public APIDasConnectListInfo[] connects;

    [Token(Token = "0x60093DC")]
    [Address(RVA = "0x4D12EEC", Offset = "0x4D12EEC", VA = "0x4D12EEC")]
    public APIDasConnectListResponse()
    {
    }
  }
}
