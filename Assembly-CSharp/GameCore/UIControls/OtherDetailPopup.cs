// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.OtherDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C05")]
  public static class OtherDetailPopup
  {
    [Token(Token = "0x4003690")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string ASSET_BUNDLE_NAME;
    [Token(Token = "0x4003691")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string ASSET_NAME;

    [Token(Token = "0x60044EC")]
    [Address(RVA = "0x364D45C", Offset = "0x364D45C", VA = "0x364D45C")]
    public static bool UseOtherDetailPopup(RewardTypeEnum rewardType) => new bool();

    [Token(Token = "0x60044ED")]
    [Address(RVA = "0x364D490", Offset = "0x364D490", VA = "0x364D490")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60044EE")]
    [Address(RVA = "0x364D510", Offset = "0x364D510", VA = "0x364D510")]
    public static void OpenOtherDetailPopup(
      RewardTypeEnum rewardType,
      int rewardId,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60044EF")]
    [Address(RVA = "0x364D698", Offset = "0x364D698", VA = "0x364D698")]
    static OtherDetailPopup()
    {
    }
  }
}
