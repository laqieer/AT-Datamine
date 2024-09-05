// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Home;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AAB")]
  public class LoginBonusManager : MonoBehaviour
  {
    [Token(Token = "0x4003109")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LoginBonusSettingsAsset loginBonusSettingsAsset;
    [Token(Token = "0x400310A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject loginBonusTimelineRoot;
    [Token(Token = "0x400310B")]
    [FieldOffset(Offset = "0x28")]
    private HomeManager homeManager;
    [Token(Token = "0x400310C")]
    [FieldOffset(Offset = "0x30")]
    private PlayableDirector loginBonusPlayableDirector;
    [Token(Token = "0x400310D")]
    [FieldOffset(Offset = "0x38")]
    private LoginBonusSkipView _skipView;
    [Token(Token = "0x400310E")]
    [FieldOffset(Offset = "0x40")]
    private GameObject _skipViewPrefab;
    [Token(Token = "0x400310F")]
    private const string RESOURCE_TRACK_NAME_ANIM = "Act_Anim_Track";
    [Token(Token = "0x4003110")]
    private const string RESOURCE_TRACK_NAME_DISSOLVE = "Act_Anim_Track_Dissolve";
    [Token(Token = "0x4003111")]
    private const string RESOURCE_TRACK_NAME_CAM = "Skill_Cam_Track";
    [Token(Token = "0x4003112")]
    private const string RESOURCE_TRACK_NAME_FLACH = "Lgb_flach";
    [Token(Token = "0x4003113")]
    private const string RESOURCE_TRACK_NAME_PRESENT_BOX = "presentbox";
    [Token(Token = "0x4003114")]
    private const string SKIP_VIEW_ASSETBUNDLE_NAME = "ui_page_loginbonus_prefab";
    [Token(Token = "0x4003115")]
    private const string SKIP_VIEW_ASSET_NAME = "Container_LoginBonus_Skip";
    [Token(Token = "0x4003116")]
    [FieldOffset(Offset = "0x48")]
    private bool triggerUI;
    [Token(Token = "0x4003117")]
    [FieldOffset(Offset = "0x49")]
    private bool triggerUIEmitted;

    [Token(Token = "0x170008B3")]
    public static LoginBonusManager Instance
    {
      [Token(Token = "0x6003CB0"), Address(RVA = "0x3323CC0", Offset = "0x3323CC0", VA = "0x3323CC0")] get
      {
        return (LoginBonusManager) null;
      }
      [Token(Token = "0x6003CB1"), Address(RVA = "0x3323D08", Offset = "0x3323D08", VA = "0x3323D08")] private set
      {
      }
    }

    [Token(Token = "0x6003CB2")]
    [Address(RVA = "0x3323D54", Offset = "0x3323D54", VA = "0x3323D54")]
    public void Awake()
    {
    }

    [Token(Token = "0x170008B4")]
    public bool MotionSkip
    {
      [Token(Token = "0x6003CB3"), Address(RVA = "0x3323DA0", Offset = "0x3323DA0", VA = "0x3323DA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003CB4"), Address(RVA = "0x3323DA8", Offset = "0x3323DA8", VA = "0x3323DA8")] set
      {
      }
    }

    [Token(Token = "0x170008B5")]
    public bool MotionSkip2
    {
      [Token(Token = "0x6003CB5"), Address(RVA = "0x3323DB4", Offset = "0x3323DB4", VA = "0x3323DB4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003CB6"), Address(RVA = "0x3323DBC", Offset = "0x3323DBC", VA = "0x3323DBC")] set
      {
      }
    }

    [Token(Token = "0x6003CB7")]
    [Address(RVA = "0x3323DC8", Offset = "0x3323DC8", VA = "0x3323DC8")]
    public IEnumerator InitializeAsync(HomeManager homeManager) => (IEnumerator) null;

    [Token(Token = "0x6003CB8")]
    [Address(RVA = "0x3323E3C", Offset = "0x3323E3C", VA = "0x3323E3C")]
    public IEnumerator PlayLoginBonus(Action onExitRoutine) => (IEnumerator) null;

    [Token(Token = "0x6003CB9")]
    [Address(RVA = "0x3323EB0", Offset = "0x3323EB0", VA = "0x3323EB0")]
    public void InitializeTimeline()
    {
    }

    [Token(Token = "0x6003CBA")]
    [Address(RVA = "0x33240D8", Offset = "0x33240D8", VA = "0x33240D8")]
    public bool IsLoginBonusReceived() => new bool();

    [Token(Token = "0x6003CBB")]
    [Address(RVA = "0x3324158", Offset = "0x3324158", VA = "0x3324158")]
    public bool Play3DEffectOrNot() => new bool();

    [Token(Token = "0x6003CBC")]
    [Address(RVA = "0x33241DC", Offset = "0x33241DC", VA = "0x33241DC")]
    public void PlayVoice()
    {
    }

    [Token(Token = "0x6003CBD")]
    [Address(RVA = "0x3324208", Offset = "0x3324208", VA = "0x3324208")]
    public void TriggerUI()
    {
    }

    [Token(Token = "0x6003CBE")]
    [Address(RVA = "0x3324214", Offset = "0x3324214", VA = "0x3324214")]
    public LoginBonusManager()
    {
    }
  }
}
