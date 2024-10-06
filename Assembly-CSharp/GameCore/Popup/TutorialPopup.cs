// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.TutorialPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000D16")]
  public class TutorialPopup : PopupBase
  {
    [Token(Token = "0x4003A8C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x4003A8D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject nextButton;
    [Token(Token = "0x4003A8E")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject prevButton;
    [Token(Token = "0x4003A8F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject closeButton;
    [Token(Token = "0x4003A90")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4003A91")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject scrollCell;
    [Token(Token = "0x4003A92")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject pageObj;
    [Token(Token = "0x4003A93")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text nowPage;
    [Token(Token = "0x4003A94")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text maxPage;
    [Token(Token = "0x4003A95")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private VideoPlayer videoPlayer;
    [Token(Token = "0x4003A96")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private int movieWidth;
    [Token(Token = "0x4003A97")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    private int movieHeight;
    [Token(Token = "0x4003A98")]
    [FieldOffset(Offset = "0xE0")]
    private int[] pageIds;
    [Token(Token = "0x4003A99")]
    [FieldOffset(Offset = "0xE8")]
    private int nowIndex;
    [Token(Token = "0x4003A9A")]
    [FieldOffset(Offset = "0xEC")]
    private int maxIndex;
    [Token(Token = "0x4003A9B")]
    [FieldOffset(Offset = "0xF0")]
    private bool isFirstPage;
    [Token(Token = "0x4003A9C")]
    [FieldOffset(Offset = "0xF1")]
    private bool isMaxPage;
    [Token(Token = "0x4003A9D")]
    [FieldOffset(Offset = "0xF4")]
    private float normalizedPosition;
    [Token(Token = "0x4003A9E")]
    [FieldOffset(Offset = "0xF8")]
    private float snapDuration;
    [Token(Token = "0x4003A9F")]
    private const string addfileName = "_TutorialImage";
    [Token(Token = "0x4003AA0")]
    [FieldOffset(Offset = "0x100")]
    private Action closeCallback;
    [Token(Token = "0x4003AA1")]
    [FieldOffset(Offset = "0x108")]
    private int tutorialId;
    [Token(Token = "0x4003AA2")]
    [FieldOffset(Offset = "0x110")]
    private RenderTexture videoTexture;
    [Token(Token = "0x4003AA3")]
    [FieldOffset(Offset = "0x118")]
    private SoundVolumeSaveData soundSettings;
    [Token(Token = "0x4003AA4")]
    [FieldOffset(Offset = "0x120")]
    private float bgmVolume;
    [Token(Token = "0x4003AA5")]
    [FieldOffset(Offset = "0x124")]
    private bool videoInit;
    [Token(Token = "0x4003AA6")]
    [FieldOffset(Offset = "0x125")]
    private bool videoPlayWait;
    [Token(Token = "0x4003AA7")]
    [FieldOffset(Offset = "0x128")]
    private IEnumerator coroutine;
    [Token(Token = "0x4003AA8")]
    [FieldOffset(Offset = "0x130")]
    private bool isNotDrag;
    [Token(Token = "0x4003AA9")]
    [FieldOffset(Offset = "0x134")]
    private float oldXPosition;

    [Token(Token = "0x6004B43")]
    [Address(RVA = "0x32E40AC", Offset = "0x32E40AC", VA = "0x32E40AC")]
    public IEnumerator Initialize(AssetCachedSpawner spawner, int tutorialId, Action callBack)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004B44")]
    [Address(RVA = "0x32E4164", Offset = "0x32E4164", VA = "0x32E4164")]
    private string GetTutorialMovieUrl(string movieName) => (string) null;

    [Token(Token = "0x6004B45")]
    [Address(RVA = "0x32E42F0", Offset = "0x32E42F0", VA = "0x32E42F0")]
    private IEnumerator PrepareVideo(string firstMovie) => (IEnumerator) null;

    [Token(Token = "0x6004B46")]
    [Address(RVA = "0x32E4380", Offset = "0x32E4380", VA = "0x32E4380")]
    private void Update()
    {
    }

    [Token(Token = "0x6004B47")]
    [Address(RVA = "0x32E43D0", Offset = "0x32E43D0", VA = "0x32E43D0")]
    public static void PreloadImage(AssetCachedSpawner spawner, int tutorialId)
    {
    }

    [Token(Token = "0x6004B48")]
    [Address(RVA = "0x32E4574", Offset = "0x32E4574", VA = "0x32E4574")]
    public static List<int> GetImageIds(int tutorialId) => (List<int>) null;

    [Token(Token = "0x6004B49")]
    [Address(RVA = "0x32E4788", Offset = "0x32E4788", VA = "0x32E4788")]
    public static string GetImageAssetbundleName(int imageId) => (string) null;

    [Token(Token = "0x6004B4A")]
    [Address(RVA = "0x32E4808", Offset = "0x32E4808", VA = "0x32E4808")]
    public static string GetImageAssetName(int imageId) => (string) null;

    [Token(Token = "0x6004B4B")]
    [Address(RVA = "0x32E48A8", Offset = "0x32E48A8", VA = "0x32E48A8")]
    public void Play(Action closeCallback = null)
    {
    }

    [Token(Token = "0x6004B4C")]
    [Address(RVA = "0x32E4950", Offset = "0x32E4950", VA = "0x32E4950")]
    private void SetData(int index)
    {
    }

    [Token(Token = "0x6004B4D")]
    [Address(RVA = "0x32E4B98", Offset = "0x32E4B98", VA = "0x32E4B98")]
    private IEnumerator PlayMovie(string movieName, bool isMaxPage, bool isFirstPage)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004B4E")]
    [Address(RVA = "0x32E4C54", Offset = "0x32E4C54", VA = "0x32E4C54")]
    public void NextOrCloseButton()
    {
    }

    [Token(Token = "0x6004B4F")]
    [Address(RVA = "0x32E4D9C", Offset = "0x32E4D9C", VA = "0x32E4D9C")]
    public void PrevOrNoneButton()
    {
    }

    [Token(Token = "0x6004B50")]
    [Address(RVA = "0x32E4D64", Offset = "0x32E4D64", VA = "0x32E4D64")]
    public void NextButton()
    {
    }

    [Token(Token = "0x6004B51")]
    [Address(RVA = "0x32E4DAC", Offset = "0x32E4DAC", VA = "0x32E4DAC")]
    public void PrevButton()
    {
    }

    [Token(Token = "0x6004B52")]
    [Address(RVA = "0x32E4C64", Offset = "0x32E4C64", VA = "0x32E4C64")]
    public void CloseButton()
    {
    }

    [Token(Token = "0x6004B53")]
    [Address(RVA = "0x32E4DE4", Offset = "0x32E4DE4", VA = "0x32E4DE4")]
    public void SetCenterItem(int index)
    {
    }

    [Token(Token = "0x6004B54")]
    [Address(RVA = "0x32E4FE8", Offset = "0x32E4FE8", VA = "0x32E4FE8")]
    private IEnumerator SetCenterItem(float before, float afetr, float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004B55")]
    [Address(RVA = "0x32E509C", Offset = "0x32E509C", VA = "0x32E509C")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B56")]
    [Address(RVA = "0x32E50AC", Offset = "0x32E50AC", VA = "0x32E50AC")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B57")]
    [Address(RVA = "0x32E50B8", Offset = "0x32E50B8", VA = "0x32E50B8")]
    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B58")]
    [Address(RVA = "0x32E50D8", Offset = "0x32E50D8", VA = "0x32E50D8")]
    public void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004B59")]
    [Address(RVA = "0x32E5114", Offset = "0x32E5114", VA = "0x32E5114")]
    public TutorialPopup()
    {
    }
  }
}
