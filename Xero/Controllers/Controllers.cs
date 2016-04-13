
using System;
using System.Collections.Generic;
using System.Web.Http;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using GD.Links.Xero.Services;


namespace GD.Links.Xero.Controllers
{

    public class AccountsController : ApiController
    {
        private readonly IApiService _service;

        public AccountsController(IApiService service)
        {
            _service = service;
        }

        // PUT: api/Accounts
        public Account Put(Account account)
        {
            return _service.Api.Accounts.Update(account);
        }

        // POST: api/Accounts
        public Account Post(Account account)
        {
            return _service.Api.Accounts.Create(account);
        }


        // GET: api/Accounts
        public IEnumerable<Account> Get()
        {
            return _service.Api.Accounts.Find();
        }


        // GET: api/Accounts
        public Account Get(Guid id)
        {
            return _service.Api.Accounts.Find(id);
        }



    }

    public class BankTransactionsController : ApiController
    {
        private readonly IApiService _service;

        public BankTransactionsController(IApiService service)
        {
            _service = service;
        }

        // PUT: api/BankTransactions
        public BankTransaction Put(BankTransaction bankTransaction)
        {
            return _service.Api.BankTransactions.Update(bankTransaction);
        }

        // POST: api/BankTransactions
        public BankTransaction Post(BankTransaction bankTransaction)
        {
            return _service.Api.BankTransactions.Create(bankTransaction);
        }


        // GET: api/BankTransactions
        public IEnumerable<BankTransaction> Get()
        {
            return _service.Api.BankTransactions.Find();
        }

        // GET: api/BankTransactions
        public BankTransaction Get(Guid id)
        {
            return _service.Api.BankTransactions.Find(id);
        }
    }

    public class BankTransfersController : ApiController
    {
        private readonly IApiService _service;

        public BankTransfersController(IApiService service)
        {
            _service = service;
        }



        // POST: api/BankTransfers
        public BankTransfer Post(BankTransfer bankTransfer)
        {
            return _service.Api.BankTransfers.Create(bankTransfer);
        }


        // GET: api/BankTransfers
        public IEnumerable<BankTransfer> Get()
        {
            return _service.Api.BankTransfers.Find();
        }


        // GET: api/BankTransfers
        public BankTransfer Get(Guid id)
        {
            return _service.Api.BankTransfers.Find(id);
        }

    }

    public class ContactsController : ApiController
    {
        private readonly IApiService _service;

        public ContactsController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Contacts
        public Contact Put(Contact contact)
        {
            return _service.Api.Contacts.Update(contact);
        }


        // POST: api/Contacts
        public Contact Post(Contact contact)
        {
            return _service.Api.Contacts.Create(contact);
        }


        // GET: api/Contacts
        public IEnumerable<Contact> Get()
        {
            return _service.Api.Contacts.Find();
        }


        // GET: api/Contacts
        public Contact Get(Guid id)
        {
            return _service.Api.Contacts.Find(id);
        }

    }

    public class ContactGroupsController : ApiController
    {
        private readonly IApiService _service;

        public ContactGroupsController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/ContactGroups
        public ContactGroup Put(ContactGroup contactGroup)
        {
            return _service.Api.ContactGroups.Update(contactGroup);
        }


        // POST: api/ContactGroups
        public ContactGroup Post(ContactGroup contactGroup)
        {
            return _service.Api.ContactGroups.Create(contactGroup);
        }


        // GET: api/ContactGroups
        public IEnumerable<ContactGroup> Get()
        {
            return _service.Api.ContactGroups.Find();
        }


        // GET: api/ContactGroups
        public ContactGroup Get(Guid id)
        {
            return _service.Api.ContactGroups.Find(id);
        }

    }

    public class CreditNotesController : ApiController
    {
        private readonly IApiService _service;

        public CreditNotesController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/CreditNotes
        public CreditNote Put(CreditNote creditNote)
        {
            return _service.Api.CreditNotes.Update(creditNote);
        }


        // POST: api/CreditNotes
        public CreditNote Post(CreditNote creditNote)
        {
            return _service.Api.CreditNotes.Create(creditNote);
        }


