// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2Human
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing;
using GameCore.Animation;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E11")]
  public class Adv2Human : Adv2Object
  {
    [Token(Token = "0x401104E")]
    [FieldOffset(Offset = "0xA0")]
    public Adv2LinkageAnimation FacialLinkage;
    [Token(Token = "0x401104F")]
    [FieldOffset(Offset = "0xA8")]
    public Adv2LinkageAnimation.ReserveLinagePack ReserveFacialAnimationPack;
    [Token(Token = "0x4011050")]
    [FieldOffset(Offset = "0xB0")]
    public Adv2LinkageAnimation.ReserveLinagePack ReserveHeadAnimationPack;
    [Token(Token = "0x4011051")]
    protected const string facialAnimationLayerName = "facial";
    [Token(Token = "0x4011052")]
    [FieldOffset(Offset = "0xB8")]
    public Adv2LinkageAnimation HeadLinkage;
    [Token(Token = "0x4011053")]
    protected const string headAnimationLayerName = "head";
    [Token(Token = "0x4011054")]
    [FieldOffset(Offset = "0xC0")]
    public Vector3? IkTargetPosition;
    [Token(Token = "0x4011055")]
    [FieldOffset(Offset = "0xD0")]
    public float IkDelayDuration;
    [Token(Token = "0x4011056")]
    [FieldOffset(Offset = "0xD8")]
    private string reserveLipSyncTag;
    [Token(Token = "0x4011057")]
    [FieldOffset(Offset = "0xE0")]
    private string reserveEyeSyncTag;
    [Token(Token = "0x4011058")]
    [FieldOffset(Offset = "0xE8")]
    private ScriptSideInFreeAnimator script;
    [Token(Token = "0x4011059")]
    [FieldOffset(Offset = "0xF0")]
    private AnimatorCullingMode prevAnimatorCullingMode;
    [Token(Token = "0x401105A")]
    [FieldOffset(Offset = "0xF8")]
    public IEnumerator delay;

    [Token(Token = "0x17005143")]
    private ScriptSideInFreeAnimator Script
    {
      [Token(Token = "0x6018FC9"), Address(RVA = "0x2CB9010", Offset = "0x2CB9010", VA = "0x2CB9010")] get
      {
        return (ScriptSideInFreeAnimator) null;
      }
    }

    [Token(Token = "0x6018FCA")]
    [Address(RVA = "0x2CB9078", Offset = "0x2CB9078", VA = "0x2CB9078")]
    public int ReadStyleIdfromModelName() => new int();

    [Token(Token = "0x6018FCB")]
    [Address(RVA = "0x2CB9170", Offset = "0x2CB9170", VA = "0x2CB9170", Slot = "12")]
    public override void SetAnimationSystemChangeTime(float startTime, float exitTime)
    {
    }

    [Token(Token = "0x6018FCC")]
    [Address(RVA = "0x2CB91A4", Offset = "0x2CB91A4", VA = "0x2CB91A4")]
    public Adv2Manager.OnProccessSignal PlayFacialAnimation(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool isLoop)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018FCD")]
    [Address(RVA = "0x2CB92C8", Offset = "0x2CB92C8", VA = "0x2CB92C8")]
    public void SetLipSync(Adv2AnimationLipSync.Mode mode)
    {
    }

    [Token(Token = "0x6018FCE")]
    [Address(RVA = "0x2CB936C", Offset = "0x2CB936C", VA = "0x2CB936C")]
    public void SetLipSyncText(string text, float time)
    {
    }

    [Token(Token = "0x6018FCF")]
    [Address(RVA = "0x2CB9420", Offset = "0x2CB9420", VA = "0x2CB9420")]
    public void SetIsActiveLipSync(bool flag)
    {
    }

    [Token(Token = "0x6018FD0")]
    [Address(RVA = "0x2CB94E8", Offset = "0x2CB94E8", VA = "0x2CB94E8", Slot = "13")]
    protected override void SetAdv2LinkageAnimation(
      GameObject rootObject,
      Adv2LinkageAnimation[] linkageList)
    {
    }

    [Token(Token = "0x6018FD1")]
    [Address(RVA = "0x2CB97A8", Offset = "0x2CB97A8", VA = "0x2CB97A8")]
    public void SetActiveFacialControl(bool is_valid)
    {
    }

    [Token(Token = "0x17005144")]
    public Action ActionBlink
    {
      [Token(Token = "0x6018FD2"), Address(RVA = "0x2CB98A8", Offset = "0x2CB98A8", VA = "0x2CB98A8")] set
      {
      }
    }

    [Token(Token = "0x17005145")]
    public Action ActionCloseEye
    {
      [Token(Token = "0x6018FD3"), Address(RVA = "0x2CB994C", Offset = "0x2CB994C", VA = "0x2CB994C")] set
      {
      }
    }

    [Token(Token = "0x17005146")]
    public Action ActionOpenEye
    {
      [Token(Token = "0x6018FD4"), Address(RVA = "0x2CB9A1C", Offset = "0x2CB9A1C", VA = "0x2CB9A1C")] set
      {
      }
    }

    [Token(Token = "0x17005147")]
    public Action ActionLipsync
    {
      [Token(Token = "0x6018FD5"), Address(RVA = "0x2CB9AEC", Offset = "0x2CB9AEC", VA = "0x2CB9AEC")] set
      {
      }
    }

    [Token(Token = "0x17005148")]
    public Action ActionCloseLip
    {
      [Token(Token = "0x6018FD6"), Address(RVA = "0x2CB9BBC", Offset = "0x2CB9BBC", VA = "0x2CB9BBC")] set
      {
      }
    }

    [Token(Token = "0x17005149")]
    public Action ActionOpenLip
    {
      [Token(Token = "0x6018FD7"), Address(RVA = "0x2CB9C8C", Offset = "0x2CB9C8C", VA = "0x2CB9C8C")] set
      {
      }
    }

    [Token(Token = "0x6018FD8")]
    [Address(RVA = "0x2CB9D30", Offset = "0x2CB9D30", VA = "0x2CB9D30")]
    public void SetDicingImage(CharaImage charaImage, float transitionTime)
    {
    }

    [Token(Token = "0x6018FD9")]
    [Address(RVA = "0x2CB9DE4", Offset = "0x2CB9DE4", VA = "0x2CB9DE4", Slot = "14")]
    public override void SetAnimationEvent()
    {
    }

    [Token(Token = "0x6018FDA")]
    [Address(RVA = "0x2CB9EA8", Offset = "0x2CB9EA8", VA = "0x2CB9EA8")]
    protected void OnAnimationEventFootSE(List<string> argument)
    {
    }

    [Token(Token = "0x6018FDB")]
    [Address(RVA = "0x2CB9EAC", Offset = "0x2CB9EAC", VA = "0x2CB9EAC")]
    protected void CheckIkLookAt()
    {
    }

    [Token(Token = "0x6018FDC")]
    [Address(RVA = "0x2CB9FCC", Offset = "0x2CB9FCC", VA = "0x2CB9FCC")]
    private IEnumerator Delay(Vector3? position, float duration) => (IEnumerator) null;

    [Token(Token = "0x6018FDD")]
    [Address(RVA = "0x2CBA080", Offset = "0x2CBA080", VA = "0x2CBA080", Slot = "5")]
    public override void Update()
    {
    }

    [Token(Token = "0x6018FDE")]
    [Address(RVA = "0x2CBA09C", Offset = "0x2CBA09C", VA = "0x2CBA09C")]
    public void ForceEyeSync(string syncTag)
    {
    }

    [Token(Token = "0x6018FDF")]
    [Address(RVA = "0x2CBA150", Offset = "0x2CBA150", VA = "0x2CBA150")]
    public void ForceLipSync(string syncTag)
    {
    }

    [Token(Token = "0x6018FE0")]
    [Address(RVA = "0x2CBA204", Offset = "0x2CBA204", VA = "0x2CBA204")]
    public void ResetForcePlayMode()
    {
    }

    [Token(Token = "0x6018FE1")]
    [Address(RVA = "0x2CBA2A0", Offset = "0x2CBA2A0", VA = "0x2CBA2A0")]
    public void ReserveEyeSync(string syncTag)
    {
    }

    [Token(Token = "0x6018FE2")]
    [Address(RVA = "0x2CBA2A8", Offset = "0x2CBA2A8", VA = "0x2CBA2A8")]
    public void ReserveLipSync(string syncTag)
    {
    }

    [Token(Token = "0x6018FE3")]
    [Address(RVA = "0x2CBA2B0", Offset = "0x2CBA2B0", VA = "0x2CBA2B0")]
    private void PlayReservedEyeSync()
    {
    }

    [Token(Token = "0x6018FE4")]
    [Address(RVA = "0x2CBA328", Offset = "0x2CBA328", VA = "0x2CBA328")]
    private void PlayReservedLipSync()
    {
    }

    [Token(Token = "0x6018FE5")]
    [Address(RVA = "0x2CBA3A0", Offset = "0x2CBA3A0", VA = "0x2CBA3A0")]
    public void PlayReservedForceSync()
    {
    }

    [Token(Token = "0x6018FE6")]
    [Address(RVA = "0x2CBA3C0", Offset = "0x2CBA3C0", VA = "0x2CBA3C0", Slot = "15")]
    public override void SetBindObject(GameObject prefab, bool setParent = true)
    {
    }

    [Token(Token = "0x6018FE7")]
    [Address(RVA = "0x2CBA4D4", Offset = "0x2CBA4D4", VA = "0x2CBA4D4", Slot = "16")]
    public override void RecoverBindObject()
    {
    }

    [Token(Token = "0x6018FE8")]
    [Address(RVA = "0x2CBA5B0", Offset = "0x2CBA5B0", VA = "0x2CBA5B0")]
    public List<Adv2Manager.OnProccessSignal> LoadModel(
      string objectAssetbundleName,
      string objectFileName,
      string animationAssetbundleName,
      string animationFileName,
      string facialAssetbundleName,
      string facialFileName)
    {
      return (List<Adv2Manager.OnProccessSignal>) null;
    }

    [Token(Token = "0x6018FE9")]
    [Address(RVA = "0x2CBA728", Offset = "0x2CBA728", VA = "0x2CBA728")]
    public Adv2Manager.OnProccessSignal LoadHeadAnimation(
      string headAnimationPackAssetbundleName,
      string headAnimationPackFileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018FEA")]
    [Address(RVA = "0x2CBA7C8", Offset = "0x2CBA7C8", VA = "0x2CBA7C8")]
    public void PlayHeadMotion(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool loop)
    {
    }

    [Token(Token = "0x6018FEB")]
    [Address(RVA = "0x2CBA864", Offset = "0x2CBA864", VA = "0x2CBA864")]
    public void StopHeadMotion()
    {
    }

    [Token(Token = "0x6018FEC")]
    [Address(RVA = "0x2CBA8C8", Offset = "0x2CBA8C8", VA = "0x2CBA8C8")]
    public static Adv2Human Create(string objectName, Transform parent) => (Adv2Human) null;

    [Token(Token = "0x6018FED")]
    [Address(RVA = "0x2CBA928", Offset = "0x2CBA928", VA = "0x2CBA928")]
    public Adv2Human()
    {
    }
  }
}
