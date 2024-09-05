// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20032B7")]
  public class UnitCell : MonoBehaviour
  {
    [Token(Token = "0x400D9A1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform dotUnitParent;
    [Token(Token = "0x400D9A2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject notUnitImage;
    [Token(Token = "0x400D9A3")]
    [FieldOffset(Offset = "0x28")]
    private GameObject dotObj;

    [Token(Token = "0x6013CCC")]
    [Address(RVA = "0x1AE252C", Offset = "0x1AE252C", VA = "0x1AE252C")]
    public IEnumerator SetDotUnit(int styleId) => (IEnumerator) null;

    [Token(Token = "0x6013CCD")]
    [Address(RVA = "0x1AE25CC", Offset = "0x1AE25CC", VA = "0x1AE25CC")]
    public void SetEmpty()
    {
    }

    [Token(Token = "0x6013CCE")]
    [Address(RVA = "0x1AE2614", Offset = "0x1AE2614", VA = "0x1AE2614")]
    public void DeleteObj()
    {
    }

    [Token(Token = "0x6013CCF")]
    [Address(RVA = "0x1AE26A0", Offset = "0x1AE26A0", VA = "0x1AE26A0")]
    public UnitCell()
    {
    }
  }
}
