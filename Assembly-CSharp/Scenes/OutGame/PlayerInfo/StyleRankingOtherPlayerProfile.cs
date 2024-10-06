// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.StyleRankingOtherPlayerProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.StyleRanking;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo
{
  [Token(Token = "0x200349E")]
  public class StyleRankingOtherPlayerProfile : MonoBehaviour
  {
    [Token(Token = "0x400E4E6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UISafeAreaInsets safeArea;
    [Token(Token = "0x400E4E7")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E4E8")]
    [FieldOffset(Offset = "0x28")]
    private RankingPlayerProfile playerProfile;

    [Token(Token = "0x6014A44")]
    [Address(RVA = "0x1D62D08", Offset = "0x1D62D08", VA = "0x1D62D08")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner srcAssetCachedSpawner,
      Action<bool> setOperationPossible,
      Action onClose,
      int combatPower,
      PlayerRankingProfileType otherPlayerProfileInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014A45")]
    [Address(RVA = "0x1D62DD0", Offset = "0x1D62DD0", VA = "0x1D62DD0")]
    public void Open()
    {
    }

    [Token(Token = "0x6014A46")]
    [Address(RVA = "0x1D62E10", Offset = "0x1D62E10", VA = "0x1D62E10")]
    public void Close()
    {
    }

    [Token(Token = "0x6014A47")]
    [Address(RVA = "0x1D62E2C", Offset = "0x1D62E2C", VA = "0x1D62E2C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014A48")]
    [Address(RVA = "0x1D62ED0", Offset = "0x1D62ED0", VA = "0x1D62ED0")]
    public StyleRankingOtherPlayerProfile()
    {
    }
  }
}
