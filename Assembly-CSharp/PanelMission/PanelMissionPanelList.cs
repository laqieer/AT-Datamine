// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionPanelList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A17")]
  public class PanelMissionPanelList : MonoBehaviour
  {
    [Token(Token = "0x4002EC5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PanelMissionPanelElement> _elementList;
    [Token(Token = "0x4002EC6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _missionTitle;
    [Token(Token = "0x4002EC7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject _lockObject;
    [Token(Token = "0x4002EC8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton _arrowLeft;
    [Token(Token = "0x4002EC9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton _arrowRight;
    [Token(Token = "0x4002ECA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject _pagerRoot;
    [Token(Token = "0x4002ECB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton _pagerLeftButton;
    [Token(Token = "0x4002ECC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton _pagerRightButton;
    [Token(Token = "0x4002ECD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI _pagerText;
    [Token(Token = "0x4002ECE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ToasterUI toaster;
    [Token(Token = "0x4002ECF")]
    [FieldOffset(Offset = "0x68")]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x4002ED0")]
    [FieldOffset(Offset = "0x70")]
    private List<PanelMissionViewModelFactory.PanelViewModel> _viewModels;
    [Token(Token = "0x4002ED1")]
    [FieldOffset(Offset = "0x78")]
    private int _pageIndex;
    [Token(Token = "0x4002ED2")]
    [FieldOffset(Offset = "0x80")]
    private string _pagerDefaultText;
    [Token(Token = "0x4002ED3")]
    [FieldOffset(Offset = "0x88")]
    private Action<int, int> onPressRewardGet;
    [Token(Token = "0x4002ED4")]
    [FieldOffset(Offset = "0x90")]
    private Action<int, int> onPressChallenge;
    [Token(Token = "0x4002ED5")]
    [FieldOffset(Offset = "0x98")]
    public Action OnPressPageLeft;
    [Token(Token = "0x4002ED6")]
    [FieldOffset(Offset = "0xA0")]
    public Action OnPressPageRight;

    [Token(Token = "0x17000833")]
    public int CurrentPageIndex
    {
      [Token(Token = "0x6003985"), Address(RVA = "0x3114A50", Offset = "0x3114A50", VA = "0x3114A50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000834")]
    public int CurrentPanelMissionId
    {
      [Token(Token = "0x6003986"), Address(RVA = "0x310FFFC", Offset = "0x310FFFC", VA = "0x310FFFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000835")]
    public int CurrentPanelMissionGroupId
    {
      [Token(Token = "0x6003987"), Address(RVA = "0x310EE90", Offset = "0x310EE90", VA = "0x310EE90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003988")]
    [Address(RVA = "0x310FBB0", Offset = "0x310FBB0", VA = "0x310FBB0")]
    public IEnumerator InitializeAsync(Action<int, int> onRewardGet, Action<int, int> onChallange)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003989")]
    [Address(RVA = "0x3114A80", Offset = "0x3114A80", VA = "0x3114A80")]
    private void UpdatePagerText()
    {
    }

    [Token(Token = "0x600398A")]
    [Address(RVA = "0x31112F4", Offset = "0x31112F4", VA = "0x31112F4")]
    public IEnumerator AppearAnimation() => (IEnumerator) null;

    [Token(Token = "0x600398B")]
    [Address(RVA = "0x311128C", Offset = "0x311128C", VA = "0x311128C")]
    public IEnumerator DisappearAnimation() => (IEnumerator) null;

    [Token(Token = "0x600398C")]
    [Address(RVA = "0x31102B8", Offset = "0x31102B8", VA = "0x31102B8")]
    public IEnumerator DisappearLeftAnimation() => (IEnumerator) null;

    [Token(Token = "0x600398D")]
    [Address(RVA = "0x310FF08", Offset = "0x310FF08", VA = "0x310FF08")]
    public IEnumerator DisappearRightAnimation() => (IEnumerator) null;

    [Token(Token = "0x600398E")]
    [Address(RVA = "0x310FF94", Offset = "0x310FF94", VA = "0x310FF94")]
    public IEnumerator AppearLeftAnimation() => (IEnumerator) null;

    [Token(Token = "0x600398F")]
    [Address(RVA = "0x3110344", Offset = "0x3110344", VA = "0x3110344")]
    public IEnumerator AppearRightAnimation() => (IEnumerator) null;

    [Token(Token = "0x6003990")]
    [Address(RVA = "0x310E434", Offset = "0x310E434", VA = "0x310E434")]
    public void MakePanelClicked(int panelId)
    {
    }

    [Token(Token = "0x6003991")]
    [Address(RVA = "0x310E530", Offset = "0x310E530", VA = "0x310E530")]
    public void MakePanelReceived(int panelId)
    {
    }

    [Token(Token = "0x6003992")]
    [Address(RVA = "0x3110658", Offset = "0x3110658", VA = "0x3110658")]
    public IEnumerator RefreshAsync(
      List<PanelMissionViewModelFactory.PanelViewModel> viewModels,
      int pageIndex)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003993")]
    [Address(RVA = "0x310FF70", Offset = "0x310FF70", VA = "0x310FF70")]
    public void MoveLeft()
    {
    }

    [Token(Token = "0x6003994")]
    [Address(RVA = "0x3110320", Offset = "0x3110320", VA = "0x3110320")]
    public void MoveRight()
    {
    }

    [Token(Token = "0x6003995")]
    [Address(RVA = "0x310FEA0", Offset = "0x310FEA0", VA = "0x310FEA0")]
    public IEnumerator LoadLeftPanel() => (IEnumerator) null;

    [Token(Token = "0x6003996")]
    [Address(RVA = "0x3110250", Offset = "0x3110250", VA = "0x3110250")]
    public IEnumerator LoadRightPanel() => (IEnumerator) null;

    [Token(Token = "0x6003997")]
    [Address(RVA = "0x3114FCC", Offset = "0x3114FCC", VA = "0x3114FCC")]
    private IEnumerator LoadPanel(int pageIndex) => (IEnumerator) null;

    [Token(Token = "0x6003998")]
    [Address(RVA = "0x311143C", Offset = "0x311143C", VA = "0x311143C")]
    public bool CanMoveRight() => new bool();

    [Token(Token = "0x6003999")]
    [Address(RVA = "0x3111494", Offset = "0x3111494", VA = "0x3111494")]
    public void UnlockNextPage()
    {
    }

    [Token(Token = "0x600399A")]
    [Address(RVA = "0x3114C6C", Offset = "0x3114C6C", VA = "0x3114C6C")]
    private void UpdatePanels(int pageIndex)
    {
    }

    [Token(Token = "0x600399B")]
    [Address(RVA = "0x31114EC", Offset = "0x31114EC", VA = "0x31114EC")]
    public void DisplayNewPanelOpenToaster()
    {
    }

    [Token(Token = "0x600399C")]
    [Address(RVA = "0x3115074", Offset = "0x3115074", VA = "0x3115074")]
    public PanelMissionPanelList()
    {
    }
  }
}
