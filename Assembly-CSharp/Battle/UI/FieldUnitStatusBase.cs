// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitStatusBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023FE")]
  [AddComponentMenu("")]
  public class FieldUnitStatusBase : MonoBehaviour
  {
    [Token(Token = "0x40099B9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected CanvasGroup viewCanvas;
    [Token(Token = "0x40099BA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected Image unitImage;
    [Token(Token = "0x40099BB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected Image elementIconImage;

    [Token(Token = "0x600DC86")]
    [Address(RVA = "0x1E1E33C", Offset = "0x1E1E33C", VA = "0x1E1E33C")]
    public void SetViewCanvasGroup(bool visible)
    {
    }

    [Token(Token = "0x600DC87")]
    [Address(RVA = "0x1E1E36C", Offset = "0x1E1E36C", VA = "0x1E1E36C")]
    public void SetElementIcon(ElementTypeEnum type)
    {
    }

    [Token(Token = "0x600DC88")]
    [Address(RVA = "0x1E1E418", Offset = "0x1E1E418", VA = "0x1E1E418")]
    public FieldUnitStatusBase()
    {
    }
  }
}
