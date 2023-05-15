using . . . 
namespace planeBooking
{

    public plane plane {get; set;}
    public customer customer {get; set;}
    public Location Location {get; set;}
    public datetime datetime {get; set;}
    public bool isclosed {get;set;}
    public int seatnumber {get;set;}

    public booking(plane plane,custoemr custoemr, Location Location)
    {
        this.plane = plane;
        this.customer = customer;
        this.Location = Location;
    }
      

    public void makebooking()
    {

        
    }
}