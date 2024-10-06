// Decompiled with JetBrains decompiler
// Type: Network.Param.GachaResourceDetailType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A5F")]
  [Serializable]
  public class GachaResourceDetailType
  {
    [Token(Token = "0x40070F2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int id;
    [Token(Token = "0x40070F3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int resource_id;
    [Token(Token = "0x40070F4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int type_id;
    [Token(Token = "0x40070F5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string path;

    [Token(Token = "0x17001928")]
    public int Id
    {
      [Token(Token = "0x6009745"), Address(RVA = "0x48EF880", Offset = "0x48EF880", VA = "0x48EF880")] get
      {
        return new int();
      }
      [Token(Token = "0x6009746"), Address(RVA = "0x48EF888", Offset = "0x48EF888", VA = "0x48EF888")] set
      {
      }
    }

    [Token(Token = "0x17001929")]
    public int ResourceId
    {
      [Token(Token = "0x6009747"), Address(RVA = "0x48EF890", Offset = "0x48EF890", VA = "0x48EF890")] get
      {
        return new int();
      }
      [Token(Token = "0x6009748"), Address(RVA = "0x48EF898", Offset = "0x48EF898", VA = "0x48EF898")] set
      {
      }
    }

    [Token(Token = "0x1700192A")]
    public int TypeId
    {
      [Token(Token = "0x6009749"), Address(RVA = "0x48EF8A0", Offset = "0x48EF8A0", VA = "0x48EF8A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600974A"), Address(RVA = "0x48EF8A8", Offset = "0x48EF8A8", VA = "0x48EF8A8")] set
      {
      }
    }

    [Token(Token = "0x1700192B")]
    public string Path
    {
      [Token(Token = "0x600974B"), Address(RVA = "0x48EF8B0", Offset = "0x48EF8B0", VA = "0x48EF8B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600974C"), Address(RVA = "0x48EF8B8", Offset = "0x48EF8B8", VA = "0x48EF8B8")] set
      {
      }
    }

    [Token(Token = "0x600974D")]
    [Address(RVA = "0x48EF8C0", Offset = "0x48EF8C0", VA = "0x48EF8C0")]
    public GachaResourceDetailType()
    {
    }
  }
}
