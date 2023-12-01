using System;

{
    internal class Program
    {
        static void Main()
        {
          
            Customer customer = new Customer();
            Order order = new Order();
            OrderDateail order1 = new OrderDateail();
            item it = new item();

            Cash payment1 = new Cash();
            Check payment2 = new Check();
            Credit payment3 = new Credit();


        }
    }
}

class Customer
{
    private string name, adderss;
    Order order2 = new Order();

}
class Order
{
    private DateTime Date;
    private string status;
    OrderDateail order2 = new OrderDateail();

    public void calcSubTotal()
    {
    }

    public void calcTax()
    {
    }


    public void calcTotal()
    {
    }
    public void calcTotalWeight()
    {
    }


}

class OrderDateail
{
    private string quality, taxStatus;

    public void calcTotal()
    {

    }

    public void calclWeight()
    {
    }

    public void calcTax()
    {
    }


}

class item
{
    private string shipping, description;

    public void setshipping(string sh)
    {
        this.shipping = sh;
    }

    public string getshipping()
    {
        return shipping;
    }

    public void setdescription(string sh)
    {
        this.shipping = sh;
    }

    public string getdescription()
    {
        return description;
    }

    public void inStock()
    {
    }

}

class payment
{
    private float amount;
}
class Cash : payment
{
    private float cashTendered;
}

class Check : payment
{
    private string name, bankID;

    public void authorized()
    {

    }
}

class Credit : payment
{
    private string name, type, expDate;

    public void authorized()
    {

    }

}