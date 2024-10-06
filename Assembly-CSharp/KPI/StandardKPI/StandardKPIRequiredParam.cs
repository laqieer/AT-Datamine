// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.StandardKPIRequiredParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A72")]
  [Serializable]
  public class StandardKPIRequiredParam
  {
    [Token(Token = "0x4003064")]
    [FieldOffset(Offset = "0x10")]
    public string id;
    [Token(Token = "0x4003065")]
    [FieldOffset(Offset = "0x18")]
    public string type;
    [Token(Token = "0x4003066")]
    [FieldOffset(Offset = "0x20")]
    public int occurred_at;
    [Token(Token = "0x4003067")]
    [FieldOffset(Offset = "0x28")]
    public string version;

    [Token(Token = "0x6003B48")]
    [Address(RVA = "0x331C814", Offset = "0x331C814", VA = "0x331C814")]
    public StandardKPIRequiredParam()
    {
    }
  }
}
