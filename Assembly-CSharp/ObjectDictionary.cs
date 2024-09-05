// Decompiled with JetBrains decompiler
// Type: ObjectDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000097")]
[Serializable]
public class ObjectDictionary : UnityDictionary<string>
{
  [Token(Token = "0x4000284")]
  [FieldOffset(Offset = "0x10")]
  public List<ObjectKvp> values;

  [Token(Token = "0x17000032")]
  protected override List<UnityKeyValuePair<string, string>> KeyValuePairs
  {
    [Token(Token = "0x600050E"), Address(RVA = "0x44B0A24", Offset = "0x44B0A24", VA = "0x44B0A24", Slot = "21")] get
    {
      return (List<UnityKeyValuePair<string, string>>) null;
    }
    [Token(Token = "0x600050F"), Address(RVA = "0x44B0D10", Offset = "0x44B0D10", VA = "0x44B0D10", Slot = "22")] set
    {
    }
  }

  [Token(Token = "0x6000510")]
  [Address(RVA = "0x44B0F10", Offset = "0x44B0F10", VA = "0x44B0F10")]
  public ObjectKvp ConvertUkvp(UnityKeyValuePair<string, string> ukvp) => (ObjectKvp) null;

  [Token(Token = "0x6000511")]
  [Address(RVA = "0x44B0C64", Offset = "0x44B0C64", VA = "0x44B0C64")]
  public UnityKeyValuePair<string, string> ConvertOkvp(ObjectKvp okvp)
  {
    return (UnityKeyValuePair<string, string>) null;
  }

  [Token(Token = "0x6000512")]
  [Address(RVA = "0x44B0FA4", Offset = "0x44B0FA4", VA = "0x44B0FA4", Slot = "23")]
  protected override void SetKeyValuePair(string k, string v)
  {
  }

  [Token(Token = "0x6000513")]
  [Address(RVA = "0x44B11F4", Offset = "0x44B11F4", VA = "0x44B11F4")]
  public ObjectDictionary()
  {
  }
}
