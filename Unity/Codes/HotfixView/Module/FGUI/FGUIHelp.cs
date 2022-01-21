using FairyGUI;

namespace ET
{
    public static class FGUIHelp
    {
        
        public static void AddListener(this GButton gButton, System.Action action)
        {
            gButton.onClick.Set(() =>
            {
                action();
            });
        }
        
        public static void AddListener(this GButton gButton, System.Action<int> action ,int id)
        {
            gButton.onClick.Set(() =>
            {
                action(id);
            });
        }
      


    }
}