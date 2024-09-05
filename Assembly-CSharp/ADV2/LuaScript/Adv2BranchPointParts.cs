// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2BranchPointParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003E9D")]
  public class Adv2BranchPointParts : MonoBehaviour
  {
    [Token(Token = "0x40112CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image unitThumb;
    [Token(Token = "0x40112CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x40112CF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] points;
    [Token(Token = "0x40112D0")]
    [FieldOffset(Offset = "0x30")]
    private Adv2BranchPointParts.DisplayStatus status;

    [Token(Token = "0x170051C1")]
    public bool IsAppear
    {
      [Token(Token = "0x601933F"), Address(RVA = "0x2D05C00", Offset = "0x2D05C00", VA = "0x2D05C00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019340")]
    [Address(RVA = "0x2D05A8C", Offset = "0x2D05A8C", VA = "0x2D05A8C")]
    public void SetData(Texture2D tex, int point)
    {
    }

    [Token(Token = "0x6019341")]
    [Address(RVA = "0x2D05BD8", Offset = "0x2D05BD8", VA = "0x2D05BD8")]
    public void SetHide()
    {
    }

    [Token(Token = "0x6019342")]
    [Address(RVA = "0x2D05C10", Offset = "0x2D05C10", VA = "0x2D05C10")]
    public void ToHide()
    {
    }

    [Token(Token = "0x6019343")]
    [Address(RVA = "0x2D05D88", Offset = "0x2D05D88", VA = "0x2D05D88")]
    public Adv2BranchPointParts()
    {
    }

    [Token(Token = "0x2003E9E")]
    private enum DisplayStatus
    {
      [Token(Token = "0x40112D2")] Hide,
      [Token(Token = "0x40112D3")] Appear,
    }
  }
}
