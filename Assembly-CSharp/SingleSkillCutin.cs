// Decompiled with JetBrains decompiler
// Type: SingleSkillCutin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
[Token(Token = "0x200019B")]
public class SingleSkillCutin : MonoBehaviour
{
  [Token(Token = "0x4000A61")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Transform cutinParent;
  [Token(Token = "0x4000A62")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private List<TextMeshProUGUI> textObjects;

  [Token(Token = "0x6000AED")]
  [Address(RVA = "0x4BBCB54", Offset = "0x4BBCB54", VA = "0x4BBCB54")]
  public void PlaceCutin(GameObject cutin)
  {
  }

  [Token(Token = "0x6000AEE")]
  [Address(RVA = "0x4BBCB88", Offset = "0x4BBCB88", VA = "0x4BBCB88")]
  public Vector3 GetParentScale() => new Vector3();

  [Token(Token = "0x6000AEF")]
  [Address(RVA = "0x4BBCBA4", Offset = "0x4BBCBA4", VA = "0x4BBCBA4")]
  public void SetTexts(string text)
  {
  }

  [Token(Token = "0x6000AF0")]
  [Address(RVA = "0x4BBCD00", Offset = "0x4BBCD00", VA = "0x4BBCD00")]
  public SingleSkillCutin()
  {
  }
}
