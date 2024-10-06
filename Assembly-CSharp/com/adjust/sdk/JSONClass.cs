// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONClass
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
  [Token(Token = "0x2003FD6")]
  public class JSONClass : JSONNode, IEnumerable
  {
    [Token(Token = "0x40117B6")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, JSONNode> m_Dict;

    [Token(Token = "0x170052CD")]
    public override JSONNode this[string aKey]
    {
      [Token(Token = "0x6019AF3"), Address(RVA = "0x378ECD8", Offset = "0x378ECD8", VA = "0x378ECD8", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019AF4"), Address(RVA = "0x378EDC8", Offset = "0x378EDC8", VA = "0x378EDC8", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x170052CE")]
    public override JSONNode this[int aIndex]
    {
      [Token(Token = "0x6019AF5"), Address(RVA = "0x378EE94", Offset = "0x378EE94", VA = "0x378EE94", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019AF6"), Address(RVA = "0x378EF34", Offset = "0x378EF34", VA = "0x378EF34", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170052CF")]
    public override int Count
    {
      [Token(Token = "0x6019AF7"), Address(RVA = "0x378F010", Offset = "0x378F010", VA = "0x378F010", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6019AF8")]
    [Address(RVA = "0x378F060", Offset = "0x378F060", VA = "0x378F060", Slot = "4")]
    public override void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x6019AF9")]
    [Address(RVA = "0x378F174", Offset = "0x378F174", VA = "0x378F174", Slot = "13")]
    public override JSONNode Remove(string aKey) => (JSONNode) null;

    [Token(Token = "0x6019AFA")]
    [Address(RVA = "0x378F238", Offset = "0x378F238", VA = "0x378F238", Slot = "14")]
    public override JSONNode Remove(int aIndex) => (JSONNode) null;

    [Token(Token = "0x6019AFB")]
    [Address(RVA = "0x378F314", Offset = "0x378F314", VA = "0x378F314", Slot = "15")]
    public override JSONNode Remove(JSONNode aNode) => (JSONNode) null;

    [Token(Token = "0x170052D0")]
    public override IEnumerable<JSONNode> Childs
    {
      [Token(Token = "0x6019AFC"), Address(RVA = "0x378F4DC", Offset = "0x378F4DC", VA = "0x378F4DC", Slot = "16")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x6019AFD")]
    [Address(RVA = "0x378F588", Offset = "0x378F588", VA = "0x378F588", Slot = "29")]
    public IEnumerator GetEnumerator() => (IEnumerator) null;

    [Token(Token = "0x6019AFE")]
    [Address(RVA = "0x378F618", Offset = "0x378F618", VA = "0x378F618", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6019AFF")]
    [Address(RVA = "0x378FA00", Offset = "0x378FA00", VA = "0x378FA00", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x6019B00")]
    [Address(RVA = "0x378FE6C", Offset = "0x378FE6C", VA = "0x378FE6C", Slot = "28")]
    public override void Serialize(BinaryWriter aWriter)
    {
    }

    [Token(Token = "0x6019B01")]
    [Address(RVA = "0x378C988", Offset = "0x378C988", VA = "0x378C988")]
    public JSONClass()
    {
    }
  }
}
