// Decompiled with JetBrains decompiler
// Type: UI.Common.GaugeScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UI.Common
{
  [Token(Token = "0x2000915")]
  public class GaugeScale : MonoBehaviour
  {
    [Token(Token = "0x4002A67")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform _gauge;

    [Token(Token = "0x17000764")]
    public float value
    {
      [Token(Token = "0x6003338"), Address(RVA = "0x3625DA4", Offset = "0x3625DA4", VA = "0x3625DA4")] get
      {
        return new float();
      }
      [Token(Token = "0x6003339"), Address(RVA = "0x3625DCC", Offset = "0x3625DCC", VA = "0x3625DCC")] set
      {
      }
    }

    [Token(Token = "0x600333A")]
    [Address(RVA = "0x3625DE0", Offset = "0x3625DE0", VA = "0x3625DE0")]
    public GaugeScale()
    {
    }
  }
}
