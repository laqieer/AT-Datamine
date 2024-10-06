// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineBindingAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x20008EC")]
  [CreateAssetMenu(menuName = "staq/UITimeline/Binding Asset")]
  public class UITimelineBindingAsset : ScriptableObject
  {
    [Token(Token = "0x40029C3")]
    [FieldOffset(Offset = "0x18")]
    public List<UITimelineBindingParameter> parameters;

    [Token(Token = "0x600327A")]
    [Address(RVA = "0x3C22FD0", Offset = "0x3C22FD0", VA = "0x3C22FD0")]
    public UITimelineBindingAsset()
    {
    }
  }
}
