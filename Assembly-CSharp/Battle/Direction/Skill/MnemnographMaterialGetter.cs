// Decompiled with JetBrains decompiler
// Type: Battle.Direction.Skill.MnemnographMaterialGetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Direction.Skill
{
  [Token(Token = "0x20025C7")]
  public class MnemnographMaterialGetter : MonoBehaviour
  {
    [Token(Token = "0x400A287")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tooltip("差し替え対象の念装画像を設定しているオブジェクトを登録して下さい。")]
    private List<Renderer> mnemnographObjects;
    [Token(Token = "0x400A288")]
    [FieldOffset(Offset = "0x20")]
    private bool initialized;
    [Token(Token = "0x400A289")]
    [FieldOffset(Offset = "0x28")]
    private readonly List<Material> cardMaterials;

    [Token(Token = "0x170031C8")]
    public IEnumerable<Material> CardMaterials
    {
      [Token(Token = "0x600E934"), Address(RVA = "0x4C36F34", Offset = "0x4C36F34", VA = "0x4C36F34")] get
      {
        return (IEnumerable<Material>) null;
      }
    }

    [Token(Token = "0x600E935")]
    [Address(RVA = "0x4C36D48", Offset = "0x4C36D48", VA = "0x4C36D48")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E936")]
    [Address(RVA = "0x4C47A4C", Offset = "0x4C47A4C", VA = "0x4C47A4C")]
    public MnemnographMaterialGetter()
    {
    }
  }
}
