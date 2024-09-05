// Decompiled with JetBrains decompiler
// Type: Battle.Data.MapObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using YamlDotNet.Serialization;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002705")]
  public struct MapObject
  {
    [Token(Token = "0x17003359")]
    [YamlMember(Alias = "x")]
    public int X
    {
      [Token(Token = "0x600F1DE"), Address(RVA = "0x41AFC74", Offset = "0x41AFC74", VA = "0x41AFC74")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600F1DF"), Address(RVA = "0x41AFC7C", Offset = "0x41AFC7C", VA = "0x41AFC7C")] set
      {
      }
    }

    [Token(Token = "0x1700335A")]
    [YamlMember(Alias = "y")]
    public int Y
    {
      [Token(Token = "0x600F1E0"), Address(RVA = "0x41AFC84", Offset = "0x41AFC84", VA = "0x41AFC84")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600F1E1"), Address(RVA = "0x41AFC8C", Offset = "0x41AFC8C", VA = "0x41AFC8C")] set
      {
      }
    }

    [Token(Token = "0x1700335B")]
    [YamlMember(Alias = "rotate")]
    public float Rotate
    {
      [Token(Token = "0x600F1E2"), Address(RVA = "0x41AFC94", Offset = "0x41AFC94", VA = "0x41AFC94")] readonly get
      {
        return new float();
      }
      [Token(Token = "0x600F1E3"), Address(RVA = "0x41AFC9C", Offset = "0x41AFC9C", VA = "0x41AFC9C")] set
      {
      }
    }

    [Token(Token = "0x1700335C")]
    [YamlMember(Alias = "name")]
    public string ModelName
    {
      [Token(Token = "0x600F1E4"), Address(RVA = "0x41AFCA4", Offset = "0x41AFCA4", VA = "0x41AFCA4")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1E5"), Address(RVA = "0x41AFCAC", Offset = "0x41AFCAC", VA = "0x41AFCAC")] set
      {
      }
    }

    [Token(Token = "0x1700335D")]
    [YamlMember(Alias = "full_name")]
    public string FullPath
    {
      [Token(Token = "0x600F1E6"), Address(RVA = "0x41AFCB4", Offset = "0x41AFCB4", VA = "0x41AFCB4")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1E7"), Address(RVA = "0x41AFCBC", Offset = "0x41AFCBC", VA = "0x41AFCBC")] set
      {
      }
    }
  }
}
