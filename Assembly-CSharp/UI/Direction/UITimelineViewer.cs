// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x200090D")]
  public class UITimelineViewer : MonoBehaviour
  {
    [Token(Token = "0x4002A48")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController _controller;
    [Token(Token = "0x4002A49")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform _scrollViewContent;
    [Token(Token = "0x4002A4A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle _enableToggle;
    [Token(Token = "0x4002A4B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject _directorGroup;
    [Token(Token = "0x4002A4C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text _title;
    [Token(Token = "0x4002A4D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UITimelineViewer.UITimelineDictionary _inTimelineAssets;
    [Token(Token = "0x4002A4E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UITimelineViewer.UITimelineDictionary _outTimelineAssets;
    [Token(Token = "0x4002A4F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UITimelineViewer.UITimelineDictionary _generalTimelineAssets;
    [Token(Token = "0x4002A50")]
    [FieldOffset(Offset = "0x58")]
    private List<UITimelineViewerGroup> _viewerGroups;
    [Token(Token = "0x4002A51")]
    [FieldOffset(Offset = "0x60")]
    private bool error;
    [Token(Token = "0x4002A52")]
    [FieldOffset(Offset = "0x68")]
    private PlayableDirector[] playableDirectors;

    [Token(Token = "0x17000761")]
    public UITimelineController Controller
    {
      [Token(Token = "0x600330F"), Address(RVA = "0x3624088", Offset = "0x3624088", VA = "0x3624088")] set
      {
      }
    }

    [Token(Token = "0x17000762")]
    public string TargetObjectName
    {
      [Token(Token = "0x6003310"), Address(RVA = "0x3624090", Offset = "0x3624090", VA = "0x3624090")] set
      {
      }
      [Token(Token = "0x6003311"), Address(RVA = "0x3624098", Offset = "0x3624098", VA = "0x3624098")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003312")]
    [Address(RVA = "0x36240A0", Offset = "0x36240A0", VA = "0x36240A0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003313")]
    [Address(RVA = "0x3624ADC", Offset = "0x3624ADC", VA = "0x3624ADC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6003314")]
    [Address(RVA = "0x3624160", Offset = "0x3624160", VA = "0x3624160")]
    private void SetUpTimelineAsset()
    {
    }

    [Token(Token = "0x6003315")]
    [Address(RVA = "0x362446C", Offset = "0x362446C", VA = "0x362446C")]
    private void InitializeViewGroup()
    {
    }

    [Token(Token = "0x6003316")]
    [Address(RVA = "0x3624EF4", Offset = "0x3624EF4", VA = "0x3624EF4")]
    public void PlayFadeInTimeline()
    {
    }

    [Token(Token = "0x6003317")]
    [Address(RVA = "0x362518C", Offset = "0x362518C", VA = "0x362518C")]
    public void PlayFadeOutTimeline()
    {
    }

    [Token(Token = "0x6003318")]
    [Address(RVA = "0x36253E4", Offset = "0x36253E4", VA = "0x36253E4")]
    public void PlayGeneralTimeline()
    {
    }

    [Token(Token = "0x6003319")]
    [Address(RVA = "0x362563C", Offset = "0x362563C", VA = "0x362563C")]
    public void ResetViewGroups()
    {
    }

    [Token(Token = "0x600331A")]
    [Address(RVA = "0x362580C", Offset = "0x362580C", VA = "0x362580C")]
    public UITimelineViewer()
    {
    }

    [Token(Token = "0x200090E")]
    [Serializable]
    public class UITimelineDictionary : 
      UDictionary<int, UITimelineController.UITimelineControllerData>
    {
      [Token(Token = "0x600331E")]
      [Address(RVA = "0x36258E8", Offset = "0x36258E8", VA = "0x36258E8")]
      public UITimelineDictionary()
      {
      }
    }
  }
}
