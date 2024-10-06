// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONLazyCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FDB")]
  internal class JSONLazyCreator : JSONNode
  {
    [Token(Token = "0x40117C2")]
    [FieldOffset(Offset = "0x10")]
    private JSONNode m_Node;
    [Token(Token = "0x40117C3")]
    [FieldOffset(Offset = "0x18")]
    private string m_Key;

    [Token(Token = "0x6019B1E")]
    [Address(RVA = "0x378DCA0", Offset = "0x378DCA0", VA = "0x378DCA0")]
    public JSONLazyCreator(JSONNode aNode)
    {
    }

    [Token(Token = "0x6019B1F")]
    [Address(RVA = "0x378ED9C", Offset = "0x378ED9C", VA = "0x378ED9C")]
    public JSONLazyCreator(JSONNode aNode, string aKey)
    {
    }

    [Token(Token = "0x6019B20")]
    [Address(RVA = "0x37909EC", Offset = "0x37909EC", VA = "0x37909EC")]
    private void Set(JSONNode aVal)
    {
    }

    [Token(Token = "0x170052D6")]
    public override JSONNode this[int aIndex]
    {
      [Token(Token = "0x6019B21"), Address(RVA = "0x3790A40", Offset = "0x3790A40", VA = "0x3790A40", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019B22"), Address(RVA = "0x3790AA4", Offset = "0x3790AA4", VA = "0x3790AA4", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170052D7")]
    public override JSONNode this[string aKey]
    {
      [Token(Token = "0x6019B23"), Address(RVA = "0x3790B24", Offset = "0x3790B24", VA = "0x3790B24", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x6019B24"), Address(RVA = "0x3790B94", Offset = "0x3790B94", VA = "0x3790B94", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x6019B25")]
    [Address(RVA = "0x3790C1C", Offset = "0x3790C1C", VA = "0x3790C1C", Slot = "12")]
    public override void Add(JSONNode aItem)
    {
    }

    [Token(Token = "0x6019B26")]
    [Address(RVA = "0x3790C9C", Offset = "0x3790C9C", VA = "0x3790C9C", Slot = "4")]
    public override void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x6019B27")]
    [Address(RVA = "0x3790D24", Offset = "0x3790D24", VA = "0x3790D24")]
    public static bool operator ==(JSONLazyCreator a, object b) => new bool();

    [Token(Token = "0x6019B28")]
    [Address(RVA = "0x3790D3C", Offset = "0x3790D3C", VA = "0x3790D3C")]
    public static bool operator !=(JSONLazyCreator a, object b) => new bool();

    [Token(Token = "0x6019B29")]
    [Address(RVA = "0x3790D54", Offset = "0x3790D54", VA = "0x3790D54", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6019B2A")]
    [Address(RVA = "0x3790D6C", Offset = "0x3790D6C", VA = "0x3790D6C", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6019B2B")]
    [Address(RVA = "0x3790D74", Offset = "0x3790D74", VA = "0x3790D74", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6019B2C")]
    [Address(RVA = "0x3790DB4", Offset = "0x3790DB4", VA = "0x3790DB4", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x170052D8")]
    public override int AsInt
    {
      [Token(Token = "0x6019B2D"), Address(RVA = "0x3790DF4", Offset = "0x3790DF4", VA = "0x3790DF4", Slot = "18")] get
      {
        return new int();
      }
      [Token(Token = "0x6019B2E"), Address(RVA = "0x3790E78", Offset = "0x3790E78", VA = "0x3790E78", Slot = "19")] set
      {
      }
    }

    [Token(Token = "0x170052D9")]
    public override float AsFloat
    {
      [Token(Token = "0x6019B2F"), Address(RVA = "0x3790F00", Offset = "0x3790F00", VA = "0x3790F00", Slot = "20")] get
      {
        return new float();
      }
      [Token(Token = "0x6019B30"), Address(RVA = "0x3790F84", Offset = "0x3790F84", VA = "0x3790F84", Slot = "21")] set
      {
      }
    }

    [Token(Token = "0x170052DA")]
    public override double AsDouble
    {
      [Token(Token = "0x6019B31"), Address(RVA = "0x379100C", Offset = "0x379100C", VA = "0x379100C", Slot = "22")] get
      {
        return new double();
      }
      [Token(Token = "0x6019B32"), Address(RVA = "0x3791090", Offset = "0x3791090", VA = "0x3791090", Slot = "23")] set
      {
      }
    }

    [Token(Token = "0x170052DB")]
    public override bool AsBool
    {
      [Token(Token = "0x6019B33"), Address(RVA = "0x3791118", Offset = "0x3791118", VA = "0x3791118", Slot = "24")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019B34"), Address(RVA = "0x379119C", Offset = "0x379119C", VA = "0x379119C", Slot = "25")] set
      {
      }
    }

    [Token(Token = "0x170052DC")]
    public override JSONArray AsArray
    {
      [Token(Token = "0x6019B35"), Address(RVA = "0x3791224", Offset = "0x3791224", VA = "0x3791224", Slot = "26")] get
      {
        return (JSONArray) null;
      }
    }

    [Token(Token = "0x170052DD")]
    public override JSONClass AsObject
    {
      [Token(Token = "0x6019B36"), Address(RVA = "0x379128C", Offset = "0x379128C", VA = "0x379128C", Slot = "27")] get
      {
        return (JSONClass) null;
      }
    }
  }
}
