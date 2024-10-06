// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003202")]
  public class ItemListSubScene : SubScene
  {
    [Token(Token = "0x400D5B6")]
    private const string InEquipListName = "Popup_In";
    [Token(Token = "0x400D5B7")]
    private const string OutEquipListName = "Popup_Out";
    [Token(Token = "0x400D5B8")]
    private const string ItemListAtlasAssetBundleName = "2dassets_ui_itemlist";
    [Token(Token = "0x400D5B9")]
    public const string ItemListPopupPrefabName = "Container_ItemListMain";
    [Token(Token = "0x400D5BA")]
    public const string IconItemAssetbundleName = "content_icon_item";
    [Token(Token = "0x400D5BB")]
    public const string RarelityIconSpriteAtlasAssetBundleName = "2dassets_ui_spriteatlases";
    [Token(Token = "0x400D5BC")]
    [FieldOffset(Offset = "0x58")]
    protected ItemListPopup itemListPopupPrefab;
    [Token(Token = "0x400D5BD")]
    [FieldOffset(Offset = "0x60")]
    protected ItemListPopup itemListPopup;
    [Token(Token = "0x400D5BE")]
    [FieldOffset(Offset = "0x68")]
    private bool isInitialized;
    [Token(Token = "0x400D5BF")]
    [FieldOffset(Offset = "0x70")]
    private List<string> loadedAssetBundleNameList;

    [Token(Token = "0x6013867")]
    [Address(RVA = "0x49BF88C", Offset = "0x49BF88C", VA = "0x49BF88C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013868")]
    [Address(RVA = "0x49BF894", Offset = "0x49BF894", VA = "0x49BF894", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013869")]
    [Address(RVA = "0x49BF924", Offset = "0x49BF924", VA = "0x49BF924")]
    private void OnLoadComplete(List<string> succeedList, Dictionary<string, string> failedDic)
    {
    }

    [Token(Token = "0x601386A")]
    [Address(RVA = "0x49BFB9C", Offset = "0x49BFB9C", VA = "0x49BFB9C", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601386B")]
    [Address(RVA = "0x49BFD38", Offset = "0x49BFD38", VA = "0x49BFD38")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x601386C")]
    [Address(RVA = "0x49BFDB8", Offset = "0x49BFDB8", VA = "0x49BFDB8")]
    public ItemListSubScene()
    {
    }
  }
}
