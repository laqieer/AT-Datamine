// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapPlayerInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Scriptable;
using FreeMap.UI;
using FreeMap.UI.ColliderEvent;
using GameCore.Animation;
using Il2CppDummyDll;
using Story;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C1")]
  [RequireComponent(typeof (SphereCollider))]
  [RequireComponent(typeof (NavMeshAgent))]
  public class FreeMapPlayerInstance : FreeMapCharacter, ITrackedCamera, IMoveDistanceController
  {
    [Token(Token = "0x4006B6F")]
    public const int MAINPLAYER_KEY = 0;
    [Token(Token = "0x4006B70")]
    public const int SUBPLAYER_KEY = 1;
    [Token(Token = "0x4006B71")]
    public const float RunRatio = 1f;
    [Token(Token = "0x4006B72")]
    public const float WalkRatio = 0.05f;
    [Token(Token = "0x4006B73")]
    public const float DefaultAnimationRate = 1f;
    [Token(Token = "0x4006B76")]
    [FieldOffset(Offset = "0x90")]
    protected FreeMapCharacterFacialAction myFacialAction;
    [Token(Token = "0x4006B78")]
    [FieldOffset(Offset = "0xA0")]
    protected Transform useCameraTransform;
    [Token(Token = "0x4006B79")]
    [FieldOffset(Offset = "0xA8")]
    private bool isMoveAnimationUpdate;

    [Token(Token = "0x17001693")]
    protected FreeMapPlayerAutoMove AutoMove
    {
      [Token(Token = "0x6008CA0"), Address(RVA = "0x452EA7C", Offset = "0x452EA7C", VA = "0x452EA7C")] get
      {
        return (FreeMapPlayerAutoMove) null;
      }
    }

    [Token(Token = "0x17001694")]
    protected FreeMapPlayerMoveController MoveController
    {
      [Token(Token = "0x6008CA1"), Address(RVA = "0x452EA84", Offset = "0x452EA84", VA = "0x452EA84")] get
      {
        return (FreeMapPlayerMoveController) null;
      }
    }

    [Token(Token = "0x17001695")]
    public FreeMapSideRuntimeAnimatorControl MyAnimator
    {
      [Token(Token = "0x6008CA2"), Address(RVA = "0x452EA8C", Offset = "0x452EA8C", VA = "0x452EA8C")] get
      {
        return (FreeMapSideRuntimeAnimatorControl) null;
      }
    }

    [Token(Token = "0x17001696")]
    public Collider Collider
    {
      [Token(Token = "0x6008CA3"), Address(RVA = "0x452EAB0", Offset = "0x452EAB0", VA = "0x452EAB0")] private set
      {
      }
      [Token(Token = "0x6008CA4"), Address(RVA = "0x452EAB8", Offset = "0x452EAB8", VA = "0x452EAB8")] get
      {
        return (Collider) null;
      }
    }

    [Token(Token = "0x17001697")]
    public Transform CameraTransform
    {
      [Token(Token = "0x6008CA5"), Address(RVA = "0x452EAC0", Offset = "0x452EAC0", VA = "0x452EAC0", Slot = "16")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17001698")]
    public bool IsAutoMove
    {
      [Token(Token = "0x6008CA6"), Address(RVA = "0x452EAC8", Offset = "0x452EAC8", VA = "0x452EAC8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001699")]
    public bool IsCompleteAutoMove
    {
      [Token(Token = "0x6008CA7"), Address(RVA = "0x452EAF0", Offset = "0x452EAF0", VA = "0x452EAF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700169A")]
    public bool IsMoveStoped
    {
      [Token(Token = "0x6008CA8"), Address(RVA = "0x452EB14", Offset = "0x452EB14", VA = "0x452EB14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700169B")]
    public bool IsMoving
    {
      [Token(Token = "0x6008CA9"), Address(RVA = "0x452EBFC", Offset = "0x452EBFC", VA = "0x452EBFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700169C")]
    public StoryCharacterMoveBehaviour.MoveSpeedType CurrentMoveSpeedType
    {
      [Token(Token = "0x6008CAA"), Address(RVA = "0x452EC14", Offset = "0x452EC14", VA = "0x452EC14")] get
      {
        return new StoryCharacterMoveBehaviour.MoveSpeedType();
      }
    }

    [Token(Token = "0x6008CAB")]
    [Address(RVA = "0x452EC30", Offset = "0x452EC30", VA = "0x452EC30")]
    public void PlayerBaseInitialize()
    {
    }

    [Token(Token = "0x6008CAC")]
    [Address(RVA = "0x452EE54", Offset = "0x452EE54", VA = "0x452EE54")]
    public void SetMoveSpeedMagnification(float magnification)
    {
    }

    [Token(Token = "0x6008CAD")]
    [Address(RVA = "0x452EE70", Offset = "0x452EE70", VA = "0x452EE70")]
    public void SetAnimationSpeed(float walkSpeed, float runSpeed)
    {
    }

    [Token(Token = "0x6008CAE")]
    [Address(RVA = "0x452EE94", Offset = "0x452EE94", VA = "0x452EE94", Slot = "8")]
    public override void InstanceUpdate()
    {
    }

    [Token(Token = "0x6008CAF")]
    [Address(RVA = "0x452EF54", Offset = "0x452EF54", VA = "0x452EF54", Slot = "9")]
    public override void InstanceLateUpdate()
    {
    }

    [Token(Token = "0x6008CB0")]
    [Address(RVA = "0x452EF88", Offset = "0x452EF88", VA = "0x452EF88", Slot = "7")]
    public override void PlaceInMap(FreeMapPlacementObject placementObject)
    {
    }

    [Token(Token = "0x6008CB1")]
    [Address(RVA = "0x452F088", Offset = "0x452F088", VA = "0x452F088", Slot = "17")]
    public void BindCameraTransform(Transform cameraTransform)
    {
    }

    [Token(Token = "0x6008CB2")]
    [Address(RVA = "0x452F090", Offset = "0x452F090", VA = "0x452F090", Slot = "18")]
    public void SetMoveSpeedValiable(
      StoryCharacterMoveBehaviour.MoveSpeedType speedType,
      float duration)
    {
    }

    [Token(Token = "0x6008CB3")]
    [Address(RVA = "0x452AB3C", Offset = "0x452AB3C", VA = "0x452AB3C")]
    public void RegisterInputProvider(IPlayerInputProvider provider)
    {
    }

    [Token(Token = "0x6008CB4")]
    [Address(RVA = "0x452F154", Offset = "0x452F154", VA = "0x452F154")]
    protected void OnInputUpdate(Vector3 direction, float force)
    {
    }

    [Token(Token = "0x6008CB5")]
    [Address(RVA = "0x452F258", Offset = "0x452F258", VA = "0x452F258")]
    public void AlwaysRunMoveAutoStart(Vector3 targetPosition, Vector3 lookAtPosition)
    {
    }

    [Token(Token = "0x6008CB6")]
    [Address(RVA = "0x452F2E4", Offset = "0x452F2E4", VA = "0x452F2E4")]
    public bool IsAlwaysRunMoveAutoStarted() => new bool();

    [Token(Token = "0x6008CB7")]
    [Address(RVA = "0x452F1CC", Offset = "0x452F1CC", VA = "0x452F1CC")]
    private void MoveAnimationUpdate(Vector3 direction, float force)
    {
    }

    [Token(Token = "0x6008CB8")]
    [Address(RVA = "0x452F17C", Offset = "0x452F17C", VA = "0x452F17C")]
    private void MoveUpdate(Vector3 direction, float force)
    {
    }

    [Token(Token = "0x6008CB9")]
    [Address(RVA = "0x452F44C", Offset = "0x452F44C", VA = "0x452F44C", Slot = "19")]
    public virtual void PlayerWarp(Vector3 position, Vector3 eulerAngles)
    {
    }

    [Token(Token = "0x6008CBA")]
    [Address(RVA = "0x452F698", Offset = "0x452F698", VA = "0x452F698")]
    public GameObject MoveStartAuto(FreeMapUITransformHolder holder, Vector3 lookAtPosition)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6008CBB")]
    [Address(RVA = "0x452F754", Offset = "0x452F754", VA = "0x452F754")]
    public GameObject MoveStartAuto(Vector3 targetPosition, Vector3 lookAtPosition)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6008CBC")]
    [Address(RVA = "0x452F784", Offset = "0x452F784", VA = "0x452F784")]
    public void StopAutoMove()
    {
    }

    [Token(Token = "0x6008CBD")]
    [Address(RVA = "0x452F8CC", Offset = "0x452F8CC", VA = "0x452F8CC")]
    public void LookAtPoint(Transform target, bool adjustPlayerHeadLine)
    {
    }

    [Token(Token = "0x6008CBE")]
    [Address(RVA = "0x452F7AC", Offset = "0x452F7AC", VA = "0x452F7AC")]
    public void StopLookingPoint()
    {
    }

    [Token(Token = "0x1400011E")]
    public event FreeMapPlayerInstance.ColliderEvent ColliderOnEnter
    {
      [Token(Token = "0x6008CBF"), Address(RVA = "0x452FA94", Offset = "0x452FA94", VA = "0x452FA94")] add
      {
      }
      [Token(Token = "0x6008CC0"), Address(RVA = "0x452FB30", Offset = "0x452FB30", VA = "0x452FB30")] remove
      {
      }
    }

    [Token(Token = "0x1400011F")]
    public event FreeMapPlayerInstance.ColliderEvent ColliderOnExit
    {
      [Token(Token = "0x6008CC1"), Address(RVA = "0x452FBCC", Offset = "0x452FBCC", VA = "0x452FBCC")] add
      {
      }
      [Token(Token = "0x6008CC2"), Address(RVA = "0x452FC68", Offset = "0x452FC68", VA = "0x452FC68")] remove
      {
      }
    }

    [Token(Token = "0x6008CC3")]
    [Address(RVA = "0x452FD04", Offset = "0x452FD04", VA = "0x452FD04")]
    private void OnTriggerEnter(Collider collision)
    {
    }

    [Token(Token = "0x6008CC4")]
    [Address(RVA = "0x452FD14", Offset = "0x452FD14", VA = "0x452FD14", Slot = "20")]
    protected virtual void TriggerEnter(Collider collision)
    {
    }

    [Token(Token = "0x6008CC5")]
    [Address(RVA = "0x452FDA4", Offset = "0x452FDA4", VA = "0x452FDA4")]
    public void BindAnimatorController(
      RuntimeAnimatorController controller,
      float blinkMin,
      float blinkMax)
    {
    }

    [Token(Token = "0x6008CC6")]
    [Address(RVA = "0x452FEF0", Offset = "0x452FEF0", VA = "0x452FEF0", Slot = "10")]
    public override void ReleaseInstance()
    {
    }

    [Token(Token = "0x6008CC7")]
    [Address(RVA = "0x452FF08", Offset = "0x452FF08", VA = "0x452FF08")]
    private void OnDrawGizmos()
    {
    }

    [Token(Token = "0x6008CC8")]
    [Address(RVA = "0x452FF20", Offset = "0x452FF20", VA = "0x452FF20")]
    public FreeMapPlayerInstance()
    {
    }

    [Token(Token = "0x20018C2")]
    public delegate void ColliderEvent(
      FreeMapPlayerInstance player,
      IFreeMapColliderEventObject collidableObject);
  }
}
