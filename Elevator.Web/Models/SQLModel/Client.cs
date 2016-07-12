using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elevator.Web.Models.SQLModel.Dictionary;

namespace Elevator.Web.Models.SQLModel
{
    public class Client
    //      Klient
    //Имя(офиц)
    //Название(внутр)
    //Регистрационный номер
    //Адрес
    //Телефон
    //Банк
    //Счёт номер
    //Контактная персона
    //Контакт  адрес
    //Контакт майл адрес
    //Контакт телефон
    {
        public int ClientID { get; set; }
        public string OfficialName { get; set; }
        public string ShortName { get; set; }
        public string RegNum { get; set; }
        public string RegAdress { get; set; }
        public string OfficePhone { get; set; }
        public string OfficeEmail { get; set; }
        public ClientsBank Bank { get; set; }
        public string CountNum { get; set; }
        public string Contact { get; set; }
        public string ContactAdress { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }

    }
}