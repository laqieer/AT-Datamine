// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.SkillListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using TeamOrganization;
using UI.Common;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A6E")]
  public class SkillListPopup : MonoBehaviour
  {
    [Token(Token = "0x401001E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup _tween;
    [Token(Token = "0x401001F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipSetSkillView _view;
    [Token(Token = "0x4010020")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BtnFullScreen _btnFullScreen;
    [Token(Token = "0x4010021")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4010022")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner _assetCachedSpawner;

    [Token(Token = "0x6016F6D")]
    [Address(RVA = "0x29C31EC", Offset = "0x29C31EC", VA = "0x29C31EC")]
    public static AssetSpawnOperation<GameObject> Request(AssetCachedSpawner spawner, Style style)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6016F6E")]
    [Address(RVA = "0x29C32FC", Offset = "0x29C32FC", VA = "0x29C32FC")]
    public void Initialize(Style style)
    {
    }

    [Token(Token = "0x6016F6F")]
    [Address(RVA = "0x29C3534", Offset = "0x29C3534", VA = "0x29C3534")]
    public void Open()
    {
    }

    [Token(Token = "0x6016F70")]
    [Address(RVA = "0x29C358C", Offset = "0x29C358C", VA = "0x29C358C")]
    public void Close()
    {
    }

    [Token(Token = "0x6016F71")]
    [Address(RVA = "0x29C3634", Offset = "0x29C3634", VA = "0x29C3634")]
    private void Update()
    {
    }

    [Token(Token = "0x6016F72")]
    [Address(RVA = "0x29C3648", Offset = "0x29C3648", VA = "0x29C3648")]
    public SkillListPopup()
    {
    }
  }
}
