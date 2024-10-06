// Decompiled with JetBrains decompiler
// Type: Network.Param.G0000GachaGroupType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A56")]
  [Serializable]
  public class G0000GachaGroupType
  {
    [Token(Token = "0x40070A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int id;
    [Token(Token = "0x40070A8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string name;

    [Token(Token = "0x170018DD")]
    public int Id
    {
      [Token(Token = "0x60096A6"), Address(RVA = "0x48EF374", Offset = "0x48EF374", VA = "0x48EF374")] get
      {
        return new int();
      }
      [Token(Token = "0x60096A7"), Address(RVA = "0x48EF37C", Offset = "0x48EF37C", VA = "0x48EF37C")] set
      {
      }
    }

    [Token(Token = "0x170018DE")]
    public string Name
    {
      [Token(Token = "0x60096A8"), Address(RVA = "0x48EF384", Offset = "0x48EF384", VA = "0x48EF384")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60096A9"), Address(RVA = "0x48EF38C", Offset = "0x48EF38C", VA = "0x48EF38C")] set
      {
      }
    }

    [Token(Token = "0x60096AA")]
    [Address(RVA = "0x48EF394", Offset = "0x48EF394", VA = "0x48EF394")]
    public G0000GachaGroupType()
    {
    }
  }
}
