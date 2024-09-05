// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.ExpeditionScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Expedition;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Expedition.Popup;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002CC1")]
  public class ExpeditionScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x400BF59")]
    private const string BGM_NAME = "STAQ_BGM_Abandoned_expedition";
    [Token(Token = "0x400BF5A")]
    [FieldOffset(Offset = "0x58")]
    private ExpeditionSceneParameter expeditionSceneParameter;
    [Token(Token = "0x400BF5B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ExpeditionBattle expeditionBattle;
    [Token(Token = "0x400BF5D")]
    [FieldOffset(Offset = "0x70")]
    private ExpeditionBonusInfoPopup popupExpeditionBonusInfo;

    [Token(Token = "0x17003C44")]
    public ExpeditionTimeManager ExpeditionTimeManager
    {
      [Token(Token = "0x6011833"), Address(RVA = "0x4946648", Offset = "0x4946648", VA = "0x4946648")] get
      {
        return (ExpeditionTimeManager) null;
      }
      [Token(Token = "0x6011834"), Address(RVA = "0x4946650", Offset = "0x4946650", VA = "0x4946650")] private set
      {
      }
    }

    [Token(Token = "0x6011835")]
    [Address(RVA = "0x4946658", Offset = "0x4946658", VA = "0x4946658", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6011836")]
    [Address(RVA = "0x4946858", Offset = "0x4946858", VA = "0x4946858", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011837")]
    [Address(RVA = "0x49468E8", Offset = "0x49468E8", VA = "0x49468E8")]
    public void CreateStage(ExpeditionBattle.BattleParameter param, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6011838")]
    [Address(RVA = "0x4946904", Offset = "0x4946904", VA = "0x4946904")]
    public void StartNormalExpedtionBattle(int partyNo, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6011839")]
    [Address(RVA = "0x4939870", Offset = "0x4939870", VA = "0x4939870")]
    public static ExpeditionScene ActiveScene() => (ExpeditionScene) null;

    [Token(Token = "0x601183A")]
    [Address(RVA = "0x4946F54", Offset = "0x4946F54", VA = "0x4946F54")]
    public ExpeditionSceneParameter GetParameter() => (ExpeditionSceneParameter) null;

    [Token(Token = "0x601183B")]
    [Address(RVA = "0x4946F5C", Offset = "0x4946F5C", VA = "0x4946F5C")]
    public ExpeditionBattle GetBattle() => (ExpeditionBattle) null;

    [Token(Token = "0x601183C")]
    [Address(RVA = "0x4946F64", Offset = "0x4946F64", VA = "0x4946F64")]
    public Sprite GetSpriteFromAtlas(string assetBundleName, string atlasName, string assetName)
    {
      return (Sprite) null;
    }

    [Token(Token = "0x601183D")]
    [Address(RVA = "0x49470AC", Offset = "0x49470AC", VA = "0x49470AC")]
    public Sprite GetSprite(string assetBundleName, string assetName) => (Sprite) null;

    [Token(Token = "0x601183E")]
    [Address(RVA = "0x4947150", Offset = "0x4947150", VA = "0x4947150")]
    private void SetupSoulProductionManager()
    {
    }

    [Token(Token = "0x601183F")]
    [Address(RVA = "0x49472DC", Offset = "0x49472DC", VA = "0x49472DC")]
    public void ShowExpeditionBonusInfoPopup(BonusType bonusType)
    {
    }

    [Token(Token = "0x6011840")]
    [Address(RVA = "0x494753C", Offset = "0x494753C", VA = "0x494753C")]
    public void ChangeCameraAngle()
    {
    }

    [Token(Token = "0x6011841")]
    [Address(RVA = "0x4947558", Offset = "0x4947558", VA = "0x4947558")]
    public void SwitchGridVisible()
    {
    }

    [Token(Token = "0x6011842")]
    [Address(RVA = "0x4947574", Offset = "0x4947574", VA = "0x4947574")]
    public int CurrentSelectPartyNo() => new int();

    [Token(Token = "0x6011843")]
    [Address(RVA = "0x49478A0", Offset = "0x49478A0", VA = "0x49478A0")]
    private bool CheckEmptyParty(List<PlayerExpeditionPartyCharacterType> party) => new bool();

    [Token(Token = "0x6011844")]
    [Address(RVA = "0x4947718", Offset = "0x4947718", VA = "0x4947718")]
    private int GetUnitSetPartyNo() => new int();

    [Token(Token = "0x6011845")]
    [Address(RVA = "0x4947A00", Offset = "0x4947A00", VA = "0x4947A00")]
    public int CurrentNormalBattlePartyNo() => new int();

    [Token(Token = "0x6011846")]
    [Address(RVA = "0x4947A1C", Offset = "0x4947A1C", VA = "0x4947A1C")]
    public float GetRateSoulGauge(SoulTypeEnum soulType, int storage) => new float();

    [Token(Token = "0x6011847")]
    [Address(RVA = "0x4947A4C", Offset = "0x4947A4C", VA = "0x4947A4C")]
    public ExpeditionSoulTankData GetSoulTankData(SoulTypeEnum soulType, int storage)
    {
      return (ExpeditionSoulTankData) null;
    }

    [Token(Token = "0x6011848")]
    [Address(RVA = "0x4947D84", Offset = "0x4947D84", VA = "0x4947D84", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6011849")]
    [Address(RVA = "0x4947DA8", Offset = "0x4947DA8", VA = "0x4947DA8")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x601184A")]
    [Address(RVA = "0x4947DB4", Offset = "0x4947DB4", VA = "0x4947DB4")]
    public ExpeditionScene()
    {
    }
  }
}
