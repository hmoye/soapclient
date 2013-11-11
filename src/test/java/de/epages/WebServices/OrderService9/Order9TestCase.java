package de.epages.WebServices.OrderService9;

import de.epages.WebServices.OrderService9.Stub.*;
import de.epages.WebServices.WebServiceConfiguration;
import org.junit.*;
import static org.junit.Assert.*;

import java.rmi.RemoteException;
import java.util.GregorianCalendar;
import java.util.logging.Logger;
/* import java.math.BigInteger; */
import java.net.MalformedURLException;

/**
 * A JUnit TestSuite to test epages Order WebServices.
 */
public class Order9TestCase extends WebServiceConfiguration {
    private static Logger log = Logger.getLogger(Order9TestCase.class.getName());

    private Bind_Order_SOAPStub orderService;
    TCreate_Input Order_in = new TCreate_Input();
    TUpdate_Input Order_up = new TUpdate_Input();
    TAttribute OrderAttr_in = new TAttribute("Comment","my customer commment",null,null);
    TAttribute OrderAttr_up = new TAttribute("Comment","my updated customer comment",null,null);
    TAddressNamed Address_in = new TAddressNamed();
    TAddressNamed Address_up = new TAddressNamed();

    String Alias = "java_test-1";
    String Customer = "/Shops/DemoShop/Customers/1001"; /* mmustermann */
    String OrderPath = Customer + "/Orders/" + Alias;

    String[] Orders = new String[]{OrderPath};
    String[] OrderAttributes = new String[]{"Comment"};
    String[] AddressAttributes = new String[]{"JobTitle" /*,"Salutation" */ };
    String[] ItemAttributes = new String[]{"Name"};