        // GET: api/CreditNotes
        public IEnumerable<CreditNote> Get()
        {
            return _service.Api.CreditNotes.Find();
        }


        // GET: api/CreditNotes
        public CreditNote Get(Guid id)
        {
            return _service.Api.CreditNotes.Find(id);
        }

    }

    public class EmployeesController : ApiController
    {
        private readonly IApiService _service;

        public EmployeesController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Employees
        public Employee Put(Employee employee)
        {
            return _service.Api.Employees.Update(employee);
        }


        // POST: api/Employees
        public Employee Post(Employee employee)
        {
            return _service.Api.Employees.Create(employee);
        }


        // GET: api/Employees
        public IEnumerable<Employee> Get()
        {
            return _service.Api.Employees.Find();
        }


        // GET: api/Employees
        public Employee Get(Guid id)
        {
            return _service.Api.Employees.Find(id);
        }

    }

    public class ExpenseClaimsController : ApiController
    {
        private readonly IApiService _service;

        public ExpenseClaimsController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/ExpenseClaims
        public ExpenseClaim Put(ExpenseClaim expenseClaim)
        {
            return _service.Api.ExpenseClaims.Update(expenseClaim);
        }


        // POST: api/ExpenseClaims
        public ExpenseClaim Post(ExpenseClaim expenseClaim)
        {
            return _service.Api.ExpenseClaims.Create(expenseClaim);
        }


        // GET: api/ExpenseClaims
        public IEnumerable<ExpenseClaim> Get()
        {
            return _service.Api.ExpenseClaims.Find();
        }


        // GET: api/ExpenseClaims
        public ExpenseClaim Get(Guid id)
        {
            return _service.Api.ExpenseClaims.Find(id);
        }

    }

    public class FilesController : ApiController
    {
        private readonly IApiService _service;

        public FilesController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Files
        public File Put(File file)
        {
            return _service.Api.Files.Update(file);
        }


        // POST: api/Files
        public File Post(File file)
        {
            return _service.Api.Files.Create(file);
        }


        // GET: api/Folders
        public File Get(Guid id)
        {
            return _service.Api.Files.Find(id);
        }

        public File Delete(Guid id)
        {
            return _service.Api.Files.Remove(id);
        }
    }

    public class FoldersController : ApiController
    {
        private readonly IApiService _service;

        public FoldersController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Folders
        public Folder Put(Folder folder)
        {
            return _service.Api.Folders.Update(folder);
        }


        // POST: api/Folders
        public Folder Post(Folder folder)
        {
            return _service.Api.Folders.Create(folder);
        }


        // GET: api/Folders
        public Folder Get(Guid id)
        {
            return _service.Api.Folders.Find(id);
        }

        public void Delete(Guid id)
        {
            _service.Api.Folders.Remove(id);
        }
    }

    public class InboxController : ApiController
    {
        private readonly IApiService _service;

        public InboxController(IApiService service)
        {
            _service = service;
        }


        // GET: api/Inbox
        public Folder Get(Guid id)
        {
            return _service.Api.Inbox.Find(id);
        }


        // PUT: api/Inbox
        public Folder Put(Folder folder)
        {
            return _service.Api.Inbox.Update(folder);
        }


        // POST: api/Inbox
        public Folder Post(Folder folder)
        {
            return _service.Api.Inbox.Create(folder);
        }


        // GET: api/Inbox
        public IEnumerable<Folder> Get()
        {
            return _service.Api.Inbox.Find();
        }


        public FilesResponse Delete(Guid id)
        {
            return _service.Api.Inbox.Remove(id);
        }

    }

    public class InvoicesController : ApiController
    {
        private readonly IApiService _service;

        public InvoicesController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Invoices
        public Invoice Put(Invoice invoice)
        {
            return _service.Api.Invoices.Update(invoice);
        }


        // POST: api/Invoices
        public Invoice Post(Invoice invoice)
        {
            return _service.Api.Invoices.Create(invoice);
        }


        // GET: api/Invoices
        public IEnumerable<Invoice> Get()
        {
            return _service.Api.Invoices.Find();
        }


        // GET: api/Invoices
        public Invoice Get(Guid id)
        {
            return _service.Api.Invoices.Find(id);
        }

    }

