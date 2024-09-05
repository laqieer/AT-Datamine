// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityRewardListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002C00")]
  public class GuildFacilityRewardListItem : MonoBehaviour
  {
    [Token(Token = "0x400BB58")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildFacilityRewardText guildFacilityRewardText;
    [Token(Token = "0x400BB59")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textGuildFacilityLevel;
    [Token(Token = "0x400BB5A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject objUnlocked;

    [Token(Token = "0x60112F9")]
    [Address(RVA = "0x4A13A70", Offset = "0x4A13A70", VA = "0x4A13A70")]
    public void Setup(GuildFacilityRewardListItem.UIParameter param)
    {
    }

    [Token(Token = "0x60112FA")]
    [Address(RVA = "0x4A13B34", Offset = "0x4A13B34", VA = "0x4A13B34")]
    public GuildFacilityRewardListItem()
    {
    }

    [Token(Token = "0x2002C01")]
    public class UIParameter
    {
      [Token(Token = "0x17003B3A")]
      public int guildFacilityLevel
      {
        [Token(Token = "0x60112FB"), Address(RVA = "0x4A13B3C", Offset = "0x4A13B3C", VA = "0x4A13B3C")] get
        {
          return new int();
        }
        [Token(Token = "0x60112FC"), Address(RVA = "0x4A13B44", Offset = "0x4A13B44", VA = "0x4A13B44")] set
        {
        }
      }

      [Token(Token = "0x17003B3B")]
      public bool isUnlocked
      {
        [Token(Token = "0x60112FD"), Address(RVA = "0x4A13B4C", Offset = "0x4A13B4C", VA = "0x4A13B4C")] get
        {
          return new bool();
        }
        [Token(Token = "0x60112FE"), Address(RVA = "0x4A13B54", Offset = "0x4A13B54", VA = "0x4A13B54")] set
        {
        }
      }

      [Token(Token = "0x17003B3C")]
      public List<GuildFacilityRewardDescriptionData> facilityRewards
      {
        [Token(Token = "0x60112FF"), Address(RVA = "0x4A13B60", Offset = "0x4A13B60", VA = "0x4A13B60")] get
        {
          return (List<GuildFacilityRewardDescriptionData>) null;
        }
        [Token(Token = "0x6011300"), Address(RVA = "0x4A13B68", Offset = "0x4A13B68", VA = "0x4A13B68")] set
        {
        }
      }

      [Token(Token = "0x6011301")]
      [Address(RVA = "0x4A0E7D4", Offset = "0x4A0E7D4", VA = "0x4A0E7D4")]
      public UIParameter()
      {
      }
    }
  }
}
