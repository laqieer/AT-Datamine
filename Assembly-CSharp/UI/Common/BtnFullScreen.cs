// Decompiled with JetBrains decompiler
// Type: UI.Common.BtnFullScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace UI.Common
{
  [Token(Token = "0x2000913")]
  public class BtnFullScreen : MonoBehaviour
  {
    [Token(Token = "0x4002A65")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton _button;

    [Token(Token = "0x6003333")]
    [Address(RVA = "0x3625C38", Offset = "0x3625C38", VA = "0x3625C38")]
    public void SetOnClickEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6003334")]
    [Address(RVA = "0x3625C88", Offset = "0x3625C88", VA = "0x3625C88")]
    public void Interacterble(bool interactable)
    {
    }

    [Token(Token = "0x6003335")]
    [Address(RVA = "0x3625CA8", Offset = "0x3625CA8", VA = "0x3625CA8")]
    public BtnFullScreen()
    {
    }
  }
}
