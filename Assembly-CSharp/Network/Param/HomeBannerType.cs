// Decompiled with JetBrains decompiler
// Type: Network.Param.HomeBannerType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A6F")]
  [Serializable]
  public class HomeBannerType
  {
    [Token(Token = "0x400716E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int banner_content_type_id;
    [Token(Token = "0x400716F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string resource_name;
    [Token(Token = "0x4007170")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int show_priority;
    [Token(Token = "0x4007171")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int relation_id;
    [Token(Token = "0x4007172")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string url;
    [Token(Token = "0x4007173")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string start_at;
    [Token(Token = "0x4007174")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string end_at;

    [Token(Token = "0x170019A5")]
    public int BannerContentTypeId
    {
      [Token(Token = "0x600984E"), Address(RVA = "0x48F00E4", Offset = "0x48F00E4", VA = "0x48F00E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600984F"), Address(RVA = "0x48F00EC", Offset = "0x48F00EC", VA = "0x48F00EC")] set
      {
      }
    }

    [Token(Token = "0x170019A6")]
    public string ResourceName
    {
      [Token(Token = "0x6009850"), Address(RVA = "0x48F00F4", Offset = "0x48F00F4", VA = "0x48F00F4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009851"), Address(RVA = "0x48F00FC", Offset = "0x48F00FC", VA = "0x48F00FC")] set
      {
      }
    }

    [Token(Token = "0x170019A7")]
    public int ShowPriority
    {
      [Token(Token = "0x6009852"), Address(RVA = "0x48F0104", Offset = "0x48F0104", VA = "0x48F0104")] get
      {
        return new int();
      }
      [Token(Token = "0x6009853"), Address(RVA = "0x48F010C", Offset = "0x48F010C", VA = "0x48F010C")] set
      {
      }
    }

    [Token(Token = "0x170019A8")]
    public int RelationId
    {
      [Token(Token = "0x6009854"), Address(RVA = "0x48F0114", Offset = "0x48F0114", VA = "0x48F0114")] get
      {
        return new int();
      }
      [Token(Token = "0x6009855"), Address(RVA = "0x48F011C", Offset = "0x48F011C", VA = "0x48F011C")] set
      {
      }
    }

    [Token(Token = "0x170019A9")]
    public string Url
    {
      [Token(Token = "0x6009856"), Address(RVA = "0x48F0124", Offset = "0x48F0124", VA = "0x48F0124")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009857"), Address(RVA = "0x48F012C", Offset = "0x48F012C", VA = "0x48F012C")] set
      {
      }
    }

    [Token(Token = "0x170019AA")]
    public string StartAt
    {
      [Token(Token = "0x6009858"), Address(RVA = "0x48F0134", Offset = "0x48F0134", VA = "0x48F0134")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009859"), Address(RVA = "0x48F013C", Offset = "0x48F013C", VA = "0x48F013C")] set
      {
      }
    }

    [Token(Token = "0x170019AB")]
    public string EndAt
    {
      [Token(Token = "0x600985A"), Address(RVA = "0x48F0144", Offset = "0x48F0144", VA = "0x48F0144")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600985B"), Address(RVA = "0x48F014C", Offset = "0x48F014C", VA = "0x48F014C")] set
      {
      }
    }

    [Token(Token = "0x600985C")]
    [Address(RVA = "0x48F0154", Offset = "0x48F0154", VA = "0x48F0154")]
    public HomeBannerType()
    {
    }
  }
}
