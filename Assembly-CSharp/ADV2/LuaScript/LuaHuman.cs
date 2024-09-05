// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaHuman
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing;
using GameCore.Animation;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB7")]
  [MoonSharpUserData]
  public class LuaHuman : LuaObject
  {
    [Token(Token = "0x401131D")]
    [FieldOffset(Offset = "0x38")]
    public string FaceImageTag;
    [Token(Token = "0x401131E")]
    [FieldOffset(Offset = "0x40")]
    public string CutinImageTag;
    [Token(Token = "0x401131F")]
    [FieldOffset(Offset = "0x48")]
    public string ThumbImageTag;
    [Token(Token = "0x4011320")]
    [FieldOffset(Offset = "0x50")]
    public string FullImageTag;
    [Token(Token = "0x4011321")]
    [FieldOffset(Offset = "0x58")]
    public string HiResImageTag;
    [Token(Token = "0x4011322")]
    [FieldOffset(Offset = "0x60")]
    public string ActiveFacialTag;
    [Token(Token = "0x4011323")]
    [FieldOffset(Offset = "0x68")]
    private IllustLayoutInfo illustLayoutInfoCutin;
    [Token(Token = "0x4011324")]
    [FieldOffset(Offset = "0x70")]
    private IllustLayoutInfo illustLayoutInfoHiRes;
    [Token(Token = "0x4011325")]
    [FieldOffset(Offset = "0x78")]
    public int StyleId;
    [Token(Token = "0x4011326")]
    [FieldOffset(Offset = "0x80")]
    protected EyeBlendShapesController controller;
    [Token(Token = "0x4011327")]
    [FieldOffset(Offset = "0x88")]
    private Adv2Human advHuman;
    [Token(Token = "0x4011328")]
    [FieldOffset(Offset = "0x90")]
    private FreeAnimatorController freeAnimController;
    [Token(Token = "0x4011329")]
    private const float neckLimitAngle = 90f;
    [Token(Token = "0x401132A")]
    private const float neckAddAngle = 45f;
    [Token(Token = "0x401132B")]
    [FieldOffset(Offset = "0x98")]
    private bool isEnableAutoLookat;
    [Token(Token = "0x401132C")]
    [FieldOffset(Offset = "0x99")]
    private bool isNo3DModel;
    [Token(Token = "0x401132D")]
    [FieldOffset(Offset = "0x9A")]
    private bool isSetWeight;
    [Token(Token = "0x401132E")]
    [FieldOffset(Offset = "0xA0")]
    private IEnumerator delayWeight;

    [Token(Token = "0x170051C8")]
    public IllustLayoutInfo IllustLayoutInfoCutin
    {
      [Token(Token = "0x601941C"), Address(RVA = "0x2FF1CC4", Offset = "0x2FF1CC4", VA = "0x2FF1CC4")] get
      {
        return (IllustLayoutInfo) null;
      }
      [Token(Token = "0x601941D"), Address(RVA = "0x2FF1CCC", Offset = "0x2FF1CCC", VA = "0x2FF1CCC")] private set
      {
      }
    }

    [Token(Token = "0x170051C9")]
    public IllustLayoutInfo IllustLayoutInfoHiRes
    {
      [Token(Token = "0x601941E"), Address(RVA = "0x2FF1CD4", Offset = "0x2FF1CD4", VA = "0x2FF1CD4")] get
      {
        return (IllustLayoutInfo) null;
      }
      [Token(Token = "0x601941F"), Address(RVA = "0x2FF1CDC", Offset = "0x2FF1CDC", VA = "0x2FF1CDC")] private set
      {
      }
    }

    [Token(Token = "0x170051CA")]
    protected bool isValidEyeController
    {
      [Token(Token = "0x6019420"), Address(RVA = "0x2FF1CE4", Offset = "0x2FF1CE4", VA = "0x2FF1CE4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170051CB")]
    private Adv2Human AdvHuman
    {
      [Token(Token = "0x6019421"), Address(RVA = "0x2FF1D88", Offset = "0x2FF1D88", VA = "0x2FF1D88")] get
      {
        return (Adv2Human) null;
      }
    }

    [Token(Token = "0x170051CC")]
    private FreeAnimatorController FreeAnimController
    {
      [Token(Token = "0x6019422"), Address(RVA = "0x2FF1E58", Offset = "0x2FF1E58", VA = "0x2FF1E58")] get
      {
        return (FreeAnimatorController) null;
      }
    }

    [Token(Token = "0x6019423")]
    [Address(RVA = "0x2FF1F68", Offset = "0x2FF1F68", VA = "0x2FF1F68")]
    public int ReadStyleIdfromModelName() => new int();

    [Token(Token = "0x6019424")]
    [Address(RVA = "0x2FF1FA0", Offset = "0x2FF1FA0", VA = "0x2FF1FA0")]
    public LuaHuman(Adv2Human instance)
    {
    }

    [Token(Token = "0x6019425")]
    [Address(RVA = "0x2FF201C", Offset = "0x2FF201C", VA = "0x2FF201C", Slot = "4")]
    public override void Empty(bool isRemoveObject)
    {
    }

    [Token(Token = "0x6019426")]
    [Address(RVA = "0x2FF214C", Offset = "0x2FF214C", VA = "0x2FF214C")]
    public bool IsNo3DModel() => new bool();

    [Token(Token = "0x6019427")]
    [Address(RVA = "0x2FF2154", Offset = "0x2FF2154", VA = "0x2FF2154")]
    public void LoadModel(
      string objectAssetbundleName,
      string objectFileName,
      string animationAssetbundleName,
      string animationFileName,
      string facialAssetbundleName,
      string facialFileName)
    {
    }

    [Token(Token = "0x6019428")]
    [Address(RVA = "0x2FF222C", Offset = "0x2FF222C", VA = "0x2FF222C")]
    public LuaSignalMini LoadHeadAnimation(
      string headAnimationPackAssetbundleName,
      string headAnimationPackFileName)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019429")]
    [Address(RVA = "0x2FF2310", Offset = "0x2FF2310", VA = "0x2FF2310")]
    public void LoadAnimator(string animationControllerAssetbundleName, string animationController)
    {
    }

    [Token(Token = "0x601942A")]
    [Address(RVA = "0x2FF23B8", Offset = "0x2FF23B8", VA = "0x2FF23B8")]
    public Adv2Manager.OnProccessSignal LoadIllustLayoutCutin(
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601942B")]
    [Address(RVA = "0x2FF247C", Offset = "0x2FF247C", VA = "0x2FF247C")]
    public Adv2Manager.OnProccessSignal LoadIllustLayoutHiRes(
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601942C")]
    [Address(RVA = "0x2FF2540", Offset = "0x2FF2540", VA = "0x2FF2540")]
    public void SetupNo3DModel()
    {
    }

    [Token(Token = "0x601942D")]
    [Address(RVA = "0x2FF25E4", Offset = "0x2FF25E4", VA = "0x2FF25E4")]
    public void LinkModel(
      string accessName,
      string animationAssetbundleName,
      string animationFileName,
      string facialAssetbundleName,
      string facialFileName)
    {
    }

    [Token(Token = "0x601942E")]
    [Address(RVA = "0x2FF2894", Offset = "0x2FF2894", VA = "0x2FF2894", Slot = "8")]
    protected override LuaSignalMini RotateLookAt(
      Vector3 position,
      float duration,
      bool isEaseInOut)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601942F")]
    [Address(RVA = "0x2FF2990", Offset = "0x2FF2990", VA = "0x2FF2990")]
    public LuaSignalMini PlayFacial(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool isLoop)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019430")]
    [Address(RVA = "0x2FF2A8C", Offset = "0x2FF2A8C", VA = "0x2FF2A8C")]
    public void SetLipSync(string modeTag)
    {
    }

    [Token(Token = "0x6019431")]
    [Address(RVA = "0x2FF2B7C", Offset = "0x2FF2B7C", VA = "0x2FF2B7C")]
    public void SetLipSyncText(string text, float time)
    {
    }

    [Token(Token = "0x6019432")]
    [Address(RVA = "0x2FF2C10", Offset = "0x2FF2C10", VA = "0x2FF2C10")]
    public void SetIsActiveLipSync(bool flag)
    {
    }

    [Token(Token = "0x6019433")]
    [Address(RVA = "0x2FF2C94", Offset = "0x2FF2C94", VA = "0x2FF2C94")]
    public void ForceEyeSync(string syncTag)
    {
    }

    [Token(Token = "0x6019434")]
    [Address(RVA = "0x2FF2D18", Offset = "0x2FF2D18", VA = "0x2FF2D18")]
    public void ForceLipSync(string syncTag)
    {
    }

    [Token(Token = "0x170051CD")]
    public Action ActionBlink
    {
      [Token(Token = "0x6019435"), Address(RVA = "0x2FF2D9C", Offset = "0x2FF2D9C", VA = "0x2FF2D9C")] set
      {
      }
    }

    [Token(Token = "0x170051CE")]
    public Action ActionCloseEye
    {
      [Token(Token = "0x6019436"), Address(RVA = "0x2FF2E20", Offset = "0x2FF2E20", VA = "0x2FF2E20")] set
      {
      }
    }

    [Token(Token = "0x170051CF")]
    public Action ActionOpenEye
    {
      [Token(Token = "0x6019437"), Address(RVA = "0x2FF2EA4", Offset = "0x2FF2EA4", VA = "0x2FF2EA4")] set
      {
      }
    }

    [Token(Token = "0x170051D0")]
    public Action ActionLipsync
    {
      [Token(Token = "0x6019438"), Address(RVA = "0x2FF2F28", Offset = "0x2FF2F28", VA = "0x2FF2F28")] set
      {
      }
    }

    [Token(Token = "0x170051D1")]
    public Action ActionLipsyncClose
    {
      [Token(Token = "0x6019439"), Address(RVA = "0x2FF2FAC", Offset = "0x2FF2FAC", VA = "0x2FF2FAC")] set
      {
      }
    }

    [Token(Token = "0x170051D2")]
    public Action ActionLipsyncOpen
    {
      [Token(Token = "0x601943A"), Address(RVA = "0x2FF3030", Offset = "0x2FF3030", VA = "0x2FF3030")] set
      {
      }
    }

    [Token(Token = "0x601943B")]
    [Address(RVA = "0x2FF30B4", Offset = "0x2FF30B4", VA = "0x2FF30B4")]
    public void ReserveEyeSync(string syncTag)
    {
    }

    [Token(Token = "0x601943C")]
    [Address(RVA = "0x2FF30D4", Offset = "0x2FF30D4", VA = "0x2FF30D4")]
    public void ReserveLipSync(string syncTag)
    {
    }

    [Token(Token = "0x601943D")]
    [Address(RVA = "0x2FF30F4", Offset = "0x2FF30F4", VA = "0x2FF30F4")]
    public void PlayReservedForceSync()
    {
    }

    [Token(Token = "0x601943E")]
    [Address(RVA = "0x2FF3110", Offset = "0x2FF3110", VA = "0x2FF3110")]
    public void SetDicingImage(CharaImage charaImage, float transitionTime)
    {
    }

    [Token(Token = "0x601943F")]
    [Address(RVA = "0x2FF31A4", Offset = "0x2FF31A4", VA = "0x2FF31A4")]
    public void SetActiveFacialControl(bool is_valid)
    {
    }

    [Token(Token = "0x6019440")]
    [Address(RVA = "0x2FF3228", Offset = "0x2FF3228", VA = "0x2FF3228")]
    public bool GetIsSetWeight() => new bool();

    [Token(Token = "0x6019441")]
    [Address(RVA = "0x2FF3230", Offset = "0x2FF3230", VA = "0x2FF3230")]
    public void SetLookAtWeight(
      float weight,
      float bodyWeight,
      float headWeight,
      float clampWeight)
    {
    }

    [Token(Token = "0x6019442")]
    [Address(RVA = "0x2FF330C", Offset = "0x2FF330C", VA = "0x2FF330C")]
    public void SetLookAtWeightReset()
    {
    }

    [Token(Token = "0x6019443")]
    [Address(RVA = "0x2FF33F4", Offset = "0x2FF33F4", VA = "0x2FF33F4")]
    public void SetLookAtDelayWeight(
      float weight,
      float bodyWeight,
      float headWeight,
      float clampWeight,
      float speed)
    {
    }

    [Token(Token = "0x6019444")]
    [Address(RVA = "0x2FF3658", Offset = "0x2FF3658", VA = "0x2FF3658")]
    public void SetLookAtDelayWeightReset(float speed)
    {
    }

    [Token(Token = "0x6019445")]
    [Address(RVA = "0x2FF35A4", Offset = "0x2FF35A4", VA = "0x2FF35A4")]
    private IEnumerator SetDelayWeight(
      float weight,
      float bodyWeight,
      float headWeight,
      float clampWeight,
      float duration,
      bool isReset = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019446")]
    [Address(RVA = "0x2FF3804", Offset = "0x2FF3804", VA = "0x2FF3804")]
    public void SetLookAtPosition(float posX, float posY, float posZ)
    {
    }

    [Token(Token = "0x6019447")]
    [Address(RVA = "0x2FF3918", Offset = "0x2FF3918", VA = "0x2FF3918")]
    public bool GetEnableAutoLookAt() => new bool();

    [Token(Token = "0x6019448")]
    [Address(RVA = "0x2FF3938", Offset = "0x2FF3938", VA = "0x2FF3938")]
    public void SetEnableAutoLookAt(bool enable)
    {
    }

    [Token(Token = "0x6019449")]
    [Address(RVA = "0x2FF3944", Offset = "0x2FF3944", VA = "0x2FF3944")]
    public DynValue GetBonePosition(string boneName) => (DynValue) null;

    [Token(Token = "0x601944A")]
    [Address(RVA = "0x2FF3B5C", Offset = "0x2FF3B5C", VA = "0x2FF3B5C")]
    public new void ResetDynamicBone()
    {
    }

    [Token(Token = "0x601944B")]
    [Address(RVA = "0x2FF3BD8", Offset = "0x2FF3BD8", VA = "0x2FF3BD8")]
    public void SetLookat(LuaObject targetObject, string partsName)
    {
    }

    [Token(Token = "0x601944C")]
    [Address(RVA = "0x2FF3C54", Offset = "0x2FF3C54", VA = "0x2FF3C54")]
    public void SetLookAngle(float angleH, float angleV)
    {
    }

    [Token(Token = "0x601944D")]
    [Address(RVA = "0x2FF3CA4", Offset = "0x2FF3CA4", VA = "0x2FF3CA4")]
    public void AddEyeControl(
      string objectName,
      float centerX,
      float centerY,
      float centerZ,
      float directionX,
      float directionY,
      float directionZ,
      float minAngleX,
      float maxAngleX,
      float minAngleY,
      float maxAngleY,
      float convertL,
      float convertR,
      float convertU,
      float convertD)
    {
    }

    [Token(Token = "0x601944E")]
    [Address(RVA = "0x2FF3F6C", Offset = "0x2FF3F6C", VA = "0x2FF3F6C")]
    public void SetEyeHilight(float scale, float shiningSpeed)
    {
    }

    [Token(Token = "0x601944F")]
    [Address(RVA = "0x2FF3FC8", Offset = "0x2FF3FC8", VA = "0x2FF3FC8")]
    public void SetEyeScale(float eye, float pupils)
    {
    }

    [Token(Token = "0x6019450")]
    [Address(RVA = "0x2FF4024", Offset = "0x2FF4024", VA = "0x2FF4024")]
    public void KeepIkLookAt(Transform target, bool useDmyTarget = false)
    {
    }

    [Token(Token = "0x6019451")]
    [Address(RVA = "0x2FF4480", Offset = "0x2FF4480", VA = "0x2FF4480")]
    public Transform KeepIkLookAt(LuaObject target, string objectName, bool useDummyTarget = false)
    {
      return (Transform) null;
    }

    [Token(Token = "0x6019452")]
    [Address(RVA = "0x2FF4590", Offset = "0x2FF4590", VA = "0x2FF4590")]
    public void KeepDelayIkLookAt(
      LuaObject target,
      string objectName,
      float speed,
      bool useDummyTarget = false)
    {
    }

    [Token(Token = "0x6019453")]
    [Address(RVA = "0x2FF4708", Offset = "0x2FF4708", VA = "0x2FF4708")]
    public Transform KeepIkLookAtObject(string objectParent, string objectName) => (Transform) null;

    [Token(Token = "0x6019454")]
    [Address(RVA = "0x2FF4794", Offset = "0x2FF4794", VA = "0x2FF4794")]
    public void KeepDelayIkLookAtObject(string objectParent, string objectName, float speed)
    {
    }

    [Token(Token = "0x6019455")]
    [Address(RVA = "0x2FF48B4", Offset = "0x2FF48B4", VA = "0x2FF48B4")]
    public void SetLookAtOffset(float x, float y, float z)
    {
    }

    [Token(Token = "0x6019456")]
    [Address(RVA = "0x2FF48F8", Offset = "0x2FF48F8", VA = "0x2FF48F8")]
    public void SetAnimationTrigger(string triggerName)
    {
    }

    [Token(Token = "0x6019457")]
    [Address(RVA = "0x2FF4B84", Offset = "0x2FF4B84", VA = "0x2FF4B84")]
    public void PlayHeadMotion(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool loop)
    {
    }

    [Token(Token = "0x6019458")]
    [Address(RVA = "0x2FF4C30", Offset = "0x2FF4C30", VA = "0x2FF4C30")]
    public void StopHeadMotion()
    {
    }
  }
}
