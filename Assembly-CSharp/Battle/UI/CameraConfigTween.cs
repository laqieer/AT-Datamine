// Decompiled with JetBrains decompiler
// Type: Battle.UI.CameraConfigTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200230F")]
  public sealed class CameraConfigTween : TweenWrapper
  {
    [Token(Token = "0x4009451")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private string showName;
    [Token(Token = "0x4009452")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [HideInInspector]
    private string hideName;

    [Token(Token = "0x600D62F")]
    [Address(RVA = "0x1D1B298", Offset = "0x1D1B298", VA = "0x1D1B298")]
    public void Show()
    {
    }

    [Token(Token = "0x600D630")]
    [Address(RVA = "0x1D1B360", Offset = "0x1D1B360", VA = "0x1D1B360")]
    public new void Hide()
    {
    }

    [Token(Token = "0x600D631")]
    [Address(RVA = "0x1D1B5A4", Offset = "0x1D1B5A4", VA = "0x1D1B5A4", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600D632")]
    [Address(RVA = "0x1D1B5A8", Offset = "0x1D1B5A8", VA = "0x1D1B5A8")]
    public CameraConfigTween()
    {
    }
  }
}
