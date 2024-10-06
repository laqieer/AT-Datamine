// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Scriptable;
using FreeMap.UI.ColliderEvent;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018DE")]
  public abstract class FreeMapInstance : MonoBehaviour, IFreeMapInstance
  {
    [Token(Token = "0x4006BC2")]
    [FieldOffset(Offset = "0x18")]
    protected InstanceID instanceID;
    [Token(Token = "0x4006BC3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected string anchorName;
    [Token(Token = "0x4006BC4")]
    [FieldOffset(Offset = "0x28")]
    protected Vector3 positionOffset;
    [Token(Token = "0x4006BC5")]
    [FieldOffset(Offset = "0x34")]
    protected float rotationOffsetY;
    [Token(Token = "0x4006BC7")]
    [FieldOffset(Offset = "0x3C")]
    protected Vector3 iconBasePosition;

    [Token(Token = "0x170016A2")]
    public string AnchorName
    {
      [Token(Token = "0x6008D2B"), Address(RVA = "0x4532F64", Offset = "0x4532F64", VA = "0x4532F64")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016A3")]
    public float RotationOffsetY
    {
      [Token(Token = "0x6008D2C"), Address(RVA = "0x4532F6C", Offset = "0x4532F6C", VA = "0x4532F6C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170016A4")]
    public int AffiliationClipRangeIndex
    {
      [Token(Token = "0x6008D2D"), Address(RVA = "0x4532F74", Offset = "0x4532F74", VA = "0x4532F74")] get
      {
        return new int();
      }
      [Token(Token = "0x6008D2E"), Address(RVA = "0x4532F7C", Offset = "0x4532F7C", VA = "0x4532F7C")] private set
      {
      }
    }

    [Token(Token = "0x170016A5")]
    public Vector3 IconBasePosition
    {
      [Token(Token = "0x6008D2F"), Address(RVA = "0x4532F84", Offset = "0x4532F84", VA = "0x4532F84")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170016A6")]
    public FreeMapActionCircleMonobehaviour ActionCircle
    {
      [Token(Token = "0x6008D30"), Address(RVA = "0x4532F90", Offset = "0x4532F90", VA = "0x4532F90")] get
      {
        return (FreeMapActionCircleMonobehaviour) null;
      }
      [Token(Token = "0x6008D31"), Address(RVA = "0x4532F98", Offset = "0x4532F98", VA = "0x4532F98")] set
      {
      }
    }

    [Token(Token = "0x6008D32")]
    public T AddComponent<T>() where T : Component => (T) null;

    [Token(Token = "0x6008D33")]
    [Address(RVA = "0x4532FA0", Offset = "0x4532FA0", VA = "0x4532FA0")]
    public string GetAnchorName() => (string) null;

    [Token(Token = "0x6008D34")]
    [Address(RVA = "0x4532FA8", Offset = "0x4532FA8", VA = "0x4532FA8")]
    public void SetAnchorName(string anchorName)
    {
    }

    [Token(Token = "0x6008D35")]
    [Address(RVA = "0x4532FB0", Offset = "0x4532FB0", VA = "0x4532FB0")]
    public InstanceID GetID() => new InstanceID();

    [Token(Token = "0x6008D36")]
    [Address(RVA = "0x4532FB8", Offset = "0x4532FB8", VA = "0x4532FB8")]
    public void SetIconBasePosition(Vector3 pos)
    {
    }

    [Token(Token = "0x6008D37")]
    [Address(RVA = "0x4532FC4", Offset = "0x4532FC4", VA = "0x4532FC4", Slot = "7")]
    public virtual void PlaceInMap(FreeMapPlacementObject placementObject)
    {
    }

    [Token(Token = "0x6008D38")]
    [Address(RVA = "0x4533100", Offset = "0x4533100", VA = "0x4533100")]
    public void Initialize(
      InstanceID instanceID,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008D39")]
    [Address(RVA = "0x452D284", Offset = "0x452D284", VA = "0x452D284")]
    protected void DestroyInstance()
    {
    }

    [Token(Token = "0x6008D3A")]
    public abstract void InstanceUpdate();

    [Token(Token = "0x6008D3B")]
    [Address(RVA = "0x452EF80", Offset = "0x452EF80", VA = "0x452EF80", Slot = "9")]
    public virtual void InstanceLateUpdate()
    {
    }

    [Token(Token = "0x6008D3C")]
    [Address(RVA = "0x4533110", Offset = "0x4533110", VA = "0x4533110", Slot = "10")]
    public virtual void ReleaseInstance()
    {
    }

    [Token(Token = "0x6008D3D")]
    [Address(RVA = "0x452D584", Offset = "0x452D584", VA = "0x452D584")]
    protected FreeMapInstance()
    {
    }
  }
}
