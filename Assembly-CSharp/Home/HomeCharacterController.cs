// Decompiled with JetBrains decompiler
// Type: Home.HomeCharacterController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B21")]
  public class HomeCharacterController : MonoBehaviour
  {
    [Token(Token = "0x40032BC")]
    private const string TLAssetBundlePrefix = "content_motion3d_home_timeline_";
    [Token(Token = "0x40032BD")]
    [FieldOffset(Offset = "0x28")]
    private List<TimelineAsset> onTouchSpeakTimelineAssets;
    [Token(Token = "0x40032BE")]
    [FieldOffset(Offset = "0x30")]
    private TimelineAsset loginBonusTimelineAsset;

    [Token(Token = "0x1700092A")]
    public HomeCharacterSettingsAsset SettingsAsset
    {
      [Token(Token = "0x6003F45"), Address(RVA = "0x2C1B51C", Offset = "0x2C1B51C", VA = "0x2C1B51C")] get
      {
        return (HomeCharacterSettingsAsset) null;
      }
      [Token(Token = "0x6003F46"), Address(RVA = "0x2C1B524", Offset = "0x2C1B524", VA = "0x2C1B524")] private set
      {
      }
    }

    [Token(Token = "0x1700092B")]
    public int CharacterIndex
    {
      [Token(Token = "0x6003F47"), Address(RVA = "0x2C1B52C", Offset = "0x2C1B52C", VA = "0x2C1B52C")] get
      {
        return new int();
      }
      [Token(Token = "0x6003F48"), Address(RVA = "0x2C1B534", Offset = "0x2C1B534", VA = "0x2C1B534")] private set
      {
      }
    }

    [Token(Token = "0x1700092C")]
    public int StyleId
    {
      [Token(Token = "0x6003F49"), Address(RVA = "0x2C1B53C", Offset = "0x2C1B53C", VA = "0x2C1B53C")] get
      {
        return new int();
      }
      [Token(Token = "0x6003F4A"), Address(RVA = "0x2C1B544", Offset = "0x2C1B544", VA = "0x2C1B544")] private set
      {
      }
    }

    [Token(Token = "0x6003F4B")]
    [Address(RVA = "0x2C1B54C", Offset = "0x2C1B54C", VA = "0x2C1B54C")]
    public TimelineAsset GetTimelineByActId(int actId) => (TimelineAsset) null;

    [Token(Token = "0x6003F4C")]
    [Address(RVA = "0x2C1B5A4", Offset = "0x2C1B5A4", VA = "0x2C1B5A4")]
    public TimelineAsset GetLoginBonusTimeline() => (TimelineAsset) null;

    [Token(Token = "0x6003F4D")]
    [Address(RVA = "0x2C1B5AC", Offset = "0x2C1B5AC", VA = "0x2C1B5AC")]
    public IEnumerator Initialize(AssetCachedSpawner useSpawner, bool isLoginBounusTarget)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003F4E")]
    [Address(RVA = "0x2C1B654", Offset = "0x2C1B654", VA = "0x2C1B654")]
    private IEnumerator LoadAssetBundle(AssetCachedSpawner useSpawner, bool isLoginBounusTarget)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003F4F")]
    [Address(RVA = "0x2C1B6FC", Offset = "0x2C1B6FC", VA = "0x2C1B6FC")]
    public static GameObject InstantiateCharacter(
      HomeCharacterSettingsAsset settingsAsset,
      GameObject parent,
      int characterIndex,
      int styleId)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6003F50")]
    [Address(RVA = "0x2C1BAFC", Offset = "0x2C1BAFC", VA = "0x2C1BAFC")]
    public void ResolveCharacter()
    {
    }

    [Token(Token = "0x6003F51")]
    [Address(RVA = "0x2C1BAB4", Offset = "0x2C1BAB4", VA = "0x2C1BAB4")]
    public Animator GetAnimator() => (Animator) null;

    [Token(Token = "0x6003F52")]
    [Address(RVA = "0x2C067A8", Offset = "0x2C067A8", VA = "0x2C067A8")]
    public LipSyncController GetLipSyncController() => (LipSyncController) null;

    [Token(Token = "0x6003F53")]
    [Address(RVA = "0x2C1BBDC", Offset = "0x2C1BBDC", VA = "0x2C1BBDC")]
    public void ResetFacial()
    {
    }

    [Token(Token = "0x6003F54")]
    [Address(RVA = "0x2C1BC6C", Offset = "0x2C1BC6C", VA = "0x2C1BC6C")]
    public void SetActiveFacialAnimationByAnimatorController(bool active)
    {
    }

    [Token(Token = "0x6003F55")]
    [Address(RVA = "0x2C1BCA0", Offset = "0x2C1BCA0", VA = "0x2C1BCA0")]
    public void SetValidBlinkController(bool state)
    {
    }

    [Token(Token = "0x6003F56")]
    [Address(RVA = "0x2C1BD08", Offset = "0x2C1BD08", VA = "0x2C1BD08")]
    public HomeCharacterController()
    {
    }
  }
}
