// Decompiled with JetBrains decompiler
// Type: Network.Param.GachaModuleType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A5E")]
  [Serializable]
  public class GachaModuleType
  {
    [Token(Token = "0x40070E9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string name;
    [Token(Token = "0x40070EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int number;
    [Token(Token = "0x40070EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string title;
    [Token(Token = "0x40070EC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GachaResourceDetailType> background_resource;
    [Token(Token = "0x40070ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool is_badge_enable;
    [Token(Token = "0x40070EE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string start_at;
    [Token(Token = "0x40070EF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string end_at;
    [Token(Token = "0x40070F0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private bool is_story_gacha;
    [Token(Token = "0x40070F1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string api_schema_version;

    [Token(Token = "0x1700191F")]
    public string Name
    {
      [Token(Token = "0x6009732"), Address(RVA = "0x48EF7E0", Offset = "0x48EF7E0", VA = "0x48EF7E0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009733"), Address(RVA = "0x48EF7E8", Offset = "0x48EF7E8", VA = "0x48EF7E8")] set
      {
      }
    }

    [Token(Token = "0x17001920")]
    public int Number
    {
      [Token(Token = "0x6009734"), Address(RVA = "0x48EF7F0", Offset = "0x48EF7F0", VA = "0x48EF7F0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009735"), Address(RVA = "0x48EF7F8", Offset = "0x48EF7F8", VA = "0x48EF7F8")] set
      {
      }
    }

    [Token(Token = "0x17001921")]
    public string Title
    {
      [Token(Token = "0x6009736"), Address(RVA = "0x48EF800", Offset = "0x48EF800", VA = "0x48EF800")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009737"), Address(RVA = "0x48EF808", Offset = "0x48EF808", VA = "0x48EF808")] set
      {
      }
    }

    [Token(Token = "0x17001922")]
    public List<GachaResourceDetailType> BackgroundResource
    {
      [Token(Token = "0x6009738"), Address(RVA = "0x48EF810", Offset = "0x48EF810", VA = "0x48EF810")] get
      {
        return (List<GachaResourceDetailType>) null;
      }
      [Token(Token = "0x6009739"), Address(RVA = "0x48EF818", Offset = "0x48EF818", VA = "0x48EF818")] set
      {
      }
    }

    [Token(Token = "0x17001923")]
    public bool IsBadgeEnable
    {
      [Token(Token = "0x600973A"), Address(RVA = "0x48EF820", Offset = "0x48EF820", VA = "0x48EF820")] get
      {
        return new bool();
      }
      [Token(Token = "0x600973B"), Address(RVA = "0x48EF828", Offset = "0x48EF828", VA = "0x48EF828")] set
      {
      }
    }

    [Token(Token = "0x17001924")]
    public string StartAt
    {
      [Token(Token = "0x600973C"), Address(RVA = "0x48EF834", Offset = "0x48EF834", VA = "0x48EF834")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600973D"), Address(RVA = "0x48EF83C", Offset = "0x48EF83C", VA = "0x48EF83C")] set
      {
      }
    }

    [Token(Token = "0x17001925")]
    public string EndAt
    {
      [Token(Token = "0x600973E"), Address(RVA = "0x48EF844", Offset = "0x48EF844", VA = "0x48EF844")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600973F"), Address(RVA = "0x48EF84C", Offset = "0x48EF84C", VA = "0x48EF84C")] set
      {
      }
    }

    [Token(Token = "0x17001926")]
    public bool IsStoryGacha
    {
      [Token(Token = "0x6009740"), Address(RVA = "0x48EF854", Offset = "0x48EF854", VA = "0x48EF854")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009741"), Address(RVA = "0x48EF85C", Offset = "0x48EF85C", VA = "0x48EF85C")] set
      {
      }
    }

    [Token(Token = "0x17001927")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x6009742"), Address(RVA = "0x48EF868", Offset = "0x48EF868", VA = "0x48EF868")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009743"), Address(RVA = "0x48EF870", Offset = "0x48EF870", VA = "0x48EF870")] set
      {
      }
    }

    [Token(Token = "0x6009744")]
    [Address(RVA = "0x48EF878", Offset = "0x48EF878", VA = "0x48EF878")]
    public GachaModuleType()
    {
    }
  }
}
