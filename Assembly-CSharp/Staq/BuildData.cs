// Decompiled with JetBrains decompiler
// Type: staq.BuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C40")]
  public class BuildData : ScriptableObject
  {
    [Token(Token = "0x4010B6C")]
    [FieldOffset(Offset = "0x18")]
    public string appVersion;
    [Token(Token = "0x4010B6D")]
    [FieldOffset(Offset = "0x20")]
    public string serverName;
    [Token(Token = "0x4010B6E")]
    [FieldOffset(Offset = "0x28")]
    public string serverHost;

    [Token(Token = "0x6017B11")]
    [Address(RVA = "0x238B74C", Offset = "0x238B74C", VA = "0x238B74C")]
    public BuildData()
    {
    }
  }
}
