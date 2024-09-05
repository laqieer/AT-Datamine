// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponDetailAddedStatusContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003677")]
  public class WeaponDetailAddedStatusContent : MonoBehaviour
  {
    [Token(Token = "0x400ECF8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text statusName;
    [Token(Token = "0x400ECF9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text statusNum;

    [Token(Token = "0x60156F4")]
    [Address(RVA = "0x18E2E70", Offset = "0x18E2E70", VA = "0x18E2E70")]
    public void SetParam(string name, int num)
    {
    }

    [Token(Token = "0x60156F5")]
    [Address(RVA = "0x18E2C50", Offset = "0x18E2C50", VA = "0x18E2C50")]
    public void SetParam(string name, int num, string colorCode)
    {
    }

    [Token(Token = "0x60156F6")]
    [Address(RVA = "0x18E2F00", Offset = "0x18E2F00", VA = "0x18E2F00")]
    public WeaponDetailAddedStatusContent()
    {
    }
  }
}
