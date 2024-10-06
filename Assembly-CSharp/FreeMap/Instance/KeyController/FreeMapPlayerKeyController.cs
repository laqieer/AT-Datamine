// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.KeyController.FreeMapPlayerKeyController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.Instance.KeyController
{
  [Token(Token = "0x2001908")]
  public class FreeMapPlayerKeyController : MonoBehaviour
  {
    [Token(Token = "0x4006C2E")]
    [FieldOffset(Offset = "0x18")]
    private readonly ReadOnlyDictionary<KeyCode, Vector2> TaragetKeyInfoDic;
    [Token(Token = "0x4006C2F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Vector2 prevInputDirection;

    [Token(Token = "0x14000126")]
    public event UnityAction OnStartControl
    {
      [Token(Token = "0x6008E43"), Address(RVA = "0x4AFFC84", Offset = "0x4AFFC84", VA = "0x4AFFC84")] add
      {
      }
      [Token(Token = "0x6008E44"), Address(RVA = "0x4AFFD20", Offset = "0x4AFFD20", VA = "0x4AFFD20")] remove
      {
      }
    }

    [Token(Token = "0x14000127")]
    public event UnityAction OnEndControl
    {
      [Token(Token = "0x6008E45"), Address(RVA = "0x4AFFDBC", Offset = "0x4AFFDBC", VA = "0x4AFFDBC")] add
      {
      }
      [Token(Token = "0x6008E46"), Address(RVA = "0x4AFFE58", Offset = "0x4AFFE58", VA = "0x4AFFE58")] remove
      {
      }
    }

    [Token(Token = "0x14000128")]
    public event UnityAction<Vector2> OnUpdateControl
    {
      [Token(Token = "0x6008E47"), Address(RVA = "0x4AFFEF4", Offset = "0x4AFFEF4", VA = "0x4AFFEF4")] add
      {
      }
      [Token(Token = "0x6008E48"), Address(RVA = "0x4AFFFA4", Offset = "0x4AFFFA4", VA = "0x4AFFFA4")] remove
      {
      }
    }

    [Token(Token = "0x6008E49")]
    [Address(RVA = "0x4B00054", Offset = "0x4B00054", VA = "0x4B00054")]
    private void Update()
    {
    }

    [Token(Token = "0x6008E4A")]
    [Address(RVA = "0x4B0009C", Offset = "0x4B0009C", VA = "0x4B0009C")]
    private void UpdateDirection(out Vector2 prevDirection, out Vector2 nextDirection)
    {
    }

    [Token(Token = "0x6008E4B")]
    [Address(RVA = "0x4B00464", Offset = "0x4B00464", VA = "0x4B00464")]
    private void ExecCallback(in Vector2 prevDirection, in Vector2 nextDirection)
    {
    }

    [Token(Token = "0x6008E4C")]
    [Address(RVA = "0x4B004FC", Offset = "0x4B004FC", VA = "0x4B004FC")]
    private bool IsOnStartControl(in Vector2 prevDirection, in Vector2 nextDirection) => new bool();

    [Token(Token = "0x6008E4D")]
    [Address(RVA = "0x4B005C0", Offset = "0x4B005C0", VA = "0x4B005C0")]
    private bool IsOnEndControl(in Vector2 prevDirection, in Vector2 nextDirection) => new bool();

    [Token(Token = "0x6008E4E")]
    [Address(RVA = "0x4B00684", Offset = "0x4B00684", VA = "0x4B00684")]
    private bool IsOnUpdateControl(in Vector2 prevDirection, in Vector2 nextDirection)
    {
      return new bool();
    }

    [Token(Token = "0x6008E4F")]
    [Address(RVA = "0x4B00748", Offset = "0x4B00748", VA = "0x4B00748")]
    public void SetEnable(bool enable)
    {
    }

    [Token(Token = "0x6008E50")]
    [Address(RVA = "0x4B007B4", Offset = "0x4B007B4", VA = "0x4B007B4")]
    public FreeMapPlayerKeyController()
    {
    }
  }
}
