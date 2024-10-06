// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.CommonButtonExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BEA")]
  public static class CommonButtonExtension
  {
    [Token(Token = "0x60043FC")]
    [Address(RVA = "0x3644FCC", Offset = "0x3644FCC", VA = "0x3644FCC")]
    public static void AddClickListenerSafe(this Button obj, UnityAction onClickEvent)
    {
    }

    [Token(Token = "0x60043FD")]
    [Address(RVA = "0x3644FF4", Offset = "0x3644FF4", VA = "0x3644FF4")]
    public static void RemoveAllListenersSafe(this Button obj)
    {
    }

    [Token(Token = "0x60043FE")]
    [Address(RVA = "0x364501C", Offset = "0x364501C", VA = "0x364501C")]
    public static void ResetSafe(this Button obj, UnityAction onClickEvent)
    {
    }

    [Token(Token = "0x60043FF")]
    [Address(RVA = "0x3645044", Offset = "0x3645044", VA = "0x3645044")]
    public static void SetInteractable(this Button obj, bool interactable)
    {
    }
  }
}
