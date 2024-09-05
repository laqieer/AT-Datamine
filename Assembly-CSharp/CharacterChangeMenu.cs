// Decompiled with JetBrains decompiler
// Type: CharacterChangeMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000301")]
public class CharacterChangeMenu : MonoBehaviour
{
  [Token(Token = "0x40011C2")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GameObject charaRoot;
  [Token(Token = "0x40011C3")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private List<GameObject> characters;
  [Token(Token = "0x40011C4")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private List<Text> charaName;
  [Token(Token = "0x40011C5")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private RuntimeAnimatorController maleAnimation;
  [Token(Token = "0x40011C6")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private RuntimeAnimatorController femaleAnimation;
  [Token(Token = "0x40011C7")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private GameObject light;

  [Token(Token = "0x6001259")]
  [Address(RVA = "0x27E02B8", Offset = "0x27E02B8", VA = "0x27E02B8")]
  private void Awake()
  {
  }

  [Token(Token = "0x600125A")]
  [Address(RVA = "0x27E044C", Offset = "0x27E044C", VA = "0x27E044C")]
  public void CloseCharaMenu()
  {
  }

  [Token(Token = "0x600125B")]
  [Address(RVA = "0x27E0470", Offset = "0x27E0470", VA = "0x27E0470")]
  public void SetCharacter(int num)
  {
  }

  [Token(Token = "0x600125C")]
  [Address(RVA = "0x27E06DC", Offset = "0x27E06DC", VA = "0x27E06DC")]
  public CharacterChangeMenu()
  {
  }
}
