namespace Elevator.Web.Models.EE.Dictionary
{
    public  class ElevatorNowStatus
    {
       //       тек.состояние лифта
        //Эксплуатируется
        //Выключен
        //Ремонт
        //Необходимо уточнить
       public int ElevatorNowStatusId { get; set; }
       public string ElevatorNowStatusName { get; set; }
    }

    //public enum StatusList
    //{
    //  AtWork = 1,
    //    Vacation = 2
    //}
}