// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FD0")]
  public class JSONNode
  {
    [Token(Token = "0x6019A95")]
    [Address(RVA = "0x378B85C", Offset = "0x378B85C", VA = "0x378B85C", Slot = "4")]
    public virtual void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x170052B5")]
    public virtual JSONNode this[int aIndex]
    {
      [Token(Token = "0x6019A96"), Address(RVA = "0x378B860", Offset = "0x378B860", VA = "0x378B860", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019A97"), Address(RVA = "0x378B868", Offset = "0x378B868", VA = "0x378B868", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170052B6")]
    public virtual JSONNode this[string aKey]
    {
      [Token(Token = "0x6019A98"), Address(RVA = "0x378B86C", Offset = "0x378B86C", VA = "0x378B86C", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019A99"), Address(RVA = "0x378B874", Offset = "0x378B874", VA = "0x378B874", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x170052B7")]
    public virtual string Value
    {
      [Token(Token = "0x6019A9A"), Address(RVA = "0x378B878", Offset = "0x378B878", VA = "0x378B878", Slot = "9")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A9B"), Address(RVA = "0x378B8B8", Offset = "0x378B8B8", VA = "0x378B8B8", Slot = "10")] set
      {
      }
    }

    [Token(Token = "0x170052B8")]
    public virtual int Count
    {
      [Token(Token = "0x6019A9C"), Address(RVA = "0x378B8BC", Offset = "0x378B8BC", VA = "0x378B8BC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6019A9D")]
    [Address(RVA = "0x378B8C4", Offset = "0x378B8C4", VA = "0x378B8C4", Slot = "12")]
    public virtual void Add(JSONNode aItem)
    {
    }

    [Token(Token = "0x6019A9E")]
    [Address(RVA = "0x378B924", Offset = "0x378B924", VA = "0x378B924", Slot = "13")]
    public virtual JSONNode Remove(string aKey) => (JSONNode) null;

    [Token(Token = "0x6019A9F")]
    [Address(RVA = "0x378B92C", Offset = "0x378B92C", VA = "0x378B92C", Slot = "14")]
    public virtual JSONNode Remove(int aIndex) => (JSONNode) null;

    [Token(Token = "0x6019AA0")]
    [Address(RVA = "0x378B934", Offset = "0x378B934", VA = "0x378B934", Slot = "15")]
    public virtual JSONNode Remove(JSONNode aNode) => (JSONNode) null;

    [Token(Token = "0x170052B9")]
    public virtual IEnumerable<JSONNode> Childs
    {
      [Token(Token = "0x6019AA1"), Address(RVA = "0x378B93C", Offset = "0x378B93C", VA = "0x378B93C", Slot = "16")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x170052BA")]
    public IEnumerable<JSONNode> DeepChilds
    {
      [Token(Token = "0x6019AA2"), Address(RVA = "0x378B9E0", Offset = "0x378B9E0", VA = "0x378B9E0")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x6019AA3")]
    [Address(RVA = "0x378BA8C", Offset = "0x378BA8C", VA = "0x378BA8C", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6019AA4")]
    [Address(RVA = "0x378BACC", Offset = "0x378BACC", VA = "0x378BACC", Slot = "17")]
    public virtual string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x170052BB")]
    public virtual int AsInt
    {
      [Token(Token = "0x6019AA5"), Address(RVA = "0x378BB0C", Offset = "0x378BB0C", VA = "0x378BB0C", Slot = "18")] get
      {
        return new int();
      }
      [Token(Token = "0x6019AA6"), Address(RVA = "0x378BB40", Offset = "0x378BB40", VA = "0x378BB40", Slot = "19")] set
      {
      }
    }

    [Token(Token = "0x170052BC")]
    public virtual float AsFloat
    {
      [Token(Token = "0x6019AA7"), Address(RVA = "0x378BB7C", Offset = "0x378BB7C", VA = "0x378BB7C", Slot = "20")] get
      {
        return new float();
      }
      [Token(Token = "0x6019AA8"), Address(RVA = "0x378BBB4", Offset = "0x378BBB4", VA = "0x378BBB4", Slot = "21")] set
      {
      }
    }

    [Token(Token = "0x170052BD")]
    public virtual double AsDouble
    {
      [Token(Token = "0x6019AA9"), Address(RVA = "0x378BBF0", Offset = "0x378BBF0", VA = "0x378BBF0", Slot = "22")] get
      {
        return new double();
      }
      [Token(Token = "0x6019AAA"), Address(RVA = "0x378BC28", Offset = "0x378BC28", VA = "0x378BC28", Slot = "23")] set
      {
      }
    }

    [Token(Token = "0x170052BE")]
    public virtual bool AsBool
    {
      [Token(Token = "0x6019AAB"), Address(RVA = "0x378BC64", Offset = "0x378BC64", VA = "0x378BC64", Slot = "24")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019AAC"), Address(RVA = "0x378BD1C", Offset = "0x378BD1C", VA = "0x378BD1C", Slot = "25")] set
      {
      }
    }

    [Token(Token = "0x170052BF")]
    public virtual JSONArray AsArray
    {
      [Token(Token = "0x6019AAD"), Address(RVA = "0x378BD94", Offset = "0x378BD94", VA = "0x378BD94", Slot = "26")] get
      {
        return (JSONArray) null;
      }
    }

    [Token(Token = "0x170052C0")]
    public virtual JSONClass AsObject
    {
      [Token(Token = "0x6019AAE"), Address(RVA = "0x378BE0C", Offset = "0x378BE0C", VA = "0x378BE0C", Slot = "27")] get
      {
        return (JSONClass) null;
      }
    }

    [Token(Token = "0x6019AAF")]
    [Address(RVA = "0x378BE84", Offset = "0x378BE84", VA = "0x378BE84")]
    public static implicit operator JSONNode(string s) => (JSONNode) null;

    [Token(Token = "0x6019AB0")]
    [Address(RVA = "0x378BF10", Offset = "0x378BF10", VA = "0x378BF10")]
    public static implicit operator string(JSONNode d) => (string) null;

    [Token(Token = "0x6019AB1")]
    [Address(RVA = "0x378BF4C", Offset = "0x378BF4C", VA = "0x378BF4C")]
    public static bool operator ==(JSONNode a, object b) => new bool();

    [Token(Token = "0x6019AB2")]
    [Address(RVA = "0x378BFD4", Offset = "0x378BFD4", VA = "0x378BFD4")]
    public static bool operator !=(JSONNode a, object b) => new bool();

    [Token(Token = "0x6019AB3")]
    [Address(RVA = "0x378BFEC", Offset = "0x378BFEC", VA = "0x378BFEC", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6019AB4")]
    [Address(RVA = "0x378BFF8", Offset = "0x378BFF8", VA = "0x378BFF8", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6019AB5")]
    [Address(RVA = "0x378C000", Offset = "0x378C000", VA = "0x378C000")]
    internal static string Escape(string aText) => (string) null;

    [Token(Token = "0x6019AB6")]
    [Address(RVA = "0x378C1F0", Offset = "0x378C1F0", VA = "0x378C1F0")]
    public static JSONNode Parse(string aJSON) => (JSONNode) null;

    [Token(Token = "0x6019AB7")]
    [Address(RVA = "0x378CA80", Offset = "0x378CA80", VA = "0x378CA80", Slot = "28")]
    public virtual void Serialize(BinaryWriter aWriter)
    {
    }

    [Token(Token = "0x6019AB8")]
    [Address(RVA = "0x378CA84", Offset = "0x378CA84", VA = "0x378CA84")]
    public void SaveToStream(Stream aData)
    {
    }

    [Token(Token = "0x6019AB9")]
    [Address(RVA = "0x378CB04", Offset = "0x378CB04", VA = "0x378CB04")]
    public void SaveToCompressedStream(Stream aData)
    {
    }

    [Token(Token = "0x6019ABA")]
    [Address(RVA = "0x378CB54", Offset = "0x378CB54", VA = "0x378CB54")]
    public void SaveToCompressedFile(string aFileName)
    {
    }

    [Token(Token = "0x6019ABB")]
    [Address(RVA = "0x378CBA4", Offset = "0x378CBA4", VA = "0x378CBA4")]
    public string SaveToCompressedBase64() => (string) null;

    [Token(Token = "0x6019ABC")]
    [Address(RVA = "0x378CBF4", Offset = "0x378CBF4", VA = "0x378CBF4")]
    public static JSONNode Deserialize(BinaryReader aReader) => (JSONNode) null;

    [Token(Token = "0x6019ABD")]
    [Address(RVA = "0x378D060", Offset = "0x378D060", VA = "0x378D060")]
    public static JSONNode LoadFromCompressedFile(string aFileName) => (JSONNode) null;

    [Token(Token = "0x6019ABE")]
    [Address(RVA = "0x378D0B0", Offset = "0x378D0B0", VA = "0x378D0B0")]
    public static JSONNode LoadFromCompressedStream(Stream aData) => (JSONNode) null;

    [Token(Token = "0x6019ABF")]
    [Address(RVA = "0x378D100", Offset = "0x378D100", VA = "0x378D100")]
    public static JSONNode LoadFromCompressedBase64(string aBase64) => (JSONNode) null;

    [Token(Token = "0x6019AC0")]
    [Address(RVA = "0x378D150", Offset = "0x378D150", VA = "0x378D150")]
    public static JSONNode LoadFromStream(Stream aData) => (JSONNode) null;

    [Token(Token = "0x6019AC1")]
    [Address(RVA = "0x378D2E4", Offset = "0x378D2E4", VA = "0x378D2E4")]
    public static JSONNode LoadFromBase64(string aBase64) => (JSONNode) null;

    [Token(Token = "0x6019AC2")]
    [Address(RVA = "0x378D398", Offset = "0x378D398", VA = "0x378D398")]
    public JSONNode()
    {
    }
  }
}
