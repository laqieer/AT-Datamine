// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000BA0")]
  public class GlobalMenuOptionSetting : MonoBehaviour
  {
    [Token(Token = "0x40034F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x40034F8")]
    private const string TimeLineAssetbundleName = "ui_page_outgame_timeline";
    [Token(Token = "0x40034F9")]
    private const string TimeLineAssetName = "GlobalMenuFront";
    [Token(Token = "0x40034FA")]
    private const string TitleMenuAssetbundleName = "ui_page_outgame_option_prefab";
    [Token(Token = "0x40034FB")]
    private const string TitleMenuAssetName = "Contents_TitleMenu_Popup_Option";
    [Token(Token = "0x40034FC")]
    private const string SideMenuAssetbundleName = "ui_page_header";
    [Token(Token = "0x40034FD")]
    private const string SideMenuAssetName = "Container_SideMenu_Option";
    [Token(Token = "0x40034FE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject menuObject;
    [Token(Token = "0x40034FF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject optionMenuParent;
    [Token(Token = "0x4003500")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject sideMenuParent;
    [Token(Token = "0x4003501")]
    [FieldOffset(Offset = "0x38")]
    private GlobalMenuOptionView optionView;
    [Token(Token = "0x4003502")]
    [FieldOffset(Offset = "0x40")]
    private GlobalMenuOptionSideMenuView optionSideMenuView;
    [Token(Token = "0x4003504")]
    [FieldOffset(Offset = "0x49")]
    private bool isInitialize;

    [Token(Token = "0x170009A0")]
    public bool IsShown
    {
      [Token(Token = "0x600425B"), Address(RVA = "0x2A35E70", Offset = "0x2A35E70", VA = "0x2A35E70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600425C"), Address(RVA = "0x2A35E78", Offset = "0x2A35E78", VA = "0x2A35E78")] private set
      {
      }
    }

    [Token(Token = "0x600425D")]
    [Address(RVA = "0x2A35E84", Offset = "0x2A35E84", VA = "0x2A35E84")]
    public void Open()
    {
    }

    [Token(Token = "0x600425E")]
    [Address(RVA = "0x2A36078", Offset = "0x2A36078", VA = "0x2A36078")]
    public void Close()
    {
    }

    [Token(Token = "0x600425F")]
    [Address(RVA = "0x2A36010", Offset = "0x2A36010", VA = "0x2A36010")]
    private IEnumerator TimeLineAssetLoad() => (IEnumerator) null;

    [Token(Token = "0x6004260")]
    [Address(RVA = "0x2A36200", Offset = "0x2A36200", VA = "0x2A36200")]
    private void OnLoadComplete(List<string> succeedList, Dictionary<string, string> failedDic)
    {
    }

    [Token(Token = "0x6004261")]
    [Address(RVA = "0x2A366A4", Offset = "0x2A366A4", VA = "0x2A366A4")]
    public GlobalMenuOptionSetting()
    {
    }

    [Token(Token = "0x2000BA1")]
    public enum OptionMenu
    {
      [Token(Token = "0x4003506")] Setting,
      [Token(Token = "0x4003507")] Rules,
      [Token(Token = "0x4003508")] Currency,
      [Token(Token = "0x4003509")] Support,
      [Token(Token = "0x400350A")] DataLink,
    }
  }
}
