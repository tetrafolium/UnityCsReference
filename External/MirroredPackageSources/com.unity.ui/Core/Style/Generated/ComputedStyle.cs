/******************************************************************************/
//
//                             DO NOT MODIFY
//          This file has been generated by the UIElementsGenerator tool
//              See ComputedStyleGenerator class for details
//
/******************************************************************************/
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements {
  internal partial class ComputedStyle {
    public InheritedData inheritedData = new InheritedData();
    public NonInheritedData nonInheritedData = new NonInheritedData();

    public StyleEnum<Align> alignContent => nonInheritedData.alignContent;
    public StyleEnum<Align> alignItems => nonInheritedData.alignItems;
    public StyleEnum<Align> alignSelf => nonInheritedData.alignSelf;
    public StyleColor backgroundColor => nonInheritedData.backgroundColor;
    public StyleBackground backgroundImage => nonInheritedData.backgroundImage;
    public StyleColor borderBottomColor => nonInheritedData.borderBottomColor;
    public StyleLength borderBottomLeftRadius =>
        nonInheritedData.borderBottomLeftRadius;
    public StyleLength borderBottomRightRadius =>
        nonInheritedData.borderBottomRightRadius;
    public StyleFloat borderBottomWidth => nonInheritedData.borderBottomWidth;
    public StyleColor borderLeftColor => nonInheritedData.borderLeftColor;
    public StyleFloat borderLeftWidth => nonInheritedData.borderLeftWidth;
    public StyleColor borderRightColor => nonInheritedData.borderRightColor;
    public StyleFloat borderRightWidth => nonInheritedData.borderRightWidth;
    public StyleColor borderTopColor => nonInheritedData.borderTopColor;
    public StyleLength borderTopLeftRadius =>
        nonInheritedData.borderTopLeftRadius;
    public StyleLength borderTopRightRadius =>
        nonInheritedData.borderTopRightRadius;
    public StyleFloat borderTopWidth => nonInheritedData.borderTopWidth;
    public StyleLength bottom => nonInheritedData.bottom;
    public StyleColor color => inheritedData.color;
    public StyleCursor cursor => nonInheritedData.cursor;
    public StyleEnum<DisplayStyle> display => nonInheritedData.display;
    public StyleLength flexBasis => nonInheritedData.flexBasis;
    public StyleEnum<FlexDirection> flexDirection =>
        nonInheritedData.flexDirection;
    public StyleFloat flexGrow => nonInheritedData.flexGrow;
    public StyleFloat flexShrink => nonInheritedData.flexShrink;
    public StyleEnum<Wrap> flexWrap => nonInheritedData.flexWrap;
    public StyleLength fontSize => inheritedData.fontSize;
    public StyleLength height => nonInheritedData.height;
    public StyleEnum<Justify> justifyContent => nonInheritedData.justifyContent;
    public StyleLength left => nonInheritedData.left;
    public StyleLength marginBottom => nonInheritedData.marginBottom;
    public StyleLength marginLeft => nonInheritedData.marginLeft;
    public StyleLength marginRight => nonInheritedData.marginRight;
    public StyleLength marginTop => nonInheritedData.marginTop;
    public StyleLength maxHeight => nonInheritedData.maxHeight;
    public StyleLength maxWidth => nonInheritedData.maxWidth;
    public StyleLength minHeight => nonInheritedData.minHeight;
    public StyleLength minWidth => nonInheritedData.minWidth;
    public StyleFloat opacity => nonInheritedData.opacity;
    public StyleEnum<OverflowInternal> overflow => nonInheritedData.overflow;
    public StyleLength paddingBottom => nonInheritedData.paddingBottom;
    public StyleLength paddingLeft => nonInheritedData.paddingLeft;
    public StyleLength paddingRight => nonInheritedData.paddingRight;
    public StyleLength paddingTop => nonInheritedData.paddingTop;
    public StyleEnum<Position> position => nonInheritedData.position;
    public StyleLength right => nonInheritedData.right;
    public StyleEnum<TextOverflow> textOverflow =>
        nonInheritedData.textOverflow;
    public StyleLength top => nonInheritedData.top;
    public StyleColor unityBackgroundImageTintColor =>
        nonInheritedData.unityBackgroundImageTintColor;
    public StyleEnum<ScaleMode> unityBackgroundScaleMode =>
        nonInheritedData.unityBackgroundScaleMode;
    public StyleFont unityFont => inheritedData.unityFont;
    public StyleEnum<FontStyle> unityFontStyleAndWeight =>
        inheritedData.unityFontStyleAndWeight;
    public StyleEnum<OverflowClipBox> unityOverflowClipBox =>
        nonInheritedData.unityOverflowClipBox;
    public StyleInt unitySliceBottom => nonInheritedData.unitySliceBottom;
    public StyleInt unitySliceLeft => nonInheritedData.unitySliceLeft;
    public StyleInt unitySliceRight => nonInheritedData.unitySliceRight;
    public StyleInt unitySliceTop => nonInheritedData.unitySliceTop;
    public StyleEnum<TextAnchor> unityTextAlign => inheritedData.unityTextAlign;
    public StyleEnum<TextOverflowPosition> unityTextOverflowPosition =>
        nonInheritedData.unityTextOverflowPosition;
    public StyleEnum<Visibility> visibility => inheritedData.visibility;
    public StyleEnum<WhiteSpace> whiteSpace => inheritedData.whiteSpace;
    public StyleLength width => nonInheritedData.width;

    public void CopyFrom(ComputedStyle other) {
      inheritedData = other.inheritedData;
      nonInheritedData = other.nonInheritedData;
    }

    public void ApplyProperties(StylePropertyReader reader,
                                ComputedStyle parentStyle) {
      for (var id = reader.propertyId; id != StylePropertyId.Unknown;
           id = reader.MoveNextProperty()) {
        if (ApplyGlobalKeyword(reader, parentStyle))
          continue;
        switch (id) {
        case StylePropertyId.AlignContent:
          nonInheritedData.alignContent =
              (Align) reader.ReadStyleEnum(StyleEnumType.Align, 0).value;
          break;
        case StylePropertyId.AlignItems:
          nonInheritedData.alignItems =
              (Align) reader.ReadStyleEnum(StyleEnumType.Align, 0).value;
          break;
        case StylePropertyId.AlignSelf:
          nonInheritedData.alignSelf =
              (Align) reader.ReadStyleEnum(StyleEnumType.Align, 0).value;
          break;
        case StylePropertyId.BackgroundColor:
          nonInheritedData.backgroundColor = reader.ReadStyleColor(0);
          break;
        case StylePropertyId.BackgroundImage:
          nonInheritedData.backgroundImage = reader.ReadStyleBackground(0);
          break;
        case StylePropertyId.BorderBottomColor:
          nonInheritedData.borderBottomColor = reader.ReadStyleColor(0);
          break;
        case StylePropertyId.BorderBottomLeftRadius:
          nonInheritedData.borderBottomLeftRadius = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.BorderBottomRightRadius:
          nonInheritedData.borderBottomRightRadius = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.BorderBottomWidth:
          nonInheritedData.borderBottomWidth = reader.ReadStyleFloat(0);
          break;
        case StylePropertyId.BorderColor:
          ShorthandApplicator.ApplyBorderColor(reader, this);
          break;
        case StylePropertyId.BorderLeftColor:
          nonInheritedData.borderLeftColor = reader.ReadStyleColor(0);
          break;
        case StylePropertyId.BorderLeftWidth:
          nonInheritedData.borderLeftWidth = reader.ReadStyleFloat(0);
          break;
        case StylePropertyId.BorderRadius:
          ShorthandApplicator.ApplyBorderRadius(reader, this);
          break;
        case StylePropertyId.BorderRightColor:
          nonInheritedData.borderRightColor = reader.ReadStyleColor(0);
          break;
        case StylePropertyId.BorderRightWidth:
          nonInheritedData.borderRightWidth = reader.ReadStyleFloat(0);
          break;
        case StylePropertyId.BorderTopColor:
          nonInheritedData.borderTopColor = reader.ReadStyleColor(0);
          break;
        case StylePropertyId.BorderTopLeftRadius:
          nonInheritedData.borderTopLeftRadius = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.BorderTopRightRadius:
          nonInheritedData.borderTopRightRadius = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.BorderTopWidth:
          nonInheritedData.borderTopWidth = reader.ReadStyleFloat(0);
          break;
        case StylePropertyId.BorderWidth:
          ShorthandApplicator.ApplyBorderWidth(reader, this);
          break;
        case StylePropertyId.Bottom:
          nonInheritedData.bottom = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.Color:
          inheritedData.color = reader.ReadStyleColor(0);
          break;
        case StylePropertyId.Cursor:
          nonInheritedData.cursor = reader.ReadStyleCursor(0);
          break;
        case StylePropertyId.Display:
          nonInheritedData.display =
              (DisplayStyle) reader.ReadStyleEnum(StyleEnumType.DisplayStyle, 0)
                  .value;
          break;
        case StylePropertyId.Flex:
          ShorthandApplicator.ApplyFlex(reader, this);
          break;
        case StylePropertyId.FlexBasis:
          nonInheritedData.flexBasis = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.FlexDirection:
          nonInheritedData.flexDirection =
              (FlexDirection)
                  reader.ReadStyleEnum(StyleEnumType.FlexDirection, 0)
                      .value;
          break;
        case StylePropertyId.FlexGrow:
          nonInheritedData.flexGrow = reader.ReadStyleFloat(0);
          break;
        case StylePropertyId.FlexShrink:
          nonInheritedData.flexShrink = reader.ReadStyleFloat(0);
          break;
        case StylePropertyId.FlexWrap:
          nonInheritedData.flexWrap =
              (Wrap) reader.ReadStyleEnum(StyleEnumType.Wrap, 0).value;
          break;
        case StylePropertyId.FontSize:
          inheritedData.fontSize = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.Height:
          nonInheritedData.height = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.JustifyContent:
          nonInheritedData.justifyContent =
              (Justify) reader.ReadStyleEnum(StyleEnumType.Justify, 0).value;
          break;
        case StylePropertyId.Left:
          nonInheritedData.left = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.Margin:
          ShorthandApplicator.ApplyMargin(reader, this);
          break;
        case StylePropertyId.MarginBottom:
          nonInheritedData.marginBottom = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.MarginLeft:
          nonInheritedData.marginLeft = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.MarginRight:
          nonInheritedData.marginRight = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.MarginTop:
          nonInheritedData.marginTop = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.MaxHeight:
          nonInheritedData.maxHeight = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.MaxWidth:
          nonInheritedData.maxWidth = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.MinHeight:
          nonInheritedData.minHeight = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.MinWidth:
          nonInheritedData.minWidth = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.Opacity:
          nonInheritedData.opacity = reader.ReadStyleFloat(0);
          break;
        case StylePropertyId.Overflow:
          nonInheritedData.overflow =
              (OverflowInternal)
                  reader.ReadStyleEnum(StyleEnumType.OverflowInternal, 0)
                      .value;
          break;
        case StylePropertyId.Padding:
          ShorthandApplicator.ApplyPadding(reader, this);
          break;
        case StylePropertyId.PaddingBottom:
          nonInheritedData.paddingBottom = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.PaddingLeft:
          nonInheritedData.paddingLeft = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.PaddingRight:
          nonInheritedData.paddingRight = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.PaddingTop:
          nonInheritedData.paddingTop = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.Position:
          nonInheritedData.position =
              (Position) reader.ReadStyleEnum(StyleEnumType.Position, 0).value;
          break;
        case StylePropertyId.Right:
          nonInheritedData.right = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.TextOverflow:
          nonInheritedData.textOverflow =
              (TextOverflow) reader.ReadStyleEnum(StyleEnumType.TextOverflow, 0)
                  .value;
          break;
        case StylePropertyId.Top:
          nonInheritedData.top = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.UnityBackgroundImageTintColor:
          nonInheritedData.unityBackgroundImageTintColor =
              reader.ReadStyleColor(0);
          break;
        case StylePropertyId.UnityBackgroundScaleMode:
          nonInheritedData.unityBackgroundScaleMode =
              (ScaleMode) reader.ReadStyleEnum(StyleEnumType.ScaleMode, 0)
                  .value;
          break;
        case StylePropertyId.UnityFont:
          inheritedData.unityFont = reader.ReadStyleFont(0);
          break;
        case StylePropertyId.UnityFontStyleAndWeight:
          inheritedData.unityFontStyleAndWeight =
              (FontStyle) reader.ReadStyleEnum(StyleEnumType.FontStyle, 0)
                  .value;
          break;
        case StylePropertyId.UnityOverflowClipBox:
          nonInheritedData.unityOverflowClipBox =
              (OverflowClipBox)
                  reader.ReadStyleEnum(StyleEnumType.OverflowClipBox, 0)
                      .value;
          break;
        case StylePropertyId.UnitySliceBottom:
          nonInheritedData.unitySliceBottom = reader.ReadStyleInt(0);
          break;
        case StylePropertyId.UnitySliceLeft:
          nonInheritedData.unitySliceLeft = reader.ReadStyleInt(0);
          break;
        case StylePropertyId.UnitySliceRight:
          nonInheritedData.unitySliceRight = reader.ReadStyleInt(0);
          break;
        case StylePropertyId.UnitySliceTop:
          nonInheritedData.unitySliceTop = reader.ReadStyleInt(0);
          break;
        case StylePropertyId.UnityTextAlign:
          inheritedData.unityTextAlign =
              (TextAnchor) reader.ReadStyleEnum(StyleEnumType.TextAnchor, 0)
                  .value;
          break;
        case StylePropertyId.UnityTextOverflowPosition:
          nonInheritedData.unityTextOverflowPosition =
              (TextOverflowPosition)
                  reader.ReadStyleEnum(StyleEnumType.TextOverflowPosition, 0)
                      .value;
          break;
        case StylePropertyId.Visibility:
          inheritedData.visibility =
              (Visibility) reader.ReadStyleEnum(StyleEnumType.Visibility, 0)
                  .value;
          break;
        case StylePropertyId.WhiteSpace:
          inheritedData.whiteSpace =
              (WhiteSpace) reader.ReadStyleEnum(StyleEnumType.WhiteSpace, 0)
                  .value;
          break;
        case StylePropertyId.Width:
          nonInheritedData.width = reader.ReadStyleLength(0);
          break;
        case StylePropertyId.Custom:
          ApplyCustomStyleProperty(reader);
          break;
        default:
          Debug.LogAssertion($"Unknown property id {id}");
          break;
        }
      }
    }

    public void ApplyStyleValue(StyleValue sv, ComputedStyle parentStyle) {
      if (ApplyGlobalKeyword(sv, parentStyle))
        return;
      switch (sv.id) {
      case StylePropertyId.AlignContent:
        nonInheritedData.alignContent =
            new StyleEnum<Align>((Align) sv.number, sv.keyword);
        if (sv.keyword == StyleKeyword.Auto)
          nonInheritedData.alignContent = Align.Auto;
        break;
      case StylePropertyId.AlignItems:
        nonInheritedData.alignItems =
            new StyleEnum<Align>((Align) sv.number, sv.keyword);
        if (sv.keyword == StyleKeyword.Auto)
          nonInheritedData.alignItems = Align.Auto;
        break;
      case StylePropertyId.AlignSelf:
        nonInheritedData.alignSelf =
            new StyleEnum<Align>((Align) sv.number, sv.keyword);
        if (sv.keyword == StyleKeyword.Auto)
          nonInheritedData.alignSelf = Align.Auto;
        break;
      case StylePropertyId.BackgroundColor:
        nonInheritedData.backgroundColor = new StyleColor(sv.color, sv.keyword);
        break;
      case StylePropertyId.BackgroundImage:
        nonInheritedData.backgroundImage =
            new StyleBackground(sv.resource, sv.keyword);
        break;
      case StylePropertyId.BorderBottomColor:
        nonInheritedData.borderBottomColor =
            new StyleColor(sv.color, sv.keyword);
        break;
      case StylePropertyId.BorderBottomLeftRadius:
        nonInheritedData.borderBottomLeftRadius =
            new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.BorderBottomRightRadius:
        nonInheritedData.borderBottomRightRadius =
            new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.BorderBottomWidth:
        nonInheritedData.borderBottomWidth =
            new StyleFloat(sv.number, sv.keyword);
        break;
      case StylePropertyId.BorderLeftColor:
        nonInheritedData.borderLeftColor = new StyleColor(sv.color, sv.keyword);
        break;
      case StylePropertyId.BorderLeftWidth:
        nonInheritedData.borderLeftWidth =
            new StyleFloat(sv.number, sv.keyword);
        break;
      case StylePropertyId.BorderRightColor:
        nonInheritedData.borderRightColor =
            new StyleColor(sv.color, sv.keyword);
        break;
      case StylePropertyId.BorderRightWidth:
        nonInheritedData.borderRightWidth =
            new StyleFloat(sv.number, sv.keyword);
        break;
      case StylePropertyId.BorderTopColor:
        nonInheritedData.borderTopColor = new StyleColor(sv.color, sv.keyword);
        break;
      case StylePropertyId.BorderTopLeftRadius:
        nonInheritedData.borderTopLeftRadius =
            new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.BorderTopRightRadius:
        nonInheritedData.borderTopRightRadius =
            new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.BorderTopWidth:
        nonInheritedData.borderTopWidth = new StyleFloat(sv.number, sv.keyword);
        break;
      case StylePropertyId.Bottom:
        nonInheritedData.bottom = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.Color:
        inheritedData.color = new StyleColor(sv.color, sv.keyword);
        break;
      case StylePropertyId.Display:
        nonInheritedData.display =
            new StyleEnum<DisplayStyle>((DisplayStyle) sv.number, sv.keyword);
        if (sv.keyword == StyleKeyword.None)
          nonInheritedData.display = DisplayStyle.None;
        break;
      case StylePropertyId.FlexBasis:
        nonInheritedData.flexBasis = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.FlexDirection:
        nonInheritedData.flexDirection =
            new StyleEnum<FlexDirection>((FlexDirection) sv.number, sv.keyword);
        break;
      case StylePropertyId.FlexGrow:
        nonInheritedData.flexGrow = new StyleFloat(sv.number, sv.keyword);
        break;
      case StylePropertyId.FlexShrink:
        nonInheritedData.flexShrink = new StyleFloat(sv.number, sv.keyword);
        break;
      case StylePropertyId.FlexWrap:
        nonInheritedData.flexWrap =
            new StyleEnum<Wrap>((Wrap) sv.number, sv.keyword);
        break;
      case StylePropertyId.FontSize:
        inheritedData.fontSize = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.Height:
        nonInheritedData.height = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.JustifyContent:
        nonInheritedData.justifyContent =
            new StyleEnum<Justify>((Justify) sv.number, sv.keyword);
        break;
      case StylePropertyId.Left:
        nonInheritedData.left = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MarginBottom:
        nonInheritedData.marginBottom = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MarginLeft:
        nonInheritedData.marginLeft = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MarginRight:
        nonInheritedData.marginRight = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MarginTop:
        nonInheritedData.marginTop = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MaxHeight:
        nonInheritedData.maxHeight = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MaxWidth:
        nonInheritedData.maxWidth = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MinHeight:
        nonInheritedData.minHeight = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.MinWidth:
        nonInheritedData.minWidth = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.Opacity:
        nonInheritedData.opacity = new StyleFloat(sv.number, sv.keyword);
        break;
      case StylePropertyId.Overflow:
        nonInheritedData.overflow = new StyleEnum<OverflowInternal>(
            (OverflowInternal) sv.number, sv.keyword);
        break;
      case StylePropertyId.PaddingBottom:
        nonInheritedData.paddingBottom = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.PaddingLeft:
        nonInheritedData.paddingLeft = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.PaddingRight:
        nonInheritedData.paddingRight = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.PaddingTop:
        nonInheritedData.paddingTop = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.Position:
        nonInheritedData.position =
            new StyleEnum<Position>((Position) sv.number, sv.keyword);
        break;
      case StylePropertyId.Right:
        nonInheritedData.right = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.TextOverflow:
        nonInheritedData.textOverflow =
            new StyleEnum<TextOverflow>((TextOverflow) sv.number, sv.keyword);
        break;
      case StylePropertyId.Top:
        nonInheritedData.top = new StyleLength(sv.length, sv.keyword);
        break;
      case StylePropertyId.UnityBackgroundImageTintColor:
        nonInheritedData.unityBackgroundImageTintColor =
            new StyleColor(sv.color, sv.keyword);
        break;
      case StylePropertyId.UnityBackgroundScaleMode:
        nonInheritedData.unityBackgroundScaleMode =
            new StyleEnum<ScaleMode>((ScaleMode) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnityFont:
        inheritedData.unityFont = new StyleFont(sv.resource, sv.keyword);
        break;
      case StylePropertyId.UnityFontStyleAndWeight:
        inheritedData.unityFontStyleAndWeight =
            new StyleEnum<FontStyle>((FontStyle) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnityOverflowClipBox:
        nonInheritedData.unityOverflowClipBox = new StyleEnum<OverflowClipBox>(
            (OverflowClipBox) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnitySliceBottom:
        nonInheritedData.unitySliceBottom =
            new StyleInt((int) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnitySliceLeft:
        nonInheritedData.unitySliceLeft =
            new StyleInt((int) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnitySliceRight:
        nonInheritedData.unitySliceRight =
            new StyleInt((int) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnitySliceTop:
        nonInheritedData.unitySliceTop =
            new StyleInt((int) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnityTextAlign:
        inheritedData.unityTextAlign =
            new StyleEnum<TextAnchor>((TextAnchor) sv.number, sv.keyword);
        break;
      case StylePropertyId.UnityTextOverflowPosition:
        nonInheritedData.unityTextOverflowPosition =
            new StyleEnum<TextOverflowPosition>(
                (TextOverflowPosition) sv.number, sv.keyword);
        break;
      case StylePropertyId.Visibility:
        inheritedData.visibility =
            new StyleEnum<Visibility>((Visibility) sv.number, sv.keyword);
        break;
      case StylePropertyId.WhiteSpace:
        inheritedData.whiteSpace =
            new StyleEnum<WhiteSpace>((WhiteSpace) sv.number, sv.keyword);
        break;
      case StylePropertyId.Width:
        nonInheritedData.width = new StyleLength(sv.length, sv.keyword);
        break;
      default:
        Debug.LogAssertion($"Unexpected property id {sv.id}");
        break;
      }
    }

    public void ApplyStyleCursor(StyleCursor sc) {
      nonInheritedData.cursor = sc;
    }

    public void ApplyInitialValue(StylePropertyReader reader) {
      switch (reader.propertyId) {
      case StylePropertyId.Custom:
        RemoveCustomStyleProperty(reader);
        break;
      default:
        ApplyInitialValue(reader.propertyId);
        break;
      }
    }

    public void ApplyInitialValue(StylePropertyId id) {
      switch (id) {
      case StylePropertyId.AlignContent:
        nonInheritedData.alignContent = InitialStyle.alignContent;
        break;
      case StylePropertyId.AlignItems:
        nonInheritedData.alignItems = InitialStyle.alignItems;
        break;
      case StylePropertyId.AlignSelf:
        nonInheritedData.alignSelf = InitialStyle.alignSelf;
        break;
      case StylePropertyId.BackgroundColor:
        nonInheritedData.backgroundColor = InitialStyle.backgroundColor;
        break;
      case StylePropertyId.BackgroundImage:
        nonInheritedData.backgroundImage = InitialStyle.backgroundImage;
        break;
      case StylePropertyId.BorderBottomColor:
        nonInheritedData.borderBottomColor = InitialStyle.borderBottomColor;
        break;
      case StylePropertyId.BorderBottomLeftRadius:
        nonInheritedData.borderBottomLeftRadius =
            InitialStyle.borderBottomLeftRadius;
        break;
      case StylePropertyId.BorderBottomRightRadius:
        nonInheritedData.borderBottomRightRadius =
            InitialStyle.borderBottomRightRadius;
        break;
      case StylePropertyId.BorderBottomWidth:
        nonInheritedData.borderBottomWidth = InitialStyle.borderBottomWidth;
        break;
      case StylePropertyId.BorderColor:
        nonInheritedData.borderTopColor = InitialStyle.borderTopColor;
        nonInheritedData.borderRightColor = InitialStyle.borderRightColor;
        nonInheritedData.borderBottomColor = InitialStyle.borderBottomColor;
        nonInheritedData.borderLeftColor = InitialStyle.borderLeftColor;
        break;
      case StylePropertyId.BorderLeftColor:
        nonInheritedData.borderLeftColor = InitialStyle.borderLeftColor;
        break;
      case StylePropertyId.BorderLeftWidth:
        nonInheritedData.borderLeftWidth = InitialStyle.borderLeftWidth;
        break;
      case StylePropertyId.BorderRadius:
        nonInheritedData.borderTopLeftRadius = InitialStyle.borderTopLeftRadius;
        nonInheritedData.borderTopRightRadius =
            InitialStyle.borderTopRightRadius;
        nonInheritedData.borderBottomRightRadius =
            InitialStyle.borderBottomRightRadius;
        nonInheritedData.borderBottomLeftRadius =
            InitialStyle.borderBottomLeftRadius;
        break;
      case StylePropertyId.BorderRightColor:
        nonInheritedData.borderRightColor = InitialStyle.borderRightColor;
        break;
      case StylePropertyId.BorderRightWidth:
        nonInheritedData.borderRightWidth = InitialStyle.borderRightWidth;
        break;
      case StylePropertyId.BorderTopColor:
        nonInheritedData.borderTopColor = InitialStyle.borderTopColor;
        break;
      case StylePropertyId.BorderTopLeftRadius:
        nonInheritedData.borderTopLeftRadius = InitialStyle.borderTopLeftRadius;
        break;
      case StylePropertyId.BorderTopRightRadius:
        nonInheritedData.borderTopRightRadius =
            InitialStyle.borderTopRightRadius;
        break;
      case StylePropertyId.BorderTopWidth:
        nonInheritedData.borderTopWidth = InitialStyle.borderTopWidth;
        break;
      case StylePropertyId.BorderWidth:
        nonInheritedData.borderTopWidth = InitialStyle.borderTopWidth;
        nonInheritedData.borderRightWidth = InitialStyle.borderRightWidth;
        nonInheritedData.borderBottomWidth = InitialStyle.borderBottomWidth;
        nonInheritedData.borderLeftWidth = InitialStyle.borderLeftWidth;
        break;
      case StylePropertyId.Bottom:
        nonInheritedData.bottom = InitialStyle.bottom;
        break;
      case StylePropertyId.Color:
        inheritedData.color = InitialStyle.color;
        break;
      case StylePropertyId.Cursor:
        nonInheritedData.cursor = InitialStyle.cursor;
        break;
      case StylePropertyId.Display:
        nonInheritedData.display = InitialStyle.display;
        break;
      case StylePropertyId.Flex:
        nonInheritedData.flexGrow = InitialStyle.flexGrow;
        nonInheritedData.flexShrink = InitialStyle.flexShrink;
        nonInheritedData.flexBasis = InitialStyle.flexBasis;
        break;
      case StylePropertyId.FlexBasis:
        nonInheritedData.flexBasis = InitialStyle.flexBasis;
        break;
      case StylePropertyId.FlexDirection:
        nonInheritedData.flexDirection = InitialStyle.flexDirection;
        break;
      case StylePropertyId.FlexGrow:
        nonInheritedData.flexGrow = InitialStyle.flexGrow;
        break;
      case StylePropertyId.FlexShrink:
        nonInheritedData.flexShrink = InitialStyle.flexShrink;
        break;
      case StylePropertyId.FlexWrap:
        nonInheritedData.flexWrap = InitialStyle.flexWrap;
        break;
      case StylePropertyId.FontSize:
        inheritedData.fontSize = InitialStyle.fontSize;
        break;
      case StylePropertyId.Height:
        nonInheritedData.height = InitialStyle.height;
        break;
      case StylePropertyId.JustifyContent:
        nonInheritedData.justifyContent = InitialStyle.justifyContent;
        break;
      case StylePropertyId.Left:
        nonInheritedData.left = InitialStyle.left;
        break;
      case StylePropertyId.Margin:
        nonInheritedData.marginTop = InitialStyle.marginTop;
        nonInheritedData.marginRight = InitialStyle.marginRight;
        nonInheritedData.marginBottom = InitialStyle.marginBottom;
        nonInheritedData.marginLeft = InitialStyle.marginLeft;
        break;
      case StylePropertyId.MarginBottom:
        nonInheritedData.marginBottom = InitialStyle.marginBottom;
        break;
      case StylePropertyId.MarginLeft:
        nonInheritedData.marginLeft = InitialStyle.marginLeft;
        break;
      case StylePropertyId.MarginRight:
        nonInheritedData.marginRight = InitialStyle.marginRight;
        break;
      case StylePropertyId.MarginTop:
        nonInheritedData.marginTop = InitialStyle.marginTop;
        break;
      case StylePropertyId.MaxHeight:
        nonInheritedData.maxHeight = InitialStyle.maxHeight;
        break;
      case StylePropertyId.MaxWidth:
        nonInheritedData.maxWidth = InitialStyle.maxWidth;
        break;
      case StylePropertyId.MinHeight:
        nonInheritedData.minHeight = InitialStyle.minHeight;
        break;
      case StylePropertyId.MinWidth:
        nonInheritedData.minWidth = InitialStyle.minWidth;
        break;
      case StylePropertyId.Opacity:
        nonInheritedData.opacity = InitialStyle.opacity;
        break;
      case StylePropertyId.Overflow:
        nonInheritedData.overflow = InitialStyle.overflow;
        break;
      case StylePropertyId.Padding:
        nonInheritedData.paddingTop = InitialStyle.paddingTop;
        nonInheritedData.paddingRight = InitialStyle.paddingRight;
        nonInheritedData.paddingBottom = InitialStyle.paddingBottom;
        nonInheritedData.paddingLeft = InitialStyle.paddingLeft;
        break;
      case StylePropertyId.PaddingBottom:
        nonInheritedData.paddingBottom = InitialStyle.paddingBottom;
        break;
      case StylePropertyId.PaddingLeft:
        nonInheritedData.paddingLeft = InitialStyle.paddingLeft;
        break;
      case StylePropertyId.PaddingRight:
        nonInheritedData.paddingRight = InitialStyle.paddingRight;
        break;
      case StylePropertyId.PaddingTop:
        nonInheritedData.paddingTop = InitialStyle.paddingTop;
        break;
      case StylePropertyId.Position:
        nonInheritedData.position = InitialStyle.position;
        break;
      case StylePropertyId.Right:
        nonInheritedData.right = InitialStyle.right;
        break;
      case StylePropertyId.TextOverflow:
        nonInheritedData.textOverflow = InitialStyle.textOverflow;
        break;
      case StylePropertyId.Top:
        nonInheritedData.top = InitialStyle.top;
        break;
      case StylePropertyId.UnityBackgroundImageTintColor:
        nonInheritedData.unityBackgroundImageTintColor =
            InitialStyle.unityBackgroundImageTintColor;
        break;
      case StylePropertyId.UnityBackgroundScaleMode:
        nonInheritedData.unityBackgroundScaleMode =
            InitialStyle.unityBackgroundScaleMode;
        break;
      case StylePropertyId.UnityFont:
        inheritedData.unityFont = InitialStyle.unityFont;
        break;
      case StylePropertyId.UnityFontStyleAndWeight:
        inheritedData.unityFontStyleAndWeight =
            InitialStyle.unityFontStyleAndWeight;
        break;
      case StylePropertyId.UnityOverflowClipBox:
        nonInheritedData.unityOverflowClipBox =
            InitialStyle.unityOverflowClipBox;
        break;
      case StylePropertyId.UnitySliceBottom:
        nonInheritedData.unitySliceBottom = InitialStyle.unitySliceBottom;
        break;
      case StylePropertyId.UnitySliceLeft:
        nonInheritedData.unitySliceLeft = InitialStyle.unitySliceLeft;
        break;
      case StylePropertyId.UnitySliceRight:
        nonInheritedData.unitySliceRight = InitialStyle.unitySliceRight;
        break;
      case StylePropertyId.UnitySliceTop:
        nonInheritedData.unitySliceTop = InitialStyle.unitySliceTop;
        break;
      case StylePropertyId.UnityTextAlign:
        inheritedData.unityTextAlign = InitialStyle.unityTextAlign;
        break;
      case StylePropertyId.UnityTextOverflowPosition:
        nonInheritedData.unityTextOverflowPosition =
            InitialStyle.unityTextOverflowPosition;
        break;
      case StylePropertyId.Visibility:
        inheritedData.visibility = InitialStyle.visibility;
        break;
      case StylePropertyId.WhiteSpace:
        inheritedData.whiteSpace = InitialStyle.whiteSpace;
        break;
      case StylePropertyId.Width:
        nonInheritedData.width = InitialStyle.width;
        break;
      default:
        Debug.LogAssertion($"Unexpected property id {id}");
        break;
      }
    }

    public void ApplyUnsetValue(StylePropertyReader reader,
                                ComputedStyle parentStyle) {
      switch (reader.propertyId) {
      case StylePropertyId.Custom:
        RemoveCustomStyleProperty(reader);
        break;
      default:
        ApplyUnsetValue(reader.propertyId, parentStyle);
        break;
      }
    }

    public void ApplyUnsetValue(StylePropertyId id, ComputedStyle parentStyle) {
      switch (id) {
      case StylePropertyId.Color:
        inheritedData.color = parentStyle.color;
        break;
      case StylePropertyId.FontSize:
        inheritedData.fontSize = parentStyle.fontSize;
        break;
      case StylePropertyId.UnityFont:
        inheritedData.unityFont = parentStyle.unityFont;
        break;
      case StylePropertyId.UnityFontStyleAndWeight:
        inheritedData.unityFontStyleAndWeight =
            parentStyle.unityFontStyleAndWeight;
        break;
      case StylePropertyId.UnityTextAlign:
        inheritedData.unityTextAlign = parentStyle.unityTextAlign;
        break;
      case StylePropertyId.Visibility:
        inheritedData.visibility = parentStyle.visibility;
        break;
      case StylePropertyId.WhiteSpace:
        inheritedData.whiteSpace = parentStyle.whiteSpace;
        break;
      default:
        ApplyInitialValue(id);
        break;
      }
    }
  }
}
