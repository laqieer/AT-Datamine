// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FDA")]
  public class JSONData : JSONNode
  {
    [Token(Token = "0x40117C1")]
    [FieldOffset(Offset = "0x10")]
    private string m_Data;

    [Token(Token = "0x170052D5")]
    public override string Value
    {
      [Token(Token = "0x6019B14"), Address(RVA = "0x379066C", Offset = "0x379066C", VA = "0x379066C", Slot = "9")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019B15"), Address(RVA = "0x3790674", Offset = "0x3790674", VA = "0x3790674", Slot = "10")] set
      {
      }
    }

    [Token(Token = "0x6019B16")]
    [Address(RVA = "0x378BEE8", Offset = "0x378BEE8", VA = "0x378BEE8")]
    public JSONData(string aData)
    {
    }

    [Token(Token = "0x6019B17")]
    [Address(RVA = "0x378D028", Offset = "0x378D028", VA = "0x378D028")]
    public JSONData(float aData)
    {
    }

    [Token(Token = "0x6019B18")]
    [Address(RVA = "0x378CFB8", Offset = "0x378CFB8", VA = "0x378CFB8")]
    public JSONData(double aData)
    {
    }

    [Token(Token = "0x6019B19")]
    [Address(RVA = "0x378CFF0", Offset = "0x378CFF0", VA = "0x378CFF0")]
    public JSONData(bool aData)
    {
    }

    [Token(Token = "0x6019B1A")]
    [Address(RVA = "0x378CF80", Offset = "0x378CF80", VA = "0x378CF80")]
    public JSONData(int aData)
    {
    }

    [Token(Token = "0x6019B1B")]
    [Address(RVA = "0x379067C", Offset = "0x379067C", VA = "0x379067C", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6019B1C")]
    [Address(RVA = "0x37906D4", Offset = "0x37906D4", VA = "0x37906D4", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x6019B1D")]
    [Address(RVA = "0x379072C", Offset = "0x379072C", VA = "0x379072C", Slot = "28")]
    public override void Serialize(BinaryWriter aWriter)
    {
    }
  }
}
