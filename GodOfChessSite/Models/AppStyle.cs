using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodOfChessSite.Models
{
    public class AppStyle
    {
        public string Color { get; set; } = "green";
        public string Size { get; set; } = "65px";
        public List<string> RandomPhrases { get; set; } = new List<string>()
        {
            "Правду говорят — убивает не падение, а внезапная остановка в конце",
            "Для того, чтобы спорить, нужны два глупца",
            "Если Чеширский кот улыбается, значит, это кому-нибудь нужно"
        };

        public List<TableListModel> TableStyles { get; set; } = new List<TableListModel>()
        {
            new TableListModel()
            {
                Text = "Table Striped",
                Value = "table-striped"
            },
            new TableListModel()
            {
                Text = "Table Light",
                Value = "table-light"
            },
            new TableListModel()
            {
                Text = "Table Dark",
                Value = "table-dark"
            }
        };
    }
}
