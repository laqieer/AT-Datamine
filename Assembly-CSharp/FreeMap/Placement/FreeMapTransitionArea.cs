// Decompiled with JetBrains decompiler
// Type: FreeMap.Placement.FreeMapTransitionArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.Placement
{
  [Token(Token = "0x2001859")]
  public class FreeMapTransitionArea : MonoBehaviour
  {
    [Token(Token = "0x4006A19")]
    public const int TransitionAreaLayerId = 16;
    [Token(Token = "0x4006A1A")]
    public const float StayTimeSec = 0.5f;
    [Token(Token = "0x4006A1B")]
    public const float ViewFxLength = 10f;
    [Token(Token = "0x4006A1C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FreeMapTransitionAreaUnit[] unitList;

    [Token(Token = "0x14000117")]
    public event UnityAction<string> OnEnableTransition
    {
      [Token(Token = "0x600899E"), Address(RVA = "0x43E6430", Offset = "0x43E6430", VA = "0x43E6430")] add
      {
      }
      [Token(Token = "0x600899F"), Address(RVA = "0x43E64E0", Offset = "0x43E64E0", VA = "0x43E64E0")] remove
      {
      }
    }

    [Token(Token = "0x14000118")]
    public event UnityAction OnInteractDisableUI
    {
      [Token(Token = "0x60089A0"), Address(RVA = "0x43E6590", Offset = "0x43E6590", VA = "0x43E6590")] add
      {
      }
      [Token(Token = "0x60089A1"), Address(RVA = "0x43E662C", Offset = "0x43E662C", VA = "0x43E662C")] remove
      {
      }
    }

    [Token(Token = "0x14000119")]
    public event UnityAction OnInteractEnableUI
    {
      [Token(Token = "0x60089A2"), Address(RVA = "0x43E66C8", Offset = "0x43E66C8", VA = "0x43E66C8")] add
      {
      }
      [Token(Token = "0x60089A3"), Address(RVA = "0x43E6764", Offset = "0x43E6764", VA = "0x43E6764")] remove
      {
      }
    }

    [Token(Token = "0x170015B9")]
    public GameObject ColliderObject
    {
      [Token(Token = "0x60089A4"), Address(RVA = "0x43E6800", Offset = "0x43E6800", VA = "0x43E6800")] private set
      {
      }
      [Token(Token = "0x60089A5"), Address(RVA = "0x43E6808", Offset = "0x43E6808", VA = "0x43E6808")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015BA")]
    private bool IsActive
    {
      [Token(Token = "0x60089A6"), Address(RVA = "0x43E6810", Offset = "0x43E6810", VA = "0x43E6810")] set
      {
      }
      [Token(Token = "0x60089A7"), Address(RVA = "0x43E681C", Offset = "0x43E681C", VA = "0x43E681C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015BB")]
    private string CurrentUnitName
    {
      [Token(Token = "0x60089A8"), Address(RVA = "0x43E6824", Offset = "0x43E6824", VA = "0x43E6824")] set
      {
      }
      [Token(Token = "0x60089A9"), Address(RVA = "0x43E682C", Offset = "0x43E682C", VA = "0x43E682C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015BC")]
    private float BeginTime
    {
      [Token(Token = "0x60089AA"), Address(RVA = "0x43E6834", Offset = "0x43E6834", VA = "0x43E6834")] set
      {
      }
      [Token(Token = "0x60089AB"), Address(RVA = "0x43E683C", Offset = "0x43E683C", VA = "0x43E683C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60089AC")]
    [Address(RVA = "0x43E6844", Offset = "0x43E6844", VA = "0x43E6844")]
    public void Initialize(GameObject targetObject)
    {
    }

    [Token(Token = "0x60089AD")]
    [Address(RVA = "0x43E69D8", Offset = "0x43E69D8", VA = "0x43E69D8")]
    private void Awake()
    {
    }

    [Token(Token = "0x60089AE")]
    [Address(RVA = "0x43E6B54", Offset = "0x43E6B54", VA = "0x43E6B54")]
    private void Update()
    {
    }

    [Token(Token = "0x60089AF")]
    [Address(RVA = "0x43E6BE8", Offset = "0x43E6BE8", VA = "0x43E6BE8")]
    public void SetUnitActive(IReadOnlyCollection<string> objectNames, bool active)
    {
    }

    [Token(Token = "0x60089B0")]
    [Address(RVA = "0x43E6FB0", Offset = "0x43E6FB0", VA = "0x43E6FB0")]
    private void EnterCollision(string objectName, Collider other)
    {
    }

    [Token(Token = "0x60089B1")]
    [Address(RVA = "0x43E70E4", Offset = "0x43E70E4", VA = "0x43E70E4")]
    private void StayCollision(string objectName, Collider other)
    {
    }

    [Token(Token = "0x60089B2")]
    [Address(RVA = "0x43E7164", Offset = "0x43E7164", VA = "0x43E7164")]
    private void ExitCollision(string objectName, Collider other)
    {
    }

    [Token(Token = "0x60089B3")]
    [Address(RVA = "0x43E7020", Offset = "0x43E7020", VA = "0x43E7020")]
    private bool CheckCollider(Collider collider) => new bool();

    [Token(Token = "0x60089B4")]
    [Address(RVA = "0x43E6878", Offset = "0x43E6878", VA = "0x43E6878")]
    private void UpdateViewFx(Transform targetTransform, bool initialize)
    {
    }

    [Token(Token = "0x60089B5")]
    [Address(RVA = "0x43E71CC", Offset = "0x43E71CC", VA = "0x43E71CC")]
    public void SetActiveFreeMapTransitionAreaUnit(bool active)
    {
    }

    [Token(Token = "0x60089B6")]
    [Address(RVA = "0x43E723C", Offset = "0x43E723C", VA = "0x43E723C")]
    public FreeMapTransitionArea()
    {
    }
  }
}
