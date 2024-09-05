// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SkillEnhancePerformance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031D6")]
  public class SkillEnhancePerformance : MonoBehaviour
  {
    [Token(Token = "0x400D481")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400D482")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400D483")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup suppression;
    [Token(Token = "0x400D484")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton toNextButton;
    [Token(Token = "0x400D485")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton SkipButton;
    [Token(Token = "0x400D486")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI beforLevelText;
    [Token(Token = "0x400D487")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text afterLevelText;
    [Token(Token = "0x400D488")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private DetailSkillListThumb beforDetailSkillList;
    [Token(Token = "0x400D489")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private DetailSkillListThumb afterDetailSkillList;
    [Token(Token = "0x400D48A")]
    public const string prefabAssetBundleName = "ui_page_equipdetail";
    [Token(Token = "0x400D48B")]
    public const string prefabAssetNameSuccess = "Skill_Strengthening_Staging_Success_Popup";
    [Token(Token = "0x400D48C")]
    public const string prefabAssetNameFailure = "Skill_Strengthening_Staging_Failure_Popup";
    [Token(Token = "0x400D48D")]
    private const string levelDisplayFormat = "{0:#,0}";
    [Token(Token = "0x400D48E")]
    [FieldOffset(Offset = "0x60")]
    private int targetSkillID;
    [Token(Token = "0x400D48F")]
    [FieldOffset(Offset = "0x64")]
    private bool isDirection;
    [Token(Token = "0x400D490")]
    [FieldOffset(Offset = "0x68")]
    private Action finish;
    [Token(Token = "0x400D491")]
    [FieldOffset(Offset = "0x70")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x601374C")]
    [Address(RVA = "0x4E0D998", Offset = "0x4E0D998", VA = "0x4E0D998")]
    private void Awake()
    {
    }

    [Token(Token = "0x601374D")]
    [Address(RVA = "0x4E0D9B8", Offset = "0x4E0D9B8", VA = "0x4E0D9B8")]
    public IEnumerator InitializeAsync(
      bool success,
      EquipmentSkill oldSkilldata,
      EquipmentSkill newSkilldata,
      Action _finish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601374E")]
    [Address(RVA = "0x4E0DA74", Offset = "0x4E0DA74", VA = "0x4E0DA74")]
    private IEnumerator Disclosure() => (IEnumerator) null;

    [Token(Token = "0x601374F")]
    [Address(RVA = "0x4E0DB04", Offset = "0x4E0DB04", VA = "0x4E0DB04")]
    public SkillEnhancePerformance()
    {
    }
  }
}
