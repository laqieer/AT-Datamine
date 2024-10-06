// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineViewerGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x2000910")]
  public class UITimelineViewerGroup : MonoBehaviour
  {
    [Token(Token = "0x4002A5B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _title;
    [Token(Token = "0x4002A5C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Dropdown _inTimelineDropdown;
    [Token(Token = "0x4002A5D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Dropdown _outTimelineDropdown;
    [Token(Token = "0x4002A5E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Dropdown _generalTimelineDropdown;
    [Token(Token = "0x4002A5F")]
    [FieldOffset(Offset = "0x38")]
    private PlayableDirector _director;

    [Token(Token = "0x17000763")]
    public PlayableDirector Director
    {
      [Token(Token = "0x6003327"), Address(RVA = "0x3625B4C", Offset = "0x3625B4C", VA = "0x3625B4C")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x6003328")]
    [Address(RVA = "0x3624B90", Offset = "0x3624B90", VA = "0x3624B90")]
    public void SetPlayableDirector(string name, PlayableDirector director)
    {
    }

    [Token(Token = "0x6003329")]
    [Address(RVA = "0x3624BCC", Offset = "0x3624BCC", VA = "0x3624BCC")]
    public void SetTimelineAssets(
      List<TimelineAsset> inAssets,
      List<TimelineAsset> outAssets,
      List<TimelineAsset> generalAssets)
    {
    }

    [Token(Token = "0x600332A")]
    [Address(RVA = "0x362514C", Offset = "0x362514C", VA = "0x362514C")]
    public void GetSelectIndex(
      out int inTimelineIndex,
      out int outTimelineIndex,
      out int generalTimelineIndex)
    {
    }

    [Token(Token = "0x600332B")]
    [Address(RVA = "0x3625B54", Offset = "0x3625B54", VA = "0x3625B54")]
    public UITimelineViewerGroup()
    {
    }
  }
}
