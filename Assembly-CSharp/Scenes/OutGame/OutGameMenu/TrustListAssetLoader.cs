// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.TrustListAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003993")]
  public class TrustListAssetLoader : EquipmentListAssetLoaderBase
  {
    [Token(Token = "0x60169FE")]
    [Address(RVA = "0x42F6A60", Offset = "0x42F6A60", VA = "0x42F6A60")]
    public TrustListAssetLoader(AssetCachedSpawner assetLoader)
    {
    }

    [Token(Token = "0x60169FF")]
    [Address(RVA = "0x42F6A88", Offset = "0x42F6A88", VA = "0x42F6A88", Slot = "10")]
    public override string ThumbnailAssetBundleName(Equipment equipment) => (string) null;

    [Token(Token = "0x6016A00")]
    [Address(RVA = "0x42F6AA4", Offset = "0x42F6AA4", VA = "0x42F6AA4", Slot = "11")]
    public override string ThumbnailAssetName(Equipment equipment) => (string) null;
  }
}
