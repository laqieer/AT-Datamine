// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.FeatureBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004D4")]
  [SerializeField]
  public class FeatureBase
  {
    [Token(Token = "0x4001950")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string simpleText;
    [Token(Token = "0x4001951")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string detailText;
    [Token(Token = "0x4001952")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Color color;

    [Token(Token = "0x17000362")]
    public string SimpleText
    {
      [Token(Token = "0x6001B89"), Address(RVA = "0x2C2CBE4", Offset = "0x2C2CBE4", VA = "0x2C2CBE4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000363")]
    public string DetailText
    {
      [Token(Token = "0x6001B8A"), Address(RVA = "0x2C2CBEC", Offset = "0x2C2CBEC", VA = "0x2C2CBEC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000364")]
    public Color Color
    {
      [Token(Token = "0x6001B8B"), Address(RVA = "0x2C2CBF4", Offset = "0x2C2CBF4", VA = "0x2C2CBF4")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17000365")]
    public virtual int Key
    {
      [Token(Token = "0x6001B8C"), Address(RVA = "0x2C2CC00", Offset = "0x2C2CC00", VA = "0x2C2CC00", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001B8D")]
    [Address(RVA = "0x2C2CC08", Offset = "0x2C2CC08", VA = "0x2C2CC08")]
    public FeatureBase()
    {
    }
  }
}
