// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FD3")]
  public class JSONArray : JSONNode, IEnumerable
  {
    [Token(Token = "0x40117AC")]
    [FieldOffset(Offset = "0x10")]
    private List<JSONNode> m_List;

    [Token(Token = "0x170052C5")]
    public override JSONNode this[int aIndex]
    {
      [Token(Token = "0x6019AD5"), Address(RVA = "0x378DBEC", Offset = "0x378DBEC", VA = "0x378DBEC", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019AD6"), Address(RVA = "0x378DCC8", Offset = "0x378DCC8", VA = "0x378DCC8", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170052C6")]
    public override JSONNode this[string aKey]
    {
      [Token(Token = "0x6019AD7"), Address(RVA = "0x378DDD0", Offset = "0x378DDD0", VA = "0x378DDD0", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019AD8"), Address(RVA = "0x378DE34", Offset = "0x378DE34", VA = "0x378DE34", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x170052C7")]
    public override int Count
    {
      [Token(Token = "0x6019AD9"), Address(RVA = "0x378DEDC", Offset = "0x378DEDC", VA = "0x378DEDC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6019ADA")]
    [Address(RVA = "0x378DF24", Offset = "0x378DF24", VA = "0x378DF24", Slot = "4")]
    public override void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x6019ADB")]
    [Address(RVA = "0x378DFCC", Offset = "0x378DFCC", VA = "0x378DFCC", Slot = "14")]
    public override JSONNode Remove(int aIndex) => (JSONNode) null;

    [Token(Token = "0x6019ADC")]
    [Address(RVA = "0x378E080", Offset = "0x378E080", VA = "0x378E080", Slot = "15")]
    public override JSONNode Remove(JSONNode aNode) => (JSONNode) null;

    [Token(Token = "0x170052C8")]
    public override IEnumerable<JSONNode> Childs
    {
      [Token(Token = "0x6019ADD"), Address(RVA = "0x378E0E0", Offset = "0x378E0E0", VA = "0x378E0E0", Slot = "16")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x6019ADE")]
    [Address(RVA = "0x378E18C", Offset = "0x378E18C", VA = "0x378E18C", Slot = "29")]
    public IEnumerator GetEnumerator() => (IEnumerator) null;

    [Token(Token = "0x6019ADF")]
    [Address(RVA = "0x378E21C", Offset = "0x378E21C", VA = "0x378E21C", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6019AE0")]
    [Address(RVA = "0x378E434", Offset = "0x378E434", VA = "0x378E434", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x6019AE1")]
    [Address(RVA = "0x378E6B4", Offset = "0x378E6B4", VA = "0x378E6B4", Slot = "28")]
    public override void Serialize(BinaryWriter aWriter)
    {
    }

    [Token(Token = "0x6019AE2")]
    [Address(RVA = "0x378CA04", Offset = "0x378CA04", VA = "0x378CA04")]
    public JSONArray()
    {
    }
  }
}
