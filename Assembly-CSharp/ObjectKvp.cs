// Decompiled with JetBrains decompiler
// Type: ObjectKvp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000096")]
[Serializable]
public sealed class ObjectKvp : UnityNameValuePair<string>
{
  [Token(Token = "0x4000283")]
  [FieldOffset(Offset = "0x28")]
  public string value;

  [Token(Token = "0x17000031")]
  public override string Value
  {
    [Token(Token = "0x600050B"), Address(RVA = "0x44B09B4", Offset = "0x44B09B4", VA = "0x44B09B4", Slot = "6")] get
    {
      return (string) null;
    }
    [Token(Token = "0x600050C"), Address(RVA = "0x44B09BC", Offset = "0x44B09BC", VA = "0x44B09BC", Slot = "7")] set
    {
    }
  }

  [Token(Token = "0x600050D")]
  [Address(RVA = "0x44B09C4", Offset = "0x44B09C4", VA = "0x44B09C4")]
  public ObjectKvp(string key, string value)
  {
  }
}
