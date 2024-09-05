// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery.Check;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x2003956")]
  public class ApRecoveryModel
  {
    [Token(Token = "0x400FA92")]
    [FieldOffset(Offset = "0x20")]
    private int _recoveryApNum;
    [Token(Token = "0x400FA93")]
    [FieldOffset(Offset = "0x28")]
    private RecoveryItemList _recoveryItemList;
    [Token(Token = "0x400FA94")]
    [FieldOffset(Offset = "0x30")]
    private bool _isOpenedCheckPopup;
    [Token(Token = "0x400FA95")]
    [FieldOffset(Offset = "0x34")]
    private PlayerStatusModel _prevStatus;

    [Token(Token = "0x17004A1D")]
    public PlayerStatusModel NowStatus
    {
      [Token(Token = "0x601688D"), Address(RVA = "0x42ED294", Offset = "0x42ED294", VA = "0x42ED294")] get
      {
        return new PlayerStatusModel();
      }
    }

    [Token(Token = "0x17004A1E")]
    public int NowAp
    {
      [Token(Token = "0x601688E"), Address(RVA = "0x42ED320", Offset = "0x42ED320", VA = "0x42ED320")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A1F")]
    public int CoinNumPaid
    {
      [Token(Token = "0x601688F"), Address(RVA = "0x42ED330", Offset = "0x42ED330", VA = "0x42ED330")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A20")]
    public int CoinNumFree
    {
      [Token(Token = "0x6016890"), Address(RVA = "0x42ED370", Offset = "0x42ED370", VA = "0x42ED370")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A21")]
    public int ItemNum
    {
      [Token(Token = "0x6016891"), Address(RVA = "0x42ED394", Offset = "0x42ED394", VA = "0x42ED394")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A22")]
    public int RecoveryAp
    {
      [Token(Token = "0x6016892"), Address(RVA = "0x42ED3B0", Offset = "0x42ED3B0", VA = "0x42ED3B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A23")]
    public int RecoveryUseItem
    {
      [Token(Token = "0x6016893"), Address(RVA = "0x42ED3B8", Offset = "0x42ED3B8", VA = "0x42ED3B8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A24")]
    public int RecoveryUseCoin
    {
      [Token(Token = "0x6016894"), Address(RVA = "0x42ED3C0", Offset = "0x42ED3C0", VA = "0x42ED3C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A25")]
    public Action<ApRecoveryModel.ApRecoveryViewInfo> OnUpdateRecoveryNum
    {
      [Token(Token = "0x6016895"), Address(RVA = "0x42ED460", Offset = "0x42ED460", VA = "0x42ED460")] get
      {
        return (Action<ApRecoveryModel.ApRecoveryViewInfo>) null;
      }
      [Token(Token = "0x6016896"), Address(RVA = "0x42ED468", Offset = "0x42ED468", VA = "0x42ED468")] set
      {
      }
    }

    [Token(Token = "0x17004A26")]
    public Action<string> OnMessage
    {
      [Token(Token = "0x6016897"), Address(RVA = "0x42ED470", Offset = "0x42ED470", VA = "0x42ED470")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x6016898"), Address(RVA = "0x42ED478", Offset = "0x42ED478", VA = "0x42ED478")] set
      {
      }
    }

    [Token(Token = "0x6016899")]
    [Address(RVA = "0x42ED480", Offset = "0x42ED480", VA = "0x42ED480")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601689A")]
    [Address(RVA = "0x42EDADC", Offset = "0x42EDADC", VA = "0x42EDADC")]
    public void OnUpdatedAp()
    {
    }

    [Token(Token = "0x601689B")]
    [Address(RVA = "0x42EDD98", Offset = "0x42EDD98", VA = "0x42EDD98")]
    public bool CanIncRecoverAp() => new bool();

    [Token(Token = "0x601689C")]
    [Address(RVA = "0x42EDE70", Offset = "0x42EDE70", VA = "0x42EDE70")]
    public void IncRecoveryAp()
    {
    }

    [Token(Token = "0x601689D")]
    [Address(RVA = "0x42EDE9C", Offset = "0x42EDE9C", VA = "0x42EDE9C")]
    public bool CanDecRecoverAp() => new bool();

    [Token(Token = "0x601689E")]
    [Address(RVA = "0x42EDEAC", Offset = "0x42EDEAC", VA = "0x42EDEAC")]
    public void DecRecoveryAp()
    {
    }

    [Token(Token = "0x601689F")]
    [Address(RVA = "0x42EDEC0", Offset = "0x42EDEC0", VA = "0x42EDEC0")]
    public IEnumerator RequestRecoveryByItemAsync(Action onSuccess = null, Action onError = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60168A0")]
    [Address(RVA = "0x42EDF64", Offset = "0x42EDF64", VA = "0x42EDF64")]
    public IEnumerator RequestOpenCheck(
      AssetCachedSpawner assetCachedSpawner,
      Action<CheckPopup> callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17004A27")]
    private PlayerConstData PlayerConst
    {
      [Token(Token = "0x60168A1"), Address(RVA = "0x42EDBA8", Offset = "0x42EDBA8", VA = "0x42EDBA8")] get
      {
        return (PlayerConstData) null;
      }
    }

    [Token(Token = "0x17004A28")]
    private PlayerProfile PlayerProfile
    {
      [Token(Token = "0x60168A2"), Address(RVA = "0x42ED4F8", Offset = "0x42ED4F8", VA = "0x42ED4F8")] get
      {
        return (PlayerProfile) null;
      }
    }

    [Token(Token = "0x17004A29")]
    private Player Player
    {
      [Token(Token = "0x60168A3"), Address(RVA = "0x42ED354", Offset = "0x42ED354", VA = "0x42ED354")] get
      {
        return (Player) null;
      }
    }

    [Token(Token = "0x60168A4")]
    [Address(RVA = "0x42EDC28", Offset = "0x42EDC28", VA = "0x42EDC28")]
    private void SetRecoveryAp(int recoveryAp)
    {
    }

    [Token(Token = "0x60168A5")]
    [Address(RVA = "0x42EE008", Offset = "0x42EE008", VA = "0x42EE008")]
    public ApRecoveryModel()
    {
    }

    [Token(Token = "0x2003957")]
    public struct ApRecoveryViewInfo
    {
      [Token(Token = "0x400FA96")]
      [FieldOffset(Offset = "0x0")]
      public int NowAp;
      [Token(Token = "0x400FA97")]
      [FieldOffset(Offset = "0x4")]
      public int RecoveryAp;
      [Token(Token = "0x400FA98")]
      [FieldOffset(Offset = "0x8")]
      public int UseItem;
      [Token(Token = "0x400FA99")]
      [FieldOffset(Offset = "0xC")]
      public int UseCoin;
      [Token(Token = "0x400FA9A")]
      [FieldOffset(Offset = "0x10")]
      public bool CanIncRecoveryAp;
      [Token(Token = "0x400FA9B")]
      [FieldOffset(Offset = "0x11")]
      public bool CanDecRecoveryAp;
      [Token(Token = "0x400FA9C")]
      [FieldOffset(Offset = "0x12")]
      public bool CanReoveryItem;
    }
  }
}
