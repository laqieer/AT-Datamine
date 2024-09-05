// Decompiled with JetBrains decompiler
// Type: Battle.UI.GridInformation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20022F9")]
  public class GridInformation : MonoBehaviour
  {
    [Token(Token = "0x40093FA")]
    private const string ZeroValueText = "±00";
    [Token(Token = "0x40093FB")]
    private const string PlusValueFormat = "+{0:00}";
    [Token(Token = "0x40093FC")]
    private const string MinusValueFormat = "-{0:00}";
    [Token(Token = "0x40093FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnityEngine.UI.Text landformNameText;
    [Token(Token = "0x40093FE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnityEngine.UI.Text physicalDefValueText;
    [Token(Token = "0x40093FF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UnityEngine.UI.Text magicDefValueText;
    [Token(Token = "0x4009400")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnityEngine.UI.Text hitValueText;
    [Token(Token = "0x4009401")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UnityEngine.UI.Text eviValuText;
    [Token(Token = "0x4009402")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UnityEngine.UI.Text specialEffectText;
    [Token(Token = "0x4009403")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<GridInformation.TagTextContainer> landTags;
    [Token(Token = "0x4009404")]
    [FieldOffset(Offset = "0x50")]
    private StringBuilder builder;

    [Token(Token = "0x600D5CC")]
    [Address(RVA = "0x1D180B8", Offset = "0x1D180B8", VA = "0x1D180B8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600D5CD")]
    [Address(RVA = "0x1D180DC", Offset = "0x1D180DC", VA = "0x1D180DC")]
    public void Show(GridData grid)
    {
    }

    [Token(Token = "0x600D5CE")]
    [Address(RVA = "0x1D1886C", Offset = "0x1D1886C", VA = "0x1D1886C")]
    public void Show()
    {
    }

    [Token(Token = "0x600D5CF")]
    [Address(RVA = "0x1D18890", Offset = "0x1D18890", VA = "0x1D18890")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D5D0")]
    [Address(RVA = "0x1D18764", Offset = "0x1D18764", VA = "0x1D18764")]
    private string CreateValueText(int value) => (string) null;

    [Token(Token = "0x600D5D1")]
    [Address(RVA = "0x1D188B4", Offset = "0x1D188B4", VA = "0x1D188B4")]
    public GridInformation()
    {
    }

    [Token(Token = "0x20022FA")]
    [Serializable]
    public class TagTextContainer
    {
      [Token(Token = "0x4009405")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject viewRootObject;
      [Token(Token = "0x4009406")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private UnityEngine.UI.Text name;

      [Token(Token = "0x17002E34")]
      public GameObject ViewRootObject
      {
        [Token(Token = "0x600D5D2"), Address(RVA = "0x1D1891C", Offset = "0x1D1891C", VA = "0x1D1891C")] get
        {
          return (GameObject) null;
        }
      }

      [Token(Token = "0x17002E35")]
      public UnityEngine.UI.Text Name
      {
        [Token(Token = "0x600D5D3"), Address(RVA = "0x1D18924", Offset = "0x1D18924", VA = "0x1D18924")] get
        {
          return (UnityEngine.UI.Text) null;
        }
      }

      [Token(Token = "0x600D5D4")]
      [Address(RVA = "0x1D1892C", Offset = "0x1D1892C", VA = "0x1D1892C")]
      public TagTextContainer()
      {
      }
    }
  }
}
