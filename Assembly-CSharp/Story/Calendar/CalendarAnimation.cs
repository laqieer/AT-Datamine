// Decompiled with JetBrains decompiler
// Type: Story.Calendar.CalendarAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Story.Calendar
{
  [Token(Token = "0x200071B")]
  [Serializable]
  public class CalendarAnimation : MonoBehaviour
  {
    [Token(Token = "0x40020FE")]
    [FieldOffset(Offset = "0x18")]
    private UITimelineController uITimelineController;

    [Token(Token = "0x60027FE")]
    [Address(RVA = "0x3671CF8", Offset = "0x3671CF8", VA = "0x3671CF8")]
    public IEnumerator SetTimelineAsset(UITimelineSettingAsset settingAsset) => (IEnumerator) null;

    [Token(Token = "0x60027FF")]
    [Address(RVA = "0x3671D94", Offset = "0x3671D94", VA = "0x3671D94")]
    public void UpdateNonPlayAsset()
    {
    }

    [Token(Token = "0x6002800")]
    [Address(RVA = "0x3671DEC", Offset = "0x3671DEC", VA = "0x3671DEC")]
    public IEnumerator Play(
      string assetBundleName,
      UITimelineController.DirectionType directionType = UITimelineController.DirectionType.In,
      GameObject bindObj = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002801")]
    [Address(RVA = "0x3671EA0", Offset = "0x3671EA0", VA = "0x3671EA0")]
    public CalendarAnimation()
    {
    }
  }
}
