package de.epages.WebServices.CustomerService2;

import de.epages.WebServices.CustomerService2.Stub.*;
import de.epages.WebServices.WebServiceConfiguration;

import org.junit.*;
import static org.junit.Assert.*;

import java.util.*;
import java.util.logging.Logger;
import java.net.MalformedURLException;
import java.rmi.RemoteException;

/**
 * A JUnit TestSuite to test epages Customer WebServices.
 */
public class Customer2TestCase extends WebServiceConfiguration {
    private static Logger log = Logger.getLogger(Customer2TestCase.class.getName());
    private Bind_Customer_SOAPStub customerService;

    private TCreate_Input customer_in       = new TCreate_Input();
    private TUpdate_Input customer_update   = new TUpdate_Input();
    
    private String custpath = "/Shops/DemoShop/Customers/";
    private String alias    = "java_test-1";
    private String path     = custpath+alias;
    private String email    = "java_test-1@epages.de";

    /**
     * Sets all the required prerequisites for the tests. Will be called before the test are run.
     */
    @Before
    public void setUp() throws RemoteException, MalformedURLException {

        // init customerService
        CustomerService serviceLocator = new CustomerServiceLocator();
        log.info("address specified by wsdl: " + serviceLocator.getport_CustomerAddress());
        log.info("using web service Url: " + WEBSERVICE_URL);
        customerService = new Bind_Customer_SOAPStub(new java.net.URL(WEBSERVICE_URL), serviceLocator);
        customerService.setUsername(WEBSERVICE_LOGIN);
        customerService.setPassword(WEBSERVICE_PASSWORD);
        
        // test data customer_in
        customer_in.setAlias(alias);
        customer_in.setCustomerGroup("/Shops/DemoShop/Groups/NewCustomer");
        customer_in.setTaxArea("/TaxMatrixGermany/EU");
        customer_in.setTaxModel("gross");
        customer_in.setCurrencyID("EUR");
        TAddress billingAddress = new TAddress();
            billingAddress.setEMail(        email );
            billingAddress.setFirstName(    "Klaus" );
            billingAddress.setLastName(     "Klaussen" );
            billingAddress.setStreet(       "Musterstraße 2" );
            billingAddress.setStreet2(      "Ortsteil Niederfingeln" );
            billingAddress.setBirthday( new GregorianCalendar(1976,9,25,11,33) );
        customer_in.setBillingAddress(billingAddress);
        TAttribute custAttr = new TAttribute();
            custAttr.setName(   "Comment");
            custAttr.setValue(  "my customer comment");
        customer_in.setAttributes(new TAttribute[]{custAttr});
 
        // test data customer_update
        customer_update.setPath(path);
        TAddress billingAddress2 = new TAddress();
            billingAddress2.setFirstName(   "Hans" );
            billingAddress2.setLastName(    "Hanssen" );
            billingAddress2.setStreet(      "Musterstraße 2b" );
            billingAddress2.setStreet2(     "Ortsteil Oberfingeln" );
        customer_update.setBillingAddress(billingAddress2);
            TAttribute custAttr2 = new TAttribute();
                custAttr2.setName("Comment");
                custAttr2.setValue("my updated customer comment");
        customer_update.setAttributes(new TAttribute[]{custAttr2});
        
        // delete the test customer if it exists
        TExists_Return[] ret = customerService.exists(new String[]{path});
        if( ret[0].getExists() ) {
            log.info("Customer2TestCase: delete customer "+path+" before start testing");
            customerService.delete(new String[]{path});
        }
    }

    /**
     * Create a customer and check if the creation was successful
     */
    public void testCreate() throws RemoteException {
        log.info("Customer2TestCase: testCreate");
        TCreate_Return[] customers_out = customerService.create(new TCreate_Input[]{customer_in});

        // test if creation was successful
        assertEquals("create result set", 1, customers_out.length );
        if(customers_out.length >= 1) {
        	TCreate_Return customer_out = customers_out[0];
        	if( null != customer_out.getError() ) {
        		log.warning(customer_out.getError().getMessage());
            	assertNull("create: no error", customer_out.getError());
        	}
        	else {
        		assertTrue("created?", customers_out[0].getCreated() );
        	}
        }
    }

