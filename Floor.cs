using ConsoleApp2.Panel;


namespace ConsoleApp2
{
    internal class Floor
    {
        public int ID { get; set; }
        public HallPanel HallPanel { get; set; }   
        public Display Display { get; set; }
       
        public Floor(int ID) { 
            this.ID = ID;
            this.HallPanel = new HallPanel(ID);
            this.Display = new Display();
        }
        #region method
        public bool IsTopMost() { return this.ID == ElevatorCar.MAX_FLOOR; }
        public bool IsBottomMost() { return this.ID == ElevatorCar.MIN_FLOOR; }
        #endregion
    }
}
