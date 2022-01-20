/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace TestM
{
    public partial class FUI_TestMUI : GComponent
    {
        public GGraph m_bg;
        public GTextField m_title;
        public GTextField m_logo;
        public GTextField m_tip;
        public GProgressBar m_pb;
        public const string URL = "ui://5hcuqm5omc2q0";

        public static FUI_TestMUI CreateInstance()
        {
            return (FUI_TestMUI)UIPackage.CreateObject("TestM", "TestMUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GGraph)GetChildAt(0);
            m_title = (GTextField)GetChildAt(1);
            m_logo = (GTextField)GetChildAt(2);
            m_tip = (GTextField)GetChildAt(3);
            m_pb = (GProgressBar)GetChildAt(4);
        }
    }
}