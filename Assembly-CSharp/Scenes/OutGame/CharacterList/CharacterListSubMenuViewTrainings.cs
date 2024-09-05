// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.CharacterListSubMenuViewTrainings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200373A")]
  public class CharacterListSubMenuViewTrainings : MonoBehaviour
  {
    [Token(Token = "0x400F13D")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("熟練度表示(Index=\"Index:武器種\")")]
    [SerializeField]
    private TrainingItem[] trainings;

    [Token(Token = "0x6015C23")]
    [Address(RVA = "0x1B24C34", Offset = "0x1B24C34", VA = "0x1B24C34")]
    public void Set(Character character)
    {
    }

    [Token(Token = "0x6015C24")]
    [Address(RVA = "0x1B251C4", Offset = "0x1B251C4", VA = "0x1B251C4")]
    public CharacterListSubMenuViewTrainings()
    {
    }
  }
}
