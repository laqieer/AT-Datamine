// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Member.GuildMemberRoleSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Member
{
  [Token(Token = "0x2002BDC")]
  public class GuildMemberRoleSelect : MonoBehaviour
  {
    [Token(Token = "0x400BAA9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GuildMemberRoleSelect.RoleObj> Roles;

    [Token(Token = "0x6011226")]
    [Address(RVA = "0x4A0A888", Offset = "0x4A0A888", VA = "0x4A0A888")]
    public void SetActive(GuildRoleTypeEnum role)
    {
    }

    [Token(Token = "0x6011227")]
    [Address(RVA = "0x4A0AA04", Offset = "0x4A0AA04", VA = "0x4A0AA04")]
    public GuildMemberRoleSelect()
    {
    }

    [Token(Token = "0x2002BDD")]
    [Serializable]
    public class RoleObj
    {
      [Token(Token = "0x400BAAA")]
      [FieldOffset(Offset = "0x10")]
      public GuildRoleTypeEnum role;
      [Token(Token = "0x400BAAB")]
      [FieldOffset(Offset = "0x18")]
      public GameObject obj;

      [Token(Token = "0x6011228")]
      [Address(RVA = "0x4A0AA0C", Offset = "0x4A0AA0C", VA = "0x4A0AA0C")]
      public RoleObj()
      {
      }
    }
  }
}
