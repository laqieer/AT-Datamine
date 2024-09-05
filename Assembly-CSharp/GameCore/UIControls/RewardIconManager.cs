// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.RewardIconManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C08")]
  public class RewardIconManager : SingletonMonoBehaviour<RewardIconManager>
  {
    [Token(Token = "0x4003697")]
    [FieldOffset(Offset = "0x0")]
    private static string THUMB_AB;
    [Token(Token = "0x4003698")]
    [FieldOffset(Offset = "0x8")]
    private static string ITEM_THUMB;
    [Token(Token = "0x4003699")]
    [FieldOffset(Offset = "0x10")]
    private static string STYLE_THUMB;
    [Token(Token = "0x400369A")]
    [FieldOffset(Offset = "0x18")]
    private static string MINDEQUIP_THUMB;
    [Token(Token = "0x400369B")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x60044F4")]
    [Address(RVA = "0x364D9A4", Offset = "0x364D9A4", VA = "0x364D9A4")]
    private void Start()
    {
    }

    [Token(Token = "0x60044F5")]
    [Address(RVA = "0x364DA04", Offset = "0x364DA04", VA = "0x364DA04")]
    private void Update()
    {
    }

    [Token(Token = "0x60044F6")]
    [Address(RVA = "0x364DA1C", Offset = "0x364DA1C", VA = "0x364DA1C")]
    public void SetUp()
    {
    }

    [Token(Token = "0x60044F7")]
    [Address(RVA = "0x364DAF4", Offset = "0x364DAF4", VA = "0x364DAF4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60044F8")]
    [Address(RVA = "0x364BEA8", Offset = "0x364BEA8", VA = "0x364BEA8")]
    public void CreateRewardIcon(
      RewardTypeEnum rewardType,
      int rewardId,
      int rewardAmount,
      Transform parent,
      bool showAmount = true,
      bool showNew = false,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60044F9")]
    [Address(RVA = "0x364DDA4", Offset = "0x364DDA4", VA = "0x364DDA4")]
    private void CreateItemIcon(
      ItemUtility.Parameter param,
      int rewardAmount,
      Transform parent,
      bool showAmount,
      bool showNew,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60044FA")]
    [Address(RVA = "0x364DC5C", Offset = "0x364DC5C", VA = "0x364DC5C")]
    private void CreateStyleThumb(
      int rewardId,
      int rewardAmount,
      Transform parent,
      bool showAmount,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60044FB")]
    [Address(RVA = "0x364DB0C", Offset = "0x364DB0C", VA = "0x364DB0C")]
    private void CreateMindIcon(
      int rewardId,
      int rewardAmount,
      Transform parent,
      bool showAmount,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60044FC")]
    [Address(RVA = "0x364BD3C", Offset = "0x364BD3C", VA = "0x364BD3C")]
    public void CreateRewardIconByItemParam(
      ItemUtility.Parameter param,
      int rewardAmount,
      Transform parent,
      bool showAmount,
      bool showNew = false,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60044FD")]
    [Address(RVA = "0x364DF30", Offset = "0x364DF30", VA = "0x364DF30")]
    public RewardIconManager()
    {
    }

    [Token(Token = "0x60044FE")]
    [Address(RVA = "0x364DF78", Offset = "0x364DF78", VA = "0x364DF78")]
    static RewardIconManager()
    {
    }
  }
}