    /**
     * Sets all the required prerequisites for the tests. Will be called before the test are run.
     */
    @Before
    public void setUp() throws RemoteException, MalformedURLException {
        log.info("Order5TestCase: setUp");

        OrderService serviceLocator = new OrderServiceLocator();
        log.info("address specified by wsdl: " + serviceLocator.getport_OrderAddress());
        log.info("using web service Url: " + WEBSERVICE_URL);

        orderService = new Bind_Order_SOAPStub(new java.net.URL(WEBSERVICE_URL), serviceLocator);

        // setting user-path and password of the shop
        orderService.setUsername(WEBSERVICE_LOGIN);
        orderService.setPassword(WEBSERVICE_PASSWORD);

        // init input address data
        Address_in.setEMail("java_test-1@epages.de");
        Address_in.setFirstName("Klaus");
        Address_in.setLastName("Klaussen");
        Address_in.setStreet("Musterstraße 2");
        Address_in.setStreet2("Ortsteil Niederfingeln");
        Address_in.setCodePorte("13a");
        Address_in.setAttributes( new TAttribute[] {
                new TAttribute("JobTitle","best Job",null,null),
                new TAttribute("Salutation","Dr.",null,null),
        });

        Address_up.setFirstName("Hans");
        Address_up.setLastName("Hanssen");
        Address_up.setStreet("Musterstraße 2b");
        Address_up.setStreet2("Ortsteil Oberfingeln");
        Address_up.setCodePorte("13u");

        // init order input data
        Order_in.setAlias(Alias);
        Order_in.setCustomer(Customer);
        Order_in.setBillingAddress(Address_in);
        Order_in.setCreationDate(new GregorianCalendar(2008,0,1,11,11));
        Order_in.setViewedOn(new GregorianCalendar(2008,0,2,12,00));
        Order_in.setAttributes(new TAttribute[]{OrderAttr_in});
        TLineItemContainerIn lineItemContainer = new TLineItemContainerIn();
        lineItemContainer.setCurrencyID("EUR");
        lineItemContainer.setPaymentMethod("/Shops/DemoShop/PaymentMethods/Invoice");
        lineItemContainer.setShippingMethod("/Shops/DemoShop/ShippingMethods/Express");
        lineItemContainer.setTaxArea("/TaxMatrixGermany/EU");
        lineItemContainer.setTaxModel("gross");
        lineItemContainer.setProductLineItems(new TProductLineItemIn[]{
                new TProductLineItemIn("/Shops/DemoShop/Products/ho_1112105010", (float)10),
                //new TProductLineItemIn("/Shops/DemoShop/Products/de_3203104010", (float)10),
        });
        Order_in.setLineItemContainer(lineItemContainer);

        // init order update data
        Order_up.setPath(OrderPath);
        Order_up.setBillingAddress(Address_up);
        Order_up.setCreationDate(new GregorianCalendar(2008,0,1,11,11));
        Order_up.setInProcessOn(new GregorianCalendar(2008,0,3,12,00));
        Order_up.setAttributes(new TAttribute[]{OrderAttr_up});

        // delete the test order if it exists
        try {
            TExists_Return[] Orders_exists_out = orderService.exists(new String[]{OrderPath});
            if( Orders_exists_out[0].getExists() ) {
                TDelete_Return[] Orders_delete_out = orderService.delete(new String[]{OrderPath});
                assertEquals("delete result set", 1, Orders_delete_out.length);
            }
        }
        catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    /**
     * Create a Order and check if the creation was successful
     */
    public void testCreate() throws RemoteException {
        log.info("Order5TestCase: testCreate");
        try {
            TCreate_Return[] Orders_create_out = orderService.create(new TCreate_Input[]{Order_in});
            assertEquals("create result set", 1, Orders_create_out.length);
            assertEquals("created?", new Boolean(true), Orders_create_out[0].getCreated());
        }
        catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    /**
     * Update a Order and check if the update was successful
     */
    public void testUpdate() throws RemoteException {
        log.info("Order5TestCase: testUpdate");
        try {
            TUpdate_Return[] Orders_update_out = orderService.update(new TUpdate_Input[]{Order_up});
            assertEquals("update result set", 1, Orders_update_out.length);
            assertEquals("updated?", new Boolean(true), Orders_update_out[0].getUpdated());
        }
        catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    /**
     * Retrieve information about an Order. Check if the returned data are equal to
     * the data of create or update call
     *
     * @param isAlreadyUpdated if true check against update data, else against create data
     */
    public void testGetInfo(boolean isAlreadyUpdated) throws RemoteException {
        log.info("Order5TestCase: testGetInfo");
        try {
            TGetInfo_Return[] Orders_info_out = orderService.getInfo(Orders, OrderAttributes, AddressAttributes, ItemAttributes, null);
            assertEquals("exists result set", 1, Orders_info_out.length);

            TGetInfo_Return Order_info_out = Orders_info_out[0];
            assertEquals("Alias", Alias, Order_info_out.getAlias());
            assertEquals("Customer", Order_in.getCustomer(), Order_info_out.getCustomer());

            TAddressNamed Address_out = Order_info_out.getBillingAddress();
            assertEquals("EMail", Address_in.getEMail(), Address_out.getEMail());


            if (isAlreadyUpdated) {
                // check updated order data
                assertEquals("InProcessOn", Order_up.getInProcessOn().getTime(), Order_info_out.getInProcessOn().getTime());
                assertEquals("Comment", Order_up.getAttributes()[0].getValue(), Order_info_out.getAttributes()[0].getValue());

                // check updated address
                assertEquals("FirstName", Address_up.getFirstName(), Address_out.getFirstName());
                assertEquals("LastName", Address_up.getLastName(), Address_out.getLastName());
                assertEquals("Street", Address_up.getStreet(), Address_out.getStreet());
                assertEquals("Street2", Address_up.getStreet2(), Address_out.getStreet2());
                assertEquals("CodePorte", Address_up.getCodePorte(), Address_out.getCodePorte());
            } else {
                // check order data created without update
                assertEquals("ViewedOn", Order_in.getViewedOn().getTime(), Order_info_out.getViewedOn().getTime());
                assertEquals("CreationDate", Order_in.getCreationDate().getTime(), Order_info_out.getCreationDate().getTime());
                assertEquals("Comment", Order_in.getAttributes()[0].getValue(), Order_info_out.getAttributes()[0].getValue());

                // check created address
                assertEquals("FirstName", Address_in.getFirstName(), Address_out.getFirstName());
                assertEquals("LastName", Address_in.getLastName(), Address_out.getLastName());
                assertEquals("Street", Address_in.getStreet(), Address_out.getStreet());
                assertEquals("Street2", Address_in.getStreet2(), Address_out.getStreet2());
                assertEquals("CodePorte", Address_in.getCodePorte(), Address_out.getCodePorte());
            }

            assertEquals("TaxArea", Order_in.getLineItemContainer().getTaxArea()      , Order_info_out.getLineItemContainer().getTaxArea()      );
            assertEquals("TaxModel", Order_in.getLineItemContainer().getTaxModel()     , Order_info_out.getLineItemContainer().getTaxModel()     );
            assertEquals("CurrencyID", Order_in.getLineItemContainer().getCurrencyID()   , Order_info_out.getLineItemContainer().getCurrencyID()   );

            TProductLineItemIn refLineItem = Order_in.getLineItemContainer().getProductLineItems()[0];
            TBaseLineItem[] AllLineItems = Order_info_out.getLineItemContainer().getAllBaseLineItems();
            for (TBaseLineItem tBaseLineItem : AllLineItems) {
                if ( "Products/" + tBaseLineItem.getSKU() == refLineItem.getProduct() ) {
                    assertEquals("base line item is a product", "LineItemProduct", tBaseLineItem.getClass());
                    assertEquals("base line item quantity", (float)refLineItem.getQuantity(), (float)tBaseLineItem.getQuantity());
                }
            }
        }
        catch (RemoteException e) {
            e.printStackTrace();
        }


    }

    /**
     * Delete a Order and check if no error occured.
     */
    public void testDelete() throws RemoteException {
        log.info("Order5TestCase: testDelete");
        try {
            TDelete_Return[] Orders_delete_out = orderService.delete(new String[]{OrderPath});
            assertEquals("delete result set", 1, Orders_delete_out.length);
            }
        catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    /**
    * test exists method
    * @param expected  if false, test is successful if the Order does NOT exists
    */
    public void testExists(boolean expected) throws RemoteException {
        log.info("Order5TestCase: testExists");
        try {
            TExists_Return[] Orders_exists_out = orderService.exists(new String[]{OrderPath});
            assertEquals("exists result set", 1, Orders_exists_out.length);
            assertEquals("exists?", new Boolean(expected), Orders_exists_out[0].getExists());
            }
        catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    /**
     * Test if a Order is found by Alias
     */
    public void testFind() {
        log.info("Order5TestCase: testFind");
        TFind_Input searchParameters = new TFind_Input();
        searchParameters.setAlias(Alias);
        searchParameters.setIsViewed(true);

        try {
            String[] Orders_find_out = orderService.find(searchParameters);
            assertEquals("find result set", 1, Orders_find_out.length);
            assertEquals("found path", OrderPath, Orders_find_out[0]);
        }
        catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    /**
     * Test if a Order is found by Customer
     */
    public void testFindCustomerOrder() {
        log.info("Order5TestCase: testFind");
        TFind_Input searchParameters = new TFind_Input();
        searchParameters.setCustomer(Customer);

        try {
            String[] Orders_find_out = orderService.find(searchParameters);
            assertTrue("find result set", Orders_find_out.length >= 1 );
        }
        catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    /**
     * runs all tests
     */
    @Test
    public void testAll() throws RemoteException
    {
        testCreate();
        testExists(true);
        testFind();
        testFindCustomerOrder();
        testGetInfo(false);
        testUpdate();
        testGetInfo(true);
        testDelete();
        testExists(false);
    }
}