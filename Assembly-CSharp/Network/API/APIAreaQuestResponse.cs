// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B6C")]
  [Serializable]
  public class APIAreaQuestResponse : ICommonApiResult
  {
    [Token(Token = "0x4007581")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007582")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int active_area_id;
    [Token(Token = "0x4007583")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int active_area_node_id;
    [Token(Token = "0x4007584")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerAreaType> player_areas;
    [Token(Token = "0x4007585")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<int> directed_area_ids;
    [Token(Token = "0x4007586")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<int> directed_area_node_ids;

    [Token(Token = "0x17001D69")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A102"), Address(RVA = "0x46C67A4", Offset = "0x46C67A4", VA = "0x46C67A4", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001D6A")]
    public int ActiveAreaId
    {
      [Token(Token = "0x600A103"), Address(RVA = "0x46C67AC", Offset = "0x46C67AC", VA = "0x46C67AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D6B")]
    public int ActiveAreaNodeId
    {
      [Token(Token = "0x600A104"), Address(RVA = "0x46C67B4", Offset = "0x46C67B4", VA = "0x46C67B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D6C")]
    public List<PlayerAreaType> PlayerAreas
    {
      [Token(Token = "0x600A105"), Address(RVA = "0x46C67BC", Offset = "0x46C67BC", VA = "0x46C67BC")] get
      {
        return (List<PlayerAreaType>) null;
      }
    }

    [Token(Token = "0x17001D6D")]
    public List<int> DirectedAreaIds
    {
      [Token(Token = "0x600A106"), Address(RVA = "0x46C67C4", Offset = "0x46C67C4", VA = "0x46C67C4")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17001D6E")]
    public List<int> DirectedAreaNodeIds
    {
      [Token(Token = "0x600A107"), Address(RVA = "0x46C67CC", Offset = "0x46C67CC", VA = "0x46C67CC")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600A108")]
    [Address(RVA = "0x46C67D4", Offset = "0x46C67D4", VA = "0x46C67D4")]
    public APIAreaQuestResponse()
    {
    }
  }
}
