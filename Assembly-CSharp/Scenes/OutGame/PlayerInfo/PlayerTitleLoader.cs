// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerTitleLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using GameCore.DLC;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.TitleEmblem;
using StaqData;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo
{
  [Token(Token = "0x200349B")]
  public class PlayerTitleLoader : ITitleLoader
  {
    [Token(Token = "0x400E4DE")]
    private const string AssetBundleNameParentPart = "2dassets_ui_playertitle";

    [Token(Token = "0x6014A2B")]
    [Address(RVA = "0x1D61EDC", Offset = "0x1D61EDC", VA = "0x1D61EDC")]
    private static string BuildFrameSpriteAssetBundleName(int spriteId) => (string) null;

    [Token(Token = "0x6014A2C")]
    [Address(RVA = "0x1D61F7C", Offset = "0x1D61F7C", VA = "0x1D61F7C")]
    private static string BuildTextImageSpriteAssetBundleName(int spriteId) => (string) null;

    [Token(Token = "0x6014A2D")]
    [Address(RVA = "0x1D6201C", Offset = "0x1D6201C", VA = "0x1D6201C")]
    private static string BuildFullSetSpriteAssetBundleName(int spriteId) => (string) null;

    [Token(Token = "0x6014A2E")]
    [Address(RVA = "0x1D620BC", Offset = "0x1D620BC", VA = "0x1D620BC")]
    private static string BuildFrameSpriteAssetName(int spriteId) => (string) null;

    [Token(Token = "0x6014A2F")]
    [Address(RVA = "0x1D6213C", Offset = "0x1D6213C", VA = "0x1D6213C")]
    private static string BuildTextImageSpriteAssetName(int spriteId) => (string) null;

    [Token(Token = "0x6014A30")]
    [Address(RVA = "0x1D621BC", Offset = "0x1D621BC", VA = "0x1D621BC")]
    private static string BuildFullSetSpriteAssetName(int spriteId) => (string) null;

    [Token(Token = "0x17004486")]
    public AsyncAssetLoader AssetLoader
    {
      [Token(Token = "0x6014A31"), Address(RVA = "0x1D6223C", Offset = "0x1D6223C", VA = "0x1D6223C")] get
      {
        return (AsyncAssetLoader) null;
      }
    }

    [Token(Token = "0x6014A32")]
    [Address(RVA = "0x1D62244", Offset = "0x1D62244", VA = "0x1D62244")]
    public PlayerTitleLoader(AsyncAssetLoader assetLoader = null)
    {
    }

    [Token(Token = "0x6014A33")]
    [Address(RVA = "0x1D622BC", Offset = "0x1D622BC", VA = "0x1D622BC")]
    private static ITitleMasterData Get(int titleId) => (ITitleMasterData) null;

    [Token(Token = "0x6014A34")]
    [Address(RVA = "0x1D62358", Offset = "0x1D62358", VA = "0x1D62358", Slot = "6")]
    public ITitleMasterData GetTitleMaster(int titleId) => (ITitleMasterData) null;

    [Token(Token = "0x6014A35")]
    [Address(RVA = "0x1D62360", Offset = "0x1D62360", VA = "0x1D62360", Slot = "4")]
    public bool IsUnlocked(int titleId) => new bool();

    [Token(Token = "0x6014A36")]
    [Address(RVA = "0x1D623D8", Offset = "0x1D623D8", VA = "0x1D623D8", Slot = "5")]
    public UniTask<Sprite> LoadSpriteAsync(int titleId, CancellationToken cancellationToken)
    {
      return new UniTask<Sprite>();
    }

    [Token(Token = "0x6014A37")]
    [Address(RVA = "0x1D62590", Offset = "0x1D62590", VA = "0x1D62590", Slot = "7")]
    public IEnumerable<ITitleMasterData> GetAllMasters() => (IEnumerable<ITitleMasterData>) null;

    [Token(Token = "0x6014A38")]
    [Address(RVA = "0x1D62610", Offset = "0x1D62610", VA = "0x1D62610")]
    public static TitleSet ToTitleSet(IPlayerTitleInfo titleData) => new TitleSet();

    [Token(Token = "0x6014A39")]
    [Address(RVA = "0x1D627A4", Offset = "0x1D627A4", VA = "0x1D627A4")]
    public static IEnumerable<string> GetDependencyAssetBundleNames(IPlayerTitleInfo titleData)
    {
      return (IEnumerable<string>) null;
    }
  }
}
