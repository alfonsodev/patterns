//TestFlyweight.java - the Client, tests the Flyweight


namespace Structural.Flyweight {

using tap;


class TestFlyweight {  
   static TeaFlavor[] flavors = new TeaFlavor[100];
   static TeaOrderContext[] tables = new TeaOrderContext[100];
   static int ordersMade = 0;    
   static TeaFlavorFactory teaFlavorFactory;
    
   static void takeOrders(string flavorIn, int table) {
       flavors[ordersMade] = 
         teaFlavorFactory.getTeaFlavor(flavorIn);
       tables[ordersMade++] = 
         new TeaOrderContext(table);
   }
    
   public static void Main() {
       teaFlavorFactory = new TeaFlavorFactory();
       
       takeOrders("chai", 2);    
       takeOrders("chai", 2);
       takeOrders("camomile", 1);
       takeOrders("camomile", 1);
       takeOrders("earl grey", 1);
       takeOrders("camomile", 897);
       takeOrders("chai", 97);
       takeOrders("chai", 97);
       takeOrders("camomile", 3);
       takeOrders("earl grey", 3);
       takeOrders("chai", 3);
       takeOrders("earl grey", 96);
       takeOrders("camomile", 552);
       takeOrders("chai", 121);
       takeOrders("earl grey", 121);
      
       for (int i = 0; i < ordersMade; i++) {
           flavors[i].serveTea(tables[i]);
       }  

		Tapper tap = new Tapper();
		tap.test("Flyweight test", 
			("total teaFlavor objects made: " + teaFlavorFactory.getTotalTeaFlavorsMade()) , ("total teaFlavor objects made: 3")
		);
		tap.done();
   }
}

}    
