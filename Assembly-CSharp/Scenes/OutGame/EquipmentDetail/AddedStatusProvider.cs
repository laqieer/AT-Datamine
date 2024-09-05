// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.AddedStatusProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using StaqData;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003670")]
  public class AddedStatusProvider
  {
    [Token(Token = "0x400ECDB")]
    private const string AssetBundleName = "ui_page_equipdetail";
    [Token(Token = "0x400ECDC")]
    private const string AssetName = "Container_WeaponDetail_AddedStatus";

    [Token(Token = "0x60156D3")]
    [Address(RVA = "0x18E06A0", Offset = "0x18E06A0", VA = "0x18E06A0")]
    public static void Request(Equipment equipmentData, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x60156D4")]
    [Address(RVA = "0x18E06AC", Offset = "0x18E06AC", VA = "0x18E06AC")]
    public static void Request(
      Equipment equipmentData,
      Equipment assumption,
      IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x60156D5")]
    [Address(RVA = "0x18E0890", Offset = "0x18E0890", VA = "0x18E0890")]
    public AddedStatusProvider()
    {
    }
  }
}
