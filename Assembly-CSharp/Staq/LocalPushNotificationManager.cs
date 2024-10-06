// Decompiled with JetBrains decompiler
// Type: staq.LocalPushNotificationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Expedition.Main;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C48")]
  public class LocalPushNotificationManager : SingletonMonoBehaviour<LocalPushNotificationManager>
  {
    [Token(Token = "0x4010B84")]
    private const int RE_FACTORIZE_INTERVAL_SECONDS = 300;
    [Token(Token = "0x4010B85")]
    private const int RE_FACTORIZE_LIMIT = 10;
    [Token(Token = "0x4010B86")]
    private const int PUSH_ID_AP_FULL_RECOVERY = 1;
    [Token(Token = "0x4010B87")]
    private const int PUSH_ID_FULL_EXPEDITION_BOX = 2;
    [Token(Token = "0x4010B88")]
    private const int PUSH_ID_FULL_FRAGMENT_POOL_BLUE = 3;
    [Token(Token = "0x4010B89")]
    private const int PUSH_ID_FULL_FRAGMENT_POOL_RED = 4;
    [Token(Token = "0x4010B8A")]
    public const int TEST_PUSH_ID_RE_FACTORIZE = 3;

    [Token(Token = "0x17004D33")]
    public bool ReFactorizeUpdate
    {
      [Token(Token = "0x6017B36"), Address(RVA = "0x238C78C", Offset = "0x238C78C", VA = "0x238C78C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6017B37"), Address(RVA = "0x238C794", Offset = "0x238C794", VA = "0x238C794")] set
      {
      }
    }

    [Token(Token = "0x6017B38")]
    [Address(RVA = "0x238C7A0", Offset = "0x238C7A0", VA = "0x238C7A0", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6017B39")]
    [Address(RVA = "0x238C7EC", Offset = "0x238C7EC", VA = "0x238C7EC")]
    public void SendApFullRecovery(int seconds)
    {
    }

    [Token(Token = "0x6017B3A")]
    [Address(RVA = "0x238C910", Offset = "0x238C910", VA = "0x238C910")]
    public void CancelApFullRecovery()
    {
    }

    [Token(Token = "0x6017B3B")]
    [Address(RVA = "0x238C960", Offset = "0x238C960", VA = "0x238C960")]
    public void SendFullExpenditionBox(ExpeditionTimeManager ExpeditionTimeManager)
    {
    }

    [Token(Token = "0x6017B3C")]
    [Address(RVA = "0x238CB04", Offset = "0x238CB04", VA = "0x238CB04")]
    public void SendFullFragmentPoolAll(List<PlayerExpeditionSoulSpotType> soulSpots)
    {
    }

    [Token(Token = "0x6017B3D")]
    [Address(RVA = "0x238CBEC", Offset = "0x238CBEC", VA = "0x238CBEC")]
    public void SendFullFragmentPool(int seconds, SoulTypeEnum soulType)
    {
    }

    [Token(Token = "0x6017B3E")]
    [Address(RVA = "0x238CBD0", Offset = "0x238CBD0", VA = "0x238CBD0")]
    private void SendFullFragmentPool(
      List<PlayerExpeditionSoulSpotType> soulSpots,
      SoulTypeEnum soulType)
    {
    }

    [Token(Token = "0x6017B3F")]
    [Address(RVA = "0x238CE9C", Offset = "0x238CE9C", VA = "0x238CE9C")]
    private int GetMaxFragmentPoolTime(
      List<PlayerExpeditionSoulSpotType> soulSpots,
      SoulTypeEnum soulType)
    {
      return new int();
    }

    [Token(Token = "0x6017B40")]
    [Address(RVA = "0x238D12C", Offset = "0x238D12C", VA = "0x238D12C")]
    public void CancelFullExpedition()
    {
    }

    [Token(Token = "0x6017B41")]
    [Address(RVA = "0x238D18C", Offset = "0x238D18C", VA = "0x238D18C")]
    public void SendReFactorize(int seconds, int characterId)
    {
    }

    [Token(Token = "0x6017B42")]
    [Address(RVA = "0x238D2C0", Offset = "0x238D2C0", VA = "0x238D2C0")]
    public void CancelReFactorize(int characterId)
    {
    }

    [Token(Token = "0x6017B43")]
    [Address(RVA = "0x238D314", Offset = "0x238D314", VA = "0x238D314")]
    private void Update()
    {
    }

    [Token(Token = "0x6017B44")]
    [Address(RVA = "0x238DB00", Offset = "0x238DB00", VA = "0x238DB00")]
    public void UpdateApFullRecovery()
    {
    }

    [Token(Token = "0x6017B45")]
    [Address(RVA = "0x238D334", Offset = "0x238D334", VA = "0x238D334")]
    private void UpdateReFactorize()
    {
    }

    [Token(Token = "0x6017B46")]
    [Address(RVA = "0x238DCB0", Offset = "0x238DCB0", VA = "0x238DCB0")]
    private (int, int) UpdateReFactorize(Character chara) => ();

    [Token(Token = "0x6017B47")]
    [Address(RVA = "0x238DEB8", Offset = "0x238DEB8", VA = "0x238DEB8")]
    public LocalPushNotificationManager()
    {
    }
  }
}
