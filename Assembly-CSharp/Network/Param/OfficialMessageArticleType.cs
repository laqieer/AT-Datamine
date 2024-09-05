// Decompiled with JetBrains decompiler
// Type: Network.Param.OfficialMessageArticleType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A7A")]
  [Serializable]
  public class OfficialMessageArticleType
  {
    [Token(Token = "0x4007188")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int id;
    [Token(Token = "0x4007189")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool is_important;
    [Token(Token = "0x400718A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string published_at;
    [Token(Token = "0x400718B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string title;
    [Token(Token = "0x400718C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string body;
    [Token(Token = "0x400718D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool is_read;

    [Token(Token = "0x170019CC")]
    public int Id
    {
      [Token(Token = "0x600989B"), Address(RVA = "0x48F02C0", Offset = "0x48F02C0", VA = "0x48F02C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600989C"), Address(RVA = "0x48F02C8", Offset = "0x48F02C8", VA = "0x48F02C8")] set
      {
      }
    }

    [Token(Token = "0x170019CD")]
    public bool IsImportant
    {
      [Token(Token = "0x600989D"), Address(RVA = "0x48F02D0", Offset = "0x48F02D0", VA = "0x48F02D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600989E"), Address(RVA = "0x48F02D8", Offset = "0x48F02D8", VA = "0x48F02D8")] set
      {
      }
    }

    [Token(Token = "0x170019CE")]
    public string PublishedAt
    {
      [Token(Token = "0x600989F"), Address(RVA = "0x48F02E4", Offset = "0x48F02E4", VA = "0x48F02E4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098A0"), Address(RVA = "0x48F02EC", Offset = "0x48F02EC", VA = "0x48F02EC")] set
      {
      }
    }

    [Token(Token = "0x170019CF")]
    public string Title
    {
      [Token(Token = "0x60098A1"), Address(RVA = "0x48F02F4", Offset = "0x48F02F4", VA = "0x48F02F4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098A2"), Address(RVA = "0x48F02FC", Offset = "0x48F02FC", VA = "0x48F02FC")] set
      {
      }
    }

    [Token(Token = "0x170019D0")]
    public string Body
    {
      [Token(Token = "0x60098A3"), Address(RVA = "0x48F0304", Offset = "0x48F0304", VA = "0x48F0304")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098A4"), Address(RVA = "0x48F030C", Offset = "0x48F030C", VA = "0x48F030C")] set
      {
      }
    }

    [Token(Token = "0x170019D1")]
    public bool IsRead
    {
      [Token(Token = "0x60098A5"), Address(RVA = "0x48F0314", Offset = "0x48F0314", VA = "0x48F0314")] get
      {
        return new bool();
      }
      [Token(Token = "0x60098A6"), Address(RVA = "0x48F031C", Offset = "0x48F031C", VA = "0x48F031C")] set
      {
      }
    }

    [Token(Token = "0x60098A7")]
    [Address(RVA = "0x48F0328", Offset = "0x48F0328", VA = "0x48F0328")]
    public OfficialMessageArticleType()
    {
    }
  }
}
