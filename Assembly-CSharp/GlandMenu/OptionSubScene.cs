// Decompiled with JetBrains decompiler
// Type: GlandMenu.OptionSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GlobalMenu;
using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlandMenu
{
  [Token(Token = "0x2000964")]
  public class OptionSubScene : SubScene
  {
    [Token(Token = "0x4002B8D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4002B8E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x4002B8F")]
    private const string TimeLineAssetbundleName = "ui_page_outgame_timeline";
    [Token(Token = "0x4002B90")]
    private const string TimeLineAssetName = "GlobalMenuFront";
    [Token(Token = "0x4002B91")]
    private const string TitleMenuAssetbundleName = "ui_page_outgame_option_prefab";
    [Token(Token = "0x4002B92")]
    private const string TitleMenuAssetName = "Contents_TitleMenu_Popup_Option";
    [Token(Token = "0x4002B93")]
    private const string SideMenuAssetbundleName = "ui_page_header";
    [Token(Token = "0x4002B94")]
    private const string SideMenuAssetName = "Container_SideMenu_Option";
    [Token(Token = "0x4002B95")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject menuObject;
    [Token(Token = "0x4002B96")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject optionMenuParent;
    [Token(Token = "0x4002B97")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject sideMenuParent;
    [Token(Token = "0x4002B98")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Button returnButton;
    [Token(Token = "0x4002B99")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GlobalMenuOptionView optionView;
    [Token(Token = "0x4002B9A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GlobalMenuOptionSideMenuView optionSideMenuView;
    [Token(Token = "0x4002B9B")]
    [FieldOffset(Offset = "0x98")]
    private OptionSubScene.SubSceneParam subSceneParam;

    [Token(Token = "0x6003517")]
    [Address(RVA = "0x35238A8", Offset = "0x35238A8", VA = "0x35238A8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6003518")]
    [Address(RVA = "0x3523948", Offset = "0x3523948", VA = "0x3523948", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003519")]
    [Address(RVA = "0x35239D8", Offset = "0x35239D8", VA = "0x35239D8", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x600351A")]
    [Address(RVA = "0x35239DC", Offset = "0x35239DC", VA = "0x35239DC", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x600351B")]
    [Address(RVA = "0x35239E0", Offset = "0x35239E0", VA = "0x35239E0")]
    public void OnClickBackButton()
    {
    }

    [Token(Token = "0x600351C")]
    [Address(RVA = "0x3523AB0", Offset = "0x3523AB0", VA = "0x3523AB0")]
    public OptionSubScene()
    {
    }

    [Token(Token = "0x2000965")]
    public class SubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x600351E")]
      [Address(RVA = "0x3523C38", Offset = "0x3523C38", VA = "0x3523C38")]
      public SubSceneParam()
      {
      }
    }

    [Token(Token = "0x2000966")]
    public enum OptionMenu
    {
      [Token(Token = "0x4002B9D")] Setting,
      [Token(Token = "0x4002B9E")] Rules,
      [Token(Token = "0x4002B9F")] Currency,
      [Token(Token = "0x4002BA0")] Support,
      [Token(Token = "0x4002BA1")] DataLink,
    }
  }
}
