// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.SetAlphaCanvasGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EA5")]
  [RequireComponent(typeof (CanvasGroup))]
  public class SetAlphaCanvasGroup : MonoBehaviour
  {
    [Token(Token = "0x400C7F8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SetAlphaCanvasGroup.Type type;
    [Token(Token = "0x400C7F9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float alpha;

    [Token(Token = "0x601235C")]
    [Address(RVA = "0x4595D80", Offset = "0x4595D80", VA = "0x4595D80")]
    private void Awake()
    {
    }

    [Token(Token = "0x601235D")]
    [Address(RVA = "0x4595DF0", Offset = "0x4595DF0", VA = "0x4595DF0")]
    private void Start()
    {
    }

    [Token(Token = "0x601235E")]
    [Address(RVA = "0x4595E04", Offset = "0x4595E04", VA = "0x4595E04")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601235F")]
    [Address(RVA = "0x4595E18", Offset = "0x4595E18", VA = "0x4595E18")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6012360")]
    [Address(RVA = "0x4595E2C", Offset = "0x4595E2C", VA = "0x4595E2C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6012361")]
    [Address(RVA = "0x4595D94", Offset = "0x4595D94", VA = "0x4595D94")]
    private void SetAlpha()
    {
    }

    [Token(Token = "0x6012362")]
    [Address(RVA = "0x4595E40", Offset = "0x4595E40", VA = "0x4595E40")]
    public SetAlphaCanvasGroup()
    {
    }

    [Token(Token = "0x2002EA6")]
    private enum Type
    {
      [Token(Token = "0x400C7FB")] None,
      [Token(Token = "0x400C7FC")] Awake,
      [Token(Token = "0x400C7FD")] Start,
      [Token(Token = "0x400C7FE")] Enable,
      [Token(Token = "0x400C7FF")] Disable,
      [Token(Token = "0x400C800")] Destroy,
    }
  }
}
