// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.IconView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using FreeMap.Scriptable;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.Map.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E18")]
  public class IconView
  {
    [Token(Token = "0x400C5D1")]
    [FieldOffset(Offset = "0x10")]
    private View view;
    [Token(Token = "0x400C5D2")]
    [FieldOffset(Offset = "0x18")]
    private MapActionIcon actionIconOrigin;
    [Token(Token = "0x400C5D3")]
    [FieldOffset(Offset = "0x20")]
    private MapActionIcon commuIconOrigin;
    [Token(Token = "0x400C5D4")]
    [FieldOffset(Offset = "0x28")]
    private GameObject fasttravelOrigin;
    [Token(Token = "0x400C5D5")]
    [FieldOffset(Offset = "0x30")]
    private GameObject transitionOrigin;
    [Token(Token = "0x400C5D6")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<FreeMapUIParamBase, MapActionIcon> iconTable;
    [Token(Token = "0x400C5D7")]
    [FieldOffset(Offset = "0x40")]
    private List<GameObject> icons;
    [Token(Token = "0x400C5D8")]
    [FieldOffset(Offset = "0x48")]
    private MapActionIcon highlightIcon;
    [Token(Token = "0x400C5D9")]
    [FieldOffset(Offset = "0x50")]
    private List<(RectTransform, Vector2)> iconWithAnchors;
    [Token(Token = "0x400C5DA")]
    [FieldOffset(Offset = "0x58")]
    private readonly Dictionary<string, IconWayController> iconWayControllers;

    [Token(Token = "0x6012011")]
    [Address(RVA = "0x4379338", Offset = "0x4379338", VA = "0x4379338")]
    public IconView(View view)
    {
    }

    [Token(Token = "0x17003D58")]
    private CurrentFreeActionParam currentFreeActionParam
    {
      [Token(Token = "0x6012012"), Address(RVA = "0x4379544", Offset = "0x4379544", VA = "0x4379544")] get
      {
        return (CurrentFreeActionParam) null;
      }
    }

    [Token(Token = "0x17003D59")]
    private Image mapImage
    {
      [Token(Token = "0x6012013"), Address(RVA = "0x4379560", Offset = "0x4379560", VA = "0x4379560")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x17003D5A")]
    private SpriteAtlas iconAtlas
    {
      [Token(Token = "0x6012014"), Address(RVA = "0x4379584", Offset = "0x4379584", VA = "0x4379584")] get
      {
        return (SpriteAtlas) null;
      }
    }

    [Token(Token = "0x17003D5B")]
    private SpriteAtlas charaIconAtlas
    {
      [Token(Token = "0x6012015"), Address(RVA = "0x43795A0", Offset = "0x43795A0", VA = "0x43795A0")] get
      {
        return (SpriteAtlas) null;
      }
    }

    [Token(Token = "0x14000165")]
    public event Action<FreeMapUIParamBase> OnClickIcon
    {
      [Token(Token = "0x6012016"), Address(RVA = "0x43795BC", Offset = "0x43795BC", VA = "0x43795BC")] add
      {
      }
      [Token(Token = "0x6012017"), Address(RVA = "0x437966C", Offset = "0x437966C", VA = "0x437966C")] remove
      {
      }
    }

    [Token(Token = "0x14000166")]
    public event Action<int> OnClickTransition
    {
      [Token(Token = "0x6012018"), Address(RVA = "0x437971C", Offset = "0x437971C", VA = "0x437971C")] add
      {
      }
      [Token(Token = "0x6012019"), Address(RVA = "0x43797CC", Offset = "0x43797CC", VA = "0x43797CC")] remove
      {
      }
    }

    [Token(Token = "0x601201A")]
    [Address(RVA = "0x437987C", Offset = "0x437987C", VA = "0x437987C")]
    public IEnumerator PreLoad() => (IEnumerator) null;

    [Token(Token = "0x601201B")]
    [Address(RVA = "0x4379904", Offset = "0x4379904", VA = "0x4379904")]
    public void Update()
    {
    }

    [Token(Token = "0x601201C")]
    [Address(RVA = "0x4379B50", Offset = "0x4379B50", VA = "0x4379B50")]
    public void Select(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x601201D")]
    [Address(RVA = "0x4379CFC", Offset = "0x4379CFC", VA = "0x4379CFC")]
    public void UnSelect()
    {
    }

    [Token(Token = "0x601201E")]
    [Address(RVA = "0x4379D7C", Offset = "0x4379D7C", VA = "0x4379D7C")]
    private void IconsRelease()
    {
    }

    [Token(Token = "0x601201F")]
    [Address(RVA = "0x4379FAC", Offset = "0x4379FAC", VA = "0x4379FAC")]
    public IEnumerator PlacementIcons(int areaID) => (IEnumerator) null;

    [Token(Token = "0x6012020")]
    private void PlacementIcons<T>(
      int areaID,
      IEnumerable<T> iconParams,
      Func<FreeMapUIParamBase, bool> predicate,
      Action<FreeMapUIParamBase, FreeMapPlacementObject.AnchorData> placement)
      where T : FreeMapUIParamBase
    {
    }

    [Token(Token = "0x6012021")]
    [Address(RVA = "0x437A04C", Offset = "0x437A04C", VA = "0x437A04C")]
    private FreeMapPlacementObject GetPlacement(int areaID) => (FreeMapPlacementObject) null;

    [Token(Token = "0x6012022")]
    [Address(RVA = "0x437A070", Offset = "0x437A070", VA = "0x437A070")]
    private string GetAnchorName(FreeMapUIParamBase param) => (string) null;

    [Token(Token = "0x6012023")]
    [Address(RVA = "0x437A15C", Offset = "0x437A15C", VA = "0x437A15C")]
    private FreeMapPlacementObject.AnchorData GetAnchor(int areaID, string anchorName)
    {
      return (FreeMapPlacementObject.AnchorData) null;
    }

    [Token(Token = "0x6012024")]
    [Address(RVA = "0x437A1B4", Offset = "0x437A1B4", VA = "0x437A1B4")]
    private IconWayController GetorNewIconWayController(FreeMapPlacementObject.AnchorData anchor)
    {
      return (IconWayController) null;
    }

    [Token(Token = "0x6012025")]
    [Address(RVA = "0x437A3F4", Offset = "0x437A3F4", VA = "0x437A3F4")]
    private bool IsShowMap(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6012026")]
    [Address(RVA = "0x437A414", Offset = "0x437A414", VA = "0x437A414")]
    private bool IsShowActionIcon(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6012027")]
    [Address(RVA = "0x437A584", Offset = "0x437A584", VA = "0x437A584")]
    private bool IsShowCommuCharaIcon(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6012028")]
    [Address(RVA = "0x437A64C", Offset = "0x437A64C", VA = "0x437A64C")]
    private void PlacementIcon(FreeMapUIParamBase param, FreeMapPlacementObject.AnchorData anchor)
    {
    }

    [Token(Token = "0x6012029")]
    [Address(RVA = "0x437A940", Offset = "0x437A940", VA = "0x437A940")]
    private void PlacementTransitionIcon(
      FreeMapUIParamBase param,
      FreeMapPlacementObject.AnchorData anchor)
    {
    }

    [Token(Token = "0x601202A")]
    [Address(RVA = "0x437AB84", Offset = "0x437AB84", VA = "0x437AB84")]
    private void PlacementCommuCharaIcon(
      FreeMapUIParamBase param,
      FreeMapPlacementObject.AnchorData anchor)
    {
    }

    [Token(Token = "0x601202B")]
    [Address(RVA = "0x437AD64", Offset = "0x437AD64", VA = "0x437AD64")]
    private void PlacementActionIcon(
      FreeMapUIParamBase param,
      FreeMapPlacementObject.AnchorData anchor)
    {
    }

    [Token(Token = "0x601202C")]
    [Address(RVA = "0x437AEF8", Offset = "0x437AEF8", VA = "0x437AEF8")]
    private void PlacementFastTravel(
      FreeMapUIParamBase param,
      FreeMapPlacementObject.AnchorData anchor)
    {
    }

    [Token(Token = "0x601202D")]
    [Address(RVA = "0x437A728", Offset = "0x437A728", VA = "0x437A728")]
    private void ShowIcon(
      MinimapRectalize rectalize,
      FreeMapPlacementObject.AnchorData anchor,
      FreeMapUIParamBase param,
      MapActionIcon iconObj,
      Sprite sprite,
      out MapActionIcon actionIcon)
    {
    }

    [Token(Token = "0x601202E")]
    [Address(RVA = "0x437AAE4", Offset = "0x437AAE4", VA = "0x437AAE4")]
    private void ShowTransitionIcon(
      MinimapRectalize rectalize,
      FreeMapPlacementObject.AnchorData anchor,
      FreeMapTransitionEventUIParam param,
      out Button button)
    {
    }

    [Token(Token = "0x601202F")]
    [Address(RVA = "0x437B0D4", Offset = "0x437B0D4", VA = "0x437B0D4")]
    private void ShowIcon(
      GameObject origin,
      MinimapRectalize rectalize,
      FreeMapPlacementObject.AnchorData anchor,
      FreeMapUIParamBase param,
      out GameObject icon)
    {
    }
  }
}
