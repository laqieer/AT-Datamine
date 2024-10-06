// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Data.GuildDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using staq.SaveData;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Guild.Data
{
  [Token(Token = "0x2002C17")]
  public class GuildDataManager
  {
    [Token(Token = "0x400BBC1")]
    [FieldOffset(Offset = "0x44")]
    public int chatActiveCount;
    [Token(Token = "0x400BBC2")]
    [FieldOffset(Offset = "0x48")]
    public List<GuildMemberType> chatMembers;
    [Token(Token = "0x400BBC3")]
    [FieldOffset(Offset = "0x50")]
    public List<GuildChatMessageType> chatLogs;

    [Token(Token = "0x17003B5A")]
    public GuildRequestInfo GuildRequestInfo
    {
      [Token(Token = "0x6011397"), Address(RVA = "0x4A1863C", Offset = "0x4A1863C", VA = "0x4A1863C")] get
      {
        return (GuildRequestInfo) null;
      }
      [Token(Token = "0x6011398"), Address(RVA = "0x4A18644", Offset = "0x4A18644", VA = "0x4A18644")] private set
      {
      }
    }

    [Token(Token = "0x17003B5B")]
    public PlayerGuildInfo PlayerGuildInfo
    {
      [Token(Token = "0x6011399"), Address(RVA = "0x4A1864C", Offset = "0x4A1864C", VA = "0x4A1864C")] get
      {
        return (PlayerGuildInfo) null;
      }
      [Token(Token = "0x601139A"), Address(RVA = "0x4A18654", Offset = "0x4A18654", VA = "0x4A18654")] private set
      {
      }
    }

    [Token(Token = "0x17003B5C")]
    public GuildDetailInfo PlayerGuildDetailInfo
    {
      [Token(Token = "0x601139B"), Address(RVA = "0x4A1865C", Offset = "0x4A1865C", VA = "0x4A1865C")] get
      {
        return (GuildDetailInfo) null;
      }
      [Token(Token = "0x601139C"), Address(RVA = "0x4A18664", Offset = "0x4A18664", VA = "0x4A18664")] private set
      {
      }
    }

    [Token(Token = "0x17003B5D")]
    public GuildMemberListInfo PlayerGuildMemberListInfo
    {
      [Token(Token = "0x601139D"), Address(RVA = "0x4A1866C", Offset = "0x4A1866C", VA = "0x4A1866C")] get
      {
        return (GuildMemberListInfo) null;
      }
      [Token(Token = "0x601139E"), Address(RVA = "0x4A18674", Offset = "0x4A18674", VA = "0x4A18674")] private set
      {
      }
    }

    [Token(Token = "0x17003B5E")]
    public GuildFacilityInfo FacilityInfo
    {
      [Token(Token = "0x601139F"), Address(RVA = "0x4A1867C", Offset = "0x4A1867C", VA = "0x4A1867C")] get
      {
        return (GuildFacilityInfo) null;
      }
      [Token(Token = "0x60113A0"), Address(RVA = "0x4A18684", Offset = "0x4A18684", VA = "0x4A18684")] private set
      {
      }
    }

    [Token(Token = "0x17003B5F")]
    public GuildAttendInfo AttendInfo
    {
      [Token(Token = "0x60113A1"), Address(RVA = "0x4A1868C", Offset = "0x4A1868C", VA = "0x4A1868C")] get
      {
        return (GuildAttendInfo) null;
      }
      [Token(Token = "0x60113A2"), Address(RVA = "0x4A18694", Offset = "0x4A18694", VA = "0x4A18694")] private set
      {
      }
    }

    [Token(Token = "0x17003B60")]
    public bool ExistNewRequest
    {
      [Token(Token = "0x60113A3"), Address(RVA = "0x4A1869C", Offset = "0x4A1869C", VA = "0x4A1869C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60113A4"), Address(RVA = "0x4A186A4", Offset = "0x4A186A4", VA = "0x4A186A4")] private set
      {
      }
    }

    [Token(Token = "0x17003B61")]
    private GuildRoleSaveData GuildRoleSaveData
    {
      [Token(Token = "0x60113A5"), Address(RVA = "0x4A186B0", Offset = "0x4A186B0", VA = "0x4A186B0")] get
      {
        return (GuildRoleSaveData) null;
      }
    }

    [Token(Token = "0x17003B62")]
    private GuildFacilityConfirmLevelupEffectSaveData SaveDataFacilityConfirmLevelupEffect
    {
      [Token(Token = "0x60113A6"), Address(RVA = "0x4A18728", Offset = "0x4A18728", VA = "0x4A18728")] get
      {
        return (GuildFacilityConfirmLevelupEffectSaveData) null;
      }
    }

    [Token(Token = "0x17003B63")]
    public bool IsEmptyGuildRoleSaveData
    {
      [Token(Token = "0x60113A7"), Address(RVA = "0x4A187A0", Offset = "0x4A187A0", VA = "0x4A187A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003B64")]
    public bool IsEmptyFacilityConfirmLevelupEffect
    {
      [Token(Token = "0x60113A8"), Address(RVA = "0x4A187BC", Offset = "0x4A187BC", VA = "0x4A187BC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003B65")]
    public string LastBulletinBoardID
    {
      [Token(Token = "0x60113A9"), Address(RVA = "0x4A187D8", Offset = "0x4A187D8", VA = "0x4A187D8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003B66")]
    public string LastChatMessageID
    {
      [Token(Token = "0x60113AA"), Address(RVA = "0x4A1885C", Offset = "0x4A1885C", VA = "0x4A1885C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003B67")]
    public bool IsUpdateBulletinBoardID
    {
      [Token(Token = "0x60113AB"), Address(RVA = "0x4A188E0", Offset = "0x4A188E0", VA = "0x4A188E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60113AC"), Address(RVA = "0x4A188E8", Offset = "0x4A188E8", VA = "0x4A188E8")] set
      {
      }
    }

    [Token(Token = "0x17003B68")]
    public bool IsUpdateChatMessageID
    {
      [Token(Token = "0x60113AD"), Address(RVA = "0x4A188F4", Offset = "0x4A188F4", VA = "0x4A188F4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60113AE"), Address(RVA = "0x4A188FC", Offset = "0x4A188FC", VA = "0x4A188FC")] set
      {
      }
    }

    [Token(Token = "0x60113AF")]
    [Address(RVA = "0x4A18908", Offset = "0x4A18908", VA = "0x4A18908")]
    public void ResetPlayerGuildInfo()
    {
    }

    [Token(Token = "0x60113B0")]
    [Address(RVA = "0x4A18B58", Offset = "0x4A18B58", VA = "0x4A18B58")]
    public void ApplyPlayerSignin(APIPlayerSigninResponse signinRespons)
    {
    }

    [Token(Token = "0x60113B1")]
    [Address(RVA = "0x4A18B88", Offset = "0x4A18B88", VA = "0x4A18B88")]
    public void ApplyHome(APIHomeResponse homeResponse)
    {
    }

    [Token(Token = "0x60113B2")]
    [Address(RVA = "0x4A0B7A8", Offset = "0x4A0B7A8", VA = "0x4A0B7A8")]
    public void ApplyPlayerGuildRelationSyncParam(PlayerGuildRelationSync relationSync)
    {
    }

    [Token(Token = "0x60113B3")]
    [Address(RVA = "0x4A0B5DC", Offset = "0x4A0B5DC", VA = "0x4A0B5DC")]
    public void ApplyPlayerGuildSyncDataSet(GuildSyncDataSet guildSyncDataSet)
    {
    }

    [Token(Token = "0x60113B4")]
    [Address(RVA = "0x4A0E100", Offset = "0x4A0E100", VA = "0x4A0E100")]
    public void ApplyGuildFacilityType(List<GuildFacilityType> facilityList)
    {
    }

    [Token(Token = "0x60113B5")]
    [Address(RVA = "0x4A0E1CC", Offset = "0x4A0E1CC", VA = "0x4A0E1CC")]
    public void ApplyGuildFacilityLevelChanged(List<int> facilityLevelChangedList)
    {
    }

    [Token(Token = "0x60113B6")]
    [Address(RVA = "0x4A19A1C", Offset = "0x4A19A1C", VA = "0x4A19A1C")]
    public void ApplyGuildNewRequest(bool existNewRequest)
    {
    }

    [Token(Token = "0x60113B7")]
    [Address(RVA = "0x4A19A28", Offset = "0x4A19A28", VA = "0x4A19A28")]
    public void ApplyGuildIndexResponse(APIGuildIndexResponse apiGuildIndexResponse)
    {
    }

    [Token(Token = "0x60113B8")]
    [Address(RVA = "0x4A0BA3C", Offset = "0x4A0BA3C", VA = "0x4A0BA3C")]
    public void ApplyJoinRequestInfo(GuildJoinRequestType joinRequest)
    {
    }

    [Token(Token = "0x60113B9")]
    [Address(RVA = "0x4A19610", Offset = "0x4A19610", VA = "0x4A19610")]
    private void ShowToasterRoleNotification(GuildRoleTypeEnum newRole, GuildRoleTypeEnum oldRole)
    {
    }

    [Token(Token = "0x60113BA")]
    [Address(RVA = "0x4A19808", Offset = "0x4A19808", VA = "0x4A19808")]
    public void SaveGuildRole(GuildRoleTypeEnum role)
    {
    }

    [Token(Token = "0x60113BB")]
    [Address(RVA = "0x4A18DB8", Offset = "0x4A18DB8", VA = "0x4A18DB8")]
    public void DeleteGuildRole()
    {
    }

    [Token(Token = "0x60113BC")]
    [Address(RVA = "0x4A10DA8", Offset = "0x4A10DA8", VA = "0x4A10DA8")]
    public bool IsNeedPlayFacilityLevelupEffectEffect(int facilityId, int level) => new bool();

    [Token(Token = "0x60113BD")]
    [Address(RVA = "0x4A11D80", Offset = "0x4A11D80", VA = "0x4A11D80")]
    public void ChangeStatusFacilityLevelupEffectEffect(int facilityId, int level)
    {
    }

    [Token(Token = "0x60113BE")]
    [Address(RVA = "0x4A18EFC", Offset = "0x4A18EFC", VA = "0x4A18EFC")]
    public void JoinInitFacilityLevelupEffectEffect()
    {
    }

    [Token(Token = "0x60113BF")]
    [Address(RVA = "0x4A19ADC", Offset = "0x4A19ADC", VA = "0x4A19ADC")]
    public void NotJoinInitFacilityLevelupEffectEffect()
    {
    }

    [Token(Token = "0x60113C0")]
    [Address(RVA = "0x4A18DD4", Offset = "0x4A18DD4", VA = "0x4A18DD4")]
    public void ClearGuildLastConfirmationID()
    {
    }

    [Token(Token = "0x60113C1")]
    [Address(RVA = "0x4A1942C", Offset = "0x4A1942C", VA = "0x4A1942C")]
    public void SetGuildLastBulletinBoardID(string id)
    {
    }

    [Token(Token = "0x60113C2")]
    [Address(RVA = "0x4A19AF8", Offset = "0x4A19AF8", VA = "0x4A19AF8")]
    public void SetGuildLastChatMesageID(string id)
    {
    }

    [Token(Token = "0x60113C3")]
    [Address(RVA = "0x4A18BFC", Offset = "0x4A18BFC", VA = "0x4A18BFC")]
    public void ApplyGuildData(string lastBulletinBoardId, string lastChatMessageId)
    {
    }

    [Token(Token = "0x60113C4")]
    [Address(RVA = "0x4A19BC4", Offset = "0x4A19BC4", VA = "0x4A19BC4")]
    public void ApplyGuildChat(
      int chatActiveCount,
      List<GuildMemberType> members,
      List<GuildChatMessageType> logs)
    {
    }

    [Token(Token = "0x60113C5")]
    [Address(RVA = "0x4A19CE4", Offset = "0x4A19CE4", VA = "0x4A19CE4")]
    public void UpdateGuildChat(
      int chatActiveCount,
      List<GuildMemberType> members,
      List<GuildChatMessageType> logs)
    {
    }

    [Token(Token = "0x60113C6")]
    [Address(RVA = "0x4A19E68", Offset = "0x4A19E68", VA = "0x4A19E68")]
    public GuildDataManager()
    {
    }
  }
}
