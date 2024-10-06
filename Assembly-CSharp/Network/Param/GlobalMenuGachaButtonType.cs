// Decompiled with JetBrains decompiler
// Type: Network.Param.GlobalMenuGachaButtonType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A61")]
  [Serializable]
  public class GlobalMenuGachaButtonType
  {
    [Token(Token = "0x40070FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int gacha_number;
    [Token(Token = "0x40070FC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string gacha_end_at;
    [Token(Token = "0x40070FD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string display_end_at;
    [Token(Token = "0x40070FE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string title_image_url;
    [Token(Token = "0x40070FF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string front_image_url;

    [Token(Token = "0x17001931")]
    public int GachaNumber
    {
      [Token(Token = "0x6009759"), Address(RVA = "0x48EF928", Offset = "0x48EF928", VA = "0x48EF928")] get
      {
        return new int();
      }
      [Token(Token = "0x600975A"), Address(RVA = "0x48EF930", Offset = "0x48EF930", VA = "0x48EF930")] set
      {
      }
    }

    [Token(Token = "0x17001932")]
    public string GachaEndAt
    {
      [Token(Token = "0x600975B"), Address(RVA = "0x48EF938", Offset = "0x48EF938", VA = "0x48EF938")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600975C"), Address(RVA = "0x48EF940", Offset = "0x48EF940", VA = "0x48EF940")] set
      {
      }
    }

    [Token(Token = "0x17001933")]
    public string DisplayEndAt
    {
      [Token(Token = "0x600975D"), Address(RVA = "0x48EF948", Offset = "0x48EF948", VA = "0x48EF948")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600975E"), Address(RVA = "0x48EF950", Offset = "0x48EF950", VA = "0x48EF950")] set
      {
      }
    }

    [Token(Token = "0x17001934")]
    public string TitleImageUrl
    {
      [Token(Token = "0x600975F"), Address(RVA = "0x48EF958", Offset = "0x48EF958", VA = "0x48EF958")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009760"), Address(RVA = "0x48EF960", Offset = "0x48EF960", VA = "0x48EF960")] set
      {
      }
    }

    [Token(Token = "0x17001935")]
    public string FrontImageUrl
    {
      [Token(Token = "0x6009761"), Address(RVA = "0x48EF968", Offset = "0x48EF968", VA = "0x48EF968")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009762"), Address(RVA = "0x48EF970", Offset = "0x48EF970", VA = "0x48EF970")] set
      {
      }
    }

    [Token(Token = "0x6009763")]
    [Address(RVA = "0x48EF978", Offset = "0x48EF978", VA = "0x48EF978")]
    public GlobalMenuGachaButtonType()
    {
    }
  }
}
