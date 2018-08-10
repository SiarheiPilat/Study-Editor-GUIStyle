public class GUIStyle {
        //from https://github.com/Unity-Technologies/UnityCsReference/blob/master/Editor/Mono/GUI/EditorStyles.cs
        private void InitSharedStyles()
        {
            m_ColorPickerBox = GetStyle("ColorPickerBox");
            m_InspectorBig = GetStyle("In BigTitle");
            m_MiniLabel = GetStyle("miniLabel");
            m_LargeLabel = GetStyle("LargeLabel");
            m_BoldLabel = GetStyle("BoldLabel");
            m_MiniBoldLabel = GetStyle("MiniBoldLabel");
            m_WordWrappedLabel = GetStyle("WordWrappedLabel");
            m_WordWrappedMiniLabel = GetStyle("WordWrappedMiniLabel");
            m_WhiteLabel = GetStyle("WhiteLabel");
            m_WhiteMiniLabel = GetStyle("WhiteMiniLabel");
            m_WhiteLargeLabel = GetStyle("WhiteLargeLabel");
            m_WhiteBoldLabel = GetStyle("WhiteBoldLabel");
            m_MiniTextField = GetStyle("MiniTextField");
            m_RadioButton = GetStyle("Radio");
            m_MiniButton = GetStyle("miniButton");
            m_MiniButtonLeft = GetStyle("miniButtonLeft");
            m_MiniButtonMid = GetStyle("miniButtonMid");
            m_MiniButtonRight = GetStyle("miniButtonRight");
            m_Toolbar = GetStyle("toolbar");
            m_ToolbarButton = GetStyle("toolbarbutton");
            m_ToolbarPopup = GetStyle("toolbarPopup");
            m_ToolbarDropDown = GetStyle("toolbarDropDown");
            m_ToolbarTextField = GetStyle("toolbarTextField");
            m_ToolbarSearchField = GetStyle("ToolbarSeachTextField");
            m_ToolbarSearchFieldPopup = GetStyle("ToolbarSeachTextFieldPopup");
            m_ToolbarSearchFieldCancelButton = GetStyle("ToolbarSeachCancelButton");
            m_ToolbarSearchFieldCancelButtonEmpty = GetStyle("ToolbarSeachCancelButtonEmpty");
            m_SearchField = GetStyle("SearchTextField");
            m_SearchFieldCancelButton = GetStyle("SearchCancelButton");
            m_SearchFieldCancelButtonEmpty = GetStyle("SearchCancelButtonEmpty");
            m_HelpBox = GetStyle("HelpBox");
            m_AssetLabel = GetStyle("AssetLabel");
            m_AssetLabelPartial = GetStyle("AssetLabel Partial");
            m_AssetLabelIcon = GetStyle("AssetLabel Icon");
            m_SelectionRect = GetStyle("selectionRect");
            m_MinMaxHorizontalSliderThumb = GetStyle("MinMaxHorizontalSliderThumb");
            m_DropDownList = GetStyle("DropDownButton");
            m_MinMaxStateDropdown = GetStyle("IN MinMaxStateDropdown");
            m_BoldFont = GetStyle("BoldLabel").font;
            m_StandardFont = GetStyle("Label").font;
            m_MiniFont = GetStyle("MiniLabel").font;
            m_MiniBoldFont = GetStyle("MiniBoldLabel").font;
            m_ProgressBarBack = GetStyle("ProgressBarBack");
            m_ProgressBarBar = GetStyle("ProgressBarBar");
            m_ProgressBarText = GetStyle("ProgressBarText");
            m_FoldoutPreDrop = GetStyle("FoldoutPreDrop");
            m_InspectorTitlebar = GetStyle("IN Title");
            m_InspectorTitlebarText = GetStyle("IN TitleText");
            m_ToggleGroup = GetStyle("BoldToggle");
            m_Tooltip = GetStyle("Tooltip");
            m_NotificationText = GetStyle("NotificationText");
            m_NotificationBackground = GetStyle("NotificationBackground");

            // Former LookLikeControls styles
            m_Popup = m_LayerMaskField = GetStyle("MiniPopup");
            m_TextField = m_NumberField = GetStyle("textField");
            m_Label = GetStyle("ControlLabel");
            m_ObjectField = GetStyle("ObjectField");
            m_ObjectFieldThumb = GetStyle("ObjectFieldThumb");
            m_ObjectFieldMiniThumb = GetStyle("ObjectFieldMiniThumb");
            m_Toggle = GetStyle("Toggle");
            m_ToggleMixed = GetStyle("ToggleMixed");
            m_ColorField = GetStyle("ColorField");
            m_Foldout = GetStyle("Foldout");
            m_FoldoutSelected = GUIStyle.none;
            m_IconButton = GetStyle("IconButton");
            m_TextFieldDropDown = GetStyle("TextFieldDropDown");
            m_TextFieldDropDownText = GetStyle("TextFieldDropDownText");

            m_LinkLabel = new GUIStyle(m_Label);
            // Match selection color which works nicely for both light and dark skins
            m_LinkLabel.normal.textColor = new Color(0.25f, 0.5f, 0.9f, 1f);
            m_LinkLabel.stretchWidth = false;

            m_TextArea = new GUIStyle(m_TextField);
            m_TextArea.wordWrap = true;

            m_InspectorDefaultMargins = new GUIStyle();
            m_InspectorDefaultMargins.padding = new RectOffset(
                    InspectorWindow.kInspectorPaddingLeft,
                    InspectorWindow.kInspectorPaddingRight, 0, 0);

            // For the full width margins, use padding from right side in both sides,
            // though adjust for overdraw by adding one in left side to get even margins.
            m_InspectorFullWidthMargins = new GUIStyle();
            m_InspectorFullWidthMargins.padding = new RectOffset(
                    InspectorWindow.kInspectorPaddingRight + 1,
                    InspectorWindow.kInspectorPaddingRight, 0, 0);

            // Derive centered grey mini label from base minilabel
            m_CenteredGreyMiniLabel = new GUIStyle(m_MiniLabel);
            m_CenteredGreyMiniLabel.alignment = TextAnchor.MiddleCenter;
            m_CenteredGreyMiniLabel.normal.textColor = Color.grey;
        }

}
