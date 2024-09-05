// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EBC")]
  [MoonSharpUserData]
  public class LuaObject : LuaSignal, IDisposable
  {
    [Token(Token = "0x4011341")]
    [FieldOffset(Offset = "0x18")]
    protected Adv2Object advObject;
    [Token(Token = "0x4011342")]
    [FieldOffset(Offset = "0x20")]
    private int skipDefaultTriggerCount;
    [Token(Token = "0x4011343")]
    [FieldOffset(Offset = "0x28")]
    private string beforeTriggerName;
    [Token(Token = "0x4011344")]
    [FieldOffset(Offset = "0x30")]
    private string defaultTriggerName;

    [Token(Token = "0x170051D6")]
    public Adv2Object Instance
    {
      [Token(Token = "0x6019472"), Address(RVA = "0x2FF5594", Offset = "0x2FF5594", VA = "0x2FF5594")] get
      {
        return (Adv2Object) null;
      }
    }

    [Token(Token = "0x170051D7")]
    public int SkipDefaultTriggerCount
    {
      [Token(Token = "0x6019473"), Address(RVA = "0x2FF559C", Offset = "0x2FF559C", VA = "0x2FF559C")] get
      {
        return new int();
      }
      [Token(Token = "0x6019474"), Address(RVA = "0x2FF55A4", Offset = "0x2FF55A4", VA = "0x2FF55A4")] set
      {
      }
    }

    [Token(Token = "0x6019475")]
    [Address(RVA = "0x2FECD94", Offset = "0x2FECD94", VA = "0x2FECD94")]
    public LuaObject(Adv2Object instance)
    {
    }

    [Token(Token = "0x6019476")]
    [Address(RVA = "0x2FF20BC", Offset = "0x2FF20BC", VA = "0x2FF20BC", Slot = "4")]
    public override void Empty(bool isRemoveObject)
    {
    }

    [Token(Token = "0x6019477")]
    [Address(RVA = "0x2FF55AC", Offset = "0x2FF55AC", VA = "0x2FF55AC", Slot = "5")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6019478")]
    [Address(RVA = "0x2FF55BC", Offset = "0x2FF55BC", VA = "0x2FF55BC")]
    public string GetName() => (string) null;

    [Token(Token = "0x6019479")]
    [Address(RVA = "0x2FF55E4", Offset = "0x2FF55E4", VA = "0x2FF55E4")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x601947A")]
    [Address(RVA = "0x2FF5614", Offset = "0x2FF5614", VA = "0x2FF5614")]
    public void LoadModel(string objectAssetbundleName, string objectFileName)
    {
    }

    [Token(Token = "0x601947B")]
    [Address(RVA = "0x2FF569C", Offset = "0x2FF569C", VA = "0x2FF569C")]
    public void LoadModel(
      string objectAssetbundleName,
      string objectFileName,
      string animationAssetbundleName,
      string animationFileName)
    {
    }

    [Token(Token = "0x601947C")]
    [Address(RVA = "0x2FF56CC", Offset = "0x2FF56CC", VA = "0x2FF56CC")]
    public void LoadAnim(string animationAssetbundleName, string animationFileName)
    {
    }

    [Token(Token = "0x601947D")]
    [Address(RVA = "0x2FF5724", Offset = "0x2FF5724", VA = "0x2FF5724")]
    public void SetAnimationSystemChangeTime(float startTime, float exitTime)
    {
    }

    [Token(Token = "0x601947E")]
    [Address(RVA = "0x2FF5744", Offset = "0x2FF5744", VA = "0x2FF5744")]
    public void RemoveInside()
    {
    }

    [Token(Token = "0x601947F")]
    [Address(RVA = "0x2FEE7D8", Offset = "0x2FEE7D8", VA = "0x2FEE7D8", Slot = "6")]
    public virtual void InitializeTransform(
      float posX,
      float posY,
      float posZ,
      float angX,
      float angY,
      float angZ,
      float scaleX,
      float scaleY,
      float scaleZ)
    {
    }

    [Token(Token = "0x6019480")]
    [Address(RVA = "0x2FF57DC", Offset = "0x2FF57DC", VA = "0x2FF57DC")]
    public void SetPos(float posX, float posY, float posZ)
    {
    }

    [Token(Token = "0x6019481")]
    [Address(RVA = "0x2FF580C", Offset = "0x2FF580C", VA = "0x2FF580C")]
    public void SetRot(float angX, float angY, float angZ)
    {
    }

    [Token(Token = "0x6019482")]
    [Address(RVA = "0x2FF583C", Offset = "0x2FF583C", VA = "0x2FF583C")]
    public void SetScale(float scaleX, float scaleY, float scaleZ)
    {
    }

    [Token(Token = "0x6019483")]
    [Address(RVA = "0x2FF586C", Offset = "0x2FF586C", VA = "0x2FF586C")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6019484")]
    [Address(RVA = "0x2FF5890", Offset = "0x2FF5890", VA = "0x2FF5890", Slot = "7")]
    public virtual bool IsActive() => new bool();

    [Token(Token = "0x6019485")]
    [Address(RVA = "0x2FF58B0", Offset = "0x2FF58B0", VA = "0x2FF58B0")]
    public void SetLookAtObject(LuaObject target)
    {
    }

    [Token(Token = "0x6019486")]
    [Address(RVA = "0x2FF58D4", Offset = "0x2FF58D4", VA = "0x2FF58D4")]
    public void ResetLookAtObject()
    {
    }

    [Token(Token = "0x6019487")]
    [Address(RVA = "0x2FF1BE0", Offset = "0x2FF1BE0", VA = "0x2FF1BE0")]
    public LuaSignalMini Move(float x, float y, float z, float duration, bool isEaseInOut)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019488")]
    [Address(RVA = "0x2FF58F0", Offset = "0x2FF58F0", VA = "0x2FF58F0")]
    public LuaSignalMini AroundMove(LuaObject target, float angle, float duration, int speedType)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019489")]
    [Address(RVA = "0x2FF59AC", Offset = "0x2FF59AC", VA = "0x2FF59AC")]
    public LuaSignalMini SlideMove(float x, float y, float z, float duration, int speedType)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601948A")]
    [Address(RVA = "0x2FF5A7C", Offset = "0x2FF5A7C", VA = "0x2FF5A7C")]
    public LuaSignalMini CurveMove(
      float pathX,
      float pathY,
      float pathZ,
      float endX,
      float endY,
      float endZ,
      float duration,
      int speedType)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601948B")]
    [Address(RVA = "0x2FF5B78", Offset = "0x2FF5B78", VA = "0x2FF5B78")]
    public LuaSignalMini CircleMove(
      float x,
      float y,
      float z,
      float angle,
      float duration,
      int speedType)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601948C")]
    [Address(RVA = "0x2FF5C58", Offset = "0x2FF5C58", VA = "0x2FF5C58")]
    public LuaSignalMini GroundMove(float x, float y, float z, float duration, bool usenavimesh)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601948D")]
    [Address(RVA = "0x2FF5D18", Offset = "0x2FF5D18", VA = "0x2FF5D18")]
    public void SetGroundPos()
    {
    }

    [Token(Token = "0x601948E")]
    [Address(RVA = "0x2FF5D98", Offset = "0x2FF5D98", VA = "0x2FF5D98")]
    public LuaSignalMini TransMove(float x, float y, float z, float duration)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601948F")]
    [Address(RVA = "0x2FF5E54", Offset = "0x2FF5E54", VA = "0x2FF5E54")]
    public LuaSignalMini Rotate(float x, float y, float z, float duration, bool isEaseInOut)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019490")]
    [Address(RVA = "0x2FF5F18", Offset = "0x2FF5F18", VA = "0x2FF5F18")]
    public LuaSignalMini TransRotate(float x, float y, float z, float duration)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019491")]
    [Address(RVA = "0x2FF5FD0", Offset = "0x2FF5FD0", VA = "0x2FF5FD0")]
    public LuaSignalMini RotateLookAt(
      float x,
      float y,
      float z,
      float duration,
      bool isEaseInOut)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019492")]
    [Address(RVA = "0x2FF5FE0", Offset = "0x2FF5FE0", VA = "0x2FF5FE0")]
    public LuaSignalMini RotateLookAt(LuaObject target, float duration, bool isEaseInOut)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019493")]
    [Address(RVA = "0x2FF6034", Offset = "0x2FF6034", VA = "0x2FF6034", Slot = "8")]
    protected virtual LuaSignalMini RotateLookAt(
      Vector3 position,
      float duration,
      bool isEaseInOut)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019494")]
    [Address(RVA = "0x2FEE8F4", Offset = "0x2FEE8F4", VA = "0x2FEE8F4")]
    public void SetParent(
      LuaObject parent,
      string[] path,
      float posX,
      float posY,
      float posZ,
      float angX,
      float angY,
      float angZ)
    {
    }

    [Token(Token = "0x6019495")]
    [Address(RVA = "0x2FF6160", Offset = "0x2FF6160", VA = "0x2FF6160")]
    public void SetOffsetPosition(float posX, float posY, float posZ)
    {
    }

    [Token(Token = "0x6019496")]
    [Address(RVA = "0x2FF617C", Offset = "0x2FF617C", VA = "0x2FF617C")]
    public void SetOffsetEulerAngles(float angX, float angY, float angZ)
    {
    }

    [Token(Token = "0x6019497")]
    [Address(RVA = "0x2FF6198", Offset = "0x2FF6198", VA = "0x2FF6198")]
    public void ResetParent()
    {
    }

    [Token(Token = "0x6019498")]
    [Address(RVA = "0x2FF61B4", Offset = "0x2FF61B4", VA = "0x2FF61B4")]
    public LuaSignalMini PlayAnimation(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool isLoop)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019499")]
    [Address(RVA = "0x2FF62E0", Offset = "0x2FF62E0", VA = "0x2FF62E0")]
    public LuaSignalMini PlayAnimation(
      string animationTag1,
      string animationTag2,
      float transitionDuration1,
      float transitionDuration2,
      float playSpeed)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601949A")]
    [Address(RVA = "0x2FF49F8", Offset = "0x2FF49F8", VA = "0x2FF49F8")]
    public void PlayAnimatorAnimation(string currenTriggerName)
    {
    }

    [Token(Token = "0x601949B")]
    [Address(RVA = "0x2FF6484", Offset = "0x2FF6484", VA = "0x2FF6484")]
    public bool CheckControllerName(string controllerName) => new bool();

    [Token(Token = "0x601949C")]
    [Address(RVA = "0x2FF64A0", Offset = "0x2FF64A0", VA = "0x2FF64A0")]
    public void SetBeforeTriggerName(string triggerName)
    {
    }

    [Token(Token = "0x601949D")]
    [Address(RVA = "0x2FF64A8", Offset = "0x2FF64A8", VA = "0x2FF64A8")]
    public void SetDefaultTrigger()
    {
    }

    [Token(Token = "0x601949E")]
    [Address(RVA = "0x2FF6500", Offset = "0x2FF6500", VA = "0x2FF6500")]
    public void SetSkipDefautTrigger(int count)
    {
    }

    [Token(Token = "0x601949F")]
    [Address(RVA = "0x2FF6508", Offset = "0x2FF6508", VA = "0x2FF6508")]
    public void DecrementSkipDefautTrigger()
    {
    }

    [Token(Token = "0x60194A0")]
    [Address(RVA = "0x2FF651C", Offset = "0x2FF651C", VA = "0x2FF651C")]
    public void ResetDefaultTrigger()
    {
    }

    [Token(Token = "0x60194A1")]
    [Address(RVA = "0x2FF6564", Offset = "0x2FF6564", VA = "0x2FF6564")]
    public void SetDefaultTriggerName(string triggerName)
    {
    }

    [Token(Token = "0x60194A2")]
    [Address(RVA = "0x2FF658C", Offset = "0x2FF658C", VA = "0x2FF658C")]
    public void CheckStanding(string controllerId)
    {
    }

    [Token(Token = "0x60194A3")]
    [Address(RVA = "0x2FF4930", Offset = "0x2FF4930", VA = "0x2FF4930")]
    public bool ExistsAnimator() => new bool();

    [Token(Token = "0x60194A4")]
    [Address(RVA = "0x2FF65FC", Offset = "0x2FF65FC", VA = "0x2FF65FC")]
    public void AnimatorTurn(string currenTriggerName, int rotateAngle, float duration)
    {
    }

    [Token(Token = "0x60194A5")]
    [Address(RVA = "0x2FF6640", Offset = "0x2FF6640", VA = "0x2FF6640")]
    public void AnimationTurn(
      string animationTag1,
      string animationTag2,
      float transitionDuration1,
      float transitionDuration2,
      int playSpeed,
      int rotateAngle,
      float duration)
    {
    }

    [Token(Token = "0x60194A6")]
    [Address(RVA = "0x2FF6280", Offset = "0x2FF6280", VA = "0x2FF6280")]
    public bool IsPauseAnimation() => new bool();

    [Token(Token = "0x60194A7")]
    [Address(RVA = "0x2FF66B4", Offset = "0x2FF66B4", VA = "0x2FF66B4")]
    private bool ExistsTrigger(string trigger) => new bool();

    [Token(Token = "0x60194A8")]
    [Address(RVA = "0x2FF63D4", Offset = "0x2FF63D4", VA = "0x2FF63D4")]
    private bool IsExecuteTrigger(string trigger) => new bool();

    [Token(Token = "0x60194A9")]
    [Address(RVA = "0x2FF6750", Offset = "0x2FF6750", VA = "0x2FF6750")]
    public DynValue GetPartsPosition(string objectName) => (DynValue) null;

    [Token(Token = "0x60194AA")]
    [Address(RVA = "0x2FF68E4", Offset = "0x2FF68E4", VA = "0x2FF68E4")]
    public void SetAnimationEventSound(string typeName, string tagName, string soundName)
    {
    }

    [Token(Token = "0x60194AB")]
    [Address(RVA = "0x2FF6900", Offset = "0x2FF6900", VA = "0x2FF6900")]
    public void KeepTurnLookat(LuaObject target, float inter)
    {
    }

    [Token(Token = "0x60194AC")]
    [Address(RVA = "0x2FF693C", Offset = "0x2FF693C", VA = "0x2FF693C")]
    public DynValue GetPos() => (DynValue) null;

    [Token(Token = "0x60194AD")]
    [Address(RVA = "0x2FF6A10", Offset = "0x2FF6A10", VA = "0x2FF6A10")]
    public DynValue GetRot() => (DynValue) null;

    [Token(Token = "0x60194AE")]
    [Address(RVA = "0x2FF6AE4", Offset = "0x2FF6AE4", VA = "0x2FF6AE4")]
    public void SetBindObjectName(string name)
    {
    }

    [Token(Token = "0x60194AF")]
    [Address(RVA = "0x2FF6B00", Offset = "0x2FF6B00", VA = "0x2FF6B00")]
    public void ResetDynamicBone()
    {
    }

    [Token(Token = "0x60194B0")]
    [Address(RVA = "0x2FF6B1C", Offset = "0x2FF6B1C", VA = "0x2FF6B1C")]
    public void LinkObject(string objectname)
    {
    }

    [Token(Token = "0x60194B1")]
    [Address(RVA = "0x2FF6438", Offset = "0x2FF6438", VA = "0x2FF6438")]
    private void StopBodyAnimation()
    {
    }

    [Token(Token = "0x60194B2")]
    [Address(RVA = "0x2FF62A4", Offset = "0x2FF62A4", VA = "0x2FF62A4")]
    private void PlayBodyAnimationPack()
    {
    }

    [Token(Token = "0x60194B3")]
    [Address(RVA = "0x2FF6C70", Offset = "0x2FF6C70", VA = "0x2FF6C70")]
    public void ReleaseBodyAnimation()
    {
    }
  }
}
