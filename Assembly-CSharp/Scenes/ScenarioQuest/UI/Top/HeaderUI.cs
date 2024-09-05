// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.Top.HeaderUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.UI.Top
{
  [Token(Token = "0x2002954")]
  [AddComponentMenu("ScenarioQuestTopHeader")]
  public class HeaderUI : MonoBehaviour
  {
    [Token(Token = "0x400B02B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor txtPlayable;

    [Token(Token = "0x60103F9")]
    [Address(RVA = "0x475334C", Offset = "0x475334C", VA = "0x475334C")]
    public void SetPlayableTerm(string playableText)
    {
    }

    [Token(Token = "0x60103FA")]
    [Address(RVA = "0x47533B4", Offset = "0x47533B4", VA = "0x47533B4")]
    public HeaderUI()
    {
    }
  }
}
