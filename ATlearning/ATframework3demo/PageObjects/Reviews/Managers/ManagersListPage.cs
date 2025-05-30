﻿
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.TestCases.ProjectWorkPart3.Manager
{
    public class ManagersListPage
    {
        public ManagersListPage CheckManagerIsAdded(string ManagerLastNameName)
        {
            WebItem managerName = new WebItem($"//span[@class='main-grid-cell-content' and text()='{ManagerLastNameName}']",
                "Строка с именем и фамилией в списке менеджеров");
            if (managerName.InnerText() != ManagerLastNameName)
            {
                Log.Error($"Менеджер не отображается в списке. Ожидалось, что в списке появится менеджер с именем {ManagerLastNameName}");
            }
            else
            {
                Log.Info($"Менеджер с именем {ManagerLastNameName} отображается в списке менеджеров.");
            }
               
            return new ManagersListPage();
        }
    }
}
