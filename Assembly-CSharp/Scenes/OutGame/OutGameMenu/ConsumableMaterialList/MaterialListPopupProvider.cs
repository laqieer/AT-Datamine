// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.MaterialListPopupProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using UI.ItemDetail;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BF3")]
  public class MaterialListPopupProvider
  {
    [Token(Token = "0x4010997")]
    [FieldOffset(Offset = "0x10")]
    private ConsumableMaterialListBase list;
    [Token(Token = "0x4010998")]
    [FieldOffset(Offset = "0x18")]
    private readonly Generator generator;
    [Token(Token = "0x4010999")]
    [FieldOffset(Offset = "0x20")]
    private readonly ItemDetailPopupProvider itemDetailPopupProvider;
    [Token(Token = "0x401099A")]
    [FieldOffset(Offset = "0x28")]
    private readonly AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x401099B")]
    [FieldOffset(Offset = "0x30")]
    private bool inProcessingOpenOrClose;

    [Token(Token = "0x17004C89")]
    public bool IsOpened
    {
      [Token(Token = "0x6017904"), Address(RVA = "0x237B470", Offset = "0x237B470", VA = "0x237B470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017905")]
    [Address(RVA = "0x237B4F8", Offset = "0x237B4F8", VA = "0x237B4F8")]
    public MaterialListPopupProvider(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6017906")]
    [Address(RVA = "0x237B5A8", Offset = "0x237B5A8", VA = "0x237B5A8")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6017907")]
    [Address(RVA = "0x237B638", Offset = "0x237B638", VA = "0x237B638")]
    public IEnumerator DoOpenOrClose(MaterialListPopupProvider.BelowScreen belowScreen)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017908")]
    [Address(RVA = "0x237B6D8", Offset = "0x237B6D8", VA = "0x237B6D8")]
    private ItemListModel CreateModel(MaterialListPopupProvider.BelowScreen belowScreen)
    {
      return (ItemListModel) null;
    }

    [Token(Token = "0x6017909")]
    [Address(RVA = "0x237B718", Offset = "0x237B718", VA = "0x237B718")]
    public void PlayOutAnim()
    {
    }

    [Token(Token = "0x601790A")]
    [Address(RVA = "0x237B798", Offset = "0x237B798", VA = "0x237B798")]
    public void Destroy()
    {
    }

    [Token(Token = "0x2003BF4")]
    public enum BelowScreen
    {
      [Token(Token = "0x401099D")] STYLE,
      [Token(Token = "0x401099E")] WEAPON,
      [Token(Token = "0x401099F")] ACCESSORY,
      [Token(Token = "0x40109A0")] MINDEQUIPMENT,
      [Token(Token = "0x40109A1")] CUSTOM_SKILL,
    }
  }
}