    /**
     * Update a customer and check if the update was successful
     */
   public void testUpdate() throws RemoteException {
        log.info("Customer2TestCase: testUpdate");

        TUpdate_Return[] customers_out = customerService.update(new TUpdate_Input[]{customer_update});

        // test if update was successful
        assertEquals("create result set", 1, customers_out.length );
        assertTrue("updated?", customers_out[0].getUpdated() );
    }

   /**
    * Delete a customer and check if no error occured.
    */
   public void testDelete() throws RemoteException {
       log.info("Customer2TestCase: testDelete");

       TDelete_Return[] customers_out = customerService.delete(new String[]{path});

       // test if update was successful
       assertEquals("create result set", 1, customers_out.length );
       assertTrue("deleted?", customers_out[0].getDeleted() );
   }

    /**
     * Retrieve information about an customer. Check if the returned data are equal to
     * the data of create or update call
     *
     * @param isAlreadyUpdated if true check against update data, else against create data
     */
    public void testGetInfo(String testUpdated) throws RemoteException {
        log.info("Customer2TestCase: testGetInfo("+testUpdated+")");
        boolean isAlreadyUpdated = testUpdated.equalsIgnoreCase("updated");

        TGetInfo_Return[] customers_out = customerService.getInfo(
            new String[]{path},
            new String[]{"Comment"}
        );

        // test if getinfo was successful and if all data are equal to input
        assertEquals("getinfo result set", 1, customers_out.length );

        // define vars for easy access
        TGetInfo_Return customer_out    = customers_out[0];
        TAttribute[]  attr_out          = customer_out.getAttributes();
        TAttribute[]  attr_in           = customer_in.getAttributes();
        TAddress bill_out          = customer_out.getBillingAddress(); 
        TAddress bill_in           = customer_in.getBillingAddress(); 

        // check general data
        assertEquals("Alias", alias, customer_out.getAlias());
        assertEquals("CustomerGroup", customer_in.getCustomerGroup(), customer_out.getCustomerGroup());
        assertEquals("TaxArea",       customer_in.getTaxArea()      , customer_out.getTaxArea()      );
        assertEquals("TaxModel",      customer_in.getTaxModel()     , customer_out.getTaxModel()     );
        // customer attribute CurrencyID is obsolete
        // assertEquals("CurrencyID",    customer_in.getCurrencyID()   , customer_out.getCurrencyID()   );
        
        // check if data created and not changed
        assertEquals("Birthday",    bill_in.getBirthday().getTime(), bill_out.getBirthday().getTime() );

        if (isAlreadyUpdated) {
            attr_in = customer_update.getAttributes();
            bill_in = customer_update.getBillingAddress();
        }
        
        // check updated/created data
        assertEquals("Comment",   attr_in[0].getValue(), attr_out[0].getValue()  );
        assertEquals("FirstName", bill_in.getFirstName(), bill_out.getFirstName());
        assertEquals("LastName",  bill_in.getLastName() , bill_out.getLastName() );
        assertEquals("Street",    bill_in.getStreet()   , bill_out.getStreet()   );
        assertEquals("Street2",   bill_in.getStreet2()  , bill_out.getStreet2()  );
    }

    /**
     * Test if a customer exists or not
     * @param expected if false the Test will be successful if the customer does NOT exist
     */
    public void testExists(boolean expected) throws RemoteException {
        log.info("Customer2TestCase: testExists("+(expected?"true":"false")+")");

        TExists_Return[] customers_out = customerService.exists(new String[]{path}); 

        // test if exists check was successful
        assertEquals("exists result set", 1, customers_out.length );
        assertEquals("exists?", new Boolean(expected), customers_out[0].getExists() );
    }

    /**
     * Test if a customer is found by EMail
     */
    public void testFind() throws RemoteException {
        log.info("Customer2TestCase: testFind");

    	TFind_Input find_in = new TFind_Input();
    	find_in.setEMail(email);
        String[] customers_out = customerService.find(find_in);

        // test if find was successful
        assertEquals("find result set", 1, customers_out.length );
        assertEquals("found path", path, customers_out[0] );
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
        testGetInfo("");
        testUpdate();
        testGetInfo("updated");
        testDelete();
        testExists(false);
    }
}