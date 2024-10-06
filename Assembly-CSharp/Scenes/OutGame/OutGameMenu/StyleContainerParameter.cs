// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleContainerParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003ACE")]
  public class StyleContainerParameter : MonoBehaviour
  {
    [Token(Token = "0x40102D7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x40102D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image imageUnit;
    [Token(Token = "0x40102D9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text textName;
    [Token(Token = "0x40102DA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text textNameJp;
    [Token(Token = "0x40102DB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text textStatusLife;
    [Token(Token = "0x40102DC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text textStatusStrength;
    [Token(Token = "0x40102DD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text textStatusMag;
    [Token(Token = "0x40102DE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text textStatusDef;
    [Token(Token = "0x40102DF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text textStatusSpirit;
    [Token(Token = "0x40102E0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text textStatusSpeed;
    [Token(Token = "0x40102E1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text textStatusTech;
    [Token(Token = "0x40102E2")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text textStatusLuck;
    [Token(Token = "0x40102E3")]
    [FieldOffset(Offset = "0x78")]
    [Tooltip("熟練度表示(Index=\"Index:武器種\")")]
    [SerializeField]
    private StyleContainerParameter.TrainingItem[] trainings;
    [Token(Token = "0x40102E4")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Button buttonBack;
    [Token(Token = "0x40102E5")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton buttonStyleList;
    [Token(Token = "0x40102E6")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton toSupportValueList;
    [Token(Token = "0x40102E7")]
    [FieldOffset(Offset = "0x98")]
    public bool isDirection;
    [Token(Token = "0x40102E8")]
    private const string TimeLineAssetbundleName = "content_effect_common_outgamemenu_timeline";
    [Token(Token = "0x40102E9")]
    private const string TimeLineAssetName = "StyleParameter";
    [Token(Token = "0x40102EA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CapturedBlurTexture capturedBlurTexture;
    [Token(Token = "0x40102EB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject[] dontcapturedObjects;
    [Token(Token = "0x40102EC")]
    [FieldOffset(Offset = "0xB0")]
    private int characterId;
    [Token(Token = "0x40102ED")]
    [FieldOffset(Offset = "0xB4")]
    public StyleContainerParameter.eStyleContainerParameterEnd endState;
    [Token(Token = "0x40102EE")]
    [FieldOffset(Offset = "0xB8")]
    public Action<StyleContainerParameter.eStyleContainerParameterEnd> finish;
    [Token(Token = "0x40102EF")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Transform supportPopPearent;
    [Token(Token = "0x40102F0")]
    private const string SupportListAssetBundleName = "ui_page_outgame_supportlist_prefab";
    [Token(Token = "0x40102F1")]
    private const string SupportListAssetName = "Container_Support_List";
    [Token(Token = "0x40102F2")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private UITweenGroup rankColorTweenGroup;
    [Token(Token = "0x40102F3")]
    [FieldOffset(Offset = "0xD0")]
    private UITweenContainer maxTweenContainer;
    [Token(Token = "0x40102F4")]
    [FieldOffset(Offset = "0xD8")]
    private UITweenContainer defTweenContainer;
    [Token(Token = "0x40102F5")]
    private const string TweenColorDefGroupId = "Color_Def";
    [Token(Token = "0x40102F6")]
    private const string TweenColorMaxGroupId = "Color_Max";
    [Token(Token = "0x40102F7")]
    [FieldOffset(Offset = "0xE0")]
    private readonly string markMaxExperience;
    [Token(Token = "0x40102F8")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40102F9")]
    [FieldOffset(Offset = "0xF0")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17004B9A")]
    private Button ButtonBack
    {
      [Token(Token = "0x6017226"), Address(RVA = "0x300BBA4", Offset = "0x300BBA4", VA = "0x300BBA4")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x17004B9B")]
    private CommonButton ButtonStyleList
    {
      [Token(Token = "0x6017227"), Address(RVA = "0x300BBAC", Offset = "0x300BBAC", VA = "0x300BBAC")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x17004B9C")]
    private CommonButton ButtonSupportValue
    {
      [Token(Token = "0x6017228"), Address(RVA = "0x300BBB4", Offset = "0x300BBB4", VA = "0x300BBB4")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x6017229")]
    [Address(RVA = "0x300BBBC", Offset = "0x300BBBC", VA = "0x300BBBC")]
    private void Awake()
    {
    }

    [Token(Token = "0x601722A")]
    [Address(RVA = "0x300BC20", Offset = "0x300BC20", VA = "0x300BC20")]
    public void Setup(
      Character characterData,
      bool fromArmoury,
      Action<StyleContainerParameter.eStyleContainerParameterEnd> _finish,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601722B")]
    [Address(RVA = "0x300BEB4", Offset = "0x300BEB4", VA = "0x300BEB4")]
    private void Setup(Character character)
    {
    }

    [Token(Token = "0x601722C")]
    [Address(RVA = "0x300C6F0", Offset = "0x300C6F0", VA = "0x300C6F0")]
    private void SetRankColor(int weaponIndex, bool isMax)
    {
    }

    [Token(Token = "0x601722D")]
    [Address(RVA = "0x300C504", Offset = "0x300C504", VA = "0x300C504")]
    private void SetButton()
    {
    }

    [Token(Token = "0x601722E")]
    [Address(RVA = "0x300C8F4", Offset = "0x300C8F4", VA = "0x300C8F4")]
    public void Open()
    {
    }

    [Token(Token = "0x601722F")]
    [Address(RVA = "0x300C97C", Offset = "0x300C97C", VA = "0x300C97C")]
    public void Close()
    {
    }

    [Token(Token = "0x6017230")]
    [Address(RVA = "0x300C914", Offset = "0x300C914", VA = "0x300C914")]
    private IEnumerator openProcess() => (IEnumerator) null;

    [Token(Token = "0x6017231")]
    [Address(RVA = "0x300CA10", Offset = "0x300CA10", VA = "0x300CA10")]
    private IEnumerator playTimeline(UITimelineController.DirectionType inout, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017232")]
    [Address(RVA = "0x300CAE0", Offset = "0x300CAE0", VA = "0x300CAE0")]
    private void SetSupportList(int chrId)
    {
    }

    [Token(Token = "0x6017233")]
    [Address(RVA = "0x300CAF8", Offset = "0x300CAF8", VA = "0x300CAF8")]
    public StyleContainerParameter()
    {
    }

    [Token(Token = "0x2003ACF")]
    [Serializable]
    private class TrainingItem
    {
      [Token(Token = "0x40102FA")]
      [FieldOffset(Offset = "0x10")]
      public WeaponTypeEnum type;
      [Token(Token = "0x40102FB")]
      [FieldOffset(Offset = "0x18")]
      public Text textRank;
      [Token(Token = "0x40102FC")]
      [FieldOffset(Offset = "0x20")]
      public Text textNextExperience;

      [Token(Token = "0x601723A")]
      [Address(RVA = "0x300CD24", Offset = "0x300CD24", VA = "0x300CD24")]
      public TrainingItem()
      {
      }
    }

    [Token(Token = "0x2003AD0")]
    public enum eStyleContainerParameterEnd
    {
      [Token(Token = "0x40102FE")] Close,
      [Token(Token = "0x40102FF")] toStyleList,
    }
  }
}
