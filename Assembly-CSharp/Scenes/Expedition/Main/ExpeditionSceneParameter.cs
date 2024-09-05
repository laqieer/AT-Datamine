// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.ExpeditionSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.Expedition.Boss.BattleResult;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002CBA")]
  public sealed class ExpeditionSceneParameter : ChangeSceneParameter
  {
    [Token(Token = "0x400BF37")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x400BF38")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerType beforePlayer;
    [Token(Token = "0x400BF39")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerExpeditionType playerExpedition;
    [Token(Token = "0x400BF3A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerExpeditionStageType> playerExpeditionStages;
    [Token(Token = "0x400BF3B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerExpeditionPartyType> playerExpeditionParties;
    [Token(Token = "0x400BF3C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerUnitCharacterType> playerUnitCharacters;
    [Token(Token = "0x400BF3D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitCharacterType> beforePlayerUnitCharacters;
    [Token(Token = "0x400BF3E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerExpeditionSoulTankType> playerExpeditionSoulTanks;
    [Token(Token = "0x400BF3F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerExpeditionSoulSpotType> playerExpeditionSoulSpots;
    [Token(Token = "0x400BF40")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerExpeditionBoxType> playerExpeditionBoxes;
    [Token(Token = "0x400BF41")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerUnitType> beforePlayerUnits;
    [Token(Token = "0x400BF42")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<PlayerSoulType> playerSouls;
    [Token(Token = "0x400BF43")]
    [FieldOffset(Offset = "0x78")]
    public Dictionary<int, int> PlayerSoulsDic;
    [Token(Token = "0x400BF44")]
    [FieldOffset(Offset = "0x80")]
    public Dictionary<int, int> BeforePlayerSoulsDic;
    [Token(Token = "0x400BF45")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private List<int> playerExpeditionBoxRewardIds;
    [Token(Token = "0x400BF46")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private APIExpeditionResponse expeditionApiResponse;

    [Token(Token = "0x17003C2F")]
    public PlayerType Player
    {
      [Token(Token = "0x60117E5"), Address(RVA = "0x4942EF4", Offset = "0x4942EF4", VA = "0x4942EF4")] get
      {
        return (PlayerType) null;
      }
      [Token(Token = "0x60117E6"), Address(RVA = "0x4942EFC", Offset = "0x4942EFC", VA = "0x4942EFC")] set
      {
      }
    }

    [Token(Token = "0x17003C30")]
    public PlayerType BeforePlayer
    {
      [Token(Token = "0x60117E7"), Address(RVA = "0x4942F04", Offset = "0x4942F04", VA = "0x4942F04")] get
      {
        return (PlayerType) null;
      }
      [Token(Token = "0x60117E8"), Address(RVA = "0x4942F0C", Offset = "0x4942F0C", VA = "0x4942F0C")] set
      {
      }
    }

    [Token(Token = "0x17003C31")]
    public PlayerExpeditionType PlayerExpedition
    {
      [Token(Token = "0x60117E9"), Address(RVA = "0x4942F14", Offset = "0x4942F14", VA = "0x4942F14")] get
      {
        return (PlayerExpeditionType) null;
      }
      [Token(Token = "0x60117EA"), Address(RVA = "0x4942F1C", Offset = "0x4942F1C", VA = "0x4942F1C")] set
      {
      }
    }

    [Token(Token = "0x17003C32")]
    public List<PlayerExpeditionStageType> PlayerExpeditionStages
    {
      [Token(Token = "0x60117EB"), Address(RVA = "0x4942F24", Offset = "0x4942F24", VA = "0x4942F24")] get
      {
        return (List<PlayerExpeditionStageType>) null;
      }
      [Token(Token = "0x60117EC"), Address(RVA = "0x4942F2C", Offset = "0x4942F2C", VA = "0x4942F2C")] set
      {
      }
    }

    [Token(Token = "0x17003C33")]
    public List<PlayerExpeditionPartyType> PlayerExpeditionParties
    {
      [Token(Token = "0x60117ED"), Address(RVA = "0x4942F34", Offset = "0x4942F34", VA = "0x4942F34")] get
      {
        return (List<PlayerExpeditionPartyType>) null;
      }
      [Token(Token = "0x60117EE"), Address(RVA = "0x4942F3C", Offset = "0x4942F3C", VA = "0x4942F3C")] set
      {
      }
    }

    [Token(Token = "0x17003C34")]
    public List<PlayerUnitCharacterType> PlayerUnitCharacters
    {
      [Token(Token = "0x60117EF"), Address(RVA = "0x4942F44", Offset = "0x4942F44", VA = "0x4942F44")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x60117F0"), Address(RVA = "0x4942F4C", Offset = "0x4942F4C", VA = "0x4942F4C")] set
      {
      }
    }

    [Token(Token = "0x17003C35")]
    public List<PlayerUnitCharacterType> BeforePlayerUnitCharacters
    {
      [Token(Token = "0x60117F1"), Address(RVA = "0x4942F54", Offset = "0x4942F54", VA = "0x4942F54")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x60117F2"), Address(RVA = "0x4942F5C", Offset = "0x4942F5C", VA = "0x4942F5C")] set
      {
      }
    }

    [Token(Token = "0x17003C36")]
    public List<PlayerExpeditionSoulTankType> PlayerExpeditionSoulTanks
    {
      [Token(Token = "0x60117F3"), Address(RVA = "0x4942F64", Offset = "0x4942F64", VA = "0x4942F64")] get
      {
        return (List<PlayerExpeditionSoulTankType>) null;
      }
      [Token(Token = "0x60117F4"), Address(RVA = "0x4942F6C", Offset = "0x4942F6C", VA = "0x4942F6C")] set
      {
      }
    }

    [Token(Token = "0x17003C37")]
    public List<PlayerExpeditionSoulSpotType> PlayerExpeditionSoulSpots
    {
      [Token(Token = "0x60117F5"), Address(RVA = "0x4942F74", Offset = "0x4942F74", VA = "0x4942F74")] get
      {
        return (List<PlayerExpeditionSoulSpotType>) null;
      }
      [Token(Token = "0x60117F6"), Address(RVA = "0x4942F7C", Offset = "0x4942F7C", VA = "0x4942F7C")] set
      {
      }
    }

    [Token(Token = "0x17003C38")]
    public List<PlayerExpeditionBoxType> PlayerExpeditionBoxes
    {
      [Token(Token = "0x60117F7"), Address(RVA = "0x494300C", Offset = "0x494300C", VA = "0x494300C")] get
      {
        return (List<PlayerExpeditionBoxType>) null;
      }
      [Token(Token = "0x60117F8"), Address(RVA = "0x4943014", Offset = "0x4943014", VA = "0x4943014")] set
      {
      }
    }

    [Token(Token = "0x17003C39")]
    public List<PlayerUnitType> BeforePlayerUnits
    {
      [Token(Token = "0x60117F9"), Address(RVA = "0x494301C", Offset = "0x494301C", VA = "0x494301C")] get
      {
        return (List<PlayerUnitType>) null;
      }
      [Token(Token = "0x60117FA"), Address(RVA = "0x4943024", Offset = "0x4943024", VA = "0x4943024")] set
      {
      }
    }

    [Token(Token = "0x17003C3A")]
    public List<PlayerSoulType> PlayerSouls
    {
      [Token(Token = "0x60117FB"), Address(RVA = "0x494302C", Offset = "0x494302C", VA = "0x494302C")] get
      {
        return (List<PlayerSoulType>) null;
      }
      [Token(Token = "0x60117FC"), Address(RVA = "0x4943034", Offset = "0x4943034", VA = "0x4943034")] set
      {
      }
    }

    [Token(Token = "0x17003C3B")]
    public List<int> PlayerExpeditionBoxRewardIds
    {
      [Token(Token = "0x60117FD"), Address(RVA = "0x494303C", Offset = "0x494303C", VA = "0x494303C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x60117FE"), Address(RVA = "0x4943044", Offset = "0x4943044", VA = "0x4943044")] set
      {
      }
    }

    [Token(Token = "0x17003C3C")]
    public APIExpeditionResponse ExpeditionApiResponse
    {
      [Token(Token = "0x60117FF"), Address(RVA = "0x494304C", Offset = "0x494304C", VA = "0x494304C")] get
      {
        return (APIExpeditionResponse) null;
      }
      [Token(Token = "0x6011800"), Address(RVA = "0x4943054", Offset = "0x4943054", VA = "0x4943054")] set
      {
      }
    }

    [Token(Token = "0x17003C3D")]
    public bool WonBossBattle
    {
      [Token(Token = "0x6011801"), Address(RVA = "0x494305C", Offset = "0x494305C", VA = "0x494305C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011802"), Address(RVA = "0x4943064", Offset = "0x4943064", VA = "0x4943064")] set
      {
      }
    }

    [Token(Token = "0x17003C3E")]
    public ExpeditionBossBattleWinData ExpeditionBossBattleWinData
    {
      [Token(Token = "0x6011803"), Address(RVA = "0x4943070", Offset = "0x4943070", VA = "0x4943070")] get
      {
        return (ExpeditionBossBattleWinData) null;
      }
      [Token(Token = "0x6011804"), Address(RVA = "0x4943078", Offset = "0x4943078", VA = "0x4943078")] set
      {
      }
    }

    [Token(Token = "0x17003C3F")]
    public ExpeditionBossBattleLoseData ExpeditionBossBattleLoseData
    {
      [Token(Token = "0x6011805"), Address(RVA = "0x4943080", Offset = "0x4943080", VA = "0x4943080")] get
      {
        return (ExpeditionBossBattleLoseData) null;
      }
      [Token(Token = "0x6011806"), Address(RVA = "0x4943088", Offset = "0x4943088", VA = "0x4943088")] set
      {
      }
    }

    [Token(Token = "0x17003C40")]
    public bool IsChangedStage
    {
      [Token(Token = "0x6011807"), Address(RVA = "0x4943090", Offset = "0x4943090", VA = "0x4943090")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011808"), Address(RVA = "0x4943098", Offset = "0x4943098", VA = "0x4943098")] set
      {
      }
    }

    [Token(Token = "0x17003C41")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x6011809"), Address(RVA = "0x49430A4", Offset = "0x49430A4", VA = "0x49430A4")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x601180A"), Address(RVA = "0x49430AC", Offset = "0x49430AC", VA = "0x49430AC")] private set
      {
      }
    }

    [Token(Token = "0x17003C42")]
    public int SelectPartyNo
    {
      [Token(Token = "0x601180B"), Address(RVA = "0x49430B4", Offset = "0x49430B4", VA = "0x49430B4")] get
      {
        return new int();
      }
      [Token(Token = "0x601180C"), Address(RVA = "0x49430BC", Offset = "0x49430BC", VA = "0x49430BC")] set
      {
      }
    }

    [Token(Token = "0x17003C43")]
    public int? RequestBossStage
    {
      [Token(Token = "0x601180D"), Address(RVA = "0x49430C4", Offset = "0x49430C4", VA = "0x49430C4")] get
      {
        return new int?();
      }
      [Token(Token = "0x601180E"), Address(RVA = "0x49430CC", Offset = "0x49430CC", VA = "0x49430CC")] set
      {
      }
    }

    [Token(Token = "0x601180F")]
    [Address(RVA = "0x49430D4", Offset = "0x49430D4", VA = "0x49430D4")]
    public ExpeditionSceneParameter(APIExpeditionResponse response, int? requestBossStage = null)
    {
    }

    [Token(Token = "0x6011810")]
    [Address(RVA = "0x49438E0", Offset = "0x49438E0", VA = "0x49438E0")]
    public void SetAssetCachedSpawner(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6011811")]
    [Address(RVA = "0x494060C", Offset = "0x494060C", VA = "0x494060C")]
    public void SetAPIExpeditionPartyEditResponse(APIExpeditionPartyEditResponse response)
    {
    }

    [Token(Token = "0x6011812")]
    [Address(RVA = "0x4940E54", Offset = "0x4940E54", VA = "0x4940E54")]
    public void SetAPIExpeditionPartyStageChangeResponse(
      APIExpeditionPartyStageChangeResponse response)
    {
    }

    [Token(Token = "0x6011813")]
    [Address(RVA = "0x493FF34", Offset = "0x493FF34", VA = "0x493FF34")]
    public void SetAPIExpeditionBossPartyEditResponse(
      PlayerExpeditionStageType playerExpeditionStageType,
      APIExpeditionStageBossPartyEditResponse response)
    {
    }

    [Token(Token = "0x6011814")]
    [Address(RVA = "0x4944B28", Offset = "0x4944B28", VA = "0x4944B28")]
    public void SetAPIExpeditionBoxOpenResponse(APIExpeditionBoxOpenResponse response)
    {
    }

    [Token(Token = "0x6011815")]
    [Address(RVA = "0x494092C", Offset = "0x494092C", VA = "0x494092C")]
    public void SetAPIExpeditionPartySlotReleaseResponse(
      APIExpeditionPartySlotReleaseResponse response)
    {
    }

    [Token(Token = "0x6011816")]
    [Address(RVA = "0x4944F50", Offset = "0x4944F50", VA = "0x4944F50")]
    public void SetAPIExpeditionRapidResponse(APIExpeditionRapidResponse response)
    {
    }

    [Token(Token = "0x6011817")]
    [Address(RVA = "0x494513C", Offset = "0x494513C", VA = "0x494513C")]
    public void SetAPIExpeditionSoulLevelUpResponse(APIExpeditionSoul_spotLevel_upResponse response)
    {
    }

    [Token(Token = "0x6011818")]
    [Address(RVA = "0x49453A0", Offset = "0x49453A0", VA = "0x49453A0")]
    public void SetAPIExpeditionBoxLevelUpResponse(APIExpeditionBoxLevel_upResponse response)
    {
    }

    [Token(Token = "0x6011819")]
    [Address(RVA = "0x49453D4", Offset = "0x49453D4", VA = "0x49453D4")]
    public void SetExpeditionBossBattleResult(
      bool isWin,
      ExpeditionBossBattleWinData winData,
      ExpeditionBossBattleLoseData loseData)
    {
    }

    [Token(Token = "0x601181A")]
    [Address(RVA = "0x4945AE0", Offset = "0x4945AE0", VA = "0x4945AE0")]
    private void UpdateBeforePlayerUnits(List<PlayerUnitType> beforePlayerUnits)
    {
    }

    [Token(Token = "0x601181B")]
    [Address(RVA = "0x49457FC", Offset = "0x49457FC", VA = "0x49457FC")]
    private void UpdatePlayerUnitCharacter(PlayerUnitCharacterType playerUnitCharacter)
    {
    }

    [Token(Token = "0x601181C")]
    [Address(RVA = "0x49460C0", Offset = "0x49460C0", VA = "0x49460C0")]
    private bool CreatePlayerUnitCharacter(PlayerUnitCharacterType playerUnitCharacter)
    {
      return new bool();
    }

    [Token(Token = "0x601181D")]
    [Address(RVA = "0x49458F0", Offset = "0x49458F0", VA = "0x49458F0")]
    private void UpdateBeforePlayerUnitCharacters(
      List<PlayerUnitCharacterType> beforePlayerUnitCharacters)
    {
    }

    [Token(Token = "0x601181E")]
    [Address(RVA = "0x4943438", Offset = "0x4943438", VA = "0x4943438")]
    private void SetPlayerSouls(List<PlayerSoulType> playerSouls)
    {
    }

    [Token(Token = "0x601181F")]
    [Address(RVA = "0x4944D4C", Offset = "0x4944D4C", VA = "0x4944D4C")]
    private void UpdatePlayerSoulsDic(List<PlayerSoulType> playerSouls)
    {
    }

    [Token(Token = "0x6011820")]
    [Address(RVA = "0x494626C", Offset = "0x494626C", VA = "0x494626C")]
    private void UpdateBeforePlayerSoulsDic(PlayerSoulType playerSoul)
    {
    }

    [Token(Token = "0x6011821")]
    [Address(RVA = "0x494635C", Offset = "0x494635C", VA = "0x494635C")]
    public int GetPlayerSoulAmount(int itemId) => new int();

    [Token(Token = "0x6011822")]
    [Address(RVA = "0x4945CD0", Offset = "0x4945CD0", VA = "0x4945CD0")]
    private void UpdateRedSoulTank(List<PlayerSoulType> playerSouls)
    {
    }
  }
}