    public class ItemsController : ApiController
    {
        private readonly IApiService _service;

        public ItemsController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Items
        public Item Put(Item item)
        {
            return _service.Api.Items.Update(item);
        }


        // POST: api/Items
        public Item Post(Item item)
        {
            return _service.Api.Items.Create(item);
        }


        // GET: api/Items
        public IEnumerable<Item> Get()
        {
            return _service.Api.Items.Find();
        }


        // GET: api/Items
        public Item Get(Guid id)
        {
            return _service.Api.Items.Find(id);
        }

    }

    public class ManualJournalsController : ApiController
    {
        private readonly IApiService _service;

        public ManualJournalsController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/ManualJournals
        public ManualJournal Put(ManualJournal manualJournal)
        {
            return _service.Api.ManualJournals.Update(manualJournal);
        }


        // POST: api/ManualJournals
        public ManualJournal Post(ManualJournal manualJournal)
        {
            return _service.Api.ManualJournals.Create(manualJournal);
        }


        // GET: api/ManualJournals
        public IEnumerable<ManualJournal> Get()
        {
            return _service.Api.ManualJournals.Find();
        }


        // GET: api/ManualJournals
        public ManualJournal Get(Guid id)
        {
            return _service.Api.ManualJournals.Find(id);
        }

    }

    public class PaymentsController : ApiController
    {
        private readonly IApiService _service;

        public PaymentsController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Payments
        public Payment Put(Payment payment)
        {
            return _service.Api.Payments.Update(payment);
        }


        // POST: api/Payments
        public Payment Post(Payment payment)
        {
            return _service.Api.Payments.Create(payment);
        }


        // GET: api/Payments
        public IEnumerable<Payment> Get()
        {
            return _service.Api.Payments.Find();
        }


        // GET: api/Payments
        public Payment Get(Guid id)
        {
            return _service.Api.Payments.Find(id);
        }

    }

    public class ReceiptsController : ApiController
    {
        private readonly IApiService _service;

        public ReceiptsController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/Receipts
        public Receipt Put(Receipt receipt)
        {
            return _service.Api.Receipts.Update(receipt);
        }


        // POST: api/Receipts
        public Receipt Post(Receipt receipt)
        {
            return _service.Api.Receipts.Create(receipt);
        }


        // GET: api/Receipts
        public IEnumerable<Receipt> Get()
        {
            return _service.Api.Receipts.Find();
        }


        // GET: api/Receipts
        public Receipt Get(Guid id)
        {
            return _service.Api.Receipts.Find(id);
        }

    }

    public class TaxRatesController : ApiController
    {
        private readonly IApiService _service;

        public TaxRatesController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/TaxRates
        public TaxRate Put(TaxRate taxRate)
        {
            return _service.Api.TaxRates.Update(taxRate);
        }


        // POST: api/TaxRates
        public TaxRate Post(TaxRate taxRate)
        {
            return _service.Api.TaxRates.Create(taxRate);
        }


        // GET: api/TaxRates
        public IEnumerable<TaxRate> Get()
        {
            return _service.Api.TaxRates.Find();
        }


        // GET: api/TaxRates
        public TaxRate Get(Guid id)
        {
            return _service.Api.TaxRates.Find(id);
        }

    }

    public class TrackingCategoriesController : ApiController
    {
        private readonly IApiService _service;

        public TrackingCategoriesController(IApiService service)
        {
            _service = service;
        }


        // PUT: api/TrackingCategories
        public TrackingCategory Put(TrackingCategory trackingCategory)
        {
            return _service.Api.TrackingCategories.Update(trackingCategory);
        }


        // POST: api/TrackingCategories
        public TrackingCategory Post(TrackingCategory trackingCategory)
        {
            return _service.Api.TrackingCategories.Create(trackingCategory);
        }


        // GET: api/TrackingCategories
        public IEnumerable<TrackingCategory> Get()
        {
            return _service.Api.TrackingCategories.Find();
        }


        // GET: api/TrackingCategories
        public TrackingCategory Get(Guid id)
        {
            return _service.Api.TrackingCategories.Find(id);
        }

    }
}