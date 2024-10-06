// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordAddDeviceResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019CF")]
  [Serializable]
  public class APIDascIDPasswordAddDeviceResponse
  {
    [Token(Token = "0x4006EBD")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006EBE")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x6009376")]
    [Address(RVA = "0x4D119E8", Offset = "0x4D119E8", VA = "0x4D119E8")]
    public APIDascIDPasswordAddDeviceResponse()
    {
    }
  }
}
